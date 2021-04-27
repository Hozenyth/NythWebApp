using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //Utilizado pra Display.

namespace NythWebApp.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")] //Descrição incluida com acento.
        [RequiredAttribute(ErrorMessage = "O campo produto é obrigatório")]


        public string Descricao { get; set; }
        [RangeAttribute(1, 10, ErrorMessage = "Valor fora da faixa")]
        public int Quantidade { get; set; }

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}