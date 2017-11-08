using System;

namespace BookStore.Models
{
    public class Book
    {
        public Int32 BookId{get;set;}
        public String Title{get;set;}
        public Int32 Year{get;set;}
        public String Author{get;set;}
        public byte[] Image{get;set;}

        public Int32 CategoryId{get;set;}
        public Category Category{get;set;}
    }
}