using System.ComponentModel.DataAnnotations;

namespace RepositoryPractice.Models
{
    public class tblIssue
    {
        [Key]
        public int IssueId { get; set; }
        [Required]
        public string Problem { get; set; }
        [Required]
        public string CarMake { get; set; }
        [Required]
        public string CarModel { get; set; }
        [Required]
        public string CarRego { get; set; }

        public int CustomerId { get; set; }
      //  public tblCustomer tblCustomer { get; set; }
    }
}
