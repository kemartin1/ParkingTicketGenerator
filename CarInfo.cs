using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Car;

namespace ParkingTicketGenerator
{
    public partial class CarInfo : Form
    {
        
        public CarInfo()
        {
            InitializeComponent();
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtMake.Text == "" || txtModel.Text == "" || txtColor.Text == "" || txtPlateNum.Text == "")
                MessageBox.Show("All data must be filled!");
            else
            {
                Form1 form1 = new Form1(txtMake.Text, txtModel.Text, txtColor.Text, txtPlateNum.Text);
                this.Close();
                form1.ShowDialog();
            }
        }
    }
    

}
