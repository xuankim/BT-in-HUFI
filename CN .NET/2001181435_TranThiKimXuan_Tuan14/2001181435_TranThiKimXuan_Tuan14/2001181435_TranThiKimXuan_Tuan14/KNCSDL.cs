using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001181435_TranThiKimXuan_Tuan14
{
    public class KNCSDL
    {
      public  SqlConnection cnn;

        string tenmay;
        string tencsdl;
        string user;
        string pass;

        public string Tenmay
        {
            get { return tenmay; }
            set { tenmay = value; }
        }
     

        public string Tencsdl
        {
            get { return tencsdl; }
            set { tencsdl = value; }
        }
       

        public string User
        {
            get { return user; }
            set { user = value; }
        }
       

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }


        public KNCSDL() {
            cnn = Program.cnn;
        }
        public KNCSDL(string ptenmay,string ptencsdl,string puser,string ppass) {
            tenmay = ptenmay;
            tencsdl = ptencsdl;
            user = puser;
            pass = ppass;

            cnn = new SqlConnection("Data Source="+tenmay+";Initial Catalog="+tencsdl+";User ID="+user+";Password="+pass+"");
        }
        public bool ktkn()
        {
            try {
                cnn.Open();
                Program.cnn=cnn;
                return true;
            }
            catch {
                return false;
            
            }
        }
    }
}
