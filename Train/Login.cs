using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Train
{
    public partial class Login : Form
    {
        //완료
        Flag flag = new Flag();
        DBHelper dBHelper = new DBHelper();
        static public string _id = string.Empty;
        public Login()
        {
            InitializeComponent();
            tb_ID.Focus();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string id = tb_ID.Text.ToUpper();
            if (tb_ID.Text.Equals(string.Empty) || tb_PW.Text.Equals(string.Empty))
            {
                MessageBox.Show("ID 또는 P/W를 입력해주세요.");
                return;
            }

            if (dBHelper.Login(id, tb_PW.Text)){

                flag.LOGIN = true;
                if (id.Equals("ADMIN"))
                {
                    flag.ADMIN = true;
                }
                else
                {
                    _id = tb_ID.Text;
                }
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("로그인 정보가 일치하지 않습니다.", "실패");
            }
        }
        private void Signup_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.ShowDialog();
        }

        private void Account_Click(object sender, EventArgs e)
        {
            FindAccount findAccount = new FindAccount();
            findAccount.ShowDialog();
        }
    }
}
