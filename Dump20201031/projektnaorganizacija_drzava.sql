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
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `drzava`
--

LOCK TABLES `drzava` WRITE;
/*!40000 ALTER TABLE `drzava` DISABLE KEYS */;
INSERT INTO `drzava` VALUES (1,1,'Thailand'),(2,2,'China'),(3,3,'Philippines'),(4,4,'Thailand'),(5,5,'China'),(6,6,'Philippines'),(7,7,'Indonesia'),(8,8,'Portugal'),(9,9,'Brazil'),(10,10,'Bangladesh'),(11,11,'Poland'),(12,12,'Cameroon'),(13,13,'China'),(14,14,'Indonesia'),(15,15,'Senegal'),(16,16,'Jordan'),(17,17,'Japan'),(18,18,'Thailand'),(19,19,'Pakistan'),(20,20,'Sri Lanka'),(21,21,'Costa Rica'),(22,22,'China'),(23,23,'China'),(24,24,'Japan'),(25,25,'Poland'),(26,26,'Sweden'),(27,27,'Sweden'),(28,28,'Norway'),(29,29,'France'),(30,30,'China'),(31,31,'Iran'),(32,32,'Portugal'),(33,33,'Nigeria'),(34,34,'Indonesia'),(35,35,'Liberia'),(36,36,'Indonesia'),(37,37,'China'),(38,38,'United States'),(39,39,'Germany'),(40,40,'South Korea'),(41,41,'Greece'),(42,42,'United Kingdom'),(43,43,'Argentina'),(44,44,'Luxembourg'),(45,45,'China'),(46,46,'Sweden'),(47,47,'France'),(48,48,'Ireland'),(49,49,'China'),(50,50,'Sweden');
/*!40000 ALTER TABLE `drzava` ENABLE KEYS */;
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
