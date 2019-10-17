using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Andromeda.Models.Data
{
    public class AN_Image
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public Guid IdAndromeda { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
    }
}
