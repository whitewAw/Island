namespace ConsoleApp1
{
    public class Question1
    {
        public static int[] Solution(int[] A, string[] B, string[] C)
        {
            if (A.Length != B.Length || B.Length != C.Length)
            {
                throw new ArgumentException("Input arrays must have the same length.");
            }

            Dictionary<int, Dictionary<string, List<string>>> userGroups = new Dictionary<int, Dictionary<string, List<string>>>();

            for (int i = 0; i < A.Length; i++)
            {
                int userId = A[i];
                string fileName = B[i];
                string fileType = C[i];

                if (!userGroups.ContainsKey(userId))
                {
                    userGroups[userId] = new Dictionary<string, List<string>>();
                }

                if (!userGroups[userId].ContainsKey(fileType))
                {
                    userGroups[userId][fileType] = new List<string>();
                }

                userGroups[userId][fileType].Add(fileName);
            }

            int[] result = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                int userId = A[i];

                if (userGroups.ContainsKey(userId))
                {
                    result[i] = userGroups[userId].Count;
                }
            }

            return result;
        }
    }
}
