CREATE TABLE [dbo].[ProdutoFornecedor]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Quantidade] INT NOT NULL, 
    [Id_Produto] INT NOT NULL, 
    [Id_Fornecedor] INT NOT NULL, 
    CONSTRAINT [FK_ProdutoFornecedor_Produto] FOREIGN KEY (Id_Produto) REFERENCES Produto(Id), 
    CONSTRAINT [FK_ProdutoFornecedor_Fornecedor] FOREIGN KEY (Id_Fornecedor) REFERENCES Fornecedor(Id)
)
