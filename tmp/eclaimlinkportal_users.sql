-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: eclaimlinkportal
-- ------------------------------------------------------
-- Server version	5.7.12-log

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
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Username` varchar(255) NOT NULL,
  `ApplicationName` varchar(100) DEFAULT NULL,
  `Email` varchar(128) NOT NULL,
  `Comment` varchar(255) DEFAULT NULL,
  `Password` varchar(128) NOT NULL,
  `PasswordQuestion` varchar(255) DEFAULT NULL,
  `PasswordAnswer` varchar(255) DEFAULT NULL,
  `IsApproved` tinyint(1) DEFAULT NULL,
  `LastActivityDate` datetime(6) DEFAULT NULL,
  `LastLoginDate` datetime(6) DEFAULT NULL,
  `LastPasswordChangedDate` datetime(6) DEFAULT NULL,
  `CreationDate` datetime(6) DEFAULT NULL,
  `IsOnLine` tinyint(1) DEFAULT NULL,
  `IsLockedOut` tinyint(1) DEFAULT NULL,
  `LastLockedOutDate` datetime(6) DEFAULT NULL,
  `FailedPasswordAttemptCount` int(11) DEFAULT NULL,
  `FailedPasswordAttemptWindowStart` datetime(6) DEFAULT NULL,
  `FailedPasswordAnswerAttemptCount` int(11) DEFAULT NULL,
  `FailedPasswordAnswerAttemptWindowStart` datetime(6) DEFAULT NULL,
  `IsAnonymous` tinyint(1) DEFAULT NULL,
  `FacilityId` int(11) DEFAULT NULL,
  `Name` varchar(100) DEFAULT NULL,
  `UserType` int(11) DEFAULT NULL,
  `userRole` int(11) DEFAULT NULL,
  `phone` varchar(50) DEFAULT NULL,
  `Address` varchar(200) DEFAULT NULL,
  `validated` tinyint(1) DEFAULT NULL,
  `groupId` int(11) DEFAULT NULL,
  `LoginKey` varchar(50) DEFAULT NULL,
  `demo` tinyint(1) DEFAULT NULL,
  `Agree` int(11) DEFAULT NULL,
  `AgreemantDate` datetime(6) DEFAULT NULL,
  `mobilePassword` varchar(35) DEFAULT NULL,
  `ipwhitelist` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `AK_Username` (`Username`),
  KEY `FK_Users_Facilities` (`FacilityId`),
  KEY `FK_Users_Groups` (`groupId`),
  CONSTRAINT `FK_Users_Facilities` FOREIGN KEY (`FacilityId`) REFERENCES `facilities` (`ID`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `FK_Users_Groups` FOREIGN KEY (`groupId`) REFERENCES `groups` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-05-19 10:12:56
