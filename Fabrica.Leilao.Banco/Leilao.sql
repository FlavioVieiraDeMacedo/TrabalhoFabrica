CREATE TABLE [dbo].[Leilao]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Id_Usuario] INT NOT NULL, 
    [Id_ProdutoFornecedor] INT NOT NULL, 
    [PrecoDoFornecedor] DECIMAL NOT NULL, 
    CONSTRAINT [FK_Leilao_Usuario] FOREIGN KEY (Id_Usuario) REFERENCES Usuario(Id), 
    CONSTRAINT [FK_Leilao_Id_ProdutoFornecedor] FOREIGN KEY (Id_ProdutoFornecedor) REFERENCES ProdutoFornecedor(Id)
)
