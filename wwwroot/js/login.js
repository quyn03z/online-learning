document.addEventListener("DOMContentLoaded", function () {
    let container = document.getElementById("container");
    let activeForm = container.dataset.activeForm; // Đọc từ dataset

    // Kiểm tra trạng thái form từ dữ liệu của ViewData
    if (activeForm === "signup") {
        container.classList.add("right-panel-active");
    } else {
        container.classList.remove("right-panel-active");
    }

    // Xử lý khi nhấn Sign Up
    document.getElementById("signUp").addEventListener("click", function () {
        container.classList.add("right-panel-active");
    });

    // Xử lý khi nhấn Sign In
    document.getElementById("signIn").addEventListener("click", function () {
        container.classList.remove("right-panel-active");
    });
});
