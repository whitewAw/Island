namespace ConsoleApp1.Test
{
    public class Question2Tests
    {
        [Fact]
        public void Solution2_ReturnsTotalCoveredArea()
        {
            var solution = new Question2();
            string input = "[[1, 5, 3], [2, 8, 6], [6, 9, 4], [7, 12, 5]]";
            int expectedOutput = 27;

             int actualOutput = solution.Solution(input);

             Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void Solution2_ReturnsEmpty_WhenInputAreEmpty()
        {
            var solution = new Question2();
            string input = "[]";
            int expectedOutput = 0;

            int actualOutput = solution.Solution(input);

            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}
