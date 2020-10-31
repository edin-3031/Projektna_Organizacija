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
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `organizacionajedinica`
--

LOCK TABLES `organizacionajedinica` WRITE;
/*!40000 ALTER TABLE `organizacionajedinica` DISABLE KEYS */;
INSERT INTO `organizacionajedinica` VALUES (1,1,4,6,'Stehr-Bergnaum','5367 Moose Avenue'),(2,2,7,3,'Pouros, Crist and Larkin','6405 Nelson Plaza'),(3,2,10,38,'Kessler-Stark','4870 Hanover Trail'),(4,15,4,15,'Champlin, Auer and Spinka','0 Northview Parkway'),(5,6,6,46,'Mante-Leuschke','81801 Schiller Pass'),(6,4,5,30,'Marquardt, Kohler and Harris','6992 Charing Cross Lane'),(7,6,5,46,'Walsh, Gislason and Spencer','0 Sheridan Crossing'),(8,5,3,30,'Dare Inc','730 Harbort Hill'),(9,3,7,23,'Hirthe, Langosh and Weber','51218 Pawling Crossing'),(10,10,2,22,'DuBuque LLC','00499 Nevada Lane'),(11,12,7,33,'Hegmann Inc','133 Helena Alley'),(12,11,7,1,'Lindgren, Greenholt and Grady','8937 Spohn Crossing'),(13,6,8,18,'Sanford and Sons','77883 Karstens Alley'),(14,1,9,49,'Goodwin LLC','279 Grasskamp Road'),(15,8,5,30,'Shanahan-Windler','2 Pleasure Crossing'),(16,12,9,27,'Boyer, Bogisich and Daniel','50 Logan Center'),(17,1,8,46,'Murphy-Keeling','50501 Clove Drive'),(18,14,9,41,'Lakin-Paucek','0 Oak Avenue'),(19,13,9,36,'Wolf LLC','54239 Hayes Park'),(20,2,2,6,'Will, Kautzer and Hoeger','704 Vidon Terrace');
/*!40000 ALTER TABLE `organizacionajedinica` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-10-31 16:09:07
