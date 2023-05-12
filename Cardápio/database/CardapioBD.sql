create database Cardapio;
use Cardapio;

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
EmpresaID int,
CategoriaID int,
    Constraint FK_CategoriaProduto foreign key (CategoriaID) references Categoria(CategoriaID),
    Constraint FK_EmpresaID foreign key (EmpresaID) references Empresa(EmpresaID)
    
);


Create table Empresa
(
	EmpresaID int primary key auto_increment,
    Telefone varchar(13),
    NomeEmpresa varchar(100),
    SenhaEmpresa varchar(100),
    FotoEmpresa varchar(999),
    CNPJ varchar(14),
    taxaEmpresa double
);

select * from empresa;
Select * from Categoria;
select * from Produto;

Select distinct c.CategoriaID, c.CategoriaDescricao from produto
join categoria c
where idEmpresa;

select distinct categorias.categoriaID, categorias.nome  from produto produtos join categoria categorias on produtos.categoriaID=categorias.categoriaID where EmpresaID=1;
 
select produtos.*,categorias.*, empresas.*  from produto produtos join categoria categorias on produtos.categoriaID=categorias.categoriaID join Empresa empresas on produtos.EmpresaID=empresas.EmpresaID where empresas.EmpresaID=1;
 
 
 




