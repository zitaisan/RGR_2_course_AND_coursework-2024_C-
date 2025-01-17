using System;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace kursovaya
{
    public partial class Form1 : Form
    {
        private DateTime selectedDate;
        private bool islog;
        private int id;
        public Form1(bool islog, int id)
        {
            this.islog = islog;
            this.id = id;
            InitializeComponent();
            
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
            var selectedDate = monthCalendar1.SelectionStart;
            string data = selectedDate.ToString("yyyy-MM-dd");
            Form3 newForm = new Form3(data, islog, id);
            this.Visible= false;
            newForm.Show();      
        }
    }
}