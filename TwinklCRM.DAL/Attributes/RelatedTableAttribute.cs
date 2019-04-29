using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinklCRM.DAL.Attributes
{
    public class RelatedTableAttribute : Attribute
    {
        public Type RelatedDictionaryType;

        public RelatedTableAttribute(Type relatedDictionaryType)
        {
            RelatedDictionaryType = relatedDictionaryType;
        }
    }

}
