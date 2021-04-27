using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace NythWebApp.Models
{
    public class Categoria
    {
        public int Id { get; set; } //Chave primária da tabela no BD


        [Display(Name = "Descrição")]
        [RequiredAttribute(ErrorMessage = "O campo descrição é obrigatório")]




        public string Descricao { get; set; }


      // public List<Produto> Produtos { get; set; }

    }
}