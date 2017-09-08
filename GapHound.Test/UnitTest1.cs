using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace GapHound.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLoadMaze()
        {
            TextReader reader = new StreamReader("Hound Maze(tsv).txt");
            string tsv = reader.ReadToEnd();
            reader.Close();
            GapHound.Business.MazeHound mh = new GapHound.Business.MazeHound();
            Assert.IsNotNull(mh.LoadMaze(tsv, 5, 5));

        }
        [TestMethod]
        public void TestSolveMaze()
        {
            TextReader reader = new StreamReader("Hound Maze(tsv).txt");
            string tsv = reader.ReadToEnd();
            reader.Close();
            GapHound.Business.MazeHound mh = new GapHound.Business.MazeHound();
            Assert.IsTrue(mh.SolveMaze(tsv, 54, 77, 12, 20, 5, 5));

        }
    }
}
