using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Function3.Models
{
    public class MedicalCard
    {
        /// <summary>
        /// Код мед.карты
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Код пациента
        /// </summary>
        [Column("IdPatient")]
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }
        /// <summary>
        /// Информация о пциенте
        /// </summary>
        public string Inforamtion { get; set; }
        /// <summary>
        /// Симптомы
        /// </summary>
        public string Symptoms { get; set; }
        /// <summary>
        /// Диагноз 
        /// </summary>
        public string Diagnosis { get; set; }
        /// <summary>
        /// Рекомендации по лечению
        /// </summary>
        public string TreatmentRecom { get; set; }
        /// <summary>
        /// Рецепты
        /// </summary>
        public string Recipes { get; set; }
        /// <summary>
        /// НАправления к специалистам
        /// </summary>
        public string DirectionSpecialist { get; set; }
        /// <summary>
        /// Исследования
        /// </summary>
        public string Research { get; set; }
        /// <summary>
        /// Процедуры
        /// </summary>
        public string Procedures { get; set; }
    }
}
