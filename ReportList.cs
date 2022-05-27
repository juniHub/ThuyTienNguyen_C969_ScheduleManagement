using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThuyTienNguyen_C969_ScheduleManagement.DBModel;

namespace ThuyTienNguyen_C969_ScheduleManagement
{
    public partial class ReportList : Form
    {
        private Form Main;
        private List<User> ListOfUsers;

        public ReportList(Form form)
        {
            InitializeComponent();
            Main = form;
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            ListOfUsers = Database.getAllUsers();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                var text = new StringBuilder();
                text.AppendLine("Number of Appointment Types by Month:");
                text.AppendLine("-------------------------------------------------------------------");
               

                var groupedByMonthList = MainScreen.ListOfAppointments
                    // The following two lines contain Lambda expessions that order appointments, and group appointments to create a new list of appointments.
                 
                    .OrderBy(appt => appt.Start)
                    .GroupBy(appt => appt.Start.ToString("MMMM yyyy"));

                foreach (var group in groupedByMonthList)
                {
                    text.AppendLine($"{group.Key}:");
                    var groupedByTypeList = group.GroupBy(appt => appt.Type);

                    foreach (var list in groupedByTypeList)
                    {
                        text.AppendLine($"\t{list.Key}: {list.Count()}");
                    }
                    text.AppendLine();
                }

                reportTextBox.Text = text.ToString();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                var text = new StringBuilder();
                text.AppendLine("The Schedule for Each Consultant:");
                text.AppendLine("-------------------------------------------------------------------");


                var groupedByConsultantList = MainScreen.ListOfAppointments
                .GroupBy(appt => appt.UserId);

                foreach (var consultantList in groupedByConsultantList)
                {
                    text.AppendLine($"{ListOfUsers.Where(user => user.UserID == consultantList.Key).Single().UserName}'s Schedule:");
                    foreach (var appt in consultantList.OrderBy(appt => appt.Start))
                    {
                        text.AppendLine($"{MainScreen.ListOfCustomers.Where(customer => customer.CustomerId == appt.CustomerId).Single().CustomerName}:");
                        text.AppendLine($"\t{appt.Start.ToString("dddd M/d/yyyy h:mm tt")}.");
                    }
                    text.AppendLine("-------------------------------------------------------------------");
                }

                reportTextBox.Text = text.ToString();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                var text = new StringBuilder();
                text.AppendLine("Customers with Appointments This Month:");
                text.AppendLine("-------------------------------------------------------------------");


                DateTime beginningOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                DateTime endOfMonth = beginningOfMonth.AddMonths(1).AddMilliseconds(-1);

                var listOfAppointmentsThisMonthGroupedByCustomerId = MainScreen.ListOfAppointments.Where(appt => appt.Start >= beginningOfMonth && appt.Start <= endOfMonth)
                    .GroupBy(appt => appt.CustomerId);

                foreach (var appt in listOfAppointmentsThisMonthGroupedByCustomerId)
                {
                    text.AppendLine($"Name:\t{MainScreen.ListOfCustomers.Where(customer => customer.CustomerId == appt.Key).Single().CustomerName}");
                    text.AppendLine($"Phone:\t{MainScreen.AddressDictionary[appt.Key].Phone}");

                    text.AppendLine("-------------------------------------------------------------------");
                }

                reportTextBox.Text = text.ToString();
            }
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main.Show();
        }



    }
}
