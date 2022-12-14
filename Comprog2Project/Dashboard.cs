using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comprog2Project
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

        }

        public SearchAndFindFrm Search { get; set; } = new SearchAndFindFrm();

        //--------------------------------------------------------------------------------------------------------------------

        private void LeaveForm(object sender, EventArgs e) => Close();      //close the form

        //-------------------------------------------------------------------------------------------------------------------
        private void HoverLeaveForm(object sender, EventArgs e) => ChangeColor.ForeColor((Control)sender,System.Drawing.Color.Orange);
        private void NotHoverLeaveForm(object sender, EventArgs e) => ChangeColor.ForeColor((Control)sender,System.Drawing.Color.Red);
        //------------------------------------------------------------------------------------------------------------------
        private void ShowTotal(object sender, EventArgs e) {

            var temp = (Control)sender;           //capture the control being triggered by this event 


            HoverForm hoverForm = new HoverForm();   //form that show the name of the student in the hoverform

            //check if one of these controls are being hover by the mouse
            if (temp == AbsentPanel || temp == AbsentLabel || temp == AbsentNumLabel)
                hoverForm.BackColor = System.Drawing.Color.Red;
            if (temp == LateComerPanel || temp == LateLabel || temp == LateNumLabel)
                hoverForm.BackColor = System.Drawing.Color.Orange;
            if (temp == ExcusePanel || temp == ExcuseLabel || temp == ExcuseNumLabel)
                hoverForm.BackColor = System.Drawing.Color.MediumSpringGreen;

            //automacally close that form when the mouse leave from 
            //those panel in this form and determine the backcolor
            //of the hoverform
            temp.MouseLeave += (x, y) => hoverForm.Close();

            hoverForm.Visible = true;
            hoverForm.Show();

        }

        //---------------------------------------------------------------------------------------------------------
        private void HoverNavBar(object sender, EventArgs e) {

             
            var pic = (Control)sender;                  // capture the control that trigger this event
            ChangeColor.BackColor((Control)pic.Parent, System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(155)))), ((int)(((byte)(110)))))); //capture the parent control and change the backcolor
            // 190, 144, 110

        }
        //---------------------------------------------------------------------------------------------------------
        private void NotHoverNavBar(object sender, EventArgs e) {

            var pic = (Control)sender;                 //capture the control that trigger this event
            ChangeColor.BackColor((Control)pic.Parent, System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(144)))), ((int)(((byte)(99))))));   //capture the parent control and change the backcolor
            //190, 144, 99

        }
        //-------------------------------------------------------------------------------------------------------

        //open the searching form
        private void SearchAndFind(object sender, EventArgs e)
        {
            ChangeColor.BackColor(SearchPeoplePanel, System.Drawing.Color.WhiteSmoke);
            Search.FormClosed += (x, y) => EnableControl.ControlEnable(this,true);   //enabled the dashboard form when this form closed
            EnableControl.ControlEnable(this,false);   //unable the dashboard when using this form
            Search.Show();

        }
        //------------------------------------------------------------------------------------------------------
        //this event trigger when the user logout and jump to login form
        private void ExitClick(object sender, EventArgs e)
        {
            ChangeColor.BackColor(ExitPeoplePanel, System.Drawing.Color.WhiteSmoke);
            var thread = new Thread(ThreadStart =>  Application.Run(new LoginFrm()) );
            thread.Start();
            this.Close();

        }
        //------------------------------------------------------------------------------------------------------
        //open create account form
        private void CreateAccountCLick(object sender, EventArgs e)
        {
            ChangeColor.BackColor(AddPeoplePanel, System.Drawing.Color.WhiteSmoke);
            var createAccount = new CreateAccount();
            createAccount.FormClosed += (x, y) => this.Enabled = true;    //enabled the dashboard form when this form closed
            this.Enabled = false;        //unable the dashboard when using this form
            createAccount.Show();         //show the form
        }
        //----------------------------------------------------------------------------------------------------

        private void CreateSectionClick(object sender, EventArgs e) {

            ChangeColor.BackColor(AddCRoomPanel, System.Drawing.Color.WhiteSmoke);
            var createSection = new CreateClassroom();
            createSection.FormClosed += (x, y) => this.Enabled = true;    //enabled the dashboard form when this form closed
            this.Enabled = false;        //unable the dashboard when using this form
            createSection.Show();         //show the form

        }
         //------------------------------------------------------------------------------------------------------------------
        private void LoadInfo(object sender, EventArgs e)
        {

            //pre load some data in the database in the summary
            ConnectionDb.ViewRecord((ChangePropertyValue.VisibleControl) ? "Report" : "ReportTeacher", SectionSummaryPanel);
            AbsentNumLabel.Text = ConnectionDb.getCount("absent", "SECTION");
            LateNumLabel.Text = ConnectionDb.getCount("late", "SECTION");
            ExcuseNumLabel.Text = ConnectionDb.getCount("excuse", "SECTION");

            //change the visible if the it is a admin
            AddCRoomPanel.Visible = ChangePropertyValue.VisibleControl;
            accountType.Text += ChangePropertyValue.accountType;

            if (ChangePropertyValue.accountType == "ADMIN")
            {
                ConnectionDb.getValueInAdmin(new TextBox[] {

                profNameValue,ProfContactValue,ProfEmailValue,PathHolder

            }, (ChangePropertyValue.VisibleControl) ? "adminInfo" : "teacherInfo");

                ProfilePic.Image = Image.FromFile(PathHolder.Text);
            }


        }
    }
}
