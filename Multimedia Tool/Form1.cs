using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multimedia_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            panelArchiveSubMenu.Visible = false;
            panelSubAbout.Visible = false;
        }



        private void HideSubmenu()
        {
            if (panelArchiveSubMenu.Visible==true)
            {
                panelArchiveSubMenu.Visible = false;
            }
            if (panelSubAbout.Visible == true)
            {
                panelSubAbout.Visible = false;
            }
        }

        private void ShowSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelArchiveSubMenu);
        }
        #region Archive SubMenu buttons
        private void btCreate_Click(object sender, EventArgs e)
        {

            OpenChildForm(new AddArchive());

            HideSubmenu();
        }

        private void btExtract_Click(object sender, EventArgs e)
        {

            OpenChildForm(new ExtractArchive());

            HideSubmenu();
        }
#endregion
        private void btnAboutSubMenu_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelSubAbout);
        }
        #region About application Submenu
        private void btnAppInfo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AppInfo());
            HideSubmenu();
        }

        private void btnVersion_Click(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        #endregion

     


    }
}
