using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class xuly
    {
        SqlConnection cnn = new SqlConnection("Data Source=A102PC36;Initial Catalog=QLSINHVIEN ; User ID=sa ; Password=sa2012");
        DataSet DsQlSinhVien = new DataSet();
        SqlDataAdapter da_Khoa;
        SqlDataAdapter da_lopkhoa;
        public DataTable loadKhoa(){
             da_Khoa = new SqlDataAdapter("Select*from Khoa",cnn);

        
            da_Khoa.Fill(DsQlSinhVien, "Khoa");
            DataColumn[] khoachinh=new DataColumn[1];
            khoachinh[0] = DsQlSinhVien.Tables["Khoa"].Columns[0];
            DsQlSinhVien.Tables["Khoa"].PrimaryKey = khoachinh;
            return DsQlSinhVien.Tables["Khoa"];
        }
        public DataTable loadlopkhoa() {
            da_Khoa = new SqlDataAdapter("    select MaLop,TenLop,Khoa.MaKhoa,TenKhoa from Khoa,Lop where lop.MaKhoa=Khoa.MaKhoa", cnn);
            da_Khoa.Fill(DsQlSinhVien, "Lop_Khoa");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = DsQlSinhVien.Tables["Lop_Khoa"].Columns[0];
            DsQlSinhVien.Tables["Lop_Khoa"].PrimaryKey = khoachinh;
            return DsQlSinhVien.Tables["Lop_Khoa"];
        }
        public bool themlopkhoa(string pmakhoa,string ptenkhoa) {
            try
            {
                DataRow dr_them = DsQlSinhVien.Tables["Lop_Khoa"].NewRow();
                dr_them["MaKhoa"] = pmakhoa;
                dr_them["TenKhoa"] = ptenkhoa;

                DsQlSinhVien.Tables["Khoa"].Rows.Add(dr_them);

                //SqlCommandBuilder build = new SqlCommandBuilder(da_Khoa);
                //da_Khoa.Update(DsQlSinhVien, "Khoa");
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool Themkhoa(string pmakhoa,string ptenkhoa) {
            try
            {
                DataRow dr_them = DsQlSinhVien.Tables["Khoa"].NewRow();
                dr_them["MaKhoa"] = pmakhoa;
                dr_them["TenKhoa"] = ptenkhoa;

                DsQlSinhVien.Tables["Khoa"].Rows.Add(dr_them);

                //SqlCommandBuilder build = new SqlCommandBuilder(da_Khoa);
                //da_Khoa.Update(DsQlSinhVien, "Khoa");
                return true;
            }
            catch {
                return false;
            }
        
        }
       

        public bool ktrong(string pma, string ptenkhoa)
        {
            if (pma == "" || ptenkhoa == "")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool delete(string pmakhoa) {

            try {
                DataRow dr_xoa = DsQlSinhVien.Tables["Khoa"].Rows.Find(pmakhoa);

                if (dr_xoa != null) {
                    dr_xoa.Delete();
                    
                }
                return true;
            }
            catch {
                return false;
            }
        }
        public bool sua(string pmakhoa,string ptenkhoa) {
            try
            {
                DataRow dr_sua = DsQlSinhVien.Tables["Khoa"].Rows.Find(pmakhoa);

                if (dr_sua != null)
                {
                    dr_sua["TenKhoa"] = ptenkhoa;
                } return true;

                
                
            }
            catch
            {
                return false;
            }
        }
        public bool luu() {
            try
            {


                SqlCommandBuilder build = new SqlCommandBuilder(da_Khoa);
                da_Khoa.Update(DsQlSinhVien, "Khoa");
                return true;
            }
            catch
            {
                return false;
            }
        }

        
    }
}
