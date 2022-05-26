using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using ThuyTienNguyen_C969_ScheduleManagement.DBModel;

namespace ThuyTienNguyen_C969_ScheduleManagement
{
    public partial class AppointmentList : Form
    {
        private Form Main;
        private DateTime SelectedDate;
      

        public AppointmentList(Form main)
        {
            InitializeComponent();
            MainLabel.Text = $"Appointments for { MainScreen.LoggedInUser.UserName }";
            Main = main;
            SelectedDate = DateTime.Now;
            DatesRadioButton.Checked = true;
        }

        private void AppointmentsForm_Load(object sender, EventArgs e)
        {

            displayAllAppts();
            populateComboBoxAppointmentType();

        }

   
        private void populateComboBoxAppointmentType()
        {
            comboBoxAppointmentType.DataSource = new[] { "Scrum", "Presentation", "Lunch", "Interview", "Consultation", "In Office" };
            comboBoxAppointmentType.SelectedItem = null;
        }

        private void displayAllAppts()
        {
            appointmentDataGridView.DataSource = MainScreen.ListOfAppointments;
        }

        private void displayThisMonth()
        {
            dateTimePickerStartDate.Value = findBeginningOfMonth(DateTime.Now);
            dateTimePickerEndDate.Value = findEndOfMonth(DateTime.Now);
            appointmentDataGridView.DataSource = getAppointmentsInTimePeriod(dateTimePickerStartDate.Value, dateTimePickerEndDate.Value);
        }

      
        private void displayThisWeek()
        {
            dateTimePickerStartDate.Value = findBeginningOfWeek(DateTime.Now);
            dateTimePickerEndDate.Value = findEndOfWeek(DateTime.Now);
            appointmentDataGridView.DataSource = getAppointmentsInTimePeriod(dateTimePickerStartDate.Value, dateTimePickerEndDate.Value);
        }

        

        private void AppointmentsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main.Show();
        }

        private void formatDataGridView()
        {
            var dataGridView = appointmentDataGridView;
            dataGridView.AutoResizeColumns();
            dataGridView.RowHeadersVisible = false;
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;
            dataGridView.ClearSelection();
        }

        private void appointmentDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            formatDataGridView();
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            var addForm = new AppointmentControl(this);
            addForm.Show();
            appointmentDataGridView.ClearSelection();
            Hide();
        }

        private void editButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (appointmentDataGridView.SelectedRows.Count < 1)
                {
                    throw new ApplicationException("You must select an appointment to edit.");
                }
                var selectedRow = appointmentDataGridView.SelectedRows[0];
                int selectedAppointmentId = Convert.ToInt32(selectedRow.Cells[0].Value);
                var editForm = new AppointmentControl(this, selectedAppointmentId);
                editForm.Show();
                appointmentDataGridView.ClearSelection();
                Hide();
            }
            catch (ApplicationException error)
            {
                MessageBox.Show(error.Message, "Instructions", MessageBoxButtons.OK);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK);
            }
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (appointmentDataGridView.SelectedRows.Count < 1)
                {
                    throw new ApplicationException("You must select an appointment to delete.");
                }
                DialogResult confirmDelete = MessageBox.Show("Are you sure you want to delete the selected appointment?", "Application Instruction", MessageBoxButtons.YesNo);
                if (confirmDelete == DialogResult.Yes)
                {
                    var selectedRow = appointmentDataGridView.SelectedRows[0];
                    int selectedAppointmentId = Convert.ToInt32(selectedRow.Cells[0].Value);
                    Appointment selectedAppointment = MainScreen.ListOfAppointments.Where(appt => appt.AppointmentId == selectedAppointmentId).Single();
                    Database.deleteAppointment(selectedAppointment);

                }
                else
                {
                    appointmentDataGridView.ClearSelection();
                }
            }
            catch (ApplicationException error)
            {
                MessageBox.Show(error.Message, "Instructions", MessageBoxButtons.OK);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Main.Show();
        }


        private DateTime findBeginningOfWeek(DateTime date)
        {
            var culture = Thread.CurrentThread.CurrentCulture;
            var difference = date.DayOfWeek - culture.DateTimeFormat.FirstDayOfWeek;
            if (difference < 0)
            {
                difference = difference + 7;
            }
            return date.AddDays(-difference).Date;
        }

        private DateTime findEndOfWeek(DateTime date)
        {
            return findBeginningOfWeek(date).AddDays(7).AddMilliseconds(-1);
        }

        private DateTime findBeginningOfMonth(DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1);
        }

        private DateTime findEndOfMonth(DateTime date)
        {
            return findBeginningOfMonth(date).AddMonths(1).AddMilliseconds(-1);
        }

        private BindingList<Appointment> getAppointmentsInTimePeriod(DateTime beginTime, DateTime endTime)
        {
            //used the following lambda in linq statement to recreate list of Appointments that fall within the begin and end time bounds.
            return new BindingList<Appointment>(MainScreen.ListOfAppointments.Where(appt => appt.Start >= beginTime && appt.End <= endTime).ToList());
        }

        private BindingList<Appointment> getAppointmentsByCustomerId(int id)
        {
            return new BindingList<Appointment>(MainScreen.ListOfAppointments.Where(appt => appt.CustomerId == id).ToList());
        }


        private BindingList<Appointment> getAppointmentsByAppointmentType(string type)
        {
            return new BindingList<Appointment>(MainScreen.ListOfAppointments.Where(appt => appt.Type == type).ToList());
        }

          

        private void DateRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            CustomerIDLabel.Visible = false;
            AppointmentTypeLabel.Visible = false;
            CustomerIDtextbox.Visible = false;
            comboBoxAppointmentType.Visible = false;
            StartDateLabel.Visible = true;
            EndDateLabel.Visible = true;
            dateTimePickerStartDate.Visible = true;
            dateTimePickerEndDate.Visible = true;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (CustomerIDRadioButton.Checked == true)
            {
                updateViewOnCustomerID();
            }

            if (AppointmentTypeRadioButton.Checked == true)
            {
                updateViewOnAppointmentType();
            }
            if (DatesRadioButton.Checked == true)
            {
                updateViewOnDate();
            }
        }


        private void updateViewOnCustomerID()
        {
            int customerId = 0;
            int.TryParse(CustomerIDtextbox.Text, out customerId);
            if (customerId < 1)
            {
                MessageBox.Show("Please enter a number greater than 0");
                return;
            }
            BindingList<Appointment> appointments = getAppointmentsByCustomerId(customerId);
            if (appointments.Count == 0)
            {
                MessageBox.Show("No appointment found for this customer ID");
                return;
            }
            appointmentDataGridView.DataSource = appointments;
        }


        private void updateViewOnAppointmentType()
        {
            BindingList<Appointment> appointments = getAppointmentsByAppointmentType(comboBoxAppointmentType.Text);
            if (appointments.Count == 0)
            {
                MessageBox.Show("You have no appointments for selected type.");
                return;
            }
            appointmentDataGridView.DataSource = appointments;
        }

        private void updateViewOnDate()
        {
            var StartDate = dateTimePickerStartDate.Value;
            var EndDate = dateTimePickerEndDate.Value.AddMilliseconds(1);

            if (StartDate > EndDate)
            {
                MessageBox.Show($"The start date: {StartDate} is later than  \n the end date: {EndDate}");
                return;
            }

            BindingList<Appointment> appointments = getAppointmentsInTimePeriod(StartDate, EndDate);
            if (appointments.Count == 0)
            {
                MessageBox.Show("No appointment found for this date time period.");
                return;
            }
            appointmentDataGridView.DataSource = appointments;
        }

        private void CustomerIDRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            CustomerIDLabel.Visible = true;
            AppointmentTypeLabel.Visible = false;
            CustomerIDtextbox.Visible = true;
            comboBoxAppointmentType.Visible = false;
            StartDateLabel.Visible = false;
            EndDateLabel.Visible = false;
            dateTimePickerStartDate.Visible = false;
            dateTimePickerEndDate.Visible = false;
        }

        private void AppointmentTypeRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            CustomerIDLabel.Visible = false;
            AppointmentTypeLabel.Visible = true;
            CustomerIDtextbox.Visible = false;
            comboBoxAppointmentType.Visible = true;
            StartDateLabel.Visible = false;
            EndDateLabel.Visible = false;
            dateTimePickerStartDate.Visible = false;
            dateTimePickerEndDate.Visible = false;
        }

        private void CustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void AppointmentType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StartDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EndDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void appointmentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void radioButtonAllAppts_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAllAppts.Checked)
            {
                apptLabel.Text = "All Appointments";
                displayAllAppts();

            }
        }

        private void radioButtonMonthlyView_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMonthlyView.Checked)
            {
                apptLabel.Text = "Appointments This Month";
                displayThisMonth();

            }
        }
        private void radioButtonWeeklyView_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWeeklyView.Checked)
            {
                apptLabel.Text = "Appointments This Week";
                displayThisWeek();

            }
        }
    }
}
