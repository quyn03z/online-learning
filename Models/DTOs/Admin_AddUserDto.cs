﻿using OnlineLearning.Attribute;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineLearning.Models.DTOs
{
    public class Admin_AddUserDto
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Full name is required.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Full name must be between 2 and 100 characters.")]
        public string? Fullname { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [RegularExpression(@"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$", ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression(@"^(0[3|5|7|8|9])[0-9]{8}$", ErrorMessage = "Phone number must follow Vietnamese format (e.g., 0912345678).")]
        public string? Phone { get; set; }

        [NotMapped]
        [FileValidation(ErrorMessage = "Image file must be .jpg, .jpeg, or .png and not exceed 5MB.")]
        public IFormFile Avatar { get; set; }
        public string Avatar_str { get; set; } = "";

        [Required(ErrorMessage = "Gender is required.")]
        public bool? Gender { get; set; }

        [Required(ErrorMessage = "Date of birth is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [PastDate(ErrorMessage = "Date of birth must be in the past.")]
        public DateOnly? Dob { get; set; }

        [Required(ErrorMessage = "Role is required.")]
        [Range(1, 3, ErrorMessage = "Role must be Admin (1), Mentor (2), or Mentee (3).")]
        public int RoleId { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be between 8 and 100 characters.")]
        [RegularExpression(@"^(?=.*[0-9])(?=.*[!@#$%^&*(){}[\]_\-+=~`|:;""'<>,.?])(?=.*[a-z])(?=.*[A-Z]).{8,}$",
            ErrorMessage = "Password must contain uppercase (A-Z), lowercase (a-z), number (0-9), and a special character.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm password is required.")]
        [Compare("Password", ErrorMessage = "Confirm password does not match.")]
        [RegularExpression(@"^(?=.*[0-9])(?=.*[!@#$%^&*(){}[\]_\-+=~`|:;""'<>,.?])(?=.*[a-z])(?=.*[A-Z]).{8,}$",
            ErrorMessage = "Confirm password must contain uppercase (A-Z), lowercase (a-z), number (0-9), and a special character.")]
        [DataType(DataType.Password)]
        public string RePassword { get; set; }
    }
}

