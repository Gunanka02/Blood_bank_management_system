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
    public partial class DeleteDonor : Form
    {
        function fn = new function();
        String query;
        public DeleteDonor()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtDonorID.Text!="")
            {
                query = "select * from newDonor where did =" + txtDonorID.Text + "";
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
                    MessageBox.Show("No Record Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDonorID.Clear();
                }

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (txtDonorID.Text == "")
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

        private void txtDonorID_TextChanged(object sender, EventArgs e)
        {

            if (txtDonorID.Text == "")
            {
                txtDonorID.Clear();
                txtName.Clear();
                txtFather.Clear();
                txtMother.Clear();
                txtDOB.Clear();
                txtMobile.Clear();
                txtGender.Clear();
                txtEmail.Clear();
                txtBloodGroup.Clear();
                txtCity.Clear();
                txtAddress.Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you Sure?","Delete",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                query = "delete from newDonor where did =" + txtDonorID.Text + "";
                fn.setData(query);

            }
        }
    }
}
