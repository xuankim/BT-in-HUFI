using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001181435_TranThiKimXuan_Tuan14
{
   public class xuly :KNCSDL
    {

       public xuly() {
           Loadcoso();
       }
      

       DataSet QLgv = new DataSet();

       SqlDataAdapter da_gv;

       public DataTable loadTable(string tbl)
       {
           return QLgv.Tables[tbl];
       }

       public void Loadcoso()
       {
           da_gv = new SqlDataAdapter("select * from COSO", cnn);
           da_gv.Fill(QLgv, "COSO");
           DataColumn[] khoachinh = new DataColumn[1];
           khoachinh[0] = QLgv.Tables["COSO"].Columns[0];
           QLgv.Tables["COSO"].PrimaryKey = khoachinh;
       }
    }
}
