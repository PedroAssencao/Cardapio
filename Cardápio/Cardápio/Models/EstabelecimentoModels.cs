using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cardápio.Models
{
	public class EstabelecimentoModels
	{
		[Key] public int CNPJ { get; set; }
        public string Nome { get; set; }

		[Required]
        public string Endereco { get; set; }
		public string Telefone { get; set; }
		public string? HorariosFim { get; set; }
		public string? HorariosInicio { get; set; }
		public string? Foto { get; set; }

		[EmailAddress]
        public string Email  { get; set; }
        public string Senha { get; set; }

		[NotMapped]
		public string ConfirmarSenha { get; set; }

		public bool verificaSenha()
		{
			return Senha == ConfirmarSenha;
		}
    }
}
