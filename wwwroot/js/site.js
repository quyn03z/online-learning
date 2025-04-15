// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//start chat bot js
$(document).ready(function () {
    // Initialize SignalR connection once
    var connection = new signalR.HubConnectionBuilder()
        .withUrl("/chatHub")
        .configureLogging(signalR.LogLevel.Information)
        .build();

    // Start the connection
    connection.start().catch(function (err) {
        console.error(err.toString());
    });

    // Set up the event handler for receiving messages once
    connection.on("ReceiveMessage", function (userId, userQuery, botResponse) {
        $("#chatbot-messages").append(`<div class="message bot-message text-start"><span>${botResponse}</span></div>`);
        // Auto-scroll to bottom
        $("#chatbot-messages").scrollTop($("#chatbot-messages")[0].scrollHeight);
    });

    // UI event handlers
    $("#chatbot-toggle").click(function () {
        $("#chatbot-box").toggle();
        $("#chatbot-messages").scrollTop($("#chatbot-messages")[0].scrollHeight);
    });

    $("#chatbot-close").click(function () {
        $("#chatbot-box").hide();
    });

    $("#chatbot-send").click(function () {
        sendMessage();
    });

    $("#chatbot-input").keypress(function (e) {
        if (e.which == 13) { // Enter key
            sendMessage();
        }
    });

    function sendMessage() {
        var userMessage = $("#chatbot-input").val().trim();
        if (userMessage === "") return;

        // Get userId from session or data attribute
        var userId = $("#chatbot-box").data("user-id") || null;

        if (userId) {
            $("#chatbot-messages").append(`<div class="message user-message"><span>${userMessage}</span></div>`);
            $("#chatbot-input").val("");

            // Auto-scroll to bottom
            $("#chatbot-messages").scrollTop($("#chatbot-messages")[0].scrollHeight);

            // Send message using the existing connection
            if (connection.state === signalR.HubConnectionState.Connected) {
                connection.invoke("SendMessage", userId, userMessage).catch(function (err) {
                    console.error(err.toString());
                    $("#chatbot-messages").append(`<div class="message bot-message-danger text-start"><span>Error sending message. Please try again.</span></div>`);
                });
            } else {
                // Attempt to reconnect if disconnected
                connection.start()
                    .then(function () {
                        connection.invoke("SendMessage", userId, userMessage);
                    })
                    .catch(function (err) {
                        console.error(err.toString());
                        $("#chatbot-messages").append(`<div class="message bot-message-danger text-start"><span>Connection lost. Please refresh the page.</span></div>`);
                    });
            }
        }
        else {
            $("#chatbot-messages").append(`<div class="message bot-message-danger text-start"><span>Please login to get AI support.</span></div>`);
            $("#chatbot-messages").append(`<div class="message bot-message-danger text-start"><span><a class="text-white" href="/login">Login now</a></span></div>`)
        }
    }
});
// end chat bot js