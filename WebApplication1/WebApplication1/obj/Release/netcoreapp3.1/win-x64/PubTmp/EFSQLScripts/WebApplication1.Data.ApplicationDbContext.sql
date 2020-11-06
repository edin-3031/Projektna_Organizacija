CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(150) NOT NULL,
    `ProductVersion` varchar(32) NOT NULL,
    PRIMARY KEY (`MigrationId`)
);

IF NOT EXISTS(SELECT * FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20201031083048_m1')
BEGIN
    CREATE TABLE `Drzava` (
        `Drazava_ID` int NOT NULL AUTO_INCREMENT,
        `Sifra` int NOT NULL,
        `Naziv` text NULL,
        PRIMARY KEY (`Drazava_ID`)
    );
END;

IF NOT EXISTS(SELECT * FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20201031083048_m1')
BEGIN
    CREATE TABLE `PTT` (
        `PTT_ID` int NOT NULL AUTO_INCREMENT,
        `Sifra` int NOT NULL,
        `Naziv` text NULL,
        PRIMARY KEY (`PTT_ID`)
    );
END;

IF NOT EXISTS(SELECT * FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20201031083048_m1')
BEGIN
    CREATE TABLE `Resursi` (
        `Resursi_ID` int NOT NULL AUTO_INCREMENT,
        `Naziv` text NULL,
        PRIMARY KEY (`Resursi_ID`)
    );
END;

IF NOT EXISTS(SELECT * FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20201031083048_m1')
BEGIN
    CREATE TABLE `Uloge` (
        `Uloge_ID` int NOT NULL AUTO_INCREMENT,
        `Sifra` int NOT NULL,
        `Naziv` text NULL,
        `Opis` text NULL,
        PRIMARY KEY (`Uloge_ID`)
    );
END;

IF NOT EXISTS(SELECT * FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20201031083048_m1')
BEGIN
    CREATE TABLE `Organizacija` (
        `Organizacija_ID` int NOT NULL AUTO_INCREMENT,
        `PTT_FK` int NOT NULL,
        `Drzava_FK` int NOT NULL,
        `Sifra` int NOT NULL,
        `Naziv` text NULL,
        `Adresa` text NULL,
        PRIMARY KEY (`Organizacija_ID`),
        CONSTRAINT `FK_Organizacija_Drzava_Drzava_FK` FOREIGN KEY (`Drzava_FK`) REFERENCES `Drzava` (`Drazava_ID`) ON DELETE CASCADE,
        CONSTRAINT `FK_Organizacija_PTT_PTT_FK` FOREIGN KEY (`PTT_FK`) REFERENCES `PTT` (`PTT_ID`) ON DELETE CASCADE
    );
END;

IF NOT EXISTS(SELECT * FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20201031083048_m1')
BEGIN
    CREATE TABLE `Korisnici` (
        `Korisnici_ID` int NOT NULL AUTO_INCREMENT,
        `Uloge_FK` int NOT NULL,
        `Sifra` int NOT NULL,
        `Ime` text NULL,
        `Prezime` text NULL,
        `Telefon` text NULL,
        `Mail` text NULL,
        `Lozinka` text NULL,
        PRIMARY KEY (`Korisnici_ID`),
        CONSTRAINT `FK_Korisnici_Uloge_Uloge_FK` FOREIGN KEY (`Uloge_FK`) REFERENCES `Uloge` (`Uloge_ID`) ON DELETE CASCADE
    );
END;

IF NOT EXISTS(SELECT * FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20201031083048_m1')
BEGIN
    CREATE TABLE `OrganizacionaJedinica` (
        `OrganizacionaJedinica_ID` int NOT NULL AUTO_INCREMENT,
        `Organizacija_FK` int NOT NULL,
        `PTT_FK` int NOT NULL,
        `Drzava_FK` int NOT NULL,
        `Naziv` text NULL,
        `Adresa` text NULL,
        PRIMARY KEY (`OrganizacionaJedinica_ID`),
        CONSTRAINT `FK_OrganizacionaJedinica_Drzava_Drzava_FK` FOREIGN KEY (`Drzava_FK`) REFERENCES `Drzava` (`Drazava_ID`) ON DELETE CASCADE,
        CONSTRAINT `FK_OrganizacionaJedinica_Organizacija_Organizacija_FK` FOREIGN KEY (`Organizacija_FK`) REFERENCES `Organizacija` (`Organizacija_ID`) ON DELETE CASCADE,
        CONSTRAINT `FK_OrganizacionaJedinica_PTT_PTT_FK` FOREIGN KEY (`PTT_FK`) REFERENCES `PTT` (`PTT_ID`) ON DELETE CASCADE
    );
END;

IF NOT EXISTS(SELECT * FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20201031083048_m1')
BEGIN
    CREATE TABLE `Korisnici_OrganizacionaJedinica` (
        `Korisnici_OrganizacionaJedinica_ID` int NOT NULL AUTO_INCREMENT,
        `Korisnici_FK` int NOT NULL,
        `OrganizacionaJedinica_ID` int NULL,
        `OrganizacionaJedinica_FK` int NOT NULL,
        PRIMARY KEY (`Korisnici_OrganizacionaJedinica_ID`),
        CONSTRAINT `FK_Korisnici_OrganizacionaJedinica_Korisnici_Korisnici_FK` FOREIGN KEY (`Korisnici_FK`) REFERENCES `Korisnici` (`Korisnici_ID`) ON DELETE CASCADE,
        CONSTRAINT `FK_Korisnici_OrganizacionaJedinica_OrganizacionaJedinica_Organi~` FOREIGN KEY (`OrganizacionaJedinica_ID`) REFERENCES `OrganizacionaJedinica` (`OrganizacionaJedinica_ID`) ON DELETE RESTRICT
    );
END;

IF NOT EXISTS(SELECT * FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20201031083048_m1')
BEGIN
    CREATE TABLE `ProjekatPlan` (
        `ProjekatPlan_ID` int NOT NULL AUTO_INCREMENT,
        `OrganizacionaJedinica_FK` int NOT NULL,
        `Sifra` int NOT NULL,
        `Naziv` text NULL,
        `DatumOd` datetime NOT NULL,
        `DatumDo` datetime NOT NULL,
        PRIMARY KEY (`ProjekatPlan_ID`),
        CONSTRAINT `FK_ProjekatPlan_OrganizacionaJedinica_OrganizacionaJedinica_FK` FOREIGN KEY (`OrganizacionaJedinica_FK`) REFERENCES `OrganizacionaJedinica` (`OrganizacionaJedinica_ID`) ON DELETE CASCADE
    );
END;

IF NOT EXISTS(SELECT * FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20201031083048_m1')
BEGIN
    CREATE TABLE `ProjekatAktivnostPlan` (
        `ProjekatAktivnostPlan_ID` int NOT NULL AUTO_INCREMENT,
        `ProjekatPlan_ID` int NULL,
        `ProjekatPlan_FK` int NOT NULL,
        `Sifra` int NOT NULL,
        `Naziv` text NULL,
        `DatumOd` datetime NOT NULL,
        `DatumDo` datetime NOT NULL,
        `JedinicaMjere` text NULL,
        `Kolicina` float NOT NULL,
        PRIMARY KEY (`ProjekatAktivnostPlan_ID`),
        CONSTRAINT `FK_ProjekatAktivnostPlan_ProjekatPlan_ProjekatPlan_ID` FOREIGN KEY (`ProjekatPlan_ID`) REFERENCES `ProjekatPlan` (`ProjekatPlan_ID`) ON DELETE RESTRICT
    );
END;

IF NOT EXISTS(SELECT * FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20201031083048_m1')
BEGIN
    CREATE TABLE `ProjekatAktivnostRealizacija` (
        `ProjekatAktivnostRealizacija_ID` int NOT NULL AUTO_INCREMENT,
        `ProjekatAktivnostPlan_FK` int NOT NULL,
        `Korisnici_ID` int NULL,
        `Korisnici_FK` int NOT NULL,
        `Datum` datetime NOT NULL,
        `Kolicina` float NOT NULL,
        `Opis` text NULL,
        PRIMARY KEY (`ProjekatAktivnostRealizacija_ID`),
        CONSTRAINT `FK_ProjekatAktivnostRealizacija_Korisnici_Korisnici_ID` FOREIGN KEY (`Korisnici_ID`) REFERENCES `Korisnici` (`Korisnici_ID`) ON DELETE RESTRICT,
        CONSTRAINT `FK_ProjekatAktivnostRealizacija_ProjekatAktivnostPlan_ProjekatA~` FOREIGN KEY (`ProjekatAktivnostPlan_FK`) REFERENCES `ProjekatAktivnostPlan` (`ProjekatAktivnostPlan_ID`) ON DELETE CASCADE
    );
END;

IF NOT EXISTS(SELECT * FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20201031083048_m1')
BEGIN
    CREATE INDEX `IX_Korisnici_Uloge_FK` ON `Korisnici` (`Uloge_FK`);
END;

IF NOT EXISTS(SELECT * FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20201031083048_m1')
BEGIN
    CREATE INDEX `IX_Korisnici_OrganizacionaJedinica_Korisnici_FK` ON `Korisnici_OrganizacionaJedinica` (`Korisnici_FK`);
END;

IF NOT EXISTS(SELECT * FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20201031083048_m1')
BEGIN
    CREATE INDEX `IX_Korisnici_OrganizacionaJedinica_OrganizacionaJedinica_ID` ON `Korisnici_OrganizacionaJedinica` (`OrganizacionaJedinica_ID`);
END;

IF NOT EXISTS(SELECT * FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20201031083048_m1')
BEGIN
    CREATE INDEX `IX_Organizacija_Drzava_FK` ON `Organizacija` (`Drzava_FK`);
END;

IF NOT EXISTS(SELECT * FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20201031083048_m1')
BEGIN
    CREATE INDEX `IX_Organizacija_PTT_FK` ON `Organizacija` (`PTT_FK`);
END;

IF NOT EXISTS(SELECT * FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20201031083048_m1')
BEGIN
    CREATE INDEX `IX_OrganizacionaJedinica_Drzava_FK` ON `OrganizacionaJedinica` (`Drzava_FK`);
END;

IF NOT EXISTS(SELECT * FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20201031083048_m1')
BEGIN
    CREATE INDEX `IX_OrganizacionaJedinica_Organizacija_FK` ON `OrganizacionaJedinica` (`Organizacija_FK`);
END;

IF NOT EXISTS(SELECT * FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20201031083048_m1')
BEGIN
    CREATE INDEX `IX_OrganizacionaJedinica_PTT_FK` ON `OrganizacionaJedinica` (`PTT_FK`);
END;

IF NOT EXISTS(SELECT * FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20201031083048_m1')
BEGIN
    CREATE INDEX `IX_ProjekatAktivnostPlan_ProjekatPlan_ID` ON `ProjekatAktivnostPlan` (`ProjekatPlan_ID`);
END;

IF NOT EXISTS(SELECT * FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20201031083048_m1')
BEGIN
    CREATE INDEX `IX_ProjekatAktivnostRealizacija_Korisnici_ID` ON `ProjekatAktivnostRealizacija` (`Korisnici_ID`);
END;

IF NOT EXISTS(SELECT * FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20201031083048_m1')
BEGIN
    CREATE INDEX `IX_ProjekatAktivnostRealizacija_ProjekatAktivnostPlan_FK` ON `ProjekatAktivnostRealizacija` (`ProjekatAktivnostPlan_FK`);
END;

IF NOT EXISTS(SELECT * FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20201031083048_m1')
BEGIN
    CREATE INDEX `IX_ProjekatPlan_OrganizacionaJedinica_FK` ON `ProjekatPlan` (`OrganizacionaJedinica_FK`);
END;

IF NOT EXISTS(SELECT * FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20201031083048_m1')
BEGIN
    INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
    VALUES ('20201031083048_m1', '3.1.9');
END;

