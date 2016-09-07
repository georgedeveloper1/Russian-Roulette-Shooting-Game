using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeorgeRussianRouletteWF
{
    public partial class PlayerScore : Form
    {
        string PlayerScoreRead_Path = "C:\\Users\\George\\Documents\\Visual Studio 2015\\Projects 3 Sorted\\1 Assignment\\PlayerScore.txt";
        //string PlayerScoreRead_Path = "C:\\projects\\1 Assignment\\PlayerScore.txt";

        public PlayerScore()
        {
            InitializeComponent();
        }

        private void PlayerScore_Load(object sender, EventArgs e)
        {
            this.Text = Properties.Resources.Title2;

            try
            {
                using (StreamReader playerScoreReader = new StreamReader(PlayerScoreRead_Path))

                {
                    String Line;
                    while ((Line = playerScoreReader.ReadLine()) != null)
                    {
                        String[] PlayerScoreInfo = Line.Split(',');
                        dgPlayerScore.Rows.Add(PlayerScoreInfo[0], PlayerScoreInfo[1], PlayerScoreInfo[2]);
                    }
                }


            }
            catch (Exception exread)
            {
                MessageBox.Show("File could not be  read." + exread.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBackToGame_Click(object sender, EventArgs e)
        {
            Form1 gGameForm = new Form1 ();
            gGameForm.Show();
            gGameForm.resetGame();
            this.Close();
        }
    }
}
