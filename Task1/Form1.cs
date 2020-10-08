using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startgameButton_Click(object sender, EventArgs e)
        {
            try
            {

                int min_width = Convert.ToInt32(minwidthBox.Text);
                int max_width = Convert.ToInt32(minwidthBox.Text);
                int min_length = Convert.ToInt32(minlengthBox.Text);
                int max_length = Convert.ToInt32(maxlengthBox.Text);
                int enemies = Convert.ToInt32(enemiesBox.Text);

                startGame(min_width, max_width, min_length, max_length, enemies);

            }catch(FormatException exc)
            {
                errorLabel.Text = "Please input numbers";
            }


            }

        private void startGame(int min_width, int max_width, int min_height, int max_height, int num_enemies)
        {
            errorLabel.Text = "";

            GamePlay gp = new GamePlay(min_width, max_width, min_height, max_height, num_enemies);
            gp.setCaller(this);
            gp.Show();
            this.Hide();
        }
    }
}
