USE HealthClinic;

INSERT INTO tb_Clinica(Endereco, CPNJ, HorarioFuncionamento, NomeFantasia, RazaoSocial)
VALUES('onde judas perdeu as botas','44139741','das 2 as 8','clinica dois','rogeclinica')

INSERT INTO tb_Usuario(Nome, Email, Senha, Permissao)
VALUES('medico de numero dois', 'douto2@outlook.com', '1923912', 0)

INSERT INTO tb_Especialidade(NomeEspecialidade)
VALUES('otorrinolaringologia')

INSERT INTO tb_Medico(IDUsuario, IDEspecialidade, IDClinica, CRM)
VALUES(3, 2, 2, '553856')

INSERT INTO tb_Paciente(IDUsuario, CPF, DataNascimento, Sexo)
VALUES(1, '78498743699', '2006-09-01', 'Masculino')

INSERT INTO tb_Consulta(IDPaciente, IDMedico, Descricao, [Local], [Data], Horario)
VALUES(1, 3, 'teste', 'clinica1', '13-09-2023', '11:38:00')

INSERT INTO tb_Feedback(IDPaciente, IDMedico, IDClinica, IDConsulta, Comentario, Nota)
VALUES(1,3,2,3, 'TESTE2', 4);

