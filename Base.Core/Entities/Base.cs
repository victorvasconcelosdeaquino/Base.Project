using System.ComponentModel.DataAnnotations;

namespace Base.Core.Entities
{
    public class Base<T>
    {
        [Key]
        public T Id { get; set; }
    }
}
