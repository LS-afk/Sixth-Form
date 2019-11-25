using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoachUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Name.Text = "";
            Age.Text = "";
            Seat.Text = "";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // create a Person with correct name and age 

            Person p1 = new Person(Name.Text,

            Convert.ToInt32(Age.Text));

            // add to the Coach; it passes back the seat number 

            int seat = myCoach.AddPerson(p1); 

            //  now display the seat number 

            Seat.Text = seat + "";
        }
    }
}
