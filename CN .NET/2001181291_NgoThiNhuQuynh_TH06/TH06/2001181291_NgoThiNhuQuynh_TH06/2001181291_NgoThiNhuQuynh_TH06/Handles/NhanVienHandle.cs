using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001181291_NgoThiNhuQuynh_TH06.Handles
{
    public class NhanVienHandle
    {
        Models.PhongBan[] dsPB = new Models.PhongBan[] { };
        Models.NhanVien[] dsNV = new Models.NhanVien[] { };
        string[] array = new[] { "Giám đốc", "Tổ chức hành chính", "Kế hoạch", "Kế toán" };

        public TreeNode[] Load()
        {
            TreeNode[] kq = new TreeNode[dsPB.Length];
            for (int i = 0; i < dsPB.Length; i++)
            {
                TreeNode node = new TreeNode();
                node.Text = dsPB[i].TenPB;
                node.Tag = dsPB[i].MaPB;
                kq[i] = node;
            }
            return kq;
        }
        public TreeNode[] loadDSNV(string _maPB)
        {
            Models.NhanVien[] nvpb = dsNV.Where(t => t.MaPB == _maPB).ToArray<Models.NhanVien>();
            TreeNode[] dsnv_pb = new TreeNode[nvpb.Length];
            for (int i = 0; i < nvpb.Length; i++ )
            {
                TreeNode node = new TreeNode();
                node.Text = nvpb[i].MaNV + nvpb[i].TenNV;
                node.Tag = nvpb[i].MaNV;
                dsnv_pb[i] = node;
            }
            return dsnv_pb;
        }

        public void addRoot(string pText) {
            Array.Resize(ref dsPB, dsPB.Length + 1);
            Models.PhongBan pb = new Models.PhongBan();
            pb.TenPB = pText;
            pb.MaPB = pText;
            dsPB[dsPB.Length - 1] = pb;
        }

        public bool findIndexPB(string pTenPB)
        {
            return (dsPB.Where(t => t.TenPB == pTenPB).ToArray().Length > 0);
        }

        public void init() {
            for (int i = 0; i < array.Length; i++) {
                Models.PhongBan pb = new Models.PhongBan();
                pb.TenPB = array[i];
                pb.MaPB = array[i];
                Array.Resize(ref dsPB, dsPB.Length + 1);
                dsPB[dsPB.Length - 1] = pb;
            }
        }

        public string RandomString(int length) {
            Random rd = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[rd.Next(s.Length)]).ToArray());
        }
        public void AddNhanVien(string pMaNV, string pHoTen, string pDiaChi, string pTenPB) {
            Models.NhanVien nv = new Models.NhanVien();
            nv.MaNV = pMaNV;
            nv.TenNV = pHoTen;
            nv.DiaChi = pDiaChi;
            nv.MaPB = dsPB.Where(t => t.TenPB == pTenPB).Select(x => x.MaPB).ToArray()[0];

            Array.Resize(ref dsNV, dsNV.Length + 1);
            dsNV[dsNV.Length - 1] = nv;
        }
    }
    

    
}
