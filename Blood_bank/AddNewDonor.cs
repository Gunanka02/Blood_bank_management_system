using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Blood_bank
{
    public partial class AddNewDonor : Form
    {
        function fn = new function();
        public AddNewDonor()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewDonor_Load(object sender, EventArgs e)
        {
            String query = "select max(did) from newDonor";
            DataSet ds = fn.getData(query);
            int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            labelNewID.Text = (count+1).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(label3.Text !="" && label4.Text!="" && label5.Text!="" && label6.Text!="" && label7.Text!="" && label8.Text!="" && label10.Text!="" && label11.Text!="" && label12.Text!="" && label13.Text!="" )
            {
                String dname = label3.Text;
                String fname = label4.Text;
                String mname = label5.Text;
                String dob = label6.Text;
                Int64 mobile = Int64.Parse(label7.Text);
                String gender = label8.Text;
                String email = label10.Text;
                String bgroup = label11.Text;
                String city = label12.Text;
                String address = label13.Text;

                String query = "insert into new donor (dname,fname,mname,dob,mobile,gender,email,bloodgroup,city,address) values('" + dname + "','"+fname+"','"+mname+"','"+dob+"','"+mobile+"','"+gender+"','"+email+"','"+bgroup+"','"+city+"','"+address+"')";
                fn.setData(query); 
            }
            else
            {
                MessageBox.Show("Fill all Feilds.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

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
}
