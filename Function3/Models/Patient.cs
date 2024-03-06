using System;
using System.Collections.Generic;
using System.Text;

namespace Function3.Models
{
    public class Patient
    {
        /// <summary>
        /// Код пациента
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string Lastname { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string Firstname { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        public string Surname { get; set; }

        public string FIO() =>
            $"{Lastname} {Firstname} {Surname}";
    }
}
