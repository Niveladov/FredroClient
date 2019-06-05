using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TwinklCRM.DAL.Attributes;

namespace TwinklCRM.DAL.Extensions
{
    public static class Extensions
    {
        public static Type GetDictionaryTypeByAttr(this PropertyInfo dataSourceProp)
        {
            Type result = null;
            if (dataSourceProp != null)
            {
                var relatedTableAttr = (RelatedTableAttribute)dataSourceProp.GetCustomAttributes(typeof(RelatedTableAttribute), true).FirstOrDefault();
                if (relatedTableAttr != null)
                {
                    result = relatedTableAttr.RelatedDictionaryType;
                }
            }
            return result;
        }

        public static string GetFieldCaptionByAttr(this PropertyInfo dataSourceProp)
        {
            string result = "";
            if (dataSourceProp != null)
            {
                var displayNameAttr = (DisplayNameAttribute)dataSourceProp.GetCustomAttributes(typeof(DisplayNameAttribute), true).FirstOrDefault();
                if (displayNameAttr != null && !string.IsNullOrEmpty(displayNameAttr.DisplayName))
                {
                    result = displayNameAttr.DisplayName;
                }
            }
            return result;
        }

    }
}
