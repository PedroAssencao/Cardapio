namespace CárdapioV3_Tunado.Models
{
    public class Empresa
    {
        public int EmpresaID { get; set; }
        public string Telefone { get; set; }
        public string NomeEmpresa { get; set; }
        public string SenhaEmpresa { get; set; }
        public string CNPJ { get; set; }
        public double taxaEmpresa { get; set; } 
        public string Perfil_Empresa { get; set; }
        public string FotoEmpresa { get; set; }
        public string Perfil_Empresa { get; set; }

        public bool VerificarSenha(string Senha, string ConfirmarSenhas) => Senha == ConfirmarSenhas;

    }
}
