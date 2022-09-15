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
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        STAAS_dbEntities1 db = new STAAS_dbEntities1();

        private void SignupForm_Load(object sender, EventArgs e)
        {

        }

        private bool IsEmpty()
        {
            if(txtFullName.Text.Trim() == "" || txtEmail.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Register obj = new Register();

            if (!IsEmpty())
            {
                obj.Full_Name = txtFullName.Text;
                obj.Email = txtEmail.Text;
                obj.Password = txtPassword.Text;
                obj.Role = comboRole.SelectedText.ToString();

                db.Registers.Add(obj);

                db.SaveChanges();
                MessageBox.Show("Signup Successful");
            }
            else
            {
                MessageBox.Show("Empty Fields are not allowed, Please check the missing Field");
            }

            
        }
    }
}
