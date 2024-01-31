USE Exercicio1_2;


/*

SELECT * FROM Marcas;
SELECT * FROM Modelos;
SELECT * FROM Veiculos;
SELECT * FROM Clientes;
SELECT * FROM Alugueis;

*/


SELECT Clientes.ClienteID, Clientes.ClienteNome, Alugueis.DataRetirada, Alugueis.DataDevolucao, Alugueis.PrecoAluguel, Modelos.NomeModelo
FROM Alugueis 
LEFT JOIN Clientes ON Clientes.ClienteID = Alugueis.ClienteID
LEFT JOIN Veiculos ON Veiculos.VeiculoID = Veiculos.ModeloID 
LEFT JOIN Modelos ON Modelos.ModeloID = Veiculos.ModeloID
WHERE Clientes.ClienteID = 2;


/*

DQL

- listar todos os alugueis mostrando as datas de início e fim, o nome do cliente que alugou e nome do modelo do carro
- listar os alugueis de um determinado cliente mostrando seu nome, as datas de início e fim e o nome do modelo do carro
- listar os alugueis de um determinado cliente mostrando seu nome, as datas de início e fim e o nome do modelo do carro

*/