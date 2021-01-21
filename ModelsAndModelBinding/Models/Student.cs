using System;
using System.ComponentModel.DataAnnotations;

namespace ModelsAndModelBinding.Models
{
    /// <summary>
    /// Represents an individual student
    /// </summary>
    public class Student
    {
        /// <summary>
        /// The unique identifier for the student
        /// </summary>
        public int StudentId { get; set; }

        /// <summary>
        /// The legal first and last name of the student
        /// </summary>
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Please enter a valid full name. Ex: John Doe")]
        public string FullName { get; set; }

        /// <summary>
        /// The day the student was born. Time is ignored
        /// </summary
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// The student email (ends with @student.cptc.edu)
        /// </summary
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [Required(ErrorMessage = "Please enter a valid email address. Ex: johndoe@student.cptc.edu")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Home phone number
        /// </summary>
        [Display(Name = "Home Phone")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Please enter a valid home phone. Ex: xxx-xxx-xxx")]
        public string PhoneNumber { get; set; }
    }
}