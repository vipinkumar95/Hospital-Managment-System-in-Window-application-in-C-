using PranjulMedicalCenter.Common;
using PranjulMedicalCenter.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PranjulMedicalCenter
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxDoctors_Click(object sender, EventArgs e)
        {
            if (Global.UserInfo.UserType != 1)
            {
                MessageBox.Show("Only Admin has access");
            }
            else
            {
                this.Hide();
                DoctorForm doctorForm = new DoctorForm();
                doctorForm.Show();
            }
        }

        private void pictureBoxPatient_Click(object sender, EventArgs e)
        {
            if (Global.UserInfo.UserType != 1)
            {
                MessageBox.Show("Only Patient has access");
            }
            else
            {
                this.Hide();
                PatientForm doctorForm = new PatientForm();
                doctorForm.Show();
            }
        }

        private void pictureBoxDiagnosis_Click(object sender, EventArgs e)
        {
            if (Global.UserInfo.UserType != 2)
            {
                MessageBox.Show("Only Diagnosis has access");
            }
            else
            {
                this.Hide();
                DiagnosisForm doctorForm = new DiagnosisForm();
                doctorForm.Show();
            }
        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Login admin_Login = new Admin_Login();
            admin_Login.Show();
        }
    }
}
