using System.Collections.Generic;
using AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_10;
using System.Linq;
using System;

namespace Assignment9
{
    public static class PatentDataAnalyzer
    {
        public static List<string> InventorNames(string param)
        {
            IEnumerable<string> q = PatentData.Inventors
                        .Where(inventor => inventor.Country.Equals(param))
                        .Select(inventor => inventor.Name);

            return q.ToList<string>();
        }

        public static List<string> InventorLastNames()
        {
            IEnumerable<string> q = PatentData.Inventors
                        .OrderByDescending(inventor => inventor.Id)
                        .Select(inventor => inventor.Name.Split().Last());

            return q.ToList<string>();
        }

        public static List<string> Randomize()
        {
            IEnumerable<string> q = PatentData.Inventors
                        .OrderByDescending(inventor => inventor.Id)
                        .Select(inventor => inventor.ToString());

            Enumerable.Randomize(q);

            return q.ToList<string>();
        }

        public static List<string> QueryEquals(string field, string param)
        {
            IEnumerable<string> q = null;
            switch (field)
            {
                case "Country":
                    q = PatentData.Inventors
                        .Where(inventor => inventor.Country.Equals(param))
                        .Select(inventor => inventor.Name);
                    break;
                case "Name":
                    q = PatentData.Inventors
                        .Where(inventor => inventor.Name.Equals(param))
                        .Select(inventor => inventor.Name);
                    break;
                default:
                    break;
            }

            return q.ToList<string>();
        }

        public static List<string> QueryEquals(string param)
        {
            return QueryEquals("Country", param);
        }

        public static List<string> QueryAll()
        {
            IEnumerable<string> q = null;

            q = PatentData.Inventors
                .Select(inventor => inventor.ToString());

            return q.ToList<string>();
        }

        //Was just playing around with linq
        public static List<string> QueryContains(string field, string param)
        {
            IEnumerable<string> q = null;
            switch (field)
            {
                case "Country":
                    q = PatentData.Inventors
                        .Where(inventor => inventor.Country.Contains(param))
                        .Select(inventor => inventor.Name);
                    break;
                case "Name":
                    q = PatentData.Inventors
                        .Where(inventor => inventor.Name.Contains(param))
                        .Select(inventor => inventor.Name);
                    break;
                default:
                    break;
            }

            return q.ToList<string>();
        }

        public static string LocationsWithInventors()
        {
            IEnumerable<string> stateHyphenCountry = PatentData.Inventors
                        .Select(inventor => $"{inventor.State}-{inventor.Country}")
                        .Distinct();

            return string.Join(",", stateHyphenCountry);

        }

        public static List<int> NthFibonacciNumbers(int n)
        {
            List<int> nFibonacciNumbers = new List<int>();

            int baseOne = 1;
            int baseTwo = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = baseOne;
                baseOne = baseTwo;
                baseTwo = temp + baseTwo;

                nFibonacciNumbers.Add(baseOne);
            }

            return nFibonacciNumbers;
        }

        /*public static List<Inventor> GetInventorsWithMultiplePatents(int n)
        {

        }
        */
    }

    public static class Enumerable
    {
        public static IEnumerable<T> Randomize<T>(this IEnumerable<T> source)
        {
            Random range = new Random(5000);

            var list = source.ToList();
            for (int i = 0; i < list.Count; i++)
            {
                int j = range.Next(i, list.Count);

                yield return list[j];

                list[j] = list[i];
            }
        }
    }


}
