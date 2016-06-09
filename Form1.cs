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
using Police;

namespace ParkingTicketGenerator
{
    public partial class Form1 : Form
    {
       Cars car = new Cars();
       CarInfo f2 = new CarInfo();
       bool isParked = false;
       

        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string make, string model, string color, string plateNum)
        {
            InitializeComponent();
            car.Make = make;
            car.Model = model;
            car.Color = color;
            car.PlateNum = plateNum;
            picCar.Show();
            isParked = true;
            btnPark.Enabled = false;
        }

        private void btnPark_Click(object sender, EventArgs e)
        {
            this.Hide();
            f2.Show();
            picCar.Visible = true;
            
        }

        private void btnInspect_Click(object sender, EventArgs e)
        {
            
            if (isParked == false)
                MessageBox.Show("Why check an empty meter?");
            else
            {
                picPolice.Visible = true;
                if (car.MinPurchased > 0)
                {
                    MessageBox.Show("Your car still has " + car.MinPurchased.ToString() + " remaining");
                    picPolice.Visible = false;
                }
                else
                {
                    MessageBox.Show("BUSTED! Meter is out of time");
                    Ticket ticket = new Ticket(car.Make, car.Model, car.Color, car.PlateNum, car.MinPurchased);
                    ticket.ShowDialog();
                }
            }

        }

        private void btnElapse_Click(object sender, EventArgs e)
        {
            if (isParked == false)
                MessageBox.Show("Why elapse time if you aren't parked");
            else
            {
                car.MinParked += 30;
                car.MinPurchased -= 30;
                if (car.MinPurchased <= 0) //changes time label on meter to red when 0 has been reached
                    lblTime.ForeColor = System.Drawing.Color.Red;

                lblTime.Text = car.MinPurchased.ToString();


            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isParked == false)
                MessageBox.Show("Park your car before adding money");
            else
            {
                car.MinPurchased += 15;
                if(car.MinPurchased > 0)
                {
                    lblTime.ForeColor = System.Drawing.Color.Lime;
                }
                
                lblTime.Text = car.MinPurchased.ToString();
            }
        }
       
    }
    
}
