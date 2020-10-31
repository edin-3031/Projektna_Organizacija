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
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-10-31 16:09:08
