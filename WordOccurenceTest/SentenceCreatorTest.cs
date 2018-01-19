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
    public class SentenceCreatorTest
    {
        [TestMethod]
        public void Test_When_MultipleLinesAreGiven_CreatesASingleSentenceFromIt()
        {
            var expected = "Go do that thing you do so well";

            string[] lines = new string[]
            {
                "Go do",
                "that thing you",
                "do so",
                "well"
            };

            var creator = new SentenceCreator();

            Assert.AreEqual(expected, creator.Create(lines));

        }

        [TestMethod]
        public void Test_When_EmptyLinesArePassed_ReturnsEmptyString()
        {
            var expected = "";

            string[] lines = new string[] {""};

            var creator = new SentenceCreator();

            Assert.AreEqual(expected, creator.Create(lines));

        }

        [TestMethod]
        public void Test_When_ZeroLengthArrayIsPassed_ReturnsEmptyString()
        {
            var expected = "";

            string[] lines = new string[0] ;

            var creator = new SentenceCreator();

            Assert.AreEqual(expected, creator.Create(lines));

        }
    }
}
