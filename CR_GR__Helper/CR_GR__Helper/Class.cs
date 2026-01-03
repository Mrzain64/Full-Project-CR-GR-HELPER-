using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;

namespace CR_GR__Helper.Models
{
    public class Classes
    {
        [Key]
        public int Id { get; set; }

        public string? ClassName { get; set; }

        [Required]
        [StringLength(10)]
        public string? Section { get; set; }

        [StringLength(100)]
        public string? Program { get; set; }

        public int Semester { get; set; }

        public string? CR { get; set; }
        public string? GR { get; set; }

    }

    // Subject Entity
    public class Subject
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? SubjectName { get; set; }
        public int CreditHours { get; set; }

        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
        public bool IsActive { get; set; } = true;
    }
    public class CR_GR
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Registration_No { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Contact_number { get; set; }
    }

    // Attendance Entity
    public class Attendance
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public int? StudentId { get; set; }

        public string? SubjectId { get; set; }

        [Required]
        [StringLength(10)]
        public string? Status { get; set; } // Present, Absent, Leave

        public string? Remarks { get; set; }
    }

    // Announcement Entity
    public class Alert
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string? Title { get; set; }

        [Required]
        public string? Description { get; set; }

        public string? Posted_By { get; set; }

        public DateTime PostedDate { get; set; } = DateTime.Now;

        public bool IsUrgent { get; set; } = false;

        public DateTime? ExpiryDate { get; set; }
    }

}
