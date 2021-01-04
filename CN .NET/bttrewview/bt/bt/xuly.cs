using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt
{
    class xuly
    {

        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-D2O2784\\SQLEXPRESS;Initial Catalog=QLSINHVIEN ; User ID=sa ; Password=123");
        DataSet QLSinhVien = new DataSet();
        SqlDataAdapter da_khoalop;
        SqlDataAdapter da_sv;
        SqlDataAdapter da_lop;
        SqlDataAdapter da_khoa;

        public xuly()
        {
            loadKhoa();
            loadLop();
            loadsv();
        }

        public void loadsvlopmonhocdiem()
        {
            da_khoalop = new SqlDataAdapter("select SinhVien.MaSinhVien,HoTen,NgaySinh,lop.MaLop,TenLop from Lop,Khoa,SinhVien where lop.MaKhoa=Khoa.MaKhoa and SinhVien.MaLop=Lop.MaLop", cnn);
            da_khoalop.Fill(QLSinhVien, "ThongTin");
            DataColumn[] khoachinh = new DataColumn[2];
            khoachinh[0] = QLSinhVien.Tables["ThongTin"].Columns[0];
            khoachinh[1] = QLSinhVien.Tables["ThongTin"].Columns[3];
            QLSinhVien.Tables["ThongTin"].PrimaryKey = khoachinh;
        }

        public DataTable loadTable(string tbl)
        {
            return QLSinhVien.Tables[tbl];
        }

        public void loadsv()
        {
            da_sv = new SqlDataAdapter("select * from SINHVIEN", cnn);
            da_sv.Fill(QLSinhVien, "SINHVIEN");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLSinhVien.Tables["SINHVIEN"].Columns[0];
            QLSinhVien.Tables["SINHVIEN"].PrimaryKey = khoachinh;
        }

        public void loadLop()
        {
            da_lop = new SqlDataAdapter("select * from Lop", cnn);
            da_lop.Fill(QLSinhVien, "Lop");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLSinhVien.Tables["Lop"].Columns[0];
            QLSinhVien.Tables["Lop"].PrimaryKey = khoachinh;
        }
        public void loadKhoa()
        {
            da_khoa = new SqlDataAdapter("select * from Khoa", cnn);
            da_khoa.Fill(QLSinhVien, "Khoa");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLSinhVien.Tables["Khoa"].Columns[0];
            QLSinhVien.Tables["Khoa"].PrimaryKey = khoachinh;
        }

        public TreeNode[] loadData()
        {
            int SLKhoa = QLSinhVien.Tables["Khoa"].Rows.Count;
            TreeNode[] root = new TreeNode[SLKhoa];
            for (int i = 0; i < root.Length; i++)
            {
                TreeNode node = new TreeNode();
                node.Text = QLSinhVien.Tables["Khoa"].Rows[i]["TenKhoa"].ToString();
                node.Tag =  QLSinhVien.Tables["Khoa"].Rows[i]["MaKhoa"].ToString();
                node.Nodes.AddRange(loadLopTreeNode(node.Tag.ToString()));
                root[i] = node;
            }
            return root;
        }

        public TreeNode[] loadLopTreeNode(string pMaKhoa)
        {
            // Sao Chep DataTable Lop
            DataTable filterTable = QLSinhVien.Tables["Lop"].Clone();

            // Xoa Toan Bo Rows Trong filterTable
            filterTable.Rows.Clear();

            // Filter Gia Tri
            DataRow[] filterRow = QLSinhVien.Tables["Lop"].AsEnumerable().Where(row => row.Field<string>("MaKhoa") == pMaKhoa).ToArray<DataRow>();

            // Them filterRow[] vao fillterTable
            foreach (DataRow row in filterRow)
                filterTable.ImportRow(row);


            TreeNode[] root = new TreeNode[filterTable.Rows.Count];
            for (int i = 0; i < root.Length; i++)
            {
                TreeNode node = new TreeNode();
                node.Text = filterTable.Rows[i]["TenLop"].ToString();
                node.Tag = filterTable.Rows[i]["MaLop"].ToString();
                //node.Nodes.AddRange(loadSVTreeNode(node.Tag.ToString()));
                root[i] = node;
            }
            return root;
        }

        public TreeNode[] loadSVTreeNode(string pMaLop)
        {
            // Sao Chep DataTable Lop
            DataTable filterTable = QLSinhVien.Tables["SinhVien"].Clone();

            // Xoa Toan Bo Rows Trong filterTable
            filterTable.Rows.Clear();

            // Filter Gia Tri
            DataRow[] filterRow = QLSinhVien.Tables["SinhVien"].AsEnumerable().Where(row => row.Field<string>("MaLop") == pMaLop).ToArray<DataRow>();

            // Them filterRow[] vao fillterTable
            foreach (DataRow row in filterRow)
                filterTable.ImportRow(row);


            TreeNode[] root = new TreeNode[filterTable.Rows.Count];
            for (int i = 0; i < root.Length; i++)
            {
                TreeNode node = new TreeNode();
                node.Text = filterTable.Rows[i]["HoTen"].ToString();
                node.Tag = filterTable.Rows[i]["MaSinhVien"].ToString();
                root[i] = node;
            }
            return root;
        }

        public DataTable filterLop(string pMaKhoa)
        {
            // Sao Chep DataTable Lop
            DataTable filterTable = QLSinhVien.Tables["Lop"].Clone();

            // Xoa Toan Bo Rows Trong filterTable
            filterTable.Rows.Clear();

            // Filter Gia Tri
            DataRow[] filterRow = QLSinhVien.Tables["Lop"].AsEnumerable().Where(row => row.Field<string>("MaKhoa") == pMaKhoa).ToArray<DataRow>();

            // Them filterRow[] vao fillterTable
            foreach (DataRow row in filterRow)
                filterTable.ImportRow(row);

            return filterTable;
        }

        public DataTable filterSV(string pMaLop)
        {
            // Sao Chep DataTable Lop
            DataTable filterTable = QLSinhVien.Tables["SinhVien"].Clone();

            // Xoa Toan Bo Rows Trong filterTable
            filterTable.Rows.Clear();

            // Filter Gia Tri
            DataRow[] filterRow = QLSinhVien.Tables["SinhVien"].AsEnumerable().Where(row => row.Field<string>("MaLop") == pMaLop).ToArray<DataRow>();

            // Them filterRow[] vao fillterTable
            foreach (DataRow row in filterRow)
                filterTable.ImportRow(row);

            return filterTable;
        }

        public bool Themsv(string MaSV, string HoTen,DateTime ngaysinh ,string MaLop) {
            DataRow dr_sv = QLSinhVien.Tables["SinhVien"].NewRow();

            dr_sv["MaSinhVien"] = MaSV;
            dr_sv["HoTen"] = HoTen;
            dr_sv["MaLop"] = MaLop;
            dr_sv["NgaySinh"] = ngaysinh;
            QLSinhVien.Tables["SinhVien"].Rows.Add(dr_sv);
            return true;
        }
    }
}
