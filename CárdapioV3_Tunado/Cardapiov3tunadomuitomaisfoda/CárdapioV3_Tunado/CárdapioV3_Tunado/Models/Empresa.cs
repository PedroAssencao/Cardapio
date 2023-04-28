namespace CárdapioV3_Tunado.Models
{
    public class Empresa
    {
        public int EmpresaID { get; set; }
        public string Telefone { get; set; }
        public string NomeEmpresa { get; set; }
        public string SenhaEmpresa { get; set; }
        public string CNPJ { get; set; }

        public bool VerificarSenha(string Senha, string ConfirmarSenhas)
        {
            if (Senha == ConfirmarSenhas)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
