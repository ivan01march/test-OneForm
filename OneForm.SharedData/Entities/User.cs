using System;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OneForm.SharedData.Context;
using OneForm.SharedData.Primitives;

namespace OneForm.SharedData.Entities
{
    public partial class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public Sex Sex { get; set; }
        public Country Country { get; set; }
        public bool HasVehicle { get; set; }
    }
}