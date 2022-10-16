USE master
GO

CREATE DATABASE ClimaTempoSimples
GO

--Estado
CREATE TABLE Estado (
    Id   INT		   NOT NULL,
	Nome NVARCHAR(200) NOT NULL,
	UF   NVARCHAR(2)   NOT NULL
	CONSTRAINT PK_Estado PRIMARY KEY CLUSTERED (Id)
);
GO

--Cidade
CREATE TABLE Cidade (
    Id		 INT		   NOT NULL,
	EstadoId INT		   NOT NULL,
	Nome	 NVARCHAR(200) NOT NULL
	CONSTRAINT PK_Cidade PRIMARY KEY CLUSTERED (Id),
	CONSTRAINT FK_Cidade_Estado FOREIGN KEY (EstadoId) REFERENCES Estado (Id)
);
GO

--PrevisaoClima
CREATE TABLE PrevisaoClima (
    Id				  INT		    NOT NULL IDENTITY,
	CidadeId		  INT		    NOT NULL,
	DataPrevisao	  DATE		    NOT NULL,
	Clima			  NVARCHAR(15)  NOT NULL,
	TemperaturaMinima NUMERIC(3, 1) NULL,
	TemperaturaMaxima NUMERIC(3, 1) NULL
	CONSTRAINT PK_PrevisaoClima PRIMARY KEY CLUSTERED (Id),
	CONSTRAINT FK_PrevisaoClima_Cidade FOREIGN KEY (CidadeId) REFERENCES Cidade (Id)
);
GO
ALTER TABLE PrevisaoClima WITH CHECK ADD CHECK ((Clima='instavel' OR Clima='tempestuoso' OR Clima='chuvoso' OR Clima='nublado' OR Clima='ensolarado'))
GO