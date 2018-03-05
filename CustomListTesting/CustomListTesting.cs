using System;
using CustomLists;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListTesting
{
    [TestClass]
    public class CustomListTesting
    {
        [TestMethod]

        public void CustomeList_AddAnIntObjectToCustomList_ReturnsIntObjectinIndex0()
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

        public void CustomeList_AddAnIntObjectToCustomList_ReturnsIntObjectinIndex1()
        {
            CustomList<int> custlist = new CustomList<int>();
            // arrange

            int expected = 20;
            int actual;

            //act
            custlist.Add(29);
            custlist.Add(20);
            actual = custlist[1];
            //assert

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
      public void  CustomeList_AddAnIntObjectToCustomList_ReturnsIntObjectinIndex10()
        {
            CustomList<string> teams = new CustomList<string>();
            // arrange

            string expected = "12Gold";
            string actual;

            //act
            teams.Add("12Black");
            teams.Add("12Black");
            teams.Add("12Black");
            teams.Add("12Black");
            teams.Add("12Black");
            teams.Add("12Black");
            teams.Add("12Black");
            teams.Add("12Black");
            teams.Add("12Black");
            teams.Add("12Black");
            teams.Add("12Gold");

            actual = teams[10];

            //assert 

            Assert.AreEqual(expected, actual);

        //[TestMethod]
        //[ExpectedException(typeof(IndexOutOfRangeException))]
        //public void CustomList_OutsideRangeOfIndex_Exception()
        //{
        //    CustomList<string> teams = new CustomList<string>();
        //    // arrange


        //    string actual;

        //    //act
        //    teams.Add("12Black");
        //    teams.Add("12Black");
        //    teams.Add("12Black");
        //    teams.Add("12Black");
        //    teams.Add("12Black");
        //    teams.Add("12Black");
        //    teams.Add("12Black");
        //    teams.Add("12Black");
        //    teams.Add("12Black");
        //    teams.Add("12Black");
        //    teams.Add("12Black");

        //    actual = teams[10];


        }

        [TestMethod]

        public void CustomeList_AddAnReftypeToCustomList_ReturnsRefTypeinIndex0()
        {
            CustomList<Person> custList = new CustomList<Person>();
            // arrange


            //act
            
            Person player1 = new Person()
            {
                firstName = "Ava",
                lastName = "Gumieny",
                jerseyNumber = 24,
                age = 12,
                team = "12Black"
            };

        

            custList.Add(player1);
            string expected = "Ava";
            string actual = custList[0].firstName;
            //assert

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CustomeList_RemoveAnIntObjectToCustomList_ReturnsIntObjectinInindex4()
        {
            CustomList<string> teams = new CustomList<string>();
            // arrange

            string expected = "11Gold";
            string actual;

            //act
            teams.Add("10Gold");
            teams.Add("10Black");
            teams.Add("10Silver");
            teams.Add("11Gold");
            teams.Add("11Black");
            teams.Add("11Silver");
            teams.Add("12Gold");
            teams.Add("12Black");
            teams.Add("12Silver");
            teams.Add("13Gold");
            teams.Add("13Black");

            teams.Remove("10Silver");

            actual = teams[2];

            //assert 

            Assert.AreEqual(expected, actual);

        }


            //   [TestMethod]
            //   [ExpectedException(typeof(IndexOutOfRangeException))]
            //   public void CustomList_OutsideRangeOfIndex_Exception()
            //   {
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
    

