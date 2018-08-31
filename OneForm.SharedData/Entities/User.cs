using System;
using OneForm.SharedData.Context;
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
        public string FullName { get; set; }

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

        /// <summary>
        /// Страна
        /// </summary>
        public Country Country { get; set; }
    }
}