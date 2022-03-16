using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WSUniverslLib;
namespace UnitTestForLibary
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetQuant_easytest1_Returnrez()
        {
            int rez = 3;
            testingFunctions MyTest = new testingFunctions();
            int inter = MyTest.GetQuantityForProduct(2, 6);
            Assert.AreEqual(rez);
        }
        [TestMethod]
        public void GetQuant_easytest2_Return1655()
        {
            //Arrange
            int productType = 1, materialType = 3, count = 10, expected = 1655;
            float width = 20, length = 11;

            //Act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void GetQuant_easytest3_Returnrez()()
        {
            //Arrange
            int productType = 18, materialType = 33, count = 310, expected = 1655;
        float width = 14, length = 112;

        //Act
        int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

        //Assert
        Assert.AreEqual(expected, actual);
         }

    [TestMethod]
    public void GetQuant_easytest4_Returnrez()()
        {
            //Arrange
            int productType = 112, materialType = 1, count = 10, expected = 1655;
    float width = 10, length = 15;

    //Act
    int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

    //Assert
    Assert.AreEqual(expected, actual);

        [TestMethod]
    public void GetQuant_easytest5_Returnrez()
    {
        int rez = 6;
        testingFunctions MyTest = new testingFunctions();
        int inter = MyTest.GetQuantityForProduct(22, 13);
        Assert.AreEqual(rez);
    }
    [TestMethod]
    public void GetQuant_easytest6_Returnrez()()
        {
            //Arrange
            int productType = 5, materialType = 3, count = 20, expected = 1655;
    float width = 10, length = 15;

    //Act
    int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

    //Assert
    Assert.AreEqual(expected, actual);
        }

[TestMethod]
public void GetQuant_easytest7_Returnrez()()
        {
    //Arrange
    int productType = 1, materialType = 10, count = 5, expected = 1655;
    float width = 6, length = 4;

    //Act
    int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

    //Assert
    Assert.AreEqual(expected, actual);
}

[TestMethod]
public void GetQuant_easytest8_Returnrez()()
        {
    //Arrange
    int productType = 4, materialType = 4, count = 4, expected = 1655;
    float width = 4, length = 4;

    //Act
    int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

    //Assert
    Assert.AreEqual(expected, actual);
}

[TestMethod]
public void GetQuant_easytest9_Returnrez()()
        {
    //Arrange
    int productType = 27, materialType = 23, count = 36, expected = 1655;
    float width = 9, length = 43;

    //Act
    int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

    //Assert
    Assert.AreEqual(expected, actual);
}
[TestMethod]
public void GetQuant_easytest10_Returnrez()()
        {
    //Arrange
    int productType = 7, materialType = 5, count = 2, expected = 1655;
    float width = 22, length = 8;

    //Act
    int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

    //Assert
    Assert.AreEqual(expected, actual);
}




}
}
