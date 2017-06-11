using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspCRUDExample.Models
{
    public class pessoa
    {
        [Key]
        public int Codigo { get; set; }
        public string nome { get; set; }
        public string Email { get; set; }
    }
}