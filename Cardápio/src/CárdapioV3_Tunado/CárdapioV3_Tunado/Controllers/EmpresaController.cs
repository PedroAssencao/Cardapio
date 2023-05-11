using CárdapioV3_Tunado.DAL;
using CárdapioV3_Tunado.Models;
using Dapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.Esf;
using Org.BouncyCastle.Asn1.Iana;
using System.Data.SqlClient;
using System.Security.Claims;
using System.Text;

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

        public IActionResult Index(int idEmpresa)
        {
            idEmpresa = int.Parse(User.Identity!.Name);
            ViewBag.listaEmpresas = Estabelecimento.getTodasEmpresasbyID(idEmpresa);
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string NomeEmpresa, string SenhaEmpresa, string ConfirmarSenha, string Telefone, string FotoEmpresa, string CNPJ)
        {
            Empresa novaEmpresa = new Empresa();
            novaEmpresa.NomeEmpresa = NomeEmpresa;
            novaEmpresa.Telefone = Telefone;
            novaEmpresa.FotoEmpresa = FotoEmpresa;
            novaEmpresa.CNPJ = CNPJ;
            if (novaEmpresa.VerificarSenha(SenhaEmpresa, ConfirmarSenha))
            {
                //cripto=grafa
                var a = Encoding.UTF8.GetBytes(SenhaEmpresa);
                var b = Convert.ToBase64String(a);
                novaEmpresa.SenhaEmpresa = b;
                Estabelecimento.InsertEmpresa(novaEmpresa);
                return RedirectToAction("Logar");
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
        public async Task<IActionResult> Logar(string NomeEmpresa, string SenhaEmpresa)
        {
            using (var conexao = _connection)
            {
                var query = "select * from Empresa";
                var parametros = new { NomeEmpresa, SenhaEmpresa };


                var empresas = conexao.Query<Empresa>(query).ToList();
                var empresa = empresas.FirstOrDefault(x => x.NomeEmpresa == NomeEmpresa && Estabelecimento.Descriptografar(x.SenhaEmpresa) == SenhaEmpresa);
                if (empresa != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, empresa.EmpresaID.ToString()),
                        new Claim(ClaimTypes.NameIdentifier, NomeEmpresa),
                    };

                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var principal = new ClaimsPrincipal(identity);

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                    return RedirectToAction("Index", "Categoria");
                }
                else
                {
                    return View();
                }
            }
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Logar", "Empresa");
        }

        [HttpGet]
        public IActionResult Atualizar(int idEmpresa)
        {
            var empresa = Estabelecimento.getTodasEmpresas().Where(x => x.EmpresaID == idEmpresa).FirstOrDefault();
            if (empresa is null)
                return BadRequest();
            ViewBag.TaxaAtualizar = empresa;
            return View();
        }

        [HttpGet]
        public IActionResult cu()
        {
            var idEmpresa = int.Parse(User.Identity!.Name);
            var empresa = Estabelecimento.getTodasEmpresas().Where(x => x.EmpresaID == idEmpresa).FirstOrDefault();
            if (empresa is null)
                return BadRequest();
            ViewBag.TaxaAtualizar = empresa;
            ViewBag.listaIDEmpresa = idEmpresa;
            return View();
        }

        [HttpPost]
        public IActionResult cu(double Taxa, int idEmpresa)
        {

            EmpresaDAO taxaempresa = new EmpresaDAO();
            var empresa = taxaempresa.getTodasEmpresas().FirstOrDefault(x => x.EmpresaID == idEmpresa);
            empresa.taxaEmpresa = Taxa;
            Estabelecimento.AtualizarTaxa(empresa);

            return RedirectToAction("Index");
        }
    }
}
        
