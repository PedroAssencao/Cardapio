use cardapio;
select * from empresa;
select * from categoria;
insert Categoria (Nome, CategoriaDescricao, CategoriaFoto) values ('Petisco', 'Para comer antes do prato principal', 'https://cdn-icons-png.flaticon.com/512/3063/3063327.png');
insert Categoria (Nome, CategoriaDescricao, CategoriaFoto) values ('Bebidas', 'Para refrescar a garganta', 'https://cdn-icons-png.flaticon.com/512/5821/5821449.png');
insert Categoria (Nome, CategoriaDescricao, CategoriaFoto) values ('Drinks', 'Algo um pouco mais forte', 'https://cdn-icons-png.flaticon.com/512/3201/3201936.png');
insert Categoria (Nome, CategoriaDescricao, CategoriaFoto) values ('Almoço', 'Para recarregar as energias', 'https://cdn-icons-png.flaticon.com/512/2082/2082045.png');
insert Categoria (Nome, CategoriaDescricao, CategoriaFoto) values ('Sobremesa', 'Para sentir o gosto doce das coisas', 'https://cdn-icons-png.flaticon.com/512/5347/5347946.png');
insert Categoria (Nome, CategoriaDescricao, CategoriaFoto) values ('Massas', 'Deliciosos para qualquer hora do dia', 'https://cdn-icons-png.flaticon.com/512/2082/2082045.png');
insert Categoria (Nome, CategoriaDescricao, CategoriaFoto) values ('Hamburguer', 'Diversos gostos para todo mundo', 'https://cdn-icons-png.flaticon.com/512/706/706944.png');
insert Categoria (Nome, CategoriaDescricao, CategoriaFoto) values ('Pizza', 'Simples, porém saborosa', 'https://cdn-icons-png.flaticon.com/512/1404/1404945.png');


ALTER TABLE Empresa
MODIFY COLUMN Telefone varchar(100);