SELECT * FROM Clientes
SELECT * FROM Enderecos


CREATE TABLE Enderecos (
Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
IdCliente int NULL,
Rua varchar (255) NULL,
Bairro varchar (255),
Cidade varchar (255) NULL,
Estado char (2) NULL,

CONSTRAINT FK_Enderecos_Clientes FOREIGN KEY (IdCliente)
REFERENCES Clientes (Id)
)

INSERT INTO Enderecos VALUES (6, 'Rua Teste', 'Bairro teste', 'Cidade teste', 'DF')

SELECT * FROM Clientes WHERE Id = 6
SELECT * FROM Enderecos WHERE IdClientes = 6