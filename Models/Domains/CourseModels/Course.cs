﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using OnlineLearning.Enums;
using OnlineLearning.Models.Domains.CourseModels.CategoryModels;
using OnlineLearning.Models.Domains.UserModels;
using OnlineLearning.Models.Domains.Miscellaneous;

namespace OnlineLearning.Models.Domains.CourseModels
{
    public class Course
    {
        [Key]
        public long CourseId { get; set; }

        [Required]
        [StringLength(255)]
        public string CourseName { get; set; } = null!;

        public string? Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Discount { get; set; }

        [Required]
        public long Creator { get; set; }

        public long? Acceptor { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? UpdatedAt { get; set; }

        public DateTime? PublishedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        [StringLength(50)]
        public string? StudyTime { get; set; }

        public long? LanguageId { get; set; }

        public long? LevelId { get; set; }

        [Required]
        public CourseStatus Status { get; set; } = CourseStatus.Draft;

        [ForeignKey("Creator")]
        public virtual User CreatorUser { get; set; } = null!;

        [ForeignKey("Acceptor")]
        public virtual User? AcceptorUser { get; set; }

        public virtual Language? Language { get; set; }
        public virtual Level? Level { get; set; }
        public virtual ICollection<CourseImageUrl> CourseImageUrls { get; set; } = new List<CourseImageUrl>();
        public virtual ICollection<CourseCategory> CourseCategories { get; set; } = new List<CourseCategory>();
        public virtual ICollection<Module> Modules { get; set; } = new List<Module>();
        public virtual ICollection<Certificate> Certificates { get; set; } = new List<Certificate>();
        public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();

    }
}
