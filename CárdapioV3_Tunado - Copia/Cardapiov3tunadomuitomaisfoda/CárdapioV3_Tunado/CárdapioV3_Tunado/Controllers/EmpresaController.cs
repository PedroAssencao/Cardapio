using CárdapioV3_Tunado.DAL;
using CárdapioV3_Tunado.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Esf;
using Org.BouncyCastle.Asn1.Iana;
using System.Data.SqlClient;

namespace CárdapioV3_Tunado.Controllers
{
    public class EmpresaController : Controller
    {

        EmpresaDAO Estabelecimento = new EmpresaDAO();
        MySqlConnection _connection;
        public EmpresaController()
        {
            _connection = ConexaoBD.getConexao();
        }

        public IActionResult Index()
        {
            ViewBag.listaEmpresas = Estabelecimento.getTodasEmpresas();
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string NomeEmpresa, string SenhaEmpresa, string ConfirmarSenha, string Telefone, string CNPJ)
        {
            Empresa novaEmpresa = new Empresa();
            novaEmpresa.NomeEmpresa = NomeEmpresa;
            novaEmpresa.SenhaEmpresa = SenhaEmpresa;
            novaEmpresa.Telefone = Telefone;
            novaEmpresa.CNPJ = CNPJ;
            if (novaEmpresa.VerificarSenha(SenhaEmpresa, ConfirmarSenha))
            {
                Estabelecimento.InsertEmpresa(novaEmpresa);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Logar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Logar(string NomeEmpresa, string SenhaEmpresa)
        {
            using (var conexao = _connection)
            {
                var query = "SELECT * FROM Empresa WHERE NomeEmpresa = @NomeEmpresa AND SenhaEmpresa = @SenhaEmpresa";
                var parametros = new { NomeEmpresa, SenhaEmpresa };
                var empresa = conexao.QueryFirstOrDefault<Empresa>(query, parametros);
                if (empresa != null)
                {
                    return RedirectToAction("Create");
                }
                else
                {
                    return View();
                }
            }
        }
    }
}
        
