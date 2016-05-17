namespace WebAppMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("eclaimlinkportal.users")]
    public partial class user
    {
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string Username { get; set; }

        [StringLength(100)]
        public string ApplicationName { get; set; }

        [Required]
        [StringLength(128)]
        public string Email { get; set; }

        [StringLength(255)]
        public string Comment { get; set; }

        [Required]
        [StringLength(128)]
        public string Password { get; set; }

        [StringLength(255)]
        public string PasswordQuestion { get; set; }

        [StringLength(255)]
        public string PasswordAnswer { get; set; }

        public bool? IsApproved { get; set; }

        public DateTime? LastActivityDate { get; set; }

        public DateTime? LastLoginDate { get; set; }

        public DateTime? LastPasswordChangedDate { get; set; }

        public DateTime? CreationDate { get; set; }

        public bool? IsOnLine { get; set; }

        public bool? IsLockedOut { get; set; }

        public DateTime? LastLockedOutDate { get; set; }

        public int? FailedPasswordAttemptCount { get; set; }

        public DateTime? FailedPasswordAttemptWindowStart { get; set; }

        public int? FailedPasswordAnswerAttemptCount { get; set; }

        public DateTime? FailedPasswordAnswerAttemptWindowStart { get; set; }

        public bool? IsAnonymous { get; set; }

        public int? FacilityId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public int? UserType { get; set; }

        public int? userRole { get; set; }

        [StringLength(50)]
        public string phone { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        public bool? validated { get; set; }

        public int? groupId { get; set; }

        [StringLength(50)]
        public string LoginKey { get; set; }

        public bool? demo { get; set; }

        public int? Agree { get; set; }

        public DateTime? AgreemantDate { get; set; }

        [StringLength(35)]
        public string mobilePassword { get; set; }

        [StringLength(500)]
        public string ipwhitelist { get; set; }
    }
}
