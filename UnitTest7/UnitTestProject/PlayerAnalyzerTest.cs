using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest7;

namespace UnitTestProject
{
    public class PlayerAnalyzerTests
    {
        [Fact]
        public void Should_Calculate_Normal_Player_Score()
        {
            var players = new List<Player>
        {
            new Player { Name = "John", Age = 25, Experience = 5, Skills = new List<int> { 2, 2, 2 } }
        };
            var analyzer = new PlayerAnalyzer();

            var score = analyzer.CalculateScore(players);

            Assert.Equal(150, score);
        }

        [Fact]
        public void Should_Calculate_Junior_Player_Score()
        {
            var players = new List<Player>
        {
            new Player { Name = "John", Age = 15, Experience = 3, Skills = new List<int> { 3, 3, 3 } }
        };
            var analyzer = new PlayerAnalyzer();

            var score = analyzer.CalculateScore(players);

            Assert.Equal(67.5, score);
        }

        [Fact]
        public void Should_Calculate_Senior_Player_Score()
        {
            var players = new List<Player>
        {
            new Player { Name = "John", Age = 35, Experience = 15, Skills = new List<int> { 4, 4, 4 } }
        };
            var analyzer = new PlayerAnalyzer();

            var score = analyzer.CalculateScore(players);

            Assert.Equal(1008, score);
        }

        [Fact]
        public void Should_Calculate_Multiple_Players_Score()
        {
            var players = new List<Player>
        {
            new Player { Name = "John", Age = 25, Experience = 5, Skills = new List<int> { 2, 2, 2 } },
            new Player { Name = "Steve", Age = 15, Experience = 3, Skills = new List<int> { 3, 3, 3 } },
            new Player { Name = "Mary", Age = 35, Experience = 15, Skills = new List<int> { 4, 4, 4 } }
        };
            var analyzer = new PlayerAnalyzer();

            var score = analyzer.CalculateScore(players);

            Assert.Equal(150 + 67.5 + 1008, score);
        }

        [Fact]
        public void Should_Throw_ArgumentNullException_When_Skills_Are_Null()
        {
            var players = new List<Player>
        {
            new Player { Name = "John", Age = 25, Experience = 5, Skills = null }
        };
            var analyzer = new PlayerAnalyzer();

            Assert.Throws<ArgumentNullException>(() => analyzer.CalculateScore(players));
        }

        [Fact]
        public void Should_Return_Zero_When_Given_Empty_Array()
        {
            var players = new List<Player>();
            var analyzer = new PlayerAnalyzer();

            var score = analyzer.CalculateScore(players);

            Assert.Equal(0, score);
        }
    }

}
