using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comprog2Project
{
    public partial class CreateClassroom : Form
    {
        public CreateClassroom()
        {
            InitializeComponent();
        }


        //---------------------------------------------------------------------------------------------------------------------------------------

        //change the font color in the closing form logo
        private void CloseLbl_MouseHover(object sender, EventArgs e) => ChangeColor.ForeColor((Label)sender, System.Drawing.Color.Orange);

        private void CloseLbl_MouseLeave(object sender, EventArgs e) => ChangeColor.ForeColor((Label)sender, System.Drawing.Color.Maroon);

        //---------------------------------------------------------------------------------------------------------------------------------------

        //change color backcolor in a control

        private void ChangeColorMouseOver(Object sender, EventArgs e) => ChangeColor.BackColor((Button)sender, System.Drawing.Color.CornflowerBlue);

        private void ChangeColorMouseLeave(Object sender, EventArgs e) => ChangeColor.BackColor((Button)sender, System.Drawing.Color.WhiteSmoke);

        private void CloseLbl_Click(object sender, EventArgs e) => Close();

        private void CancelBtn_Click(object sender, EventArgs e) => Close();

        //----------------------------------------------------------------------------------------------------------------------------------------


    }
}
