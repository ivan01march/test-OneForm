using System;
using System.ComponentModel.DataAnnotations.Schema;
using OneForm.SharedData.Primitives;

namespace OneForm.SharedData.Entities
{
    public partial class User : BaseEntity
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Полное имя
        /// </summary>
        public virtual string FullName => $"{FirstName} {LastName}";

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Пол
        /// </summary>
        public Sex Sex { get; set; }

        /// <summary>
        /// Имеется ли собственная машина
        /// </summary>
        public bool HasVehicle { get; set; }

        public int CountryId { get; set; }

        /// <summary>
        /// Страна
        /// </summary>
        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }
    }
}