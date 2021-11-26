using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trpoproject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ButtonStart_click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void buttonExit_close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBackToMenu_click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
