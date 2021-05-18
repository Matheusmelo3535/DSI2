using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace ShowdeBola.Models {
     
     public class Actor
     {
          [Required]
         public int Id {get; set;}
         
         
         [StringLength(60, MinimumLength = 10)]
         [Required]
         public string name {get; set;}
         
         
         public int movieId {get; set;}
        public Movie movie {get; set;}
     }
}