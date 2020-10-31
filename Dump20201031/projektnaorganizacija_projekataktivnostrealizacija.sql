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
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `projekataktivnostrealizacija`
--

LOCK TABLES `projekataktivnostrealizacija` WRITE;
/*!40000 ALTER TABLE `projekataktivnostrealizacija` DISABLE KEYS */;
INSERT INTO `projekataktivnostrealizacija` VALUES (1,1,NULL,9,'2018-01-26 00:00:00',72.9,'Ca in situ skin lip'),(2,2,NULL,1,'2020-01-07 00:00:00',38.4,'Dislocation ankle-closed'),(3,3,NULL,8,'2018-04-26 00:00:00',16.9,'Female infertility NEC'),(4,4,NULL,6,'2019-11-17 00:00:00',20.3,'Vertigo'),(5,5,NULL,1,'2019-03-31 00:00:00',5.3,'Bsl cell ca scalp/skn nk'),(6,6,NULL,4,'2019-05-25 00:00:00',35.7,'Deep thromb postpar-unsp'),(7,7,NULL,10,'2015-11-25 00:00:00',22.7,'Broken tooth-complicated'),(8,8,NULL,9,'2020-10-11 00:00:00',14.4,'Fetal-matern hem-antepar'),(9,9,NULL,3,'2019-12-11 00:00:00',23.9,'Shrt lst uni nral hdache'),(10,10,NULL,4,'2020-07-13 00:00:00',18.3,'Hx-health hazard NOS'),(11,11,NULL,5,'2017-09-15 00:00:00',22.6,'Bungee jumping'),(12,12,NULL,10,'2016-10-12 00:00:00',12.1,'Desensitiza to allergens'),(13,13,NULL,7,'2017-06-06 00:00:00',25.2,'Lymphoid mal NEC abdom'),(14,14,NULL,6,'2017-04-14 00:00:00',9.3,'Excess physical exert'),(15,15,NULL,9,'2019-03-15 00:00:00',2.6,'Abn uterus NEC-antepart'),(16,16,NULL,5,'2016-06-20 00:00:00',15.4,'Renal vascular disorder'),(17,17,NULL,6,'2020-05-10 00:00:00',19.9,'TB of bladder-no exam'),(18,18,NULL,1,'2018-01-02 00:00:00',26.9,'Const aplastc anemia NEC'),(19,19,NULL,2,'2020-03-14 00:00:00',28.2,'Sprain of ankle NEC'),(20,20,NULL,5,'2018-11-19 00:00:00',21.6,'Anemia d/t antineo chemo');
/*!40000 ALTER TABLE `projekataktivnostrealizacija` ENABLE KEYS */;
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
