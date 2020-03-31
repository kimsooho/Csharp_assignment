using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Train
{
    class DBHelper
    {
        //완료
        MailHelper mailHelper = new MailHelper();
        UserInfo userInfo = new UserInfo();
        DataSet1 dataSet;
        DataSet1TableAdapters.MEMBERTableAdapter member;

        public DBHelper()
        {
            dataSet = new DataSet1();
            member = new DataSet1TableAdapters.MEMBERTableAdapter();

            member.Fill(dataSet.MEMBER);
        }

        public bool Signup(string id, string pw, string name, string phone, string email) // 회원가입
        {
            try
            {
                DataTable dt = dataSet.Tables["MEMBER"];
                DataRow dr = dt.NewRow();                
                dt.Rows.Clear();

                dr["ID"] = id.ToUpper(); ;
                dr["PASSWORD"] = pw;
                dr["NAME"] = name;
                dr["PHONE"] = phone;
                dr["EMAIL"] = email.ToUpper();

                dt.Rows.Add(dr);

                if (member.Update(dataSet.MEMBER) == 1)
                {                   
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }

        public bool ID_Check(string id)
        {
            DataTable dt = dataSet.Tables["MEMBER"];
            foreach (DataRow dr in dt.Rows)
            {
                if (id.Equals(dr["ID"].ToString()))
                    return false;
            }
            return true;
        }

        public bool FindAccount(string name, string phone, string email)
        {
            DataTable dt = dataSet.Tables["MEMBER"];
            foreach (DataRow dr in dt.Rows)
            {                
                if (dr["NAME"].ToString().Equals(name) && dr["PHONE"].ToString().Equals(phone) && dr["EMAIL"].ToString().Equals(email))
                {
                    mailHelper.SendMail(name, dr["ID"].ToString(), dr["PASSWORD"].ToString(), email);
                    return true;
                }
            }
            return false;
        }

        public bool Login(string id, string pw)
        {            
            member.Fill(dataSet.MEMBER);

            DataTable dt = dataSet.Tables["MEMBER"];
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["ID"].ToString().Equals(id) && dr["PASSWORD"].ToString().Equals(pw))
                {
                    userInfo.ID = dr["ID"].ToString();
                    userInfo.NAME = dr["NAME"].ToString();
                    userInfo.PHONE = dr["PHONE"].ToString();
                    userInfo.EMAIL = dr["EMAIL"].ToString();
                    userInfo.LASTCONNECTIONTIME = dr["LASTLOGIN"].ToString();

                    dr["LASTLOGIN"] = DateTime.Now.ToString();
                    member.Update(dataSet.MEMBER);
                    return true;
                }
            }
            return false;
        }

    }
}
