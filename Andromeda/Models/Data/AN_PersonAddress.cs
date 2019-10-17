using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Andromeda.Models.Data
{
    public class AN_PersonAddress
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public Guid IdAndromedaPerson { get; set; }
        public Guid IdAndromedaAddress { get; set; }
        public bool Primary { get; set; }
    }
}
