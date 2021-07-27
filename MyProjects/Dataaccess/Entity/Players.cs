namespace Dataaccess.Entity
{
    using System.ComponentModel.DataAnnotations;

    public class Players : BaseClass
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        [MaxLength(50)]
        public string Country { get; set; }

        [MaxLength(50)]
        public string City { get; set; }
    }
}
