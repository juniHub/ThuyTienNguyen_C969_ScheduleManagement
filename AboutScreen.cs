using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuyTienNguyen_C969_ScheduleManagement
{
    public partial class AboutScreen : Form
    {

        private string aboutText = "Welcome to Smart Scheduler\n The smartest tool to help your consulting business\n to shedule and keep track of apppointments\n with your valuable customers. ";

        private Form Main;

        public AboutScreen(Form main)
        {
            InitializeComponent();
            Main = main;
        }


        private void AboutScreen_Load(object sender, EventArgs e)
        {
            aboutLabel.Text = aboutText;
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Main.Show();
        }
    }
}
