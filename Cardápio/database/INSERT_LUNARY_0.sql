
use cardapio;


insert into empresa (Telefone, NomeEmpresa, SenhaEmpresa, FotoEmpresa, CNPJ, taxaEmpresa) values ('5579998881750','Lunary', 'MTIzNDU2Nzg5', '/Images/1empresa_1.png', '99999999999999', 10.00);
insert into categoria (Nome, CategoriaDescricao, CategoriaFoto) values ('Petiscos', 'Otimas escolhas para antes do prato principal', 'https://cdn-icons-png.flaticon.com/512/3063/3063327.png');
insert into categoria (Nome, CategoriaDescricao, CategoriaFoto) values ('Almoço', 'Otimas escolhas de prato principal', '   https://cdn-icons-png.flaticon.com/512/2082/2082045.png ');
insert into categoria (Nome, CategoriaDescricao, CategoriaFoto) values ('bebidas', 'Experimente nossas opções geladas e saborosas!', '   https://cdn-icons-png.flaticon.com/512/5821/5821449.png ');












;
select * from categoria;
select * from  produto;
select * from empresa;




insert produto(NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto) values ('Calabresa na Cachaça',28.90, 1, 1, 'Calabresa feita com cachaça', 'Proteinas e Gorduras');  
insert produto(NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto) values ('Calabresa Espiral',34.90,1, 1,'Calabresa feita em espiral','Proteinas e Gorduras');
insert produto(NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto) values ('Brochete Frango(Espeto)',13.90, 1, 1, 'Brochete de frango servido no espetinho','proteinas e gorduras');
insert produto(NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto) values ('Brochete Carne(C/Barbecue Espeto)',15.90,1, 1, 'Brochete de carne com barbecue servido no espetinho','Proteinas e Gorduras');

insert produto(NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto) values ('Costela De Porco(Barbecue)',44.90,1, 1, 'Costela de porco assada servida com barbecue', 'Proteinas, Gorduras e Carboidratos');
insert produto(NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)  values ('Picanha Fatiada C/P o De Alho',58.90, 1 , 1, 'Picanha fatiada com molho de alho','Proteinas, Corduras e Carboidratos');
insert produto(NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)  values ('Carne Do Sol',35.90,1, 1, 'Carne do sol frita acebolada','proteinas e gorduras');
insert produto(NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto) values ('Carne Do Sol(C/Macaxeira ou Fritas)',42.90, 1, 1, 'Carne do sol acebolada acompanhada de macacheira ou fritas','Carboidratos e Proteinas');
insert produto(NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto) values ('Carne Do Sol Na Nata',46.90, 1, 1, 'Carne do sol acebolada na nata', 'Carboidratos e gorduras' );
insert produto(NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto) values ('Filezinho Aperitivo',41.90, 1, 1,'Feito em Molho Madeira,Torradas ou Fritas ou Macaxeira', 'Gorduras e Proteinas');
insert produto(NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto) values ('Filezinho Molho De Queijo',44.90,1,1,'File de Carne servido com queijo','Carboidratos e Proteinas');
insert produto(NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto) values ('Filé  De Frango Na Pedra',41.90, 1, 1,'Uma deliciosa opção de frango grelhado, preparado na pedra quente, resultando em um filé suculento e saboroso','Carboidratos e proteinas');

insert produto(NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto) values ('Caldinho De Feijão',7.90, 1, 1, 'Caldinho feito de feijão','Carboidratos');
insert produto(NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto) values ('Caldinho De Frutos Do Mar',10.90, 1, 1,'Caldinho Feito especialmente de frutos do mar','Carboidratos e Gorduras');
insert produto(NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto) values ('Bolinho De Carne Do Sol C/Calabresa',18.90, 1, 1,'Bolo feito de carne do sol','Carboidratos e proteinas');
insert produto(NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto) values ('Bolinho De Bacalhau',24.90, 1, 1,'Bolo feito de bacalhau','Proteinas, Carboidratos e gorduras');
insert produto(NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto) values ('Bolinho De Peixe',24.90, 1,1,'Bolo da carne de peixes', 'Proteinas, carboidratos, e gorduras');
insert produto(NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto) values ('Bolinho De Aratu',25.90, 1, 1,'O bolinho de aratu é uma iguaria deliciosa, feito com carne de caranguejo, temperos especiais e frito até ficar crocante e saboroso','carboidratos e proteinas' );
insert produto(NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)  values ('Bolinho De Bob  De Camarão',25.90,1, 1,'O "Bolinho de Bob de Camarão" é um petisco delicioso feito com camarão e temperos especiais, perfeito para saborear','carboidratos, proteinas e gorduras');
insert produto(NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)  values ('Queijo a Milanesa',21.90, 1, 1,'O "Queijo a Milanesa" é um petisco crocante e saboroso, feito com queijo empanado e frito, ideal para os amantes de queijo','carboidratos');
insert produto(NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto) values ('Macaxeira Frita',10.90, 1, 1,'A "Macaxeira Frita" é um delicioso petisco feito com mandioca cortada em formato de palitos e frita até ficar crocante','Carboidratos');
insert produto(NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto) values ('Batata Frita','14.90',1,1,'Descasque e corte as batatas em palitos. Aqueça o óleo. Frite as batatas até dourarem. Escorra e tempere. Sirva crocantes.','Carboidratos e gorduras');
insert produto(NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto) values ('Batatinha Especial',9.90,1,1,'A "Batatinha Especial" é um petisco irresistível composto por batatas fritas acompanhadas de irresistíveis coberturas como cheddar e bacon, proporcionando um sabor incrível','carboidratos e gorduras');
insert produto(NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto) values ('Batatinha Boa Da Pága',25.90,1,1,'A "Batatinha Boa Da Pága" é um delicioso petisco de batatas fritas cobertas com calabresa e muçarela derretida, garantindo um sabor irresistível e uma experiência única.','carboidratis e gorduras');
INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('KIBE', '18.90', 1, 1, 'Delicioso kibe frito recheado com carne moída temperada.', 'Proteínas e carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Camarão C/Catupiry Na Tapioca', '34.90', 1, 1, 'Tapioca recheada com camarão e catupiry, uma combinação irresistível.', 'Proteínas e carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Frango a Passarinho', '32.90', 1, 1, 'Deliciosos pedaços de frango frito, ideais para compartilhar.', 'Proteínas e carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Coxinha de Asa', '23.90', 1, 1, 'Coxinhas de frango empanadas e fritas, perfeitas para petiscar.', 'Proteínas e carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Codorna', '12.90', 1, 1, 'Codornas fritas, uma opção saborosa para degustar.', 'Proteínas e carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Isca De Frango', '29.90', 1, 1, 'Deliciosas iscas de frango crocantes e suculentas.', 'Proteínas e carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Isca De Peixe', '34.50', 1, 1, 'Deliciosa isca de peixe crocante.', 'Proteínas e carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Arrumadinho Tradicional', '36.90', 1, 1, 'Tradicional prato de arrumadinho.', 'Proteínas e carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Arrumadinho De Aratu', '41.90', 1, 1, 'Delicioso arrumadinho com sabor de Aratu.', 'Proteínas e carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Camarão Milanesa', '44.90', 1, 1, 'Camarão empanado e frito à milanesa.', 'Proteínas e carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Camarão Na (F.) Panka', '46.90', 1, 1, 'Camarão preparado com panko crocante.', 'Proteínas e carboidratos');


INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Camarão Alho e Óleo', 44.90, 1, 1, 'Delicioso camarão preparado com alho e óleo, perfeito para os amantes de frutos do mar.', 'Proteínas e carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Camarão Crocante Praia Do Abaís', 47.90, 1, 1, 'Camarão crocante com um sabor irresistível, ideal para acompanhar momentos de descontração.', 'Proteínas e carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Camarão Praia Do Saco', 47.90, 1, 1, 'Camarão preparado no estilo tradicional da praia do Saco, com um toque especial de sabor e frescor.', 'Proteínas e carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Peixe Frito (Posta)', 52.90, 1, 1, 'Deliciosa posta de peixe frito, crocante por fora e suculenta por dentro, uma verdadeira explosão de sabores.', 'Proteínas e carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Peixe Frito (Inteiro)', 49.90, 1, 1, 'Peixe inteiro frito, perfeito para compartilhar com amigos e família em uma refeição deliciosa.', 'Proteínas e carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Aguilhinha Frita (Sob Consulta)', 31.90, 1, 1, 'Aguilhinha frita, um petisco saboroso e crocante que vai conquistar o seu paladar. Consulte disponibilidade.', 'Proteínas e carboidratos');


INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Guaiamum(M)', '8.90', 1, 1, 'Guaiamum de tamanho médio', 'Proteínas e carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Guaiamum(G)', '14.90', 1, 1, 'Guaiamum de tamanho grande', 'Proteínas e carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Caranguejo', '5.50', 1, 1, 'Caranguejo fresco', 'Proteínas e carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Pastel De Carne', '6.90', 1, 1, 'Delicioso pastel recheado com carne', 'Proteínas e carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Pastel Frango', '6.50', 1, 1, 'Saboroso pastel recheado com frango', 'Proteínas e carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Frango C/Catupiry', '7.50', 1, 1, 'Suculento pastel de frango com catupiry', 'Proteínas e carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Pastel De Queijo', '6.50', 1, 1, 'Delicioso pastel recheado com queijo', 'Proteínas e carboidratos');
INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Pastel De Aratu', '8.50', 1, 1, 'Delicioso pastel recheado com carne de aratu', 'Proteínas e carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Pastel De Pizza', '6.90', 1, 1, 'Saboroso pastel com recheio de pizza', 'Proteínas e carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Pastel Romeu e Julieta', '6.90', 1, 1, 'Combinação irresistível de queijo e goiabada em um pastel', 'Proteínas e carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Pastel De Carne De Costela', '7.50', 1, 1, 'Delicioso pastel recheado com carne de costela', 'Proteínas e carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Pastel De Camarão', '9.90', 1, 1, 'Delicioso pastel recheado com camarão', 'Proteínas e carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Mini Pastel de Camarão C/Cream Cheese', '18.90', 1, 1, 'Mini pastéis recheados com camarão e cream cheese', 'Proteínas e carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Mini Pastel de Salmão C/Cream Cheese', '21.90', 1, 1, 'Mini pastéis recheados com salmão e cream cheese', 'Proteínas e carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Mini Pastel de Costela C/Queijo', '17.90', 1, 1, 'Mini pastéis recheados com costela e queijo', 'Proteínas e carboidratos');


insert produto(NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto) values 
('FILÉ  DE FRANGO   CUBANA', 66.90, 2, 1, 'Filé de frango cubana: suculento, temperado, grelhado. Combinação de sabores intensos, especiarias cubanas. Delícia para os fãs de frango com um toque exótico.','Proteinas e Carboidratos');

insert produto(NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto) values 
('FILÉ DE FRANGO   PARMEGIANA', 66.90,2,1, 'Filé de frango à parmegiana: frango empanado, coberto com molho de tomate e queijo derretido. Clássico italiano delicioso e reconfortante.','Proteinas e Carboidratos');

insert produto(NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto) values 
('FILÉ  DE FRANGO COM FRITAS', 66.90,2,1, 'Filé de frango com fritas: suculento filé de frango grelhado acompanhado de batatas fritas crocantes. Uma opção saborosa e popular.','Proteinas e Carboidratos');

insert produto(NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto) values 
('FILÉ  DE FRANGO COM LEGUMES', 66.90,2,1, 'Filé de frango com legumes: delicioso filé de frango grelhado servido com uma variedade de legumes frescos e crocantes. Uma opção saudável e nutritiva.','Proteinas e Carboidratos');

insert produto(NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto) values 
('FILÉ DE FRANGO AO LUNARY', 66.90,2,1, 'Filé de frango ao lunar: suculento filé de frango preparado com um delicioso molho lunar, trazendo um sabor único e irresistível.', 'Proteinas e carboidratos');

insert produto(NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto) values 
('MEDALHÃO DE FRANGO AO MOLHO MADEIRA', 68.90, 2,1, 'Medalhão de frango ao molho madeira: suculentos medalhões de frango grelhados e cobertos com um delicioso molho madeira encorpado e aromático.', 'Proteinas e carboidratos');

insert produto(NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto) values 
('FILÉ  FRANGO NA PEDRA', 66.90,2,1, 'Filé de frango na pedra: suculentos pedaços de filé de frango grelhados e servidos sobre uma pedra quente para manter a temperatura e realçar o sabor.', 'Proteinas e Carboidratos');



insert produto(NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto) values 
('FILÉ   CUBANA', 77.90,2,1, 'Filé à Cubana: um prato delicioso que consiste em um filé de carne grelhado, acompanhado de banana frita e arroz.', 'Proteinas e Carboidratos');

insert produto(NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto) values
('FILE   PARMEGIANA', 77.90,2,1, 'Filé à Parmegiana: um clássico da culinária italiana, feito com filé de carne empanado, coberto com molho de tomate e queijo derretido.', 'Proteinas e Carboidratos');

insert produto(NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto) values  
('FILÉ    CAVALO', 77.90,2,1, 'GRELHADO, BATATA FRITA, ARROZ, FEIJ O, FAROFA, SALADA, OVO', 'Proteinas e Carboidratos');

insert produto(NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto) values  
('FILÉ  COM FRITAS', 77.90,2,1, 'Filé com fritas é um prato clássico composto por um suculento filé de carne acompanhado de batatas fritas crocantes.','Proteinas, Carboidratos e gorduras');

insert produto(NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto) values  
('FILÉ  COM LEGUMES', 77.80,2,1, 'Filé com legumes é uma deliciosa combinação de carne macia e suculenta acompanhada de vegetais frescos e crocantes.','Proteinas e Carboidratos');

INSERT INTO produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('MEDALHÃO C/ LINGUINE AO M.QUEIJO', '82.90', 2, 1, 'MEDALHÃO DE FILÉ, BACON, MOLHO MADEIRA, LINGUINE M, QUEIJO', 'Proteinas e carboidratos');

INSERT produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('MEDALHÃO AO MOLHO MADEIRA', '79.90', 2, 1, 'MEDALHÃO DE FILÉ, BACON, FEIJÃO, ARROZ À GREGA, MOLHO MADEIRA', 'Proteinas e carboidratos');


INSERT INTO produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('MEDALHÃO AO MOLHO CABERNET', '82.90', 2, 1, 'MEDALHÃO DE FILÉ, M.CABERNET, ARROZ PIOMONTESE, BATATAS', 'Proteinas e carboidratos');

INSERT INTO produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('PICANHA NA PEDRA', '79.90', 2, 1, 'GRELHADO, MACAXEIRA OU FRITAS, FEIJÃO TROPEIRO, ARROZ, VINAGRETE, FAROFA', 'Proteinas e carboidratos');

INSERT INTO produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('CARNE DO SOL MODA DA CASA', '79.90', 2, 1, 'GRELHADA, MACAXEIRA OU FRITAS, BAIÃO DE DOIS, FAROFA, VINAGRETE', 'Proteinas e carboidratos');

INSERT INTO produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('MIX DE GRELHADOS', '77.90', 2, 1, 'BOI, FRANGO, TOSCANA, BAIÃO DE DOIS, MACAXEIRA OU FRITAS, FAROFA, VINAGRETE', 'Proteinas e carboidratos');

INSERT INTO produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('CARNE DO SOL C/ PIRÃO DE LEITE', '77.90', 2, 1, 'GRELHADO, PIRÃO DE LEITE, FEIJÃO TROPEIRO, ARROZ, FRITAS OU MACAXEIRA, FAROFA, VINAGRETE', 'Proteinas e carboidratos');

INSERT INTO produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('CUPIM NA CHAPA', '77.90', 2, 1, 'AO FORNO, SELADO NA MANTEIGA DE GARRAFA, FEIJÃO TROPEIRO, ARROZ, FAROFA, VINAGRETE, FRITAS OU MACAXEIRA', 'Proteinas e carboidratos');

INSERT INTO produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('MEDALHÃO AO MOLHO DE QUEIJO', '82.90', 2, 1, 'GRELHADO, MOLHO DE QUEIJO, ARROZ DE BRÓCOLIS, BATATA FRITA', 'Proteinas e carboidratos');
----------------

INSERT INTO produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Peixe Frito', '76.90', 2, 1, 'POSTA DE PEIXE FRITO, ARROZ, FEIJÃO, VINAGRETE, FAROFA', 'Proteinas e carboidratos');

INSERT INTO produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Peixe ao Molho de Camarão', '86.90', 2, 1, 'POSTA DE PEIXE FRITO, MOLHO DE TOMATE COM CAMARÃO, ARROZ, FEIJÃO, VINAGRETE, FAROFA', 'Proteinas e carboidratos');

INSERT INTO produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Peixe Escabeche', '79.90', 2, 1, 'POSTA DE PEIXE FRITO, MOLHO ESCABECHE, ARROZ, FEIJÃO, FAROFA, VINAGRETE', 'Proteinas e carboidratos');

INSERT INTO produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Filé De Pescada Belle Meuniere', '84.90', 2, 1, 'FILÉ DE PESCADA, CHAMPIGNON, CAMARÃO, ARROZ PIAMONTESE, BATATAS', 'Proteinas e carboidratos');

INSERT INTO produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Filé De Pescada C/Legumes', '82.90', 2, 1, 'FILÉ DE PESCADA, LEGUMES SALTEADOS NA MANTEIGA, ARROZ, SALADA', 'Proteinas e carboidratos');

INSERT INTO produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Salmão Bella Meuniere', '98.90', 2, 1, 'SALMÃO GRELHADO, ALCAPARRAS, CHAMPIGNON, CAMARÃO, ARROZ PIAMONTESE, BATATAS', 'Proteinas e carboidratos');

INSERT INTO produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Chapa De Frutas Do Mar', '98.90', 2, 1, 'SALMÃO, PESCADA, CAMARÃO. PEIXE GRELHADO, LEGUMES SALTEADOS, FRITAS, ARROZ C/ BRÓCOLIS, FAROFA', 'Proteinas e carboidratos');

INSERT INTO produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Chapa Terra e Mar', '94.90', 2, 1, 'BOI, FRANGO, CAMARÃO, PEIXE GRELHADO, LEGUMES SALTEADOS, FRITAS, ARROZ C/ BRÓCOLIS, FAROFA', 'Proteinas e carboidratos');


INSERT INTO produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Peixe Frito C/Molho De Camarão Porto De Areia', '92.90', 2, 1, 'PEIXE FRITO INTEIRO, MOLHO DE CAMARÃO NO COCO, ARROZ, FEIJÃO, VINAGRETE, FAROFA', 'Proteinas e carboidratos');

INSERT INTO produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Filé De Pescada C/Arroz De Aratu', '94.90', 2, 1, 'FILÉ DE PESCADA FRITO, ARROZ DE MOQUECA DE ARATU, VINAGRETE, FAROFA', 'Proteinas e carboidratos');



----------------------------

INSERT INTO produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Moqueca Delicia (Camarão/Aratu)', '86.90', 2, 1, 'CAMARÃO E ARATU NO LEITE DE COCO, DENDÊ, PIRÃO, ARROZ, FAROFA, VINAGRETE', 'Proteinas e carboidratos');

INSERT INTO produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Moqueca De Aratu', '82.90', 2, 1, 'ARATU NO LEITE DE COCO, DENDÊ, PIRÃO, ARROZ, FAROFA, VINAGRETE', 'Proteinas e carboidratos');

INSERT INTO produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Moqueca Trilícia (Camarão/Aratu/Caranguejo)', '86.90', 2, 1, 'CAMARÃO, ARATU E CARANGUEIJO NO LEITE DE COCO, DENDÊ, PIRÃO, ARROZ, FAROFA, VINAGRETE', 'Proteinas e carboidratos');

INSERT INTO produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Moqueca De Caranguejo', '78.90', 2, 1, 'CARANGUEJO NO LEITE DE COCO, DENDÊ, PIRÃO, ARROZ, FAROFA, VINAGRETE', 'Proteinas e carboidratos');

INSERT INTO produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Mariscada', '92.90', 2, 1, 'OSTRA, SURGIU, ARATU, SIRI, CAMARÃO, PEIXE, LULA NO COCO, DENDÊ, PIRÃO, ARROZ, FAROFA, VINAGRETE', 'Proteinas e carboidratos');

INSERT INTO produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Moqueca De Camarão', '86.90', 2, 1, 'CAMARÃO NO LEITE DE COCO, DENDÊ, PIRÃO, ARROZ, FAROFA, VINAGRETE', 'Proteinas e carboidratos');

INSERT INTO produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Pirão De Camarão', '86.90', 2, 1, 'PIRÃO JUNTO C/CAMARÃO NO LEITE DE COCO, DENDÊ, ARROZ, FAROFA, VINAGRETE', 'Proteinas e carboidratos');

INSERT INTO produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Aratu Refogado', '78.90', 2, 1, 'ARATU REFOGADO NA AZEITE E TEMPEROS, ARROZ, FAROFA, VINAGRETE', 'Proteinas e carboidratos');



------

INSERT INTO produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Camarão Internacional', '82.90', 2, 1, 'CAMARÃO AO MOLHO CATUPIRY, CREME DE LEITE, ARROZ AO CREME COM ERVILHA, PRESUNTO, BATATA PALHA', 'Proteinas e carboidratos');

INSERT INTO produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Camarão C/Catupiry Ao Lunary', '78.90', 2, 1, 'CAMARÃO AO MOLHO CATUPIRY, PURÊ GRATINADO, ARROZ BRANCO', 'Proteinas e carboidratos');

INSERT INTO produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Camarão Tropicalissimo', '55.90', 2, 1, 'CAMARÃO FLAMBADO, MOLHO BRANCO CREMOSO, SERVIDO NO ABACAXI', 'Proteinas e carboidratos');

INSERT INTO produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Camarão Parmegiana', '85.90', 2, 1, 'CAMARÃO À MILANESA, ARROZ À GREGA, BATATA PALHA, MOLHO DE TOMATE E QUEIJO', 'Proteinas e carboidratos');

INSERT INTO produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Camarão Grega', '81.90', 2, 1, 'CAMARÃO À MILANESA, ARROZ À GREGA, BATATA PALHA, MOLHO DE TOMATE E QUEIJO', 'Proteinas e carboidratos');
----------------

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Penne ao M.Branco C/Camar o', '59.90', 2, 1, 'MOLHO BRANCO', 'Proteínas e carboidratos');

-- Produto 2
INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Linguine ao M.Queijo C/Camar es Grelhado', '59.90', 2, 1, 'MOLHO BRANCO, REQUEIJÃO CREMOSO, AZEITE DE ERVAS', 'Proteínas e carboidratos');

-- Produto 3
INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Espaguete De Camar o Especial', '62.90', 2, 1, 'AO ALHO E ÓLEO, CAMARÃO, TOMATES SECOS, AZEITONAS, ALCAPARRA, SALSA', 'Proteínas e carboidratos');

-- Produto 4
INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Espaguete a Moda Lunary', '56.90', 2, 1, 'TIRAS DE FILÉ COM MOLHO MADEIRA E CREME DE LEITE', 'Proteínas e carboidratos');

-- Produto 5
INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Arroz De Camar o(invidual)', '43.90', 2, 1, 'REFEIÇÃO', 'Proteínas e carboidratos');

-- Produto 6
INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Arroz De Camar o(P/2 Pessoas', '69.90', 2, 1, 'REFEIÇÃO', 'Proteínas e carboidratos');

----
INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Arroz De Frutos Do Mar(invidual)', '43.90', 2, 1, 'Arroz de Frutos do Mar (individual) - Delicioso prato de arroz com frutos do mar.', 'proteinas, carboidratos e gorduras');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Arroz De Frutos Do Mar(P/2 Pessoas)', '69.90', 2, 1, 'Arroz de Frutos do Mar (para 2 pessoas) - Porção generosa de arroz com frutos do mar.', 'proteinas, carboidratos e gorduras');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Arroz De Fil (invidual)', '39.90', 2, 1, 'Arroz de Filé (individual) - Prato clássico com filés de carne e arroz.', 'proteinas, carboidratos e gorduras');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Arroz De Fil (P/2 Pessoas)', '64.90', 2, 1, 'Arroz de Filé (para 2 pessoas) - Porção generosa de filés de carne com arroz.', 'proteinas, carboidratos e gorduras');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Skol', 6.99, 3, 1, 'Cerveja Skol - Refrescante cerveja brasileira de alta qualidade.', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Brahma D.Malte', '9.90', 3, 1, 'Cerveja Brahma Duplo Malte', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Antarctica', '8.40', 3, 1, 'Cerveja Antarctica', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Brahma', '8.90', 3, 1, 'Cerveja Brahma', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Bohemia', '8.90', 3, 1, 'Cerveja Bohemia', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Brahma D.Malte', '9.90', 3, 1, 'Cerveja Brahma Duplo Malte', 'carboidratos');


------

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('BudWeiser 600ML', '12.90', 3, 1, 'Cerveja Budweiser 600ML', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Original 600ML', '12.90', 3, 1, 'Cerveja Original 600ML', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Spaten 600ML', '12.90', 3, 1, 'Cerveja Spaten 600ML', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Stella Artois 600ML', '13.90', 3, 1, 'Cerveja Stella Artois 600ML', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Beck S 600ML', '15.90', 3, 1, 'Cerveja Beck S 600ML', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Colorado 600ML', '19.90', 3, 1, 'Cerveja Colorado 600ML', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Malzebier', '7.00', 3, 1, 'Cerveja Malzebier', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Cerveja S/ ÁLCOOL', '7.50', 3, 1, 'Cerveja Sem Álcool', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('BudWeiser', '9.50', 3, 1, 'Cerveja BudWeiser', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Stella Artois', '9.90', 3, 1, 'Cerveja Stella Artois', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Corona', '10.50', 3, 1, 'Cerveja Corona', 'carboidratos');


INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Cachaça Mineira', '6.30', 3, 1, 'Cachaça tradicional mineira', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Reserva do Barão', '6.30', 3, 1, 'Cerveja Reserva do Barão', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Ipioca/Pit', '3.50', 3, 1, 'Bebida Ipioca/Pit', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Reserva Do Barão (Garrafa)', '62.00', 3, 1, 'Cerveja Reserva do Barão em garrafa', 'carboidratos');


INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Guaraná', '4.90', 3, 1, 'Refrigerante Guaraná', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Cola-Cola', '4.90', 3, 1, 'Refrigerante Cola-Cola', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Fanta', '4.90', 3, 1, 'Refrigerante Fanta', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Soda', '4.90', 3, 1, 'Refrigerante Soda', 'carboidratos');


INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Guaraná (EM LATA)', '5.00', 3, 1, 'Refrigerante Guaraná em lata', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Cola-Cola (EM LATA)', '5.00', 3, 1, 'Refrigerante Cola-Cola em lata', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Schwepps (EM LATA)', '5.90', 3, 1, 'Refrigerante Schwepps em lata', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Tônica (EM LATA)', '5.90', 3, 1, 'Refrigerante Tônica em lata', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Pepsi/Fanta/Soda (EM LATA)', '5.00', 3, 1, 'Refrigerante Pepsi, Fanta e Soda em lata', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Pepsi Black-Zero (EM LATA)', '5.00', 3, 1, 'Refrigerante Pepsi Black-Zero em lata', 'carboidratos');


INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Old Parr (12 anos)', '14.90', 3, 1, 'Whisky Old Parr 12 anos', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Ballantines (12 anos)', '12.90', 3, 1, 'Whisky Ballantines 12 anos', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Johnnie Red (8 anos)', '11.00', 3, 1, 'Whisky Johnnie Walker Red Label 8 anos', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Cavalo Branco (8 anos)', '9.90', 3, 1, 'Whisky Cavalo Branco 8 anos', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Bell´s', '6.90', 3, 1, 'Whisky Bell´s', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Teacher´s', '6.90', 3, 1, 'Whisky Teacher´s', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Black & White', '7.90', 3, 1, 'Whisky Black & White', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Old Parr (Club Do Whisky) (12 anos)', '210.00', 3, 1, 'Whisky Old Parr Club do Whisky 12 anos', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Chivas (Club Do Whisky) (12 anos)', '190.00', 3, 1, 'Whisky Chivas Club do Whisky 12 anos', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Ballantines (Club Do Whisky) (12 anos)', '170.00', 3, 1, 'Whisky Ballantines Club do Whisky 12 anos', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Jhonnie Red (Club Do Whisky) (8 anos)', '160.00', 3, 1, 'Whisky Jhonnie Walker Red Label Club do Whisky 8 anos', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Teacher S (Club Do Whisky)', '85.00', 3, 1, 'Whisky Teacher´s Club do Whisky', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Black & White (Club Do Whisky)', '89.90', 3, 1, 'Whisky Black & White Club do Whisky', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Jack Daniels (Club Do Whisky)', '189.00', 3, 1, 'Whisky Jack Daniels Club do Whisky', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Coquetel De Frutas (C/Alcool)', '13.90', 3, 1, 'Coquetel de frutas com álcool', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Coquetel De Frutas (S/Alcool)', '10.90', 3, 1, 'Coquetel de frutas sem álcool', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Mar Azul', '14.50', 3, 1, 'Drink Mar Azul', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Daikiri', '13.90', 3, 1, 'Drink Daikiri', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Alexander', '13.90', 3, 1, 'Drink Alexander', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Espanhola', '13.90', 3, 1, 'Drink Espanhola', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Val pia', '13.90', 3, 1, 'Drink Valépia', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Aperol Spritz', '17.90', 3, 1, 'Drink Aperol Spritz', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Mojito', '13.90', 3, 1, 'Drink Mojito', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Caipilã Especial', '16.90', 3, 1, 'Caipirinha especial com kiwi ou morango + picolé de coco/caju ou limão', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Gim/Tônica Com Morango', '16.90', 3, 1, 'Drink Gim com Tônica e Morango', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Gim/Tônica/T.Pitya e Limão', '17.90', 3, 1, 'Drink Gim com Tônica, T.Pitya e Limão', 'carboidratos');




INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Gim C/Limão Siciliano Especiarias', '15.90', 3, 1, 'Drink de gim com limão siciliano e especiarias', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Caipirosca', '11.90', 3, 1, 'Caipirosca', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Caipirinha', '8.90', 3, 1, 'Caipirinha', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Caipirinha Cach.Min', '11.50', 3, 1, 'Caipirinha Cachaça Mineira', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Roskas Diversas (frutas da época)', '11.90', 3, 1, 'Roskas diversas com frutas da época', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Morangoroska', '13.90', 3, 1, 'Morangoroska', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('KiwiRoska', '13.90', 3, 1, 'KiwiRoska', 'carboidratos');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, DescricaoProduto, NutricaoProduto)
VALUES ('Roska C/Absolut', '17.90', 3, 1, 'Roska com Absolut', 'carboidratos');





INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, NutricaoProduto, DescricaoProduto)
VALUES ('Tangerina C/Pimenta', '14.90', 3, 1, 'Carboidratos', 'Bebida refrescante com sabor de tangerina e um toque de pimenta.');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, NutricaoProduto, DescricaoProduto)
VALUES ('Manga C/Maracujá', '14.90', 3, 1, 'Carboidratos', 'Combinação tropical de manga e maracujá para refrescar seu dia.');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, NutricaoProduto, DescricaoProduto)
VALUES ('Frutas Vermelhas', '15.90', 3, 1, 'Carboidratos', 'Deliciosa mistura de frutas vermelhas em uma bebida refrescante.');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, NutricaoProduto, DescricaoProduto)
VALUES ('Cajaroska (Roskas,Frutas,Nevada)', '12.50', 3, 1, 'Carboidratos', 'Refrescante roska de cajá com frutas e gelo.');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, NutricaoProduto, DescricaoProduto)
VALUES ('Caipiroska (Roskas,Frutas,Nevada)', '12.50', 3, 1, 'Carboidratos', 'Clássica caipiroska com frutas frescas e gelo.');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, NutricaoProduto, DescricaoProduto)
VALUES ('Aceroloroska (Roskas,Frutas,Nevada)', '12.50', 3, 1, 'Carboidratos', 'Saborosa roska de acerola com frutas e gelo.');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, NutricaoProduto, DescricaoProduto)
VALUES ('Abacaxirosca (Roskas,Frutas,Nevada)', '12.50', 3, 1, 'Carboidratos', 'Refrescante roska de abacaxi com frutas e gelo.');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, NutricaoProduto, DescricaoProduto)
VALUES ('Umburoska (Roskas,Frutas,Nevada)', '12.50', 3, 1, 'Carboidratos', 'Deliciosa roska de umbu com frutas e gelo.');





INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, NutricaoProduto, DescricaoProduto)
VALUES ('Maracujaroska (Roskas,Frutas,Nevada)', '12.50', 3, 1, 'Carboidratos', 'Refrescante roska de maracujá com frutas e gelo.');

INSERT INTO Produto (NomeProduto, PrecoProduto, CategoriaID, EmpresaID, NutricaoProduto, DescricaoProduto)
VALUES ('Cajuroska (Roskas,Frutas,Nevada)', '12.50', 3, 1, 'Carboidratos', 'Deliciosa roska de caju com frutas e gelo.');








