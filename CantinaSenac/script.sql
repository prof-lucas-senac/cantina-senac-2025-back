CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(150) CHARACTER SET utf8mb4 NOT NULL,
    `ProductVersion` varchar(32) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
) CHARACTER SET=utf8mb4;

START TRANSACTION;
ALTER DATABASE CHARACTER SET utf8mb4;

CREATE TABLE `Usuario` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `NomeDoUsuario` longtext CHARACTER SET utf8mb4 NOT NULL,
    `Email` longtext CHARACTER SET utf8mb4 NOT NULL,
    `Senha` longtext CHARACTER SET utf8mb4 NOT NULL,
    `Status` int NOT NULL,
    `Foto` longtext CHARACTER SET utf8mb4 NULL,
    `Discriminator` varchar(8) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_Usuario` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `Postagem` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Descricao` longtext CHARACTER SET utf8mb4 NOT NULL,
    `DataPublicacao` datetime(6) NOT NULL,
    `UsuarioId` int NOT NULL,
    `Discriminator` varchar(8) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_Postagem` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Postagem_Usuario_UsuarioId` FOREIGN KEY (`UsuarioId`) REFERENCES `Usuario` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

INSERT INTO `Usuario` (`Id`, `Discriminator`, `Email`, `Foto`, `NomeDoUsuario`, `Senha`, `Status`)
VALUES (1, 'Aluno', 'aluno@senac.br', NULL, 'Aluno', 'aluno', 1);

CREATE INDEX `IX_Postagem_UsuarioId` ON `Postagem` (`UsuarioId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20251016231053_CriacaoDatabase', '9.0.9');

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20251104231706_Inicial', '9.0.9');

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20251115002124_InitialCreate', '9.0.9');

COMMIT;

