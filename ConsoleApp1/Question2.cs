using Newtonsoft.Json;

namespace ConsoleApp1
{
    public class Question2
    {
        public int Solution(string s)
        {
            List<int[]> buildings = JsonConvert.DeserializeObject<List<int[]>>(s)!;

            int totalCoveredArea = 0;
            int currentX = 0;
            int currentHeight = 0;

            foreach (var building in buildings)
            {
                int x1 = building[0];
                int x2 = building[1];
                int h = building[2];

                totalCoveredArea += (x2 - Math.Max(currentX, x1)) * currentHeight;

                currentX = x2;
                currentHeight = h;
            }

            return totalCoveredArea;
        }
    }
}
