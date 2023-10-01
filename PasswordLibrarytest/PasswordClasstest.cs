using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PasswordLibrary;
using static System.Net.Mime.MediaTypeNames;

namespace PasswordLibrarytest
{
    [TestClass]
    public class PasswordClasstest
    {


        /// <summary>
        /// проверка на пустоту
        /// </summary>
        [TestMethod]
        public void PasswordClasstest_empty_returnedexepted()
        {
            //arrange
            string Password = "";
            //act
            Action actiona = () => PasswordClass.PasswordStrengthCheker(Password);
            //assets
            Assert.ThrowsException<Exception>(actiona);

        }



        /// <summary>
        /// проверка на пробел
        /// </summary>
        [TestMethod]
        public void PasswordClasstest_space_returnedexepted()
        {
            //arrange
            string Password = " ";
            //act
            Action actiona = () => PasswordClass.PasswordStrengthCheker(Password);
            //assets
            Assert.ThrowsException<Exception>(actiona);

        }



        /// <summary>
        /// проверка на пробел и пароль
        /// </summary>
        [TestMethod]
        public void PasswordClasstest_spacepasswor_returnedexepted()
        {
            //arrange
            string Password = "dadad adadd";
            //act
            Action actiona = () => PasswordClass.PasswordStrengthCheker(Password);
            //assets
            Assert.ThrowsException<Exception>(actiona);

        }

        /// <summary>
        /// нижний регистр 1(сложность 1)
        /// </summary>
        [TestMethod]
        public void PasswordClasstest_lowerchars_1point()
        {
            //arrange
            string Password = "asdasd";
            int exepted = 1;
            //act
            int actual = PasswordClass.PasswordStrengthCheker(Password);

            Assert.AreEqual(exepted, actual);

        }


        /// <summary>
        /// нижний регистр 1, больше 7 символов 1 (сложность 2)
        /// </summary>
        [TestMethod]
        public void PasswordClasstest_lowereightchars_returnedtwo()
        {
            //arrange
            string Password = "asdasddpo";
            int exepted = 2;
            //act
            int actual = PasswordClass.PasswordStrengthCheker(Password);
            //assets
            Assert.AreEqual(exepted, actual);

        }


        /// <summary>
        /// нижний регистр 1, больше 7 символов 1, цифры 1 (сложность 3)
        /// </summary>
        [TestMethod]
        public void PasswordClasstest_lowereightcharsnumber_returnedtwo()
        {
            //arrange
            string Password = "1asdasddpo1";
            int exepted = 3;
            //act
            int actual = PasswordClass.PasswordStrengthCheker(Password);
            //assets
            Assert.AreEqual(exepted, actual);

        }



        /// <summary>
        /// нижний и верхний регистр 2, больше 7 символов 1, цифры 1,  (сложность 4)
        /// </summary>
        [TestMethod]
        public void PasswordClasstest_loweruppereightcharsnumber_returnedtwo()
        {
            //arrange
            string Password = "1Asdasddpo1";
            int exepted = 4;
            //act
            int actual = PasswordClass.PasswordStrengthCheker(Password);
            //assets
            Assert.AreEqual(exepted, actual);

        }

        /// <summary>
        /// нижний и верхний регистр 2, больше 7 символов 1, цифры 1, спец символ 1  (сложность 5)
        /// </summary>
        [TestMethod]
        public void PasswordClasstest_all_returnedtwo()
        {
            //arrange
            string Password = "1Asdasddpo1?";
            int exepted = 5;
            //act
            int actual = PasswordClass.PasswordStrengthCheker(Password);
            //assets
            Assert.AreEqual(exepted, actual);

        }

        /// <summary>
        /// проверка на кирилицу
        /// </summary>
        [TestMethod]
        public void PasswordClasstest_exepted_returnedexepted()
        {
            //arrange
            string Password = "аффаыа";
            //act
            Action actiona = () => PasswordClass.PasswordStrengthCheker(Password);
            //assets
            Assert.ThrowsException<Exception>(actiona);

        }


    }
}
