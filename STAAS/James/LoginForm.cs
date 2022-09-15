using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STAAS.James
{
    public partial class LoginForm : Form
    {
        Admin_User model = new Admin_User();
        public LoginForm()
        {
            InitializeComponent();
        }

        public void clear()
        {
            TxtEmail.Text = "";
            TxtPassword.Text = "";
        }

        STAAS_dbEntities1 db = new STAAS_dbEntities1();

        private void NewUserRegister_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string Email = TxtEmail.Text;
            string Password = TxtPassword.Text;

            var record = db.Registers.Where(x => x.Email == Email && x.Password == Password).FirstOrDefault();

            if (record != null)
            {
                MessageBox.Show("Login Successful");
                clear();
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }
    }
}
