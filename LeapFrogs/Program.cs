using System;

namespace LeapFrogs
{
    public class Program
    {
        public static void Main()
        {
            var numberOfFrogsOnEachSide = GetNumberOfFrogsOnEachSide();

            // create a Tree<GameStates> with all moves from the given numberOfFrogsOnEachSide

            // search for the goal state using DFS
            // write to the console the states
        }

        private static void DFS(Tree<GameState> tree)
        {

        }

        private static int GetNumberOfFrogsOnEachSide()
        {
            Console.Write("Enter the number of frogs (greated than 0) on each side: ");
            var input = Console.ReadLine();

            if (!int.TryParse(input, out int numberOfFrogsOnEachSide))
                return GetNumberOfFrogsOnEachSide();

            if (int.Parse(input) < 1)
                return GetNumberOfFrogsOnEachSide();

            return numberOfFrogsOnEachSide;
        }
    }
}
