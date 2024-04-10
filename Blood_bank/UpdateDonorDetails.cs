using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_bank
{
    public partial class UpdateDonorDetails : Form
    {
        function fn = new function();
        public UpdateDonorDetails()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtDonorID.Text =="")
            {
                txtDonorID.Clear();
                txtName.Clear();
                txtFather.Clear();
                txtMother.Clear();
                txtDOB.ResetText();
                txtMobile.Clear();
                txtGender.ResetText();
                txtEmail.Clear();
                txtBloodGroup.ResetText();
                txtCity.Clear();
                txtAddress.Clear();
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtDonorID.Text.ToString());
            String query = "SELECT * FROM newDonor WHERE did =" + id;
            DataSet ds = fn.getData(query);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count != 0)
            {
                txtName.Text = ds.Tables[0].Rows[0]["dname"].ToString();
                txtFather.Text = ds.Tables[0].Rows[0]["fname"].ToString();
                txtMother.Text = ds.Tables[0].Rows[0]["mname"].ToString();
                txtDOB.Text = ds.Tables[0].Rows[0]["dob"].ToString();
                txtMobile.Text = ds.Tables[0].Rows[0]["mobile"].ToString();
                txtGender.Text = ds.Tables[0].Rows[0]["gender"].ToString(); 
                txtEmail.Text = ds.Tables[0].Rows[0]["email"].ToString();
                txtBloodGroup.Text = ds.Tables[0].Rows[0]["bloodgroup"].ToString();
                txtCity.Text = ds.Tables[0].Rows[0]["city"].ToString();
                txtAddress.Text = ds.Tables[0].Rows[0]["daddress"].ToString();
            }
            else
            {
                MessageBox.Show("Invalid Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            String query = "update newDonor set dname ='"+txtName.Text+"',fname='"+txtFather.Text+"',mname='"+txtMother.Text+"',dob='"+txtDOB.Text+"',mobile='"+txtMobile.Text+"',gender='"+txtGender.Text+"',email='"+txtEmail.Text+"',bloodgroup='"+txtBloodGroup.Text+"',city='"+txtCity.Text+"',daddress='"+txtAddress.Text+"' where did ="+txtDonorID.Text+ "          ";
            fn.setData(query);
            UpdateDonorDetails_Load(this, null);

        }

        private void UpdateDonorDetails_Load(object sender, EventArgs e)
        {
            txtDonorID.Clear();
            

        }
    }
}
