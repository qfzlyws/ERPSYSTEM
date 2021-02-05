using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERPSYSTEM.DataSets;
using ERPSYSTEM.DataSets.PURTableAdapters;

namespace ERPSYSTEM.BLL
{
    public class VendorBLL
    {
        private CVENDORMTableAdapter tba;

        public VendorBLL()
        {
            tba = new CVENDORMTableAdapter();
        }

        public PUR.CVENDORMDataTable GetVendors()
        {
            return tba.GetVendors();
        }

        public PUR.CVENDORMDataTable GetVendorById(string vendNo)
        {
            return tba.GetVendorById(vendNo);
        }

        public void UpdateVendors(PUR.CVENDORMDataTable vendorTable)
        {
            tba.Update(vendorTable);
        }
    }
}
