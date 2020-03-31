using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Train
{  ///////DISPATCH 두개 조인해서 테이블에 띄우기
    public partial class Main : Form
    {   //완료 , 드롭박스 채울 것
        SetDate setDate = new SetDate();
        List<ComboBox> cb = new List<ComboBox>();
        //public static List<int> seatStatus = new List<int>();
        public static int[,] seatArray = new int[3, 5];
        public static int[,] arr = new int[3, 5];
        UserInfo userInfo = new UserInfo();
        public static int cost = 0;
        public static string direc = "부산행";
        public static DataGridViewRow drow;
        DataGridViewRow drow2;
        public static string endStation;        
        public Main()
        {
            InitializeComponent();

            oracleConnection1.Open();



            stationTableAdapter1.Fill(dataSet11.STATION);
            DataTable dt = dataSet11.Tables["STATION"];
            foreach (DataRow dr in dt.Rows)
            {
                cb_start.Items.Add(dr["ST_NAME"]);
                cb_end.Items.Add(dr["ST_NAME"]);
            }
            cb_start.SelectedIndex = 0;
            cb_end.SelectedIndex = 0;

            if (userInfo.LASTCONNECTIONTIME.Equals(string.Empty))
            {
                label_ID.Text = userInfo.NAME + " 님 안녕하세요!" + Environment.NewLine + Environment.NewLine + "첫 접속입니다!";
            }
            else
            {
                label_ID.Text = userInfo.NAME + " 님 안녕하세요!" + Environment.NewLine + Environment.NewLine + "최근 접속 시간 : " + userInfo.LASTCONNECTIONTIME;
            }

            DateTime date = DateTime.Now;
            label1.Text = date.Year + "년 " + date.Month + "월 " + date.Day + "일";



            for (int i = 0; i < 24; ++i)
            {
                cb_hour.Items.Add(i);
            }
            cb_hour.SelectedItem = date.Hour;

        }

        private void Select_Click(object sender, EventArgs e)
        {
            SeatSelect seatSelect = new SeatSelect();
            seatSelect.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet11.TICKET' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.tICKETTableAdapter2.FillByID(this.dataSet11.TICKET, userInfo.ID);

        }

        private void cb_start_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = dataSet11.Tables["STATION"];
            cb_end.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                if (cb_start.SelectedItem.Equals(dr["ST_NAME"].ToString()))
                    continue;
                cb_end.Items.Add(dr["ST_NAME"]);
            }
            cb_end.SelectedIndex = 0;
        }

        private void SearchTrainClick(object sender, EventArgs e) // 열차 조회하기 버튼**********
        {

            cost = 0;
            string stationName = cb_start.Text;
            endStation = cb_end.Text;
            string cmpTime = cb_hour.Text + ":00";
            DateTime date = Convert.ToDateTime(cmpTime);
            sectionTableAdapter1.FillBySec(dataSet11.SECTION, cb_start.Text, direc);
            DataTable dt = dataSet11.SECTION;
            DataRow dr; // SECTION

            try
            {
                dr = dt.Rows[0];
                while (true)
                {
                    cost += int.Parse(dr["COST"].ToString());
                    if (dr["END_ST"].ToString().Equals(cb_end.Text))
                    {
                        break;
                    }
                    sectionTableAdapter1.FillBySec(dataSet11.SECTION, dr["END_ST"].ToString(), direc);
                    dt = dataSet11.SECTION;
                    try
                    {
                        dr = dt.Rows[0];
                    }
                    catch (System.Exception)
                    {
                        
                    }
                }

                // dISPATCHTableAdapter.FillByCmp(dataSet11.DISPATCH, date.TimeOfDay.ToString(), stationName);
                dISPATCHTableAdapter.FillByCmp(dataSet11.DISPATCH, direc, cb_start.Text, cb_end.Text, date.TimeOfDay.ToString());
            }
            catch (SystemException)
            {
                MessageBox.Show("구간 및 방향을 확인해주세요.");
            }

        }

        private void SelectSeat(object sender, DataGridViewCellEventArgs e)////************
        {
            if (e.RowIndex < 0)
                return;
            MessageBox.Show("운행 기본 요금은 1인당 " + cost + "원 입니다");
            int count = 0;

            for (int i = 1; i <= 2; ++i)
            {
                for (int j = 1; j <= 4; ++j)
                {
                    seatArray[i, j] = 0;
                }
            }

            DataTable dtStatus;
            drow = dataGridView2.Rows[e.RowIndex];

            string t_ID = drow.Cells[0].Value.ToString();
            string startStation = drow.Cells[1].Value.ToString();
            string startTime = drow.Cells[3].Value.ToString();


            for (int i = 1; i <= 2; ++i)
            {
                for (int j = 1; j <= 4; ++j)
                {
                    try
                    {
                        seaT_STATUSTableAdapter1.FillByStatus(dataSet11.SEAT_STATUS, i, j, t_ID,
                            startStation, direc, startTime);  // START_TIME 확인할 것 **
                        dtStatus = dataSet11.SEAT_STATUS;

                        foreach (DataRow drStatus in dtStatus.Rows)
                        {
                            if (drStatus["STATUS"].ToString().Equals("1"))
                            {
                                seatArray[i, j] = 1;
                                count++;
                            }
                        }
                    }
                    catch (SystemException ex)
                    {
                       // MessageBox.Show(ex.Message);
                    }
                }
            }

            while (true)
            {

                cmdSeatHelper.Parameters["T_ID"].Value = t_ID;
                cmdSeatHelper.Parameters["ST"].Value = startStation;
                cmdSeatHelper.Parameters["DIREC"].Value = direc;

                OracleDataReader rdr = cmdSeatHelper.ExecuteReader();
                rdr.Read();

                startStation = rdr["ST_NAME"].ToString();
                if (startStation.Equals("부산") || startStation.Equals("서울"))
                {
                    break;
                }
                else if (startStation.Equals(cb_end.Text))
                {
                    break;
                }

                startTime = rdr["START_TIME"].ToString();
                for (int i = 1; i <= 2; ++i)
                {
                    for (int j = 1; j <= 4; ++j)
                    {

                        try
                        {
                            // 열차번호, 현재 역, 방향, 출발 시간
                            seaT_STATUSTableAdapter1.FillByStatus(dataSet11.SEAT_STATUS, i, j, t_ID,
                                startStation, direc, startTime);  // START_TIME 확인할 것 **
                            dtStatus = dataSet11.SEAT_STATUS;

                            foreach (DataRow drStatus in dtStatus.Rows)
                            {
                                if (drStatus["STATUS"].ToString().Equals("1")) // 예약이 있을 때
                                {
                                    seatArray[i, j] = 1;
                                    count++;
                                }
                            }
                        }
                        catch (SystemException ex)
                        {
                           // MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            //////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 5; ++j)
                {
                    arr[i, j] = 0;
                }
            }
            /////////////////////**********************************
            if (direc.Equals("서울행"))
            {
                startStation = "부산";                
            }
            else
            {
                startStation = "서울";
            }
            for (int i = 1; i <= 2; ++i)
            {
                for (int j = 1; j <= 4; ++j)
                {
                    try
                    {
                        seaT_STATUSTableAdapter1.FillByTEST(dataSet11.SEAT_STATUS, i, j, t_ID, startStation, direc); 
                        dtStatus = dataSet11.SEAT_STATUS;

                        foreach (DataRow drStatus in dtStatus.Rows)
                        {
                            if (drStatus["STATUS"].ToString().Equals("0"))
                            {
                                arr[i, j]++;
                            }
                        }
                    }
                    catch (SystemException)
                    {
                        // MessageBox.Show(ex.Message);
                    }
                }
            }

            while (true)
            {

                cmdSeatHelper.Parameters["T_ID"].Value = t_ID;
                cmdSeatHelper.Parameters["ST"].Value = startStation;
                cmdSeatHelper.Parameters["DIREC"].Value = direc;

                OracleDataReader rdr = cmdSeatHelper.ExecuteReader();
                rdr.Read();
             //   MessageBox.Show(rdr["ST_NAME"].ToString());
                startStation = rdr["ST_NAME"].ToString();
                if (startStation.Equals("부산") || startStation.Equals("서울"))
                {
                    break;
                }
                
                for (int i = 1; i <= 2; ++i)
                {
                    for (int j = 1; j <= 4; ++j)
                    {

                        try
                        {                            
                            seaT_STATUSTableAdapter1.FillByTEST(dataSet11.SEAT_STATUS, i, j, t_ID,
                                startStation, direc);
                            dtStatus = dataSet11.SEAT_STATUS;

                            foreach (DataRow drStatus in dtStatus.Rows)
                            {
                                if (drStatus["STATUS"].ToString().Equals("0")) 
                                {
                                    arr[i, j]++;
                                }
                            }
                        }
                        catch (SystemException)
                        {
                            // MessageBox.Show(ex.Message);
                        }
                    }
                }
            }

/////////////////////////////////////////////////////////////////////////////////////////
            SeatSelect seatSelect = new SeatSelect();
            seatSelect.ShowDialog();
        }


        private void DicrecClick(object sender, EventArgs e)
        {
            if (rb_bu.Checked)
            {
                direc = "부산행";
            }
            else if (rb_seo.Checked)
            {
                direc = "서울행";
            }
        }

        private void btnDispatchCheck_Click(object sender, EventArgs e)
        {
            DispatchCheck dispatchCheck = new DispatchCheck();
            dispatchCheck.ShowDialog();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            this.tICKETTableAdapter2.FillByID(this.dataSet11.TICKET, userInfo.ID);            
        }


        private void TicketView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            drow2 = TicketView.Rows[e.RowIndex];
            if (MessageBox.Show("예약을 취소 하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //MessageBox.Show(drow2.Cells[1].Value.ToString());
                string t_ID = drow2.Cells[1].Value.ToString();
                string startStation = drow2.Cells[4].Value.ToString();
                string startTime = drow2.Cells[6].Value.ToString();
                string endStation = drow2.Cells[5].Value.ToString(); // startStation 에서 endStation까지

                cmdSeatCancel.Parameters["T_ID"].Value = t_ID;
                cmdSeatCancel.Parameters["R_NUM"].Value = drow2.Cells[2].Value;
                cmdSeatCancel.Parameters["S_NUM"].Value = drow2.Cells[3].Value;
                cmdSeatCancel.Parameters["ST"].Value = startStation;

                cmdSeatCancel.ExecuteNonQuery();


                while (true)
                {

                    cmdSeatHelper.Parameters["T_ID"].Value = t_ID;
                    cmdSeatHelper.Parameters["ST"].Value = startStation;
                    cmdSeatHelper.Parameters["DIREC"].Value = drow2.Cells[8].Value.ToString(); // 방향 

                    OracleDataReader rdr = cmdSeatHelper.ExecuteReader();
                    rdr.Read();

                    startStation = rdr["ST_NAME"].ToString();
                    if (startStation.Equals("부산") || startStation.Equals("서울"))
                    {
                        break;
                    }
                    else if (startStation.Equals(endStation))
                    {
                        break;
                    }
                 //   MessageBox.Show(startStation);
                    startTime = rdr["START_TIME"].ToString();


                    cmdSeatCancel.Parameters["T_ID"].Value = t_ID;
                    cmdSeatCancel.Parameters["R_NUM"].Value = drow2.Cells[2].Value;
                    cmdSeatCancel.Parameters["S_NUM"].Value = drow2.Cells[3].Value;
                    cmdSeatCancel.Parameters["ST"].Value = startStation;
                    cmdSeatCancel.ExecuteNonQuery();

                }
                tICKETBindingSource.RemoveCurrent();
                tICKETTableAdapter2.Update(dataSet11.TICKET);

                MessageBox.Show("예약이 취소 되었습니다.", "삭제");
            }
            else
            {
                MessageBox.Show("취소되었습니다.", "취소");
            }
        }

    }
}