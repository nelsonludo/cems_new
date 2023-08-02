-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 27, 2022 at 06:25 PM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cems`
--

-- --------------------------------------------------------

--
-- Table structure for table `cems_users`
-- 

CREATE TABLE `cems_users` (
  `user_id` int(11) NOT NULL,
  `user_name` varchar(100) NOT NULL,
  `user_phone_number` varchar(9) NOT NULL,
  `user_email` varchar(50) NOT NULL,
  `user_password` varchar(12) NOT NULL,
  `title_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `cems_users`
--

INSERT INTO `cems_users` (`user_id`, `user_name`, `user_phone_number`, `user_email`, `user_password`, `title_id`) VALUES
(1, 'admin', '655483496', 'ict@ccousp.cm', 'admin', 1);

-- --------------------------------------------------------

--
-- Table structure for table `cems_equipments`
--

CREATE TABLE `cems_equipments` (
  `equipment_id` int(11) NOT NULL,
  `equipment_type` varchar(100) NOT NULL,
  `equipment_state` varchar(100) NOT NULL,
  `post_id` int(11) NOT NULL,
  `hall_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `cems_halls`
--

CREATE TABLE `cems_halls` (
  `hall_id` int(11) NOT NULL,
  `hall_name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `cems_posts`
--

CREATE TABLE `cems_posts` (
  `post_id` int(11) NOT NULL,
  `hall_id` int(11) NOT NULL,
  `post_state` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `cems_titles`
--

CREATE TABLE `cems_titles` (
  `title_id` int(11) NOT NULL,
  `title_name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `cems_titles`
--

INSERT INTO `cems_titles` (`title_id`, `title_name`) VALUES
(1, 'admin'),
(2, 'user');
-- --------------------------------------------------------

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cems_equipments`
--
ALTER TABLE `cems_equipments`
  ADD PRIMARY KEY (`equipment_id`),
  ADD KEY `post_id` (`post_id`),
  ADD KEY `cems_equipments_ibfk_2` (`hall_id`);

--
-- Indexes for table `cems_halls`
--
ALTER TABLE `cems_halls`
  ADD PRIMARY KEY (`hall_id`);

--
-- Indexes for table `cems_posts`
--
ALTER TABLE `cems_posts`
  ADD PRIMARY KEY (`post_id`),
  ADD KEY `hall_id` (`hall_id`);

--
-- Indexes for table `cems_titles`
--
ALTER TABLE `cems_titles`
  ADD PRIMARY KEY (`title_id`);

--
-- Indexes for table `cems_users`
--
ALTER TABLE `cems_users`
  ADD PRIMARY KEY (`user_id`),
  ADD KEY `title_id` (`title_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cems_equipments`
--
ALTER TABLE `cems_equipments`
  MODIFY `equipment_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `cems_halls`
--
ALTER TABLE `cems_halls`
  MODIFY `hall_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `cems_titles`
--
ALTER TABLE `cems_titles`
  MODIFY `title_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `cems_users`
--
ALTER TABLE `cems_users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `cems_equipments`
--
ALTER TABLE `cems_equipments`
  ADD CONSTRAINT `cems_equipments_ibfk_1` FOREIGN KEY (`post_id`) REFERENCES `cems_posts` (`post_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `cems_equipments_ibfk_2` FOREIGN KEY (`hall_id`) REFERENCES `cems_halls` (`hall_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `cems_posts`
--
ALTER TABLE `cems_posts`
  ADD CONSTRAINT `cems_posts_ibfk_1` FOREIGN KEY (`hall_id`) REFERENCES `cems_halls` (`hall_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `cems_users`
--
ALTER TABLE `cems_users`
  ADD CONSTRAINT `cems_users_ibfk_1` FOREIGN KEY (`title_id`) REFERENCES `cems_titles` (`title_id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
