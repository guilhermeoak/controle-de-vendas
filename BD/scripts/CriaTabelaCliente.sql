create table Cliente(
	Codigo INT NOT NULL IDENTITY(1,1),
	Nome VARCHAR(255),
	CPF VARCHAR(255),
	RG VARCHAR(255),
	DtNascimento Date,
	DtCadastro Date,
	Tipo VARCHAR(255),
	CONSTRAINT PK_Cliente_Codigo PRIMARY KEY CLUSTERED(Codigo)

);