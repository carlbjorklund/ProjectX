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
        public GameSetEngine GameSetEngine;
     
        GameSetEngine gameSet = new GameSetEngine();
        Random r = new Random();
       
      

        public void Enable()
        {
            int value;
            value = r.Next(1, 7);
         
            gameSet.DicePanel.Dice1.DiceValue = value;
            gameSet._gameName = "Fuck";
            DateTime today = DateTime.Today;
            gameSet.Started_At= today;

        }

    }


}
   


