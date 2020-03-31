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
    public partial class Signup : Form
    {
        DBHelper dbhelper = new DBHelper();
        //완료
        public Signup()
        {
            InitializeComponent();
            check.ForeColor = Color.Red;
            this.ActiveControl = tb_ID;

        }

        private void tb_Phone_KeyPress(object sender, KeyPressEventArgs e) // 휴대폰 번호 숫자만 입력가능
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Signup_click(object sender, EventArgs e)
        {
            if (!btn_IdCheck.Enabled && check.ForeColor == Color.Green && !(tb_email.Text.Equals(string.Empty) || tb_Name.Text.Equals(string.Empty) || tb_Phone.Text.Equals(string.Empty))) // ID 중복 확인과 PW 확인 완료, 빈칸 없이
            {
                if (dbhelper.Signup(tb_ID.Text, tb_PW.Text, tb_Name.Text, tb_Phone.Text, tb_email.Text)) // 회원가입 성공 시 ture 반환
                {
                    MessageBox.Show("회원가입이 완료 되었습니다.", "성공");

                    this.Close();
                    this.Dispose();
                }
                else
                    MessageBox.Show("회원가입에 실패했습니다.", "실패");
            }
            else
            {
                MessageBox.Show("다시 시도해주세요.","실패");
            }

        }

        private void PW_Check(object sender, EventArgs e)
        {
            if (tb_PW.Text.Equals(tb_CKECK.Text) && !(tb_PW.Text.Equals(string.Empty)))
            {
                check.ForeColor = Color.Green;                
            }
            else
            {
                check.ForeColor = Color.Red;                
            }
        }

        private void ID_Check_Click(object sender, EventArgs e)
        {
            if (tb_ID.Text.Equals(""))
            {
                MessageBox.Show("ID를 입력해주세요","실패");
                return;
            }

            if (dbhelper.ID_Check(tb_ID.Text.ToUpper())) // 아이디 중복되지 않으면 true
            {
                MessageBox.Show("사용할 수 있는 ID입니다!", "성공");
                btn_IdCheck.Enabled = false;
                btn_IdCheck.Text = "확인 완료";
            }
            else
            {
                MessageBox.Show("중복된 ID입니다. 다시 입력해주세요", "실패");
            }
        }

        private void ID_Check(object sender, EventArgs e)
        {
            btn_IdCheck.Enabled = true;
            btn_IdCheck.Text = "중복 확인";
        }
    }
}
