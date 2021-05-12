using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace ShowdeBola.Models {
     
     public class Actor
     {
         public int Id {get; set;}
         
         public string name {get; set;}
         
         
         public int movieId {get; set;}
        public Movie movie {get; set;}
     }
}