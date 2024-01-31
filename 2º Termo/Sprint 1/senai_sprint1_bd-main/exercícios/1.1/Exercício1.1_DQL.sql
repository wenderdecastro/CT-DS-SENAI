USE Exercicio1_1;

-- SELECT * FROM Pessoas;
-- SELECT * FROM Telefones;
-- SELECT * FROM Emails;

SELECT Pessoas.Nome, Pessoas.CNH, Telefones.Telefone, Emails.Email
FROM Pessoas
RIGHT JOIN Telefones ON Telefones.PessoaID = Pessoas.PessoaID
RIGHT JOIN Emails ON Emails.PessoaID = Pessoas.PessoaID
ORDER BY Pessoas.Nome DESC;

