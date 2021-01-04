using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class xuly
    {
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-D2O2784\\SQLEXPRESS;Initial Catalog=QLSINHVIEN ; User ID=sa ; Password=123");
         public bool ketnoi(){
             try
             {
                 if (cnn.State == System.Data.ConnectionState.Closed)
                 {
                     cnn.Open();
                 }
                 return true;
             }
             catch {
                 return false;
             }
         }

         public bool dongkenoi() {
             try {

                 if (cnn.State == System.Data.ConnectionState.Open)
                 {
                     cnn.Close();
                 }
                 return true;
             }
             catch {
                 return false;
             
             }
         }

         public bool Them(string pmakhoa,string ptenkhoa) {
             try {

                 if (cnn.State == System.Data.ConnectionState.Closed)
                 {
                     cnn.Open();
                 }

                 string caulenh = "insert into Khoa values('" + pmakhoa + "','" + ptenkhoa + "')";
                 SqlCommand cmdkhoa = new SqlCommand(caulenh,cnn);
                 cmdkhoa.ExecuteNonQuery();
               
                 if (cnn.State == System.Data.ConnectionState.Open)
                 {
                     cnn.Close();
                 }
                 return true;
             }
             catch {
                 return false;
             }
         
         }

         public bool kttrung(string pmaso) {
           try{
                 if (cnn.State == System.Data.ConnectionState.Closed)
                 {
                     cnn.Open();
                 }
                 string caulenh = "select count(*) from Khoa where MaKhoa='" + pmaso + "'";
                 SqlCommand cmdkhoa = new SqlCommand(caulenh, cnn);

                 int kt=(int)cmdkhoa.ExecuteScalar();

                 if (cnn.State == System.Data.ConnectionState.Open)
                 {
                     cnn.Close();
                 }
                 if (kt > 0) {
                     return false;
                 }
               return  true;
           }catch{
           return false;
           }
         
         }
         public bool xoa(string pmakhoa) {
             try
             {
                 if (cnn.State == System.Data.ConnectionState.Closed)
                 {
                     cnn.Open();
                 }
                 string caulenh = "delete from Khoa where MaKhoa='" + pmakhoa+ "'";
                 SqlCommand cmdkhoa = new SqlCommand(caulenh, cnn);
                 cmdkhoa.ExecuteNonQuery();
                 
                 if (cnn.State == System.Data.ConnectionState.Open)
                 {
                     cnn.Close();
                 }
                 return true;
             }
             catch
             {
                 return false;
             }
         
         }
         public bool sua(string pmakhoa,string ptenkhoa)
         {
             try
             {
                 if (cnn.State == System.Data.ConnectionState.Closed)
                 {
                     cnn.Open();
                 }
                 string caulenh = "update Khoa set TenKhoa='" + ptenkhoa + "' where MaKhoa='" + pmakhoa + "'";
                 SqlCommand cmdkhoa = new SqlCommand(caulenh, cnn);
                 cmdkhoa.ExecuteNonQuery();

                 if (cnn.State == System.Data.ConnectionState.Open)
                 {
                     cnn.Close();
                 }
                 return true;
             }
             catch
             {
                 return false;
             }
         }

         public object[] loadkhoa() {
             List<string> dskhoa = new List<string>();
             try {

                 if (cnn.State == System.Data.ConnectionState.Closed)
                 {
                     cnn.Open();
                 }
                 string caulenh = "select TenKhoa from Khoa";
                 SqlCommand cmdkhoa = new SqlCommand(caulenh, cnn);
                 SqlDataReader kq = cmdkhoa.ExecuteReader();
                 while (kq.Read()) {
                     dskhoa.Add(kq[0].ToString());
                 }
                 kq.Close();

                 object[] mang = new object[dskhoa.Count];
                 for (int i=0; i < dskhoa.Count; i++) {
                     mang[i] = dskhoa[i];
                 }
                     if (cnn.State == System.Data.ConnectionState.Open)
                     {
                         cnn.Close();
                     }
                 return mang;
             }
             catch {
                 return null;
             }
         }
        //bai2
         public object[] loadlop()
         {
             List<string> dslop = new List<string>();
             try
             {

                 if (cnn.State == System.Data.ConnectionState.Closed)
                 {
                     cnn.Open();
                 }
                 string caulenh = "select TenLop from Lop";
                 SqlCommand cmdkhoa = new SqlCommand(caulenh, cnn);
                 SqlDataReader kq = cmdkhoa.ExecuteReader();
                 while (kq.Read())
                 {
                     dslop.Add(kq[0].ToString());
                 }
                 kq.Close();

                 object[] mang = new object[dslop.Count];
                 for (int i = 0; i < dslop.Count; i++)
                 {
                     mang[i] = dslop[i];
                 }
                 if (cnn.State == System.Data.ConnectionState.Open)
                 {
                     cnn.Close();
                 }
                 return mang;
             }
             catch
             {
                 return null;
             }
         }
         
    }
}
