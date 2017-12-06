using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetShopSolution2.Models
{
    public class cliente
    {
        [Key]
        public int CPF { get; set; }
        public String Nome { get; set; }
        public String Logadouro { get; set; }
        public int Telefone { get; set; }
        public String Animal { get; set; }
        public int Cartao { get; set; }
    }
}