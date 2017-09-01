using Interview_Exercise;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace Interview_Exercise_Tests.UnitTests
{
    //TEST CLASS 
    [TestFixture]
    public class CountryUnitTest
    {

        [TestCase]
        public void GetAllCountriesCount()
        {
            //Arrange
            var mockrep = new Mock<ICountry>();
            mockrep.Setup(c => c.GetAllCountry()).Returns(
                new List<Country>()
                     {
                        new Country(){ Id="USA", Description="United States" },
                        new Country(){ Id="UK", Description="United KingDom" },
                        new Country(){ Id="IND", Description="India" },
                         new Country(){ Id="AUS", Description="Australia" },
                       }

                );

            CountryController countryCntlrobject = new CountryController(mockrep.Object);

            //Act
            var resultlstActual= countryCntlrobject.GetAllCountries();
            var expectedCount = 4;
            //Assert

            Assert.AreEqual(resultlstActual.Count, expectedCount);


        }

        [TestCase]
        public void GetAllCountriesTestData()
        {
            //Arrange
            var mockrep = new Mock<ICountry>();
            mockrep.Setup(c => c.GetAllCountry()).Returns(
                new List<Country>()
                     {
                         new Country(){ Id="USA", Description="United States" },
                         new Country(){ Id="UK", Description="United KingDom" }
                     }
                );

            CountryController countryCntlrobject = new CountryController(mockrep.Object);
            List<Country> lstexpected = new List<Country>()
                     {
                         new Country(){ Id="USA", Description="United States" },
                         new Country(){ Id="UK", Description="United KingDom" }
                     };
            //Act
            var resultlstActual = countryCntlrobject.GetAllCountries();
            //Assert

            CollectionAssert.AreEqual(resultlstActual, lstexpected);


        }


        [TestCase]
        public void AddCountryTest()
        {
            //Arrange
            var mockrep = new Mock<ICountry>();
            mockrep.Setup(c => c.Add(It.IsAny<Country>())).Returns(true);

            CountryController countryCntlrobject = new CountryController(mockrep.Object);
            Country cntobj = new Country() { Id = "USA", Description = "United States Of America" };
            //Act
            var resultActual= countryCntlrobject.Add(cntobj);
            //Assert
            var expected = true;

            Assert.AreEqual(resultActual, expected);


        }


        [TestCase]
        public void DeleteCountryTest()
        {
            //Arrange
            var mockrep = new Mock<ICountry>();
            mockrep.Setup(c => c.Delete(It.IsAny<string>())).Returns(true);

            CountryController countryCntlrobject = new CountryController(mockrep.Object);

           
            //Act
            var resultActual = countryCntlrobject.Delete("USA");
            //Assert
            var expected = true;

            Assert.AreEqual(resultActual, expected);


        }





    }
}
