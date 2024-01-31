USE Exercicio1_4

SELECT * FROM Artistas
SELECT * FROM Albuns
SELECT * FROM GenerosMSC
SELECT * FROM EstilosMSC
SELECT * FROM Usuarios

--DQL

-- listar todos os usuários administradores, sem exibir suas senhas

SELECT Usuarios.Nome, Usuarios.Email
FROM Usuarios 
WHERE Usuarios.Permissao = 1
 
-- listar todos os álbuns lançados após o um determinado ano de lançamento

SELECT * 
FROM Albuns
WHERE Albuns.DataLancamento >= '01-01-2023'

-- listar os dados de um usuário através do e-mail e senha

SELECT *
FROM Usuarios
WHERE Usuarios.Email = 'juninho@gmail.com' AND Senha = 'cabrunco0'

-- listar todos os álbuns ativos, mostrando o nome do artista e os estilos do álbum 

SELECT *
FROM Albuns
WHERE Albuns.Ativo = 1


