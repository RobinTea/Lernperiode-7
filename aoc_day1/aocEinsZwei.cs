namespace aoc24_1
{
    internal class aocEinsZwei
    {
        public static int pEinsZwei(string filePath)
        {

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

            //Anumberlist.Sort();
            //Bnumberlist.Sort();

            var totalSame = 0; foreach (var number in Anumberlist)
            { 
                // Count occurrences of the current number in Bnumberlist
                int countInB = Bnumberlist.Count(b => b == number); 
                // Add the product to the totalSame
                totalSame += number * countInB; 
            }

                //Console.WriteLine(totalSame);
                return totalSame;

        }
    }
}
