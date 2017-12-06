using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetShopSolution2.Models
{
    public class produto
    {
        [Key]
        public int idProduto { get; set; }
        public String Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }


    }
}
