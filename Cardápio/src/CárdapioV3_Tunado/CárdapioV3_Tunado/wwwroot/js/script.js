var carrinho = [];
var categorias = document.getElementsByClassName("categoria");
var produtos = document.getElementsByClassName("produtos");
var btnVoltar = document.getElementById("btn-voltar");
var tabelaPedidos = document.getElementById("tabela-pedidos");
var telaFinalizarPedido = document.getElementById("FinalizarPedido");

window.addEventListener("DOMContentLoaded", () => {
    btnVoltar.style.display = "none";
    telaFinalizarPedido.style.display = "none";
})

function mostrarBotaoVoltar() {
    $("#btn-voltar").show()
}

for (var i = 0; i < categorias.length; i++) {
    categorias[i].addEventListener("click", function () {
        ocultarCategorias();
        mostrarProdutos(this.nextElementSibling);
        mostrarBotaoVoltar();
    });
}

function btnVoltarF() {
    mostrarCategorias();
    ocultarProdutos();
    ocultarBotaoVoltar();
};

function mostrarCategorias() {
    for (var i = 0; i < categorias.length; i++) {
        categorias[i].style.display = "block";
    }
}

function ocultarCategorias() {
    for (var i = 0; i < categorias.length; i++) {
        categorias[i].style.display = "none";
    }
}

function ocultarProdutos() {
    for (var i = 0; i < produtos.length; i++) {
        produtos[i].style.display = "none";
    }
}

function mostrarProdutos(produtosCategoria) {
    produtosCategoria.style.display = "block";
}

function ocultarTabela() {
    document.getElementById("FinalizarPedido").style.display = "block";
    document.getElementById("TabelaPedido").style.display = "none";
}

function ocultarBotaoVoltar() {
    btnVoltar.style.display = "none";
    telaFinalizarPedido.style.display = "none";
}

function ocultarTabela() {
    var tabelaProdutos = document.querySelector(".produtos");
    tabelaProdutos.style.display = "none";
}

function ocultarTabela() {

    $(".produtos").hide();
    $("#FinalizarPedido").show();
}

function exibirProdutoSelecionado(idProduto, id) {
    $("#produto-selecionado").empty();
    var nomeProduto = document.getElementById("nome-produto-" + idProduto)?.textContent;
    var precoProduto = parseFloat(document.getElementById("preco-produto-" + idProduto)?.textContent.replace(',', '.'));
    var precoAnterior = 0;
    var index = carrinho.findIndex(item => item.proID === idProduto);
    if (index !== -1) {
        precoAnterior = carrinho[index].precoProduto;
    }

    var quantidade = $("#quantidade" + id + " option:selected").val();
    adicionarAoCarrinho(idProduto, precoProduto, nomeProduto, precoAnterior, quantidade);

    var produtoSelecionado = document.getElementById("produto-selecionado");
    var html = "";

    var somaProdutos = 0;
    for (var i = 0; i < carrinho.length; i++) {
        var item = carrinho[i];
        var precoTotal = parseFloat(item.precoProduto) * parseFloat(item.quantidade);
        somaProdutos += precoTotal;
        html +=
            "<div id='" + "produto-" + i + "' class='ScroolBAr container card bg-Emphasis mb-2'>" +
            "<div class='d-flex justify-content-between align-items-center'>" +
            "<span>" + item.nomeProduto + " x " + item.quantidade + " = R$" + precoTotal.toFixed(2) + "</span>" +
            "<button class='btn btn-danger rounded-2 btn_produto' style='margin-left:20px;' onclick='event.preventDefault(); removerItemDoCarrinho(" + i + ");'>X</button></div>" +
            "</div>" + "</div>";
    }
    var taxaString = "@Model.Lista1.First().Taxa";

    taxaString = taxaString.replace(',', '.');


    var taxa = parseFloat(taxaString);

    var divSomaProdutos = document.getElementById("total-da-soma-dos-valores");
    divSomaProdutos.textContent = "Total: R$" + somaProdutos.toFixed(2);

    var divSomaProdutos = document.getElementById("taxaTela");
    divSomaProdutos.textContent = "Taxa de entrega: R$" + taxa.toFixed(2);

    produtoSelecionado.innerHTML = html;
}

async function removerItemDoCarrinho(index) {
    carrinho.splice(index, 1);
    await salvarNoLocalStorage("carrinho", carrinho);
    atualizarValorTotal();

    $("#produto-" + index).remove();


    $(".btn_produto").each(function (i, object) {
        var element = $(this);
        var currentIndex = element.closest(".ScroolBAr").attr("id").split("-")[1];
        if (currentIndex > index) {
            var newId = currentIndex - 1;
            element.closest(".ScroolBAr").attr("id", "produto-" + newId);
            element.attr("onclick", "event.preventDefault(); removerItemDoCarrinho(" + newId + ");");
        }
    });
}


function atualizarValorTotal() {
    var somaProdutos = 0;
    for (var i = 0; i < carrinho.length; i++) {
        var item = carrinho[i];
        var precoTotal = parseFloat(item.precoProduto) * parseFloat(item.quantidade);
        somaProdutos += precoTotal;
    }

    var divSomaProdutos = document.getElementById("total-da-soma-dos-valores");
    divSomaProdutos.textContent = "Total: R$" + somaProdutos.toFixed(2);
}

var btnAdicionarItem = document.getElementById("btn-adicionar-item");

btnAdicionarItem.addEventListener("click", function () {
    document.getElementById("FinalizarPedido").style.display = "none";
    document.getElementById("produtoscat@item.CategoriaProduto").style.display = "block";
});

function salvarNoLocalStorage(nome, valor) {
    localStorage.setItem(nome, JSON.stringify(valor));
}

function lerDoLocalStorage(nome) {
    return JSON.parse(localStorage.getItem(nome));
}

function allStorage() {

    var values = [],
        keys = Object.keys(localStorage),
        i = keys.length;

    while (i--) {
        values.push(localStorage.getItem(keys[i]));
    }

    return values;
}

function varrer(nome, valor) {
    var carrinho = JSON.parse(allStorage()[1]); // lembrar de mudar para 0
    var string = "";
    var nome = $("#InputNome").val()
    var endereco = $("#InputEndereco").val()
    var telefone = $("#InputNTelefone").val().replace(/[()+\-]/g, '');
    var observacao = $("#observacao").val()
    var complemento = $("#InputComplemento").val()
    var Bairro = $("#InputBairro").val()
    var ptnReferencia = $("#InputReferencia").val()
    var html = "";
    for (var i = 0; i < carrinho.length; i++) {
        console.log(carrinho[i].precoProduto)
        var item = carrinho[i];
        html += item.nomeProduto +
            " x " + item.quantidade + " = R$" + (parseFloat(item.precoProduto) * parseFloat(item.quantidade)).toFixed(2) + "\n";
    }
    console.log(varrer)

    var e = $("#FormaDePagamento option:selected").text();

    for (var i = 0; i < carrinho.length; i++) {
        var carrinho = JSON.parse(allStorage()[1]) //lembrar de mudar para 0
        string += "\n" + carrinho[i]["nomeProduto"]
    }
    var nomeEmpresa = '(@Model.Lista1.First().NomeEmpresa)'
    var horaPedido = '(@Model.Lista1.First().PedDataPedido.ToString("dd/MM/yyyy"))'
    var idpedido = '(@Model.Lista1.First().PedID)'
    var numero = '@(Model.Lista1.First().Telefone.Replace("(", "").Replace(")", "").Replace("+", "").Replace("-", "").Replace(" ", ""))';
    var preco = 0.00
    for (var i = 0; i < carrinho.length; i++) {
        var item = carrinho[i];
        preco += parseFloat(carrinho[i].precoProduto) * parseFloat(carrinho[i].quantidade)
    }


    var taxa = parseFloat("@Model.Lista1.First().Taxa")
    var novopreco = parseFloat(preco)
    var resultado = taxa + novopreco
    var idempresa = @ViewBag.Empresaid
        var idsdosprodutos = carrinho.map(objeto => objeto.proID);

    $.ajax({
        url: '@Url.ActionLink("CriarPedido", "Pedidos")',
        method: 'POST',
        data: {
            NomeCliente: nome,
            EnderecoCliente: endereco,
            TelefoneCliente: telefone,
            DataPedido: '@DateTime.Now.ToString("dd-MM-yyyy")',
            EmpresaID: @ViewBag.EmpresaID,
    TipoPagamento: e,
        Produtos: idsdosprodutos,
            empresaids: idempresa
} ,
success: function (batata) {
    var data = batata[0]
    var idpid = batata[1]




    var mensagem = "\n" + "*✏PEDIDO Nº* " + idpid + " \n" +
        "Realizado em " + data +
        "\n" + "- - - - - - - - - - - - - - - - - - - - - - - - - - -" + "\n" +
        "\n" + "📣Delivery - " + nomeEmpresa + "\n" +
        "\n" + "- - - - - - - - - - - - - - - - - - - - - - - - - - -" + "\n" +
        " \n" + "👥 *CLIENTE* \nNome:  " + nome + " \n" +
        "*Endereço:  " + endereco + " \n" +
        "*Complemento:  " + complemento + "  \n" +
        "bairro:" + Bairro + "  \n" +
        "Ponto de Referencia:" + ptnReferencia + "  \n" +
        "*Telefone:" + telefone + "  \n" +
        "\n" + "- - - - - - - - - - - - - - - - - - - - - - - - - - -" + "\n" +
        " \n*📝 RESUMO DO PEDIDO* \n" +
        "Produto: " + "\n" + html +
        "\nObservação: " + observacao + "\n" +
        "\n" + "- - - - - - - - - - - - - - - - - - - - - - - - - - -" + "\n" +
        "\n*💵DADOS DE PAGAMENTO*" + "\n" +
        "Forma de pagamento: " + "" + e + "\n" +
        "Preço do produto(s) R$ " + parseFloat(preco).toFixed(2) + "\n" +
        "Taxa de entrega: @Model.Lista1.First().Taxa" + "\n" +
        "Valor total R$: " + resultado.toFixed(2)



    var link = "https://api.whatsapp.com/send?phone=" + numero + "&text=" + encodeURIComponent(mensagem);



    window.open(link, "_blank");
}


            })
        }

function adicionarAoCarrinho(proID, precoProduto, nomeProduto, precoAnterior, quantidade) {
    var item = {
        proID: proID,
        precoProduto: precoProduto,
        nomeProduto: nomeProduto,
        precoAnterior: precoAnterior,
        quantidade: quantidade
    };
    carrinho.push(item);
    salvarNoLocalStorage("carrinho", carrinho);
}

var inputNome = document.getElementById('InputNome');
var inputEndereco = document.getElementById('InputEndereco');
var inputNTelefone = document.getElementById('InputNTelefone');


function validarCampos() {
    if (inputNome.value.trim() === '') {
        alert('Por favor, preencha o campo Nome.');
        return false;
    }

    if (inputEndereco.value.trim() === '') {
        alert('Por favor, preencha o campo Endereço.');
        return false;
    }

    if (inputNTelefone.value.trim() === '') {
        alert('Por favor, preencha o campo Número de Telefone.');
        return false;
    }

    return true;
}

var form = document.getElementById('FinalizarPedido');
form.addEventListener('submit', function (event) {
    if (!validarCampos()) {
        event.preventDefault();
    }
});


const arrow = document.querySelector('.arrow');
const complementoDiv = document.getElementById('complementoDiv');
const bairroDiv = document.getElementById('bairroDiv');
const referenciaDiv = document.getElementById('referenciaDiv');


arrow.addEventListener('click', function () {

    complementoDiv.classList.toggle('hidden');
    bairroDiv.classList.toggle('hidden');
    referenciaDiv.classList.toggle('hidden');
});

document.addEventListener('DOMContentLoaded', function () {
    var arrow = document.querySelector('.arrow');

    arrow.addEventListener('click', function () {
        arrow.classList.toggle('rotate');
    });
});

