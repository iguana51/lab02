using System;

namespace lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите начальную координату: ");
            string start = Console.ReadLine();
            if (CheckCorrect(start))
                System.Environment.Exit(0);
            Console.Write("введите конечную координату: ");
            string end = Console.ReadLine();
            if (CheckCorrect(end))
                System.Environment.Exit(0);
            if (CheckMoveHorse(start, end))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
        static bool CheckCorrect(string coord)
        {
            if (coord.Length < 2 || coord.Length > 2)
                return true;
            if (coord[0] < 'A' || coord[0] > 'H')
                return true;
            if (coord[1] < '1' || coord[1] > '8')
                return true;
            return false;
        }
        static bool CheckMoveHorse(string startPos, string endPos)
        {
            int dx = Math.Abs(startPos[0] - endPos[0]);
            int dy = Math.Abs(startPos[1] - endPos[1]);
            if (dx == 1 && dy == 2 || dx == 2 && dy == 1)
            {
                return true;
            }
            return false;
        }
    }
}
