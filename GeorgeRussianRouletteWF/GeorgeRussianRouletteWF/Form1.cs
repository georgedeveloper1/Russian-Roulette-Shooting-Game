using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeorgeRussianRouletteWF
{
    public partial class Form1 : Form
    {
        int SpinChamber = 0;
        int SpinRepeat = 0;
        bool BulletLoad = false;
        string BulletLoadMessage = "Oops! You must load the bullet!";
        string LoadGunMessage = "Oops! Load the bullet and spin chamber to fire!";
        int BulletPlace = 0;
        int YourBadluck = 0;
        int TriggerCount;
        int WinCount = 0;
        int LostCount = 0;
        string PlayerName;
        string PlayerScoreWrite_Path;
        string PlayerScoreText;
        int Replay = 0;

        //string txtScoresBox.Text = "Win" + Convert.ToString(WinCount) + " / " + "Lost" + Convert.ToString(LostCount);
        

        StartGame startGame;
                

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(StartGame objStartGame)
        {
            InitializeComponent();
            startGame = objStartGame;
            PlayerName = objStartGame.StartPlayerName;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Properties.Resources.Title;
            pbYourPicture.Image = Properties.Resources.worriedEmojiImg;
            pbYourPicture.SizeMode = PictureBoxSizeMode.Zoom;

            pbGunImage.Image = Properties.Resources.loadYourGunImg;
            pbGunImage.SizeMode = PictureBoxSizeMode.Zoom;

            //btnPlayAgain.Enabled = false;
        }

        // Load bullet button click
        private void btnBulletLoad_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(); // Random number variable for bullet load place/position in chamber

            // for 'nth' place of bullet load
            BulletPlace = rnd.Next(1, 7);

            // Initializes trigger count so that Fire button can work.
            TriggerCount = 1;

            if (rbPointHead.Checked && SpinRepeat == 0)
            {
                MessageBox.Show(PlayerScoreText);

                BulletLoad = true;

                // Loaded gun image
                runPointHeadGunImg();


            }

            else if (rbPointAway.Checked && SpinRepeat == 0)
            {
                MessageBox.Show(PlayerScoreText);

                BulletLoad = true;

                // Loaded gun image pointed away
                runPointAwayGunImg();

            }
            else if (rbPointAway.Checked && SpinRepeat != 0)
            {
                MessageBox.Show("You must click the PLAY AGAIN button)");
            }

            else if (rbPointHead.Checked && SpinRepeat != 0)
            {
                MessageBox.Show("OOPS! You must click the PLAY AGAIN button!");
            }

            else
            {
                MessageBox.Show("You must choose POINT AWAY or POINT AT HEAD :)");
            }
                        
        }

        // Spin chamber button click
        private void btnSpinChamber_Click(object sender, EventArgs e)
        {
            
            if (BulletLoad == true)
            {
                spinChamberTimer.Start();
                
                Stream str = Properties.Resources.revolverSpinSnd;
                SoundPlayer snd = new SoundPlayer(str);
                snd.Play();
            }

            else if (SpinRepeat == 12)
            {
                MessageBox.Show("OOPS! You must click PLAY AGAIN and follow the steps!");
            }

            else
            {
                MessageBox.Show(BulletLoadMessage.ToUpper());
            }

        }

        // Timer for chamber spin images
        private void spinChamberTimer_Tick(object sender, EventArgs e)
        {
            pbGunImage.SizeMode = PictureBoxSizeMode.Normal;

            if (SpinRepeat <= 12)
            {
                if (SpinChamber == 0)
                {
                    pbGunImage.Image = Properties.Resources.spinChamberImg2;
                    SpinChamber = 1;
                }
                else if (SpinChamber == 1)
                {
                    pbGunImage.Image = Properties.Resources.spinChamberImg3;
                    SpinChamber = 2;
                }
                else if (SpinChamber == 2)
                {
                    pbGunImage.Image = Properties.Resources.spinChamberImg4;
                    SpinChamber = 3;
                }
                else if (SpinChamber == 3)
                {
                    pbGunImage.Image = Properties.Resources.spinChamberImg1;
                    SpinChamber = 4;                    
                }
                else if (SpinChamber == 4)
                {
                    pbGunImage.Image = Properties.Resources.spinChamberImg2;
                    SpinChamber = 0;
                    SpinRepeat++;                    
                }                               
            }

            // Gun images when chamber stops

            if (SpinRepeat == 12)
            {
                if (rbPointAway.Checked)
                {
                    runPointAwayGunImg();
                    stopSpinChamberTimer();
                }

                else if (rbPointHead.Checked)
                {
                    runPointHeadGunImg();
                    stopSpinChamberTimer();
                }
            }

        }

        private void stopSpinChamberTimer()
        {
            spinChamberTimer.Stop();
        }

        // Shoot gun button click
        private void btnFireGun_Click(object sender, EventArgs e)
        {
            Random rndBadLuck = new Random(); //Random number variable for gun fire

            // for 'nth' place of loaded bullet fire at button click
            YourBadluck = rndBadLuck.Next(1, 7);

            //MessageBox.Show("Trigger count outside if and while" + TriggerCount.ToString());

            if (SpinRepeat == 0)
            {
                MessageBox.Show("You must choose POINT AWAY or POINT ATHEAD, then Load Bullet and spin chamber!");
            }
            
            while (TriggerCount != 0 && TriggerCount <= 6)
            {

                //MessageBox.Show("Trigger count" + TriggerCount.ToString());
                //MessageBox.Show("Fire place" + YourBadluck.ToString());
                //MessageBox.Show("Bullet place" + BulletPlace.ToString());

                if (TriggerCount <= 1 && rbPointAway.Checked)
                {
                    if (BulletLoad == true && BulletPlace != YourBadluck)
                    {
                        runStillAlive();
                        break;
                    }
                    else if (BulletLoad == true && BulletPlace == YourBadluck)
                    {
                        runEscaped();
                        break;
                    }
                }

                else if (TriggerCount <= 1 && rbPointHead.Checked)
                {
                    if (BulletLoad == true && BulletPlace != YourBadluck)
                    {
                        runStillAlive();
                        break;
                    }
                    else if (BulletLoad == true && BulletPlace == YourBadluck)
                    {
                        runBadLuck();
                        break;
                    }
                }

                else if (TriggerCount > 1)
                {
                    if (BulletLoad == true && rbPointAway.Checked)
                    {
                        rbPointAway.Enabled = false;
                        btnFireGun.Enabled = false;
                        pbarTriggerCount.Increment(1);
                        MessageBox.Show(" Your Chance is up. You must now POINT AT HEAD!!!");
                        lblDeadOrLuckyMessage.Text = "Oh no! No chance of escape!";
                        TriggerCount++;
                        break;
                    }
                    if (rbPointHead.Checked)
                    {
                        if (BulletLoad == true && BulletPlace != YourBadluck)
                        {
                            runStillAlive();
                            break;
                        }
                        else if (BulletLoad == true && BulletPlace == YourBadluck)
                        {
                            runBadLuck();                            
                            break;
                        }
                    }

                }

            }

            if (TriggerCount > 6 && BulletPlace != YourBadluck)
            {
                runBadLuck(); // This is forcing a bullet fire/Game Over at the 6th shot, if random match hasn't occured in the previous 5 shots.
                //MessageBox.Show("Game Over. Play again or check your scores1.");
                BulletLoad = false;
                btnFireGun.Enabled = false;
                                
            }
        }

        


        //// Gun fire

        //else if (TriggerCount < 7)
        //{                
        //    if (BulletLoad == true && rbPointHead.Checked)
        //    {
        //        Stream str = Properties.Resources.GunClickSnd;
        //        SoundPlayer snd = new SoundPlayer(str);
        //        snd.Play();

        //        TriggerCount++;
        //    }

        //}                   


        //else
        //{
        //    MessageBox.Show(LoadGunMessage.ToUpper());
        //}

        // stillAlive is for empty trigger sound and images.
        private void runStillAlive()
        {
            // Loaded gun image pointed away
            if (rbPointAway.Checked)
            {
                runPointAwayGunImg();
            }
            // Loaded gun image pointed at head
            else
            {
                runPointHeadGunImg();
            }
            
            Stream str = Properties.Resources.gunClickSnd;
            SoundPlayer snd = new SoundPlayer(str);
            snd.Play();

            pbarTriggerCount.Increment(1);

            TriggerCount++;
            Replay++;
                        
        }

        // runEscaped is for empty trigger in first two shots when gun pointed away, player escapes, player wins and Game Over
        private void runEscaped()
        {
            // Gun fire image pointed away
            runAwayGunFireImg();

            // play sound of gun fire
            Stream str = Properties.Resources.gunFireSnd;
            SoundPlayer snd = new SoundPlayer(str);
            snd.Play();

            pbYourPicture.SizeMode = PictureBoxSizeMode.Zoom;
            pbYourPicture.Image = Properties.Resources.happyEmojiImg;

            pbarTriggerCount.Increment(1);

            btnFireGun.Enabled = false;
            lblDeadOrLuckyMessage.Text = "You Escaped!!! You Win!!!";

            MessageBox.Show("Game Over. Play again or check your scores2.");

            TriggerCount++;
                        
            BulletLoad = false;

            btnFireGun.Enabled = false;

            btnPlayAgain.Enabled = true;

            WinCount++;

            Replay++;

            txtScoresBox.Text = "\r\nWon - " + WinCount.ToString() + " / " + "Lost - " + LostCount.ToString();
        }


        // RunBadLuck is for loaded trigger, player dead, player loses and Game Over
        private void runBadLuck()
        {
            // Gun fire image pointed at head
            runPointGunFireImg();

            // play sound of gun fire
            Stream str = Properties.Resources.gunFireSnd;
            SoundPlayer snd = new SoundPlayer(str);
            snd.Play();

            pbYourPicture.SizeMode = PictureBoxSizeMode.Zoom;
            pbYourPicture.Image = Properties.Resources.deadEmojiImg;

            pbarTriggerCount.Increment(1);

            btnFireGun.Enabled = false;
            lblDeadOrLuckyMessage.Text = "You are Dead!!! You Lost!!!";

            MessageBox.Show("Game Over. Play again or check your scores2.");

            TriggerCount++;                     

            BulletLoad = false;

            btnFireGun.Enabled = false;

            btnPlayAgain.Enabled = true;

            LostCount++;

            Replay++;

            txtScoresBox.Text = "\r\nWon - " + WinCount.ToString() + " / " + "Lost - " + LostCount.ToString();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            if (SpinRepeat == 0)
            {
                MessageBox.Show("You can play again after you finish this game.");
            }
            else
            {
                resetGame();
            }
        }

        private void rbPointHead_CheckedChanged(object sender, EventArgs e)
        {
            // Loaded gun image pointed at head
            runPointHeadGunImg();

            MessageBox.Show("Trigger count" + TriggerCount.ToString());
            MessageBox.Show("Fire place" + YourBadluck.ToString());
            MessageBox.Show("Bullet place" + BulletPlace.ToString());
            BulletLoad = true;
            btnFireGun.Enabled = true;
        }
        
        private void rbPointAway_CheckedChanged(object sender, EventArgs e)
        {
            // Loaded gun image pointed away
            runPointAwayGunImg();

            //BulletLoad = true;
            //btnFireGun.Enabled = true;
        }

        // Check game win or loss game scores
        private void btnCheckScore_Click(object sender, EventArgs e)
        {
            //PlayerName = txtPlayerName.Text; not required to assign to text field as it's available from StartGame object.

            PlayerScoreText = Convert.ToString(PlayerName) + "," + Convert.ToString(WinCount) + "," + Convert.ToString(LostCount);

            try
            {
                //TOFIX PlayerScoreWrite_Path = "C:\\Users\\George\\Documents\\Visual Studio 2015\\Projects 3 Sorted\\1 Assignment\\PlayerScore.txt";
                //TOFIX PlayerScoreWrite_Path =‪ "\\\telmar\\users\\PK016\\My Documents\\Visual Studio 2015\\Projects\\1 Assignment prog 1\\PlayerScore.txt";
                PlayerScoreWrite_Path = "C:\\projects\\1 Assignment\\PlayerScore.txt";



                using (StreamWriter swriter = new StreamWriter(PlayerScoreWrite_Path, true)) // This appends to the text file what is in the text box at runtime and not present in the code as below
                {
                    swriter.Write(PlayerScoreText + "\r\n");
                    //MessageBox.Show("Text box data written to File");
                }                
            }
            catch (Exception exWrite)
            {
                MessageBox.Show("The file could not be written.");
                MessageBox.Show(exWrite.Message);
            }

            PlayerScore psForm = new PlayerScore();
            psForm.Show();
            this.Hide();
        }

        // This is to replay the game upon clicking Play Again button after the game is over, it resets all calculations for a fresh start.
        public void resetGame()
        {
            BulletPlace = 0;
            YourBadluck = 0;
            //TriggerCount = 1;
            btnFireGun.Enabled = true;
            BulletLoad = false;
            rbPointAway.Checked = false;
            rbPointAway.Enabled = true;
            rbPointHead.Checked = false;
            pbarTriggerCount.Value = 0;
            pbGunImage.Image = Properties.Resources.loadYourGunImg;
            pbGunImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbYourPicture.Image = Properties.Resources.worriedEmojiImg;
            pbYourPicture.SizeMode = PictureBoxSizeMode.Zoom;
            // txtPlayerName.Text = ""; no need to reset Player name to blank. It's there for later use if game is modified for a new player name when replayed in the same session.
            lblDeadOrLuckyMessage.Text = "!!! Good Luck again !!!";
            SpinRepeat = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Point away gun image
        private void runPointAwayGunImg()
        {
            pbGunImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbGunImage.Image = Properties.Resources.pointAwayGunImg;
        }

        // Point head gun image
        private void runPointHeadGunImg()
        {
            pbGunImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbGunImage.Image = Properties.Resources.loadedGunImg;
        }

        // Point head gun fire image
        private void runPointGunFireImg()
        {
            pbGunImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbGunImage.Image = Properties.Resources.gunFireImg;
        }

        // Point away gun fire image
        private void runAwayGunFireImg()
        {
            pbGunImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbGunImage.Image = Properties.Resources.pointAwayGunFireImg;
        }

    }
        
    }

