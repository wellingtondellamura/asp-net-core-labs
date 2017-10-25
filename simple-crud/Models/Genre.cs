using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace simple_crud.Models
{
    public class Genre
    {
        [Display(Name = "Id")]
        public Int32 GenreId{get;set;}

        [Display(Name = "Descrição")]
        [MaxLength(50)]
        [Required(ErrorMessage ="Descrição obrigatória")]
        public String Description{get;set;}
        public ICollection<Movie> Movies { get; set; }
        
    }
}