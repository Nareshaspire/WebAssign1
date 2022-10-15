using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryCalculator;

namespace UnitTestCalculator
{
    [TestClass]
    public class UnitTestsForClassLibrary
    {

        [TestMethod]
        public void CheckClassLibrarySolveAdditionChallengeTestMethod1()
        {//this addition test method test the addition result with 0 as first number
            double additionresult;
            additionresult = CalculatorApi.AdditionTask(0,10);
            Assert.AreEqual(10, additionresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveAdditionChallengeTestMethod2()
        {//this addition test for addition result with 0 as second number
            double additionresult;
            additionresult = CalculatorApi.AdditionTask(10, 0);
            Assert.AreEqual(10, additionresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveAdditionChallengeTestMethod3()
        {//this addition test for addition result with both positive numbers
            double additionresult;
            additionresult = CalculatorApi.AdditionTask(10, 10);
            Assert.AreEqual(40, additionresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveAdditionChallengeTestMethod4()
        {//this addition test for addition result with both negative numbers
            double additionresult;
            additionresult = CalculatorApi.AdditionTask(-10, -10);
            Assert.AreEqual(-40, additionresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveAdditionChallengeTestMethod5()
        {//this addition test for addition result with first negative and second positive number
            double additionresult;
            additionresult = CalculatorApi.AdditionTask(-10, 10);
            Assert.AreEqual(0, additionresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveAdditionChallengeTestMethod6()
        {//this addition test for addition result with first positive and second negative  number
            double additionresult;
            additionresult = CalculatorApi.AdditionTask(10, -10);
            Assert.AreEqual(0, additionresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveAdditionChallengeTestMethod7()
        {//this addition test for addition result with first 0 and second negative number
            double additionresult;
            additionresult = CalculatorApi.AdditionTask(0, -10);
            Assert.AreEqual(-10, additionresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveAdditionChallengeTestMethod8()
        {//this addition test for addition result with first negative and second 0 number
            double additionresult;
            additionresult = CalculatorApi.AdditionTask(-10, 0);
            Assert.AreEqual(-10, additionresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveAdditionChallengeTestMethod9()
        {//this addition test for addition result with both 0 number
            double additionresult;
            additionresult = CalculatorApi.AdditionTask(0, 0);
            Assert.AreEqual(0, additionresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveAdditionChallengeTestMethod10()
        {//this addition test for addition result with first large and second negative number
            double additionresult;
            additionresult = CalculatorApi.AdditionTask(100000, -1);
            Assert.AreEqual(99999, additionresult);
        }

        [DataTestMethod]
        [DataRow(5, 5, 10)]
        [DataRow(7, 5, 12)]
        [DataRow(1, 9, 10)]
        [DataRow(8, 8, 16)]
        [DataRow(3, 3, 6)]
        [DataRow(6, 30, 36)]
        [DataRow(17, 17, 34)]
        [DataRow(11, 11, 22)]
        [DataRow(65, 12, 77)]
        [DataRow(45, 5, 50)]
        [DataRow(99, 1, 100)]
        public void CheckClassLibrarySolveAdditionChallengeDataTestMethod(double num1, double num2, double desiredresult)
        {
            //data test method for addition of 11 different type of numbers and their results
            double additionresult;
            additionresult = CalculatorApi.AdditionTask(num1, num2);
            Assert.AreEqual(desiredresult, additionresult);
        }

        [TestMethod]
        public void CheckClassLibrarySolveSubtractionChallengeTestMethod1()
        {//this subtraction test for subtraction result with 0 as first number
            double subtractionresult;
            subtractionresult = CalculatorApi.SubtractionTask(0, 30);
            Assert.AreEqual(-30, subtractionresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveSubtractionChallengeTestMethod2()
        {//this subtraction test for subtraction result with 0 as second number
            double subtractionresult;
            subtractionresult = CalculatorApi.SubtractionTask(30, 0);
            Assert.AreEqual(30, subtractionresult);
        }

        [TestMethod]
        public void CheckClassLibrarySolveSubtractionChallengeTestMethod3()
        {//this subtraction test for subtraction result with both positive  numbers
            double subtractionresult;
            subtractionresult = CalculatorApi.SubtractionTask(30, 30);
            Assert.AreEqual(0, subtractionresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveSubtractionChallengeTestMethod4()
        {//this subtraction test for subtraction result with both negative numbers
            double subtractionresult;
            subtractionresult = CalculatorApi.SubtractionTask(-30, 30);
            Assert.AreEqual(-60, subtractionresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveSubtractionChallengeTestMethod5()
        {//this subtraction test for subtraction result with first positive and second negative number
            double subtractionresult;
            subtractionresult = CalculatorApi.SubtractionTask(30, -30);
            Assert.AreEqual(60, subtractionresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveSubtractionChallengeTestMethod6()
        {//this subtraction test for subtraction result with both negative numbers
            double subtractionresult;
            subtractionresult = CalculatorApi.SubtractionTask(-30, -30);
            Assert.AreEqual(0, subtractionresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveSubtractionChallengeTestMethod7()
        {//this subtraction test for subtraction result with first 0 and second negative number
            double subtractionresult;
            subtractionresult = CalculatorApi.SubtractionTask(0, -30);
            Assert.AreEqual(30, subtractionresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveSubtractionChallengeTestMethod8()
        {//this subtraction test for subtraction result with first negative and second 0 number
            double subtractionresult;
            subtractionresult = CalculatorApi.SubtractionTask(-30, 0);
            Assert.AreEqual(-30, subtractionresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveSubtractionChallengeTestMethod9()
        {//this subtraction test for subtraction result with both 0 number
            double subtractionresult;
            subtractionresult = CalculatorApi.SubtractionTask(0, 0);
            Assert.AreEqual(0, subtractionresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveSubtractionChallengeTestMethod10()
        {//this subtraction test for subtraction result with first large value and second 0 number
            double subtractionresult;
            subtractionresult = CalculatorApi.SubtractionTask(100000, -1);
            Assert.AreEqual(100001, subtractionresult);
        }

        [DataTestMethod]
        [DataRow(5, 5, 0)]
        [DataRow(7, 5, 2)]
        [DataRow(1, 9, -8)]
        [DataRow(8, 8, 0)]
        [DataRow(3, 3, 0)]
        [DataRow(6, 30, -24)]
        [DataRow(17, 17, 0)]
        [DataRow(11, 11, 0)]
        [DataRow(65, 12, 53)]
        [DataRow(45, 5, 40)]
        [DataRow(99, 1, 98)]
        public void CheckClassLibrarySolveSubtractionChallengeDataTestMethod(double num1, double num2, double desiredresult)
        { //data test method for subtraction of 11 different type of numbers and their results
            double subtractionresult;
            subtractionresult = CalculatorApi.SubtractionTask(num1, num2);
            Assert.AreEqual(desiredresult, subtractionresult);
        }

        [TestMethod]
        public void CheckClassLibrarySolveMultiplicationChallengeTestMethod1()
        {//this multiplication test for product result with 0 as first number
            double multiplicationresult;
            multiplicationresult = CalculatorApi.MultiplicationTask(0, 40);
            Assert.AreEqual(0, multiplicationresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveMultiplicationChallengeTestMethod2()
        {//this multiplication test for product result with 0 as second number
            double multiplicationresult;
            multiplicationresult = CalculatorApi.MultiplicationTask(40, 0);
            Assert.AreEqual(0, multiplicationresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveMultiplicationChallengeTestMethod3()
        {//this multiplication test for product result with both positive numbers
            double multiplicationresult;
            multiplicationresult = CalculatorApi.MultiplicationTask(40, 40);
            Assert.AreEqual(1600, multiplicationresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveMultiplicationChallengeTestMethod4()
        {//this multiplication test for product result with one negative and other positive number
            double multiplicationresult;
            multiplicationresult = CalculatorApi.MultiplicationTask(-40, 40);
            Assert.AreEqual(-1600, multiplicationresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveMultiplicationChallengeTestMethod5()
        {//this multiplication test for product result with one positive and other negative number
            double multiplicationresult;
            multiplicationresult = CalculatorApi.MultiplicationTask(40, -40);
            Assert.AreEqual(-1600, multiplicationresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveMultiplicationChallengeTestMethod6()
        {//this multiplication test for product result with both negative
            double multiplicationresult;
            multiplicationresult = CalculatorApi.MultiplicationTask(-40, -40);
            Assert.AreEqual(1600, multiplicationresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveMultiplicationChallengeTestMethod7()
        {//this multiplication test for product result with one 0 and other negative number
            double multiplicationresult;
            multiplicationresult = CalculatorApi.MultiplicationTask(0, -40);
            Assert.AreEqual(0, multiplicationresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveMultiplicationChallengeTestMethod8()
        {//this multiplication test for product result with one negative and other 0 
            double multiplicationresult;
            multiplicationresult = CalculatorApi.MultiplicationTask(-40, 0);
            Assert.AreEqual(0, multiplicationresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveMultiplicationChallengeTestMethod9()
        {//this multiplication test for product result with both 0 numbers
            double multiplicationresult;
            multiplicationresult = CalculatorApi.MultiplicationTask(0, 0);
            Assert.AreEqual(0, multiplicationresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveMultiplicationChallengeTestMethod10()
        {//this multiplication test for product result with one large and other negative number
            double multiplicationresult;
            multiplicationresult = CalculatorApi.MultiplicationTask(100000, -1);
            Assert.AreEqual(-100000, multiplicationresult);
        }

        [DataTestMethod]
        [DataRow(5, 5, 25)]
        [DataRow(7, 5, 35)]
        [DataRow(1, 9, 9)]
        [DataRow(8, 8, 64)]
        [DataRow(3, 3, 9)]
        [DataRow(6, 30, 180)]
        [DataRow(17, 17, 289)]
        [DataRow(11, 11, 121)]
        [DataRow(65, 12, 780)]
        [DataRow(45, 5, 225)]
        [DataRow(99, 1, 99)]
        public void CheckClassLibrarySolveMultiplicationChallengeDataTestMethod(double num1, double num2, double desiredresult)
        { //data test method for multiplication of 11 different type of numbers and their results
            double multiplicationresult;
            multiplicationresult = CalculatorApi.MultiplicationTask(num1, num2);
            Assert.AreEqual(desiredresult, multiplicationresult);
        }

        [TestMethod]
        public void CheckClassLibrarySolveDivisionChallengeTestMethod1()
        {//this division test for quotient  with 0 as first number
            double divisionresult;
            divisionresult = CalculatorApi.DivisionTask(0, 50);
            Assert.AreEqual(0, divisionresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveDivisionChallengeTestMethod2()
        {//this division test for quotient  with 0 as second number
            double divisionresult;
            divisionresult = CalculatorApi.DivisionTask(50, 0);
            Assert.AreEqual(-1, divisionresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveDivisionChallengeTestMethod3()
        {//this division test for quotient  with both positive numbers
            double divisionresult;
            divisionresult = CalculatorApi.DivisionTask(50, 50);
            Assert.AreEqual(1, divisionresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveDivisionChallengeTestMethod4()
        {//this division test for quotient  with first negative and second positive number
            double divisionresult;
            divisionresult = CalculatorApi.DivisionTask(-50, 50);
            Assert.AreEqual(-1, divisionresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveDivisionChallengeTestMethod5()
        {//this division test for quotient  with first positive and second negative number
            double divisionresult;
            divisionresult = CalculatorApi.DivisionTask(50, -50);
            Assert.AreEqual(-1, divisionresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveDivisionChallengeTestMethod6()
        {//this division test for quotient  with both negative numbers
            double divisionresult;
            divisionresult = CalculatorApi.DivisionTask(-50, -50);
            Assert.AreEqual(1, divisionresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveDivisionChallengeTestMethod7()
        {//this division test for quotient  with one 0 and other negative numbers
            double divisionresult;
            divisionresult = CalculatorApi.DivisionTask(0, -50);
            Assert.AreEqual(0, divisionresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveDivisionChallengeTestMethod8()
        {//this division test for quotient  with one negative and other 0 number
            double divisionresult;
            divisionresult = CalculatorApi.DivisionTask(-50, 0);
            Assert.AreEqual(-1, divisionresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveDivisionChallengeTestMethod9()
        {//this division test method test the quotient  with both 0 numbers
            double divisionresult;
            divisionresult = CalculatorApi.DivisionTask(0, 0);
            Assert.AreEqual(-1, divisionresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveDivisionChallengeTestMethod10()
        {//this division test method test the quotient  with one large value and other negative number
            double divisionresult;
            divisionresult = CalculatorApi.DivisionTask(100000, -1);
            Assert.AreEqual(-100000, divisionresult);
        }

        [DataTestMethod]
        [DataRow(5, 5, 1)]
        [DataRow(7, 5, 1.4)]
        [DataRow(40, 4, 10)]
        [DataRow(121, 11, 11)]
        [DataRow(336, 12, 28)]
        [DataRow(6, 30, 0.2)]
        [DataRow(225, 15, 15)]
        [DataRow(210, 4, 55)]
        [DataRow(60, 12, 5)]
        [DataRow(45, 5, 9)]
        [DataRow(99, 1, 99)]
        public void CheckClassLibrarySolveDivisionChallengeDataTestMethod(double num1, double num2 
            , double desiredresult)
        { //data test method for division of 11 different type of numbers and their results
            double divisionresult;
            divisionresult = CalculatorApi.DivisionTask(num1, num2);
            Assert.AreEqual(desiredresult, divisionresult);
        }
    }
}
