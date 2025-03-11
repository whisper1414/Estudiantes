USE [EstudiantesDb]
GO

INSERT INTO [dbo].[Estudiantes]
           ([Codigo]
           ,[Nombres]
           ,[Apellidos]
           ,[FechaNacimiento]
           ,[Edad]
           ,[Correo]
           ,[UsuCrea]
           ,[FecCrea])
     VALUES
           ('E0001'
           ,'Marcos'
           ,'Duran'
           ,'2025-01-01'
           ,25
           ,'marcos.duran@estudiante.com'
           ,'DB'
           ,GETDATE()),
		   ('E0002'
           ,'Carlos'
           ,'Mejia'
           ,'2025-01-01'
           ,25
           ,'carlos.mejia@estudiante.com'
           ,'DB'
           ,GETDATE()),
		   ('E0003'
           ,'Ruth'
           ,'Melgar'
           ,'2025-01-01'
           ,25
           ,'ruth.melgar@estudiante.com'
           ,'DB'
           ,GETDATE())
GO



USE [EstudiantesDb]
GO

INSERT INTO [dbo].[Materias]
           ([Nombre]
           ,[IdInstructor]
           ,[Horario]
           ,[Ubicacion]
           ,[UsuCrea]
           ,[FecCrea])
     VALUES
           ('Programacion Orientada a Objetos'
		   ,1
		   ,'10:30'
           ,'Sala 1'
           ,'DB'
           ,GETDATE()),
		   ('HTML y CSS'
		   ,1
		   ,'11:30'
           ,'Sala 1'
           ,'DB'
           ,GETDATE()),
		   ('Javascript'
		   ,1
		   ,'12:30'
           ,'Sala 1'
           ,'DB'
           ,GETDATE())
GO


USE [EstudiantesDb]
GO

INSERT INTO [dbo].[MateriasEstudiantes]
           ([IdEstudiante]
           ,[IdMateria]
           ,[UsuCrea]
           ,[FecCrea])
     VALUES
           (2
           ,1
           ,'DBO'
           ,GETDATE()),
		   (2
           ,2
           ,'DBO'
           ,GETDATE()),
		   (2
           ,3
           ,'DBO'
           ,GETDATE())
GO

