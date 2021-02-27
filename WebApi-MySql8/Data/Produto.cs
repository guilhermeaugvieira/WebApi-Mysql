using System.ComponentModel.DataAnnotations;

namespace WebApi_MySql8.Data
{
    public class Produto
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
    }
}
