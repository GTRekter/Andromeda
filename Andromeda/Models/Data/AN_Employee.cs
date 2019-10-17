using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Andromeda.Models.Data
{
    public class AN_Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public Guid IdAndromeda { get; set; }
        public Guid IdAndromedaCompany { get; set; }
        public Guid IdAndromedaPerson { get; set; }
    }
}
