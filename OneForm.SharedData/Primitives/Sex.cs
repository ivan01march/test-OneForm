using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace OneForm.SharedData.Primitives
{
    /// <summary>
    /// Пол
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter), true)]
    public enum Sex
    {
        /// <summary>
        /// Мужской пол
        /// </summary>
        Male = 1,

        /// <summary>
        /// Женский пол
        /// </summary>
        Female = 2
    }
}