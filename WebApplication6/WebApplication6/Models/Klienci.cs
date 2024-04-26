using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Models
{
    public class Klienci
    {
        [Key]

        public int Id { get; set; }
        public string Name { get; set; } 
        public string Surname { get; set; } 

        public string Pesel { get; set; } 

       

        public int BirthYear { get; set; } 
        public int Płeć { get; set;} 
    }
}
