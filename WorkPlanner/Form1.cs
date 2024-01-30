using System.CodeDom;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;

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
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Natur\source\repos\WorkPlanner\WorkPlanner\Database1.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(cs);

            try
            {
                connection.Open();
                string sql = "INSERT INTO [WorkIntervals](Date, StartTime, EndTime, HoursWorked) VALUES(@param1,@param2,@param3,@param4)";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.Add("@param1", SqlDbType.Date).Value = MainCalendar.SelectionRange.Start;
                    cmd.Parameters.Add("@param2", SqlDbType.Time, 50).Value = dateTimePicker1.Value - dateTimePicker1.Value.Date;
                    cmd.Parameters.Add("@param3", SqlDbType.Time, 50).Value = dateTimePicker2.Value - dateTimePicker1.Value.Date;
                    cmd.Parameters.Add("@param4", SqlDbType.Float, 50).Value = (dateTimePicker2.Value.Hour - dateTimePicker1.Value.Hour + (float)(dateTimePicker2.Value.Minute - dateTimePicker1.Value.Minute) / 60);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error appeared while conecting to database:" + ex.Message);
                connection.Close();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
