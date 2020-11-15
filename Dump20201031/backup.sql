-- MySQL dump 10.13  Distrib 8.0.22, for Win64 (x86_64)
--
-- Host: localhost    Database: projektnaorganizacija
-- ------------------------------------------------------
-- Server version	8.0.21

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `__efmigrationshistory`
--

DROP TABLE IF EXISTS `__efmigrationshistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__efmigrationshistory`
--

LOCK TABLES `__efmigrationshistory` WRITE;
/*!40000 ALTER TABLE `__efmigrationshistory` DISABLE KEYS */;
INSERT INTO `__efmigrationshistory` VALUES ('20201031083048_m1','3.1.9'),('20201108103825_m2','3.1.9');
/*!40000 ALTER TABLE `__efmigrationshistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `drzava`
--

DROP TABLE IF EXISTS `drzava`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `drzava` (
  `Drazava_ID` int NOT NULL AUTO_INCREMENT,
  `Sifra` int NOT NULL,
  `Naziv` text,
  PRIMARY KEY (`Drazava_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=60 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `drzava`
--

LOCK TABLES `drzava` WRITE;
/*!40000 ALTER TABLE `drzava` DISABLE KEYS */;
INSERT INTO `drzava` VALUES (1,1,'Thailand'),(2,2,'China'),(3,3,'Philippines'),(4,4,'Thailand'),(5,5,'China'),(6,6,'Philippines'),(7,7,'Indonesia'),(8,8,'Portugal'),(9,9,'Brazil'),(10,10,'Bangladesh'),(11,11,'Poland'),(12,12,'Cameroon'),(13,13,'China'),(14,14,'Indonesia'),(15,15,'Senegal'),(16,16,'Jordan'),(17,17,'Japan'),(18,18,'Thailand'),(19,19,'Pakistan'),(20,20,'Sri Lanka'),(21,21,'Costa Rica'),(22,22,'China'),(23,23,'China'),(24,24,'Japan'),(25,25,'Poland'),(26,26,'Sweden'),(27,27,'Sweden'),(28,28,'Norway'),(29,29,'France'),(30,30,'China'),(31,31,'Iran'),(32,32,'Portugal'),(33,33,'Nigeria'),(34,34,'Indonesia'),(35,35,'Liberia'),(36,36,'Indonesia'),(37,37,'China'),(38,38,'United States'),(39,39,'Germany'),(40,40,'South Korea'),(41,41,'Greece'),(42,42,'United Kingdom'),(43,43,'Argentina'),(44,44,'Luxembourg'),(45,45,'China'),(47,47,'France'),(48,48,'Ireland'),(49,49,'China'),(50,50,'Sweden'),(51,999,'Bosna i Hercegovina'),(54,1234599,'Crna Gora'),(55,9,'Srbija');
/*!40000 ALTER TABLE `drzava` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `korisnici`
--

DROP TABLE IF EXISTS `korisnici`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `korisnici` (
  `Korisnici_ID` int NOT NULL AUTO_INCREMENT,
  `Uloge_FK` int NOT NULL,
  `Sifra` int NOT NULL,
  `Ime` text,
  `Prezime` text,
  `Telefon` text,
  `Mail` text,
  `Lozinka` text,
  `Korisnicko_Ime` text,
  PRIMARY KEY (`Korisnici_ID`),
  KEY `IX_Korisnici_Uloge_FK` (`Uloge_FK`),
  CONSTRAINT `FK_Korisnici_Uloge_Uloge_FK` FOREIGN KEY (`Uloge_FK`) REFERENCES `uloge` (`Uloge_ID`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `korisnici`
--

LOCK TABLES `korisnici` WRITE;
/*!40000 ALTER TABLE `korisnici` DISABLE KEYS */;
INSERT INTO `korisnici` VALUES (1,1,1,'Chadwick','Valentine','+687 (422) 115-4614','cvalentine0@goo.ne.jp','qMV2lHaxfDre','c.v'),(2,3,2,'Winnifred','Henlon','+81 (699) 457-7762','whenlon1@amazon.de','lNUKH8Cv','w.h'),(3,2,3,'Phedra','Mainstone','+993 (127) 933-4749','pmainstone2@state.tx.us','1zbhAm1dI2k','p.m'),(4,2,4,'Andrew','Raatz','+55 (897) 483-3510','araatz3@dailymail.co.uk','OyMPq1Sm','a.r'),(5,3,5,'Hillery','Muglestone','+86 (615) 646-4579','hmuglestone4@si.edu','5X8Qc9t5k','h.m'),(6,3,6,'Davide','Coulton','+62 (544) 158-2335','dcoulton5@51.la','AXLVEE80pF',NULL),(7,1,7,'Ellette','Widdecombe','+234 (632) 208-8976','ewiddecombe6@intel.com','QIO2tXpzui',NULL),(8,3,8,'Susy','Boyack','+62 (973) 965-2089','sboyack7@discovery.com','nZCbkM',NULL),(10,1,10,'Alvan','Kester','+351 (479) 938-8000','akester9@google.com','eakF1An',NULL),(11,1,11,'Admin','Admin','+11111','admin@mail.com','admin','admin'),(12,2,12,'User','User','+22222','user@mail.com','user','user'),(14,4,13,'Admin_org','Admin_org','+44444','admin_org@mail.com','admin_org','admin_org'),(15,5,15,'Korisnik_report','Korisnik_report','+555555','korisnik_report@mail.com','korisnik_report','korisnik_report');
/*!40000 ALTER TABLE `korisnici` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `korisnici_organizacionajedinica`
--

DROP TABLE IF EXISTS `korisnici_organizacionajedinica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `korisnici_organizacionajedinica` (
  `Korisnici_OrganizacionaJedinica_ID` int NOT NULL AUTO_INCREMENT,
  `Korisnici_FK` int NOT NULL,
  `OrganizacionaJedinica_ID` int DEFAULT NULL,
  `OrganizacionaJedinica_FK` int NOT NULL,
  PRIMARY KEY (`Korisnici_OrganizacionaJedinica_ID`),
  KEY `IX_Korisnici_OrganizacionaJedinica_Korisnici_FK` (`Korisnici_FK`),
  KEY `IX_Korisnici_OrganizacionaJedinica_OrganizacionaJedinica_ID` (`OrganizacionaJedinica_ID`),
  CONSTRAINT `FK_Korisnici_OrganizacionaJedinica_Korisnici_Korisnici_FK` FOREIGN KEY (`Korisnici_FK`) REFERENCES `korisnici` (`Korisnici_ID`) ON DELETE CASCADE,
  CONSTRAINT `FK_Korisnici_OrganizacionaJedinica_OrganizacionaJedinica_Organi~` FOREIGN KEY (`OrganizacionaJedinica_ID`) REFERENCES `organizacionajedinica` (`OrganizacionaJedinica_ID`) ON DELETE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=65 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `korisnici_organizacionajedinica`
--

LOCK TABLES `korisnici_organizacionajedinica` WRITE;
/*!40000 ALTER TABLE `korisnici_organizacionajedinica` DISABLE KEYS */;
INSERT INTO `korisnici_organizacionajedinica` VALUES (1,6,NULL,16),(2,10,NULL,20),(3,1,NULL,13),(4,1,NULL,18),(6,6,NULL,6),(10,7,NULL,1),(11,7,NULL,3),(12,4,NULL,15),(13,1,NULL,2),(14,4,NULL,3),(15,5,NULL,13),(16,2,NULL,14),(17,7,NULL,19),(18,7,NULL,9),(19,10,NULL,18),(20,3,NULL,11),(21,4,NULL,11),(22,10,NULL,17),(23,3,NULL,6),(25,3,NULL,5),(26,8,NULL,2),(27,6,NULL,2),(28,1,NULL,15),(29,8,NULL,5),(30,7,NULL,8),(31,8,NULL,8),(32,5,NULL,2),(33,8,NULL,5),(34,8,NULL,6),(35,3,NULL,7),(36,1,NULL,11),(38,4,NULL,19),(39,4,NULL,19),(40,5,NULL,16),(41,2,NULL,15),(42,8,NULL,17),(43,2,NULL,13),(44,6,NULL,5),(45,6,NULL,12),(46,3,NULL,19),(47,6,NULL,4),(48,10,NULL,2),(49,5,NULL,18),(50,5,NULL,1),(51,11,NULL,1),(52,12,NULL,2),(55,15,NULL,5),(56,4,NULL,8),(57,4,NULL,8),(58,14,49,49),(62,14,49,53),(63,14,49,55);
/*!40000 ALTER TABLE `korisnici_organizacionajedinica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `organizacija`
--

DROP TABLE IF EXISTS `organizacija`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `organizacija` (
  `Organizacija_ID` int NOT NULL AUTO_INCREMENT,
  `PTT_FK` int NOT NULL,
  `Drzava_FK` int NOT NULL,
  `Sifra` int NOT NULL,
  `Naziv` text,
  `Adresa` text,
  PRIMARY KEY (`Organizacija_ID`),
  KEY `IX_Organizacija_Drzava_FK` (`Drzava_FK`),
  KEY `IX_Organizacija_PTT_FK` (`PTT_FK`),
  CONSTRAINT `FK_Organizacija_Drzava_Drzava_FK` FOREIGN KEY (`Drzava_FK`) REFERENCES `drzava` (`Drazava_ID`) ON DELETE CASCADE,
  CONSTRAINT `FK_Organizacija_PTT_PTT_FK` FOREIGN KEY (`PTT_FK`) REFERENCES `ptt` (`PTT_ID`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `organizacija`
--

LOCK TABLES `organizacija` WRITE;
/*!40000 ALTER TABLE `organizacija` DISABLE KEYS */;
INSERT INTO `organizacija` VALUES (1,3,25,1,'Shufflebeat','454 Hudson Junction'),(2,5,37,2,'Camimbo','2294 Ilene Junction'),(3,2,17,3,'Topicshots','6 Hansons Trail'),(4,3,8,4,'Blogspan','7601 Mosinee Avenue'),(5,8,8,5,'Voonyx','2 Esker Point'),(6,1,8,6,'Tagcat','734 Pierstorff Avenue'),(7,4,10,7,'Jabberbean','39519 Kings Trail'),(8,3,6,8,'DabZ','3715 Colorado Terrace'),(9,8,35,9,'Quimm','8 Clarendon Park'),(10,10,6,10,'Oozz','18 Fairfield Parkway'),(11,5,10,11,'Feedfire','87527 Park Meadow Circle'),(12,1,27,12,'Skinder','95 Merchant Terrace'),(13,8,21,13,'Innotype','55 Parkside Drive'),(14,4,33,14,'Buzzbean','59404 Esch Alley'),(15,8,25,15,'Oyoba','097 Lighthouse Bay Avenue');
/*!40000 ALTER TABLE `organizacija` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `organizacionajedinica`
--

DROP TABLE IF EXISTS `organizacionajedinica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `organizacionajedinica` (
  `OrganizacionaJedinica_ID` int NOT NULL AUTO_INCREMENT,
  `Organizacija_FK` int NOT NULL,
  `PTT_FK` int NOT NULL,
  `Drzava_FK` int NOT NULL,
  `Naziv` text,
  `Adresa` text,
  PRIMARY KEY (`OrganizacionaJedinica_ID`),
  KEY `IX_OrganizacionaJedinica_Drzava_FK` (`Drzava_FK`),
  KEY `IX_OrganizacionaJedinica_Organizacija_FK` (`Organizacija_FK`),
  KEY `IX_OrganizacionaJedinica_PTT_FK` (`PTT_FK`),
  CONSTRAINT `FK_OrganizacionaJedinica_Drzava_Drzava_FK` FOREIGN KEY (`Drzava_FK`) REFERENCES `drzava` (`Drazava_ID`) ON DELETE CASCADE,
  CONSTRAINT `FK_OrganizacionaJedinica_Organizacija_Organizacija_FK` FOREIGN KEY (`Organizacija_FK`) REFERENCES `organizacija` (`Organizacija_ID`) ON DELETE CASCADE,
  CONSTRAINT `FK_OrganizacionaJedinica_PTT_PTT_FK` FOREIGN KEY (`PTT_FK`) REFERENCES `ptt` (`PTT_ID`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=56 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `organizacionajedinica`
--

LOCK TABLES `organizacionajedinica` WRITE;
/*!40000 ALTER TABLE `organizacionajedinica` DISABLE KEYS */;
INSERT INTO `organizacionajedinica` VALUES (1,1,4,6,'Stehr-Bergnaum','5367 Moose Avenue'),(2,2,7,3,'Pouros, Crist and Larkin','6405 Nelson Plaza'),(3,2,10,38,'Kessler-Stark','4870 Hanover Trail'),(6,4,5,30,'Marquardt, Kohler and Harris','6992 Charing Cross Lane'),(8,5,3,30,'Dare Inc','730 Harbort Hill'),(9,3,7,23,'Hirthe, Langosh and Weber','51218 Pawling Crossing'),(11,12,7,33,'Hegmann Inc','133 Helena Alley'),(12,11,7,1,'Lindgren, Greenholt and Grady','8937 Spohn Crossing'),(13,6,8,18,'Sanford and Sons','77883 Karstens Alley'),(14,1,9,49,'Goodwin LLC','279 Grasskamp Road'),(15,8,5,30,'Shanahan-Windler','2 Pleasure Crossing'),(16,12,9,27,'Boyer, Bogisich and Daniel','50 Logan Center'),(18,14,9,41,'Lakin-Paucek','0 Oak Avenue'),(19,13,9,36,'Wolf LLC','54239 Hayes Park'),(20,2,2,6,'Will, Kautzer and Hoeger','704 Vidon Terrace'),(48,15,2,39,'test 2','test 2'),(49,10,2,7,'test','test'),(50,10,7,33,'Test 2','Test 2');
/*!40000 ALTER TABLE `organizacionajedinica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `projekataktivnostplan`
--

DROP TABLE IF EXISTS `projekataktivnostplan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `projekataktivnostplan` (
  `ProjekatAktivnostPlan_ID` int NOT NULL AUTO_INCREMENT,
  `ProjekatPlan_ID` int DEFAULT NULL,
  `ProjekatPlan_FK` int NOT NULL,
  `Sifra` int NOT NULL,
  `Naziv` text,
  `DatumOd` datetime NOT NULL,
  `DatumDo` datetime NOT NULL,
  `JedinicaMjere` text,
  `Kolicina` float NOT NULL,
  PRIMARY KEY (`ProjekatAktivnostPlan_ID`),
  KEY `IX_ProjekatAktivnostPlan_ProjekatPlan_ID` (`ProjekatPlan_ID`),
  CONSTRAINT `FK_ProjekatAktivnostPlan_ProjekatPlan_ProjekatPlan_ID` FOREIGN KEY (`ProjekatPlan_ID`) REFERENCES `projekatplan` (`ProjekatPlan_ID`) ON DELETE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `projekataktivnostplan`
--

LOCK TABLES `projekataktivnostplan` WRITE;
/*!40000 ALTER TABLE `projekataktivnostplan` DISABLE KEYS */;
INSERT INTO `projekataktivnostplan` VALUES (1,NULL,1,1,'Childrens Acetaminophen Melts','2015-02-16 00:00:00','2015-10-10 00:00:00','CZK',83.4),(2,NULL,2,16,'PENNSAID','2020-03-22 00:00:00','2020-11-23 00:00:00','RUB',235.4),(3,NULL,3,7,'Leucovorin','2019-05-19 00:00:00','2019-07-13 00:00:00','CNY',239.7),(4,NULL,4,2,'Fosamax','2019-08-01 00:00:00','2019-08-05 00:00:00','AZN',235.9),(5,NULL,5,10,'Mirtazapine','2020-05-04 00:00:00','2020-07-20 00:00:00','COP',189.1),(6,NULL,6,6,'Glipizide and Metformin Hydrochloride','2017-04-20 00:00:00','2017-06-09 00:00:00','IDR',167),(7,NULL,7,3,'BeeGentle','2019-02-16 00:00:00','2020-01-18 00:00:00','KES',105.2),(8,NULL,8,15,'emuaidMAX','2017-05-22 00:00:00','2017-09-01 00:00:00','SOS',286.2),(9,NULL,9,11,'Spironolactone','2020-05-01 00:00:00','2021-09-28 00:00:00','CNY',148.2),(10,NULL,10,12,'Childrens Allergy Relief','2017-07-09 00:00:00','2018-05-24 00:00:00','AFN',146.4),(11,NULL,11,4,'ALOE VESTA DAILY MOISTURIZER','2017-07-23 00:00:00','2019-11-12 00:00:00','RUB',216.8),(12,NULL,12,5,'MoviPrep','2021-11-23 00:00:00','2021-12-09 00:00:00','PLN',180.7),(13,NULL,13,19,'Sulfamethoxazole and Trimethoprim','2016-12-20 00:00:00','2017-09-26 00:00:00','CNY',184.9),(14,NULL,14,9,'Olanzapine','2017-07-16 00:00:00','2018-09-14 00:00:00','USD',108.5),(15,NULL,15,17,'Amlodipine Besylate','2017-06-07 00:00:00','2018-10-15 00:00:00','IDR',41),(16,NULL,16,8,'Junior Pain Relief','2020-05-19 00:00:00','2020-05-30 00:00:00','ARS',66.6),(17,NULL,17,18,'White (Mexican) Dock','2019-05-30 00:00:00','2020-05-14 00:00:00','CNY',282.8),(18,NULL,18,13,'Topcare Cold Head Congestion','2018-02-10 00:00:00','2018-09-24 00:00:00','USD',187.6),(19,NULL,19,14,'Montelukast Sodium','2017-04-19 00:00:00','2018-09-01 00:00:00','CNY',284.6),(20,NULL,20,20,'OXALIPLATIN','2016-08-12 00:00:00','2018-09-03 00:00:00','IDR',218.7),(27,NULL,21,6653,'6653','2020-11-16 09:18:00','2020-11-17 09:18:00','kg',78),(28,NULL,21,12345,'Resurs 1','2020-11-12 09:19:00','2020-11-13 09:19:00','test',877);
/*!40000 ALTER TABLE `projekataktivnostplan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `projekataktivnostrealizacija`
--

DROP TABLE IF EXISTS `projekataktivnostrealizacija`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `projekataktivnostrealizacija` (
  `ProjekatAktivnostRealizacija_ID` int NOT NULL AUTO_INCREMENT,
  `ProjekatAktivnostPlan_FK` int NOT NULL,
  `Korisnici_ID` int DEFAULT NULL,
  `Korisnici_FK` int NOT NULL,
  `Datum` datetime NOT NULL,
  `Kolicina` float NOT NULL,
  `Opis` text,
  PRIMARY KEY (`ProjekatAktivnostRealizacija_ID`),
  KEY `IX_ProjekatAktivnostRealizacija_Korisnici_ID` (`Korisnici_ID`),
  KEY `IX_ProjekatAktivnostRealizacija_ProjekatAktivnostPlan_FK` (`ProjekatAktivnostPlan_FK`),
  CONSTRAINT `FK_ProjekatAktivnostRealizacija_Korisnici_Korisnici_ID` FOREIGN KEY (`Korisnici_ID`) REFERENCES `korisnici` (`Korisnici_ID`) ON DELETE RESTRICT,
  CONSTRAINT `FK_ProjekatAktivnostRealizacija_ProjekatAktivnostPlan_ProjekatA~` FOREIGN KEY (`ProjekatAktivnostPlan_FK`) REFERENCES `projekataktivnostplan` (`ProjekatAktivnostPlan_ID`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `projekataktivnostrealizacija`
--

LOCK TABLES `projekataktivnostrealizacija` WRITE;
/*!40000 ALTER TABLE `projekataktivnostrealizacija` DISABLE KEYS */;
INSERT INTO `projekataktivnostrealizacija` VALUES (1,1,NULL,9,'2018-01-26 00:00:00',72.9,'Ca in situ skin lip'),(2,2,NULL,1,'2020-01-07 00:00:00',38.4,'Dislocation ankle-closed'),(3,3,NULL,8,'2018-04-26 00:00:00',16.9,'Female infertility NEC'),(4,4,NULL,6,'2019-11-17 00:00:00',20.3,'Vertigo'),(5,5,NULL,1,'2019-03-31 00:00:00',5.3,'Bsl cell ca scalp/skn nk'),(6,6,NULL,4,'2019-05-25 00:00:00',35.7,'Deep thromb postpar-unsp'),(7,7,NULL,10,'2015-11-25 00:00:00',22.7,'Broken tooth-complicated'),(8,8,NULL,9,'2020-10-11 00:00:00',14.4,'Fetal-matern hem-antepar'),(9,9,NULL,3,'2019-12-11 00:00:00',23.9,'Shrt lst uni nral hdache'),(10,10,NULL,4,'2020-07-13 00:00:00',18.3,'Hx-health hazard NOS'),(11,11,NULL,5,'2017-09-15 00:00:00',22.6,'Bungee jumping'),(12,12,NULL,10,'2016-10-12 00:00:00',12.1,'Desensitiza to allergens'),(13,13,NULL,7,'2017-06-06 00:00:00',25.2,'Lymphoid mal NEC abdom'),(14,14,NULL,6,'2017-04-14 00:00:00',9.3,'Excess physical exert'),(15,15,NULL,9,'2019-03-15 00:00:00',2.6,'Abn uterus NEC-antepart'),(16,16,NULL,5,'2016-06-20 00:00:00',15.4,'Renal vascular disorder'),(17,17,NULL,6,'2020-05-10 00:00:00',19.9,'TB of bladder-no exam'),(18,18,NULL,1,'2018-01-02 00:00:00',26.9,'Const aplastc anemia NEC'),(19,19,NULL,2,'2020-03-14 00:00:00',28.2,'Sprain of ankle NEC'),(20,20,NULL,5,'2018-11-19 00:00:00',21.6,'Anemia d/t antineo chemo'),(21,4,NULL,5,'2020-11-11 08:43:00',12,'Donacija'),(23,20,NULL,7,'2020-12-17 10:55:00',10,'opis 10');
/*!40000 ALTER TABLE `projekataktivnostrealizacija` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `projekatplan`
--

DROP TABLE IF EXISTS `projekatplan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `projekatplan` (
  `ProjekatPlan_ID` int NOT NULL AUTO_INCREMENT,
  `OrganizacionaJedinica_FK` int NOT NULL,
  `Sifra` int NOT NULL,
  `Naziv` text,
  `DatumOd` datetime NOT NULL,
  `DatumDo` datetime NOT NULL,
  PRIMARY KEY (`ProjekatPlan_ID`),
  KEY `IX_ProjekatPlan_OrganizacionaJedinica_FK` (`OrganizacionaJedinica_FK`),
  CONSTRAINT `FK_ProjekatPlan_OrganizacionaJedinica_OrganizacionaJedinica_FK` FOREIGN KEY (`OrganizacionaJedinica_FK`) REFERENCES `organizacionajedinica` (`OrganizacionaJedinica_ID`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `projekatplan`
--

LOCK TABLES `projekatplan` WRITE;
/*!40000 ALTER TABLE `projekatplan` DISABLE KEYS */;
INSERT INTO `projekatplan` VALUES (1,8,1,'Fluoxetine','2015-10-13 00:00:00','2020-01-06 00:00:00'),(2,18,2,'D TIME SINUS','2016-03-08 00:00:00','2020-12-08 00:00:00'),(3,16,3,'Butalbital','2020-09-10 00:00:00','2021-06-09 00:00:00'),(4,15,4,'Mirtazapine','2020-02-10 00:00:00','2021-01-03 00:00:00'),(7,16,7,'FRESH JUICE E SERUM','2018-10-03 00:00:00','2018-11-08 00:00:00'),(8,8,8,'Duloxetine','2020-09-11 00:00:00','2020-12-30 00:00:00'),(9,8,9,'Temporary','2020-09-15 00:00:00','2021-11-13 00:00:00'),(11,19,11,'Ramipril','2017-10-08 00:00:00','2018-12-14 00:00:00'),(12,1,12,'Coast Maple','2017-02-03 00:00:00','2018-07-26 00:00:00'),(13,8,13,'Valium','2016-05-14 00:00:00','2019-03-04 00:00:00'),(14,16,14,'SPF 15','2015-03-02 00:00:00','2018-11-17 00:00:00'),(15,6,15,'Pentoxifylline','2017-02-08 00:00:00','2017-09-28 00:00:00'),(16,3,16,'SANITIZER','2020-08-10 00:00:00','2020-08-19 00:00:00'),(17,9,17,'Chloroquine phosphate','2016-01-16 00:00:00','2016-07-15 00:00:00'),(18,16,18,'Aurum Prunus','2017-10-08 00:00:00','2018-07-19 00:00:00'),(19,3,19,'Sweet Honey','2019-10-29 00:00:00','2020-10-14 00:00:00'),(20,3,20,'Horse Epithelium','2019-07-22 00:00:00','2020-09-15 00:00:00'),(21,50,6666,'6666','2020-11-10 09:17:00','2020-11-13 09:17:00');
/*!40000 ALTER TABLE `projekatplan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ptt`
--

DROP TABLE IF EXISTS `ptt`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ptt` (
  `PTT_ID` int NOT NULL AUTO_INCREMENT,
  `Sifra` int NOT NULL,
  `Naziv` text,
  PRIMARY KEY (`PTT_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ptt`
--

LOCK TABLES `ptt` WRITE;
/*!40000 ALTER TABLE `ptt` DISABLE KEYS */;
INSERT INTO `ptt` VALUES (1,1,'PTT 1'),(2,2,'PTT 2'),(3,3,'PTT 3'),(4,4,'PTT 4'),(5,5,'PTT 5'),(6,6,'PTT 6'),(7,7,'PTT 7'),(8,8,'PTT 8'),(9,9,'PTT 9'),(10,10,'PTT 10');
/*!40000 ALTER TABLE `ptt` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `resursi`
--

DROP TABLE IF EXISTS `resursi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `resursi` (
  `Resursi_ID` int NOT NULL AUTO_INCREMENT,
  `Naziv` text,
  PRIMARY KEY (`Resursi_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `resursi`
--

LOCK TABLES `resursi` WRITE;
/*!40000 ALTER TABLE `resursi` DISABLE KEYS */;
INSERT INTO `resursi` VALUES (1,'Basic IndustriesCrew'),(2,'BacicsCrew'),(3,'Public UtilitiesCrew'),(4,'EnergyCrew'),(5,'MiscellaneousCrew'),(6,'TechnologyCrew'),(7,'Technology2Crew'),(8,'CapitalCrew'),(9,'Health CareCrew'),(10,'TechnologyCrew'),(11,'Capital2 GoodsCrew'),(12,'Capital GoodsCrew'),(13,'Health2 CareCrew'),(14,'Transportation2Crew'),(15,'Basic IndustriesCrew'),(16,'OverallCrew'),(17,'Public UtilitiesCrew'),(18,'TransportingCrew'),(19,'FinanceCrew'),(20,'Finance2Crew'),(21,'Transportation4Crew'),(22,'CustomerCrew'),(23,'Consumer DurablesCrew'),(24,'Consumer2 DurablesCrew'),(25,'Health3 CareCrew');
/*!40000 ALTER TABLE `resursi` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `uloge`
--

DROP TABLE IF EXISTS `uloge`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `uloge` (
  `Uloge_ID` int NOT NULL AUTO_INCREMENT,
  `Sifra` int NOT NULL,
  `Naziv` text,
  `Opis` text,
  PRIMARY KEY (`Uloge_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `uloge`
--

LOCK TABLES `uloge` WRITE;
/*!40000 ALTER TABLE `uloge` DISABLE KEYS */;
INSERT INTO `uloge` VALUES (1,1,'Administrator','Ima puno pravo na sve'),(2,2,'Korisnik','Ima pravo na unos realizacije i projekat aktivnost plana'),(3,3,'Razvijac','com.fc2.Transcof'),(4,4,'Admin_org','Ima pravo na unos organizacionih jedinica i aktivnost planova'),(5,5,'Korisnik_report','Ima pravo na pregled izvještaja');
/*!40000 ALTER TABLE `uloge` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'projektnaorganizacija'
--

--
-- Dumping routines for database 'projektnaorganizacija'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-11-15  9:03:44
