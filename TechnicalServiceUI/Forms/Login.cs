using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.AutoFac;

namespace TechnicalServiceUI.Forms
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        private readonly IUserService _userService;
        private MainForm _mainForm;
        public Login()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool valid = false;
            foreach (var user in _userService.GetAll().Data)
            {
                if (user.UserName==txtUsername.Text && user.Password==txtPassword.Text)
                {
                    valid = true;
                }

            }

            if (valid)
            {
                _mainForm = new MainForm();
                _mainForm.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Wrong username or password please try it again", "Wrong Username or Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}