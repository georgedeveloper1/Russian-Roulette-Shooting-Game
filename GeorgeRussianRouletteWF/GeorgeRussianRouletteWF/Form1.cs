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


// George's Lucky Me!!! Russian Roulette Shooting Game

namespace GeorgeRussianRouletteWF
{
    public partial class Form1 : Form
    {
        int SpinChamber = 0;
        int SpinRepeat = 0;
        bool BulletLoad = false;
        string BulletLoadMessage = "\r\nOOPS! You must load the bullet :)";
        int BulletPlace = 0;
        int YourBadluck = 0;
        int TriggerCount;
        int WinCount = 0;
        int LostCount = 0;
        string PlayerName;
        string PlayerScoreWrite_Path;
        string PlayerScoreText;
        int Replay = 0;
        int ChamberSpunAlready = 0;
       

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
            pbYourPicture.SizeMode = PictureBoxSizeMode.CenterImage;
            pbYourPicture.Image = Properties.Resources.worriedEmojiImg;
            
            pbGunImage.Image = Properties.Resources.loadYourGunImg;
            pbGunImage.SizeMode = PictureBoxSizeMode.Zoom;
        }


        // Load bullet button click
        private void btnBulletLoad_Click(object sender, EventArgs e)
        {
            clearMessageBox(); // To clear text message from Message box

            Random rnd = new Random(); // Random number variable for bullet load place/position in chamber

            // for 'x' place of bullet load in chamber
            BulletPlace = rnd.Next(1, 7);

            if (rbPointHead.Checked && SpinRepeat == 0)
            {
                BulletLoad = true;

                pbGunImage.Image = Properties.Resources.spinChamberImg1;
                pbGunImage.SizeMode = PictureBoxSizeMode.CenterImage;

                txtScoresBox.Text = "\r\nBullet is loaded.";
            }

            else if (rbPointAway.Checked && SpinRepeat == 0)
            {
                BulletLoad = true;

                pbGunImage.Image = Properties.Resources.spinChamberImg1;
                pbGunImage.SizeMode = PictureBoxSizeMode.CenterImage;

                txtScoresBox.Text = "\r\nBullet is loaded.";
            }

            else if (rbPointAway.Checked && Replay != 0)
            {
                clickPlayAgainButton();
            }

            else if (rbPointHead.Checked && Replay != 0)
            {
                clickPlayAgainButton();
            }
            else if (rbPointAway.Checked == false && rbPointHead.Checked == false)
            {
                selectPointAwayHeadMessage();
            }
            else if (BulletLoad == true)
            {
                txtScoresBox.Text = "\r\nThe bullet is loaded already!";
            }
            else
            {
               // do nothing. This is to avoid the app freezing or getting into a loop may be?
            }
                        
        }

        // Spin chamber button click
        private void btnSpinChamber_Click(object sender, EventArgs e)
        {
            clearMessageBox(); // To clear text message from Message box                    

            if (BulletLoad == true)
            {
                btnFireGun.Enabled = false; // To prevent a player from pressing fire button before chamber spin is finished, not to miss the fun!
                ChamberSpunAlready++;
                spinChamberTimer.Start();
                
                Stream str = Properties.Resources.revolverSpinSnd;
                SoundPlayer snd = new SoundPlayer(str);
                snd.Play();

                            // Initializes trigger count so that Fire button can work.
            TriggerCount = 1;
            }

            else if (SpinRepeat == 12)
            {
                clickPlayAgainButton();
            }

            else if (SpinRepeat == 0)
            {
                if (rbPointAway.Checked == true)
                {
                    txtScoresBox.Text = BulletLoadMessage.ToUpper();
                }
                else if (rbPointHead.Checked == true)
                {
                    txtScoresBox.Text = BulletLoadMessage.ToUpper();
                }
                else if (rbPointAway.Checked == false && rbPointHead.Checked == false)
                {
                    selectPointAwayHeadMessage();
                }
            }

            else
            {
                txtScoresBox.Text = BulletLoadMessage.ToUpper();
            }

        }

        // Timer for chamber spin images
        private void spinChamberTimer_Tick(object sender, EventArgs e)
        {
            pbGunImage.SizeMode = PictureBoxSizeMode.CenterImage;

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
                    showPointAwayGunImg();
                    stopSpinChamberTimer();
                    txtScoresBox.Text = "\r\nNow Fire.";
                    if (ChamberSpunAlready >= 2) // This is to remind player that the chamber is spun already.
                    {
                        txtScoresBox.Text = "\r\nThe chamber is spun already!";
                    }
                }
                else if (rbPointHead.Checked)
                {
                    showPointHeadGunImg();
                    stopSpinChamberTimer();
                    txtScoresBox.Text = "\r\nNow Fire.";
                    if (ChamberSpunAlready >= 2) // This is to remind player that the chamber is spun already.
                    {
                        txtScoresBox.Text = "\r\nThe chamber is spun already!";
                    }
                }
                
                btnFireGun.Enabled = true; // Enables Fire button after chamber spin finishes                
            }

        }

        // Stop chamber spin timer
        private void stopSpinChamberTimer()
        {
            spinChamberTimer.Stop();
        }


        // Fire/Shoot gun button click
        private void btnFireGun_Click(object sender, EventArgs e)
        {
            clearMessageBox(); // To clear text message from Message box

            Random rndBadLuck = new Random(); //Random number variable for gun fire

            // for 'x' place of loaded bullet fire at button click, I wanted it changed at every button click
            YourBadluck = rndBadLuck.Next(1, 7);


            // Scenario for Fire button
            if (SpinRepeat == 0)
            {
                selectPointAwayHeadMessage();
            }
           
            while (TriggerCount != 0 && TriggerCount <= 6)
            {

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
                        txtScoresBox.Text = "\r\nYour Chance is up. You must now POINT AT HEAD!!!";
                        lblDeadOrLuckyMessage.Text = "Oh no! No chance of escape :{";
                        TriggerCount++;
                        break;
                    }

                    else if (rbPointHead.Checked)
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
                runBadLuck(); // This is forcing a bullet fire/Game Over at the 6th shot, if two way random match hasn't occured in the previous 5 shots.
                              // A try catch exception could be added later for instances when the forced bullet fire coincides with the random match bullet fire at the 6th shot!?!?
                BulletLoad = false;
                btnFireGun.Enabled = false;
            }

            else if (TriggerCount == 0 && Replay != 0)
            {
                selectPointAwayHeadMessage();
            }

            else if (rbPointAway.Checked == false && rbPointHead.Checked == false)
            {
                selectPointAwayHeadMessage();
            }

        }

        // Images, sound and actions while bullet is not fired from gun on fire button click, game continues
        private void runStillAlive()
        {
            clearMessageBox(); // To clear text message from Message box

            // Loaded gun image pointed away
            if (rbPointAway.Checked)
            {
                showPointAwayGunImg();
            }
            else
            {
                showPointHeadGunImg();
            }
            
            Stream str = Properties.Resources.gunClickSnd;
            SoundPlayer snd = new SoundPlayer(str);
            snd.Play();

            txtScoresBox.Text = "\r\nFire again.";

            pbarTriggerCount.Increment(1);

            TriggerCount++;                        
        }

        // Images, sound, actions and messages when bullet is fired in first two shots when gun pointed away, player escapes, player wins and Game Over
        private void runEscaped()
        {
            clearMessageBox(); // To clear text message from Message box

            // Gun fire image pointed away
            showAwayGunFireImg();

            // play sound of gun fire
            Stream str = Properties.Resources.gunFireSnd;
            SoundPlayer snd = new SoundPlayer(str);
            snd.Play();

            pbYourPicture.SizeMode = PictureBoxSizeMode.Zoom;
            pbYourPicture.Image = Properties.Resources.happyEmojiImg;

            pbarTriggerCount.Increment(1);

            lblDeadOrLuckyMessage.Text = "You Escaped!!! You Win!!!";

            txtScoresBox.Text = "\r\nGame Over. Play again or check your score2.";

            TriggerCount++;
                        
            BulletLoad = false;

            btnFireGun.Enabled = false;

            WinCount++;

            Replay++;

            txtScoresBox.Text = "\r\nGameOver" + "\r\nWon - " + WinCount.ToString() + " / " + "Lost - " + LostCount.ToString() + "\r\nPlay Again or Check Score.";
        }


        // Images, sound, actions and messages when bullet is fired after the first two shots when gun is pointed at head or during any shot when gun is pointed at head, player dead, player loses and Game Over
        private void runBadLuck()
        {
            clearMessageBox(); // To clear text message from Message box

            // Gun fire image pointed at head
            showPointGunFireImg();

            // play sound of gun fire
            Stream str = Properties.Resources.gunFireSnd;
            SoundPlayer snd = new SoundPlayer(str);
            snd.Play();

            pbYourPicture.SizeMode = PictureBoxSizeMode.CenterImage;
            pbYourPicture.Image = Properties.Resources.deadEmojiImg;

            pbarTriggerCount.Increment(1);

            lblDeadOrLuckyMessage.Text = "You are Dead!!! You Lost!!!";

            txtScoresBox.Text = "\r\nGame Over. Play again or check your score2.";

            TriggerCount++;                     

            BulletLoad = false;

            btnPlayAgain.Enabled = true;

            btnFireGun.Enabled = false;

            LostCount++;

            Replay++;

            txtScoresBox.Text = "\r\nGameOver" + "\r\nWon - " + WinCount.ToString() + " / " + "Lost - " + LostCount.ToString() + "\r\nPlay Again or Check Score.";
        }

        // Play Again button for replaying game, runs function that resets all calculations for a fresh start
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            if (SpinRepeat == 0)
            {
                clearMessageBox(); // To clear text message from Message box
                txtScoresBox.Text = "\r\nYou can play again after you finish this game.";
            }
            else
            {
                resetGame();
            }
        }

        // When radio button selection is changed to Point at Head
        private void rbPointHead_CheckedChanged(object sender, EventArgs e)
        {
            clearMessageBox(); // To clear text message from Message box

            // Loaded gun image pointed at head
            showPointHeadGunImg();

            btnFireGun.Enabled = true;

            if (BulletLoad == true)
            {
                txtScoresBox.Text = "\r\nFire again.";
            }            
        }

        // When radio button selection is changed to Point Away
        private void rbPointAway_CheckedChanged(object sender, EventArgs e)
        {
            clearMessageBox(); // To clear text message from Message box                      
            
            // Loaded gun image pointed away
            showPointAwayGunImg();
        }


        // Check game win or loss score button
        private void btnCheckScore_Click(object sender, EventArgs e)
        {
            PlayerScoreText = Convert.ToString(PlayerName) + "," + Convert.ToString(WinCount) + "," + Convert.ToString(LostCount);

            try
            {
                // Write file path should be changed to the location on PC this application is run
                PlayerScoreWrite_Path = "C:\\projects\\1 Assignment\\PlayerScore.txt";

                using (StreamWriter swriter = new StreamWriter(PlayerScoreWrite_Path, true)) // This appends to the text file what is in the text box at runtime
                {
                    swriter.Write(PlayerScoreText + "\r\n");                    
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
            TriggerCount = 0;
            btnFireGun.Enabled = true;
            BulletLoad = false;
            rbPointAway.Checked = false;
            rbPointAway.Enabled = true;
            rbPointHead.Checked = false;
            pbarTriggerCount.Value = 0;
            pbGunImage.Image = Properties.Resources.loadYourGunImg;
            pbGunImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbYourPicture.Image = Properties.Resources.worriedEmojiImg;
            pbYourPicture.SizeMode = PictureBoxSizeMode.CenterImage;
            // txtPlayerName.Text = ""; no need to reset Player name to blank. It's there for later use if game is modified for a new player name when replayed in the same session.
            lblDeadOrLuckyMessage.Text = "!!! Good Luck again !!!";
            txtScoresBox.Text = "\r\nNow choose POINT AWAY or POINT AT HEAD and follow the steps.";
            SpinRepeat = 0;
        }

        // text message asking to finish current game before replaying
        private void clickPlayAgainButton()
        {
            MessageBox.Show("OOPS! You must click the PLAY AGAIN button and follow the steps :)");
            txtScoresBox.Text = "\r\nOOPS! You must click the PLAY AGAIN button and follow the steps :)";
        }

        // text message asking POINT AWAY or POINT AT HEAD to be selected to play game
        private void selectPointAwayHeadMessage()
        {
            MessageBox.Show("OOPS! You must choose POINT AWAY or POINT AT HEAD and follow the steps :)");
            txtScoresBox.Text = "\r\nOOPS! You must choose POINT AWAY or POINT AT HEAD and follow the steps :)";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // To show Point Away Gun image
        private void showPointAwayGunImg()
        {
            pbGunImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbGunImage.Image = Properties.Resources.pointAwayGunImg;
        }

        // To show Point at Head Gun image
        private void showPointHeadGunImg()
        {
            pbGunImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbGunImage.Image = Properties.Resources.loadedGunImg;
        }

        // To show Point at Head Gun Fire image
        private void showPointGunFireImg()
        {
            pbGunImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbGunImage.Image = Properties.Resources.gunFireImg;
        }

        // To show Point Away Gun Fire image
        private void showAwayGunFireImg()
        {
            pbGunImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbGunImage.Image = Properties.Resources.pointAwayGunFireImg;
        }

        // To clear text message from Message box
        private void clearMessageBox()
        {
            txtScoresBox.Text = "";
        }
    }

}

// End of code