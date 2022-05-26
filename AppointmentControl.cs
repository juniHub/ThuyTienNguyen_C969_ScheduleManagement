using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ThuyTienNguyen_C969_ScheduleManagement.DBModel;

namespace ThuyTienNguyen_C969_ScheduleManagement
{
    public partial class AppointmentControl : Form
    {
        private AppointmentList PreviousForm;
        private int SelectedAppointmentID = -1;
        public AppointmentControl (AppointmentList prevForm, int appointmentId)
        {
            InitializeComponent();
            PreviousForm = prevForm;
            SelectedAppointmentID = appointmentId;
        }

        public AppointmentControl(AppointmentList prevForm)
        {
            InitializeComponent();
            PreviousForm = prevForm;
        }

     
        private void saveButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                DateTime now = DateTime.Now;
                TimeSpan businessStart = new DateTime(now.Year, now.Month, now.Day, 8, 0, 0).TimeOfDay;
                TimeSpan businessEnd = new DateTime(now.Year, now.Month, now.Day, 17, 0, 0).TimeOfDay;
                int selectedCustomerId = Convert.ToInt32(customerComboBox.SelectedValue);

                string selectedType = "";

                if (typeComboBox.SelectedItem != null)
                {
                    selectedType = typeComboBox.SelectedValue.ToString();
                }


                DateTime selectedStart = startDateTimePicker.Value;
                DateTime selectedEnd = endDateTimePicker.Value;
                bool overlapping = false;

                foreach (var appt in MainScreen.ListOfAppointments)
                {
                    if (selectedStart >= appt.Start && selectedStart < appt.End)
                    {
                        overlapping = true;
                    }

                    if (selectedEnd > appt.Start && selectedEnd <= appt.End)
                    {
                        overlapping = true;
                    }

                }

                if (selectedCustomerId < 1)
                {
                    throw new ApplicationException("A customer must be selected.");
                }

                if (typeComboBox.SelectedItem == null)
                {
                    throw new ApplicationException("An appointment type must be selected");
                }

                if (selectedStart > selectedEnd)
                {
                    throw new ApplicationException("The end time cannot be before the start time.");
                }

                if ((selectedStart.TimeOfDay < businessStart) || (selectedStart.TimeOfDay > businessEnd) || (selectedEnd.TimeOfDay < businessStart) || (selectedEnd.TimeOfDay > businessEnd))
                {
                    throw new ApplicationException("You cannot schedule an appointment outside of business hours, 8 am - 5 pm");
                }

                if ((selectedStart.DayOfWeek == DayOfWeek.Saturday) || (selectedStart.DayOfWeek == DayOfWeek.Sunday) || (selectedEnd.DayOfWeek == DayOfWeek.Saturday) || (selectedEnd.DayOfWeek == DayOfWeek.Sunday))
                {
                    throw new ApplicationException("You cannot schedule an appointment outside of business hours, Saturday and Sunday");
                }

                if (overlapping)
                {
                    throw new ApplicationException("You cannnot overlap appointments");
                }

                if (SelectedAppointmentID >= 0 )
                {
                    Appointment appointment = MainScreen.ListOfAppointments.Where(appt => appt.AppointmentId == SelectedAppointmentID).Single();
                    Database.updateAppointment(appointment, selectedCustomerId, selectedType, selectedStart, selectedEnd);
                }
                else
                {
                    Database.addAppointment(selectedCustomerId, selectedType, selectedStart, selectedEnd);
                }
                Close();
            }

          
            catch (ApplicationException err)
            {
                MessageBox.Show(err.Message, "Instructions", MessageBoxButtons.OK);
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK);
            }
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AppointmentAddEditForm_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> customerDictionary = MainScreen.ListOfCustomers.ToDictionary(list => list.CustomerId, list => list.CustomerName);
            customerComboBox.DataSource = new BindingSource(customerDictionary, null);
            customerComboBox.DisplayMember = "Value";
            customerComboBox.ValueMember = "Key";
            customerComboBox.SelectedItem = null;

            typeComboBox.DataSource = new[] { "Scrum", "Presentation", "Lunch", "Interview", "Consultation", "In Office" };
            typeComboBox.SelectedItem = null;

            if (SelectedAppointmentID >= 0)
            {
                titleLabel.Text = "Edit Appointment";
                Appointment appointment = MainScreen.ListOfAppointments.Where(appt => appt.AppointmentId == SelectedAppointmentID).Single();
                idTextBox.Text = appointment.AppointmentId.ToString();
                customerComboBox.Text = customerDictionary[appointment.CustomerId];
                typeComboBox.Text = appointment.Type;
                startDateTimePicker.Value = appointment.Start;
                endDateTimePicker.Value = appointment.End;
            }
            else
            {
                DateTime now = DateTime.Now;
                startDateTimePicker.Value = new DateTime(now.Year, now.Month, now.Day, 8, 0, 0);
                endDateTimePicker.Value = new DateTime(now.Year, now.Month, now.Day, 17, 0, 0);
            }

        }

        private void AppointmentAddEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        
            PreviousForm.Show();
        }

        private void customerComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void typeComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void customerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void endDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
