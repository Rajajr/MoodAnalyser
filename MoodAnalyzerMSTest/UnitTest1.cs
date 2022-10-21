using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserDemo;

namespace MoodAnalyzerMSTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// TC 1:1 Given?I am in Sad Mood? message Should return SAD.
        /// </summary>
        [TestMethod]
        public void GivenSadMoodShouldReturnSAD()
        {
            //Arrange
            string expected = "SAD";
            string message = "I am in sad Mood";
            MoodAnalyser moodanalyser = new MoodAnalyser(message);

            //Act
            string mood = moodanalyser.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);

        }

        
    }

    
}
