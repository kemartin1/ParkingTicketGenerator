using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Police;
using Car;

namespace ParkingTicketGenerator
{
    public partial class Ticket : Form
    {
        Police1 popo = new Police1();

        public Ticket()
        {
            InitializeComponent();
        }
        public Ticket(string make, string model, string color, string plateNum, int minPurchased)
        {
            int amountOver;

            InitializeComponent();
            lblMake.Text = make;
            lblModel.Text = model;
            lblColor.Text = color;
            lblPlateNum.Text = plateNum;

            amountOver = Math.Abs(minPurchased);

            if (amountOver <= 60)
                popo.FineAmount = 25;
            else
            {
                int remaining;
                popo.FineAmount = 35;
                remaining = amountOver - 60;

                while(remaining > 60)
                {
                    popo.FineAmount += 10;
                    remaining -= 60;
                }
               
                
            }

                
            lblFine.Text = popo.FineAmount.ToString("c2");

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                popo.OfficerName = txtName.Text;
                popo.BadgeNum = txtBadgeNum.Text;

                lblName.Text = popo.OfficerName;
                lblBadgeNum.Text = popo.BadgeNum;

                btnSubmit.Enabled = false;
           
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            

            


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
