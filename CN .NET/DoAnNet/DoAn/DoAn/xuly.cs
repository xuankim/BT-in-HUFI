using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    class xuly
    {
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-D2O2784\\SQLEXPRESS;Initial Catalog=QL_SHOPGIAY;User ID=sa;Password=123");
        DataSet QLBanGiay = new DataSet();
        SqlDataAdapter da_phieunhap;
        SqlDataAdapter da_ctphieunhap;
        SqlDataAdapter da_ncc;
        SqlDataAdapter da_sp;
        SqlDataAdapter da_hoadon;
        SqlDataAdapter da_cthoadon;
        SqlDataAdapter da_nhanvien;
        SqlDataAdapter da_khachhang;
        SqlDataAdapter da_thuonghieu;
         SqlDataAdapter da_user;

        public xuly() {
            loadphieunhap();
            loadCTphieunhap();
            loadnhacc();
            loadsanpham();
            loadhoadon();
            loadCThoadon();
            loadnhanvien();
            loadKhachhang();
            loadthuonghieu();
            loaduser();
        }
        public DataTable LoadTable(string tbl)
        {
            return QLBanGiay.Tables[tbl];
        }

        public void loadnhacc()
        {
            da_ncc = new SqlDataAdapter("select *from NHACC", cnn);
            da_ncc.Fill(QLBanGiay, "NHACC");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLBanGiay.Tables["NHACC"].Columns[0];         
            QLBanGiay.Tables["NHACC"].PrimaryKey = khoachinh;

        }
        
        

        //luu sản phẩm vào database
        public bool luuSanPham()
        {

            try
            {
                SqlCommandBuilder build = new SqlCommandBuilder(da_sp);
                da_sp.Update(QLBanGiay, "SANPHAM");

                return true;
            }
            catch
            {
                return false;
            }
        }
        //load sản phẩm lên datable
        public void loadsanpham()
        {
            da_sp = new SqlDataAdapter("select *from SANPHAM", cnn);
            da_sp.Fill(QLBanGiay, "SANPHAM");
            DataColumn[] khoachinh = new DataColumn[2];
            khoachinh[0] = QLBanGiay.Tables["SANPHAM"].Columns[0];
            khoachinh[1] = QLBanGiay.Tables["SANPHAM"].Columns[1];
            QLBanGiay.Tables["SANPHAM"].PrimaryKey = khoachinh;

        }
        //thêm sản phẩm vào datatable
        public bool themsp(string masp, string idthuonghieu, string tensp, int size, string loai, float dongiaban, int sl, string hinh, string mota)
        {
            try
            {

                DataRow dr_sp = QLBanGiay.Tables["SANPHAM"].NewRow();

                dr_sp["MASP"] = masp;
                dr_sp["IDTHUONGHIEU"] = idthuonghieu;
                dr_sp["TENSP"] = tensp;
                dr_sp["SIZE"] = size;
                dr_sp["LOAI"] = loai;
                dr_sp["GIABAN"] = dongiaban;
                dr_sp["SOLUONG"] = sl;
                dr_sp["HINHANHSP"] = hinh;
                dr_sp["MOTA"] = mota;
                QLBanGiay.Tables["SANPHAM"].Rows.Add(dr_sp);

                return true;
            }
            catch
            {
                return false;
            }
        }
        //sửa sản phẩm
        public bool suaSP( string MASP,string IDTHUONGHIEU,string tensp,int size,string loai,float dngia, int sl,string hinh,string mota)
        {
            DataRow dr_sp = QLBanGiay.Tables["SANPHAM"].Rows.Find(new string[] { MASP, IDTHUONGHIEU });
            if (dr_sp != null)
            {
                dr_sp["TENSP"] = tensp;
                dr_sp["SIZE"] = size;
                dr_sp["LOAI"] = loai;
                dr_sp["GIABAN"] = dngia;
                dr_sp["SOLUONG"] = sl;
                dr_sp["HINHANHSP"] = hinh;
                dr_sp["MOTA"] = mota;
                return true;
            }
            else
            {
                return false;
            }
        }
       //Xóa sản phẩm
        public bool xoasp(string MASP, string IDTHUONGHIEU)
        {

            DataRow dr_sp = QLBanGiay.Tables["SANPHAM"].Rows.Find(new string[] { MASP, IDTHUONGHIEU });
            if (dr_sp != null)
            {
                dr_sp.Delete();
                dr_sp.Delete();
                return true;
            }
            else
            {
                return false;
            }
        }

        //load thuog hiệu vào database
        public void loadthuonghieu()
        {
            da_thuonghieu = new SqlDataAdapter("select *from THUONGHIEU", cnn);
            da_thuonghieu.Fill(QLBanGiay, "THUONGHIEU");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLBanGiay.Tables["THUONGHIEU"].Columns[0];  
            QLBanGiay.Tables["THUONGHIEU"].PrimaryKey = khoachinh;

        }

        //Hoa đơn
        public void loadhoadon()
        {
            da_hoadon = new SqlDataAdapter("select *from HOADON", cnn);
            da_hoadon.Fill(QLBanGiay, "HOADON");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLBanGiay.Tables["HOADON"].Columns[0];
            QLBanGiay.Tables["HOADON"].PrimaryKey = khoachinh;

        }
        public void loadCThoadon()
        {
            da_cthoadon = new SqlDataAdapter("select *from CTHD", cnn);
            da_cthoadon.Fill(QLBanGiay, "CTHD");
            DataColumn[] khoachinh = new DataColumn[2];
            khoachinh[0] = QLBanGiay.Tables["CTHD"].Columns[0];
            khoachinh[1] = QLBanGiay.Tables["CTHD"].Columns[1];
            QLBanGiay.Tables["CTHD"].PrimaryKey = khoachinh;

        }
        public bool themhoadon(string sohd, DateTime ngaylap,string makh,string manv) {
            try
            {

                DataRow dr_hoadon = QLBanGiay.Tables["HOADON"].NewRow();

                dr_hoadon["SOHD"] = sohd;
                dr_hoadon["NGLAPHD"] = ngaylap;
                dr_hoadon["MAKH"] = makh;
                dr_hoadon["MANV"] = manv;

                QLBanGiay.Tables["HOADON"].Rows.Add(dr_hoadon);

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool themcthoadon(string sohd, string masp, int sl,string dongia)
        {
            try
            {

                DataRow dr_cthoadon = QLBanGiay.Tables["CTHD"].NewRow();

                dr_cthoadon["SOHD"] = sohd;
                dr_cthoadon["MASP"] = masp;
                dr_cthoadon["SL"] = sl;
                dr_cthoadon["DONGIA"] = dongia;

                QLBanGiay.Tables["CTHD"].Rows.Add(dr_cthoadon);

                return true;
            }
            catch
            {
                return false;
            }
        }
        public string laydongia(string MASP){
            DataRow dr = QLBanGiay.Tables["SANPHAM"].Rows.Find(new string[] { MASP});
            return (dr != null) ? dr["GIABAN"].ToString() : "";
        }
        //luu hoa đơn vào database
        public bool luuHoaDon()
        {
            try
            {
                SqlCommandBuilder build = new SqlCommandBuilder(da_hoadon);
                da_hoadon.Update(QLBanGiay, "HOADON");

                SqlCommandBuilder buildt = new SqlCommandBuilder(da_cthoadon);
                da_cthoadon.Update(QLBanGiay, "CTHD");

                return true;
               
            }
            catch
            {
                return false;
            }
        }
       
        //load nhân viên từ database lên datable
        public void loadnhanvien()
        {
            da_nhanvien = new SqlDataAdapter("select *from NHANVIEN", cnn);
            da_nhanvien.Fill(QLBanGiay, "NHANVIEN");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLBanGiay.Tables["NHANVIEN"].Columns[0];
          
            QLBanGiay.Tables["NHANVIEN"].PrimaryKey = khoachinh;

        }
        //load khách hàng từ database lên datable
        public void loadKhachhang()
        {
            da_khachhang = new SqlDataAdapter("select *from KHACHHANG", cnn);
            da_khachhang.Fill(QLBanGiay, "KHACHHANG");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLBanGiay.Tables["KHACHHANG"].Columns[0];

            QLBanGiay.Tables["KHACHHANG"].PrimaryKey = khoachinh;

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
        //thêm phiếu nhập vào datatable
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
        public bool themCTphieunhap(string mapn, string msp, float dongianhap,int slnhap)
        {
            try
            {

                DataRow dr_ctphieunhap = QLBanGiay.Tables["CTPHIEUNHAP"].NewRow();

                dr_ctphieunhap["IDPHIEUNHAP"] = mapn;
                dr_ctphieunhap["MASP"] = msp;
                dr_ctphieunhap["DONGIANHAP"] =dongianhap;
                dr_ctphieunhap["SLNHAP"] = slnhap;

                QLBanGiay.Tables["CTPHIEUNHAP"].Rows.Add(dr_ctphieunhap);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool suaPN(string IDPHIEUNHAP, string MASP, float dngia, int slnhap)
        {
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
        //xóa chi tiết phiếu nhập
        public bool xoaPN(string IDPHIEUNHAP, string MASP)
        {

            DataRow dr_ctphieunhap = QLBanGiay.Tables["CTPHIEUNHAP"].Rows.Find(new string[] { IDPHIEUNHAP, MASP });
            if (dr_ctphieunhap != null)
            {
                dr_ctphieunhap.Delete();
               
                return true;
            }
            else
            {
                return false;
            }
        }



        public int TinhThanhTien(string IDPHIEUNHAP)
        {

            DataRow[] listrow = QLBanGiay.Tables["CTPHIEUNHAP"].Select("IDPHIEUNHAP ='" + IDPHIEUNHAP + "'");
            int sum = 0;
            foreach (DataRow r in listrow) {
                int y = r.Field<int>("DONGIANHAP");
                int x = r.Field<int>("SLNHAP");
                sum +=  x*y ;

            }
                 return sum;
        }


       
        //lưu phiếu nhập vào databasse
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
        public void loaduser()
        {
            da_user = new SqlDataAdapter("select *from USERS", cnn);
            da_user.Fill(QLBanGiay, "USERS");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLBanGiay.Tables["USERS"].Columns[0];
            QLBanGiay.Tables["USERS"].PrimaryKey = khoachinh;
            //return QLBanGiay.Tables["USERS"];
        }

        //kt đăng nhập
        public bool KTDN(string USERNAME, string MATKHAU)
        {
            DataRow dr_user = QLBanGiay.Tables["USERS"].Rows.Find(USERNAME); 
            
            if (dr_user == null)
            {
                return false;
            }
            else
            {
                if (dr_user["MATKHAU"].ToString()!= MATKHAU)
                {
                    return false;
                }
                else {
                    return true;
                }
            
            }
        }
        //nhan vien
        public bool luunhanvien(TextBox manv, TextBox tennv, TextBox email, TextBox sdt, TextBox diachi, DateTimePicker ngsinh, DateTimePicker ngvaolam, TextBox hsluong, TextBox soglv)
        {
            try
            {
                DataRow dr_add = QLBanGiay.Tables["NHANVIEN"].NewRow();

                dr_add["MANV"] = manv.Text;
                dr_add["HOTEN"] = tennv.Text;
                dr_add["EMAIL"] = email.Text;
                dr_add["DCHI"] = diachi.Text;
                dr_add["SODT"] = sdt.Text;
                dr_add["NGSINH"] = ngsinh.Value;

                dr_add["NGVL"] = ngvaolam.Value;
                dr_add["HS_LUONG"] = hsluong.Text;
                dr_add["GioLV"] = soglv.Text;




                QLBanGiay.Tables["NHANVIEN"].Rows.Add(dr_add);
                SqlCommandBuilder build = new SqlCommandBuilder(da_nhanvien);
                da_nhanvien.Update(QLBanGiay, "NHANVIEN");

                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool xoanhanvien(string MaNhanVien)
        {
            DataRow dr = QLBanGiay.Tables["NHANVIEN"].Rows.Find(new string[] { MaNhanVien });
            loadhoadon();
            loaduser();
            if (QLBanGiay.Tables["HOADON"].Select("MANV = '" + MaNhanVien + "'").Count() > 0 || QLBanGiay.Tables["USERS"].Select("MANV = '" + MaNhanVien + "'").Count() > 0)
            {
                return false;
            }
            else
            {
                if (dr != null)
                {
                    dr.Delete();
                    SqlCommandBuilder build = new SqlCommandBuilder(da_nhanvien);
                    build.GetUpdateCommand();
                    da_nhanvien.Update(QLBanGiay, "NHANVIEN");
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        //public bool themKhachhang() { }
        //public bool luuKhachhang() { }
        public bool xoaKhachhang(string makh)
        {
            DataRow dr = QLBanGiay.Tables["KHACHHANG"].Rows.Find(new string[] { makh });
            if (QLBanGiay.Tables["HOADON"].Select("MANV = '" + makh + "'").Count() > 0)
            {

                return false;
            }
            else
            {
                if (dr != null)
                {
                    dr.Delete();
                    SqlCommandBuilder build = new SqlCommandBuilder(da_khachhang);
                    da_khachhang.Update(QLBanGiay, "KHACHHANG");
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
    }

    
}
