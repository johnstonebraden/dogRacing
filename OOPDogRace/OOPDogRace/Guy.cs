using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPDogRace
{
    class Guy
    {

        private string PlayerName;          //declaring variables (private)
       
        private double Balance { get; set; }

        public string PlayerMessage;

        private int PlayerMaxBet;

        private int BetOnDog;

        private RadioButton PlayerRadioButton;

        private TextBox PlayerText;

        private int GuyBetAmount;

        public int player_max_bet
        {
            get { return PlayerMaxBet; } set { PlayerMaxBet = value; }
        }

        public string playername         //setting public vaiables that are linked with the private ones
        {
            get { return PlayerName; } set { PlayerName = value; }           
        }

        public int guy_bet_amount
        {
            get { return GuyBetAmount; } set { GuyBetAmount = value; }
        }

        public int betondog
        {
            get { return BetOnDog; } set { BetOnDog = value; }
        }

        public double balance
        {
            get { return Balance; } set { Balance = value; }           
        }

        public RadioButton player_radioButton
        {
            get { return PlayerRadioButton; } set { PlayerRadioButton = value; }           
        }

        public TextBox player_text
        {
            get { return PlayerText; } set { PlayerText = value; }
        } 

        public void updateMessages()      //updates radio button messages
        {
            player_radioButton.Text = PlayerName + ", Balance: $" + Balance.ToString();           
        }

        public string showMessage()  //if a player has not made a bet this message shows
        {
            PlayerMessage = "Player has not made a bet";

            return PlayerMessage;
        }
    }
}
