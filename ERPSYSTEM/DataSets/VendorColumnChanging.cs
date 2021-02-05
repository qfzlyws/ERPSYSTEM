using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSYSTEM.DataSets
{
    public partial class PUR
    {
        public partial class CVENDORMDataTable
        {
           public override void BeginInit()
            {
                this.ColumnChanged += ValidateColumn;
            }

            void ValidateColumn(object sender, System.Data.DataColumnChangeEventArgs e)
            {
                if(e.Column.Equals(this.TRA_FACTColumn))
                {
                    if(!Convert.IsDBNull(e.ProposedValue) &&
                        (string)e.ProposedValue != "N")
                    {
                        throw new ArgumentException("轉廠注記必需為N!");
                    }
                }
            }
        }
    }
}
