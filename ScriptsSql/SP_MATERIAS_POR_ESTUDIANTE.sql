USE EstudiantesDb
GO

CREATE OR ALTER PROCEDURE SP_MATERIAS_POR_ESTUDIANTE(
	@CODIGO_ESTUDIANTE		VARCHAR(50) 
)
AS BEGIN
	SELECT M.Nombre
		  ,M.IdInstructor
		  ,M.Horario
		  ,M.Ubicacion
		  ,M.FecCrea
		  ,M.UsuCrea
	  FROM MateriasEstudiantes ME
	 INNER JOIN Estudiantes E ON E.IdEstudiante = ME.IdEstudiante
	 INNER JOIN Materias M ON M.IdMateria = ME.IdMateria
	 WHERE E.Codigo = @CODIGO_ESTUDIANTE;
END
