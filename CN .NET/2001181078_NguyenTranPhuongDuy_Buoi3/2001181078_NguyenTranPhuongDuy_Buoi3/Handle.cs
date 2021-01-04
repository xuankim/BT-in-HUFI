using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001181078_NguyenTranPhuongDuy_Buoi3
{
    class Handle
    {
        public string showInfomation(string name, string year)
        {
            return "Tên: " + name.ToString() + "\nTuổi: " + (DateTime.Now.Year - int.Parse(year)).ToString();
        }

        public string showInfomation(string name, int year)
        {
            return "Tên: " + name.ToString() + "\nTuổi: " + (DateTime.Now.Year - year).ToString();
        }

        public bool checkFloatString(string str)
        {
            
            try{
                float.Parse(str);
            }
            catch (Exception err)
            {
                return false;
            }
            return true;
        }

        // Add
        
        public float Add(string a,string b)
        {
            return Add(float.Parse(a),float.Parse(b));
        }

        public float Add(int a, int b)
        {
            return Add((float)a, (float)b);
        }

        public float Add(float a, float b)
        {
            return (a + b);
        }

        // Sub
        
        public float Sub(string a, string b)
        {
            return Sub(float.Parse(a), float.Parse(b));
        }

        public float Sub(int a, int b)
        {
            return Sub((float)a, (float)b);
        }

        public float Sub(float a, float b)
        {
            return (a - b);
        }

        // Mul

        public float Mul(string a, string b)
        {
            return Mul(float.Parse(a), float.Parse(b));
        }

        public float Mul(int a, int b)
        {
            return Mul((float)a, (float)b);
        }

        public float Mul(float a, float b)
        {
            return (a * b);
        }

        // Div

        public float Div(string a, string b)
        {
            return Div(float.Parse(a), float.Parse(b));
        }

        public float Div(int a, int b)
        {
            return Div((float)a, (float)b);
        }

        public float Div(float a, float b)
        {
            return (a / b);
        }

        public bool isEmail(string email)
        {
            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch (FormatException ex)
            {
                return false;
            }
        }
    }
}
