using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Andromeda.Models.Data
{
    public class AN_Company
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public Guid IdAndromeda { get; set; }
        public string Name { get; set; }
        public string Website { get; set; }
        public Guid? IdAndromedaAddress { get; set; }
    }
}
