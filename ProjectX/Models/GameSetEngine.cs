using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX.Models
{
    public class GameSetEngine:Screen
    {
        public int _game_Id { get => _GameType_Id; set => _GameType_Id = value; }
        private DateTime _started_At;
        public DateTime Started_At
        {
            get
            {
                return _started_At;

            }
            set
            {
                _started_At = value;
                NotifyOfPropertyChange(() => Started_At);


            }
        }
        public DateTime _ended_At { get; set; }
        public int _GameType_Id { get; set; }
        public string _gameName { get; set; }
        public enum GameTypeEnum { Classic, Restricted }
        public enum GamteTypeEnum { getSetUp, InGame, GameOver }

        public List<Player> Players;
        public DicePanel DicePanel;
     
       
        public GameSetEngine()
        {
           DicePanel = new DicePanel();
        }
    }
}

