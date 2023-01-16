using Bunifu.UI.WinForms;
using PasswordGenerator.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIssues_Click(object sender, EventArgs e)
        {
            bool oneChecked = false;
            foreach (Control control in this.Controls)
            {
                BunifuCheckBox checkbox = control as BunifuCheckBox;
                if (checkbox != null && checkbox.Checked)
                {
                    oneChecked = true;
                    break;
                }
            }
            if (oneChecked)
            {
                // at least one checkbox is checked
                var pwd = new Password(includeLowercase: bunifuCheckBox1.Checked, includeUppercase: bunifuCheckBox2.Checked, includeNumeric: bunifuCheckBox3.Checked, includeSpecial: bunifuCheckBox4.Checked, passwordLength: bunifuHSlider1.Value);
                var password = pwd.Next();
                bunifuSnackbar1.Show(this, "Password copied to clipboard", BunifuSnackbar.MessageTypes.Success);
                Clipboard.SetText(password);
            }
            else
            {
                // no checkboxes are checked
                bunifuSnackbar1.Show(this, "Select atleast 1 option", BunifuSnackbar.MessageTypes.Error);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            //Close the  Application
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            //Makes the application in Minimized State
            this.WindowState = FormWindowState.Minimized;
        }

        #region Drag
        //Variables for form dragging
        private int mouseStartX, mouseStartY;
        private int formStartX, formStartY;
        private bool isDragging = false;

        private void PanelNavbar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseStartX = MousePosition.X;
            mouseStartY = MousePosition.Y;
            formStartX = this.Location.X;
            formStartY = this.Location.Y;
            isDragging = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = bunifuHSlider1.Value.ToString();
        }

        private void PanelNavbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                //Move Form
                this.Location = new Point(formStartX + MousePosition.X - mouseStartX, formStartY + MousePosition.Y - mouseStartY);
            }
        }

        private void PanelNavbar_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
        #endregion

    }
}
