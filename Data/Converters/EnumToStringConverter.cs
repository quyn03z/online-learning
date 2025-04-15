using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace OnlineLearning.Data.Converters
{
    public class EnumToIntConverter<TEnum> : ValueConverter<TEnum, int> where TEnum : struct
    {
        public EnumToIntConverter() : base(
            v => (int)(object)v,
            v => (TEnum)(object)v)
        {
        }
    }
}
