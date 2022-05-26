
namespace ThuyTienNguyen_C969_ScheduleManagement
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.customersButton = new System.Windows.Forms.Button();
            this.appointmentButton = new System.Windows.Forms.Button();
            this.reportsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.mainscreenLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customersButton
            // 
            this.customersButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.customersButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("customersButton.BackgroundImage")));
            this.customersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.customersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersButton.Location = new System.Drawing.Point(12, 108);
            this.customersButton.Name = "customersButton";
            this.customersButton.Size = new System.Drawing.Size(169, 139);
            this.customersButton.TabIndex = 0;
            this.customersButton.UseVisualStyleBackColor = false;
            this.customersButton.Click += new System.EventHandler(this.customersButton_Click);
            // 
            // appointmentButton
            // 
            this.appointmentButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.appointmentButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("appointmentButton.BackgroundImage")));
            this.appointmentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.appointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentButton.Location = new System.Drawing.Point(198, 108);
            this.appointmentButton.Name = "appointmentButton";
            this.appointmentButton.Size = new System.Drawing.Size(170, 139);
            this.appointmentButton.TabIndex = 1;
            this.appointmentButton.UseVisualStyleBackColor = false;
            this.appointmentButton.Click += new System.EventHandler(this.appointmentsButton_Click);
            // 
            // reportsButton
            // 
            this.reportsButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.reportsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reportsButton.BackgroundImage")));
            this.reportsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reportsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsButton.Location = new System.Drawing.Point(385, 108);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(176, 139);
            this.reportsButton.TabIndex = 2;
            this.reportsButton.UseVisualStyleBackColor = false;
            this.reportsButton.Click += new System.EventHandler(this.reportsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(385, 354);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(176, 55);
            this.exitButton.TabIndex = 3;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mainscreenLabel
            // 
            this.mainscreenLabel.AutoSize = true;
            this.mainscreenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainscreenLabel.Location = new System.Drawing.Point(7, 12);
            this.mainscreenLabel.Name = "mainscreenLabel";
            this.mainscreenLabel.Size = new System.Drawing.Size(332, 29);
            this.mainscreenLabel.TabIndex = 4;
            this.mainscreenLabel.Text = "Smart Scheduler\'s Dashboard";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(627, 481);
            this.Controls.Add(this.mainscreenLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.reportsButton);
            this.Controls.Add(this.appointmentButton);
            this.Controls.Add(this.customersButton);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainScreen_FormClosed);
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.Shown += new System.EventHandler(this.MainScreen_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button customersButton;
        private System.Windows.Forms.Button appointmentButton;
        private System.Windows.Forms.Button reportsButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label mainscreenLabel;
    }
}

