 create database Cardapio;
use Cardapio;
drop database Cardapio;

Create table Categoria
(
CategoriaID int primary key auto_increment,
Nome varchar(100) not null,
    CategoriaDescricao varchar(100) not null,
    CategoriaFoto varchar(999) null
);

Create table Produto
(
ProID int primary key auto_increment,
NomeProduto varchar(250) not null,
DescricaoProduto varchar(250) not null,
NutricaoProduto varchar(500) null,
PrecoProduto double not null,
CategoriaFoto varchar(999) null,
CategoriaProduto int,
    Constraint FK_CategoriaProduto foreign key (CategoriaProduto) references Categoria(CategoriaID)
);


Create table Empresa
(
	EmpresaID int primary key auto_increment,
    Telefone varchar(13),
    NomeEmpresa varchar(100),
    SenhaEmpresa varchar(100),
    CNPJ varchar(14),
    taxaEmpresa double
);

Create table ProdutoEmpresa
(
	EmpresaID int,
    ProdutoID int,
    CategoriaID int,
    Constraint FK_EmpresaID foreign key (EmpresaID) references Empresa(EmpresaID),
    Constraint FK_ProdutoID foreign key (ProdutoID) references Produto(ProID),
    Constraint FK_CategoriaID foreign key (CategoriaID) references Categoria(CategoriaID)
);

select * from produtoempresa;
select * from empresa;
Select * from Categoria;
select * from Produto;






