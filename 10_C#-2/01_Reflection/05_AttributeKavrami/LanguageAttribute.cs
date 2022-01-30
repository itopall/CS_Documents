using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_AttributeKavrami
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Struct)]
    class LanguageAttribute : Attribute
    {
        public string Name { get; set; }

        public LanguageAttribute(string name)
        {
            Name = name;
        }
    }
}
