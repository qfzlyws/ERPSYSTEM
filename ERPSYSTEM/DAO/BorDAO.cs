using ERPSYSTEM.DataSets;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSYSTEM
{
    class BorDAO
    {
        private BOM.CBORMDataTable cborm;
        private DataSets.BOMTableAdapters.CBORMTableAdapter bormTableAdapter;

        public BorDAO(BOM.CBORMDataTable cborm, DataSets.BOMTableAdapters.CBORMTableAdapter bormTableAdapter)
        {
            this.cborm = cborm;
            this.bormTableAdapter = bormTableAdapter;
        }

        /// <summary>
        /// 新增一筆制程資料
        /// </summary>
        /// <param name="newRow">BOM.CBORMRow</param>
        public void Add(string borNo,string borNm)
        {
            DataRow newRow = cborm.NewRow();
            newRow["FACT_NO"] = "0721";
            newRow["BOR_NO"] = borNo;
            newRow["BOR_NM"] = borNm;
            newRow["PRO_KIND"] = "I";
            newRow["SFC_RMK"] = "Y";
            newRow["USER_NO"] = "CR007975";
            newRow["MODIFY_DT"] = DateTime.Now.ToString("yyyyMMddHHmmss");
            newRow["BOR_SEQ"] = "020";
            cborm.Rows.Add(newRow);
            bormTableAdapter.Update(cborm);
        }

        public void Modify(string borNo,string borNm)
        {
            DataRow[] modifiedRow = cborm.Select(string.Format("BOR_NO={0}",borNo));
            modifiedRow[0]["BOR_NM"] = borNm;
            modifiedRow[0]["MODIFY_DT"] = DateTime.Now.ToString("yyyyMMddHHmmss");
            bormTableAdapter.Update(cborm);
        }

        public void Delete(string borNo)
        {
            cborm.Select(string.Format("BOR_NO='{0}'", borNo))[0].Delete();
            //cborm.AcceptChanges();
            bormTableAdapter.Update(cborm);
        }

        public int Search(string borNo)
        {
            BOM.CBORMRow findRow = cborm.FindByFACT_NOBOR_NO(Utilities.factNo,borNo);
   
            return cborm.Rows.IndexOf(findRow);
        }

        public void findAll()
        {
            bormTableAdapter.Fill(cborm);
        }
    }
}
