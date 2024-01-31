USE Exercicio1_2;

INSERT INTO Marcas(NomeMarca)
VALUES('Volkswagen')

INSERT INTO Modelos(NomeModelo)
VALUES('Fusca')

INSERT INTO Veiculos(Placa, MarcaID, ModeloID)
VALUES('3366633', 1, 1)

INSERT INTO Clientes(ClienteNome, CPF)
VALUES('cliente 3', 1231232)

INSERT INTO Alugueis(ClienteID, VeiculoID, DataRetirada, DataDevolucao, PrecoAluguel)
VALUES (3, 3, '25-12-2015', '24-12-2024', 80000)