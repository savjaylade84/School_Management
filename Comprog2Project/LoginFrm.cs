using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Comprog2Project.Properties; 
namespace Comprog2Project
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
            StartSplashScreen();
        }

        //corousel hover collection of image path
        private readonly Bitmap[] bitmaps = {Resources.bg_2,Resources.bg_3,Resources.bg_4,Resources.bg_5 };
        private int length = 0;
        //---------------------------------------------------------------------------------------------------------------------------------------

        //change color backcolor in a control

        private void ChangeColorMouseOver(Object sender,EventArgs e) =>ChangeColor.BackColor((Button)sender,System.Drawing.Color.CornflowerBlue);

        private void ChangeColorMouseLeave(Object sender, EventArgs e) => ChangeColor.BackColor((Button)sender, System.Drawing.Color.WhiteSmoke);

        //----------------------------------------------------------------------------------------------------------------------------------------

        //close the form 
        private void CloseLbl_Click(object sender, EventArgs e) => Close();

        //---------------------------------------------------------------------------------------------------------------------------------------

        private void CloseLbl_MouseHover(object sender, EventArgs e) => ChangeColor.ForeColor((Label)sender,System.Drawing.Color.Orange);

        private void CloseLbl_MouseLeave(object sender, EventArgs e) => ChangeColor.ForeColor((Label)sender,System.Drawing.Color.Maroon);

        //---------------------------------------------------------------------------------------------------------------------------------------

        private void CouroselSlides(object sender, EventArgs e) {

           

            if(length > bitmaps.Length)
                length = 0;
            else
                ImageCorousel.BackgroundImage = (length <= bitmaps.Length - 1) ? bitmaps[length] : bitmaps[0];

            length++;

        }

        //----------------------------------------------------------------------------------------------------------------------------------------
         //run the splash screen and abort in about 8sec
        private void StartSplashScreen() {

            Thread thread = new Thread(ThreaStart => Application.Run(new StartForm()));
            thread.Start();
            Thread.Sleep(5000);
            thread.Abort();

        }
        //------------------------------------------------------------------------------------------------------------------------------------------

        public void RunDashboard() {

            var thread = new Thread(ThreadStart => Application.Run(new Dashboard()));
            thread.Start();
            this.Close();

        }

        //validate the login credential 
        private void LoginBtn_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(UsernameValue.Text) && string.IsNullOrEmpty(PasswordValue.Text))
                MessageBox.Show("Empty value");
            else
            {

                try
                {
                    if (accType.SelectedItem.ToString() == "Teacher")
                    {

                        bool isCorrectEnterTeacher = (ConnectionDb.getCompareValue("username", "pword", "_TEACHER", UsernameValue.Text, PasswordValue.Text));
                        if (isCorrectEnterTeacher)
                        {

                            ChangePropertyValue.VisibleControl = false;
                            ChangePropertyValue.accountType = "_TEACHER";
                            RunDashboard();
                        }
                        else
                        {


                            MessageBox.Show("Wrong username or password");

                        }
                    }

                    if (accType.SelectedItem.ToString() == "Admin")
                    {
                        bool isCorrectEnterAdmin = (ConnectionDb.getCompareValue("username", "pword", "ADMIN", UsernameValue.Text, PasswordValue.Text));
                        if (isCorrectEnterAdmin)
                        {

                            ChangePropertyValue.VisibleControl = true;
                            ChangePropertyValue.accountType = "ADMIN";
                            RunDashboard();

                        }
                        else
                        {


                            MessageBox.Show("Wrong username or password");

                        }
                    }


                }
                catch {

                    MessageBox.Show("Not A Account Type");
                
                }

            }
        }
      //-----------------------------------------------------------------------------------------------------------------------------------------
      //close the this form
        private void CancelBtn_Click(object sender, EventArgs e) => Close();
      //-----------------------------------------------------------------------------------------------------------------------------------------
        //hide and show text form of the password
        private void ShowHideChkbx_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckState.Checked == ShowHideChkbx.CheckState)
            {
                PasswordValue.UseSystemPasswordChar = true;
                ShowHideChkbx.Text = "Show";
            }
            else
            {
                PasswordValue.UseSystemPasswordChar = false;
                ShowHideChkbx.Text = "Hide";
            }
        }
     //----------------------------------------------------------------------------------------------------------------------------------------
        private void PasswordChoose(object sender, EventArgs e)
        {
            var temp = (TextBox)sender;
            temp.UseSystemPasswordChar = true;
            temp.Clear();
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------

    }
}
