﻿using CárdapioV3_Tunado.DAL;
using CárdapioV3_Tunado.Models;
using CárdapioV3_Tunado.Models.enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CárdapioV3_Tunado.Controllers
{
    [Authorize(Roles = nameof(E_Perfil.MASTER))] // alterado
    public class CardapioController : Controller
    {
        ListCategoriaProduto cardapio2 = new ListCategoriaProduto();
        CardapioDAO cardapio = new CardapioDAO();
        EmpresaDAO empresa = new EmpresaDAO();

        [AllowAnonymous]
        public IActionResult Index(int idEmpresa)
        {
            try
            {
               if (User.Identity?.Name != null)
                {
                    idEmpresa = int.Parse(User.Identity!.Name);
                }
                List<CategoriaProdutoView> lista = cardapio.getTodosProdutosbyEmpresa(idEmpresa);
                List<CategoriaProdutoView> listaCategoria = cardapio.getTodasCategoriasbyEmpresa(idEmpresa);            

                var emp = empresa.getTodasEmpresas().First(x => x.EmpresaID == lista.First().EmpresaID); //TODO: Retorna erro ao não ter itens no banco
             
                lista = lista.Select(x =>
                {
                    x.Telefone = emp.Telefone;
                    return x;
                }).ToList();
                listaCategoria.Select(x =>
                {
                    x.Telefone = emp.Telefone;
                    return x;
                }).ToList();

                lista = lista.Select(x =>
                {
                    x.FotoEmpresa = emp.FotoEmpresa;
                    return x;
                }).ToList();
                listaCategoria.Select(x =>
                {
                    x.FotoEmpresa = emp.FotoEmpresa;
                    return x;
                }).ToList();

                lista = lista.Select(x =>
                {
                    x.Taxa = emp.taxaEmpresa;
                    return x;
                }).ToList();
                listaCategoria.Select(x =>
                {
                    x.Taxa = emp.taxaEmpresa;
                    return x;
                }).ToList();

                var listas = new ListCategoriaProduto
                {
                    Lista1 = lista,
                    Lista2 = listaCategoria
                };
                return View(listas);
            }
            catch (Exception)
            {
                return Json("Não existem produtos nesta empresa");
            }
 
        }





        //crud
        //create
        [HttpGet]
        public IActionResult create()
        {
            return View();

        }

        [HttpPost]
        public IActionResult create(string Nome, string Descricao, double preco, int Categoria)
        {
            CategoriaProdutoView NovoProduto = new CategoriaProdutoView();
            NovoProduto.DescricaoProduto = Descricao;
            NovoProduto.NomeProduto = Nome;
            NovoProduto.PrecoProduto = preco;
            NovoProduto.CategoriaProduto = Categoria;
            cardapio.InsertProdutos(NovoProduto);
            return RedirectToAction("Index");

        }
        //atualizar

        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            ViewBag.ProdutoAtualizar = cardapio.getTodosProdutos().Where(x => x.ProID == id).FirstOrDefault();
            return View();
        }

        [HttpPost]
        public IActionResult Atualizar(string codigo, string nome, string descricao, double preco, int CategoriaProduto)
        {

            CategoriaProdutoView AtualizarProduto = new CategoriaProdutoView();
            AtualizarProduto.ProID = Convert.ToInt32(codigo);
            AtualizarProduto.NomeProduto = nome;
            AtualizarProduto.DescricaoProduto = descricao;            
            AtualizarProduto.PrecoProduto = preco;
            AtualizarProduto.CategoriaProduto = CategoriaProduto;
            cardapio.UptdateProdutos(AtualizarProduto);

            return RedirectToAction("Index");
        }
        //apagar
        [HttpGet]
        public IActionResult Apagar(string id)
        {

            CategoriaProdutoView apagarproduto = new CategoriaProdutoView();
            apagarproduto.ProID = Convert.ToInt32(id);
            cardapio.ApagarProdutos(apagarproduto);

            return RedirectToAction("Index");
        }
    }
}
