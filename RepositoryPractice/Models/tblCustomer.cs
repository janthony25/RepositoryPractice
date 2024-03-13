using System.ComponentModel.DataAnnotations;

namespace RepositoryPractice.Models
{
    public class tblCustomer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string CustomerName { get; set; }

        
    }
}
