using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN10
{
    class xuly
    {
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-D2O2784\\SQLEXPRESS;Initial Catalog=QL_SHOPGIAY;User ID=sa;Password=123");

        DataSet QLBanGiay = new DataSet();
        SqlDataAdapter da_phieunhap;
        SqlDataAdapter da_ctphieunhap;
        SqlDataAdapter da_ncc;
        SqlDataAdapter da_sp;
        public xuly()
        {
            loadphieunhap();
            loadCTphieunhap();
            loadnhacc();
            loadsanpham();
           
        }
        public DataTable LoadTable(string tbl)
        {
            return QLBanGiay.Tables[tbl];
        }

        public void loadphieunhap()
        {
            da_phieunhap = new SqlDataAdapter("select *from PHIEUNHAP", cnn);
            da_phieunhap.Fill(QLBanGiay, "PHIEUNHAP");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLBanGiay.Tables["PHIEUNHAP"].Columns[0];
            QLBanGiay.Tables["PHIEUNHAP"].PrimaryKey = khoachinh;

        }

        public void loadCTphieunhap()
        {
            da_ctphieunhap = new SqlDataAdapter("select *from CTPHIEUNHAP", cnn);
            da_ctphieunhap.Fill(QLBanGiay, "CTPHIEUNHAP");
            DataColumn[] khoachinh = new DataColumn[2];
            khoachinh[0] = QLBanGiay.Tables["CTPHIEUNHAP"].Columns[0];
            khoachinh[1] = QLBanGiay.Tables["CTPHIEUNHAP"].Columns[1];
            QLBanGiay.Tables["CTPHIEUNHAP"].PrimaryKey = khoachinh;

        }
        public void loadnhacc()
        {
            da_ncc = new SqlDataAdapter("select *from NHACC", cnn);
            da_ncc.Fill(QLBanGiay, "NHACC");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLBanGiay.Tables["NHACC"].Columns[0];
            QLBanGiay.Tables["NHACC"].PrimaryKey = khoachinh;

        }
        public void loadsanpham()
        {
            da_sp = new SqlDataAdapter("select *from SANPHAM", cnn);
            da_sp.Fill(QLBanGiay, "SANPHAM");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLBanGiay.Tables["SANPHAM"].Columns[0];
            QLBanGiay.Tables["SANPHAM"].PrimaryKey = khoachinh;

        }

        public bool themphieunhap(string mapn, DateTime ngaylaphd, string manhcc)
        {
            try
            {

                DataRow dr_phieunhap = QLBanGiay.Tables["PHIEUNHAP"].NewRow();

                dr_phieunhap["IDPHIEUNHAP"] = mapn;
                dr_phieunhap["NGAYNHAP"] = ngaylaphd;
                dr_phieunhap["IDNCC"] = manhcc;


                QLBanGiay.Tables["PHIEUNHAP"].Rows.Add(dr_phieunhap);

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool themCTphieunhap(string mapn, string msp, float dongianhap, int slnhap)
        {
            try
            {

                DataRow dr_ctphieunhap = QLBanGiay.Tables["CTPHIEUNHAP"].NewRow();

                dr_ctphieunhap["IDPHIEUNHAP"] = mapn;
                dr_ctphieunhap["MASP"] = msp;
                dr_ctphieunhap["DONGIANHAP"] = dongianhap;
                dr_ctphieunhap["SLNHAP"] = slnhap;

                QLBanGiay.Tables["CTPHIEUNHAP"].Rows.Add(dr_ctphieunhap);

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool sua(string IDPHIEUNHAP,string MASP,float dngia,int slnhap) {
            DataRow dr_ctphieunhap = QLBanGiay.Tables["CTPHIEUNHAP"].Rows.Find(new string[] { IDPHIEUNHAP, MASP });
            if (dr_ctphieunhap != null)
            {
                dr_ctphieunhap["DONGIANHAP"] = dngia;
                dr_ctphieunhap["SLNHAP"] = slnhap;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool xoa(string IDPHIEUNHAP,string MASP) {

            DataRow dr_ctphieunhap = QLBanGiay.Tables["CTPHIEUNHAP"].Rows.Find(new string[] { IDPHIEUNHAP, MASP });
            if (dr_ctphieunhap != null)
            {
                dr_ctphieunhap.Delete();
                dr_ctphieunhap.Delete();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool luuPhieunhap()
        {
            try
            {
                SqlCommandBuilder build = new SqlCommandBuilder(da_phieunhap);
                da_phieunhap.Update(QLBanGiay, "PHIEUNHAP");
                SqlCommandBuilder buildct = new SqlCommandBuilder(da_ctphieunhap);
                da_ctphieunhap.Update(QLBanGiay, "CTPHIEUNHAP");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
