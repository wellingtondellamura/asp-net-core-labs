using System;
using System.Collections.Generic;

namespace BookStore.Models
{
    public class Category
    {
        public Int32 CategoryId{get;set;}
        public String Name{get;set;}
        public String Color{get;set;}

        public List<Book> Books{get;set;}
    }
}