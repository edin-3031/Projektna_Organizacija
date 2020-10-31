CREATE DATABASE  IF NOT EXISTS `projektnaorganizacija` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `projektnaorganizacija`;
-- MySQL dump 10.13  Distrib 8.0.21, for Win64 (x86_64)
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
  PRIMARY KEY (`Korisnici_ID`),
  KEY `IX_Korisnici_Uloge_FK` (`Uloge_FK`),
  CONSTRAINT `FK_Korisnici_Uloge_Uloge_FK` FOREIGN KEY (`Uloge_FK`) REFERENCES `uloge` (`Uloge_ID`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `korisnici`
--

LOCK TABLES `korisnici` WRITE;
/*!40000 ALTER TABLE `korisnici` DISABLE KEYS */;
INSERT INTO `korisnici` VALUES (1,1,1,'Chadwick','Valentine','+687 (422) 115-4614','cvalentine0@goo.ne.jp','qMV2lHaxfDre'),(2,3,2,'Winnifred','Henlon','+81 (699) 457-7762','whenlon1@amazon.de','lNUKH8Cv'),(3,2,3,'Phedra','Mainstone','+993 (127) 933-4749','pmainstone2@state.tx.us','1zbhAm1dI2k'),(4,2,4,'Andrew','Raatz','+55 (897) 483-3510','araatz3@dailymail.co.uk','OyMPq1Sm'),(5,3,5,'Hillery','Muglestone','+86 (615) 646-4579','hmuglestone4@si.edu','5X8Qc9t5k'),(6,3,6,'Davide','Coulton','+62 (544) 158-2335','dcoulton5@51.la','AXLVEE80pF'),(7,1,7,'Ellette','Widdecombe','+234 (632) 208-8976','ewiddecombe6@intel.com','QIO2tXpzui'),(8,3,8,'Susy','Boyack','+62 (973) 965-2089','sboyack7@discovery.com','nZCbkM'),(9,1,9,'Whitney','Frostdick','+30 (991) 624-9247','wfrostdick8@ucoz.ru','rMZ7u3p8l'),(10,1,10,'Alvan','Kester','+351 (479) 938-8000','akester9@google.com','eakF1An');
/*!40000 ALTER TABLE `korisnici` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-10-31 16:09:08
