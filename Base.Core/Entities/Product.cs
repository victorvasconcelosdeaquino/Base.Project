using System.ComponentModel.DataAnnotations;

namespace Base.Core.Entities
{
    public class Product : Base<int>
    {
        [Required, StringLength(maximumLength:6, MinimumLength = 4)]
        public string? Code { get; set; }
        [Required, StringLength(maximumLength: 80, MinimumLength = 2)]
        public string? Name { get; set; }
        public string? Description { get; set; }
        [Required]
        public float Price { get; set; }
        public bool IsActive { get; set; }
    }
}
