/*

namespace aoc24_1
{
    internal class aocEinsEins
    {
        static void Main(string[] args)
        {
            string filePath = "C:/Users/RinSk/Desktop/sprite/workspace/BBB/aoc/input.txt";

            List<int> Anumberlist = new List<int>();
            List<int> Bnumberlist = new List<int>();

            string[] lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (int.TryParse(parts[0], out var number)) // first part (left) 
                {
                    Anumberlist.Add(number);
                }
                if (int.TryParse(parts[1], out number)) // second part (right) 
                {
                    Bnumberlist.Add(number);
                }
            }

            Anumberlist.Sort();
            Bnumberlist.Sort();

            var totalDifference = 0;
            var totalSame = 0;

            int minCount = Math.Min(Anumberlist.Count, Bnumberlist.Count); 
            
            for (int i = 0; i < minCount; i++) 
            { 
                totalDifference += Math.Abs(Anumberlist[i] - Bnumberlist[i]); 
                if (Anumberlist[i] == Bnumberlist[i]) 
                { 
                    totalSame++; 
                } 
            }

            /*
            for (int i = 0; i < Anumberlist.Count; i++)
            {
                totalDifference += Math.Abs(Anumberlist[i] - Bnumberlist[i]);
                
                if (Anumberlist[i] == Bnumberlist[i]) 
                { 
                    totalSame++; 
                }
            }
            * /

            //Console.WriteLine(totalDifference);
            Console.WriteLine(totalSame);

        }
    }
}


*/
