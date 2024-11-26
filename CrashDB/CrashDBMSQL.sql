-- MySQL dump 10.13  Distrib 8.0.38, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: crashbandicootdb
-- ------------------------------------------------------
-- Server version	8.3.0

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
-- Table structure for table `level`
--

DROP TABLE IF EXISTS `level`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `level` (
  `idLevel` int NOT NULL AUTO_INCREMENT,
  `idScore` int NOT NULL,
  PRIMARY KEY (`idLevel`),
  UNIQUE KEY `ID_Level_UNIQUE` (`idLevel`),
  KEY `fk_idScore_idx` (`idScore`),
  CONSTRAINT `fk_idScore` FOREIGN KEY (`idScore`) REFERENCES `score` (`idScore`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `level`
--

LOCK TABLES `level` WRITE;
/*!40000 ALTER TABLE `level` DISABLE KEYS */;
/*!40000 ALTER TABLE `level` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `player`
--

DROP TABLE IF EXISTS `player`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `player` (
  `idPlayer` int NOT NULL AUTO_INCREMENT,
  `Nickname` varchar(45) NOT NULL,
  `LastConnection` datetime NOT NULL,
  PRIMARY KEY (`idPlayer`),
  UNIQUE KEY `idPlayer_UNIQUE` (`idPlayer`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `player`
--

LOCK TABLES `player` WRITE;
/*!40000 ALTER TABLE `player` DISABLE KEYS */;
INSERT INTO `player` VALUES (1,'VicPDJ','2024-11-20 17:24:00'),(4,'VicPDJ','2024-11-20 17:24:00'),(5,'VicPDJ','2024-11-20 17:24:00'),(6,'AndyAEJ','2024-11-26 17:31:00'),(7,'Alceo','0000-00-00 00:00:00'),(8,'BUMBUM','2024-11-13 17:33:00');
/*!40000 ALTER TABLE `player` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `saveslot`
--

DROP TABLE IF EXISTS `saveslot`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `saveslot` (
  `idSaveSlot` int NOT NULL AUTO_INCREMENT,
  `idPlayer` int NOT NULL,
  `idLevel` int NOT NULL,
  `Lives` int NOT NULL,
  `SaveDate` datetime NOT NULL,
  PRIMARY KEY (`idSaveSlot`),
  UNIQUE KEY `ID_SaveSlot_UNIQUE` (`idSaveSlot`),
  KEY `fk_idPlayer_idx` (`idPlayer`),
  KEY `fk_idLevel_idx` (`idLevel`),
  CONSTRAINT `fk_idLevel` FOREIGN KEY (`idLevel`) REFERENCES `level` (`idLevel`) ON UPDATE CASCADE,
  CONSTRAINT `fk_idPlayer` FOREIGN KEY (`idPlayer`) REFERENCES `player` (`idPlayer`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `saveslot`
--

LOCK TABLES `saveslot` WRITE;
/*!40000 ALTER TABLE `saveslot` DISABLE KEYS */;
/*!40000 ALTER TABLE `saveslot` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `score`
--

DROP TABLE IF EXISTS `score`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `score` (
  `idScore` int NOT NULL AUTO_INCREMENT,
  `idPlayer` int NOT NULL,
  `Score` int NOT NULL,
  `Date` datetime NOT NULL,
  PRIMARY KEY (`idScore`),
  UNIQUE KEY `idScore_UNIQUE` (`idScore`),
  KEY `fk_idPlayer_idx` (`idPlayer`),
  CONSTRAINT `fk_idPlayerScr` FOREIGN KEY (`idPlayer`) REFERENCES `player` (`idPlayer`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `score`
--

LOCK TABLES `score` WRITE;
/*!40000 ALTER TABLE `score` DISABLE KEYS */;
/*!40000 ALTER TABLE `score` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-11-26 17:40:21
