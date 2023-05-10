using CárdapioV3_Tunado.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System.Text;

namespace CárdapioV3_Tunado.DAL
{
    public class EmpresaDAO
    {
        MySqlConnection _connection;

        public EmpresaDAO()
        {
            _connection = ConexaoBD.getConexao();
        }

        public List<Empresa> getTodosNomes()
        {
            var query = "select NomeEmpresa from Empresa";

            var dados = (List<Empresa>)_connection.Query<Empresa>(query);
            return dados;
        }

        public List<Empresa> getTodasSenhas()
        {
            var query = "select SenhaEmpresa from Empresa";

            var dados = (List<Empresa>)_connection.Query<Empresa>(query);
            return dados;
        }

        public List<Empresa> getTodasEmpresas()
        {
            var query = "select * from Empresa";

            var dados = (List<Empresa>) _connection.Query<Empresa>(query);
            return dados;
        }



        //Insert
        public void InsertEmpresa(Empresa novaEmpresa)
        {
            var query = "insert Empresa (NomeEmpresa, SenhaEmpresa, Telefone, CNPJ) values (@NomeEmpresa, @SenhaEmpresa, @Telefone, @CNPJ)";

            int qtdinserida = _connection.Execute(query, novaEmpresa);
        }

        //Update
        public void UpdateEmpresa(Empresa atualizarEmpresa)
        {
            var query = "update Categoria set NomeEmpresa=@NomeEmpresa, SenhaEmpresa=@SenhaEmpresa, Telefone=@Telefone, CNPJ=@CNPJ where EmpresaID=@EmpresaID";

            int qtdinserida = _connection.Execute(query, atualizarEmpresa);
        }

        //delete
        public void DeleteEmpresa(Empresa deletarEmpresa)
        {
            var query = "delete from Empresa where EmpresaID=@EmpresaID";

            int qtdinserida = _connection.Execute(query, deletarEmpresa);
        }

        public string Criptografar(string SenhaEmpresa)
        {
            //cripto=grafa
            var a = Encoding.UTF8.GetBytes(SenhaEmpresa);
            var b = Convert.ToBase64String(a);
            return b;
        }

        public string Descriptografar(string SenhaEmpresa)
        {

            //descripotografa
            var c = Convert.FromBase64String(SenhaEmpresa);
            var d = Encoding.UTF8.GetString(c);
            return d;
        }

        public void AtualizarTaxa(Empresa Taxa)
        {
            var query = "update Empresa set taxaEmpresa=@taxaEmpresa where EmpresaID=@EmpresaID";

            int qtdinserida = _connection.Execute(query, Taxa);
        }
    }
}
