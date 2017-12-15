using System;
using System.Collections.Generic;
using System.Text;

namespace LeapFrogs
{
    public class GameState
    {
        private string _value;
        private int _numberOfFrogsOnEachSide;
        private IList<GameState> _nextGameStates;

        public GameState(string value, int numberOfFrogsOnEachSide)
        {
            _value = value;
            _numberOfFrogsOnEachSide = numberOfFrogsOnEachSide;
            _nextGameStates = new List<GameState>();
        }

        public IList<GameState> NextGameStates => _nextGameStates;

        /// <summary>
        /// Generate game states recursively until the goal state is reached.
        /// </summary>
        public void GenerateNextStates()
        {
            if (_value == GetGoalState()._value)
                return;


        }   

        private GameState GetGoalState()
        {
            StringBuilder sb = new StringBuilder();
            var numberOfPositions = _numberOfFrogsOnEachSide * 2 + 1;

            for (int i = 0; i < numberOfPositions; i++)
            {
                if (i < _numberOfFrogsOnEachSide)
                    sb.Append('<');

                else if (i == _numberOfFrogsOnEachSide)
                    sb.Append('_');

                else if (i > _numberOfFrogsOnEachSide)
                    sb.Append('>');
            }

            return new GameState(sb.ToString(), _numberOfFrogsOnEachSide);
        }

        public override string ToString() => _value;
    }
}