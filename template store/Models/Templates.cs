using System.ComponentModel.DataAnnotations;

namespace template_store.Models
{
    public class Templates
    {
        [Key]
        public int TemplateId { get; set; }
        [Required]
        public string? TemplateName { get; set; }
        [Required]
        public string? TemplateAddress { get; set; }

        public decimal TemplatePrice { get; set; }



    }
}
