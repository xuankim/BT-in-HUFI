using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN
{
    class xuly
    {
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-D2O2784\\SQLEXPRESS;Initial Catalog=QLSINHVIEN ; User ID=sa ; Password=123");
        public bool ketnoi()
        {
            try
            {
                if (cnn.State == System.Data.ConnectionState.Closed)
                {
                    cnn.Open();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool dongkenoi()
        {
            try
            {

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

        public bool Them(string pmalop,string ptenlop,string pmakhoa)
        {
            try
            {

                if (cnn.State == System.Data.ConnectionState.Closed)
                {
                    cnn.Open();
                }

                string caulenh = "insert into Lop values('" + pmalop + "','" + ptenlop + "','"+pmakhoa+"')";
                SqlCommand cmdlop = new SqlCommand(caulenh, cnn);
                cmdlop.ExecuteNonQuery();

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
        public bool kttrung(string pmaso)
        {
            try
            {
                if (cnn.State == System.Data.ConnectionState.Closed)
                {
                    cnn.Open();
                }
                string caulenh = "select count(*) from Lop where MaLop='" + pmaso + "'";
                SqlCommand cmdlop = new SqlCommand(caulenh, cnn);

                int kt = (int)cmdlop.ExecuteScalar();

                if (cnn.State == System.Data.ConnectionState.Open)
                {
                    cnn.Close();
                }
                if (kt > 0)
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool xoa(string pmaso)
        {
            try
            {
                if (cnn.State == System.Data.ConnectionState.Closed)
                {
                    cnn.Open();
                }
                string caulenh = "delete from Lop where MaLop='" + pmaso + "'";
                SqlCommand cmdlop = new SqlCommand(caulenh, cnn);
                cmdlop.ExecuteNonQuery();

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
        public bool sua(string pmalop, string ptenlop,string pmakhoa)
        {
            try
            {
                if (cnn.State == System.Data.ConnectionState.Closed)
                {
                    cnn.Open();
                }
                string caulenh = "update Lop set TenLop='" + ptenlop + "', MaKhoa='"+pmakhoa+"' where MaLop='" + pmalop + "'";
                SqlCommand cmdlop = new SqlCommand(caulenh, cnn);
                cmdlop.ExecuteNonQuery();

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

    }
}
