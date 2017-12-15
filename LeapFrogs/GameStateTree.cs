using System;
using System.Collections.Generic;
using System.Text;

namespace LeapFrogs
{
    public class GameStateTree
    {
        private GameState _root;

        public GameStateTree(int numberOfFrogsOnEachSide)
        {
            _root = GetInitialGameState(numberOfFrogsOnEachSide);
            _root.GenerateNextStates();
        }

        /// <summary>
        /// Searches for the goal state using Depth-first search and prints the path to the console.
        /// </summary>
        public void PrintDFS()
        {
            var visited = new List<GameState>();
            var stack = new Stack<GameState>();

            stack.Push(_root);
            while (stack.Count > 0)
            {
                var current = stack.Pop();
                visited.Add(current);

                Console.WriteLine(current);

                foreach (var nextState in current.NextGameStates)
                {
                    if (visited.Contains(nextState))
                        continue;

                    stack.Push(nextState);
                }
            }
        }

        private GameState GetInitialGameState(int numberOfFrogsOnEachSide)
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

            return new GameState(sb.ToString(), numberOfFrogsOnEachSide);
        }
    }
}
