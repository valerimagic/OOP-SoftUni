using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dataaccess.Entity
{
    public class BaseClass
    {
        [Key]
        public int ID { get; set; }  
    }
}
