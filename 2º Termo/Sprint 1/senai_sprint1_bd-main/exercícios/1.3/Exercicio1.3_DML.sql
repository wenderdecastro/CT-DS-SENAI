USE Exercicio1_3

INSERT INTO Clinica(NomeClinica, EnderecoClinica)
VALUES('raduncio veterinaria', 'casa do vextre')

INSERT INTO Veterinario(IDClinica, NomeVeterinario, CRMV)
VALUES(2, 'cleber floricultura e cia', '11111')

INSERT INTO TiposPet(NomeTipo)
VALUES('Tatu')

INSERT INTO RacasPet(NomeRaca)
VALUES('Labrador')

INSERT INTO Dono(Endereco, Nome)
VALUES('cano de concreto', 'rodriguinho do canil')

INSERT INTO Pets(IDRaca, IDTipo, IDDono, NomePet, DataNascimento)
VALUES(2, 2, 3, 'juninho', '23-06-2059')

INSERT INTO Atendimento(IDVeterinario, IDPet, IDClinica)
VALUES(3, 2, 2)


