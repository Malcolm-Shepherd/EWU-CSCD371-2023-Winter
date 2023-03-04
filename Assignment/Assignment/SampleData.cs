﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Linq;

namespace Assignment
{
    public class SampleData : ISampleData
    {
        // 1.
        public IEnumerable<string> CsvRows 
        {
            get
            {
                IEnumerable<string> lines =
                    from line in File.ReadLines("People.csv")
                    where line.Contains('@')
                    select line;
                return lines;
            } 
        }

        // 2.
        public IEnumerable<string> GetUniqueSortedListOfStatesGivenCsvRows()
        {
            List<string> states = new List<string>();
            foreach(string item in CsvRows) 
            {
                string[] Csvs  = item.Split(',');
                states.Add(Csvs[6]);
            } 
            IEnumerable<string> uniqueStates = states.Distinct().OrderBy(state => state);
            return uniqueStates;
        }

        // 3.
        public string GetAggregateSortedListOfStatesUsingCsvRows() 
        {
            IEnumerable<string> states = this.GetUniqueSortedListOfStatesGivenCsvRows();
            

            return string.Join(',', states.ToArray());
        }

        // 4.
        public IEnumerable<IPerson> People => throw new NotImplementedException();

        // 5.
        public IEnumerable<(string FirstName, string LastName)> FilterByEmailAddress(
            Predicate<string> filter) => throw new NotImplementedException();

        // 6.
        public string GetAggregateListOfStatesGivenPeopleCollection(
            IEnumerable<IPerson> people) => throw new NotImplementedException();
    }
}
