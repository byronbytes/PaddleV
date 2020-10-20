using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaddleV
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

        }

        private void clearAllTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChatBox.Text = " ";

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Registry
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
