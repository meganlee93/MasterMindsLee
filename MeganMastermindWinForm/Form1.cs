using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeganMastermindWinForm
{
    public partial class Form1 : Form
    {
        int[] master = new int[4];
        int[] userArray = new int[4];

        //create numbers

        public Form1()
        {
            InitializeComponent();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            //for one number only
            int num = int.Parse(userTextBox.Text);

            
        }
    }
}
