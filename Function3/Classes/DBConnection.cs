using Function3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Function3.Classes
{
    public class DBConnection : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> DoctorsRus { get; set; }
        public DbSet<MedicalCard> MedicalCardsRus { get; set; }

        public DBConnection()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=student.permaviat.ru;Trusted_Connection=No;DataBase=base2_ISP_21_2_19;User=ISP_21_2_19;PWD=D17IDNLg4#;");

        }
    }
}
