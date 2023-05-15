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
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authorization;
using CárdapioV3_Tunado.Models.enums;
using System.IO;

namespace CárdapioV3_Tunado.Controllers
{
    [Authorize]
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
            idEmpresa = int.Parse(User.Identity!.Name!);
            ViewBag.listadeEmpresas = Estabelecimento.getTodasEmpresasbyID(idEmpresa);
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        [Authorize(Roles = nameof(E_Perfil.MASTER))] //alterado
        public IActionResult Empresas()
        {
            return View(Estabelecimento.getTodasEmpresas());
        }


        [HttpPost]
        [AllowAnonymous]
        public IActionResult Create(string NomeEmpresa, string SenhaEmpresa, string ConfirmarSenha, string Telefone, string CNPJ)
        {
            Empresa novaEmpresa = new Empresa();
            novaEmpresa.NomeEmpresa = NomeEmpresa;
            novaEmpresa.Telefone = Telefone;
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
        [AllowAnonymous] // alterado
        public IActionResult Logar()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous] //alterado
        public async Task<IActionResult> Logar(string NomeEmpresa, string SenhaEmpresa)
        {
            using (var conexao = _connection)
            {
                var query = "select * from Empresa";
                var parametros = new { NomeEmpresa, SenhaEmpresa };


                var empresas = conexao.Query<Empresa>(query).ToList();
                var empresa = empresas.FirstOrDefault(x => x.NomeEmpresa == NomeEmpresa && Estabelecimento.Descriptografar(x.SenhaEmpresa) == SenhaEmpresa);

                //alterado

                if (empresa != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, empresa.EmpresaID.ToString()),
                        new Claim(ClaimTypes.Role, empresa.Perfil_Empresa), //alterado
                        new Claim(ClaimTypes.NameIdentifier, NomeEmpresa),
                    };

                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme) ;
                    var principal = new ClaimsPrincipal(identity);

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                    return RedirectToAction("Index", "Produto");
                }
                else
                {
                    return View();
                }
            }
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Logar", "Empresa");
        }

        [HttpGet]
        [Authorize] //alterado
        public IActionResult Atualizar(int idEmpresa = 0)
        {
            if (idEmpresa == 0)
            {
                idEmpresa = int.Parse(User.Identity!.Name!);
            }
            //var empresa = Estabelecimento.getTodasEmpresas().Where(x => x.EmpresaID == idEmpresa).FirstOrDefault();
            //if (empresa is null)
            //   return BadRequest();
            //ViewBag.TaxaAtualizar = empresa;
            //ViewBag.listaIDEmpresa = idEmpresa;
            ViewBag.EmpresaAtualizar = Estabelecimento.getTodasEmpresasbyID(idEmpresa);
            return View();
        }

        [HttpPost]
        [Authorize] //alterado
        public async Task<IActionResult> Atualizar(string NomeEmpresa, string Telefone, string CNPJ, string SenhaEmpresa, double taxaEmpresa, IFormFile FotoEmpresa, int idEmpresa = 0)
        {
            if (idEmpresa == 0)
            {
                idEmpresa = int.Parse(User.Identity!.Name!);
            }
            Empresa novaEmpresa = new Empresa();
            //var empresa = Estabelecimento.getTodasEmpresas().FirstOrDefault(x => x.EmpresaID == idEmpresa);
            //empresa.taxaEmpresa = Taxa;
            novaEmpresa.EmpresaID = idEmpresa;
            novaEmpresa.NomeEmpresa = NomeEmpresa;
            novaEmpresa.Telefone = Telefone;
            novaEmpresa.CNPJ = CNPJ;
            novaEmpresa.taxaEmpresa = taxaEmpresa;

            if (!Directory.Exists("wwwroot/FotoEmpresas"))
                Directory.CreateDirectory("wwwroot/FotoEmpresas");

            string path = $"wwwroot/FotoEmpresas/Empresa_{novaEmpresa.EmpresaID}.png";

            if (FotoEmpresa is not null)
            {
                using var memoryStream = new MemoryStream();
                await FotoEmpresa.CopyToAsync(memoryStream);
                memoryStream.Position = 0;
                using var fileStream = new FileStream(path, FileMode.OpenOrCreate);
                memoryStream.CopyTo(fileStream);
            }

            novaEmpresa.FotoEmpresa = path.Replace("wwwroot/", String.Empty);

            string novaSenha = Estabelecimento.Criptografar(SenhaEmpresa);
            novaEmpresa.SenhaEmpresa = novaSenha;
            Estabelecimento.AtualizarEmpresa(novaEmpresa);

            return RedirectToAction("Index");
        }

        public IActionResult Apagar(string id)
        {
            try
            {
                Empresa empresa = new Empresa();
                empresa.EmpresaID = Convert.ToInt32(id);
                Estabelecimento.DeleteEmpresa(empresa);

                return RedirectToAction("Index");
            }
            catch
            {
                return Json("Não foi possível apagar a empresa pois ela está vinculada a produtos e categorias"); //Fazer página ou trocar pra mensagem de erro
            }

        }
    }
}
        
