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
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-10-31 16:09:07
