

function toggleSubmitButton() {

    const fullNameError = document.getElementById("fullNameError").textContent;
    const emailError = document.getElementById("emailError").textContent;
    const phoneError = document.getElementById("phoneError").textContent;
    const passwordError = document.getElementById("passwordError").textContent;
    const confirmPasswordError = document.getElementById("confirmPasswordError").textContent;
    const genderError = document.getElementById("genderError").textContent;
    const dobError = document.getElementById("dobError").textContent;
    const roleError = document.getElementById("roleError").textContent;

    const submitButton = document.getElementById("submitButton");
    if (fullNameError === "" && emailError === "" && phoneError === "" &&
        passwordError === "" && confirmPasswordError === "" &&
        genderError === "" && dobError === "" && roleError === "") {
        submitButton.disabled = false;
    } else {
        submitButton.disabled = true;
    }


}



// Gọi lại `toggleSubmitButton` trong từng hàm kiểm tra


function validateFullName() {
    const fullName = document.getElementById("fullName").value;
    const fullNameError = document.getElementById("fullNameError");
    const fullNameInput = document.getElementById("fullName");

    if (fullName.trim().length < 2) {
        fullNameError.textContent = "Full name must be at least 2 characters.";
        fullNameInput.classList.remove("is-valid");
        fullNameInput.classList.add("is-invalid");
    } else {
        fullNameError.textContent = "";
        fullNameInput.classList.remove("is-invalid");
        fullNameInput.classList.add("is-valid");
    }
    toggleSubmitButton();
}

function validateEmail() {
    const email = document.getElementById("email").value;
    const emailError = document.getElementById("emailError");
    const emailInput = document.getElementById("email");
    const emailPattern = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$/;

    if (!emailPattern.test(email)) {
        emailError.textContent = "Please enter a valid email address.";
        emailInput.classList.remove("is-valid");
        emailInput.classList.add("is-invalid");
    } else {
        emailError.textContent = ""; // Clear error if no frontend error
        emailInput.classList.remove("is-invalid");
        emailInput.classList.add("is-valid");
    }

    toggleSubmitButton();
}
function validatePhone() {
    const phone = document.getElementById("phone").value;
    const phoneError = document.getElementById("phoneError");
    const phoneInput = document.getElementById("phone");
    const phonePattern = /^(0[3|5|7|8|9])[0-9]{8}$/; // Định dạng VN: 10 số, bắt đầu bằng 03, 05, 07, 08, 09

    if (!phonePattern.test(phone)) {
        phoneError.textContent = "Please enter a valid Vietnamese phone number (e.g., 0912345678).";
        phoneInput.classList.remove("is-valid");
        phoneInput.classList.add("is-invalid");
    } else {
        phoneError.textContent = "";
        phoneInput.classList.remove("is-invalid");
        phoneInput.classList.add("is-valid");
    }
    toggleSubmitButton();
}

function validatePassword() {
    const password = document.getElementById("password").value;
    const passwordError = document.getElementById("passwordError");
    const passwordInput = document.getElementById("password");
    const regex = /^(?=.*[0-9])(?=.*[!@#$%^&*(){}\[\]_\-+=~`|:;\"'<>,.\/?])(?=.*[a-z])(?=.*[A-Z]).{8,}$/;

    if (!regex.test(password)) {
        passwordError.textContent = "Password must have (A-Z), (a-z), (0-9), a special char, and be 8+ chars.";
        passwordInput.classList.remove("is-valid");
        passwordInput.classList.add("is-invalid");
    } else {
        passwordError.textContent = "";
        passwordInput.classList.remove("is-invalid");
        passwordInput.classList.add("is-valid");
    }

    toggleSubmitButton();
}

function validateConfirmPassword() {
    const password = document.getElementById("password").value;
    const confirmPassword = document.getElementById("re_pass").value;

    const confirmPasswordError = document.getElementById("confirmPasswordError");
    const confirmPasswordInput = document.getElementById("re_pass");
    const regex = /^(?=.*[0-9])(?=.*[!@#$%^&*(){}\[\]_\-+=~`|:;\"'<>,.\/?])(?=.*[a-z])(?=.*[A-Z]).{8,}$/;

    if (!regex.test(confirmPassword)) {
        confirmPasswordError.textContent = "Password must have (A-Z), (a-z), (0-9), a special char, and be 8+ chars.";
        confirmPasswordInput.classList.remove("is-valid");
        confirmPasswordInput.classList.add("is-invalid");
    } else if (confirmPassword !== password) {
        confirmPasswordError.textContent = "Passwords do not match.";
        confirmPasswordInput.classList.remove("is-valid");
        confirmPasswordInput.classList.add("is-invalid");
    } else {
        confirmPasswordError.textContent = "";
        confirmPasswordInput.classList.remove("is-invalid");
        confirmPasswordInput.classList.add("is-valid");
    }

    toggleSubmitButton();
}



function validateGender() {
    const gender = document.getElementById("gender").value;
    const genderError = document.getElementById("genderError");
    const genderInput = document.getElementById("gender");

    if (gender === "") {
        genderError.textContent = "Please select a gender.";
        genderInput.classList.remove("is-valid");
        genderInput.classList.add("is-invalid");
    } else {
        genderError.textContent = "";
        genderInput.classList.remove("is-invalid");
        genderInput.classList.add("is-valid");
    }
    toggleSubmitButton();
}

function validateDob() {
    const dob = document.getElementById("dob").value;
    const dobError = document.getElementById("dobError");
    const dobInput = document.getElementById("dob");
    const today = new Date();
    const selectedDate = new Date(dob);

    if (!dob) {
        dobError.textContent = "Please select a date of birth.";
        dobInput.classList.remove("is-valid");
        dobInput.classList.add("is-invalid");
    } else if (selectedDate >= today) {
        dobError.textContent = "Date of birth must be in the past.";
        dobInput.classList.remove("is-valid");
        dobInput.classList.add("is-invalid");
    } else {
        dobError.textContent = "";
        dobInput.classList.remove("is-invalid");
        dobInput.classList.add("is-valid");
    }
    toggleSubmitButton();
}

function validateRole() {
    const role = document.getElementById("role").value;
    const roleError = document.getElementById("roleError");
    const roleInput = document.getElementById("role");

    if (role === "") {
        roleError.textContent = "Please select a role.";
        roleInput.classList.remove("is-valid");
        roleInput.classList.add("is-invalid");
    } else {
        roleError.textContent = "";
        roleInput.classList.remove("is-invalid");
        roleInput.classList.add("is-valid");
    }
    toggleSubmitButton();
}

function previewAvatar() {
    const fileInput = document.getElementById("avatar");
    const preview = document.getElementById("avatarPreview");
    const avatarError = document.getElementById("avatarError");
    const file = fileInput.files[0];

    if (file) {
        // Kiểm tra định dạng file
        const validExtensions = [".jpg", ".jpeg", ".png"];
        const fileExt = file.name.substring(file.name.lastIndexOf(".")).toLowerCase();
        if (!validExtensions.includes(fileExt)) {
            avatarError.textContent = "Only JPG and PNG files are allowed.";
            preview.innerHTML = "";
            preview.style.display = "none"; // Ẩn khung nếu file không hợp lệ
            fileInput.classList.remove("is-valid");
            fileInput.classList.add("is-invalid");
        }
        // Kiểm tra kích thước file (5MB = 5 * 1024 * 1024 bytes)
        else if (file.size > 5 * 1024 * 1024) {
            avatarError.textContent = "File size must not exceed 5MB.";
            preview.innerHTML = "";
            preview.style.display = "none";
            fileInput.classList.remove("is-valid");
            fileInput.classList.add("is-invalid");
        }
        else {
            const reader = new FileReader();
            reader.onload = function (e) {
                preview.innerHTML = `<img src="${e.target.result}" alt="Avatar Preview">`;
                preview.style.display = "flex"; // Hiển thị khung khi có ảnh hợp lệ
            };
            reader.readAsDataURL(file);
            avatarError.textContent = "";
            fileInput.classList.remove("is-invalid");
            fileInput.classList.add("is-valid");
        }
    } else {
        preview.innerHTML = "";
        preview.style.display = "none";
        avatarError.textContent = "";
        fileInput.classList.remove("is-invalid");
        fileInput.classList.remove("is-valid");
    }
    toggleSubmitButton();
}

// Gọi validate ban đầu để disable nút submit
document.addEventListener("DOMContentLoaded", function () {
    toggleSubmitButton();
});