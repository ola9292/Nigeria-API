using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nigeria.Models
{
    public class State 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }        
        public string Capital { get; set; }      
        public long Population { get; set; }     
        public double Area { get; set; }         
        public string Region { get; set; }       
        public string Governor { get; set; } 
    }
}