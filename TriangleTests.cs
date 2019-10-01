using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2;
using NUnit.Framework;

namespace TriangleTests
{
    [TestFixture]
    public class TriangleTests
    {
        // not Triangle
        [Test]
        public void Analyze_Input1_2_and_3_Returns_Doesnt_form_a_triangle()
        {

            //Arrange
            int side1 = 1;
            int side2 = 2;
            int side3 = 3;            
            string expectedResult = "Doesn't form a triangle";

            //Act
            string actualResult = TriangleSolver.Analyze(side1, side2, side3); ;

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        // not Triangle
        [Test]
        public void Analyze_Input100_40_and_30_Returns_Doesnt_form_a_triangle()
        {

            //Arrange
            int side1 = 100;
            int side2 = 40;
            int side3 = 30;
            string expectedResult = "Doesn't form a triangle";

            //Act
            string actualResult = TriangleSolver.Analyze(side1, side2, side3); ;

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        // not Triangle
        [Test]
        public void Analyze_Input15_20_and_3_Returns_Doesnt_form_a_triangle()
        {

            //Arrange
            int side1 = 15;
            int side2 = 20;
            int side3 = 3;
            string expectedResult = "Doesn't form a triangle";

            //Act
            string actualResult = TriangleSolver.Analyze(side1, side2, side3); ;

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        //Triangle: Scalene
        [Test]
        public void Analyze_Input14_36_and_29_Returns_Forms_a_triangle_Scalene()
        {

            //Arrange
            int side1 = 14;
            int side2 = 36;
            int side3 = 29;
            string expectedResult = "Forms a triangle\nScalene\n";

            //Act
            string actualResult = TriangleSolver.Analyze(side1, side2, side3); ;

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        //Triangle: IsoSceles
        [Test]
        public void Analyze_Input67_67_and_54_Returns_Forms_a_triangle_Isosceles()
        {

            //Arrange
            int side1 = 67;
            int side2 = 67;
            int side3 = 54;
            string expectedResult = "Forms a triangle\nIsosceles\n";

            //Act
            string actualResult = TriangleSolver.Analyze(side1, side2, side3); ;

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        //Triangle: IsoSceles
        [Test]
        public void Analyze_Input54_36_and_54_Returns_Forms_a_triangle_Isosceles()
        {

            //Arrange
            int side1 = 54;
            int side2 = 36;
            int side3 = 54;
            string expectedResult = "Forms a triangle\nIsosceles\n";

            //Act
            string actualResult = TriangleSolver.Analyze(side1, side2, side3); ;

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        //Triangle: IsoSceles
        [Test]
        public void Analyze_Input5_6_and_6_Returns_Forms_a_triangle_Isosceles()
        {

            //Arrange
            int side1 = 5;
            int side2 = 6;
            int side3 = 6;
            string expectedResult = "Forms a triangle\nIsosceles\n";

            //Act
            string actualResult = TriangleSolver.Analyze(side1, side2, side3); ;

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }


        //Triangle: Equilateral
        [Test]
        public void Analyze_Input26_26_and_26_Returns_Forms_a_triangle_Equilateral()
        {

            //Arrange
            int side1 = 26;
            int side2 = 26;
            int side3 = 26;
            string expectedResult = "Forms a triangle\nEquilateral\n";

            //Act
            string actualResult = TriangleSolver.Analyze(side1, side2, side3); ;

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }



    }
}
