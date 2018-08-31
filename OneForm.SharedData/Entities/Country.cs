using OneForm.SharedData.Context;

namespace OneForm.SharedData.Entities
{
    /// <summary>
    /// Страта
    /// </summary>
    public class Country : BaseEntity
    {
        /// <summary>
        /// Наименование на русском
        /// </summary>
        public string NameRu { get; set; }

        /// <summary>
        /// Наименование на английском
        /// </summary>
        public string NameEn { get; set; }
    }
}