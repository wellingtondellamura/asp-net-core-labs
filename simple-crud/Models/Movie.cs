using System;

namespace simple_crud.Models
{
    public class Movie
    {
        public Int32 MovieId{get;set;}
        public String Title{get;set;}
        public String Summary{get;set;}
        public Int32 Year{get;set;}
        public Int32 GenreId{get;set;}
        public Genre Genre{get;set;}
    }
}