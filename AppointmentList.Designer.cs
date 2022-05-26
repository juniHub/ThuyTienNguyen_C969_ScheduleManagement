
namespace ThuyTienNguyen_C969_ScheduleManagement
{
    partial class AppointmentList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentList));
            this.comboBoxAppointmentType = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.CustomerIDtextbox = new System.Windows.Forms.TextBox();
            this.MainLabel = new System.Windows.Forms.Label();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.AppointmentTypeLabel = new System.Windows.Forms.Label();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.appointmentDataGridView = new System.Windows.Forms.DataGridView();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.CustomerIDRadioButton = new System.Windows.Forms.RadioButton();
            this.AppointmentTypeRadioButton = new System.Windows.Forms.RadioButton();
            this.DatesRadioButton = new System.Windows.Forms.RadioButton();
            this.apptLabel = new System.Windows.Forms.Label();
            this.radioButtonMonthlyView = new System.Windows.Forms.RadioButton();
            this.radioButtonWeeklyView = new System.Windows.Forms.RadioButton();
            this.radioButtonAllAppts = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxAppointmentType
            // 
            this.comboBoxAppointmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAppointmentType.FormattingEnabled = true;
            this.comboBoxAppointmentType.Location = new System.Drawing.Point(492, 697);
            this.comboBoxAppointmentType.Name = "comboBoxAppointmentType";
            this.comboBoxAppointmentType.Size = new System.Drawing.Size(319, 28);
            this.comboBoxAppointmentType.TabIndex = 49;
            this.comboBoxAppointmentType.SelectedIndexChanged += new System.EventHandler(this.AppointmentType_SelectedIndexChanged);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(849, 175);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(214, 62);
            this.backButton.TabIndex = 48;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // CustomerIDtextbox
            // 
            this.CustomerIDtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIDtextbox.Location = new System.Drawing.Point(492, 656);
            this.CustomerIDtextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CustomerIDtextbox.Name = "CustomerIDtextbox";
            this.CustomerIDtextbox.Size = new System.Drawing.Size(319, 26);
            this.CustomerIDtextbox.TabIndex = 45;
            this.CustomerIDtextbox.TextChanged += new System.EventHandler(this.CustomerID_TextChanged);
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.Location = new System.Drawing.Point(13, 9);
            this.MainLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(191, 29);
            this.MainLabel.TabIndex = 44;
            this.MainLabel.Text = "Appointment List";
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateLabel.Location = new System.Drawing.Point(328, 574);
            this.StartDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(83, 20);
            this.StartDateLabel.TabIndex = 43;
            this.StartDateLabel.Text = "Start Date";
            // 
            // AppointmentTypeLabel
            // 
            this.AppointmentTypeLabel.AutoSize = true;
            this.AppointmentTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentTypeLabel.Location = new System.Drawing.Point(328, 697);
            this.AppointmentTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AppointmentTypeLabel.Name = "AppointmentTypeLabel";
            this.AppointmentTypeLabel.Size = new System.Drawing.Size(138, 20);
            this.AppointmentTypeLabel.TabIndex = 42;
            this.AppointmentTypeLabel.Text = "Appointment Type";
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIDLabel.Location = new System.Drawing.Point(328, 656);
            this.CustomerIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(99, 20);
            this.CustomerIDLabel.TabIndex = 41;
            this.CustomerIDLabel.Text = "Customer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 574);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Select Search Type Here:";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.searchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchButton.BackgroundImage")));
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.searchButton.Location = new System.Drawing.Point(849, 664);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(214, 61);
            this.searchButton.TabIndex = 35;
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(849, 294);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(214, 62);
            this.addButton.TabIndex = 34;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(849, 488);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(214, 62);
            this.deleteButton.TabIndex = 33;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(849, 391);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(214, 62);
            this.editButton.TabIndex = 32;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // appointmentDataGridView
            // 
            this.appointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentDataGridView.Location = new System.Drawing.Point(18, 175);
            this.appointmentDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.appointmentDataGridView.MultiSelect = false;
            this.appointmentDataGridView.Name = "appointmentDataGridView";
            this.appointmentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointmentDataGridView.Size = new System.Drawing.Size(792, 375);
            this.appointmentDataGridView.TabIndex = 27;
            this.appointmentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appointmentDataGridView_CellContentClick);
            this.appointmentDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.appointmentDataGridView_DataBindingComplete);
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDateLabel.Location = new System.Drawing.Point(328, 615);
            this.EndDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(77, 20);
            this.EndDateLabel.TabIndex = 53;
            this.EndDateLabel.Text = "End Date";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(492, 574);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(319, 26);
            this.dateTimePickerStartDate.TabIndex = 54;
            this.dateTimePickerStartDate.ValueChanged += new System.EventHandler(this.StartDateTimePicker_ValueChanged);
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(492, 615);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(319, 26);
            this.dateTimePickerEndDate.TabIndex = 55;
            this.dateTimePickerEndDate.ValueChanged += new System.EventHandler(this.EndDateTimePicker_ValueChanged);
            // 
            // CustomerIDRadioButton
            // 
            this.CustomerIDRadioButton.AutoSize = true;
            this.CustomerIDRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIDRadioButton.Location = new System.Drawing.Point(18, 657);
            this.CustomerIDRadioButton.Name = "CustomerIDRadioButton";
            this.CustomerIDRadioButton.Size = new System.Drawing.Size(117, 24);
            this.CustomerIDRadioButton.TabIndex = 56;
            this.CustomerIDRadioButton.Text = "Customer ID";
            this.CustomerIDRadioButton.UseVisualStyleBackColor = true;
            this.CustomerIDRadioButton.CheckedChanged += new System.EventHandler(this.CustomerIDRadioButton_CheckedChanged);
            // 
            // AppointmentTypeRadioButton
            // 
            this.AppointmentTypeRadioButton.AutoSize = true;
            this.AppointmentTypeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentTypeRadioButton.Location = new System.Drawing.Point(18, 699);
            this.AppointmentTypeRadioButton.Name = "AppointmentTypeRadioButton";
            this.AppointmentTypeRadioButton.Size = new System.Drawing.Size(156, 24);
            this.AppointmentTypeRadioButton.TabIndex = 57;
            this.AppointmentTypeRadioButton.Text = "Appointment Type";
            this.AppointmentTypeRadioButton.UseVisualStyleBackColor = true;
            this.AppointmentTypeRadioButton.CheckedChanged += new System.EventHandler(this.AppointmentTypeRadioButton_CheckedChanged);
            // 
            // DatesRadioButton
            // 
            this.DatesRadioButton.AutoSize = true;
            this.DatesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatesRadioButton.Location = new System.Drawing.Point(18, 615);
            this.DatesRadioButton.Name = "DatesRadioButton";
            this.DatesRadioButton.Size = new System.Drawing.Size(70, 24);
            this.DatesRadioButton.TabIndex = 58;
            this.DatesRadioButton.Text = "Dates";
            this.DatesRadioButton.UseVisualStyleBackColor = true;
            this.DatesRadioButton.CheckedChanged += new System.EventHandler(this.DateRadioButton_CheckedChanged);
            // 
            // apptLabel
            // 
            this.apptLabel.AutoSize = true;
            this.apptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptLabel.Location = new System.Drawing.Point(13, 127);
            this.apptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.apptLabel.Name = "apptLabel";
            this.apptLabel.Size = new System.Drawing.Size(152, 24);
            this.apptLabel.TabIndex = 59;
            this.apptLabel.Text = "All Appointments";
            // 
            // radioButtonMonthlyView
            // 
            this.radioButtonMonthlyView.AutoSize = true;
            this.radioButtonMonthlyView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMonthlyView.Location = new System.Drawing.Point(270, 74);
            this.radioButtonMonthlyView.Name = "radioButtonMonthlyView";
            this.radioButtonMonthlyView.Size = new System.Drawing.Size(208, 24);
            this.radioButtonMonthlyView.TabIndex = 60;
            this.radioButtonMonthlyView.Text = "Appointments This Month";
            this.radioButtonMonthlyView.UseVisualStyleBackColor = true;
            this.radioButtonMonthlyView.CheckedChanged += new System.EventHandler(this.radioButtonMonthlyView_CheckedChanged);
            // 
            // radioButtonWeeklyView
            // 
            this.radioButtonWeeklyView.AutoSize = true;
            this.radioButtonWeeklyView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonWeeklyView.Location = new System.Drawing.Point(583, 74);
            this.radioButtonWeeklyView.Name = "radioButtonWeeklyView";
            this.radioButtonWeeklyView.Size = new System.Drawing.Size(204, 24);
            this.radioButtonWeeklyView.TabIndex = 61;
            this.radioButtonWeeklyView.Text = "Appointments This Week";
            this.radioButtonWeeklyView.UseVisualStyleBackColor = true;
            this.radioButtonWeeklyView.CheckedChanged += new System.EventHandler(this.radioButtonWeeklyView_CheckedChanged);
            // 
            // radioButtonAllAppts
            // 
            this.radioButtonAllAppts.AutoSize = true;
            this.radioButtonAllAppts.Checked = true;
            this.radioButtonAllAppts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAllAppts.Location = new System.Drawing.Point(18, 74);
            this.radioButtonAllAppts.Name = "radioButtonAllAppts";
            this.radioButtonAllAppts.Size = new System.Drawing.Size(147, 24);
            this.radioButtonAllAppts.TabIndex = 62;
            this.radioButtonAllAppts.TabStop = true;
            this.radioButtonAllAppts.Text = "All Appointments";
            this.radioButtonAllAppts.UseVisualStyleBackColor = true;
            this.radioButtonAllAppts.CheckedChanged += new System.EventHandler(this.radioButtonAllAppts_CheckedChanged);
            // 
            // AppointmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1244, 813);
            this.Controls.Add(this.radioButtonAllAppts);
            this.Controls.Add(this.radioButtonWeeklyView);
            this.Controls.Add(this.radioButtonMonthlyView);
            this.Controls.Add(this.apptLabel);
            this.Controls.Add(this.DatesRadioButton);
            this.Controls.Add(this.AppointmentTypeRadioButton);
            this.Controls.Add(this.CustomerIDRadioButton);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.EndDateLabel);
            this.Controls.Add(this.comboBoxAppointmentType);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.CustomerIDtextbox);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.AppointmentTypeLabel);
            this.Controls.Add(this.CustomerIDLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.appointmentDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppointmentList";
            this.Text = "AppointmentList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AppointmentsForm_FormClosed);
            this.Load += new System.EventHandler(this.AppointmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxAppointmentType;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox CustomerIDtextbox;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.Label AppointmentTypeLabel;
        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.DataGridView appointmentDataGridView;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.RadioButton CustomerIDRadioButton;
        private System.Windows.Forms.RadioButton AppointmentTypeRadioButton;
        private System.Windows.Forms.RadioButton DatesRadioButton;
        private System.Windows.Forms.Label apptLabel;
        private System.Windows.Forms.RadioButton radioButtonMonthlyView;
        private System.Windows.Forms.RadioButton radioButtonWeeklyView;
        private System.Windows.Forms.RadioButton radioButtonAllAppts;
    }
}