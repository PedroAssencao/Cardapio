create database Cardapio;
use Cardapio;

Create table Categoria
(
CategoriaID int primary key auto_increment,
Nome varchar(100) not null,
    CategoriaDescricao varchar(100) not null,
    CategoriaFoto varchar(999) null
);

create table Perfil(
    Per_Nome varchar(255) primary key
);

Create table Empresa
(
	EmpresaID int primary key auto_increment,
    Telefone varchar(255),
    NomeEmpresa varchar(100),
    SenhaEmpresa varchar(100),
    FotoEmpresa varchar(999) default null,
    CNPJ varchar(14),
    taxaEmpresa double,
    Perfil_Empresa varchar(255) not null,
    Constraint FK_Perfil foreign key (Perfil_Empresa) references Perfil(Per_Nome)
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

insert Perfil values ('MASTER');
insert Perfil values ('EMPRESS');
insert into Empresa (EmpresaID, Telefone, NomeEmpresa, SenhaEmpresa, FotoEmpresa, CNPJ, taxaEmpresa, Perfil_Empresa) values (null, null, 'master', 'bWFzdGVyQDEyM0AxMjM=', null, null, null, 'MASTER');
/*insert into Empresa (EmpresaID, Telefone, NomeEmpresa, SenhaEmpresa, FotoEmpresa, CNPJ, taxaEmpresa, Perfil_Empresa) values (null, null, 'pedro', 'bWFzdGVyQDEyM0AxMjM=', null, null, null, 'EMPRESS');*/
/*insert into Empresa (EmpresaID, Telefone, NomeEmpresa, SenhaEmpresa, FotoEmpresa, CNPJ, taxaEmpresa, Perfil_Empresa) values (null, null, 'mario', 'bWFzdGVyQDEyM0AxMjM=', null, null, null, 'DEFAULT');*/

select * from empresa;
Select * from Categoria;
select * from Produto;
select * from Perfil;
 
 
 




