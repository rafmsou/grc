CREATE DATABASE GRC

GO

USE GRC

GO

CREATE TABLE ENDERECO(
 CODIGO INT NOT NULL IDENTITY(1,1),
 LOGRADOURO VARCHAR(200),
 NUMERO INT,
 BAIRRO VARCHAR(200),
 CIDADE VARCHAR(200),
 ESTADO VARCHAR(2)
)

ALTER TABLE ENDERECO ADD CONSTRAINT PK_ENDERECO PRIMARY KEY(CODIGO)

GO

CREATE TABLE CLIENTE(
 CODIGO INT NOT NULL IDENTITY(1,1),
 NOME VARCHAR(200) NOT NULL,
 CPF BIGINT NOT NULL,
 TELEFONE VARCHAR(200) NOT NULL,
 CODIGO_ENDERECO INT NOT NULL,
 EMAIL VARCHAR(200)
)

ALTER TABLE CLIENTE ADD CONSTRAINT PK_CLIENTE PRIMARY KEY(CODIGO)
ALTER TABLE CLIENTE ADD CONSTRAINT FK_CLIENTE_ENDERECO FOREIGN KEY(CODIGO_ENDERECO)
REFERENCES ENDERECO(CODIGO)

GO

CREATE TABLE PRODUTO(
 CODIGO INT NOT NULL IDENTITY(1,1),
 DESCRICAO VARCHAR(200) NOT NULL,
 VALOR DECIMAL(8,2) NOT NULL
)

ALTER TABLE PRODUTO ADD CONSTRAINT PK_PRODUTO PRIMARY KEY(CODIGO)

GO

CREATE TABLE PEDIDO(
 CODIGO INT NOT NULL IDENTITY(1,1),
 CODIGO_CLIENTE INT NOT NULL,
 DATA DATE NOT NULL
)

ALTER TABLE PEDIDO ADD CONSTRAINT PK_PEDIDO PRIMARY KEY(CODIGO)
ALTER TABLE PEDIDO ADD CONSTRAINT FK_PEDIDO_CLIENTE FOREIGN KEY(CODIGO_CLIENTE)
REFERENCES CLIENTE(CODIGO)

GO 

CREATE TABLE PEDIDO_ITEM(
 CODIGO_PRODUTO INT NOT NULL,
 CODIGO_PEDIDO INT NOT NULL
)

ALTER TABLE PEDIDO_ITEM ADD CONSTRAINT FK_PEDIDO_ITEM_PRODUTO FOREIGN KEY(CODIGO_PRODUTO)
REFERENCES PRODUTO (CODIGO)
ALTER TABLE PEDIDO_ITEM ADD CONSTRAINT FK_PEDIDO_ITEM_PEDIDO FOREIGN KEY(CODIGO_PEDIDO)
REFERENCES PEDIDO (CODIGO)
