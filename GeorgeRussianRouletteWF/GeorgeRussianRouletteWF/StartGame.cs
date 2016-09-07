using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeorgeRussianRouletteWF
{
    public partial class StartGame : Form
    {        
        public StartGame()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        public string StartPlayerName;

        private void btnSubmitPlayerName_Click(object sender, EventArgs e)
        {
            StartPlayerName = txtPlayerName.Text;

            Form1 StayAliveGame = new Form1(this);
            this.Hide();
            StayAliveGame.Show();
        }
    }
}
