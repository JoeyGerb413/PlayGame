using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace PlayGame
{
    public partial class EpicGame : Form
    {
        public EpicGame()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            
            Thread.Sleep(333);
            CreditDisplay.Text = "3";
            Refresh();
            Thread.Sleep(333);
            CreditDisplay.Text = "3.";

            Refresh();
            Thread.Sleep(333);
            CreditDisplay.Text = "3..";

            Refresh();
            Thread.Sleep(333);
            CreditDisplay.Text = "3..    2";

            Refresh();
            Thread.Sleep(333);
            CreditDisplay.Text = "3..    2.";

            Refresh();
            Thread.Sleep(333);
            CreditDisplay.Text = "3..    2..";

            Refresh();
            Thread.Sleep(333);
            CreditDisplay.Text = "3..    2..    1";

            Refresh();
            Thread.Sleep(333);
            CreditDisplay.Text = "3..    2..    1.";


            Refresh();
            Thread.Sleep(333);
            SoundPlayer xplode = new SoundPlayer(Properties.Resources.Xplode);
            BackColor = Color.White;
            xplode.Play();
            CreditDisplay.Text = "3..    2..    1..";
            Refresh();
            Thread.Sleep(333);
            CreditDisplay.Hide();
            StartButton.Hide();
            GO.ForeColor = Color.Orange;




        }

        private void EpicGame_Load(object sender, EventArgs e)
        {

        }
    }
}
