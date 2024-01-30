using System.CodeDom;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using WorkPlanner.Data;

namespace WorkPlanner
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void MainCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddIntervals_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value >= dateTimePicker2.Value)
            {
                MessageBox.Show("Interval end must be later than interval start.");
                dateTimePicker1.Focus();
                return;
            }
            try
            {
                using (var connection = new DataClasses1DataContext())
                {
                    var workInterval = new WorkInterval
                    {
                        Date = MainCalendar.SelectionRange.Start,
                        StartTime = dateTimePicker1.Value - dateTimePicker1.Value.Date,
                        EndTime = dateTimePicker2.Value - dateTimePicker1.Value.Date,
                        HoursWorked = (dateTimePicker2.Value.Hour - dateTimePicker1.Value.Hour + (float)(dateTimePicker2.Value.Minute - dateTimePicker1.Value.Minute) / 60)
                    };
                    connection.WorkIntervals.InsertOnSubmit(workInterval);
                    connection.SubmitChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
