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
{
    //요금 정하기 
    // 기본 요금 = 일반 요금
    // 어린이 = 일반 요금*0.7
    // 유아   = 일반 요금 * 0.5
    // 경로   = 일반 요금 * 0.5
    // 장애   = 일반 요금 * 0.4
    // 국가 유공자 = FREE
    public partial class SeatSelect : Form
    {
        int cost = Main.cost; // DB꺼 가져오기
        List<int> costSum;
        List<CheckBox> cb;
        List<int> peopleCount;
        int seatCount;
        int sum;
        CheckBox[,] arr = new CheckBox[3, 5];
        UserInfo userInfo = new UserInfo();
        int saveI = 999;
        int saveJ = 999;
        int save = 999;
        int[] arrr = new int[8];
        public SeatSelect()
        {
            InitializeComponent();
            oracleConnection1.Open();
        }

        private void SeatSelect_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.SEAT_STATUS' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.sEAT_STATUSTableAdapter.Fill(this.dataSet1.SEAT_STATUS);
            costSum = new List<int>();
            cb = new List<CheckBox>();
            peopleCount = new List<int>();
            sum = 0;
            cb.Add(checkBox1);
            cb.Add(checkBox2);
            cb.Add(checkBox3);
            cb.Add(checkBox4);
            cb.Add(checkBox5);
            cb.Add(checkBox6);
            cb.Add(checkBox7);
            cb.Add(checkBox8);

            for (int i = 0; i < 6; ++i)
            {
                peopleCount.Add(0);
            }
            for (int i = 0; i < 5; ++i)
            {
                costSum.Add(0);
            }

            //for (int i = 0; i < cb.Count; ++i)
            //{
            //    if (cb[i].Checked)
            //    {
            //        cb[i].Checked = false;
            //        cb[i].Enabled = false;
            //    }
            //}
            InitSeat();
            seatCount = 0;

            

        }

        private void OnlyNum(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_normal_TextChanged(object sender, EventArgs e)
        {
            if (tb_normal.Text.Equals(string.Empty))
            {
                normal.Text = "명";
                costSum[0] = 0;
                peopleCount[0] = 0;
            }
            else
            {
                costSum[0] = int.Parse(tb_normal.Text.ToString()) * cost;
                normal.Text = "명  " + costSum[0] + "원";
                peopleCount[0] = int.Parse(tb_normal.Text.ToString());
            }
            Sum();
        }

        private void tb_child_TextChanged(object sender, EventArgs e)
        {
            if (tb_child.Text.Equals(string.Empty))
            {
                child.Text = "명";
                costSum[1] = 0;
                peopleCount[1] = 0;
            }
            else
            {
                costSum[1] = int.Parse((int.Parse(tb_child.Text.ToString()) * cost * 0.7).ToString());
                child.Text = "명  " + costSum[1] + "원";
                peopleCount[1] = int.Parse(tb_child.Text.ToString());

            }
            Sum();
        }

        private void tb_baby_TextChanged(object sender, EventArgs e)
        {
            if (tb_baby.Text.Equals(string.Empty))
            {
                baby.Text = "명";
                costSum[2] = 0;
                peopleCount[2] = 0;
            }
            else
            {
                costSum[2] = int.Parse((int.Parse(tb_baby.Text.ToString()) * cost * 0.5).ToString());
                baby.Text = "명  " + costSum[2] + "원";
                peopleCount[2] = int.Parse(tb_baby.Text.ToString());
            }
            Sum();
        }

        private void tb_old_TextChanged(object sender, EventArgs e)
        {
            if (tb_old.Text.Equals(string.Empty))
            {
                old.Text = "명";
                costSum[3] = 0;
                peopleCount[3] = 0;
            }
            else
            {
                costSum[3] = int.Parse((int.Parse(tb_old.Text.ToString()) * cost * 0.5).ToString());
                old.Text = "명  " + costSum[3] + "원";
                peopleCount[3] = int.Parse(tb_old.Text.ToString());
            }
            Sum();
        }

        private void tb_disabled_TextChanged(object sender, EventArgs e)
        {
            if (tb_disabled.Text.Equals(string.Empty))
            {
                disabled.Text = "명";
                costSum[4] = 0;
                peopleCount[4] = 0;
            }
            else
            {
                costSum[4] = int.Parse((int.Parse(tb_disabled.Text.ToString()) * cost * 0.4).ToString());
                disabled.Text = "명  " + costSum[4] + "원";
                peopleCount[4] = int.Parse(tb_disabled.Text.ToString());
            }
            Sum();
        }

        private void tb_hero_TextChanged(object sender, EventArgs e)
        {
            if (tb_hero.Text.Equals(string.Empty))
            {
                hero.Text = "명";
                peopleCount[5] = 0;
            }
            else
            {
                hero.Text = "명  Free";
                peopleCount[5] = int.Parse(tb_hero.Text.ToString());
            }
        }

        private void Sum()
        {
            sum = 0;
            for (int i = 0; i < costSum.Count; ++i)
            {
                sum += costSum[i];
            }
            lb_cost.Text = "요금 : " + sum;
        }

        private void SelectSeatClick(object sender, EventArgs e)
        {
            seatCount = 0;
            for (int i = 0; i < cb.Count; ++i)
            {
                if (cb[i].Checked)
                    seatCount++;
                cb[i].Enabled = false;
            }
            lb_Seat.Text = "선택된 좌석 수 : " + seatCount.ToString();

        }

        private void RetryClick(object sender, EventArgs e)
        {
            for (int i = 0; i < cb.Count; ++i)
            {
                cb[i].Checked = false;
                cb[i].Enabled = true;
            }
            InitSeat();
            MessageBox.Show("좌석 선택을 다시 해주시기 바랍니다.");
            seatCount = 0;
            lb_Seat.Text = "선택된 좌석 수 : " + seatCount.ToString();

        }

        private void BookingClick(object sender, EventArgs e)
        {
            int cnt = 0;
            for (int i = 0; i < peopleCount.Count; ++i)
            {
                cnt += peopleCount[i];
            }

            if (cnt != seatCount)
            {
                MessageBox.Show("인원이 맞지 않습니다. 다시 확인해주세요! \n선택한 좌석 : " + seatCount.ToString() + "  인원 수 : " + cnt);
            }
            else
            {
                if (MessageBox.Show("인원 수 : " + cnt + "  요금 : " + sum + "\n예약 하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //디비에 넣기


                    string t_ID = Main.drow.Cells[0].Value.ToString();
                    string startStation = Main.drow.Cells[1].Value.ToString();
                    string startTime = Main.drow.Cells[3].Value.ToString();
                    string endStation = Main.drow.Cells[2].Value.ToString(); // startStation 에서 endStation까지
                    string direc = Main.drow.Cells[5].Value.ToString();
                    
                    for (int j = 1; j <= 4; ++j) // 1호차
                    {
                        if (cb[j - 1].Checked)
                        {
                            cmdSeatUpdate.Parameters["T_ID"].Value = t_ID;
                            cmdSeatUpdate.Parameters["R_NUM"].Value = 1;
                            cmdSeatUpdate.Parameters["S_NUM"].Value = j;
                            cmdSeatUpdate.Parameters["ST"].Value = startStation;

                            cmdSeatUpdate.ExecuteNonQuery();

                            ticketTableAdapter2.Fill(dataSet1.TICKET);
                            DataTable dt = dataSet1.TICKET;
                            DataRow dr = dt.NewRow();
                            dr["T_ID"] = DateTime.Now.Millisecond.ToString() + j;
                            dr["T_TIME"] = DateTime.Now.ToString();
                            dr["M_ID"] = userInfo.ID;
                            dr["TRAIN_ID"] = t_ID;
                            dr["ROOM_NUM"] = 1;
                            dr["S_NUM"] = j;
                            dr["ST_START"] = Main.drow.Cells[1].Value.ToString();
                            dr["ST_END"] = Main.drow.Cells[2].Value.ToString();
                            dr["COST"] = sum;
                            dr["START_TIME"] = Main.drow.Cells[3].Value.ToString();
                            dr["END_TIME"] = Main.drow.Cells[4].Value.ToString();
                            dr["DIRECTION"] = Main.drow.Cells[5].Value.ToString();                            
                            dt.Rows.Add(dr);

                            ticketTableAdapter2.Update(dataSet1.TICKET);

                        }
                    }

                    for (int j = 1; j <= 4; ++j) // 2호차
                    {
                        if (cb[j + 3].Checked)
                        {
                            cmdSeatUpdate.Parameters["T_ID"].Value = t_ID;
                            cmdSeatUpdate.Parameters["R_NUM"].Value = 2;
                            cmdSeatUpdate.Parameters["S_NUM"].Value = j;
                            cmdSeatUpdate.Parameters["ST"].Value = startStation;

                            cmdSeatUpdate.ExecuteNonQuery();

                            ticketTableAdapter2.Fill(dataSet1.TICKET);
                            DataTable dt = dataSet1.TICKET;
                            DataRow dr = dt.NewRow();
                            dr["T_ID"] = DateTime.Now.Millisecond.ToString() + j;
                            dr["T_TIME"] = DateTime.Now.ToString();
                            dr["M_ID"] = userInfo.ID;
                            dr["TRAIN_ID"] = t_ID;
                            dr["ROOM_NUM"] = 2;
                            dr["S_NUM"] = j;
                            dr["ST_START"] = Main.drow.Cells[1].Value.ToString();
                            dr["ST_END"] = Main.endStation;
                            dr["COST"] = sum;
                            dr["START_TIME"] = Main.drow.Cells[3].Value.ToString();
                            dr["END_TIME"] = Main.drow.Cells[4].Value.ToString();
                            dr["DIRECTION"] = Main.drow.Cells[5].Value.ToString();                            
                            dt.Rows.Add(dr);
                            ticketTableAdapter2.Update(dataSet1.TICKET);
                        }
                    }

                    while (true)
                    {

                        cmdSeat.Parameters["T_ID"].Value = t_ID;
                        cmdSeat.Parameters["ST"].Value = startStation;
                        cmdSeat.Parameters["DIREC"].Value = direc;

                        OracleDataReader rdr = cmdSeat.ExecuteReader();
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

                        startTime = rdr["START_TIME"].ToString();


                        for (int j = 1; j <= 4; ++j) // 1호차
                        {
                            if (cb[j - 1].Checked)
                            {
                                cmdSeatUpdate.Parameters["T_ID"].Value = t_ID;
                                cmdSeatUpdate.Parameters["R_NUM"].Value = 1;
                                cmdSeatUpdate.Parameters["S_NUM"].Value = j;
                                cmdSeatUpdate.Parameters["ST"].Value = startStation;
                                
                                cmdSeatUpdate.ExecuteNonQuery();


                            }
                        }

                        for (int j = 1; j <= 4; ++j) // 2호차
                        {
                            if (cb[j + 3].Checked)
                            {
                                cmdSeatUpdate.Parameters["T_ID"].Value = t_ID;
                                cmdSeatUpdate.Parameters["R_NUM"].Value = 2;
                                cmdSeatUpdate.Parameters["S_NUM"].Value = j;
                                cmdSeatUpdate.Parameters["ST"].Value = startStation;

                                cmdSeatUpdate.ExecuteNonQuery();
                            }
                        }
                    }

                  //  ticketTableAdapter2.Update(dataSet1.TICKET);
                    MessageBox.Show("예약이 완료되었습니다");
                    
                    
                    this.Close();
                }
            }
        }
        
        
        private void InitSeat()
        {
            for (int j = 1; j <= 4; ++j)
            {
                if (Main.seatArray[1, j] == 1)
                {
                    cb[j - 1].Enabled = false;
                    Main.arr[1, j] = 9999;
                }
            }

            for (int j = 1; j <= 4; ++j)
            {
                if (Main.seatArray[2, j] == 1)
                {
                    cb[j + 3].Enabled = false;
                    Main.arr[2, j] = 9999;
                }
            }

            for (int i = 1; i <= 2; ++i)
            {
                for (int j = 1; j <= 4; ++j)
                {                   
                    if (Main.arr[i, j] < save && Main.arr[i, j] != 0)
                    {
                        saveI = i;
                        saveJ = j;
                        save = Main.arr[i, j];
                    }
                }
            }
            if (saveI == 1)
            {
                cb[saveJ - 1].ForeColor = Color.Red;
            }
            else
            {
                cb[saveJ + 3].ForeColor = Color.Red;
            }

        }


    }
}
