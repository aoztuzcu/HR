using System.ComponentModel.DataAnnotations;

namespace HR.Presentation.Models
{
    public static class EnumHelper
    {
        public static string GetDisplayName(Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var displayAttribute = (DisplayAttribute)Attribute.GetCustomAttribute(field, typeof(DisplayAttribute));

            return displayAttribute?.Name ?? value.ToString();
        }
    }
}
