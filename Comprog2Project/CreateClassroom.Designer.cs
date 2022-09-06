namespace Comprog2Project
{
    partial class CreateClassroom
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseLbl = new System.Windows.Forms.Label();
            this.SumOfAtndLBL = new System.Windows.Forms.Label();
            this.sectionNameTItle = new System.Windows.Forms.TextBox();
            this.sectionCodeTitle = new System.Windows.Forms.TextBox();
            this.sectionCodeValue = new System.Windows.Forms.TextBox();
            this.sectionNameValue = new System.Windows.Forms.TextBox();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.PInfoTitleLbl = new System.Windows.Forms.Label();
            this.studentTitle = new System.Windows.Forms.TextBox();
            this.teacherTitle = new System.Windows.Forms.TextBox();
            this.studentValue = new System.Windows.Forms.ComboBox();
            this.teacherValue = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CloseLbl);
            this.panel1.Controls.Add(this.SumOfAtndLBL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 49);
            this.panel1.TabIndex = 48;
            // 
            // CloseLbl
            // 
            this.CloseLbl.AutoSize = true;
            this.CloseLbl.BackColor = System.Drawing.Color.Transparent;
            this.CloseLbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseLbl.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.CloseLbl.Location = new System.Drawing.Point(368, 0);
            this.CloseLbl.Name = "CloseLbl";
            this.CloseLbl.Size = new System.Drawing.Size(34, 40);
            this.CloseLbl.TabIndex = 1;
            this.CloseLbl.Text = "x";
            this.CloseLbl.Click += new System.EventHandler(this.CloseLbl_Click);
            this.CloseLbl.MouseLeave += new System.EventHandler(this.CloseLbl_MouseLeave);
            this.CloseLbl.MouseHover += new System.EventHandler(this.CloseLbl_MouseHover);
            // 
            // SumOfAtndLBL
            // 
            this.SumOfAtndLBL.AutoSize = true;
            this.SumOfAtndLBL.Dock = System.Windows.Forms.DockStyle.Left;
            this.SumOfAtndLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumOfAtndLBL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SumOfAtndLBL.Location = new System.Drawing.Point(0, 0);
            this.SumOfAtndLBL.Name = "SumOfAtndLBL";
            this.SumOfAtndLBL.Padding = new System.Windows.Forms.Padding(3);
            this.SumOfAtndLBL.Size = new System.Drawing.Size(149, 35);
            this.SumOfAtndLBL.TabIndex = 34;
            this.SumOfAtndLBL.Text = "Add Section";
            // 
            // sectionNameTItle
            // 
            this.sectionNameTItle.BackColor = System.Drawing.Color.LightGray;
            this.sectionNameTItle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sectionNameTItle.Enabled = false;
            this.sectionNameTItle.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.sectionNameTItle.ForeColor = System.Drawing.Color.Black;
            this.sectionNameTItle.Location = new System.Drawing.Point(14, 192);
            this.sectionNameTItle.Margin = new System.Windows.Forms.Padding(8);
            this.sectionNameTItle.Name = "sectionNameTItle";
            this.sectionNameTItle.Size = new System.Drawing.Size(142, 31);
            this.sectionNameTItle.TabIndex = 87;
            this.sectionNameTItle.Text = "(Section Name)";
            this.sectionNameTItle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sectionCodeTitle
            // 
            this.sectionCodeTitle.BackColor = System.Drawing.Color.LightGray;
            this.sectionCodeTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sectionCodeTitle.Enabled = false;
            this.sectionCodeTitle.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.sectionCodeTitle.ForeColor = System.Drawing.Color.Black;
            this.sectionCodeTitle.Location = new System.Drawing.Point(14, 145);
            this.sectionCodeTitle.Margin = new System.Windows.Forms.Padding(8);
            this.sectionCodeTitle.Name = "sectionCodeTitle";
            this.sectionCodeTitle.Size = new System.Drawing.Size(142, 31);
            this.sectionCodeTitle.TabIndex = 86;
            this.sectionCodeTitle.Text = "(Section Code)";
            this.sectionCodeTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sectionCodeValue
            // 
            this.sectionCodeValue.BackColor = System.Drawing.Color.Gainsboro;
            this.sectionCodeValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sectionCodeValue.Enabled = false;
            this.sectionCodeValue.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.sectionCodeValue.ForeColor = System.Drawing.Color.Black;
            this.sectionCodeValue.Location = new System.Drawing.Point(159, 145);
            this.sectionCodeValue.Margin = new System.Windows.Forms.Padding(8);
            this.sectionCodeValue.Name = "sectionCodeValue";
            this.sectionCodeValue.Size = new System.Drawing.Size(213, 31);
            this.sectionCodeValue.TabIndex = 88;
            this.sectionCodeValue.Text = "(Section Code)";
            this.sectionCodeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sectionNameValue
            // 
            this.sectionNameValue.BackColor = System.Drawing.Color.Gainsboro;
            this.sectionNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sectionNameValue.Enabled = false;
            this.sectionNameValue.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.sectionNameValue.ForeColor = System.Drawing.Color.Black;
            this.sectionNameValue.Location = new System.Drawing.Point(159, 192);
            this.sectionNameValue.Margin = new System.Windows.Forms.Padding(8);
            this.sectionNameValue.Name = "sectionNameValue";
            this.sectionNameValue.Size = new System.Drawing.Size(213, 31);
            this.sectionNameValue.TabIndex = 89;
            this.sectionNameValue.Text = "(Section Code)";
            this.sectionNameValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CreateBtn
            // 
            this.CreateBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CreateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateBtn.Location = new System.Drawing.Point(0, 399);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(404, 43);
            this.CreateBtn.TabIndex = 90;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = false;
            this.CreateBtn.MouseLeave += new System.EventHandler(this.ChangeColorMouseLeave);
            this.CreateBtn.MouseHover += new System.EventHandler(this.ChangeColorMouseOver);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Location = new System.Drawing.Point(0, 442);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(404, 43);
            this.CancelBtn.TabIndex = 91;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            this.CancelBtn.MouseLeave += new System.EventHandler(this.ChangeColorMouseLeave);
            this.CancelBtn.MouseHover += new System.EventHandler(this.ChangeColorMouseOver);
            // 
            // PInfoTitleLbl
            // 
            this.PInfoTitleLbl.AutoSize = true;
            this.PInfoTitleLbl.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PInfoTitleLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PInfoTitleLbl.Location = new System.Drawing.Point(9, 100);
            this.PInfoTitleLbl.Name = "PInfoTitleLbl";
            this.PInfoTitleLbl.Size = new System.Drawing.Size(232, 28);
            this.PInfoTitleLbl.TabIndex = 92;
            this.PInfoTitleLbl.Text = "Section Information";
            // 
            // studentTitle
            // 
            this.studentTitle.BackColor = System.Drawing.Color.LightGray;
            this.studentTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentTitle.Enabled = false;
            this.studentTitle.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.studentTitle.ForeColor = System.Drawing.Color.Black;
            this.studentTitle.Location = new System.Drawing.Point(14, 292);
            this.studentTitle.Margin = new System.Windows.Forms.Padding(8);
            this.studentTitle.Name = "studentTitle";
            this.studentTitle.Size = new System.Drawing.Size(142, 31);
            this.studentTitle.TabIndex = 94;
            this.studentTitle.Text = "(Student ID)";
            this.studentTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // teacherTitle
            // 
            this.teacherTitle.BackColor = System.Drawing.Color.LightGray;
            this.teacherTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teacherTitle.Enabled = false;
            this.teacherTitle.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.teacherTitle.ForeColor = System.Drawing.Color.Black;
            this.teacherTitle.Location = new System.Drawing.Point(14, 245);
            this.teacherTitle.Margin = new System.Windows.Forms.Padding(8);
            this.teacherTitle.Name = "teacherTitle";
            this.teacherTitle.Size = new System.Drawing.Size(142, 31);
            this.teacherTitle.TabIndex = 93;
            this.teacherTitle.Text = "(Teacher ID)";
            this.teacherTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // studentValue
            // 
            this.studentValue.BackColor = System.Drawing.Color.LightGray;
            this.studentValue.DropDownWidth = 100;
            this.studentValue.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.studentValue.FormattingEnabled = true;
            this.studentValue.Items.AddRange(new object[] {
            "Student",
            "Teacher"});
            this.studentValue.Location = new System.Drawing.Point(159, 292);
            this.studentValue.Name = "studentValue";
            this.studentValue.Size = new System.Drawing.Size(213, 31);
            this.studentValue.Sorted = true;
            this.studentValue.TabIndex = 97;
            this.studentValue.Text = "(Student ID)";
            // 
            // teacherValue
            // 
            this.teacherValue.BackColor = System.Drawing.Color.LightGray;
            this.teacherValue.DropDownWidth = 100;
            this.teacherValue.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.teacherValue.FormattingEnabled = true;
            this.teacherValue.Items.AddRange(new object[] {
            "Student",
            "Teacher"});
            this.teacherValue.Location = new System.Drawing.Point(159, 245);
            this.teacherValue.Name = "teacherValue";
            this.teacherValue.Size = new System.Drawing.Size(213, 31);
            this.teacherValue.Sorted = true;
            this.teacherValue.TabIndex = 98;
            this.teacherValue.Text = "(Teacher ID)";
            // 
            // CreateClassroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(404, 485);
            this.Controls.Add(this.teacherValue);
            this.Controls.Add(this.studentValue);
            this.Controls.Add(this.studentTitle);
            this.Controls.Add(this.teacherTitle);
            this.Controls.Add(this.PInfoTitleLbl);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.sectionNameTItle);
            this.Controls.Add(this.sectionCodeTitle);
            this.Controls.Add(this.sectionCodeValue);
            this.Controls.Add(this.sectionNameValue);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateClassroom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateClassroom";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CloseLbl;
        private System.Windows.Forms.Label SumOfAtndLBL;
        private System.Windows.Forms.TextBox sectionNameTItle;
        private System.Windows.Forms.TextBox sectionCodeTitle;
        private System.Windows.Forms.TextBox sectionCodeValue;
        private System.Windows.Forms.TextBox sectionNameValue;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label PInfoTitleLbl;
        private System.Windows.Forms.TextBox studentTitle;
        private System.Windows.Forms.TextBox teacherTitle;
        private System.Windows.Forms.ComboBox studentValue;
        private System.Windows.Forms.ComboBox teacherValue;
    }
}