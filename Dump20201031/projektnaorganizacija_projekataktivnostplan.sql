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
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `projekataktivnostplan`
--

LOCK TABLES `projekataktivnostplan` WRITE;
/*!40000 ALTER TABLE `projekataktivnostplan` DISABLE KEYS */;
INSERT INTO `projekataktivnostplan` VALUES (1,NULL,1,1,'Childrens Acetaminophen Melts','2015-02-16 00:00:00','2015-10-10 00:00:00','CZK',83.4),(2,NULL,2,16,'PENNSAID','2020-03-22 00:00:00','2020-11-23 00:00:00','RUB',235.4),(3,NULL,3,7,'Leucovorin','2019-05-19 00:00:00','2019-07-13 00:00:00','CNY',239.7),(4,NULL,4,2,'Fosamax','2019-08-01 00:00:00','2019-08-05 00:00:00','AZN',235.9),(5,NULL,5,10,'Mirtazapine','2020-05-04 00:00:00','2020-07-20 00:00:00','COP',189.1),(6,NULL,6,6,'Glipizide and Metformin Hydrochloride','2017-04-20 00:00:00','2017-06-09 00:00:00','IDR',167),(7,NULL,7,3,'BeeGentle','2019-02-16 00:00:00','2020-01-18 00:00:00','KES',105.2),(8,NULL,8,15,'emuaidMAX','2017-05-22 00:00:00','2017-09-01 00:00:00','SOS',286.2),(9,NULL,9,11,'Spironolactone','2020-05-01 00:00:00','2021-09-28 00:00:00','CNY',148.2),(10,NULL,10,12,'Childrens Allergy Relief','2017-07-09 00:00:00','2018-05-24 00:00:00','AFN',146.4),(11,NULL,11,4,'ALOE VESTA DAILY MOISTURIZER','2017-07-23 00:00:00','2019-11-12 00:00:00','RUB',216.8),(12,NULL,12,5,'MoviPrep','2021-11-23 00:00:00','2021-12-09 00:00:00','PLN',180.7),(13,NULL,13,19,'Sulfamethoxazole and Trimethoprim','2016-12-20 00:00:00','2017-09-26 00:00:00','CNY',184.9),(14,NULL,14,9,'Olanzapine','2017-07-16 00:00:00','2018-09-14 00:00:00','USD',108.5),(15,NULL,15,17,'Amlodipine Besylate','2017-06-07 00:00:00','2018-10-15 00:00:00','IDR',41),(16,NULL,16,8,'Junior Pain Relief','2020-05-19 00:00:00','2020-05-30 00:00:00','ARS',66.6),(17,NULL,17,18,'White (Mexican) Dock','2019-05-30 00:00:00','2020-05-14 00:00:00','CNY',282.8),(18,NULL,18,13,'Topcare Cold Head Congestion','2018-02-10 00:00:00','2018-09-24 00:00:00','USD',187.6),(19,NULL,19,14,'Montelukast Sodium','2017-04-19 00:00:00','2018-09-01 00:00:00','CNY',284.6),(20,NULL,20,20,'OXALIPLATIN','2016-08-12 00:00:00','2018-09-03 00:00:00','IDR',218.7);
/*!40000 ALTER TABLE `projekataktivnostplan` ENABLE KEYS */;
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
