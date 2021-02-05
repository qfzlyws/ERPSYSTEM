using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSYSTEM.DataSets
{
    public class VendKind
    {
        private string kind;
        private string name;

        public VendKind(string kind,string name)
        {
            Name = name;
            Kind = kind;
        }

        public string Kind
        { get
            {
                return kind;
            }

            set
            {
                kind = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }
}
