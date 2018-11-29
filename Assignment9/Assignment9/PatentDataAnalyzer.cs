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
            IEnumerable<string> Q = PatentData.Inventors
                        .Where(inventor => inventor.Country.Equals(param))
                        .Select(inventor => inventor.Name);

            return Q.ToList<string>();
        }

        public static List<string> InventorLastNames()
        {
            IEnumerable<string> Q = PatentData.Inventors
                        .OrderByDescending(inventor => inventor.Id)
                        .Select(inventor => inventor.Name);

            return Q.ToList<string>();
        }

        public static List<string> Randomize()
        {
            IEnumerable<string> Q = PatentData.Inventors
                        .OrderByDescending(inventor => inventor.Id)
                        .Select(inventor => inventor.ToString());
            
            Enumerable.Randomize(Q);

            return Q.ToList<string>();
        }

        public static List<string> QueryEquals(string field, string param)
        {
            IEnumerable<string> Q = null;
            switch (field)
            {
                case "Country":
                    Q = PatentData.Inventors
                        .Where(inventor => inventor.Country.Equals(param))
                        .Select(inventor => inventor.Name);
                    break;
                case "Name":
                    Q = PatentData.Inventors
                        .Where(inventor => inventor.Name.Equals(param))
                        .Select(inventor => inventor.Name);
                    break;
                default:
                    break;
            }

            return Q.ToList<string>();
        }

        public static List<string> QueryAll()
        {
            IEnumerable<string> Q = null;

                    Q = PatentData.Inventors
                        .Select(inventor => inventor.ToString());

            return Q.ToList<string>();
        }

        public static List<string> QueryContains(string field, string param)
        {
            IEnumerable<string> Q = null;
            switch (field)
            {
                case "Country":
                    Q = PatentData.Inventors
                        .Where(inventor => inventor.Country.Contains(param))
                        .Select(inventor => inventor.Name);
                    break;
                case "Name":
                    Q = PatentData.Inventors
                        .Where(inventor => inventor.Name.Contains(param))
                        .Select(inventor => inventor.Name);
                    break;
                default:
                    break;
            }

            return Q.ToList<string>();
        }
        
    }

    public static class Enumerable
    {
        public static IEnumerable<T> Randomize<T>(this IEnumerable<T> source)
        {
            return source.Randomize(new Random());
        }

        private static IEnumerable<T> Randomize<T>(
            this IEnumerable<T> source, Random rng)
        {
            var buffer = source.ToList();
            for (int i = 0; i < buffer.Count; i++)
            {
                int j = rng.Next(i, buffer.Count);
                yield return buffer[j];

                buffer[j] = buffer[i];
            }
        }
    }
}
