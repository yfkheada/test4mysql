namespace WebAppMVC.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Microsoft.Extensions.Configuration;
    using WebApplication2.Controllers;
    [DbConfigurationType(typeof(MyDbConfiguration))]
    public partial class Users : DbContext
    {
        public Users(IConfiguration config)
            : base(config.Get<string>("Data:Users:ConnectionString"))
        {
        }

        public virtual DbSet<user> users2 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<user>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.ApplicationName)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.PasswordQuestion)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.PasswordAnswer)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.LastActivityDate)
                .HasPrecision(6);

            modelBuilder.Entity<user>()
                .Property(e => e.LastLoginDate)
                .HasPrecision(6);

            modelBuilder.Entity<user>()
                .Property(e => e.LastPasswordChangedDate)
                .HasPrecision(6);

            modelBuilder.Entity<user>()
                .Property(e => e.CreationDate)
                .HasPrecision(6);

            modelBuilder.Entity<user>()
                .Property(e => e.LastLockedOutDate)
                .HasPrecision(6);

            modelBuilder.Entity<user>()
                .Property(e => e.FailedPasswordAttemptWindowStart)
                .HasPrecision(6);

            modelBuilder.Entity<user>()
                .Property(e => e.FailedPasswordAnswerAttemptWindowStart)
                .HasPrecision(6);

            modelBuilder.Entity<user>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.LoginKey)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.AgreemantDate)
                .HasPrecision(6);

            modelBuilder.Entity<user>()
                .Property(e => e.mobilePassword)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.ipwhitelist)
                .IsUnicode(false);
        }
    }
}
