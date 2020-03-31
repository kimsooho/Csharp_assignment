using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Train
{
    class SetDate
    {
        DateTime dt;
        //완료
        public SetDate()
        {
            dt = new DateTime();
            dt = DateTime.Now;            
        }

        public void SetDateTime(List<ComboBox> cb)
        {
            cb[0].SelectedItem = dt.Year;
            cb[1].SelectedItem = dt.Month;
            cb[2].SelectedItem = dt.Day;
            cb[3].SelectedItem = dt.Hour;
        }

        public void SetYearMonth(ComboBox year, ComboBox month)
        {

            for (int i = dt.Year; i < dt.Year + 10; ++i)
            {
                year.Items.Add(i);
            }
            for (int i = 1; i <= 12; ++i)
            {
                month.Items.Add(i);
            }
        }


        public void SetDay(ComboBox day, int year, int month)
        {
            day.Items.Clear();
            int days = DateTime.DaysInMonth(year, month);

            for (int i = 1; i <= days; ++i)
            {
                day.Items.Add(i);
            }
            day.SelectedIndex = 0;            
        }

        public void SetDay(ComboBox cb)
        {
            int days = DateTime.DaysInMonth(dt.Year, dt.Month);
            for (int i = 1; i <= days; ++i)
            {
                cb.Items.Add(i);
            }
        }

        public void SetHour(ComboBox cb)
        {
            for(int i = 0; i <= 24; ++i)
            {
                cb.Items.Add(i);
            }
        }
    }
}
