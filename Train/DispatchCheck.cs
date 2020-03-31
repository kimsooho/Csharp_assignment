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
    public partial class DispatchCheck : Form
    {
        public DispatchCheck()
        {
            InitializeComponent();
        }
        

        private void DispatchCheck_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.DISPATCH' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.dISPATCHTableAdapter.Fill(this.dataSet1.DISPATCH);
            dISPATCHBindingSource.Sort = "DISPATCH ASC";

        }

        private void DirectionClick(object sender, EventArgs e)
        {
            if (rb_All.Checked)
            {
                // MessageBox.Show("전체");
                dISPATCHBindingSource.RemoveFilter();
                dISPATCHBindingSource.Sort = "DISPATCH ASC";
            }
            else if (rb_Seoul.Checked)
            {
                //  MessageBox.Show("서울");
                dISPATCHBindingSource.Filter = "DIRECTION = '서울행'";
                dISPATCHBindingSource.Sort = "DISPATCH ASC";
            }
            else if (rb_Busan.Checked)
            {
                //  MessageBox.Show("부산");
                dISPATCHBindingSource.Filter = "DIRECTION = '부산행'";
                dISPATCHBindingSource.Sort = "DISPATCH ASC";
            }
        }
    }



}
