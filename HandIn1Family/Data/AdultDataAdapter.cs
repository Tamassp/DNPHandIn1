using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using HandIn1Family.Persistence;
using Models;

namespace HandIn1Family.Data
{
    public class AdultDataAdapter : IAdultData
    {
        private FileContext fileContext; 
        private IList<Adult> adults;
        

        public AdultDataAdapter()
        {
            fileContext = new FileContext();
            
            /*Adult adultTest = new Adult();
            Person personTest = new Person();
            adults.Add(adultTest);*/

        }

        public IList<Adult> GetAdults()
        {
            adults = new List<Adult>(fileContext.Adults);
            
            return adults;
        }

        public void AddAdult(Adult adult)
        {
            int max = adults.Max(adult => adult.Id);
            adult.Id = (++max);
            fileContext.Adults.Add(adult);
            fileContext.SaveChanges();
        }

        public void RemoveAdult(int adultId)
        {
            Adult toRemove = adults.First(a => a.Id == adultId);
            Console.WriteLine("Deleteee  " + toRemove.FirstName);
            fileContext.Adults.Remove(toRemove);
            fileContext.SaveChanges();
        }
    }
}