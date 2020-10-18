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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LoginBox.Text == "111008")
                {
                    frmMain f2 = new frmMain();
                    f2.Show();
                //Registry
                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("PaddleV");
                key.SetValue("LoginID", LoginBox.Text);
                key.SetValue("SetUserName", "byron");
                key.SetValue("UserToken", "rkvg6zmelx");
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("PaddleV");
                

            }

            if (LoginBox.Text == "001002")
            {
                frmMain f2 = new frmMain();
                f2.Show();
                //Registry
                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("PaddleV");
                key.SetValue("LoginID", LoginBox.Text);
                key.SetValue("SetUserName", "byron");
                key.SetValue("UserToken", "igw2u4zpdd");
            }


          
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
