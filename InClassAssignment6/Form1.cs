using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassAssignment6
{
    public partial class frmDice : Form
    {
        public frmDice()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method to Role the Dice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRoleDice_Click(object sender, EventArgs e)
        {
            //  Now we need to role the dice until we get snake eyes and then report the number of roles it took 
            //  First define var's 
            int rolesDice1 = 0, rolesDice2 = 0;
            int sendNumber = 20;
            int defineSides = 6;

            //  Now lets create dice obj's 
            DiceClass dice1 = new DiceClass(sendNumber, defineSides);
            //  DiceClass dice2 = new DiceClass(sendNumber, defineSides);
            //  now role dice1 and get the back the face value
            rolesDice1 = dice1.roleDie();
            //  put this value in the label
            lblDice1.Text = rolesDice1.ToString();

            //  When creating a Random instance it's seeded with the current time. So if you create several of them at the same time 
            //      they'll generate the same random number sequence
            System.Threading.Thread.Sleep(100);

            DiceClass dice2 = new DiceClass(sendNumber, defineSides);
            //  Role Dice 2 
            rolesDice2 = dice2.roleDie();
            //  put this value in the label
            lblDice2.Text = rolesDice2.ToString();
        }
    }
}
