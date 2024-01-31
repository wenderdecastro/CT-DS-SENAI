USE HealthClinic;


SELECT * FROM tb_Usuario 
SELECT * FROM tb_Medico
SELECT * FROM tb_Paciente
SELECT * FROM tb_Consulta
SELECT * FROM tb_Feedback

-- Id Consulta
-- Data da Consulta
-- Horario da Consulta
--- Nome da Clinica
-- Nome do Paciente
-- Nome do Medico
-- Especialidade do Medico
-- CRM
-- Prontuário ou Descricao
-- FeedBack(Comentario da consulta)

SELECT
	tb_Consulta.IDConsulta, 
	tb_Consulta.[Data], 
	tb_Consulta.Horario, 
	tb_Clinica.NomeFantasia,
	NomePaciente.Nome,
	NomeMedico.Nome,
	Medicos.IDEspecialidade,
	Medicos.CRM,
	tb_Consulta.Descricao,
	tb_Feedback.Comentario
FROM 
	tb_Consulta
JOIN tb_Medico AS Medicos 
	ON Medicos.IDMedico = tb_Consulta.IDMedico

INNER JOIN tb_Feedback 
	ON tb_Feedback.IDConsulta = tb_Consulta.IDConsulta

INNER JOIN tb_Clinica 
	ON tb_Clinica.IDClinica = tb_Feedback.IDClinica

INNER JOIN tb_Paciente AS Pacientes
	ON Pacientes.IDPaciente = tb_Consulta.IDPaciente

INNER JOIN tb_Usuario AS NomePaciente
	ON Pacientes.IDUsuario = NomePaciente.IDUsuario

INNER JOIN tb_Usuario AS NomeMedico
	ON Medicos.IDUsuario = NomeMedico.IDUsuario



	-- FUNÇÃO DESAFIO 1



CREATE FUNCTION QuantMedicoEspecialidade (@IDEspecialidade INT)
RETURNS INT
AS
BEGIN
	DECLARE @quant INT

	SELECT @quant = COUNT(*)
	FROM tb_Medico
	WHERE IDEspecialidade = @IDEspecialidade

	RETURN @quant

END;

SELECT dbo.QuantMedicoEspecialidade(1) AS [Quantidade Medico Especialidade];



	-- PROCEDURE DESAFIO 2



CREATE PROCEDURE CalcIdadeCliente (@IDPaciente INT)
AS
BEGIN
	DECLARE @IdadeCliente INT
	DECLARE @DataAniversario DATE;

	SELECT @DataAniversario = DataNascimento 
	FROM tb_Paciente
	WHERE tb_Paciente.IDPaciente = @IDPaciente;

	SELECT DATEDIFF(YEAR, @DataAniversario, CAST( GETDATE() AS Date )) AS IdadeCliente
END;

EXEC CalcIdadeCliente @IDPaciente = 1;
