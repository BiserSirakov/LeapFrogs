using System.Text;

namespace LeapFrogs
{
    public class GameState
    {
        public string Current { get; set; }

        public string InitialState { get; set; }

        public string GoalState { get; set; }

        public GameState(int numberOfFrogsOnEachSide)
        {
            this.Current = GetInitialState(numberOfFrogsOnEachSide);

            this.InitialState = GetInitialState(numberOfFrogsOnEachSide);
            this.GoalState = GetGoalState(numberOfFrogsOnEachSide);
        }

        public bool IsGoalState() => 
            this.Current == this.GoalState;

        private string GetInitialState(int numberOfFrogsOnEachSide)
        {
            StringBuilder sb = new StringBuilder();
            var numberOfPositions = numberOfFrogsOnEachSide * 2 + 1;

            for (int i = 0; i < numberOfPositions; i++)
            {
                if (i < numberOfFrogsOnEachSide)
                    sb.Append('>');

                else if (i == numberOfFrogsOnEachSide)
                    sb.Append('_');

                else if (i > numberOfFrogsOnEachSide)
                    sb.Append('<');
            }

            return sb.ToString();
        }

        private string GetGoalState(int numberOfFrogsOnEachSide)
        {
            StringBuilder sb = new StringBuilder();
            var numberOfPositions = numberOfFrogsOnEachSide * 2 + 1;

            for (int i = 0; i < numberOfPositions; i++)
            {
                if (i < numberOfFrogsOnEachSide)
                    sb.Append('<');

                else if (i == numberOfFrogsOnEachSide)
                    sb.Append('_');

                else if (i > numberOfFrogsOnEachSide)
                    sb.Append('>');
            }

            return sb.ToString();
        }
    }
}
