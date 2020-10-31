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
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `projekatplan`
--

LOCK TABLES `projekatplan` WRITE;
/*!40000 ALTER TABLE `projekatplan` DISABLE KEYS */;
INSERT INTO `projekatplan` VALUES (1,8,1,'Fluoxetine','2015-10-13 00:00:00','2020-01-06 00:00:00'),(2,18,2,'D TIME SINUS','2016-03-08 00:00:00','2020-12-08 00:00:00'),(3,16,3,'Butalbital','2020-09-10 00:00:00','2021-06-09 00:00:00'),(4,15,4,'Mirtazapine','2020-02-10 00:00:00','2021-01-03 00:00:00'),(5,4,5,'Hand Sanitizer','2017-05-22 00:00:00','2017-08-11 00:00:00'),(6,17,6,'Klor-Con','2019-08-10 00:00:00','2019-10-20 00:00:00'),(7,16,7,'FRESH JUICE E SERUM','2018-10-03 00:00:00','2018-11-08 00:00:00'),(8,8,8,'Duloxetine','2020-09-11 00:00:00','2020-12-30 00:00:00'),(9,8,9,'Temporary','2020-09-15 00:00:00','2021-11-13 00:00:00'),(10,5,10,'Uniretic','2019-03-22 00:00:00','2019-09-21 00:00:00'),(11,19,11,'Ramipril','2017-10-08 00:00:00','2018-12-14 00:00:00'),(12,1,12,'Coast Maple','2017-02-03 00:00:00','2018-07-26 00:00:00'),(13,8,13,'Valium','2016-05-14 00:00:00','2019-03-04 00:00:00'),(14,16,14,'SPF 15','2015-03-02 00:00:00','2018-11-17 00:00:00'),(15,6,15,'Pentoxifylline','2017-02-08 00:00:00','2017-09-28 00:00:00'),(16,3,16,'SANITIZER','2020-08-10 00:00:00','2020-08-19 00:00:00'),(17,9,17,'Chloroquine phosphate','2016-01-16 00:00:00','2016-07-15 00:00:00'),(18,16,18,'Aurum Prunus','2017-10-08 00:00:00','2018-07-19 00:00:00'),(19,3,19,'Sweet Honey','2019-10-29 00:00:00','2020-10-14 00:00:00'),(20,3,20,'Horse Epithelium','2019-07-22 00:00:00','2020-09-15 00:00:00');
/*!40000 ALTER TABLE `projekatplan` ENABLE KEYS */;
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
