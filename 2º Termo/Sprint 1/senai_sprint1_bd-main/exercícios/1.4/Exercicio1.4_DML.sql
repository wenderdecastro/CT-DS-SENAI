USE Exercicio1_4

INSERT INTO Artistas(Nome)
VALUES('bucetildes dos teclados')

INSERT INTO Albuns(IDArtista, Titulo, DataLancamento, Localizacao, QTDMin, Ativo)
VALUES(2, 'julilson atraves do olhar de um espirito dormido', '29-12-2021', 'Sararau - Espirito Santo', '0:32', 1)

INSERT INTO GenerosMSC(Nome)
VALUES('Indie')

INSERT INTO EstilosMSC(IDAlbum, IDGenero)
VALUES(1, 1)

INSERT INTO Usuarios(Nome, Email, Senha, Permissao)
VALUES('juninho personagem secundario', 'juninho@gmail.com', 'cabrunco0', 0)
