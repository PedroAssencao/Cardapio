

    var categorias = document.getElementsByClassName("categoria");
    var produtos = document.getElementsByClassName("produtos");
    var btnVoltar = document.getElementById("btn-voltar");

    for (var i = 0; i < categorias.length; i++) {
        categorias[i].addEventListener("click", function () {
            ocultarCategorias();
            mostrarProdutos(this.nextElementSibling);
            mostrarBotaoVoltar();
        });
    }

    btnVoltar.addEventListener("click", function () {
        mostrarCategorias();
    ocultarProdutos();
    ocultarBotaoVoltar();
    });

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

    function mostrarProdutos(produtosCategoria) {
        produtosCategoria.style.display = "block";
    }

    function ocultarProdutos() {
        for (var i = 0; i < produtos.length; i++) {
        produtos[i].style.display = "none";
        }
    }

    function mostrarBotaoVoltar() {
        btnVoltar.style.display = "block";
    }

    function ocultarBotaoVoltar() {
        btnVoltar.style.display = "none";
    }

    function enviarMensagem(id) {
        var numero = "5579998468046";
    var quantidade = document.getElementById("quantidade").value;
    var produto = document.getElementById(id).textContent.trim();
    var mensagem = "Olá, gostaria de pedir " + quantidade + " " + produto + "(s)";
    var link = "https://api.whatsapp.com/send?phone=" + numero + "&text=" + encodeURIComponent(mensagem);
    window.open(link, "_blank");
    }
