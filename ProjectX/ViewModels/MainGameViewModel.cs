using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using ProjectX.Models;

namespace ProjectX.ViewModels
{
    public class MainGameViewModel : Screen
    {
        Dice Dice1 = new Dice();
        Dice Dice2 = new Dice();
        Dice Dice3 = new Dice();
        Dice Dice4 = new Dice();
        Dice Dice5 = new Dice();

        Random Randomator = new Random();







    }
    public class GameSetEngine : Screen
    {
        private int _game_Id;
        private DateTime _started_At;
        private DateTime _ended_At;
        private int _GameType_Id;
        private enum GameTypeEnum { Classic, Restricted }
        private enum GamteTypeEnum { getSetUp, InGame, GameOver }
        public List<Player> Players { get; set; }
        public DicePanel DicePanel { get; set; }
        public void SetGameType() { }
        public void SetGameStatus() { }


    }
    public class Player : Screen
    {

        private string _name;
        private int _playerId;
        private string _nickname;
        private List<Scoreboard> scoreboards = new List<Scoreboard>();


    }
    internal class Scoreboard : Screen
    {

        private int _ones;
        private int _twos;
        private int _threes;
        private int _fours;
        private int _fives;
        private int _sixes;
        private int _sum;
        private int _bonus;
        private int _pair;
        private int _twoPairs;
        private int _threeOfAKind;
        private int _fourOfAKind;
        private int _smallStraight;
        private int _largeStraight;
        private int _fullHouse;
        private int _chance;
        private int _yatzy;
        private int _total;
    }
    public class ScoreBoardProp : Screen
    {
        private bool _isonesprop;
        private bool _istwosprop;
        private bool _isthreesprop;
        private bool _isfoursprop;
        private bool _isfivesprop;
        private bool _issixesprop;
        private bool _issumprop;
        private bool _isbonusprop;
        private bool _ispairprop;
        private bool _istwoPairsprop;
        private bool _isthreeOfAKindprop;
        private bool _isfourOfAKindprop;
        private bool _issmallStraightprop;
        private bool _islargeStraightprop;
        private bool _isfullHouseprop;
        private bool _ischanceprop;
        private bool _isyatzyprop;
        private bool _istotalprop;

        private int _onesprop;
        private int _twosprop;
        private int _threesprop;
        private int _foursprop;
        private int _fivesprop;
        private int _sixesprop;
        private int _sumprop;
        private int _bonusprop;
        private int _pairprop;
        private int _twoPairsprop;
        private int _threeOfAKindprop;
        private int _fourOfAKindprop;
        private int _smallStraightprop;
        private int _largeStraightprop;
        private int _fullHouseprop;
        private int _chanceprop;
        private int _yatzyprop;
        private int _totalprop;
    }
    public class DicePanel : Screen
    {
        Random Randomator = new Random();
        int[] dices = new int[5];
        Dice Dice1;
        Dice Dice2;
        Dice Dice3;
        Dice Dice4;
        Dice Dice5;

       

        public void RollDice()
        {
            if(!Dice1.Keep)
            {
                Dice1.DiceValue = Randomator.Next(1, 7);
            }
            if (!Dice2.Keep)
            {
                Dice2.DiceValue = Randomator.Next(1, 7);
            }
            if (!Dice3.Keep)
            {
                Dice3.DiceValue = Randomator.Next(1, 7);
            }
            if (!Dice4.Keep)
            {
                Dice4.DiceValue = Randomator.Next(1, 7);
            }
            if (!Dice5.Keep)
            {
                Dice4.DiceValue = Randomator.Next(1, 7);
            }


        }

    }
   

    public class Dice :Screen
    {
        private int _diceValue;

        private bool _keep;
        public bool Keep = false;


        public int DiceValue
        {
            get { return _diceValue; }
            set
            {
                _diceValue = value;
                NotifyOfPropertyChange(() => DiceValue);


            }
        }

    }
}

