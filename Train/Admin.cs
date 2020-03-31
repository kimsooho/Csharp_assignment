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
    public partial class Admin : Form
    {
        int[] days = new int[7];


        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet11.DISPATCH' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.dISPATCHTableAdapter.Fill(this.dataSet11.DISPATCH);
            dISPATCHBindingSource.Sort = "DISPATCH ASC";            

            // TODO: 이 코드는 데이터를 'dataSet11.SECTION' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.sECTIONTableAdapter.Fill(this.dataSet11.SECTION);
            sECTIONBindingSource.Sort = "DIRECTION ASC";            

            // TODO: 이 코드는 데이터를 'dataSet11.TRAIN' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.tRAINTableAdapter.Fill(this.dataSet11.TRAIN);

            // TODO: 이 코드는 데이터를 'dataSet11.DIRECTION' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.dIRECTIONTableAdapter.Fill(this.dataSet11.DIRECTION);

            // TODO: 이 코드는 데이터를 'dataSet11.STATION' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.sTATIONTableAdapter.Fill(this.dataSet11.STATION);




            //StationView.ReadOnly = true;
            //SectionView.ReadOnly = true;
            //DispatchView.ReadOnly = true;

            rb_All.Checked = true;

            for(int i=0;i<24; ++i){
                cb_Hour.Items.Add(i.ToString());
            }
            for (int i = 0; i < 60; ++i)
            {
                cb_Min.Items.Add(i.ToString());
            }
            cb_Hour.SelectedIndex = 0;
            cb_Min.SelectedIndex = 0;

            oracleConnection1.Open();
            OracleDataReader dr = cmdUserCount.ExecuteReader();

            while (dr.Read())
            {
                chart1.Series[0].Points.AddXY(dr["id"], dr["cnt"]);
            }

            dr = cmdStationCount.ExecuteReader();

            while (dr.Read())
            {
                chart2.Series[0].Points.AddXY(dr["st"], dr["stcnt"]);
            }


            dr = cmdDays.ExecuteReader();
            while (dr.Read())
            {
                DateTime date = Convert.ToDateTime(dr["T_TIME"].ToString());
                switch (date.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                        chart3.Series[0].Points[0].SetValueY(++days[0]);
                        break;
                    case DayOfWeek.Tuesday:
                        chart3.Series[0].Points[1].SetValueY(++days[1]);
                        break;
                    case DayOfWeek.Wednesday:
                        chart3.Series[0].Points[2].SetValueY(++days[2]);
                        break;
                    case DayOfWeek.Thursday:
                        chart3.Series[0].Points[3].SetValueY(++days[3]);
                        break;
                    case DayOfWeek.Friday:
                        chart3.Series[0].Points[4].SetValueY(++days[4]);
                        break;
                    case DayOfWeek.Saturday:
                        chart3.Series[0].Points[5].SetValueY(++days[5]);
                        break;
                    case DayOfWeek.Sunday:
                        chart3.Series[0].Points[6].SetValueY(++days[6]);
                        break;
                }
            }

            dr.Close();
            oracleConnection1.Close();

        }

        private void RemoveStationClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("삭제하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sTATIONBindingSource.RemoveCurrent();
                sTATIONTableAdapter.Update(dataSet11.STATION);
                MessageBox.Show("삭제되었습니다.", "삭제");
            }
            else
            {
                MessageBox.Show("취소되었습니다.", "취소");
            }
            
        }

        private void StationSaveClick(object sender, EventArgs e)
        {
            this.sTATIONTableAdapter.Update(this.dataSet11.STATION);
            //  StationView.ReadOnly = true;
            MessageBox.Show("저장되었습니다", "확인");
        }

        private void AddStationClick(object sender, EventArgs e)
        {
            StationView.ReadOnly = false;
            sTATIONBindingSource.AddNew();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void AddSectionClick(object sender, EventArgs e)
        {
            SectionView.ReadOnly = false;
            sECTIONBindingSource.AddNew();
        }

        private void RemoveSectionClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("삭제하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sECTIONBindingSource.RemoveCurrent();
                MessageBox.Show("삭제되었습니다.", "삭제");
            }
            else
            {
                MessageBox.Show("취소되었습니다.", "취소");
            }
        }

        private void SectionSaveClick(object sender, EventArgs e)
        {
            this.sECTIONTableAdapter.Update(this.dataSet11.SECTION);
            //   SectionView.ReadOnly = true;
            MessageBox.Show("저장되었습니다", "확인");
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void AddDispatchClick(object sender, EventArgs e) //// 배차 자동 추가
        {
            DataTable dt = dataSet11.DISPATCH;            
            DataRow dr = dt.NewRow();

            DataTable dtSeat = dataSet11.SEAT_STATUS; // TRAIN_ID, ROOM_NUM, S_NUM, ST_NAME, START_TIME, DIRECTION, STATUS
            DataRow drSeat;

            DateTime date = DateTime.Now;
            
            string direction = cb_Direction.Text;
            string tmpdate = cb_Hour.Text + ":" + cb_Min.Text;
            date = Convert.ToDateTime(tmpdate);
            
            if (direction.Equals("서울행"))
            {
                dr["ST_NAME"] = "부산";
            }
            else
            {
                dr["ST_NAME"] = "서울";
            }
            dr["TRAIN_ID"] = cb_TrainID.Text;
            dr["DISPATCH"] = "-";
            dr["START_TIME"] = date.TimeOfDay.ToString();
            dr["DIRECTION"] = cb_Direction.Text;

            for (int i = 1; i <= 2; ++i) // 객차        자동생성
            {
                for (int j = 1; j <= 4; ++j) // 좌석    자동 생성
                {
                    drSeat = dtSeat.NewRow();
                    drSeat["ST_NAME"] = dr["ST_NAME"].ToString();
                    drSeat["TRAIN_ID"] = cb_TrainID.Text;
                    drSeat["START_TIME"] = date.TimeOfDay.ToString();
                    drSeat["DIRECTION"] = cb_Direction.Text;
                    drSeat["STATUS"] = 0;

                    drSeat["ROOM_NUM"] = i.ToString();
                    drSeat["S_NUM"] = j.ToString();
                    dtSeat.Rows.Add(drSeat);
                }
            }

            try
            {
                dt.Rows.Add(dr);                
            }
            
            catch (System.Exception E){
                MessageBox.Show(E.Message);
                return;
            }



            date = Convert.ToDateTime(dr["START_TIME"].ToString());

            sECTIONTableAdapter.FillBySec(dataSet11.SECTION, dr["ST_NAME"].ToString(), direction); // 다음 역 정보 가져오기
            DataTable dtSec = dataSet11.SECTION;
            DataTable dtSt = dataSet11.STATION;
            DataRow drSec;
            DataRow drSt;


            // 열차 번호 , 역 , 도착시간, 출발시간 ,방향
            // 도착역, 출발역, 소요시간, 요금, 방향
            // 역, 정차시간

            drSec = dtSec.Rows[0]; // 출발 역이 있냐? 있으면 밑에거도 됨
            sTATIONTableAdapter.FillByWaiting(dataSet11.STATION, drSec["END_ST"].ToString());
            drSt = dtSt.Rows[0]; // 역이름, 정차시간

            dr = dt.NewRow();
            date = date.AddMinutes(int.Parse(drSec["INTERVALTIME"].ToString()));
            dr["TRAIN_ID"] = cb_TrainID.Text;
            dr["DISPATCH"] = date.TimeOfDay;

            date = date.AddMinutes(int.Parse(drSt["WAITINGTIME"].ToString())); // 정차시간 더하기
            dr["START_TIME"] = date.TimeOfDay;
            dr["DIRECTION"] = cb_Direction.Text;
            dr["ST_NAME"] = drSt["ST_NAME"].ToString();


            for (int i = 1; i <= 2; ++i) // 객차        자동생성
            {
                for (int j = 1; j <= 4; ++j) // 좌석    자동 생성
                {
                    drSeat = dtSeat.NewRow();
                    drSeat["ST_NAME"] = dr["ST_NAME"].ToString();
                    drSeat["TRAIN_ID"] = cb_TrainID.Text;
                    drSeat["START_TIME"] = date.TimeOfDay.ToString();
                    drSeat["DIRECTION"] = cb_Direction.Text;
                    drSeat["STATUS"] = 0;

                    drSeat["ROOM_NUM"] = i.ToString();
                    drSeat["S_NUM"] = j.ToString();
                    dtSeat.Rows.Add(drSeat);
                }
            }

            dt.Rows.Add(dr);




            while (true)
            {
                sECTIONTableAdapter.FillBySec(dataSet11.SECTION, drSec["END_ST"].ToString(), direction);
                drSec = dtSec.Rows[0]; // 출발 역이 있냐? 있으면 밑에거도 됨
                sTATIONTableAdapter.FillByWaiting(dataSet11.STATION, drSec["END_ST"].ToString());
                drSt = dtSt.Rows[0]; // 역이름, 정차시간


                dr = dt.NewRow();
                date = date.AddMinutes(int.Parse(drSec["INTERVALTIME"].ToString()));
                dr["TRAIN_ID"] = cb_TrainID.Text;
                dr["DISPATCH"] = date.TimeOfDay;

                date = date.AddMinutes(int.Parse(drSt["WAITINGTIME"].ToString())); // 정차시간 더하기
                dr["START_TIME"] = date.TimeOfDay;
                dr["DIRECTION"] = cb_Direction.Text;
                dr["ST_NAME"] = drSt["ST_NAME"].ToString();
                //                MessageBox.Show(drSec["END_ST"].ToString());
                dt.Rows.Add(dr);

                for (int i = 1; i <= 2; ++i) // 객차        자동생성
                {
                    for (int j = 1; j <= 4; ++j) // 좌석    자동 생성
                    {
                        drSeat = dtSeat.NewRow();
                        drSeat["ST_NAME"] = dr["ST_NAME"].ToString();
                        drSeat["TRAIN_ID"] = cb_TrainID.Text;
                        drSeat["START_TIME"] = date.TimeOfDay.ToString();
                        drSeat["DIRECTION"] = cb_Direction.Text;
                        drSeat["STATUS"] = 0;

                        drSeat["ROOM_NUM"] = i.ToString();
                        drSeat["S_NUM"] = j.ToString();
                        dtSeat.Rows.Add(drSeat);
                    }
                }

                if (drSec["END_ST"].ToString().Equals("부산")) // --------부산행 끝
                {
                    dr["START_TIME"] = "-";
                    break;
                }
                else if (drSec["END_ST"].ToString().Equals("서울")) // ----------서울행 끝
                {
                    dr["START_TIME"] = "-";
                    break;
                }

            }

            this.dISPATCHTableAdapter.Update(this.dataSet11.DISPATCH);
            try
            {
                this.seaT_STATUSTableAdapter1.Update(this.dataSet11.SEAT_STATUS);
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.sECTIONTableAdapter.Fill(this.dataSet11.SECTION);
            sECTIONBindingSource.Sort = "DIRECTION ASC";
            this.sTATIONTableAdapter.Fill(this.dataSet11.STATION);
        }


        private void RemoveDispatchClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("삭제하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dISPATCHBindingSource.RemoveCurrent();
                this.dISPATCHTableAdapter.Update(this.dataSet11.DISPATCH);            
                MessageBox.Show("삭제되었습니다.", "삭제");
            }
            else
            {
                MessageBox.Show("취소되었습니다.", "취소");
            }
        }

        private void SaveDispatchClick(object sender, EventArgs e)
        {
            this.dISPATCHTableAdapter.Update(dataSet11.DISPATCH);
            //     DispatchView.ReadOnly = true;
            MessageBox.Show("저장되었습니다", "확인");
        }

        private void DirectionClick(object sender, EventArgs e)
        {
            if (rb_All.Checked)
            {
                // MessageBox.Show("전체");
                dISPATCHBindingSource.RemoveFilter();
            }
            else if (rb_Seoul.Checked)
            {
                //  MessageBox.Show("서울");
                dISPATCHBindingSource.Filter = "DIRECTION = '서울행'";
            }
            else if (rb_Busan.Checked)
            {
                //  MessageBox.Show("부산");
                dISPATCHBindingSource.Filter = "DIRECTION = '부산행'";
            }
        }
    }
}
