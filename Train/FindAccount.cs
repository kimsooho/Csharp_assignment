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
    public partial class FindAccount : Form
    {        
        //완료
        DBHelper dbHelper = new DBHelper();
        public FindAccount()
        {
            InitializeComponent();
            this.ActiveControl = tb_Name;           
        }

        private void tb_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void SendMail_Click(object sender, EventArgs e)
        {            
            if (!dbHelper.FindAccount(tb_Name.Text, tb_Phone.Text, tb_email.Text.ToUpper()))
                MessageBox.Show("정보가 일치하지 않습니다");     
            
        }
    }
}
