using System.ComponentModel.DataAnnotations;

namespace Cardápio.Models
{
	public class EstabelecimentoModels
	{
		[Key] public int CNPJ { get; set; }
		public string Endereco { get; set; }
		public string Telefone { get; set; }
		public string HorariosFim { get; set; }
		public string HorariosInicio { get; set; }
		public string Foto { get; set; }
        public string Email  { get; set; }
        public string Senha { get; set; }
    }
}
