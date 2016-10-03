-- MySQL dump 10.13  Distrib 5.6.16, for Win32 (x86)
--
-- Host: localhost    Database: vendo_lks
-- ------------------------------------------------------
-- Server version	5.6.16

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `log_mach_status`
--

DROP TABLE IF EXISTS `log_mach_status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `log_mach_status` (
  `logNo` int(11) NOT NULL AUTO_INCREMENT,
  `logDateTime` datetime NOT NULL,
  `machNo` varchar(6) COLLATE latin1_general_ci NOT NULL,
  `machStat` int(10) NOT NULL,
  `machCtrl` int(10) NOT NULL,
  `machUtil` int(10) NOT NULL,
  PRIMARY KEY (`logNo`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `log_mach_status`
--

LOCK TABLES `log_mach_status` WRITE;
/*!40000 ALTER TABLE `log_mach_status` DISABLE KEYS */;
INSERT INTO `log_mach_status` VALUES (1,'2016-09-08 13:24:44','MA001',200,255,255),(2,'2016-09-08 13:26:11','MA001',200,255,255),(3,'2016-09-08 13:27:04','MA001',200,255,255),(4,'2016-09-08 13:33:30','MA001',200,255,255),(5,'2016-09-13 10:13:59','MA001',200,255,255),(6,'2016-09-13 10:15:26','MA001',200,255,255),(7,'2016-09-13 10:25:28','MA001',200,255,255);
/*!40000 ALTER TABLE `log_mach_status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `log_trans`
--

DROP TABLE IF EXISTS `log_trans`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `log_trans` (
  `logNo` int(11) NOT NULL AUTO_INCREMENT,
  `logDateTime` datetime NOT NULL,
  `refNo` varchar(12) COLLATE latin1_general_ci NOT NULL,
  `machNo` varchar(5) COLLATE latin1_general_ci NOT NULL,
  `prodNo` varchar(5) COLLATE latin1_general_ci NOT NULL,
  `mobileNo` varchar(15) COLLATE latin1_general_ci NOT NULL,
  `totalDue` varchar(10) COLLATE latin1_general_ci NOT NULL,
  `totalInsert` varchar(10) COLLATE latin1_general_ci NOT NULL,
  PRIMARY KEY (`logNo`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `log_trans`
--

LOCK TABLES `log_trans` WRITE;
/*!40000 ALTER TABLE `log_trans` DISABLE KEYS */;
INSERT INTO `log_trans` VALUES (1,'2016-09-08 13:33:55','001160908A02','MA001','btnPr','09205697164','40','');
/*!40000 ALTER TABLE `log_trans` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `man_advertisement`
--

DROP TABLE IF EXISTS `man_advertisement`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `man_advertisement` (
  `advertisementNo` varchar(7) COLLATE latin1_general_ci NOT NULL,
  `advertisementCode` varchar(15) COLLATE latin1_general_ci NOT NULL,
  `advertisementName` varchar(25) COLLATE latin1_general_ci NOT NULL,
  `startDate` datetime NOT NULL,
  `expiryDate` datetime NOT NULL,
  `timeSlotNo` int(2) NOT NULL,
  `timeSlotStart` varchar(5) COLLATE latin1_general_ci NOT NULL,
  `timeSlotEnd` varchar(5) COLLATE latin1_general_ci NOT NULL,
  `typeOfFile` varchar(50) COLLATE latin1_general_ci NOT NULL,
  `location` varchar(150) COLLATE latin1_general_ci NOT NULL,
  `sizeOnDisk` varchar(50) COLLATE latin1_general_ci NOT NULL,
  `length` varchar(8) COLLATE latin1_general_ci NOT NULL,
  `frameWidth` varchar(5) COLLATE latin1_general_ci NOT NULL,
  `frameHeight` varchar(5) COLLATE latin1_general_ci NOT NULL,
  `dataRate` varchar(15) COLLATE latin1_general_ci NOT NULL,
  `totalBitrate` varchar(15) COLLATE latin1_general_ci NOT NULL,
  `frameRate` varchar(50) COLLATE latin1_general_ci NOT NULL,
  `adStatusNo` int(2) NOT NULL,
  `isVisible` char(1) COLLATE latin1_general_ci NOT NULL DEFAULT 'Y',
  PRIMARY KEY (`advertisementNo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `man_advertisement`
--

LOCK TABLES `man_advertisement` WRITE;
/*!40000 ALTER TABLE `man_advertisement` DISABLE KEYS */;
/*!40000 ALTER TABLE `man_advertisement` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `man_franchisee`
--

DROP TABLE IF EXISTS `man_franchisee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `man_franchisee` (
  `franchiseeNo` varchar(6) COLLATE latin1_general_ci NOT NULL,
  `franchiseeCode` varchar(25) COLLATE latin1_general_ci NOT NULL,
  `franchiseeName` varchar(50) COLLATE latin1_general_ci NOT NULL,
  `franchiseeTypeNo` int(2) NOT NULL,
  `first` varchar(25) COLLATE latin1_general_ci NOT NULL,
  `middle` varchar(25) CHARACTER SET latin1 COLLATE latin1_general_cs NOT NULL,
  `last` varchar(25) COLLATE latin1_general_ci NOT NULL,
  `contactPerson` varchar(50) COLLATE latin1_general_ci NOT NULL,
  `contactNo1` varchar(25) COLLATE latin1_general_ci NOT NULL,
  `contactNo2` varchar(25) COLLATE latin1_general_ci NOT NULL,
  `email` varchar(50) COLLATE latin1_general_ci NOT NULL,
  `address` varchar(250) COLLATE latin1_general_ci NOT NULL,
  `username` varchar(25) COLLATE latin1_general_ci NOT NULL,
  `password` varchar(8) COLLATE latin1_general_ci NOT NULL,
  `machNo` varchar(6) COLLATE latin1_general_ci NOT NULL,
  `isActive` char(1) COLLATE latin1_general_ci NOT NULL DEFAULT 'Y',
  `isVisible` char(1) COLLATE latin1_general_ci NOT NULL DEFAULT 'Y',
  PRIMARY KEY (`franchiseeNo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `man_franchisee`
--

LOCK TABLES `man_franchisee` WRITE;
/*!40000 ALTER TABLE `man_franchisee` DISABLE KEYS */;
INSERT INTO `man_franchisee` VALUES ('CA001','CA001','Dela Cruz, Juan Reyes',1,'Juan','Reyes','Dela Cruz','','','','Juan@mail.com','','juan','password','MA001','Y','Y');
/*!40000 ALTER TABLE `man_franchisee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `man_item`
--

DROP TABLE IF EXISTS `man_item`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `man_item` (
  `itmNo` varchar(4) COLLATE latin1_general_ci NOT NULL,
  `itmCode` varchar(40) COLLATE latin1_general_ci NOT NULL,
  `itmName` varchar(40) COLLATE latin1_general_ci NOT NULL,
  `itmTypeNo` int(2) NOT NULL,
  `description` varchar(250) COLLATE latin1_general_ci NOT NULL,
  `networkNo` int(2) NOT NULL,
  `packageNo` int(2) NOT NULL,
  `cost` varchar(10) COLLATE latin1_general_ci NOT NULL,
  `price` varchar(10) COLLATE latin1_general_ci NOT NULL,
  `validity` varchar(3) COLLATE latin1_general_ci DEFAULT NULL,
  `validityUnit` varchar(25) COLLATE latin1_general_ci DEFAULT NULL,
  `logoLocation` varchar(250) COLLATE latin1_general_ci DEFAULT NULL,
  `isActive` char(1) COLLATE latin1_general_ci NOT NULL DEFAULT 'Y',
  `isVisible` char(1) COLLATE latin1_general_ci NOT NULL DEFAULT 'Y',
  PRIMARY KEY (`itmNo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `man_item`
--

LOCK TABLES `man_item` WRITE;
/*!40000 ALTER TABLE `man_item` DISABLE KEYS */;
INSERT INTO `man_item` VALUES ('01','GIGA50','GigaSurf 50',1,'1GB of open access volume data with FREE 300MB of iflix, Spinnr, YouTube, Vimeo, DailyMotion, Dubsmash and Skype Qik, all valid for 3 days',2,5,'50.00','50.00','3','Days','C:\\Users\\Earl\\Pictures\\a1.JPG','Y','Y'),('02','TEXT50','Big Unli Text 50',1,'Unlimited Smart, SUN, TNT SMS 30 MB Data',2,3,'50.00','50.00','7','Days','C:\\Users\\Earl\\Pictures\\a2.JPG','Y','Y'),('03','GoALLNET25','GoALLNET25',1,'Unlimited texts to all networks + 75 mins of calls to Globe/TM + 5 mins of calls to all networks + 5MB Facebook',1,4,'25.00','25.00','1','Days','C:\\Users\\Earl\\Pictures\\a3.JPG','Y','Y'),('04','SULITXT15','SULITXT 15',1,'Send 100 text messages to other Globe/TM subscribers for one day',1,3,'15.00','15.00','1','Days','C:\\Users\\Earl\\Pictures\\a4.JPG','Y','Y');
/*!40000 ALTER TABLE `man_item` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `man_machine`
--

DROP TABLE IF EXISTS `man_machine`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `man_machine` (
  `machNo` varchar(6) COLLATE latin1_general_ci NOT NULL,
  `machCode` varchar(25) COLLATE latin1_general_ci NOT NULL,
  `machName` varchar(25) COLLATE latin1_general_ci NOT NULL,
  `serialNo` varchar(30) COLLATE latin1_general_ci NOT NULL,
  `simNo` varchar(13) COLLATE latin1_general_ci NOT NULL,
  `firmwareVer` varchar(8) COLLATE latin1_general_ci NOT NULL,
  `softwareVer` varchar(8) COLLATE latin1_general_ci NOT NULL,
  `machStat` int(1) NOT NULL DEFAULT '0',
  `isVisible` char(1) COLLATE latin1_general_ci NOT NULL DEFAULT 'Y',
  PRIMARY KEY (`machNo`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `man_machine`
--

LOCK TABLES `man_machine` WRITE;
/*!40000 ALTER TABLE `man_machine` DISABLE KEYS */;
INSERT INTO `man_machine` VALUES ('MA001','MA001','MACHINE 1','BFEBFBFF000206A7','','','',1,'Y');
/*!40000 ALTER TABLE `man_machine` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `man_network`
--

DROP TABLE IF EXISTS `man_network`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `man_network` (
  `networkNo` int(2) NOT NULL AUTO_INCREMENT,
  `networkCode` varchar(15) COLLATE latin1_general_ci NOT NULL,
  `networkName` varchar(35) COLLATE latin1_general_ci NOT NULL,
  `prefixList` text COLLATE latin1_general_ci NOT NULL,
  `logo` blob,
  `isVisible` char(1) COLLATE latin1_general_ci NOT NULL DEFAULT 'Y',
  PRIMARY KEY (`networkNo`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `man_network`
--

LOCK TABLES `man_network` WRITE;
/*!40000 ALTER TABLE `man_network` DISABLE KEYS */;
INSERT INTO `man_network` VALUES (1,'GLOBE','Globe Telecom','0817,0926,0936,0994,0978,0905,0916,0927,0995,0976,0979','','Y'),(2,'SMART','Smart Communications','','','Y'),(3,'SUN','Sun Cellular','','','Y');
/*!40000 ALTER TABLE `man_network` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `man_user`
--

DROP TABLE IF EXISTS `man_user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `man_user` (
  `EmpCode` varchar(10) COLLATE latin1_general_ci NOT NULL,
  `Title` varchar(3) COLLATE latin1_general_ci NOT NULL,
  `Fname` varchar(20) COLLATE latin1_general_ci DEFAULT NULL,
  `Lname` varchar(20) COLLATE latin1_general_ci DEFAULT NULL,
  `Username` varchar(20) COLLATE latin1_general_ci DEFAULT NULL,
  `Password` varchar(64) COLLATE latin1_general_ci DEFAULT NULL,
  `accessNo` int(2) DEFAULT NULL COMMENT 'man_users_access.accessNo',
  `isVisible` char(1) COLLATE latin1_general_ci NOT NULL DEFAULT 'Y',
  PRIMARY KEY (`EmpCode`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `man_user`
--

LOCK TABLES `man_user` WRITE;
/*!40000 ALTER TABLE `man_user` DISABLE KEYS */;
INSERT INTO `man_user` VALUES ('20001','Ms','Admin','Istrator','admin','',1,'Y'),('20002','Mr','Staff','One','staff','',2,'Y'),('20003','Ms','Super','Visor','super','',3,'Y');
/*!40000 ALTER TABLE `man_user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `man_user_access`
--

DROP TABLE IF EXISTS `man_user_access`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `man_user_access` (
  `accessNo` int(2) NOT NULL,
  `accessName` varchar(20) COLLATE latin1_general_ci NOT NULL,
  `isVisible` char(1) COLLATE latin1_general_ci NOT NULL,
  PRIMARY KEY (`accessNo`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci COMMENT='reference for user access level';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `man_user_access`
--

LOCK TABLES `man_user_access` WRITE;
/*!40000 ALTER TABLE `man_user_access` DISABLE KEYS */;
INSERT INTO `man_user_access` VALUES (1,'Administrator','N'),(2,'Supervisor','Y'),(3,'Staff','Y');
/*!40000 ALTER TABLE `man_user_access` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ref_ad_status`
--

DROP TABLE IF EXISTS `ref_ad_status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ref_ad_status` (
  `adStatusNo` int(1) NOT NULL AUTO_INCREMENT,
  `adStatusName` varchar(25) COLLATE latin1_general_ci NOT NULL,
  `isVisible` char(1) COLLATE latin1_general_ci NOT NULL DEFAULT 'Y',
  PRIMARY KEY (`adStatusNo`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ref_ad_status`
--

LOCK TABLES `ref_ad_status` WRITE;
/*!40000 ALTER TABLE `ref_ad_status` DISABLE KEYS */;
INSERT INTO `ref_ad_status` VALUES (1,'Active','Y'),(2,'Inactive','Y'),(3,'Expired','Y');
/*!40000 ALTER TABLE `ref_ad_status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ref_ad_timeslot`
--

DROP TABLE IF EXISTS `ref_ad_timeslot`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ref_ad_timeslot` (
  `timeSlotNo` int(2) NOT NULL AUTO_INCREMENT,
  `timeSlotName` varchar(25) COLLATE latin1_general_ci NOT NULL,
  `timeStart` varchar(5) COLLATE latin1_general_ci DEFAULT NULL,
  `timeEnd` varchar(5) COLLATE latin1_general_ci DEFAULT NULL,
  `isVisible` char(1) COLLATE latin1_general_ci NOT NULL DEFAULT 'Y',
  PRIMARY KEY (`timeSlotNo`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ref_ad_timeslot`
--

LOCK TABLES `ref_ad_timeslot` WRITE;
/*!40000 ALTER TABLE `ref_ad_timeslot` DISABLE KEYS */;
INSERT INTO `ref_ad_timeslot` VALUES (1,'Graveyard','02:00','05:59','Y'),(2,'Breakfast','06:00','09:59','Y'),(3,'Daytime','10:00','18:59','Y'),(4,'Prime Time','19:00','22:59','Y'),(5,'Late Night','23:00','01:59','Y'),(6,'Custom...',NULL,NULL,'Y');
/*!40000 ALTER TABLE `ref_ad_timeslot` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ref_franchisee_type`
--

DROP TABLE IF EXISTS `ref_franchisee_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ref_franchisee_type` (
  `franchiseeTypeNo` int(2) NOT NULL AUTO_INCREMENT,
  `franchiseeTypeName` varchar(25) COLLATE latin1_general_ci NOT NULL,
  `isVisible` char(1) COLLATE latin1_general_ci NOT NULL DEFAULT 'Y',
  PRIMARY KEY (`franchiseeTypeNo`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ref_franchisee_type`
--

LOCK TABLES `ref_franchisee_type` WRITE;
/*!40000 ALTER TABLE `ref_franchisee_type` DISABLE KEYS */;
INSERT INTO `ref_franchisee_type` VALUES (1,'Individual','Y'),(2,'Company','Y');
/*!40000 ALTER TABLE `ref_franchisee_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ref_itm_package`
--

DROP TABLE IF EXISTS `ref_itm_package`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ref_itm_package` (
  `packageNo` int(2) NOT NULL AUTO_INCREMENT,
  `packageName` varchar(30) COLLATE latin1_general_ci NOT NULL,
  `isVisible` char(1) COLLATE latin1_general_ci NOT NULL DEFAULT 'Y',
  PRIMARY KEY (`packageNo`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ref_itm_package`
--

LOCK TABLES `ref_itm_package` WRITE;
/*!40000 ALTER TABLE `ref_itm_package` DISABLE KEYS */;
INSERT INTO `ref_itm_package` VALUES (1,'Regular','Y'),(2,'Call','Y'),(3,'Text','Y'),(4,'Call & Text','Y'),(5,'Data','Y'),(6,'International','Y');
/*!40000 ALTER TABLE `ref_itm_package` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ref_itm_type`
--

DROP TABLE IF EXISTS `ref_itm_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ref_itm_type` (
  `itmTypeNo` int(2) NOT NULL AUTO_INCREMENT,
  `itmTypeName` varchar(30) COLLATE latin1_general_ci NOT NULL,
  `isVisible` char(1) COLLATE latin1_general_ci NOT NULL DEFAULT 'Y',
  PRIMARY KEY (`itmTypeNo`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ref_itm_type`
--

LOCK TABLES `ref_itm_type` WRITE;
/*!40000 ALTER TABLE `ref_itm_type` DISABLE KEYS */;
INSERT INTO `ref_itm_type` VALUES (1,'Electronic Load','Y'),(2,'Card Load','Y');
/*!40000 ALTER TABLE `ref_itm_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ref_mach_status`
--

DROP TABLE IF EXISTS `ref_mach_status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ref_mach_status` (
  `machStat` int(1) NOT NULL AUTO_INCREMENT,
  `machStatName` varchar(25) NOT NULL,
  `isVisible` char(1) NOT NULL DEFAULT 'Y',
  PRIMARY KEY (`machStat`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ref_mach_status`
--

LOCK TABLES `ref_mach_status` WRITE;
/*!40000 ALTER TABLE `ref_mach_status` DISABLE KEYS */;
INSERT INTO `ref_mach_status` VALUES (0,'UNREGISTERED','Y'),(1,'REGISTERED','Y'),(2,'INACTIVE','Y');
/*!40000 ALTER TABLE `ref_mach_status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `set_other`
--

DROP TABLE IF EXISTS `set_other`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `set_other` (
  `function` varchar(15) COLLATE latin1_general_ci NOT NULL,
  `setValue` varchar(25) COLLATE latin1_general_ci NOT NULL,
  PRIMARY KEY (`function`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `set_other`
--

LOCK TABLES `set_other` WRITE;
/*!40000 ALTER TABLE `set_other` DISABLE KEYS */;
INSERT INTO `set_other` VALUES ('theme','Office2010Black'),('db_version','v1.0'),('systemVersion','Version 0.0.1');
/*!40000 ALTER TABLE `set_other` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-09-15 16:40:03
