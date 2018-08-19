using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace crud_people.Models
{
    public class PersonViewModel
    {
        public int id { get; set; }
        [Required(ErrorMessage ="O campo nome é obrigatório.")]
        public string name { get; set; }
        public string address { get; set; }
    }
}
