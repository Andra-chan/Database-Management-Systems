USE Centru_de_engleza;

-- Validate Profesori nume if null or if it begins with uppercase
GO
CREATE OR ALTER FUNCTION validateNume(@nume VARCHAR(50)) RETURNS INT AS
BEGIN
	DECLARE @return INT
	SET @return = 1
	IF(@nume = null OR @nume != upper(left(@nume, 1)) + right(@nume, len(@nume) - 1)) 
		SET @return = 0 
	RETURN @return
END

-- Validate Profesori prenume if null or if it begins with uppercase
GO
CREATE OR ALTER FUNCTION validatePrenume(@prenume VARCHAR(50)) RETURNS INT AS
BEGIN
	DECLARE @return INT
	SET @return = 1
	IF(@prenume = null OR @prenume != upper(left(@prenume, 1)) + right(@prenume, len(@prenume) - 1)) 
		SET @return = 0 
	RETURN @return
END

-- Validate Profesori telefon if not a phone number
GO
CREATE OR ALTER FUNCTION validateTelefon(@telefon INT) RETURNS INT AS
BEGIN
	DECLARE @return INT
	SET @return = 1
	IF (@telefon > 9999999999 OR @telefon < 1)
		SET @return = 0
	RETURN @return
END

-- Validate Grupe numar if null or numar > 1 or numar > 10
GO
CREATE  OR ALTER FUNCTION validateNumar(@numar INT) RETURNS INT AS
BEGIN
	DECLARE @return INT
	SET @return = 1
	IF (@numar < 1 OR @numar > 10)
		SET @return = 0
	RETURN @return
END

-- First procedure(rollback on everything)
GO
CREATE OR ALTER PROCEDURE AddProfesoriGrupe @nume VARCHAR(50), @prenume VARCHAR(50), @telefon INT, @adresa VARCHAR(250), @numar INT AS
BEGIN
	BEGIN TRAN
		BEGIN TRY

			IF(dbo.validateNume(@nume) = 0)
				BEGIN RAISERROR('Numele trebuie sa inceapa cu litera mare si nu trebuie sa fie null!',14,1)
				END
			IF(dbo.validatePrenume(@prenume) = 0)
				BEGIN RAISERROR('Prenumele trebuie sa inceapa cu litera mare si nu trebuie sa fie null!',14,1)
				END
			IF(dbo.validateTelefon(@telefon) = 0)
				BEGIN RAISERROR('Telefonul nu trebuie sa fie null si sa fie valid!',14,1)
				END
			IF(dbo.validateNumar(@numar) = 0)
				BEGIN RAISERROR('Numarul trebuie sa fie intre 1 si 10!',14,1)
				END

			INSERT INTO Profesori(nume, prenume, telefon, adresa) VALUES (@nume, @prenume, @telefon, @adresa)
			DECLARE  @id_profesor INT = SCOPE_IDENTITY();
			INSERT INTO Grupe(numar) VALUES (@numar)
			DECLARE @id_grupa INT = SCOPE_IDENTITY();
			INSERT INTO RelatieProfesoriGrupe(id_profesor, id_grupa) VALUES (@id_profesor, @id_grupa)

			COMMIT TRAN
			SELECT 'Transaction committed'
		END TRY

		BEGIN CATCH
			ROLLBACK TRAN
			SELECT 'Transaction rollbacked'
		END CATCH
END

-- First procedure(rollback separat)
GO
CREATE OR ALTER PROCEDURE AddProfesoriGrupeSeparate @nume VARCHAR(50), @prenume VARCHAR(50), @telefon INT, @adresa VARCHAR(250), @numar INT AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			IF(dbo.validateNume(@nume) = 0)
				BEGIN RAISERROR('Numele trebuie sa inceapa cu litera mare si nu trebuie sa fie null!',14,1)
				END
			IF(dbo.validatePrenume(@prenume) = 0)
				BEGIN RAISERROR('Prenumele trebuie sa inceapa cu litera mare si nu trebuie sa fie null!',14,1)
				END
			IF(dbo.validateTelefon(@telefon) = 0)
				BEGIN RAISERROR('Telefonul nu trebuie sa fie null si sa fie valid!',14,1)
				END

			INSERT INTO Profesori(nume, prenume, telefon, adresa) VALUES (@nume, @prenume, @telefon, @adresa);
			DECLARE  @id_profesor INT = SCOPE_IDENTITY();
			COMMIT TRAN
			SELECT 'Transaction committed'
			END TRY
			BEGIN CATCH
				ROLLBACK TRAN
				SELECT 'Transaction rollbacked'
			END CATCH

		BEGIN TRAN
			BEGIN TRY
				IF(dbo.validateNumar(@numar) = 0)
					BEGIN RAISERROR('Numarul trebuie sa fie intre 1 si 10!',14,1)
					END

				INSERT INTO Grupe(numar) VALUES (@numar)
				DECLARE @id_grupa INT = SCOPE_IDENTITY();
				COMMIT TRAN
				SELECT 'Transaction committed'
				END TRY
				BEGIN CATCH
					ROLLBACK TRAN
					SELECT 'Transaction rollbacked'
				END CATCH

		BEGIN TRAN
			BEGIN TRY
				INSERT INTO RelatieProfesoriGrupe(id_profesor, id_grupa) VALUES (@id_profesor, @id_grupa);
				COMMIT TRAN
				SELECT 'Transaction committed'

				END TRY
			BEGIN CATCH
				ROLLBACK TRAN
				SELECT 'Transaction rollbacked'
			END CATCH
END

DELETE FROM RelatieProfesoriGrupe;
DELETE FROM Profesori;
DELETE FROM Grupe;

-- correct
SELECT * FROM Profesori;
SELECT * FROM Grupe;
SELECT * FROM RelatieProfesoriGrupe;
EXEC AddProfesoriGrupe @nume = 'Andra', @prenume = 'Mihaila', @telefon = 111, @adresa = 'Constanta', @numar = 1;
SELECT * FROM Profesori;
SELECT * FROM Grupe;
SELECT * FROM RelatieProfesoriGrupe;

-- incorrect
SELECT * FROM Profesori;
SELECT * FROM Grupe;
SELECT * FROM RelatieProfesoriGrupe;
EXEC AddProfesoriGrupe @nume = '', @prenume = '', @telefon = 0, @adresa = '', @numar = 10;
SELECT * FROM Profesori;
SELECT * FROM Grupe;
SELECT * FROM RelatieProfesoriGrupe;

-- correct
SELECT * FROM Profesori;
SELECT * FROM Grupe;
SELECT * FROM RelatieProfesoriGrupe;
EXEC AddProfesoriGrupeSeparate @nume = 'Mihai', @prenume = 'Barbulescu', @telefon = 222, @adresa = 'Cluj', @numar = 2;
SELECT * FROM Profesori;
SELECT * FROM Grupe;
SELECT * FROM RelatieProfesoriGrupe;

-- incorrect Profesori nume
SELECT * FROM Profesori;
SELECT * FROM Grupe;
SELECT * FROM RelatieProfesoriGrupe;
EXEC AddProfesoriGrupeSeparate @nume = '', @prenume = 'Barbulescu', @telefon = 333, @adresa = 'Cluj', @numar = 3;
SELECT * FROM Profesori;
SELECT * FROM Grupe;
SELECT * FROM RelatieProfesoriGrupe;

-- incorrect Profesori prenume
SELECT * FROM Profesori;
SELECT * FROM Grupe;
SELECT * FROM RelatieProfesoriGrupe;
EXEC AddProfesoriGrupeSeparate @nume = 'Mihai', @prenume = '', @telefon = 444, @adresa = 'Cluj', @numar = 4;
SELECT * FROM Profesori;
SELECT * FROM Grupe;
SELECT * FROM RelatieProfesoriGrupe;

-- incorrect Profesori telefon
SELECT * FROM Profesori;
SELECT * FROM Grupe;
SELECT * FROM RelatieProfesoriGrupe;
EXEC AddProfesoriGrupeSeparate @nume = 'Mihai', @prenume = 'Barbulescu', @telefon = 0, @adresa = 'Cluj', @numar = 5;
SELECT * FROM Profesori;
SELECT * FROM Grupe;
SELECT * FROM RelatieProfesoriGrupe;

-- incorrect Grupe numar
SELECT * FROM Profesori;
SELECT * FROM Grupe;
SELECT * FROM RelatieProfesoriGrupe;
EXEC AddProfesoriGrupeSeparate @nume = 'Mihaela', @prenume = 'Mihaila', @telefon = 2, @adresa = 'Constanta', @numar = 24;
SELECT * FROM Profesori;
SELECT * FROM Grupe;
SELECT * FROM RelatieProfesoriGrupe;




