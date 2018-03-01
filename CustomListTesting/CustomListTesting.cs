using System;
using CustomLists;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListTesting
{
    [TestClass]
    public class CustomListTesting
    {
        [TestMethod]

        static void CustomeList_AddAnIntObjectToCustomList_ReturnsIntObjectinIndex0()
        {
            CustomList<int> custlist = new CustomList<int>();
            // arrange

            int expected = 30;
            int actual;

            //act
            custlist.Add(30);
            actual = custlist[0];
            //assert

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]

        static void CustomeList_AddAnIntObjectToCustomList_ReturnsIntObjectinIndex1()
        {
            CustomList<int> custlist = new CustomList<int>();
            // arrange

            int expected = 20;
            int actual;

            //act
            custlist.Add(20);
            actual = custlist[2];
            //assert

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]

        static void CustomeList_AddAnReftypeToCustomList_ReturnsRefTypeinIndex0()
        {
            CustomList<> custlistref = new CustomList<int>();
            // arrange

            int expected = 30;
            int actual;

            //act
            actual = custlist.Add(ref 30);
            //assert

            Assert.AreEqual(expected, actual);

        }


        //[TestMethod]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        //public void Weather_OutsideRangeIndex_Exception()
        //{
        //    Weather weather = new LemonAidStand.Weather();
        //    // arrange

        //    //  string expected = "Muggy";
        //    string actual;

        //    //act
        //    actual = weather.CreateWeather(6);
        //    //assert

        //    //  Assert.AreEqual(expected, actual);

    }
    }
