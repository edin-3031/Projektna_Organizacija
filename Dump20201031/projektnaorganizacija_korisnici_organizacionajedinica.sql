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
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `korisnici_organizacionajedinica`
--

LOCK TABLES `korisnici_organizacionajedinica` WRITE;
/*!40000 ALTER TABLE `korisnici_organizacionajedinica` DISABLE KEYS */;
INSERT INTO `korisnici_organizacionajedinica` VALUES (1,6,NULL,16),(2,10,NULL,20),(3,1,NULL,13),(4,1,NULL,18),(5,9,NULL,1),(6,6,NULL,6),(7,9,NULL,19),(8,9,NULL,17),(9,9,NULL,11),(10,7,NULL,1),(11,7,NULL,3),(12,4,NULL,15),(13,1,NULL,2),(14,4,NULL,3),(15,5,NULL,13),(16,2,NULL,14),(17,7,NULL,19),(18,7,NULL,9),(19,10,NULL,18),(20,3,NULL,11),(21,4,NULL,11),(22,10,NULL,17),(23,3,NULL,6),(24,9,NULL,8),(25,3,NULL,5),(26,8,NULL,2),(27,6,NULL,2),(28,1,NULL,15),(29,8,NULL,5),(30,7,NULL,8),(31,8,NULL,8),(32,5,NULL,2),(33,8,NULL,5),(34,8,NULL,6),(35,3,NULL,7),(36,1,NULL,11),(37,9,NULL,7),(38,4,NULL,19),(39,4,NULL,19),(40,5,NULL,16),(41,2,NULL,15),(42,8,NULL,17),(43,2,NULL,13),(44,6,NULL,5),(45,6,NULL,12),(46,3,NULL,19),(47,6,NULL,4),(48,10,NULL,2),(49,5,NULL,18),(50,5,NULL,1);
/*!40000 ALTER TABLE `korisnici_organizacionajedinica` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-10-31 16:09:09
