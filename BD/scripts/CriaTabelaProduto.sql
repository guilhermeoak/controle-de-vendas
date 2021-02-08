create table Produto(
	Codprod int not null,
	Prodnome varchar(255),
	Custo float,
	Preco_final float,
	Quantidade int,
	Lucro float,
	Lucro_percentual float,
	CONSTRAINT PK_Produto_Codprod PRIMARY KEY CLUSTERED(codprod) 

);