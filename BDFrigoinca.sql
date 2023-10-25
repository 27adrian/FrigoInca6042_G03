CREATE DATABASE DBFrigoinca
USE DBFrigoinca

CREATE TABLE [dbo].[Cliente](
[Idcliente] [int] IDENTITY(1,1) NOT NULL,
[Tipocliente] [nvarchar](50) NULL,
[Nombrecompleto] [nvarchar](50) NULL,
[Tipodocumento] [nvarchar](50) NULL,
[Numerodocumento] [int] NULL,
[Correo] [nvarchar](50) NULL,
[TelefonoContacto] [int] NULL,
[Estadocliente] [bit] NULL,
[Fecharegistrocliente] [date] NULL,
CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED
(
[Idcliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS =
ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE PROCEDURE [dbo].[Listarcliente]
AS
SELECT Idcliente, Tipocliente, Nombrecompleto, Tipodocumento, Numerodocumento, Correo, TelefonoContacto, Estadocliente, Fecharegistrocliente
from Cliente
 where Estadocliente='1'

CREATE PROCEDURE [dbo].[Insertarcliente]
(@Tipocliente nvarchar(50),
@Nombrecompleto nvarchar(50),
@Tipodocumento nvarchar(50),
@Numerodocumento int,
@Correo nvarchar(50),
@TelefonoContacto int,
@Estadocliente bit,
@Fecharegistrocliente date
)
as
begin
insert into Cliente(Tipocliente, Nombrecompleto, Tipodocumento, Numerodocumento, Correo, TelefonoContacto, Estadocliente, Fecharegistrocliente) values
(@Tipocliente, @Nombrecompleto, @Tipodocumento, @Numerodocumento, @Correo, @TelefonoContacto, @Estadocliente, @Fecharegistrocliente)
end

create PROCEDURE [dbo].[Editarcliente]
(@Idcliente int,
@Tipocliente nvarchar(50),
@Nombrecompleto nvarchar(50),
@Tipodocumento nvarchar(50),
@Numerodocumento int,
@Correo nvarchar(50),
@TelefonoContacto int,
@Estadocliente bit,
@Fecharegistrocliente date
)
as
begin
update Cliente set
Tipocliente = @Tipocliente,
Nombrecompleto = @Nombrecompleto,
Tipodocumento = @Tipodocumento,
Numerodocumento = @Numerodocumento,
Correo = @Correo,
TelefonoContacto = @TelefonoContacto,
Estadocliente = @Estadocliente,
Fecharegistrocliente = @Fecharegistrocliente
where Idcliente = @Idcliente
end

create PROCEDURE [dbo].[Deshabilitarcliente]
(@idcliente int
)
as
begin
update Cliente set
Estadocliente = 0
where Idcliente = @idcliente
end


