using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001181435_TranThiKimXuan_Tuan6
{
    
    

   public class xuly
    {
       PhongBan[] dsphongban = new PhongBan[] { };
       NhanVien[] dsnhanvien = new NhanVien[] { };
      public string[] mangdulieu = new[] { "Giám đốc", "Tổ chức hành chính", "Kế hoạch", "Kế toán" };

      public TreeNode[] Loadtree() {
          TreeNode[] kq = new TreeNode[dsphongban.Length];
          for (int i = 0; i < dsphongban.Length; i++)
          {
              TreeNode node = new TreeNode();
              node.Text = dsphongban[i].Tenpb;
              node.Tag = dsphongban[i].Mpb;
              kq[i] = node;
          }
          return kq; 
      }

       public TreeNode[] LoadDSNV(string pMaPB) {
           NhanVien[] nvpb = dsnhanvien.Where(t => t.MaPB == pMaPB).ToArray<NhanVien>();
           TreeNode[] dsnv_pb = new TreeNode[nvpb.Length];
           for (int i = 0; i < nvpb.Length; i++) {
               TreeNode node = new TreeNode();
               node.Text = nvpb[i].Mnv+nvpb[i].Tennv;
               node.Tag = nvpb[i].Mnv;
               dsnv_pb[i] = node;
           }
           return dsnv_pb; 
       }
      

       public void Themroot(string ptext) {
           Array.Resize(ref dsphongban,dsphongban.Length + 1);
           PhongBan pb = new PhongBan();
           pb.Tenpb = ptext;
           pb.Mpb = ptext;
           dsphongban[dsphongban.Length - 1] = pb;
          
       }
      
       public bool Kt(string ptext) {
          
           for(int i=0;i<dsphongban.Length;i++){
               if (String.Compare(dsphongban[i].Tenpb.ToString(), ptext, true)==0)
               {
                   return true;
               }
           
           }
           return false;
           }

       public void init() {

           for (int i = 0; i < mangdulieu.Length; i++) {
               PhongBan pb = new PhongBan();
               pb.Tenpb = mangdulieu[i];
               pb.Mpb = mangdulieu[i];
               Array.Resize(ref dsphongban, dsphongban.Length + 1);
               dsphongban[dsphongban.Length - 1] = pb;
           }
       }
       public bool isIssetNV(string pMaNV)
       {
           return (dsnhanvien.Where(t => t.Mnv == pMaNV).ToArray().Length > 0);
       }

       public void AddNhanVien(string pMaNV, string pHoTen, string pDiaChi, string pTenPB)
       {
           NhanVien nv = new NhanVien();
           nv.Mnv = pMaNV;
           nv.Tennv= pHoTen;
           nv.Diachi = pDiaChi;
           nv.MaPB = dsphongban.Where(t => t.Tenpb == pTenPB).Select(x => x.Mpb).ToArray()[0];

           Array.Resize(ref dsnhanvien, dsnhanvien.Length + 1);
           dsnhanvien[dsnhanvien.Length - 1] = nv;
       }

       public void DeletePhongBan(string pMaPB)
       {
           int index = findIndexPB(pMaPB);
           if (index != -1)
           {
               string mpb = dsphongban[index].Mpb;
               dsphongban = dsphongban.Where(t => t.Mpb != mpb).ToArray<PhongBan>();
               dsnhanvien = dsnhanvien.Where(t => t.MaPB != mpb).ToArray<NhanVien>();
           }
       }
       public int findIndexPB(string pMaBP)
       {
           return Array.IndexOf(dsphongban.Select(x => x.Mpb).ToArray<string>(), pMaBP);
       }


       //public NhanVien findNhanVien(string pMaSoNV)
       //{
       //    return dsnhanvien.Where(t => t.Mnv == pMaSoNV).ToArray()[0];
       //}
       

       }
       
    }

