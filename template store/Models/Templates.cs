using System.ComponentModel.DataAnnotations;

namespace template_store.Models
{
    public class Templates
    {
        [Key]
        public int TemplateId { get; set; }
        public string? TemplateName { get; set; }
        public string? TemlateAddress { get; set; }
    }
}
