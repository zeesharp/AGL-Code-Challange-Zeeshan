using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using Moq;
using AGL_Code_Challenge;
using static AGL_Code_Challenge.BusinessModels.Enum;

namespace AGL_Code_Challenge_UnitTests
{
    [TestClass]
    public class People_API_Test
    {
        [TestMethod]
        public void Execute_PositiveTest_Male_Pet_Cat()
        {
        var testData = MockData.GetValidPeopleListWithPets();

            var pestListOfCat = BusinessLogic.GetCatsNameByGender(testData, GenderEnum.Male.ToString(), AnimalEnum.Cat.ToString());

            Assert.AreEqual(4, pestListOfCat.Count);

        }
        [TestMethod]
        public void Execute_PositiveTest_Female_Pet_Cat()
        {
            var testData = MockData.GetValidPeopleListWithPets();

            var pestListOfCat = BusinessLogic.GetCatsNameByGender(testData, GenderEnum.Female.ToString(), AnimalEnum.Cat.ToString());

            Assert.AreEqual(2, pestListOfCat.Count);

        }

        [TestMethod]
        public void Execute_NegativeTest_Female_Pet_Chicken()
        {
            var testData = MockData.GetValidPeopleListWithPets();

            var pestListOfCat = BusinessLogic.GetCatsNameByGender(testData, GenderEnum.Female.ToString(), AnimalEnum.Chicken.ToString());

            Assert.AreEqual(0, pestListOfCat.Count);
        }
    }
}
