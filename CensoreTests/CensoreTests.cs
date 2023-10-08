using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibraryCensore;

namespace CensoreTests
{
    [TestClass]
    public class CensoreTests
    {

        [TestMethod]
        public void Censore_CorrectTest1()
        {
            //arrange
            string textString = "Хаахаха текст со словом редиска";
            string expected = "Хаахаха текст со словом ***";
            //act
            string actual = CensoreClass.Censore(textString);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// пустая строка
        /// </summary>
        [TestMethod]
        public void Censore_StringIsEmpty()
        {
            //arrange
            string textString = "";
            //act
            Action result = () => new CensoreClass().Censore(textString);
            //Assert
            Assert.ThrowsException<Exception>(result);
        }

        /// <summary>
        /// неправельно введено слово редиска
        /// </summary>
        [TestMethod]
        public void Censore_UnCorrectTest()
        {
            //arrange
            string textString = "текст со словом ррредиска";
            string expected = "текст со словом ррредиска";
            //act
            string actual = CensoreClass.Censore(textString);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// два слова редиска
        /// </summary>
        [TestMethod]
        public void Censore_CorrectTest2()
        {
            //arrange
            string textString = "текст со словом редиска редиска";
            string expected = "текст со словом *** ***";
            //act
            string actual = CensoreClass.Censore(textString);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// просто слово редиска без текста
        /// </summary>
        [TestMethod]
        public void Censore_CorrectTest3()
        {
            //arrange
            string textString = "редиска";
            string expected = "***";
            //act
            string actual = CensoreClass.Censore(textString);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// слово редиска заглыавными буквами
        /// </summary>
        [TestMethod]
        public void Censore_CorrectTest4()
        {
            //arrange
            string textString = "текст со словом РЕДИСКА";
            string expected = "текст со словом ***";
            //act
            string actual = CensoreClass.Censore(textString);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// слово редска с некоторыми заглавными буквами
        /// </summary>
        [TestMethod]
        public void Censore_CorrectTest5()
        {
            //arrange
            string textString = "текст со словом рЕдиСка";
            string expected = "текст со словом ***";
            //act
            string actual = CensoreClass.Censore(textString);
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
