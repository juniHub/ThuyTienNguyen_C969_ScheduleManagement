using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ThuyTienNguyen_C969_ScheduleManagement.DBModel;

namespace ThuyTienNguyen_C969_ScheduleManagement
{
    public partial class MainScreen : Form
    {
        public static User LoggedInUser;
        public static BindingList<Customer> ListOfCustomers = new BindingList<Customer>();
        public static BindingList<Appointment> ListOfAppointments = new BindingList<Appointment>();
        public static Dictionary<int, Address> AddressDictionary = new Dictionary<int, Address>();
        public static Dictionary<int, City> CityDictionary = new Dictionary<int, City>();
        public static Dictionary<int, Country> CountryDictionary = new Dictionary<int, Country>();

        public MainScreen(User user)
        {
            InitializeComponent();
            LoggedInUser = user;
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

            Database.getCustomers();
            Database.getAddresses();
            Database.getCities();
            Database.getCountries();
            Database.getAppointments();
        }

     
        private void customersButton_Click(object sender, EventArgs e)
        {
            var customerRecords = new CustomerList(this);
            customerRecords.Show();
            Hide();
        }

        private void appointmentsButton_Click(object sender, EventArgs e)
        {
            var appointmentScreen = new AppointmentList(this);
            appointmentScreen.Show();
            Hide();
        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            var reportsScreen = new ReportList(this);
            reportsScreen.Show();
            Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
            
        private void MainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //a notice will be shown in window form for the users if they have apppointments within 15 minutes
        private void MainScreen_Shown(object sender, EventArgs e)
        {
            var apptInFifteenMinutes = ListOfAppointments.Where(appt =>
            {
                var now = DateTime.Now;
                var fifteenMinutes = new TimeSpan(0, 15, 0);
                var timeLeft = appt.Start - now;

                if (timeLeft > new TimeSpan(0, 0, 0) && timeLeft <= fifteenMinutes)
                {
                    return true;
                }
                return false;
            });


            if (apptInFifteenMinutes.Count() > 0)
            {
               var appointment = apptInFifteenMinutes.First();
               
               MessageBox.Show($"You have an appointment with {ListOfCustomers.Where(cust => cust.CustomerId == appointment.CustomerId).Single().CustomerName} at {appointment.Start.ToString("h:mm tt")}.", "Upcoming Appointment", MessageBoxButtons.OK);
            }
        }
    }
}
