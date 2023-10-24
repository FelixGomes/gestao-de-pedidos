using System.ComponentModel.DataAnnotations;

namespace gestao_pedidos.Models
{
    public class Cliente
    {
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }


        [Required(ErrorMessage = "O nome do usuário é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Nome do Usuário")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Informe o seu email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
    }
}
