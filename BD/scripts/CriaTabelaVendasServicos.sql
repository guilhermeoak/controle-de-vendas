create table VendasServicos(
	Codigo INT NOT NULL IDENTITY(1,1),
	Descricao VARCHAR(255),
	CodProdServ int,
	DataTransacao Date,
	Tipo VARCHAR(255),
	Quantidade float,
	ValorTotal float,
	CodCli int,
	CodOp int,
	CONSTRAINT PK_VendasServicos_Codigo PRIMARY KEY CLUSTERED(Codigo)
);