using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordOccurence;

namespace WordOccurenceTest
{
    [TestClass]
    public class WordOccurenceCounterTest
    {
        [TestMethod]
        public void Test_When_AStringIsGiven_ItCorrectlyCountsOccurenceOfUniqueWords()
        {
            string inputSentence = "Go do that thing that you do so well";

            Dictionary<string, int> expectedResult = new Dictionary<string, int>
            {
                { "GO", 1 },
                { "DO", 2 },
                { "THAT", 2 },
                { "THING", 1 },
                { "YOU", 1 },
                {"SO", 1 },
                {"WELL", 1 }
            };
            
            var wordOccurence = new WordOccurenceCounter();

            CollectionAssert.AreEqual(expectedResult, wordOccurence.Count(inputSentence));
            
        }

        [TestMethod]
        public void Test_When_AStringIsGiven_ItCorrectlyCountsOccurenceOfUniqueWordsCaseInsensitively()
        {
            string inputSentence = "Go DO that thing thAt you do so well";

            Dictionary<string, int> expectedResult = new Dictionary<string, int>
            {
                { "GO", 1 },
                { "DO", 2 },
                { "THAT", 2 },
                { "THING", 1 },
                { "YOU", 1 },
                { "SO", 1 },
                { "WELL", 1 }
            };

            var wordOccurence = new WordOccurenceCounter();

            CollectionAssert.AreEqual(expectedResult, wordOccurence.Count(inputSentence));

        }

        [TestMethod]
        public void Test_When_ANonWordIsInTheSentence_ItIsNotAddedToTheResult()
        {
            string inputSentence = "Go do that thing8 that you do so well";

            var wordOccurence = new WordOccurenceCounter();

            Assert.IsTrue(!wordOccurence.Count(inputSentence).ContainsKey("thing8"));

        }

        [TestMethod]
        public void Test_When_EmptyStringIsGiven_ReturnsEmptyDictionary()
        {
            string inputSentence = "";

            var wordOccurence = new WordOccurenceCounter();

            Assert.IsTrue(wordOccurence.Count(inputSentence).Count==0);

        }

        [TestMethod]
        public void Test_When_NullStringIsGiven_ReturnsEmptyDictionary()
        {
            var wordOccurence = new WordOccurenceCounter();

            Assert.IsTrue(wordOccurence.Count(null).Count == 0);

        }
    }
}
