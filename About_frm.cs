using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YGOPro_Launcher
{
    public partial class About_frm : Form
    {
        private Language lang = new Language(); 

        public About_frm()
        {
            InitializeComponent();
            TopLevel = false;
            Dock = DockStyle.Fill;
            Visible = true;

            lang.Load(Program.Config.language + ".conf");
            newText();
        }

        private void newText()
        {
            AboutText.Text = lang.aAboutText;
            label1.Text = lang.aboutLabel1;
            label5.Text = lang.aboutLabel5;
        }
    }
}
