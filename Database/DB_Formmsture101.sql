----------------------------------------------------------------------------------------------------------------------

						   -- DATABASE OF FORMMSTURE 101 (F117-NIGHTHAWK\SQLEXPRESS) --


						/*			   414			14141414		  414			*/
						/*			  14 4		   14	  4 4	     14 4			*/
						/*			 14 14		  14	14	14	    14 14			*/
						/*			    14		  14   14	14		   14			*/
						/*				14		  14  14	14		   14			*/
						/*				14		  14 4		14	  	   14			*/
						/*				14		   14	   14	  	   14			*/
						/*			 14141414		14141414	    14141414		*/

----------------------------------------------------------------------------------------------------------------------

CREATE DATABASE DB_Formmsture101
GO
USE DB_Formmsture101

----------------------------------------------------------------------------------------------------------------------

CREATE TABLE tb_ImagemProf
(
	ID_Img INTEGER PRIMARY KEY IDENTITY (1, 1),
	Nome VARCHAR (1000),
	ProfImagem VARBINARY (MAX) NULL
)

INSERT INTO tb_ImagemProf (Nome, ProfImagem)
SELECT 'image.jpg', * from OPENROWSET(BULK N'C:\Users\Aluno\Pictures\image.jpg', SINGLE_BLOB) imagem

--Create table teste
--(
--	ID_Img INTEGER PRIMARY KEY IDENTITY (1, 1),
--	Nome VARCHAR (1000),
--	ProfImagem VARBINARY (MAX) NULL
--)

--INSERT INTO teste (Nome, ProfImagem)
-- 'image.jpeg', * from OPENROWSET(BULK N'C:\Imagens\image.jpeg', SINGLE_BLOB) LOAD

select * from tb_ImagemProf

----------------------------------------------------------------------------------------------------------------------

CREATE TABLE tb_ImagemTexto
(
	ID_ImgTxt INTEGER PRIMARY KEY IDENTITY (1, 1),
	NomeImg VARCHAR (1000),
	TextoImagem VARBINARY (MAX) NULL
)

INSERT INTO tb_ImagemTexto (NomeImg, TextoImagem)
SELECT 'image.jpg', * from OPENROWSET(BULK N'C:\Users\Aluno\Pictures\image.jpg', SINGLE_BLOB) imagem

select * from tb_ImagemTexto

----------------------------------------------------------------------------------------------------------------------

CREATE TABLE tb_Professor
(
	ID_Prof INTEGER PRIMARY KEY IDENTITY (1, 1),
	NomeProf VARCHAR (45) NOT NULL,
	SenhaProf VARCHAR (50) NOT NULL,
	MateriaProf VARCHAR (25) NOT NULL,
	FK_ID_Img INT NULL,
	FOREIGN KEY (FK_ID_Img) REFERENCES tb_ImagemProf(ID_Img)
)

--DROP TABLE tb_Professor;

--INSERT INTO tb_Professor (NomeProf, SenhaProf, MateriaProf, ProfImagem) 
--	VALUES
--		('Teste Teste', 'testeteste', 'Teste', convert ('C:\Users\user\Desktop\Discord Servers\JediEdit') RETURNS )

INSERT INTO tb_Professor (NomeProf, SenhaProf, MateriaProf, FK_ID_Img) 
	VALUES
		('teste', 'teste', 'teste', '1')

--INSERT INTO tb_Professor (ProfImagem)
--	SELECT * FROM OPENROWSET(BULK 'C:\Users\user\Desktop\Discord Servers\JediEdit', SINGLE_BLOB) AS ProfImagem

--SELECT FROM OPENROWSET (bulk 'C:\\.jpg', single_blob) imagem

SELECT ID_Prof [CÓDIGO], NomeProf [NOME DO PROFESSOR], SenhaProf [SENHA DO PROFESSOR], MateriaProf [MATÉRIA], FK_ID_Img [IMAGEM DE PERFIL] FROM tb_Professor;
DELETE tb_Professor WHERE ID_Prof = '1';



----------------------------------------------------------------------------------------------------------------------

CREATE TABLE tb_Admin
(
	ID_Admin INTEGER PRIMARY KEY IDENTITY (1, 1),
	NomeAdmin VARCHAR (25) NOT NULL,
	SenhaAdmin VARCHAR (50) NOT NULL
)

--DROP TABLE tb_Admin;

INSERT INTO tb_Admin (NomeAdmin, SenhaAdmin) 
	VALUES
		('admin', 'admin')

SELECT * FROM tb_Admin;

----------------------------------------------------------------------------------------------------------------------

CREATE TABLE tb_Equipe
(
	ID_Equipe INTEGER PRIMARY KEY IDENTITY (1, 1),
	NumEqp VARCHAR (8) NOT NULL
)

INSERT INTO tb_Equipe (NumEqp)
	VALUES
		('Equipe 1'),
		('Equipe 2'),
		('Equipe 3'),
		('Equipe 4'),
		('Equipe 5'),
		('Equipe 6'),
		('Equipe 7')

SELECT * FROM tb_Equipe;

--DROP TABLE tb_Equipe;

----------------------------------------------------------------------------------------------------------------------

CREATE TABLE tb_Sala
(
	ID_Sala INTEGER PRIMARY KEY IDENTITY (1, 1),
	Sala VARCHAR (7) NOT NULL
)

INSERT INTO tb_Sala (Sala)
	VALUES
		('Sala 1'),
		('Sala 2'),
		('Sala 3'),
		('Sala 4'),
		('Sala 5'),
		('Sala 6'),
		('Sala 7'),
		('Sala 8'),
		('Sala 9'),
		('Sala 10'),
		('Sala 11'),
		('Sala 12'),
		('Sala 13'),
		('Sala 14'),
		('Sala 15')

SELECT * FROM tb_Sala;

--DROP TABLE tb_Sala;

----------------------------------------------------------------------------------------------------------------------

CREATE TABLE tb_Turno
(
	ID_Turno INTEGER PRIMARY KEY IDENTITY (1, 1),
	Turno VARCHAR (12) NOT NULL
)

INSERT INTO tb_Turno (Turno) 
	VALUES
		('Matutino'),
		('Vespertino')

SELECT * FROM tb_Turno;

--DROP TABLE tb_Turno;

----------------------------------------------------------------------------------------------------------------------

CREATE TABLE tb_Aluno
(
	ID_Aluno INTEGER PRIMARY KEY IDENTITY (1, 1),
	FK_ID_Prof INT NOT NULL,
	FOREIGN KEY (FK_ID_Prof) REFERENCES tb_Professor(ID_Prof),
	FK_ID_Equipe INT NOT NULL,
	FOREIGN KEY (FK_ID_Equipe) REFERENCES tb_Equipe(ID_Equipe),
	FK_ID_Sala INT NOT NULL,
	FOREIGN KEY (FK_ID_Sala) REFERENCES tb_Sala(ID_Sala),
	FK_ID_Turno INT NOT NULL,
	FOREIGN KEY (FK_ID_Turno) REFERENCES tb_Turno(ID_Turno),
	ResFormEqp INT NOT NULL,
	DataRes DATETIME2 -- format('YYYY-MM-DD HH:ii:ss')
)

set language Portuguese


insert select GETDATE()


INSERT INTO tb_Aluno (FK_ID_Prof, FK_ID_Equipe, FK_ID_Sala, FK_ID_Turno, ResFormEqp, DataRes)
	VALUES
		('1', '1', '1', '1', '1', GETDATE())

SELECT * FROM tb_Aluno;

--DROP TABLE tb_Aluno;

----------------------------------------------------------------------------------------------------------------------

CREATE TABLE tb_Forms
(
	ID_Forms INTEGER PRIMARY KEY IDENTITY (1, 1),
	NomeForms VARCHAR (12),
	FK_ID_ImgSeg INT NULL,
	FOREIGN KEY (FK_ID_ImgSeg) REFERENCES tb_ImagemSegmento(ID_ImgSeg),
	FK_ID_Fase INT NOT NULL,
	FOREIGN KEY (FK_ID_Fase) REFERENCES tb_Fase(ID_Fase),
	FK_ID_Nivel INT NOT NULL,
	FOREIGN KEY (FK_ID_Nivel) REFERENCES tb_Nivel(ID_Nivel)
)

INSERT INTO tb_Forms ()
	VALUES
	
SELECT * FROM tb_Forms;

DROP DATABASE tb_Forms;

----------------------------------------------------------------------------------------------------------------------

CREATE TABLE tb_Fase
(
	ID_Fase INTEGER PRIMARY KEY IDENTITY (1, 1),
	FK_ID_Nivel INT NOT NULL,
	FOREIGN KEY (FK_ID_Nivel) REFERENCES tb_Nivel(ID_Nivel)
)

INSERT INTO tb_Fase ()
	VALUES
	
SELECT * FROM tb_Fase;

DROP DATABASE tb_Fase;

----------------------------------------------------------------------------------------------------------------------

CREATE TABLE tb_Nivel
(
	ID_Nivel INTEGER PRIMARY KEY IDENTITY (1, 1),
	Texto VARCHAR (8000) NOT NULL,
	Alternativa1 VARCHAR (4000) NOT NULL,
	Alternativa2 VARCHAR (4000) NOT NULL,
	Alternativa3 VARCHAR (4000) NULL,
	Alternativa4 VARCHAR (4000) NULL,
	AlternativaPontuacao1 INT NOT NULL,
	AlternativaPontuacao2 INT NOT NULL,
	AlternativaPontuacao3 INT NULL,
	AlternativaPontuacao4 INT NULL,
	Tempo TIME (4) NOT NULL
)

INSERT INTO tb_Nivel ()
	VALUES
	
SELECT * FROM tb_Nivel;

DROP DATABASE tb_Nivel;

----------------------------------------------------------------------------------------------------------------------

CREATE TABLE tb_ImagemSegmento
(
	ID_ImgSeg INTEGER PRIMARY KEY IDENTITY (1, 1),
	NameImgSeg VARCHAR (1000),
	SegmentoImagem VARBINARY (MAX) NULL
)

INSERT INTO tb_ImagemSegmento (NameImgSeg, SegmentoImagem)
SELECT 'image.jpg', * from OPENROWSET(BULK N'C:\Users\Aluno\Pictures\image.jpg', SINGLE_BLOB) imagem

select * from tb_ImagemTexto

----------------------------------------------------------------------------------------------------------------------

--DROP DATABASE DB_Formmsture101;



--SELECT P.MateriaProf, E.NumEqp, S.Sala, T.Turno
--FROM tb_Professor P 
--INNER JOIN 


--SELECT P.FK_ID_Prof, E.FK_ID_Equipe, S.FK_ID_Sala, T.FK_ID_Turno, FROM tb_Aluno AS A FULL JOIN tb_Professor AS P, tb_Equipe AS E,
--tb_Sala AS S, tb_Turno AS T ON P.FK_ID_Prof = P.MateriaProf, E.FK_ID_Equipe = E.NumEqp, S.FK_ID_Sala = S.Sala,
--T.FK_ID_Turno = T.Turno, WHERE P.MateriaProf = @Materia, E.NumEqp = @Equipe, S.Sala = @Sala, T.Turno = @Turno"







