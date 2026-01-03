using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CR_GR__Helper.Models
{
    // Student Entity
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = "";

        [Required]
        [StringLength(50)]
        public string RegistrationNo { get; set; } = "";

        [Required]
        [EmailAddress]
        public string Email { get; set; } = "";


        [Phone]
        public string PhoneNo { get; set; } = "";


        [Range(0, 4)]
        public decimal CGPA { get; set; }

        public string? Class { get; set; } 

    }

    // Teacher Entity
    public class Teacher
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Phone]
        public string? PhoneNo { get; set; }

        [StringLength(100)]
        public string? Department { get; set; }


        public bool IsActive { get; set; } = true;

        public string? Subjects { get; set; }
    }

    // Class Entity
    //public class Class
    //{
    //    [Key]
    //    public int Id { get; set; }

    //    public string? ClassName { get; set; }

    //    [Required]
    //    [StringLength(10)]
    //    public string? Section { get; set; }

    //    [StringLength(100)]
    //    public string? Program { get; set; }

    //    public int Semester { get; set; }

    //    public string? CR { get; set; }
    //    public string? GR { get; set; }

    //}

    public class Complain
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public string? Description { get; set; }

        public string? ComplainantName { get; set; }

        public string? ComplainantEmail { get; set; }

        public string? ComplainantPhone { get; set; }

        public DateTime SubmittedDate { get; set; } = DateTime.Now;

        [Required]
        public string Status { get; set; } = "Pending"; // Pending, In Progress, Resolved, Closed

        public string? Category { get; set; } // e.g., "Academic", "Infrastructure", "Administration", "Other"

        public DateTime? ResolvedDate { get; set; } = DateTime.Now;

        public string? Priority { get; set; } = "Medium"; // Low, Medium, High, Critical
    }
}
