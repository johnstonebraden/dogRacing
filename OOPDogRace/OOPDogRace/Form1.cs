using OOPDogRace.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPDogRace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private Guy[] GuyArray = null;
        public int selectedPlayer;

        public void GenerateArray()    //creating the players, giving default balance etc
        {
            Guy g = new Guy();
            GuyArray = new Guy[3]
            {
                new Guy()
                {
                    playername = "Player 1",
                    balance = 50,
                    player_radioButton = rbPlayer1,
                    player_text = txtPlayer1Info,
                    betondog = 0,
                    guy_bet_amount = 0,
                    player_max_bet = 15   
                                      
                    
                },
                new Guy()
                {
                    playername = "Player 2",
                    balance = 50,
                    player_radioButton = rbPlayer2,
                    player_text = txtPlayer2Info,
                    betondog = 0,
                    guy_bet_amount = 0,
                    player_max_bet = 15

                },
                new Guy()
                {
                    playername = "Player 3",
                    balance = 50,
                    player_radioButton = rbPlayer3,
                    player_text = txtPlayer3Info,
                    betondog = 0,
                    guy_bet_amount = 0,
                    player_max_bet = 15

                }

            };

            for (int guy = 0; guy < GuyArray.Length; guy++)
            {                
                GuyArray[guy].updateMessages();

                if(GuyArray[guy].balance < 15)
                {
                    GuyArray[guy].player_max_bet = Convert.ToInt16(GuyArray[guy].balance);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Guy g = new Guy();
            txtPlayer1Info.Text = g.showMessage();          //showing default message in the txt boxes
            txtPlayer2Info.Text = g.showMessage();
            txtPlayer3Info.Text = g.showMessage();

            GenerateArray();            
        }

        private void btnRace_Click(object sender, EventArgs e)
        {
            btnPlaceBet.Enabled = false;
            Race r = new Race();
            r.DogRace();

            if (r.winningDog == 1)
            {
                pbRaceTrack.Image = Properties.Resources.Dog1Win;   //setting picture depending on what dog won
            }
            else if (r.winningDog == 2)
            {
                pbRaceTrack.Image = Properties.Resources.Dog2Win;
            }
            else if (r.winningDog == 3)
            {
                pbRaceTrack.Image = Properties.Resources.Dog3Win;
            }
            else if (r.winningDog == 4)
            {
                pbRaceTrack.Image = Properties.Resources.Dog4Win;
            }
            Bet b = new Bet();
            Guy guy = new Guy();
            foreach (Guy g in GuyArray)        //seeing if the player wins or loses, gives appropirate messages/values
            {
                if(r.winningDog == g.betondog)                          
                {
                    b.betReturns(g.guy_bet_amount);
                    
                    g.balance = g.balance + b.BetReturn;
                  
                    g.updateMessages();
                   
                    g.player_text.Text = g.playername + " bet $" + g.guy_bet_amount + " and won! Return $" + b.BetReturn;
                    
                }
                else if (r.winningDog != g.betondog)
                {
                    g.player_text.Text = g.playername + " lost this round";
                } 
                
                      
                if (g.betondog == 0)
                {
                    g.player_text.Text = g.playername + " did not make a bet";
                }       
            }
            btnRace.Enabled = false;
            btnReset.Enabled = true;

            if(GuyArray[0].balance == 0 && GuyArray[1].balance == 0 && GuyArray[2].balance == 0)   // when they all have $0 game asks if players want to play again or not
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to play again?", "Game over", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
            }


        }   //races the dogs giving a random value of who wins

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnPlaceBet.Enabled = true;
            btnReset.Enabled = false;
            btnRace.Enabled = true;
            pbRaceTrack.Image = Properties.Resources.StartingRace;
            Guy g = new Guy();
            txtPlayer1Info.Text = g.showMessage();          //showing default message in the txt boxes after reset
            txtPlayer2Info.Text = g.showMessage();
            txtPlayer3Info.Text = g.showMessage();
            rbPlayer1.Enabled = true;
            rbPlayer2.Enabled = true;
            rbPlayer3.Enabled = true;
            btnPlaceBet.Enabled = true;
            rbPlayer1.Checked = true;
            foreach (var guy in GuyArray)
            {
                guy.betondog = 0;     //setting bet back to 0 to prevent bug ( could keep pressing race and next round and win money without actually betting anything)
                if (guy.balance == 0)
                {
                    guy.betondog = 0;
                    guy.player_radioButton.Enabled = false;
                    guy.player_text.Text = "BUSTED";
                    guy.player_text.Enabled = false;
                }
            }
        }   //resets game

        private void btnPlaceBet_Click(object sender, EventArgs e)    //places the bet depending on which player radio button is pressed
        {
            Bet b = new Bet();
            b.betMade(GuyArray[selectedPlayer].playername, Convert.ToInt16(udDogNumber.Value), Convert.ToInt16(udBetAmount.Value));  //making the bet on button click, sending values to the functions
            if (selectedPlayer == 0)
            {
                GuyArray[0].balance = GuyArray[0].balance - Convert.ToDouble(udBetAmount.Value);
                txtPlayer1Info.Text = b.BetMessage;
                rbPlayer1.Enabled = false;
                GuyArray[0].betondog = Convert.ToInt16(udDogNumber.Value);
                GuyArray[0].guy_bet_amount = Convert.ToInt16(udBetAmount.Value);
                rbPlayer1.Checked = false;
                rbPlayer2.Checked = true;

            }
            else if (selectedPlayer == 1)
            {
                GuyArray[1].balance = GuyArray[1].balance - Convert.ToDouble(udBetAmount.Value);
                txtPlayer2Info.Text = b.BetMessage;
                rbPlayer2.Enabled = false;
                GuyArray[1].betondog = Convert.ToInt16(udDogNumber.Value);
                GuyArray[1].guy_bet_amount = Convert.ToInt16(udBetAmount.Value);
                rbPlayer2.Checked = false;
                rbPlayer3.Checked = true;
            }
            else if (selectedPlayer == 2)
            {
                GuyArray[2].balance = GuyArray[2].balance - Convert.ToDouble(udBetAmount.Value);
                txtPlayer3Info.Text = b.BetMessage;
                rbPlayer3.Enabled = false;
                GuyArray[2].betondog = Convert.ToInt16(udDogNumber.Value);
                GuyArray[2].guy_bet_amount = Convert.ToInt16(udBetAmount.Value);
                rbPlayer3.Checked = false;                
                btnPlaceBet.Enabled = false;
            }
            for (int guy = 0; guy < GuyArray.Length; guy++)
            {
                GuyArray[guy].updateMessages();
            }

            
        }

        private void rbPlayer1_CheckedChanged(object sender, EventArgs e)     //sets selected player to a different value depending on which button is checked
        {
            Bet b = new Bet();
            b.FindMaxBet(Convert.ToInt16(GuyArray[0].balance));
            selectedPlayer = 0;
            lblMaxBet.Text = "Max bet is: " + b.maxBet;
            btnPlaceBet.Enabled = true;
            udBetAmount.Maximum = b.maxBet;
            udBetAmount.Value = b.maxBet;
            udBetAmount.Refresh();
        }

        private void rbPlayer2_CheckedChanged(object sender, EventArgs e)
        {
            Bet b = new Bet();
            b.FindMaxBet(Convert.ToInt16(GuyArray[1].balance));
            selectedPlayer = 1;
            lblMaxBet.Text = "Max bet is: " + b.maxBet;
            btnPlaceBet.Enabled = true;
            udBetAmount.Maximum = b.maxBet;
            udBetAmount.Value = b.maxBet;
            udBetAmount.Refresh();
        }

        private void rbPlayer3_CheckedChanged(object sender, EventArgs e)
        {
            Bet b = new Bet();
            b.FindMaxBet(Convert.ToInt16(GuyArray[2].balance));
            selectedPlayer = 2;
            lblMaxBet.Text = "Max bet is: " + b.maxBet;
            btnPlaceBet.Enabled = true;
            udBetAmount.Maximum = b.maxBet;
            udBetAmount.Value = b.maxBet;
            udBetAmount.Refresh();
        }
       
        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Restart game", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Restart();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Close game", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}



//unused code that might be needed
// while (txtPlayer1Info.Text == "Player has not made a bet" || txtPlayer2Info.Text == "Player has not made a bet" || txtPlayer3Info.Text == "Player has not made a bet")
           // {
           //     btnRace.Enabled = false;
           // }