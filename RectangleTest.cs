using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2Test;

namespace Assignment2Test
{
    public class RectangleTest
    {
        [Test]
        public void ValidTriangle_Input20and80and80_OutputValidTriangle()
        {
            //Arrange
            int firstAngle = 20;
            int secondAngle = 80;
            int thirdAngle = 80;
            string expected = "The triangle is valid.";
            //string false_condition = "The triangle is invalid";


            //Act
            string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);


            //Assert
            Assert.AreNotEqual(expected, actual);

        }
    }
}
