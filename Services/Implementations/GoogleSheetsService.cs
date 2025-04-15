using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Sheets.v4;
using Microsoft.Extensions.Options;
using OnlineLearning.Models.DTOs;
using OnlineLearning.Services.Interfaces;

namespace OnlineLearning.Services.Implementations
{
    public class GoogleSheetsService : IGoogleSheetsService
    {
        private readonly GoogleSheetsSettings _settings;

        public GoogleSheetsService(IOptions<GoogleSheetsSettings> settings)
        {
            _settings = settings.Value;
        }
        public async Task UpdateRevenueAsync(RevenueDto revenue)
        {

            var credential = GoogleCredential.FromFile(_settings.CredentialsPath)
                .CreateScoped(SheetsService.Scope.Spreadsheets);

            var service = new SheetsService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = "CourseRevenueDashboard"
            });

            var range = $"{_settings.SheetName}!A:D";
            var request = service.Spreadsheets.Values.Get(_settings.SpreadsheetId, range);
            var response = await request.ExecuteAsync();
            var rowCount = response.Values?.Count ?? 0;

            if (rowCount == 0)
            {
                var headerRange = new ValueRange
                {
                    Values = new List<IList<object>>
                    {
                        new List<object> { "Date", "Daily Revenue", "Monthly Revenue", "Yearly Revenue" }
                    }
                };
                var headerRequest = service.Spreadsheets.Values.Update(headerRange, _settings.SpreadsheetId, $"{_settings.SheetName}!A1:D1");
                headerRequest.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.USERENTERED;
                await headerRequest.ExecuteAsync();
                rowCount = 1;
            }

            var newRow = rowCount + 1;
            var valueRange = new ValueRange
            {
                Values = new List<IList<object>>
                {
                    new List<object> { DateTime.UtcNow.ToString("yyyy-MM-dd"), revenue.DailyRevenue, revenue.MonthlyRevenue, revenue.YearlyRevenue }
                }
            };

            var updateRange = $"{_settings.SheetName}!A{newRow}:D{newRow}";
            var updateRequest = service.Spreadsheets.Values.Update(valueRange, _settings.SpreadsheetId, updateRange);
            updateRequest.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.USERENTERED;
            await updateRequest.ExecuteAsync();
        }


    }
}
