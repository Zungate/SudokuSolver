using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SudokuSolver;

namespace SudokuTest
{
    [TestClass]
    public class UnitTest1
    {
        int[,] board = {
              { 5, 3, 0, 0, 7, 0, 0, 0, 0 },
              { 6, 0, 0, 1, 9, 5, 0, 0, 0 },
              { 0, 9, 8, 0, 0, 0, 0, 6, 0 },
              { 8, 0, 0, 0, 6, 0, 0, 6, 0 },
              { 4, 0, 0, 8, 0, 3, 0, 0, 1 },
              { 7, 0, 0, 0, 2, 0, 0, 0, 6 },
              { 0, 6, 0, 0, 0, 0, 2, 8, 0 },
              { 0, 0, 0, 4, 1, 9, 0, 0, 5 },
              { 0, 0, 0, 0, 8, 0, 0, 7, 9 }};

       

        [TestMethod]
        public void TestIsValidTrue()
        {
            Assert.IsTrue(Program.IsValid(4, 4, 5, board));
        }

        [TestMethod]
        public void TestIsValidFalse()
        {
            Assert.IsFalse(Program.IsValid(4, 4, 4, board));
        }

        [TestMethod]
        public void TestSolve()
        {
            Assert.IsTrue(Program.Solve(board));
        }
    }
}
