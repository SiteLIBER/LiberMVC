/****** Object:  Table [liber].[EstadoCivil]    Script Date: 02/13/2011 20:32:19 ******/
DELETE FROM [EstadoCivil]
GO
/****** Object:  Table [liber].[GrauInstrucao]    Script Date: 02/13/2011 20:32:19 ******/
DELETE FROM [GrauInstrucao]
GO
/****** Object:  Table [liber].[TipoUsuario]    Script Date: 02/13/2011 20:32:19 ******/
DELETE FROM [TipoUsuario]
GO
/****** Object:  Table [liber].[TipoUsuario]    Script Date: 02/13/2011 20:32:19 ******/
SET IDENTITY_INSERT [TipoUsuario] ON
INSERT [TipoUsuario] ([TipoUsuarioID], [Descricao]) VALUES (1, N'Admin')
INSERT [TipoUsuario] ([TipoUsuarioID], [Descricao]) VALUES (2, N'Filiado')
INSERT [TipoUsuario] ([TipoUsuarioID], [Descricao]) VALUES (3, N'Usuario')
INSERT [TipoUsuario] ([TipoUsuarioID], [Descricao]) VALUES (4, N'Editor')
SET IDENTITY_INSERT [TipoUsuario] OFF
/****** Object:  Table [liber].[GrauInstrucao]    Script Date: 02/13/2011 20:32:19 ******/
INSERT [GrauInstrucao] ([GrauInstrucaoID], [Descricao]) VALUES (1, N'Ensino Fundamental (1ª a 8ª)')
INSERT [GrauInstrucao] ([GrauInstrucaoID], [Descricao]) VALUES (2, N'Ensino Médio (Colegial)')
INSERT [GrauInstrucao] ([GrauInstrucaoID], [Descricao]) VALUES (3, N'Ensino Médio (Magistério)')
INSERT [GrauInstrucao] ([GrauInstrucaoID], [Descricao]) VALUES (4, N'Superior - Técnica')
INSERT [GrauInstrucao] ([GrauInstrucaoID], [Descricao]) VALUES (5, N'Superior - Graduação')
INSERT [GrauInstrucao] ([GrauInstrucaoID], [Descricao]) VALUES (6, N'Especialização e extensão')
INSERT [GrauInstrucao] ([GrauInstrucaoID], [Descricao]) VALUES (7, N'Pós-graduação')
INSERT [GrauInstrucao] ([GrauInstrucaoID], [Descricao]) VALUES (8, N'MBA')
INSERT [GrauInstrucao] ([GrauInstrucaoID], [Descricao]) VALUES (9, N'Mestrado')
INSERT [GrauInstrucao] ([GrauInstrucaoID], [Descricao]) VALUES (10, N'Doutorado')
/****** Object:  Table [liber].[EstadoCivil]    Script Date: 02/13/2011 20:32:19 ******/
INSERT [EstadoCivil] ([EstadoCivilID], [Descricao]) VALUES (1, N'Solteiro (a)')
INSERT [EstadoCivil] ([EstadoCivilID], [Descricao]) VALUES (2, N'Casado (a)')
INSERT [EstadoCivil] ([EstadoCivilID], [Descricao]) VALUES (3, N'Divorciado (a)')
INSERT [EstadoCivil] ([EstadoCivilID], [Descricao]) VALUES (4, N'Viúvo (a)')
INSERT [EstadoCivil] ([EstadoCivilID], [Descricao]) VALUES (5, N'Outros')
