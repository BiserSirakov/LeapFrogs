using System;
using System.Collections.Generic;
using System.Text;

namespace LeapFrogs
{
    public class Main
    {
        public Stack<GameState> States { get; set; }

        public Main()
        {
            this.States = new Stack<GameState>();
        }
    }
}
