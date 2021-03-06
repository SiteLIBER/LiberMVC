/****** Object:  ForeignKey [FK_Artigo_Usuario]    Script Date: 02/13/2011 20:58:18 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_Artigo_Usuario]') AND parent_object_id = OBJECT_ID(N'[Artigo]'))
ALTER TABLE [Artigo] DROP CONSTRAINT [FK_Artigo_Usuario]
GO
/****** Object:  ForeignKey [FK_Usuario_EstadoCivil]    Script Date: 02/13/2011 20:58:23 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_Usuario_EstadoCivil]') AND parent_object_id = OBJECT_ID(N'[Usuario]'))
ALTER TABLE [Usuario] DROP CONSTRAINT [FK_Usuario_EstadoCivil]
GO
/****** Object:  ForeignKey [FK_Usuario_GrauInstrucao]    Script Date: 02/13/2011 20:58:23 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_Usuario_GrauInstrucao]') AND parent_object_id = OBJECT_ID(N'[Usuario]'))
ALTER TABLE [Usuario] DROP CONSTRAINT [FK_Usuario_GrauInstrucao]
GO
/****** Object:  ForeignKey [FK_Usuario_TipoUsuario]    Script Date: 02/13/2011 20:58:23 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_Usuario_TipoUsuario]') AND parent_object_id = OBJECT_ID(N'[Usuario]'))
ALTER TABLE [Usuario] DROP CONSTRAINT [FK_Usuario_TipoUsuario]
GO
/****** Object:  Table [liber].[Artigo]    Script Date: 02/13/2011 20:58:18 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Artigo]') AND type in (N'U'))
DROP TABLE [Artigo]
GO
/****** Object:  Table [liber].[Usuario]    Script Date: 02/13/2011 20:58:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Usuario]') AND type in (N'U'))
DROP TABLE [Usuario]
GO
/****** Object:  Table [liber].[EstadoCivil]    Script Date: 02/13/2011 20:58:19 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[EstadoCivil]') AND type in (N'U'))
DROP TABLE [EstadoCivil]
GO
/****** Object:  Table [liber].[GrauInstrucao]    Script Date: 02/13/2011 20:58:19 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GrauInstrucao]') AND type in (N'U'))
DROP TABLE [GrauInstrucao]
GO
/****** Object:  Table [liber].[TipoUsuario]    Script Date: 02/13/2011 20:58:19 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[TipoUsuario]') AND type in (N'U'))
DROP TABLE [TipoUsuario]
GO
/****** Object:  Default [DF_Artigo_Publicado]    Script Date: 02/13/2011 20:58:18 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[liber].[DF_Artigo_Publicado]') AND parent_object_id = OBJECT_ID(N'[Artigo]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Artigo_Publicado]') AND type = 'D')
BEGIN
ALTER TABLE [Artigo] DROP CONSTRAINT [DF_Artigo_Publicado]
END


End
GO
/****** Object:  Default [DF_Artigo_CriadoEm1]    Script Date: 02/13/2011 20:58:18 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[liber].[DF_Artigo_CriadoEm1]') AND parent_object_id = OBJECT_ID(N'[Artigo]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Artigo_CriadoEm1]') AND type = 'D')
BEGIN
ALTER TABLE [Artigo] DROP CONSTRAINT [DF_Artigo_CriadoEm1]
END


End
GO
/****** Object:  Default [DF_Artigo_CriadoEm]    Script Date: 02/13/2011 20:58:18 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[liber].[DF_Artigo_CriadoEm]') AND parent_object_id = OBJECT_ID(N'[Artigo]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Artigo_CriadoEm]') AND type = 'D')
BEGIN
ALTER TABLE [Artigo] DROP CONSTRAINT [DF_Artigo_CriadoEm]
END


End
GO
/****** Object:  Default [DF_Usuario_TipoUsuarioID]    Script Date: 02/13/2011 20:58:23 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[liber].[DF_Usuario_TipoUsuarioID]') AND parent_object_id = OBJECT_ID(N'[Usuario]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Usuario_TipoUsuarioID]') AND type = 'D')
BEGIN
ALTER TABLE [Usuario] DROP CONSTRAINT [DF_Usuario_TipoUsuarioID]
END


End
GO
/****** Object:  Default [DF_Usuario_Banido]    Script Date: 02/13/2011 20:58:23 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[liber].[DF_Usuario_Banido]') AND parent_object_id = OBJECT_ID(N'[Usuario]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Usuario_Banido]') AND type = 'D')
BEGIN
ALTER TABLE [Usuario] DROP CONSTRAINT [DF_Usuario_Banido]
END


End
GO
/****** Object:  Default [DF_Usuario_OutroPartido]    Script Date: 02/13/2011 20:58:23 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[liber].[DF_Usuario_OutroPartido]') AND parent_object_id = OBJECT_ID(N'[Usuario]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Usuario_OutroPartido]') AND type = 'D')
BEGIN
ALTER TABLE [Usuario] DROP CONSTRAINT [DF_Usuario_OutroPartido]
END


End
GO
/****** Object:  Schema [liber]    Script Date: 02/13/2011 20:58:16 ******/
IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'liber')
DROP SCHEMA [liber]
GO
--/****** Object:  Schema [liber]    Script Date: 02/13/2011 20:58:16 ******/
--IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'liber')
--EXEC sys.sp_executesql N'CREATE SCHEMA [liber] AUTHORIZATION [liber]'
--GO
/****** Object:  Table [liber].[TipoUsuario]    Script Date: 02/13/2011 20:58:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[TipoUsuario]') AND type in (N'U'))
BEGIN
CREATE TABLE [TipoUsuario](
	[TipoUsuarioID] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_TipoUsuario] PRIMARY KEY CLUSTERED 
(
	[TipoUsuarioID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [liber].[GrauInstrucao]    Script Date: 02/13/2011 20:58:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GrauInstrucao]') AND type in (N'U'))
BEGIN
CREATE TABLE [GrauInstrucao](
	[GrauInstrucaoID] [int] NOT NULL,
	[Descricao] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_GrauInstrucao] PRIMARY KEY CLUSTERED 
(
	[GrauInstrucaoID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [liber].[EstadoCivil]    Script Date: 02/13/2011 20:58:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[EstadoCivil]') AND type in (N'U'))
BEGIN
CREATE TABLE [EstadoCivil](
	[EstadoCivilID] [int] NOT NULL,
	[Descricao] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_EstadoCivil] PRIMARY KEY CLUSTERED 
(
	[EstadoCivilID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [liber].[Usuario]    Script Date: 02/13/2011 20:58:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Usuario]') AND type in (N'U'))
BEGIN
CREATE TABLE [Usuario](
	[UsuarioID] [int] IDENTITY(1,1) NOT NULL,
	[TipoUsuarioID] [int] NOT NULL,
	[Nome] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Email] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[CPF] [nvarchar](18) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ReceberNewsletter] [bit] NOT NULL,
	[Senha] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[DataNasc] [datetime] NULL,
	[Sexo] [nvarchar](1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Banido] [bit] NOT NULL,
	[Naturalidade] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[NomePai] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[NomeMae] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[EstadoCivilID] [int] NULL,
	[Profissao] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[GrauInstrucaoID] [int] NULL,
	[Endereco] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Cidade] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Estado] [nvarchar](2) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[CEP] [nvarchar](9) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Telefone] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[TituloEleitor] [nvarchar](12) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Zona] [nvarchar](4) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Secao] [nvarchar](4) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[MunicipioUF] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[OutroPartido] [bit] NOT NULL,
	[OutroPartidoQual] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[UsuarioID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [liber].[Artigo]    Script Date: 02/13/2011 20:58:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Artigo]') AND type in (N'U'))
BEGIN
CREATE TABLE [Artigo](
	[ArtigoID] [int] IDENTITY(1,1) NOT NULL,
	[EditorID] [int] NOT NULL,
	[Titulo] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Chamada] [nvarchar](1000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Conteudo] [ntext] COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Publicado] [bit] NOT NULL,
	[PublicadoEm] [datetime] NOT NULL,
	[CriadoEm] [datetime] NOT NULL,
	[Autor] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Fonte] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_Artigo] PRIMARY KEY CLUSTERED 
(
	[ArtigoID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Default [DF_Artigo_Publicado]    Script Date: 02/13/2011 20:58:18 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[liber].[DF_Artigo_Publicado]') AND parent_object_id = OBJECT_ID(N'[Artigo]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Artigo_Publicado]') AND type = 'D')
BEGIN
ALTER TABLE [Artigo] ADD  CONSTRAINT [DF_Artigo_Publicado]  DEFAULT ((0)) FOR [Publicado]
END


End
GO
/****** Object:  Default [DF_Artigo_CriadoEm1]    Script Date: 02/13/2011 20:58:18 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[liber].[DF_Artigo_CriadoEm1]') AND parent_object_id = OBJECT_ID(N'[Artigo]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Artigo_CriadoEm1]') AND type = 'D')
BEGIN
ALTER TABLE [Artigo] ADD  CONSTRAINT [DF_Artigo_CriadoEm1]  DEFAULT (getdate()) FOR [PublicadoEm]
END


End
GO
/****** Object:  Default [DF_Artigo_CriadoEm]    Script Date: 02/13/2011 20:58:18 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[liber].[DF_Artigo_CriadoEm]') AND parent_object_id = OBJECT_ID(N'[Artigo]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Artigo_CriadoEm]') AND type = 'D')
BEGIN
ALTER TABLE [Artigo] ADD  CONSTRAINT [DF_Artigo_CriadoEm]  DEFAULT (getdate()) FOR [CriadoEm]
END


End
GO
/****** Object:  Default [DF_Usuario_TipoUsuarioID]    Script Date: 02/13/2011 20:58:23 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[liber].[DF_Usuario_TipoUsuarioID]') AND parent_object_id = OBJECT_ID(N'[Usuario]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Usuario_TipoUsuarioID]') AND type = 'D')
BEGIN
ALTER TABLE [Usuario] ADD  CONSTRAINT [DF_Usuario_TipoUsuarioID]  DEFAULT ((3)) FOR [TipoUsuarioID]
END


End
GO
/****** Object:  Default [DF_Usuario_Banido]    Script Date: 02/13/2011 20:58:23 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[liber].[DF_Usuario_Banido]') AND parent_object_id = OBJECT_ID(N'[Usuario]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Usuario_Banido]') AND type = 'D')
BEGIN
ALTER TABLE [Usuario] ADD  CONSTRAINT [DF_Usuario_Banido]  DEFAULT ((0)) FOR [Banido]
END


End
GO
/****** Object:  Default [DF_Usuario_OutroPartido]    Script Date: 02/13/2011 20:58:23 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[liber].[DF_Usuario_OutroPartido]') AND parent_object_id = OBJECT_ID(N'[Usuario]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Usuario_OutroPartido]') AND type = 'D')
BEGIN
ALTER TABLE [Usuario] ADD  CONSTRAINT [DF_Usuario_OutroPartido]  DEFAULT ((0)) FOR [OutroPartido]
END


End
GO
/****** Object:  ForeignKey [FK_Artigo_Usuario]    Script Date: 02/13/2011 20:58:18 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_Artigo_Usuario]') AND parent_object_id = OBJECT_ID(N'[Artigo]'))
ALTER TABLE [Artigo]  WITH CHECK ADD  CONSTRAINT [FK_Artigo_Usuario] FOREIGN KEY([EditorID])
REFERENCES [Usuario] ([UsuarioID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_Artigo_Usuario]') AND parent_object_id = OBJECT_ID(N'[Artigo]'))
ALTER TABLE [Artigo] CHECK CONSTRAINT [FK_Artigo_Usuario]
GO
/****** Object:  ForeignKey [FK_Usuario_EstadoCivil]    Script Date: 02/13/2011 20:58:23 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_Usuario_EstadoCivil]') AND parent_object_id = OBJECT_ID(N'[Usuario]'))
ALTER TABLE [Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_EstadoCivil] FOREIGN KEY([EstadoCivilID])
REFERENCES [EstadoCivil] ([EstadoCivilID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_Usuario_EstadoCivil]') AND parent_object_id = OBJECT_ID(N'[Usuario]'))
ALTER TABLE [Usuario] CHECK CONSTRAINT [FK_Usuario_EstadoCivil]
GO
/****** Object:  ForeignKey [FK_Usuario_GrauInstrucao]    Script Date: 02/13/2011 20:58:23 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_Usuario_GrauInstrucao]') AND parent_object_id = OBJECT_ID(N'[Usuario]'))
ALTER TABLE [Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_GrauInstrucao] FOREIGN KEY([GrauInstrucaoID])
REFERENCES [GrauInstrucao] ([GrauInstrucaoID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_Usuario_GrauInstrucao]') AND parent_object_id = OBJECT_ID(N'[Usuario]'))
ALTER TABLE [Usuario] CHECK CONSTRAINT [FK_Usuario_GrauInstrucao]
GO
/****** Object:  ForeignKey [FK_Usuario_TipoUsuario]    Script Date: 02/13/2011 20:58:23 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_Usuario_TipoUsuario]') AND parent_object_id = OBJECT_ID(N'[Usuario]'))
ALTER TABLE [Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_TipoUsuario] FOREIGN KEY([TipoUsuarioID])
REFERENCES [TipoUsuario] ([TipoUsuarioID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_Usuario_TipoUsuario]') AND parent_object_id = OBJECT_ID(N'[Usuario]'))
ALTER TABLE [Usuario] CHECK CONSTRAINT [FK_Usuario_TipoUsuario]
GO
