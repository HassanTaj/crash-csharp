
using System.ComponentModel;

namespace OnlineShop.Extensions {
    public static class EnumExtensions {
        public static string GetDescription(this Enum value) {
            if (value == null) { return ""; }

            DescriptionAttribute? attribute = value.GetType()
                    .GetField(value.ToString())
                    ?.GetCustomAttributes(typeof(DescriptionAttribute), false)
                    .SingleOrDefault() as DescriptionAttribute;
            return attribute == null ? value.ToString() : attribute.Description;
        }
    }
}
