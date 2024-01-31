namespace ConsoleApp1.Test
{
    public class Question1Tests
    {
        [Fact]
        public void Solution1_ReturnsCorrectFileGroupsCount()
        {
            int[] A = { 1, 2, 1, 3, 2 };
            string[] B = { "document.docx", "image.jpg", "presentation.ppt", "music.mp3", "photo.png" };
            string[] C = { "Document", "Image", "Document", "Audio", "Image" };

            int[] result = Question1.Solution(A, B, C);

            Assert.Equal(new[] { 1, 1, 1, 1, 1 }, result);
        }

        [Fact]
        public void Solution1_ThrowsArgumentException_WhenInputArraysHaveDifferentLengths()
        {
            int[] A = { 1, 2, 1, 3, 2 };
            string[] B = { "document.docx", "image.jpg", "presentation.ppt", "music.mp3" }; 
            string[] C = { "Document", "Image", "Document", "Audio", "Image" };

            Assert.Throws<ArgumentException>(() => Question1.Solution(A, B, C));
        }

        [Fact]
        public void Solution1_ReturnsEmptyArray_WhenInputArraysAreEmpty()
        {
            int[] A = Array.Empty<int>();
            string[] B = Array.Empty<string>();
            string[] C = Array.Empty<string>();

            int[] result = Question1.Solution(A, B, C);

            Assert.Empty(result);
        }
    }
}