using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalDay
{
    public partial class CalDayFrm : Form
    {
        public CalDayFrm()
        {
            InitializeComponent();
        }


        private void CalDayFrm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = new DateTime(1994,06,06);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime birthday = dateTimePicker1.Value;    
            txt10000Day.Text = CalLiveDay(birthday).ToString();      
            txtTotalDays.Text = Get10000DayDate(birthday).ToString();
        }

        int CalLiveDay(DateTime birthday)
        {
            DateTime endTime = DateTime.Now;
            TimeSpan timeSpan = endTime - birthday;
            return timeSpan.Days;
        }

        DateTime Get10000DayDate(DateTime birthday)
        {
            DateTime startTime = birthday;
            DateTime desinationTime = startTime.AddDays(10000);
            return desinationTime;
        }
    }
}
