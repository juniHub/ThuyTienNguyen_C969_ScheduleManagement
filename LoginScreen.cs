using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using ThuyTienNguyen_C969_ScheduleManagement.DBModel;

namespace ThuyTienNguyen_C969_ScheduleManagement
{
    public partial class LoginScreen : Form
    {
        private List<User> users;

        private string lang;
     
        public LoginScreen()
        {
            InitializeComponent();
        }


        private void changeLoginToVietnamese()
        {
            LoginScreenLabel.Text = "Chào mừng bạn đến với lịch hẹn thông minh";
            UnameLabel.Text = "Tên người dùng";
            PwdLabel.Text = "Mật khẩu";
            LoginBtn.Text = "Đăng nhập";
            ExitBtn.Text = "Đăng xuất";
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string userName = UnameTextBox.Text;
            string password = PwdTextBox.Text;

            try
            {
                if (userName == "" || password == "")
                {
                    if (lang == "vi")
                    {
                        throw new LoginValidator("Bạn phải nhập cả tên người dùng và mật khẩu để đăng nhập.");
                    }

                    throw new LoginValidator("You must enter both username and password to log in.");
                }


                //Below Lambda expession used to determine if user name entered match one of the user names returned from the database.
              
                List<User> signedInUser = users.Where(user => user.UserName == userName).ToList();

                if (signedInUser.Count < 1)
                {
                    if (lang == "vi")
                    {
                        throw new LoginValidator("Tên người dùng bạn đã nhập không tồn tại.");
                    }
                    throw new LoginValidator("The username you entered does not exist.");
                }

                if (signedInUser[0].Password != password)
                {
                    if (lang == "vi")
                    {
                        throw new LoginValidator("Mật khẩu không đúng");
                    }
                    throw new LoginValidator("The password is incorrect");
                }

               UserActivityLog.logActivity(signedInUser[0]);

                var mainScreen = new MainScreen(signedInUser[0]);
                mainScreen.Show();
                Hide();
            }
            catch (LoginValidator error)
            {
                ErrorLabel.Text = error.Message;
            }

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PwdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            lang = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            users = Database.getAllUsers();
            ErrorLabel.Text = "";
            if (lang == "vi")
            {
                changeLoginToVietnamese();
            }
        }
     


    }
}
