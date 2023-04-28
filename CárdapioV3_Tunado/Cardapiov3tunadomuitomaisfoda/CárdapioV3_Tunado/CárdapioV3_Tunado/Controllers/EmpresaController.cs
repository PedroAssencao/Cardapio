using CárdapioV3_Tunado.DAL;
using CárdapioV3_Tunado.Models;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.Esf;
using Org.BouncyCastle.Asn1.Iana;

namespace CárdapioV3_Tunado.Controllers
{
    public class EmpresaController : Controller
    {

        EmpresaDAO Estabelecimento = new EmpresaDAO();

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
            Empresa login = new Empresa();
            if (login.NomeEmpresa == login.NomeEmpresa)
            {
                if ((login.SenhaEmpresa == login.SenhaEmpresa))
                {
                    return RedirectToAction("Create");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
    }
}
