using System.ComponentModel.DataAnnotations;

namespace firstproject.Models
{
    public class Classpro
    {
        [Required(ErrorMessage ="name is required")]
        public string full_name{ get; set; }
        [Required(ErrorMessage="Error is required")]
        public string email_id {  get; set; }
        public string subject { get; set; }
        public string message{ get; set;} 
            
    }
}
