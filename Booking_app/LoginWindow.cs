using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking_app
{
    public partial class LoginWindow : Form
    {
        private string user = "Ola";
        private string password = "haslo";
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (user == InpUser.Text && password == InpPassword.Text) 
            {
                this.DialogResult=DialogResult.OK;

            }
            else
            {
                if(MessageBox.Show("Invalid login or password") == DialogResult.OK)
                {
                    InpPassword.Text = "";
                    InpUser.Text = "";
                    InpUser.Focus();
                }
            }
        }
    }
}
