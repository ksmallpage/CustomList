﻿using System;
using CustomLists;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

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

        [TestMethod]
        public void CustomeList_CounttheNumberofElementsinaListCustomList_ReturnsIntofCount()
        {
            CustomList<string> teams = new CustomList<string>();
            // arrange

            int expected = 11;
            int actual;

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

            teams.Count();

            actual = teams.Count();

            //assert 

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CustomeList_iteratethroughaCustomList_ReturnstheelementsinaList()
        {
            CustomList<string> teams = new CustomList<string>();
           

            // arrange

            string expected = "HelloKeithSmallpage5335";
            string actual;
            string printstring = "Hello";

            //act

            teams.Add("Keith");
            teams.Add("Smallpage");
            teams.Add("5335");
            foreach (var item in teams)
            {
                printstring = printstring + item;
            }



            actual = printstring;

            //assert 

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CustomeList_overloadtheplusoperator_Returnssinglearrayadded()
        {
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testList3 = new CustomList<int>();


            // arrange

            int expected = 56;
            int actual;


            //act

            testList1.Add(34);
            testList2.Add(56);
            testList3 = testList1 + testList2;




            actual = testList3[1];

            //assert 

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CustomeList_overloadtheminusoperator_Returnssamelengthlists()
        {
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testList3 = new CustomList<int>();


            // arrange

            int expected = 90;
            int actual;


            //act

            testList1.Add(34);
            testList1.Add(80);
            testList2.Add(56);
            testList2.Add(90);
            testList2.Add(88);
            testList2.Add(77);
            testList3 = testList1 - testList2;




            actual = testList3[3];

            //assert 

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CustomeList_createaZipperMethod_ReturnssingleListinterleaved()
        {
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testList3 = new CustomList<int>();


            // arrange

            int expected = 6;
            int actual;


            //act

            testList1.Add(1);
            testList1.Add(3);
            testList1.Add(5);
            testList2.Add(2);
            testList2.Add(4);
            testList2.Add(6);
            testList3 = testList3.Zipper(testList1, testList2);




            actual = testList3[5];

            //assert 

            Assert.AreEqual(expected, actual);

        }


        //[TestMethod]
        //[ExpectedException(typeof(IndexOutOfRangeException))]
        //public void CustomList_OutsideRangeOfIndex_Exception()
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
    

