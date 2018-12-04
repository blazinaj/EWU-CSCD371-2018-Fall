using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System;
using System.Collections.Generic;

namespace Assignment9.Tests
{
    [TestClass]
    public class PatentDataAnalyzerTests
    {

        [TestInitialize]
        public void Init()
        {
        }

        [TestMethod]
        public void InventorNames_QueryEquals_Country_Returns_List_Of_Inventor_Names()
        {
            string inventorsFromUSA = "Benjamin Franklin,Orville Wright,Wilbur Wright,Samuel Morse,John Michaelis,Mary Phelps Jacob";


            List<string> query = PatentDataAnalyzer.QueryEquals("Country","USA");
            Assert.AreEqual(inventorsFromUSA, String.Join(",", query));
        }

        [TestMethod]
        public void InventorNames_QueryContains_Name_Returns_List_Of_Inventor_Names()
        {
            string inventorsNameIncludesJacob = "Mary Phelps Jacob";
            string inventorsNameIncludesWright = "Orville Wright,Wilbur Wright";

            List<string> singleItemQuery = PatentDataAnalyzer.QueryContains("Name", "Jacob");
            List<string> multipleItemQuery = PatentDataAnalyzer.QueryContains("Name", "Wright");


            Assert.AreEqual(inventorsNameIncludesJacob, String.Join(",", singleItemQuery));
            Assert.AreEqual(inventorsNameIncludesWright, String.Join(",", multipleItemQuery));
        }

        [TestMethod]
        //Returns the only the last name of each of the inventor sorted in reverse order by inventor Id.
        public void InventorLastNames_Returns_Last_Name_In_Reverse_Order_By_Id()
        {
            string lastNameSortedByID = "Jacob,Michaelis,Stephenson,Morse,Wright,Wright,Franklin";

            List<string> inventorsLastNamesSortedById = PatentDataAnalyzer.InventorLastNames();

            Assert.AreEqual(lastNameSortedByID, String.Join(",", inventorsLastNamesSortedById));
        }

        [TestMethod]
        //Returns a single comma separated list of all the unique "-" 
        //strings for each inventor. The result should be a scalar value of type string, 
        //not a collection (other than the fact that a string is a collection of characters).
        public void LocationsWithInventors_Returns_CSL_Unique_Hyphen_Returns_Scalar_String()
        {
            string locationsWithInventorsTest = "PA-USA,NC-USA,NY-USA,Northumberland-UK,IL-USA";

            string locationsWithInventors = PatentDataAnalyzer.LocationsWithInventors();

            Assert.AreEqual(locationsWithInventorsTest, locationsWithInventors);
        }

        [TestMethod]
        //Write an IEnumerable<T> extension method on a class called Enumerable<T> that returns an IEnumerable<T> of the original items in random order.To test execute the method using LINQ and verify the order is not the same for at least 3 invocations.
        public void Randomize_Writes_IEnumerable_Returns_IEnumerableT_Random_Order()
        {
            List<string> rand = PatentDataAnalyzer.QueryAll();

            for (var i = 0; i < 3; i++)
            {
                Assert.AreNotEqual( String.Join(",", rand),
                                    String.Join(",", PatentDataAnalyzer.Randomize()));
            }
        }

        /*[TestMethod]
        //Create a method that returns a list of inventors that have n patents, where n is provided as a parameter to the method.
        public void GetInventorsWithMulitplePatents()
        {
            

        }
        */

        [TestMethod]
        //Write a method that returns a collection of every nth fibonacci number.
        public void NthFibonacciNumbers()
        {
            List<int> list = PatentDataAnalyzer.NthFibonacciNumbers(10);

            Assert.AreEqual("1,2,3,5,8,13,21,34,55,89", string.Join(",", list));

        }
    }
}
