using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btvn9
{
    class xuly
    {
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-D2O2784\\SQLEXPRESS;Initial Catalog=QLSINHVIEN ; User ID=sa ; Password=123");
        DataSet QLSinhVien = new DataSet();
        SqlDataAdapter da_svlopmonhocdiem;
        SqlDataAdapter da_tenmonhoc;
        SqlDataAdapter da_tesv;
        SqlDataAdapter da_Diem;

        public xuly()
        {
            loadsvlopmonhocdiem();
            Loadtenmonhoc();
            loadtensv();
            loadLop();
            loaddiem();
        }
        public void loadsvlopmonhocdiem() {
            da_svlopmonhocdiem = new SqlDataAdapter("select sv.MaSinhVien,sv.HoTen,l.TenLop,mh.MaMonHoc,mh.TenMonHoc,d.Diem from SINHVIEN sv, MONHOC mh, DIEM d,LOP l where sv.MaLop=l.MaLop and sv.MaSinhVien=d.MaSinhVien and d.MaMonHoc=mh.MaMonHoc",cnn);
            da_svlopmonhocdiem.Fill(QLSinhVien, "ThongTin");
            DataColumn[] khoachinh = new DataColumn[2];
            khoachinh[0] = QLSinhVien.Tables["ThongTin"].Columns[0];
            khoachinh[1] = QLSinhVien.Tables["ThongTin"].Columns[3];
            QLSinhVien.Tables["ThongTin"].PrimaryKey = khoachinh;
           
        }
        public DataTable loadTable(string tbl)
        {
            return QLSinhVien.Tables[tbl];
        }
        public void Loadtenmonhoc() {
            da_tenmonhoc = new SqlDataAdapter("select * from MonHoc", cnn);
            da_tenmonhoc.Fill(QLSinhVien, "MonHoc");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLSinhVien.Tables["MonHoc"].Columns[0];
            QLSinhVien.Tables["MonHoc"].PrimaryKey = khoachinh;
        }
        public void loadtensv() {
            da_tesv = new SqlDataAdapter("select MASINHVIEN,HOTEN,MALOP from SINHVIEN", cnn);
            da_tesv.Fill(QLSinhVien, "SINHVIEN");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLSinhVien.Tables["SINHVIEN"].Columns[0];
            QLSinhVien.Tables["SINHVIEN"].PrimaryKey = khoachinh;
        }

        public void loadLop()
        {
            da_tesv = new SqlDataAdapter("select * from Lop", cnn);
            da_tesv.Fill(QLSinhVien, "Lop");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLSinhVien.Tables["Lop"].Columns[0];
            QLSinhVien.Tables["Lop"].PrimaryKey = khoachinh;
        }

        public void loaddiem() {
            da_Diem = new SqlDataAdapter("select * from diem", cnn);
            da_Diem.Fill(QLSinhVien, "Diem");
            DataColumn[] khoachinh = new DataColumn[2];
            khoachinh[0] = QLSinhVien.Tables["Diem"].Columns[0];
            khoachinh[1] = QLSinhVien.Tables["Diem"].Columns[1];
            QLSinhVien.Tables["Diem"].PrimaryKey = khoachinh;
        }
        public bool themdiem(ComboBox cbSV,ComboBox cbMon,TextBox txtdiem)
        {
            try
            {
                DataRow dr_add = QLSinhVien.Tables["ThongTin"].NewRow();
                DataRow dr_diem = QLSinhVien.Tables["Diem"].NewRow();

                dr_add["MaSinhVien"] = cbSV.SelectedValue.ToString();
                dr_add["HoTen"] = cbSV.Text;
                string MaLop = QLSinhVien.Tables["SinhVien"].Rows.Find(dr_add["MaSinhVien"])["MaLop"].ToString();
                dr_add["TenLop"] = layTenLop(MaLop);
                dr_add["MaMonHoc"] = cbMon.SelectedValue.ToString();
                dr_add["TenMonHoc"] = cbMon.Text;
                dr_add["Diem"] = float.Parse(txtdiem.Text);


                dr_diem["MaSinhVien"] = dr_add["MaSinhVien"];
                dr_diem["MaMonHoc"] = dr_add["MaMonHoc"];
                dr_diem["Diem"] = dr_add["Diem"];


                QLSinhVien.Tables["Diem"].Rows.Add(dr_diem);
                QLSinhVien.Tables["ThongTin"].Rows.Add(dr_add);
               
                return true;
            }
            catch {
                return false;
            }
        }

        public string layTenLop(string MaLop)
        {
            return QLSinhVien.Tables["Lop"].Rows.Find(MaLop)["TenLop"].ToString();
        }

        public string layDiem(string MaSinhVien, string MaMonHoc)
        {
            DataRow dr = QLSinhVien.Tables["ThongTin"].Rows.Find(new string[] { MaSinhVien, MaMonHoc });

            return (dr != null)?dr["Diem"].ToString():"";
        }

        public bool luu()
        {
            try
            {
                SqlCommandBuilder build = new SqlCommandBuilder(da_Diem);
                da_Diem.Update(QLSinhVien, "Diem");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool sua(string MaSinhVien, string MaMonHoc, float pdiem)
        {

            DataRow dr = QLSinhVien.Tables["ThongTin"].Rows.Find(new string[] { MaSinhVien, MaMonHoc });
            DataRow dr_diem = QLSinhVien.Tables["Diem"].Rows.Find(new string[] { MaSinhVien, MaMonHoc });
            if (dr != null)
            {
                dr["Diem"] = pdiem;
                dr_diem["Diem"] = pdiem;
                return true;
            }
            else {
                return false;
            }
        }

        public bool Xoa(string MaSinhVien, string MaMonHoc)
        {

            DataRow dr = QLSinhVien.Tables["ThongTin"].Rows.Find(new string[] { MaSinhVien, MaMonHoc });
            DataRow dr_diem = QLSinhVien.Tables["Diem"].Rows.Find(new string[] { MaSinhVien, MaMonHoc });
            if (dr != null)
            {
                dr.Delete();
                dr_diem.Delete();
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
