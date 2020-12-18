using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Markup;

namespace AutoClicker
{
    public class EnumBindingSourceEx : MarkupExtension
    {
        public Type EnumType { get; private set; }

        public EnumBindingSourceEx(Type enumType)
        {
            if (enumType is null || !enumType.IsEnum)
            {
                throw new Exception("EnumType must not be null and must of type Enum");
            }

            EnumType = enumType;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return Enum.GetValues(EnumType);
        }
    }
}
