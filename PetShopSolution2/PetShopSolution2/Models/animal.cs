using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetShopSolution2.Models
{
    public class animal
    {
        [Key]
        public int idAnimal { get; set; }
        public String Nome { get; set; }
        public String Descricao { get; set; }
        public double Peso { get; set; }
        public int Idade { get; set; }


    }
}