using System;
using System.Collections.Generic;
using System.Text;

namespace Function3.Models
{
    public class Doctor
    {
        /// <summary>
        /// Код врача
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Логин врача
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Пароль врача
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Должность врача
        /// </summary>
        public string Position { get; set; }
    }
}
