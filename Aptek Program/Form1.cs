using Aptek_Program.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aptek_Program
{
    public partial class SAF : Form
    {
        AptekApp DB = new AptekApp();
        public SAF()
        {
            InitializeComponent();
        }



        private void SAF_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Xoş gəlmisiniz!";
            Settings selectedSetting = DB.Settings.First();
            this.Icon = new Icon("../../Uploads/" + DB.Settings.First().Logo);
            this.Text = selectedSetting.Name;
            lblWelcome.Text = selectedSetting.Header;
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string email = txtUsername.Text;
            string password = txtPassword.Text;
            if (email != null && password != null)
            {
                Admin selectAdmin = DB.Admin.FirstOrDefault(ad => ad.Email == email);
                if (selectAdmin != null)
                {
                    if (selectAdmin.Password == password)
                    {
                        AdminDashboard Adm = new AdminDashboard();
                        Adm.ShowDialog();
                    }

                }
                else
                {
                    Workers selectWorker = DB.Workers.FirstOrDefault(wrk => wrk.Username == email);
                    if (selectWorker != null)
                    {
                        if (selectWorker.Password != password)
                        {
                            WorkersDashboard wd = new WorkersDashboard();
                            wd.ShowDialog();
                        }
                        else
                        {
                            lblError.Text = "Shifre duzgun deyil!";
                            lblError.Visible = true;
                        }
                    }
                    else
                    {
                        lblError.Text = "Email duzgun deyil!";
                        lblError.Visible = true;
                    }
                }

            }
            else
            {
                lblError.Text = "Zehmet olmasa xanalari doldurun!";
                lblError.Visible = true;
            }
        }
    }
}

                  
