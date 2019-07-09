using Xunit;
using Mark8InClassExamples;

namespace MyTestProject
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(110, "A")]
        [InlineData(100, "A")]
        [InlineData(90, "A")]
        [InlineData(89.9, "B")]
        [InlineData(80, "B")]
        [InlineData(79.9, "C")]
        [InlineData(70, "C")]
        [InlineData(69.9, "D")]
        [InlineData(60, "D")]
        [InlineData(59.9, "F")]
        [InlineData(0, "F")]
        [InlineData(-10, "F")]
        [InlineData(-100, "F")]
        public void ShouldCalculateLetterGrade(double grade, string expected)
        {
            // Arrange
            Teacher myTeacher = new Teacher();

            // Act
            string actual = myTeacher.CalculateLetterGrade(grade);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
