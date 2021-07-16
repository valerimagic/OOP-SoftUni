namespace Dataaccess.Entity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Teams : BaseClass
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(30)]
        public string NameCountry { get; set; }

        public Statistics Statistic { get; set; }

        public ICollection<Players> Players { get; set; } = new HashSet<Players>();
    }
}
