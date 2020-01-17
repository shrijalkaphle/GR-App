-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 17, 2020 at 07:21 AM
-- Server version: 10.4.10-MariaDB
-- PHP Version: 7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `academics`
--

-- --------------------------------------------------------

--
-- Table structure for table `marks`
--

CREATE TABLE `marks` (
  `id` int(11) NOT NULL,
  `sid` int(11) NOT NULL,
  `examid` int(11) NOT NULL,
  `subjectid` int(11) NOT NULL,
  `practical` double NOT NULL,
  `theory` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `marks`
--

INSERT INTO `marks` (`id`, `sid`, `examid`, `subjectid`, `practical`, `theory`) VALUES
(12, 38, 1, 1, 12, 12),
(13, 38, 1, 2, 12, 12),
(14, 38, 1, 3, 12, 12),
(15, 38, 1, 4, 12, 12),
(16, 38, 1, 5, 12, 12),
(17, 38, 1, 6, 12, 12),
(18, 38, 1, 7, 12, 12),
(19, 38, 1, 8, 12, 12),
(20, 38, 1, 9, 12, 12),
(21, 38, 1, 10, 12, 12),
(22, 38, 1, 11, 12, 12);

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE `student` (
  `empid` int(5) NOT NULL,
  `title` varchar(5) NOT NULL,
  `name` varchar(50) NOT NULL,
  `add_num` varchar(20) NOT NULL,
  `photo` varchar(200) NOT NULL,
  `mobile` varchar(15) NOT NULL,
  `dob` varchar(50) NOT NULL,
  `email` varchar(35) NOT NULL,
  `nationality` varchar(15) NOT NULL,
  `currentaddress` varchar(100) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `doj` varchar(50) NOT NULL,
  `grade` varchar(15) NOT NULL,
  `guardianname` varchar(255) NOT NULL,
  `guardiannum` varchar(20) NOT NULL,
  `father` varchar(255) NOT NULL,
  `fathernum` varchar(20) NOT NULL,
  `mother` varchar(50) NOT NULL,
  `mothernum` varchar(50) NOT NULL,
  `peraddress` varchar(255) NOT NULL,
  `sibling` varchar(50) NOT NULL,
  `sibling_mobile` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`empid`, `title`, `name`, `add_num`, `photo`, `mobile`, `dob`, `email`, `nationality`, `currentaddress`, `gender`, `doj`, `grade`, `guardianname`, `guardiannum`, `father`, `fathernum`, `mother`, `mothernum`, `peraddress`, `sibling`, `sibling_mobile`) VALUES
(38, 'Ms.', 'Pasang Lhamu Lama', 'B22', 'profile_photos/photoid@1573195863.jpg', '9842868786', '01/09/2002', '', 'Nepalese', 'Lho, Nubri, Gorkha', 'Female', '18/04/2014', 'Eight', 'Nyima Lhamo Lama', '9842868786', 'Nildha Lama', '9845997590', 'Samden Lama', '9845997590', 'Lho, Nubri, Gorkha', 'Phurbu Sangmo Lama', ''),
(41, 'Ms.', 'Yangzen Dolma Tamang', 'B40', 'profile_photos/photoid@1573196768.jpg', '9808522480', '18/12/2006', '', 'Nepalese', 'Rasuwa', 'Female', '21/04/2014', 'Eight', 'Chhimi Tsering Tamang', '9808522480', 'Nyima Wangdi Tamang', '9823198128', 'Dolma Tsering Tamang', '9823198128', 'Rasuwa', '', ''),
(42, 'Ms.', 'Lhakpa Dolma Lama', 'B118', 'profile_photos/photoid@1573201431.jpg', '9818503436', '28/08/2002', '', 'Nepalese', 'Sindhupalchok', 'Female', '18/04/2014', 'Eight', 'Kancha Lama', '9861007724', 'Kancha Lama', '9861007724', 'Chhiring Dolma Lama', '9861007724', 'Sindhupalchok', 'Kinjo Tsomo Lama', ''),
(44, 'Ms.', 'Kinjo Tsomu Lama', 'B119', 'profile_photos/photoid@1573354760.jpg', '9818503436', '12/05/2005', '', 'Nepalese', 'Sindhupalchok', 'Female', '18/04/2014', 'Eight', 'Kancha Lama', '9861007724', 'Kancha Lama', '9861007724', 'Chhiring Dolma Lama', '9861007724', 'Sindhupalchok', 'Lhakpa Dolma Lama', ''),
(45, 'Mr.', 'Tenzin Kunphel Lama', 'B129', 'profile_photos/photoid@1573356234.jpg', '9808541504', '11/02/2003', '', 'Nepalese', 'Lamjung', 'Male', '07/06/2014', 'Eight', 'Jaghat Bhadur Lama', '9808541504', 'Sonam Pemba Lama', '9840319625', 'Sunar Gurung', '9840319625', 'Lamjung', '', ''),
(46, 'Ms.', 'Tsering Dolma Lama', 'B134', 'profile_photos/photoid@1573357376.jpg', '9803233404', '17/02/2004', '', 'Nepalese', 'Gorkha', 'Female', '18/04/2014', 'Eight', 'Nyima Lhamo', '9803233404', 'Dorje Gyaltsen', '9803233404', 'Lhakpa Bhutti', '9803233404', 'Gorkha', '', ''),
(47, 'Ms.', 'Phurbu Sangmo Lama', 'B146', 'profile_photos/photoid@1573358089.jpg', '9803003558', '24/01/2004', '', 'Nepalese', 'Gorkha', 'Female', '26/04/2014', 'Eight', 'Tsewang Dhundup', '994640015', 'Tsewang Dhundup', '9846873017', 'Lhakpa Diki Lama', '9846873017', 'Gorkha', '', ''),
(48, 'Ms.', 'Mingmar Lhamo Lama', 'B164', 'profile_photos/photoid@1573359777.jpg', '9808030991', '20/08/2003', '', 'Nepalese', 'Gorkha', 'Female', '21/04/2014', 'Eight', 'Tashi Lama', '9808030991', 'Lhakpa Tsering Lama', '9899575232', 'Dolma Lama', '9899575232', 'Gorkha', '', ''),
(50, 'Ms.', 'Karmu Sherpa', 'B165', 'profile_photos/photoid@1573359515.jpg', '9868194157', '07/11/2002', '', 'Nepalese', 'Nuwakot', 'Female', '18/04/2014', 'Eight', 'Dawa Sherpa', '9868194157', 'Dawa Sherpa', '9868194157', 'Kali Sherpa', '9868194157', 'Nuwakot', '', ''),
(59, 'Ms.', 'Phurpa Diki sherpa', 'B227', 'profile_photos/photoid@1573361050.jpg', '9869176232', '29/06/2004', '', 'Nepalese', 'Sindhupalchok', 'Female', '22/04/2017', 'Eight', 'Yangten Sherpa', '9813276829', 'Pasi Sherpa', '9818864421', 'Passang Khenddro ', '9818864421', 'Sindhupalchok', '', ''),
(60, 'Ms.', 'Barsa K.C', 'B13', 'profile_photos/photoid@1573451830.jpg', '9803914119', '22/07/2006', '', 'Nepalese', 'Manang', 'Male', '18/04/2014', 'Seven', 'Anita Gurung', '9803914119', 'Kumar K.C', '9860608838', 'Anita K.C', '9860608838', 'Manang', '', ''),
(61, 'Ms.', 'Punam Nepali', 'B26', 'profile_photos/photoid@1573615708.jpg', '9808317412', '4/10/2004', '', 'Nepalese', 'Jetgau', 'Female', '19/04/2014', 'Seven', 'Sukdev Nepali', '9808317412', 'Sukdev Nepali', '9808867654', 'Gahumati Nepali', '9808867654', 'Jetgau', '', ''),
(63, 'Ms.', 'Passang Yangchen', 'B41', 'profile_photos/photoid@1573718327.jpg', '9808030991', '18/9/2005', '', 'Nepalese', 'Shapruk', 'Female', '21/04/2014', 'Seven', 'Tashi Lama', '9808030991', 'Mingmar Tamang', '9840433329', 'Dawa Bhuti Tamang', '9840433329', 'Shapruk', '', ''),
(67, 'Ms.', 'Tsewang Dolma', 'B53', 'profile_photos/photoid@1573719129.jpg', '9826639760', '31/8/2000', '', 'Nepalese', 'Bhi, Nubri', 'Female', '18/04/2014', 'Seven', 'Tsewang Dekyi', '9813796562', 'Khamsung Wangdu', '9826639760', 'Tseten Dekyi', '9826639760', 'Bhi, Nubri', '', ''),
(68, 'Ms.', 'Tsering Choeden', 'B54', 'profile_photos/photoid@1573720071.jpg', '9741424386', '26/11/2003', '', 'Nepalese', 'Gorkha, Tsum', 'Female', '18/04/2014', 'Seven', 'Dawa Angdi', '9803554500', 'Dawa Angdi', '9741424386', 'Guthi Lama', '9741424386', 'Gorkha, Tsum', '', ''),
(69, 'Ms.', 'Tashi Choeden', 'B64', 'profile_photos/photoid@1573720753.jpg', '9863695524', '30/03/2007', '', 'Nepalese', 'Nubri, Prok', 'Female', '18/04/2014', 'Seven', 'Choeying Dolma', '9808343979', 'Nyima Samdup Lama', '9863695524', 'Tsewang Dekyi Lama', '9863695524', 'Gorkha, Prok', '', ''),
(70, 'Ms.', 'Yangchen Lhamo', 'B95', 'profile_photos/photoid@1573803355.jpg', '9746085939', '22/02/2005', '', 'Nepalese', 'Gorkha, Samma', 'Female', '4/10/2004', 'Seven', 'Ngadup Gyaltsen', '994640067', 'Ngadup Gyaltsen', '9746085939', 'Tsewang Bhutti', '9746085939', 'Gorkha, Samma', '', ''),
(71, 'Ms.', 'Nyima Choedon', 'B66', 'profile_photos/photoid@1573803932.jpg', '9860969554', '4/06/2004', '', 'Nepalese', 'Gorkha, Prok', 'Female', '21/04/2014', 'Seven', 'Tsewang Rigzin', '9808343979', 'Tsewang Rigzin', '9860969554', 'Nyima Sangmo', '9860969554', 'Nubri, Prok', '', ''),
(72, 'Mr.', 'Anil Tamang ', 'B106', 'profile_photos/photoid@1573804765.jpg', '9808766049', '7/09/2004', '', 'Nepalese', 'Sindupalchowk', 'Male', '4/10/2004', 'Seven', 'Laxman Tamang', '9808766049', 'Mangale Tamang', '9808766049', 'Dolma Tamang', '9808766049', 'Sindupalchowk', '', ''),
(73, 'Mr.', 'Lhanam Hyolmo', 'B122', 'profile_photos/photoid@1573979869.jpg', '9841886676', '27/05/2001', '', 'Nepalese', 'Nuwakot', 'Male', '18/04/2014', 'Seven', 'Karkap Sherpa', '9841886676', 'Karkap Sherpa', '9841886676', 'Sangye Omu Hyolmo', '9841886676', 'Nuwakot', '', ''),
(74, 'Ms.', 'Tashi Dickey', 'B127', 'profile_photos/photoid@1573980468.jpg', '9860455825', '28/05/2008', '', 'Nepalese', 'Gorkha, Sho', 'Female', '18/04/2014', 'Seven', 'Mingmar Lama', '9803896248', 'Mingmar Lama', '9803896248', 'Sithar Tsewang Lama', '9803896248', 'Gorkha, Sho', '', ''),
(75, 'Mr.', 'Pasang Thinley', 'B142', 'profile_photos/photoid@1573981187.jpg', '9860356827', '23/03/2006', '', 'Nepalese', 'Nuwakot', 'Male', '21/04/2014', 'Seven', 'Karma Dawa Sherpa Hyolmo', '9843334430', 'Karma Dawa Sherpa Hyolmo', '9843334430', 'Maya Sherpa Hyolmo', '9843334430', 'Nuwakot', '', ''),
(76, 'Ms.', 'Tashi Lhamo', 'B143', 'profile_photos/photoid@1573981699.jpg', '9741506237', '7/08/2004', '', 'Nepalese', 'Gorkha, Samto', 'Female', '18/04/2014', 'Seven', 'Tashi Tsering ', '9808658871', 'Tashi Tsering ', '9808658871', 'Dawa Dolma ', '9808658871', 'Gorkha, Samto', '', ''),
(77, 'Mr.', 'Ngawang Sherpa', 'B147', 'profile_photos/photoid@1573982229.jpg', '9611032403', '26/04/2004', '', 'Nepalese', 'Nuwakot', 'Male', '4/10/2004', 'Seven', 'Mingmar Sherpa Hyolmo', '9849686466', 'Mingmar Sherpa Hyolmo', '9849686466', 'Chopema Sherpa Hyolmo', '9849686466', 'Nuwakot', '', ''),
(78, 'Mr.', 'Lhakpa Norbu Sherpa', 'B148', 'profile_photos/photoid@1573982841.jpg', '9611036052', '15/10/2006', '', 'Nepalese', 'Nuwakot', 'Male', '4/10/2004', 'Seven', 'Nima Pemba Sherpa Hyolmo', '9841074327', 'Nima Pemba Sherpa Hyolmo', '9841074327', 'kanchi Maya Sherpa Hyolmo', '9841074327', 'Nuwakot', '', ''),
(79, 'Mr.', 'Deepak Magar', 'B161', 'profile_photos/photoid@1573983544.jpg', '9860783800', '14/09/2003', '', 'Nepalese', 'Rukum', 'Male', '4/10/2014', 'Seven', 'Sumitra Buda  Magar', '9813751632', 'Lila Bahadur Buda', '9860783800', 'Sumitra Buda  Magar', '9860783800', 'Rukum', '', ''),
(80, 'Mr.', 'Tsewang Norbu', 'B171', 'profile_photos/photoid@1573984313.jpg', '9861148973', '28/06/2004', '', 'Nepalese', 'Gorkha, Prok', 'Male', '05/04/2015', 'Seven', 'Tsewang Dorje', '9818171018', 'Rigtsen Dorje', '9861148973', 'Sonam Choden', '9861148973', 'Gorkha, Prok', '', ''),
(82, 'Ms.', 'Dawa Jangmu Sherpa', 'B185', 'profile_photos/photoid@1573991440.jpg', '9861103605', '12/05/2004', '', 'Nepalese', 'Nuwakot', 'Female', '15/04/2015', 'Seven', 'Dolma Sherpa', '9841074327', 'Nima Pemba Sherpa Hyolmo', '9611036052', 'kanchi Maya Sherpa Hyolmo', '9611036052', 'Nuwakot', '', ''),
(83, 'Ms.', 'Premika Gurung', 'B209', 'profile_photos/photoid@1573998442.jpg', '9741518618', '24/05/2006', '', 'Nepalese', 'Bangshing', 'Female', '20/03/2017', 'Seven', 'Phul Maya', '9741345580', 'Dhundup Gurung', '9741518618', 'Maya Gurung', '9741518618', 'Bangshing', '', ''),
(84, 'Mr.', 'Tashi Sherpa', 'B218', 'profile_photos/photoid@1573999006.jpg', '9810191084', '25/08/2004', '', 'Nepalese', 'Gorkha', 'Male', '12/04/2016', 'Seven', 'Dhelu Magar  (Sherpa)', '9810191084', 'Pasang Sherpa', '9810191084', 'Dhelu Magar  (Sherpa)', '9810191084', 'Gorkha', '', ''),
(85, 'Ms.', 'Nila Dolma', 'B271', 'profile_photos/photoid@1574063337.jpg', '9803761132', '8/10/2004', '', 'Nepalese', 'Gorkha, Prok', 'Female', '24/04/2017', 'Seven', 'Ngodrup Gyaltsen', '9823801415', 'Chimik Rigzen Lama', '9803761132', 'Sangey Yangzin Lama', '9803761132', 'Gorkha, Prok', '', ''),
(86, 'Ms.', 'Samten Lhamo Lama', 'B06', 'profile_photos/photoid@1574140339.jpg', '9840513476', '15/03/2006', '', 'Nepalese', 'Gorkha, Lho', 'Female', '18/04/2014', 'Six', 'Pema Dickey Lama', '9840513476', 'Nyima Dundup Lama', '9840513476', 'Pema Dickey Lama', '9803955289', 'Gorkha, Lho', '', ''),
(87, 'Ms.', 'Nesha Gurung', 'B11', 'profile_photos/photoid@1574141202.jpg', '9840238014', '30/08/2005', '', 'Nepalese', 'Manang', 'Female', '18/04/2014', 'Six', 'Yem Bahadur Gurung', '9846589662', 'Yem Bahadur Gurung', '9840238014', 'Dil Maya Gurung', '9840238014', 'Manang', '', ''),
(88, 'Ms.', 'Sonam Lama', 'B18', 'profile_photos/photoid@1574142120.jpg', '9862380382', '27/05/2008', '', 'Nepalese', 'Gorkha, Nubri', 'Female', '18/04/2014', 'Six', 'Gyurme Lama', '9803678229', 'Gyurme Lama', '9862380382', 'Chokey Lama', '9862380382', 'Gorkha, Nubri', '', ''),
(89, 'Mr.', 'Tsewang Gombo Lama ', 'B20', 'profile_photos/photoid@1574143350.jpg', '9846845590', '13/02/2007', '', 'Nepalese', 'Gorkha, Prok', 'Male', '18/04/2014', 'Six', 'Tashi Samten', '994640025', 'Dawa Tenzin Lama', '9846845590', 'Lhachoe Dolma', '9846845590', 'Gorkha, Prok', '', ''),
(90, 'Ms.', 'Tenzin Lhamo Tamang', 'B39', 'profile_photos/photoid@1574154766.jpg', '9860939991', '05/05/2003', '', 'Nepalese', 'Rasuwa', 'Female', '21/04/2014', 'Six', 'Tashi Lama', '9808030991', 'Phurbu Tamang', '9860939991', 'Passang Dolma Tamang', '9860939991', 'Rasuwa', '', ''),
(91, 'Ms.', 'Tsewang Dolma Lama', 'B44', 'profile_photos/photoid@1574155245.jpg', '9864650298', '02/05/2008', '', 'Nepalese', 'Gorkha', 'Female', '21/04/2014', 'Six', 'Tsewang Norbu Lama', '9818888646', 'Tsewang Norbu Lama', '9864650298', 'Rasal Choekyi ', '9864650298', 'Gorkha', '', ''),
(92, 'Ms.', 'Sonam Dolma Lama', 'B68 ', 'profile_photos/photoid@1574155765.jpg', '9846845770', '24/02/2007', '', 'Nepalese', 'Gorkha', 'Female', '18/04/2014', 'Six', 'Rigtsen Namgyal Lama', '9808340430', 'Rigtsen Namgyal Lama', '9846845770', 'Tsering Ladon Lama', '9846845770', 'Gorkha', '', ''),
(93, 'Ms.', 'Urgen Lhamo lama', 'B72', 'profile_photos/photoid@1574220350.jpg', '9864650036', '28/06/2007', '', 'Nepalese', 'Gorkha', 'Female', '21/04/2014', 'Six', 'Jigme Tsewang ', '9841499948', 'Chimik Rigzin Lama', '9864650036', 'Sangye Yangzom Lama', '9864650036', 'Gorkha', '', ''),
(94, 'Ms.', 'Tenzin Ladon Lama', 'B79', 'profile_photos/photoid@1574220689.jpg', '9741514011', '16/12/2006', '', 'Nepalese', 'Gorkha', 'Female', '21/04/2014', 'Six', 'Tenzin Phuntsok', '9808583676', 'Lobsang Phuntsok Lama', '9741514011', 'Choedon Lama ', '9741514011', 'Gorkha', '', ''),
(95, 'Mr.', 'Urgen Dorje Lama', 'B88', 'profile_photos/photoid@1574221111.jpg', '9803871880', '29/07/2007', '', 'Nepalese', 'Hyolmo', 'Male', '22/04/2014', 'Six', 'Karmu Lama Hyolmo', '9803165744', 'Dawa Chempel Lama', '9803871880', 'Karmu Lama', '9803871880', 'Hyolmo', '', ''),
(96, 'Ms.', 'Lhamo Mentok Tamang', 'B92', 'profile_photos/photoid@1574221458.jpg', '9860839830', '25/10/2005', '', 'Nepalese', 'Nuwakot', 'Female', '22/04/2014', 'Six', 'Bhim Bahadur Tamang', '9818655734', 'Bhim Bahadur Tamang', '9860839830', 'Maya Tamang', '9860839830', 'Nuwakot', '', ''),
(97, 'Mr.', 'Pemba Tsering Lama', 'B96', 'profile_photos/photoid@1574221800.jpg', '9818854970', '30/12/2006', '', 'Nepalese', 'Gorkha', 'Male', '21/04/2014', 'Six', 'Ngudup Gyaltsen Lama', '9946400670', 'Ngudup Gyaltsen Lama', '9818854970', 'Tsewang Bhutti Lama', '9818854970', 'Gorkha', '', ''),
(98, 'Ms.', 'Pasang Dolma Lama', 'B107', 'profile_photos/photoid@1574222137.jpg', '9849041512', '07/05/2002', '', 'Nepalese', 'Gorkha', 'Female', '21/04/2014', 'Six', 'Tsering Dolma', '9849041512', 'Wangdu Lama', '9849041512', 'Tashi Lama', '9849041512', 'Gorkha', '', ''),
(99, 'Mr.', 'Pema Ngodup Lama', 'B113', 'profile_photos/photoid@1574222492.jpg', '9810394169', '01/10/2005', '', 'Nepalese', 'Helambu', 'Male', '18/04/2014', 'Six', 'Pasang Gyalpo Lama', '9808174259', 'Pasang Gyalpo Lama', '9810394169', 'Maya Shamgpo Lama', '9810394169', 'Helambu', '', ''),
(100, 'Ms.', 'Dickey Lhamo Lama ', 'B124', 'profile_photos/photoid@1574227805.jpg', '9745160609', '25/07/2004', '', 'Nepalese', 'Gorkha', 'Female', '25/07/2004', 'Six', 'karma Gyamtsho', '9745160599', 'karma Gyamtsho', '9745160609', 'Metok Lamo', '9745160609', 'Gorkha, Samma', '', ''),
(101, 'Mr.', 'Pemba Tsering Sherpa', 'B145', 'profile_photos/photoid@1574228721.jpg', '9611015108', '24/07/2005', '', 'Nepalese', 'Nuwakot, Gaunkharka', 'Male', '21/04/2014', 'Six', 'Tenzin Dorje Sherpa Hyolmo', '9808969045', 'Tenzin Dorje Sherpa Hyolmo', '9611015108', 'Lakh BuriSherpa Hyolmo', '9611015108', 'Nuwakot, Gaunkharka', '', ''),
(102, 'Ms.', 'Manisha Nepali', 'B156', 'profile_photos/photoid@1574234436.jpg', '9846784238', '24/08/2008', '', 'Nepalese', 'Sitapaila,KTM', 'Female', '18/04/2014', 'Six', 'Sona Nepali', '9849995974', 'k', '9846784238', 'Sona Nepali', '9846784238', 'Sitapaila,KTM', '', ''),
(103, 'Mr.', 'Pemba Tsering Sherpa', 'B177', 'profile_photos/photoid@1574235055.jpg', '9803503100', '4/05/2008', '', 'Nepalese', 'Helambu, Sindupalchowk', 'Male', '13/04/2015', 'Six', 'Phurba Jangbo Sherpa', '9803503100', 'Phurba Jangbo Sherpa', '9803503100', 'Kisang Sherpa', '9803503100', 'Helambu, Sindupalchowk', '', ''),
(104, 'Ms.', 'Nyima Sherpa', 'B189', 'profile_photos/photoid@1574235540.jpg', '9611032403', '29/03/2007', '', 'Nepalese', 'Nuwakot', 'Female', '15/04/2015', 'Six', 'Karjangmu Sherpa', '9849681466', 'Mingmar Sherpa ', '9611032403', 'Tso Pema Sherpa', '9611032403', 'Nuwakot', '', ''),
(105, 'Mr.', 'Pema Dhundup Sherpa', 'B193', 'profile_photos/photoid@1574236210.jpg', '9848810329', '13/05/2005', '', 'Nepalese', 'Tatopani, Sindupalchok', 'Male', '15/05/2015', 'Six', 'Laxmi Bajracharya', '9808088540', 'Namgyal Sherpa', '9848810329', 'Pemba Sherpa', '9848810329', 'Tatopani, Sindupalchok', '', ''),
(106, 'Ms.', 'Manisha Nath Yogi', 'B201', 'profile_photos/photoid@1574313257.jpg', '9848932939', '27/03/2008', '', 'Nepalese', 'Majkot, Jajarkot', 'Female', '18/04/2014', 'Six', 'Lal Bahadur Nath', '9843125387', 'Prem Nath Yogi', '9848932939', 'Parnata Yogi ', '9848932939', 'Majkot, Jajarkot', '', ''),
(107, 'Ms.', 'Phurbu Sangmo Lama', 'B206', 'profile_photos/photoid@1574313703.jpg', '9846920880', '2/04/2005', '', 'Nepalese', 'Nubri', 'Female', '22/04/2015', 'Six', 'Nilda Lama', '9741328659', 'Nilda Lama', '9846920880', 'Samten Lama', '9846920880', 'Nubri', '', ''),
(108, 'Mr.', 'Pema Tashi Tamang', 'B223', 'profile_photos/photoid@1574314159.jpg', '9848395081', '2/08/2015', '', 'Nepalese', 'Jumla', 'Male', '12/04/2016', 'Six', 'Karma Gyalpo Tamang', '9848395081', 'Urgen Tamang', '9866324505', 'Yangju Toma Tamang', '9866324505', 'Jumla', '', ''),
(109, 'Ms.', 'Pasang Lhamo Lama', 'B225', 'profile_photos/photoid@1574399577.jpg', '9741503437', '21/10/2005', '', 'Nepalese', 'Nubri, Samagaun', 'Female', '12/04/2016', 'Six', 'Tenzin Norbu Lama', '9741503437', 'Tenzin Norbu Lama', '9741493901', 'Pasang Lhamo Lama', '9741493901', 'Nubri, Samagaun', '', ''),
(110, 'Ms.', 'Dolma Sherpa', 'B272', 'profile_photos/photoid@1574400213.jpg', '9818171604', '25/10/2006', '', 'Nepalese', 'Solukhumbu', 'Female', '25/04/2017', 'Six', 'Yangzi Sherpa', '9818171604', 'Ang Tsering Sherpa', '9869063957', 'Ang Bhutti Sherpa', '9869063957', 'Solukhumbu', '', ''),
(111, 'Ms.', 'Mingma Doma Sherpa', 'B383', 'profile_photos/photoid@1574400689.jpg', '9861752621', '28/03/2008', '', 'Nepalese', 'Solukhumbu', 'Female', '29/04/2019', 'Six', 'Nima Doma Sherpa', '9861752621', 'Ang Tsering Sherpa', '9869063957', 'Ang Bhutti Sherpa', '9869063957', 'Solukhumbu', '', ''),
(112, 'Ms.', 'Kunchok Dolma', 'B19', 'profile_photos/photoid@1574580642.jpg', '9861829621', '18/05/2007', '', 'Nepalese', 'Gorkha', 'Female', '18/04/2014', 'Five', 'Passang Dolma', '9808150596', 'Rigtsen Namgyal', '9861829621', 'Sonam Dickey', '9861829621', 'Gorkha', '', ''),
(113, 'Ms.', 'Nyima Lhamo', 'B30', 'profile_photos/photoid@1574581232.jpg', '9803973906', '03/02/2007', '', 'Nepalese', 'Gorkha', 'Female', '18/04/2014', 'Five', 'Urgen Lama', '9803973906', 'Nyima Tseten Lama', '9803973906', 'Sonam Chonzom Lama', '9803973906', 'Gorkha', '', ''),
(114, 'Ms.', 'Neema Dolma Lama', 'B33', 'profile_photos/photoid@1574653064.jpg', '9803871880', '13/07/2005', '', 'Nepalese', 'Nuwakot', 'Female', '22/04/2014', 'Five', 'Hisse lama hyolmo', '9803165744', 'Jimme Sherpa', '9803871880', 'Hisse Lama', '9803871880', 'Nuwakot', '', ''),
(115, 'Mr.', 'Tsewang Gyaltsen Lama', 'B36', 'profile_photos/photoid@1574653408.jpg', '9860455825', '28/10/2006', '', 'Nepalese', 'Gorkha', 'Male', '21/04/2014', 'Five', 'Mentok Sangmo Lama', '9860455825', 'Chimi Dorjee Lama', '9860455825', 'Mentok Sangmo Lama', '9860455825', 'Gorkha', '', ''),
(116, 'Ms.', 'Pema Sangmo Lama', 'B46', 'profile_photos/photoid@1574653775.jpg', '9746127376', '06/09//2007', '', 'Nepalese', 'Gorkha', 'Female', '19/04/2014', 'Five', 'Norbu Gyaltsen Lama', '9741394829', 'Norbu Gyaltsen Lama', '9746127376', 'Lhakpa Dickey Lama', '9746127376', 'Gorkha', '', ''),
(117, 'Ms.', 'Tashi Lhamo', 'B48', 'profile_photos/photoid@1574654146.jpg', '9840409094', '01/10/2005', '', 'Nepalese', 'Gorkha', 'Female', '04/04/2014', 'Five', 'Lhakpa Norbu Lama', '9808364524', 'Lhakpa Norbu Lama', '9840409094', 'Tashi Sangmo', '9840409094', 'Gorkha', '', ''),
(118, 'Mr.', 'Choegyal Lama', 'B74', 'profile_photos/photoid@1574654496.jpg', '9863165927', '30/03/2006', '', 'Nepalese', 'Gorkha', 'Male', '20/04/2014', 'Five', 'Tsewang Lama', '9815178585', 'Orgen Tenzin Lama', '9863165927', 'Tsewang Sangmo Lama', '9863165927', 'Gorkha', '', ''),
(119, 'Ms.', 'Passang Chonzom Lama', 'B77', 'profile_photos/photoid@1574654886.jpg', '9741346476', '09/12/2006', '', 'Nepalese', 'Gorkha', 'Female', '24/04/2014', 'Five', 'Tenzin Norbu Lama', '9741346476', 'Tenzin Norbu Lama', '9741346476', 'Passang Lhamo', '9741346476', 'Gorkha', '', ''),
(120, 'Mr.', 'Yangchen Dolkar', 'B80', 'profile_photos/photoid@1574655245.jpg', '9823342756', '29/05/2006', '', 'Nepalese', 'Gorkha', 'Female', '18/04/2014', 'Five', 'Jampa Tenthar', '9813015047', 'Tashi Lama', '9823342756', 'Sonam Dolma Lama', '9823342756', 'Gorkha', '', ''),
(121, 'Mr.', 'Pema Gyurme Lama', 'B82', 'profile_photos/photoid@1574656934.jpg', '9843191400', '03/11/2007', '', 'Nepalese', 'Gorkha', 'Male', '18/04/2014', 'Five', 'Choeying Sangmo ', '9745001262', 'Tsering Yungdung', '9843191400', 'Tsering Sangmo', '9843191400', 'Gorkha', '', ''),
(122, 'Ms.', 'Laxmi Tamang ', 'B86', 'profile_photos/photoid@1574659121.jpg', '9808323560', '31/08/2006', '', 'Nepalese', 'Dhading', 'Female', '18/04/2014', 'Five', 'Om Prasad', '9846455819', 'Ram Tamang', '9808323560', 'Kali Maya Tamang', '9808323560', 'Dhading', '', ''),
(123, 'Ms.', 'Mingmar Khando Lama', 'B98', 'profile_photos/photoid@1574659777.jpg', '9810394169', '27/01/2007', '', 'Nepalese', 'Sindupalchowk', 'Female', '18/04/2014', 'Five', 'Passang Gyalpo Lama', '9808174259', 'Passang Gyalpo Lama', '9810394169', 'Maya Shangpo Lama', '9810394169', 'Sindupalchowk', '', ''),
(124, 'Mr.', 'Manish Nepali', 'B100', 'profile_photos/photoid@1574660368.jpg', '9746051495', '19/02/2009', '', 'Nepalese', 'Manang', 'Male', '19/04/2014', 'Five', 'Sona Nepali', '9849995974', 'C.B Khan', '9746051495', 'Sona Nepali', '9849995974', 'Manang', '', ''),
(125, 'Mr.', 'Karma Tsering', 'B121', 'profile_photos/photoid@1574660855.jpg', '9760666760', '3/02/2007', '', 'Nepalese', 'Gorkha', 'Male', '18/04/2014', 'Five', 'Lopen Gyurme', '9741342434', 'Gyurme Lama', '9760666760', 'Tsering Khando', '9760666760', 'Gorkha', '', ''),
(126, 'Ms.', 'Sangye Bhutti Lama', 'B140', 'profile_photos/photoid@1574661784.jpg', '9746082439', '26/07/2007', '', 'Nepalese', 'Gorkha', 'Female', '18/04/2014', 'Five', 'Sonam Gyamtsho', '9841963439', 'Sonam Gyamtsho', '9841963439', 'Bhutti Lama', '9841963439', 'Gorkha', '', ''),
(127, 'Ms.', 'Choenzom Lama', 'B158', 'profile_photos/photoid@1574662428.jpg', '9813055700', '11/07/2007', '', 'Nepalese', 'Manang', 'Female', '18/04/2014', 'Five', 'Dawa Dolma', '9745025563', 'Sangye Dorje Lama', '9813055700', 'lp', '9813055700', 'Manang', '', ''),
(128, 'Ms.', 'Phurba Yangzi Sherpa', 'B186', 'profile_photos/photoid@1574668397.jpg', '9808191464', '16/10/2005', '', 'Nepalese', 'Nuwakot', 'Female', '15/04/2015', 'Five', 'Dawa Phuntso Sherpa', '9803623024', 'Lhakpa Dorje Sherpa', '9808191464', 'Nymar Deckyi Sherpa', '9808191464', 'Nuwakot', '', ''),
(129, 'Ms.', 'Pemba Sherpa', 'B187', 'profile_photos/photoid@1574741137.jpg', '9611036749', '28/05/2004', '', 'Nepalese', 'Nuwakot', 'Female', '15/04/2015', 'Five', 'Lhakpa Dorje Sherpa', '9611036749', 'Karsang Dawa Sherpa', '9611036749', 'Bhutti Sherpa', '9611036749', 'Nuwakot', '', ''),
(130, 'Mr.', 'Abishek Bajracharya', 'B194', 'profile_photos/photoid@1574741734.jpg', '9841247397', '1111111', '', 'Nepalese', 'Sindhupalchok', 'Male', '15/04/2015', 'Five', 'Laxmi Bajracharya', '9808088540', 'Biuot Bajracharya', '9841247397', 'Ganga Tamang', '9841247397', 'Sindhupalchok', '', ''),
(131, 'Mr.', 'karsang Dorje Lama', 'B231', 'profile_photos/photoid@1574742151.jpg', '9813999390', '15/02/2006', '', 'Nepalese', 'Mugu', 'Male', '17/04/2016', 'Five', 'Urgyen ', '9818426659', 'Nyima Dorje Lama', '9813999390', 'Lashi Angmu Lama', '9813999390', 'Mugu', '', ''),
(132, 'Ms.', 'Kasang Chuki Lama', 'B232', 'profile_photos/photoid@1574742610.jpg', '9888184266', '26/08/2005', '', 'Nepalese', 'Mugu', 'Female', '17/04/2016', 'Five', 'Urgyen', '9888184266', 'Karma Tsering Lama', '9888184266', 'Tsering Karma Lama', '9888184266', 'Mugu', '', ''),
(133, 'Ms.', 'Passang Diki Sherpa', 'B234', 'profile_photos/photoid@1574746783.jpg', '9860646769', '28/05/2004', '', 'Nepalese', 'Sindupalchowk', 'Female', '24/04/2017', 'Five', 'Sang Lhamu Sherpa', '9860646769', 'Karma Tsering Sherpa', '9860646769', 'Sang Lhamu Sherpa', '9860646769', 'Sindupalchowk', '', ''),
(134, 'Ms.', 'Sonam Bhutti Lama', 'B240', 'profile_photos/photoid@1574825957.jpg', '9746087276', '24/06/2006', '', 'Nepalese', 'Gorkha', 'Female', '24/04/2017', 'Five', 'Hishey Dolkar', '9810121997', 'Dorje Lama', '9746087276', 'Lhakpa Lama', '9746087276', 'Gorkha', '', ''),
(135, 'Ms.', 'Sonam Bhutti Lama', 'B600', 'profile_photos/photoid@1574826310.jpg', '9746087276', '24/06/2006', '', 'Nepalese', 'Gorkha', 'Female', '24/04/2017', 'Five', 'Hishey Dolkar', '9810121997', 'Dorje Lama', '9746087276', 'Lhakpa Lama', '9746087276', 'Gorkha', '', ''),
(136, 'Mr.', 'Chin Dorje Lama', 'B275', 'profile_photos/photoid@1574826716.jpg', '9860040870', '27/05/2007', '', 'Nepalese', 'Sindhupalchok', 'Male', '26/04/2017', 'Five', 'Ang Doma Lama', '9860040870', 'Mingmar Lama', '9861496112', 'Ang Doma Lama', '9861496112', 'Sindhupalchok', '', ''),
(137, 'Mr.', 'Anisha  Lama', 'B282', 'profile_photos/photoid@1574827298.jpg', '9823033355', '10000000', '', 'Nepalese', 'Dolpa', 'Female', '31/03/2018', 'Five', 'Passang Lama', '9823033355', 'Dorji Lama', '9823741014', 'Nari Lama', '9823741014', 'Dolpa', '', ''),
(138, 'Mr.', 'Pema Gyaltsen Lama', 'B83', 'profile_photos/photoid@1574828008.jpg', '9813424484', '100000', '', 'Nepalese', 'Gorkha', 'Male', '24/04/2017', 'Five', 'Mingmar Samdup', '9813424484', 'Ngawang Lhundup Lama', '9818380214', 'Dawa Bhuti Lama', '9818380214', 'Gorkha', '', ''),
(139, 'Mr.', 'Tsering Wangdi Lama', 'B389', 'profile_photos/photoid@1574828423.jpg', '9803324466', '20/08/2005', '', 'Nepalese', 'Gorkha', 'Male', '18/04/2014', 'Five', 'Chhimi Lama', '9803324466', 'Chhimi Lama', '9741517134', 'Samden Lama', '9741517134', 'Gorkha', '', ''),
(141, 'Ms.', 'Furba Dema Lama', 'B14', 'profile_photos/photoid@1574831674.jpg', '9840908451', '28/04/2002', '', 'Nepalese', 'Manang', 'Female', '18/04/2014', 'Four', 'Dorjee Lama ', '9840908451', 'Dorjee Lama', '9840908451', 'Tashi Cheten', '9840908451', 'Manang', '', ''),
(142, 'Ms.', 'Kunsang Diki', 'B23', 'profile_photos/photoid@1574832087.jpg', '9803361782', '22/07/2009', '', 'Nepalese', 'Bihi', 'Female', '18/04/2014', 'Four', 'Tsering Lhadon', '9803361782', 'Kunsang Dhundup Lama', '9803361782', 'Tsering Lhadon ', '9803361782', 'Bihi', '', ''),
(143, 'Mr.', 'Dawa Lhakpa Sherpa', 'B32', 'profile_photos/photoid@1574832946.jpg', '9864274267', '19/04/2006', '', 'Nepalese', 'Gang', 'Male', '18/04/2014', 'Four', 'Dawa Gyalpo Sherpa', '9803621275', 'Dawa Gyalpo Sherpa', '9864274267', 'Soni Maya Sherpa', '9864274267', 'Gang', '', ''),
(144, 'Ms.', 'Tsering Lama', 'B34', 'profile_photos/photoid@1574833594.jpg', '9860049140', '17/03/2009', '', 'Nepalese', 'Kajay', 'Female', '18/04/2014', 'Four', 'Lhamu Lama Hyolmo', '9841198850', 'Mingmar Lama', '9860049140', 'Dolma Lama', '9860049140', 'Kajay', '', ''),
(145, 'Ms.', 'Sonam Choedon Lama', 'B38', 'profile_photos/photoid@1574834210.jpg', '9864243005', '01/10/2007', '', 'Nepalese', 'Prok', 'Female', '18/04/2014', 'Four', 'Nyima Gyaltsen', '9803615048', 'Tsewang Rigzin Lama', '9864243005', 'Woser Bhuti Lama', '9864243005', 'Prok', '', ''),
(146, 'Ms.', 'Sangye Lhamo ', 'B47', 'profile_photos/photoid@1574834691.jpg', '9840409094', '02/06/2007', '', 'Nepalese', 'Lhi', 'Female', '4/04/2014', 'Four', 'Tsewang Norbu', '9808364524', 'Lhakpa Norbu', '9840409094', 'Tashi Lhamo', '9840409094', 'Lhi', '', ''),
(147, 'Ms.', 'Orken Lhamo Lama', 'B65', 'profile_photos/photoid@1574835147.jpg', '9863695524', '11/04/2008', '', 'Nepalese', 'Prok', 'Female', '18/04/2014', 'Four', 'Choeying Dolma', '9808343979', 'Nima Sandup Lama', '9863695524', 'Chewang Diki Lama', '9863695524', 'Prok', '', ''),
(148, 'Ms.', 'Tashi Lhamu Lama', 'B67', 'profile_photos/photoid@1574835706.jpg', '9860969554', '12/06/2007', '', 'Nepalese', 'Prok', 'Female', '21/04/2014', 'Four', 'Tsewang Rigzin', '9808343979', 'Tsewang Rigzin', '9860969554', 'Nyima Sangmo', '9860969554', 'Prok', '', ''),
(149, 'Mr.', 'Tsering Yungdung Lama', 'B76', 'profile_photos/photoid@1574918966.jpg', '9741394736', '18/05/2008', '', 'Nepalese', 'Nubri, Samagaun', 'Male', '19/04/2014', 'Four', 'Dawa Tenzin', '9741394736', 'Raju Lama', '9741394736', 'Tsewang Diki Lama', '9741394736', 'Nubri, Samagaun', '', ''),
(150, 'Ms.', 'Pasang Dolma Tamang', 'B85', 'profile_photos/photoid@1574919652.jpg', '9880110232', '17/04/2007', '', 'Nepalese', 'Atterkhel', 'Female', '21/04/2014', 'Four', 'Tirtha Tamang', '9813370797', 'Tirtha Tamang', '9880110232', 'Sange Lahmu Tamang (Sherpa)', '9880110232', 'Atterkhel', '', ''),
(151, 'Ms.', 'Tsering Bhutti Lama   ', 'B94', 'profile_photos/photoid@1574921608.jpg', '9818191955', '19/06/2008', '', 'Nepalese', 'Bihi', 'Female', '18/04/2014', 'Four', 'Tenzin Dorje', '9818191955', 'Tenzin Dorje', '9818191955', 'Nelha Sangmo', '9818191955', 'Bihi', '', ''),
(153, 'Ms.', 'Lakpa Lama', 'B110', 'profile_photos/photoid@1574998418.jpg', '9862380072', '2222222222', '', 'Nepalese', 'Gorkha', 'Female', '18/04/2014', 'Four', 'Nephew', '9862380072', 'Shenil Lama', '9862380072', 'Dolma Lama', '9862380072', 'Gorkha', '', ''),
(155, 'Ms.', 'Pasang Dolma Lama', 'B111', 'profile_photos/photoid@1574998692.jpg', '9862380072', '3333333333', '', 'Nepalese', 'Gorkha', 'Female', '18/04/2014', 'Four', 'Nephew', '9862380072', 'Shenil Lama', '9862380072', 'Dolma Lama', '9862380072', 'Gorkha', '', ''),
(157, 'Mr.', 'Karma Diki Lama', 'B114', 'profile_photos/photoid@1574999154.jpg', '9860929757', '44444444444', '', 'Nepalese', 'Gorkha', 'Female', '18/04/2014', 'Four', 'Phurbu Tsewang', '9808056564', 'Phurbu Gyaltsen Lama', '9860929757', 'Pasang Dolma Lama', '9860929757', 'Gorkha', '', ''),
(159, 'Ms.', 'Pasang Dolma Lama', 'B130', 'profile_photos/photoid@1575000078.jpg', '9849843506', '555555555', '', 'Nepalese', 'Gorkha', 'Female', '18/04/2014', 'Four', 'Rether Lama', '9849843506', 'Chodak Lama', '9849843506', 'Rether Lama', '9849843506', 'Gorkha', '', ''),
(160, 'Ms.', 'Tsering Lhamu Lama', 'B135', 'profile_photos/photoid@1575000368.jpg', '9843882658', '27/03/2006', '', 'Nepalese', 'Gorkha', 'Female', '18/04/2014', 'Four', 'Dechen Dolma Lama', '9803598073', 'Tsewang Gyurme', '9843882658', 'Dechen Dolma Lama', '9843882658', 'Gorkha', '', ''),
(161, 'Mr.', 'Gikesh Nepali', 'B157', 'profile_photos/photoid@1575258149.jpg', '9846589937', '23/022008', '', 'Nepalese', 'Manang', 'Male', '18/04/2014', 'Four', 'Mangal Bahadur', '9846589937', 'Sadhlal Singh Nepali', '9846589937', 'Maya Bihr', '9846589937', 'Manang', '', ''),
(162, 'Ms.', 'Laxmi Gurung', 'B176', 'profile_photos/photoid@1575258588.jpg', '9860701781', '27/09/2003', '', 'Nepalese', 'Gorkha', 'Female', '15/04/2014', 'Four', 'Karma Dhundup', '9860701781', 'Karma Dhundup', '9860701781', 'Yanki Gurung', '9860701781', 'Gorkha', '', ''),
(163, 'Ms.', 'Sangye Dolma Sherpa', 'B203', 'profile_photos/photoid@1575258996.jpg', '9814137045', '19/05/2006', '', 'Nepalese', 'Gorkha', 'Female', '20/04/2015', 'Four', 'Tsering Phurpa Lama', '9818382265', 'Tsering Phurpa Lama', '9814137045', 'Tsewang Lama', '9814137045', 'Gorkha', '', ''),
(164, 'Mr.', 'Dhoedak Lama', 'B204', 'profile_photos/photoid@1575259420.jpg', '9865555156', '17/01/2007', '', 'Nepalese', 'Gorkha', 'Male', '20/04/2015', 'Four', 'Tsering Dolma', '9741506833', 'Wangchuk Lama', '9865555156', 'Tashi Lama', '9865555156', 'Gorkha', '', ''),
(165, 'Ms.', 'Tseten Lama', 'B239', 'profile_photos/photoid@1575273804.jpg', '9846087276', '19/06/2008', '', 'Nepalese', ' Tsum', 'Female', '24/04/2017', 'Four', 'Hesi Dolkar Lama', '9810121997', 'Dorje Lama', '9846087276', 'Lhakpa Lama', '9846087276', 'Tsum', '', ''),
(166, 'Mr.', 'Aryan Buda Magar', 'B283', 'profile_photos/photoid@1575274822.jpg', '9810379620', '23/06/2009', '', 'Nepalese', 'Dolpa', 'Male', '31/03/2018', 'Four', 'Passang Lama', '9810379620', 'D eepak Buda Magar', '9810379620', 'Kamala Kumari Buda', '9810379620', 'Dolpa', '', ''),
(168, 'Ms.', 'Lazi Mendo Sherpa', 'B339', 'profile_photos/photoid@1575275230.jpg', '9863332504', '31/08/2004', '', 'Nepalese', 'Drum Thali', 'Female', '10/04/2018', 'Four', 'Passang Tempa Sherpa', '9849619513', 'Passang Tempa Sherpa', '9863332504', 'Pasang Lhamu Sherpa', '9863332504', 'Drum Thali', '', ''),
(169, 'Mr.', 'Dil Ba Gurung ', 'B386', 'profile_photos/photoid@1575344102.jpg', '9846921404', '26/05/2001', '', 'Nepalese', 'Gorkha', 'Male', '04/06/2019', 'Four', 'Sabina Gurung', '9846921404', 'Nakpo Gurung', '9846921404', 'Kima Gurung', '9846921404', 'Gorkha', '', ''),
(171, 'Mr.', 'Sangye Tsering Lama', 'B04', 'profile_photos/photoid@1575345849.jpg', '9813920398', '17/05/2007', '', 'Nepalese', 'Gorkha', 'Male', '18/04/2014', 'Three', 'Kalden Lama', '9813920398', 'Kalden Lama', '9813920398', 'Tsewang Sangmo Lama', '9813920398', 'Gorkha', '', ''),
(172, 'Mr.', 'Sangye Wangdue Lama', 'B05', 'profile_photos/photoid@1575429106.jpg', '9840513476', '12/05/2008', '', 'Nepalese', 'Gorkha', 'Male', '18/04/2014', 'Three', 'Pema Dickey Lama', '9803955289', 'Nyima Dhundup Lama', '9840513476', 'Pema Dickey Lama', '9840513476', 'Gorkha', '', ''),
(173, 'Ms.', 'Dolma Youden Lama', 'B07', 'profile_photos/photoid@1575429494.jpg', '9840513476', '22/08/2005', '', 'Nepalese', 'Gorkha', 'Female', '18/04/2014', 'Three', 'Sonam Gyaltsen Lama', '9803955289', 'Sonam Gyaltsen Lama', '9840513476', 'Tenzin Lama', '9840513476', 'Gorkha', '', ''),
(174, 'Mr.', 'Samju Thinley Lama', 'B15', 'profile_photos/photoid@1575429897.jpg', '9849843506', '29/01/2008', '', 'Nepalese', 'Manang', 'Male', '18/04/2014', 'Three', 'Kumar Lama', '9849621086', 'Kumar Lama', '9849843506', 'Tashi Chiten Lama', '9849843506', 'Manang', '', ''),
(175, 'Ms.', 'Nyima Dolma Lama', 'B29', 'profile_photos/photoid@1575430202.jpg', '9849843506', '77777777777777', '', 'Nepalese', 'Gorkha', 'Female', '18/04/2014', 'Three', 'Norbu Gyaltsen Lama', '9741318371', 'Norbu Gyaltsen Lama', '9849843506', 'Lhamo', '9849843506', 'Gorkha', '', ''),
(177, 'Mr.', 'Tenzin Dorje Lama', 'B35', 'profile_photos/photoid@1575430578.jpg', '9861631813', '19/05/2006', '', 'Nepalese', 'Gorkha', 'Male', '21/04/2014', 'Three', 'Gyephel', '9843746550', 'Wangdue Lama', '9861631813', 'Ngawang Choden Lama', '9861631813', 'Gorkha', '', ''),
(178, 'Ms.', 'Pemba Jangbo Sherpa', 'B37', 'profile_photos/photoid@1575432961.jpg', '9841088920', '03/08/2006', '', 'Nepalese', 'Nuwakot', 'Female', '18/04/2014', 'Three', 'Lama Senka Sherpa', '9841548098', 'Lama Senka Sherpa', '9841088920', 'Yangzen Lhamu Sherpa', '9841088920', 'Nuwakot', '', ''),
(179, 'Mr.', 'Tse Passang Sherpa', 'B43', 'profile_photos/photoid@1575433285.jpg', '9868194157', '04/03/2010', '', 'Nepalese', 'Nuwakot', 'Male', '18/04/2014', 'Three', 'Tenzin Sherpa', '9841088920', 'Tenzin Sherpa', '9868194157', 'Mingmar Lhamu Sherpa', '9868194157', 'Nuwakot', '', ''),
(180, 'Ms.', 'Passang Chokyi', 'B51', 'profile_photos/photoid@1575433720.jpg', '9803361782', '22/04/2007', '', 'Nepalese', 'Gorkha', 'Female', '18/04/2014', 'Three', 'Passang Dorje', '9813464122', 'Passang Dorje', '9803361782', 'Tsewang Diki', '9803361782', 'Gorkha', '', ''),
(181, 'Ms.', 'Phurbu sangmo Lama', 'B52', 'profile_photos/photoid@1575434610.jpg', '9863801942', '26/08/2004', '', 'Nepalese', 'Gorkha', 'Female', '18/04/2014', 'Three', 'Tsewang Diki', '9813796562', 'Tsering Gurung', '9863801942', 'Pema Dickey ', '9863801942', 'Gorkha', '', ''),
(182, 'Ms.', 'Yeshi Lhamu', 'B56', 'profile_photos/photoid@1575435080.jpg', '9808023729', '30/05/2008', '', 'Nepalese', 'Gorkha', 'Female', '18/04/2014', 'Three', 'Chhimi Tsering Lama', '9746088262', 'Chhimi Tsering Lama', '9808023729', 'Lhamu Tsering', '9808023729', 'Gorkha', '', ''),
(183, 'Ms.', 'Tashi Lhamo', 'B57', 'profile_photos/photoid@1575435344.jpg', '9741489505', '99999999', '', 'Nepalese', 'Gorkha', 'Female', '18/04/2014', 'Three', 'Gyatso', '9803709590', 'Dawa Gyaltsen ', '9741489505', 'Tashi Sangmo', '9741489505', 'Gorkha', '', ''),
(184, 'Mr.', 'Rinzin Norbu Lama', 'B58', 'profile_photos/photoid@1575436097.jpg', '9813796611', '18/01/2008', '', 'Nepalese', 'Gorkha', 'Male', '18/04/2014', 'Three', 'Ngudup Lama', '9813796611', 'Ngudup Lama', '9813796611', 'Pomo Chhimi Lama', '9813796611', 'Gorkha', '', ''),
(185, 'Mr.', 'Pemba Tsering Lama', 'B69', 'profile_photos/photoid@1575437615.jpg', '9843277637', '20/09/2008', '', 'Nepalese', 'Gorkha', 'Male', '18/04/2014', 'Three', 'Dawa Tenzin Lama', '9803353577', 'Dawa Tenzin Lama', '9843277637', 'Phurbu Lama', '9843277637', 'Gorkha', '', ''),
(186, 'Ms.', 'Rachana Buda Magar', 'B93', 'profile_photos/photoid@1575437963.jpg', '9805850577', '24/08/2007', '', 'Nepalese', 'Rukum', 'Female', '18/04/2014', 'Three', 'Susmita Buda', '9813751632', 'Lila Bahadur Buda', '9805850577', 'Susmita Buda', '9805850577', 'Rukum', '', ''),
(187, 'Ms.', 'Tsering Tsomo', 'B97', 'profile_photos/photoid@1575438303.jpg', '9818854970', '23232323', '', 'Nepalese', 'Gorkha', 'Female', '18/04/2014', 'Three', 'Passang Dolma', '9818854970', 'Ngudup Lama', '9818854970', 'Tsewang Bhutti Lama', '9818854970', 'Gorkha', '', ''),
(188, 'Mr.', 'Tashi Gyaltsen Lama', 'B99', 'profile_photos/photoid@1575438561.jpg', '9860455825', '22/05/2006', '', 'Nepalese', 'Gorkha', 'Male', '18/04/2014', 'Three', 'Sonam Dorje', '9818353162', 'Sonam Dorje', '9860455825', 'Tashi Lhamu Lama', '9860455825', 'Gorkha', '', ''),
(190, 'Mr.', 'Choegyal Dorje Lama', 'B101', 'profile_photos/photoid@1575516435.jpg', '9843191400', '07/06/2007', '', 'Nepalese', 'Gorkha', 'Male', '21/04/2014', 'Three', 'Tashi Samten', '9843191400', 'Passang Dhundul Lama', '9843191400', 'Tashi Diki Lama', '9843191400', 'Gorkha', '', ''),
(191, 'Ms.', 'Tsewang Diki Lama', 'B128', 'profile_photos/photoid@1575517835.jpg', '9862380072', '01/10/2006', '', 'Nepalese', 'Gorkha', 'Female', '18/04/2014', 'Three', 'Tseewang Norbu', '9862380072', 'Samdup', '9862380072', 'Phurbu Lama', '9862380072', 'Gorkha', '', ''),
(192, 'Ms.', 'Sangye Tsomo Lama', 'B131', 'profile_photos/photoid@1575518311.jpg', '9741250609', '21/02/2008', '', 'Nepalese', 'Gorkha', 'Female', '18/04/2014', 'Three', 'Tashi Bhutti Lama', '9741250609', 'Karma Samdup Lama', '9741250609', 'Tashi Bhutti Lama', '9741250609', 'Gorkha', '', ''),
(193, 'Mr.', 'Tenzin Sangpo Lama', 'B141', 'profile_photos/photoid@1575519180.jpg', '9860819653', '13/11/2007', '', 'Nepalese', 'Gorkha', 'Male', '18/04/2014', 'Three', 'Tashi Dorje Lama', '9746037767', 'Tashi Dorje Lama', '9860819653', 'Pema Lhamo Lama', '9860819653', 'Gorkha', '', ''),
(194, 'Ms.', 'Tsewang Diki Lama', 'B144', 'profile_photos/photoid@1575519502.jpg', '9741489565', '   22333545                                       ', '', 'Nepalese', 'Gorkha', 'Female', '18/04/2014', 'Three', 'Gyatso', '9803709590', 'Dawa Gyaltsen ', '9741489565', 'Tashi Sangmo', '9741489565', 'Gorkha', '', ''),
(195, 'Ms.', 'Tenzin Dolha Lama', 'B173', 'profile_photos/photoid@1575604768.jpg', '9813015047', '17/08/2009', '', 'Nepalese', 'Gorkha', 'Female', '15/04/2015', 'Three', 'Karma Choden Lama', '9813015047', 'Zampa Tender Lama', '9813015047', 'Karma Choden Lama', '9813015047', 'Gorkha', '', ''),
(196, 'Ms.', 'Tsering Chodon Lama', 'B174', 'profile_photos/photoid@1575605660.jpg', '9741429363', '19/01/2008', '', 'Nepalese', 'Gorkha', 'Female', '15/04/2015', 'Three', 'Phuntso Lama', '9813088830', 'Renzo Lama', '9741429363', 'Tsering Bhutti Lama', '9741429363', 'Gorkha', '', ''),
(197, 'Ms.', 'Nyima Tsomo Sherpa', 'B188', 'profile_photos/photoid@1575606497.jpg', '9813834998', '04/08/2008', '', 'Nepalese', 'Nuwakot', 'Female', '15/04/2015', 'Three', 'Pema Gyalmo Sherpa', '9813834998', 'Passang Gyalpo Sherpa', '9813834998', 'Phul Mya Sherpa', '9813834998', 'Nuwakot', '', ''),
(198, 'Ms.', 'Lhakpa Tsomo Sherpa', 'B190', 'profile_photos/photoid@1575607337.jpg', '9860356877', '07/02/2008', '', 'Nepalese', 'Nuwakot', 'Female', '15/04/2015', 'Three', 'Karma Dawa Sherpa', '9843334430', 'Kar Dawa Sherpa', '9860356877', 'Maya Sherpa', '9860356877', 'Nuwakot', '', ''),
(199, 'Mr.', 'Nyima Norbu Tamang', 'B198', 'profile_photos/photoid@1575608004.jpg', '9840433329', '19/11/2006', '', 'Nepalese', 'Thuman, Rasuwa', 'Male', '16/04/2015', 'Three', 'Tashi Dolma', '9088030991', 'Tsering Gonbu Tamang', '9840433329', 'passang Bhutti Tamang', '', '9840433329', '', ''),
(200, 'Ms.', 'Dorje Lhamu Lama', 'B199', 'profile_photos/photoid@1575608862.jpg', '9741250609', '26/06/2007', '', 'Nepalese', 'Gorkha', 'Female', '16/03/2015', 'Three', 'Urgen Lhamo', '9841090321', 'Pemba Chirring Lama', '9741250609', 'Tsering Diki Lama', '9741250609', 'Gorkha', '', ''),
(201, 'Ms.', 'Pema Bhutti Lama', 'B202', 'profile_photos/photoid@1576034117.jpg', '9741363647', '15/01/2007', '', 'Nepalese', 'Gorkha', 'Female', '20/04/2015', 'Three', 'Lhakpa Norbu Lama', '9741363647', 'Lhakpa Norbu Lama', '9741363647', 'Ngawang Lhamu Lama', '9741363647', 'Gorkha', '', ''),
(202, 'Ms.', 'Phu Doma Sherpa', 'B236', 'profile_photos/photoid@1576034603.jpg', '9863332504', '29/10/2008', '', 'Nepalese', 'Karthali', 'Female', '24/04/2017', 'Three', 'Passang Lhamu Sherpa', '9863838315', 'Pasang Temba Sherpa', '9863332504', 'Passang Lhamu Sherpa', '9863332504', 'Karthali', '', ''),
(203, 'Ms.', 'Pema Yangzom Lama', 'B243', 'profile_photos/photoid@1576035079.jpg', '9813349087', '13/02/2008', '', 'Nepalese', 'Mugu', 'Female', '24/04/2017', 'Three', 'Urgen Mingum Lama', '9818426659', 'Karma Tsering Lama', '9813349087', 'Tsering Lama', '9813349087', 'Mugu', '', ''),
(204, 'Mr.', 'Basu Buda', 'B284', 'profile_photos/photoid@1576035719.jpg', '9849740051', '07/04/2012', '', 'Nepalese', 'Dolpa', 'Male', '10/04/2018', 'Three', 'Jigme Thapa', '9849740051', 'Him Bahadur Buda', '9849740051', 'Jun Buda', '9849740051', 'Dolpa', '', ''),
(205, 'Ms.', 'Talghar Tamang Lama', 'B292', 'profile_photos/photoid@1576036332.jpg', '9869831694', '18/03/2006', '', 'Nepalese', 'Mugu', 'Female', '10/04/2018', 'Three', 'Karma Yangchen Lama', '9863367070', 'Gyalgen Tamang', '9869831694', 'Karma Yangchen Lama', '9863367070', 'Mugu', '', ''),
(206, 'Ms.', 'Pema Lhamu Lama', 'B306', 'profile_photos/photoid@1576036956.jpg', '9860501291', '21/12/2006', '', 'Nepalese', 'Mugu', 'Female', '10/04/2018', 'Three', 'Pema Tamang', '9803652163', 'Tenzin Lama', '9860501291', 'Setol Lama', '9860501291', 'Mugu', '', ''),
(207, 'Ms.', 'Urgen Dolma Tamang', 'B313', 'profile_photos/photoid@1576037607.jpg', '9866500292', '25/02/2007', '', 'Nepalese', 'Mugu', 'Female', '10/04/2018', 'Three', 'Ghesang Tamang', '9866500292', 'Sonam Dami Lama Tamang', '9866500292', 'Pema Putik Tamang', '9866500292', 'Mugu', '', ''),
(208, 'Ms.', 'Jamyang Angmo lama', 'B321', 'profile_photos/photoid@1576037909.jpg', '9803735513', '24/06/2007', '', 'Nepalese', 'Mugu', 'Female', '10/04/2018', 'Three', 'sangmo Lama', '9868321847', 'Angdak Lama', '9803735513', 'Karma Angmo Lama', '9803735513', 'Mugu', '', ''),
(209, 'Ms.', 'Ngoedup Sangmo Tamang', 'B323', 'profile_photos/photoid@1576038186.jpg', '9864893415', '14/03/2008', '', 'Nepalese', 'Mugu', 'Female', '10/04/2018', 'Three', 'Rapten Tamang', '9849184797', 'Rapten Tamang', '9864893415', 'khado Tamang', '9864893415', 'Mugu', '', ''),
(210, 'Mr.', 'Tsering Dorjee Lama', 'B347', 'profile_photos/photoid@1576038476.jpg', '9741509986', '14/04/2006', '', 'Nepalese', 'Gorkha', 'Male', '20/02/2019', 'Three', 'Tsering Paljor Lama', '9741509986', 'Tsering Paljor Lama', '9741509986', 'Sonam Wangmo Lama', '9741509986', 'Gorkha', '', ''),
(211, 'Mr.', 'Jaypu Lama', 'B390', 'profile_photos/photoid@1576039147.jpg', '9862767926', '10/11/2010', '', 'Nepalese', 'Taplejung', 'Male', '16/04/2018', 'Three', 'Lakpa Dolma', '9841387584', 'Sonam Lama', '9862767926', 'Lakpa Dolma', '9862767926', 'Taplejung', '', ''),
(212, 'Ms.', 'Tulsi Khatri', 'B09', 'profile_photos/photoid@1576643597.jpg', '9818699546', '04/07/2007                                        ', '', 'Nepalese', 'Dolpa', 'Female', '21/04/2014', 'Two', 'Rajan Khatri', '9741112103', 'Rajan Khatri', '9818699546', 'Telu Khatri', '9818699546', 'Dolpa', '', ''),
(213, 'Ms.', 'Yangzen lama', 'B49', 'profile_photos/photoid@1576643945.jpg', '9806277130', '25/12/2008', '', 'Nepalese', 'Gorkha', 'Female', '22/04/2014', 'Two', 'Dawa Namgyal Lama', '9806277130', 'Dawa Namgyal Lama', '9806277130', 'Lhakpa Bhutti lama', '9806277130', 'Gorkha', '', ''),
(214, 'Ms.', 'Sangye Dorje Gurung', 'B70', 'profile_photos/photoid@1576644406.jpg', '9808522115', '17/04/2012', '', 'Nepalese', 'Gorkha', 'Female', '18/04/2014', 'Two', 'Tswering Wangdak Gurung', '9803998165', 'Tswering Wangdak Gurung', '9808522115', 'Sonam Bhutti Gurung', '9808522115', 'Gorkha', '', ''),
(215, 'Mr.', 'Yeshi Dorje Lama', 'B75', 'profile_photos/photoid@1576645995.jpg', '9741394736', '15/07/2009', '', 'Nepalese', 'Gorkha', 'Male', '19/04/2014', 'Two', 'Raju Lama', '9741394736', 'Raju Lama', '9741394736', 'Tsewang Diki Lama', '9741394736', 'Gorkha', '', ''),
(216, 'Mr.', 'Bhu Dorje Lama', 'B117', 'profile_photos/photoid@1576646384.jpg', '9869762620', '12/02/2010', '', 'Nepalese', 'Gorkha', 'Male', '18/04/2014', 'Two', 'Mingyur Dorje Lama', '9803709590', 'Mingyur Dorje Lama', '9869762620', 'Bhuti Lama', '9869762620', 'Gorkha', '', ''),
(217, 'Ms.', 'Mentok Lama', 'B126', 'profile_photos/photoid@1576647148.jpg', '9846644410', '06/06/2007', '', 'Nepalese', 'Manang', 'Female', '24/04/2014', 'Two', 'Gyaltsen Lama', '9846644410', 'Gyaltsen Lama', '9846644410', 'Sonam Bhuti Punel', '9846644410', 'Manang', '', ''),
(218, 'Mr.', 'Tsering Sherpa', 'B168', 'profile_photos/photoid@1576647921.jpg', '9866558720', '27/02/2009', '', 'Nepalese', 'Solukhumbu', 'Male', '20/04/2014', 'Two', 'Ang Nyima Sherpa', '9741190409', 'Ang Nyima Sherpa', '9866558720', 'Maya Sherpa', '9866558720', 'Solukhumbu', '', ''),
(219, 'Mr.', 'Tenzin Rapten Lama', 'B200', 'profile_photos/photoid@1576648601.jpg', '9841068110', '21/12/2006', '', 'Nepalese', 'Gorkha', 'Male', '17/04/2015', 'Two', 'Samten Tharchen', '9841068110', 'Tashi Gyaltsen Lama', '9841068110', 'Diki Lama', '9841068110', 'Gorkha', '', ''),
(220, 'Mr.', 'Phurba Rinzin Lama', 'B213', 'profile_photos/photoid@1576649230.jpg', '9860016469', '07/09/2008', '', 'Nepalese', 'Gorkha', 'Male', '12/04/2016', 'Two', 'Nangpa Gyaltsen', '9808397424', 'Ngawang Gyaltsen Lama', '9860016469', 'Bhutti Lama', '9860016469', 'Gorkha', '', ''),
(221, 'Mr.', 'Sangey Lama', 'B216', 'profile_photos/photoid@1576650019.jpg', '9741421182', '17/03/2009', '', 'Nepalese', 'Gorkha', 'Male', '12/04/2016', 'Two', 'Aape Lama', '9741421182', 'Aape Lama', '9741421182', 'Dawa Choenzom', '9741421182', 'Gorkha', '', ''),
(222, 'Mr.', 'Mingmar Tenzin Sherpa', 'B217', 'profile_photos/photoid@1576654055.jpg', '9866558720', '16/03/2010', '', 'Nepalese', 'Solukhumbu', 'Male', '12/04/2016', 'Two', 'Lopen Gyaltsen', '9813708859', 'Phurpa Sherpa', '9866558720', 'Pasi Sherpa', '9866558720', 'Solukhumbu', '', ''),
(228, 'Mr.', 'Norsang Adhikari', 'B229', 'profile_photos/photoid@1576727563.jpg', '9861002600', '15/08/2011', '', 'Nepalese', 'Jumla', 'Male', '14/04/2016', 'Two', 'Ngawang Dechen', '9841258363', 'Dharmindra Adhikari', '9861002600', 'Tara Tamang', '9861002600', 'Jumla', '', ''),
(230, 'Mr.', 'Gyatso Lama', 'B230', 'profile_photos/photoid@1576728090.jpg', '9818945177', '25/10/2005', '', 'Nepalese', 'Gorkha', 'Male', '30/04/2016', 'Two', 'Psuntsok Lama', '9818945177', 'Psuntsok Lama', '9818945177', 'Sonam Tsekyi Lama', '9818945177', 'Gorkha', '', ''),
(231, 'Ms.', 'Lhakpa Sherpa', 'B235', 'profile_photos/photoid@1576729200.jpg', '9863838315', '233333333', '', 'Nepalese', 'Sindhupalchok', 'Female', '24/04/2017', 'Two', 'Pasang Lhamu Sherpa', '9863838315', 'Pasang Temba Sherpa', '9863838315', 'Pasang Lhamu Sherpa', '9863838315', 'Sindhupalchok', '', ''),
(232, 'Mr.', 'Dorje Sherpa', 'B238', 'profile_photos/photoid@1576729677.jpg', '9863395984', '26/09/2007', '', 'Nepalese', 'Sindhupalchok', 'Male', '24/04/2017', 'Two', 'Sang Dolma Sherpa', '9808753664', 'Thilen Sherpa', '9863395984', 'Pem Sangmu Sherpa', '9863395984', 'Sindhupalchok', '', ''),
(233, 'Mr.', 'Santosh Roka Magar', 'B242', 'profile_photos/photoid@1576729938.jpg', '9813349087', '17/01/2009', '', 'Nepalese', 'Mugu', 'Male', '24/04/2017', 'Two', 'Urken Minzom Tamang', '9818426659', 'Mohan Lal Roka Magar', '9813349087', 'pasang Toma Roka Magar', '9813349087', 'Mugu', '', ''),
(234, 'Ms.', 'Putik Lama', 'B255', 'profile_photos/photoid@1576734402.jpg', '9868129016', '05/10/2006', '', 'Nepalese', 'Mugu', 'Female', '24/04/2017', 'Two', 'Pema Yeden', '9813284744', 'Tengyal Lama', '9868129016', 'Choeying Angmo Lama', '9868129016', 'Mugu', '', ''),
(235, 'Mr.', 'Tsering Dawa Tamang ', 'B263', 'profile_photos/photoid@1576740382.jpg', '9861573872', '27/07/2009', '', 'Nepalese', 'Rasuwa', 'Male', '25/04/2017', 'Two', 'Tashi Lama', '9808030991', 'Dawa Gambo Tamang', '9861573872', 'Chenga Dolma Tamang', '9861573872', 'Rasuwa', '', ''),
(236, 'Ms.', 'Amrita Thapa', 'B281', 'profile_photos/photoid@1576740961.jpg', '9840665056', '23/04/2009', '', 'Nepalese', 'Dolpa', 'Female', '22/02/2018', 'Two', 'Gambir Thapa', '9867368044', 'Gambir Thapa', '9840665056', 'Supari Thapa', '9840665056', 'Dolpa', '', ''),
(237, 'Mr.', 'Sangey Thiley Tamang', 'B287', 'profile_photos/photoid@1576741506.jpg', '9868377935', '28/05/2008', '', 'Nepalese', 'Mugu', 'Male', '10/04/2018', 'Two', 'Tsering ', '9841797434', 'Sherap Gyamtso Tamang', '9868377935', 'Teshang Mendik Tamang', '9868377935', 'Mugu', '', ''),
(238, 'Mr.', 'Pema Dorje Tamang', 'B289', 'profile_photos/photoid@1576742035.jpg', '9868377935', '09/01/2007', '', 'Nepalese', 'Mugu', 'Male', '10/04/2018', 'Two', 'Tsering', '9841797434', 'Sherap Gyamtso Tamang', '9868377935', 'Teshang Mendik Tamang', '9868377935', 'Mugu', '', ''),
(239, 'Ms.', 'Tsewang Sangmu Lama', 'B296', 'profile_photos/photoid@1576832121.jpg', '9869460570', '27/12/2005', '', 'Nepalese', 'Mugu', 'Female', '10/04/2018', 'Two', 'Tsering Dolma Lama', '9869399051', 'Torchee Lama', '9869460570', 'Sangmu Lama', '9869460570', 'Mugu', '', ''),
(240, 'Ms.', 'Pasang Putit Lama', 'B322', 'profile_photos/photoid@1576832569.jpg', '9860395132', '19/05/2006', '', 'Nepalese', 'Mugu', 'Female', '10/04/2018', 'Two', 'Tsering Lama', '9808487726', 'Samden Torchee Lama', '9860395132', 'Tsering Ghyalzom Lama', '9860395132', 'Mugu', '', ''),
(241, 'Ms.', 'Nyima Sangmu Lama', 'B324', 'profile_photos/photoid@1576832930.jpg', '9866550595', '13/04/2008', '', 'Nepalese', 'Mugu', 'Female', '10/04/2018', 'Two', 'Mengzom Lama', '9843390187', 'Dorpa Tsering Lama', '9866550595', 'Pema Khando Lama', '9866550595', 'Mugu', '', ''),
(242, 'Ms.', 'Tsering Yangzom Tamang', 'B325', 'profile_photos/photoid@1576833233.jpg', '9860395132', '20/12/2007', '', 'Nepalese', 'Mugu', 'Female', '10/04/2018', 'Two', 'Tsering Norbu Tamang', '9818579272', 'Tsering Norbu Tamang', '9860395132', 'Nyima Phuti Tamang', '9860395132', 'Mugu', '', ''),
(243, 'Ms.', 'Doma Sherpa', 'B338', 'profile_photos/photoid@1576833554.jpg', '9863395984', '18/01/2010', '', 'Nepalese', 'Sindhupalchok', 'Female', '10/04/2018', 'Two', 'Sang Dolma Sherpa', '9860583989', 'Thinlen Sherpa', '9863395984', 'Pem Sangmu Sherpa', '9863395984', 'Sindhupalchok', '', '');
INSERT INTO `student` (`empid`, `title`, `name`, `add_num`, `photo`, `mobile`, `dob`, `email`, `nationality`, `currentaddress`, `gender`, `doj`, `grade`, `guardianname`, `guardiannum`, `father`, `fathernum`, `mother`, `mothernum`, `peraddress`, `sibling`, `sibling_mobile`) VALUES
(244, 'Ms.', 'Tsering Aangmu Tamang', 'B350', 'profile_photos/photoid@1576833859.jpg', '9868965584', '23/05/2009', '', 'Nepalese', 'Mugu', 'Female', '10/04/2018', 'Two', 'Chomphel Tamang', '9868965584', 'Lhamdup Tamang', '9868965584', 'Yangzom Tamang', '9868965584', 'Mugu', '', ''),
(245, 'Mr.', 'Phurba Gyalgen Lama', 'B370', 'profile_photos/photoid@1576834159.jpg', '9865705532', '23/07/2008', '', 'Nepalese', 'Sindhupalchok', 'Male', '10/04/2019', 'Two', 'Nu Dolma Sherpa', '9840836742', 'Nima Tsering Lama', '9865705532', 'Nu Dolma Sherpa', '9865705532', 'Sindhupalchok', '', ''),
(246, 'Ms.', 'Anjali Kumari', 'B387', 'profile_photos/photoid@1577244633.jpg', '9845170708', '19/11/2008', '', 'Nepalese', 'Rautahut', 'Female', '29/04/2016', 'Two', 'Maha Sundar Devi', '9845270496', 'Birendra Mahato', '9845170708', 'Maha Sundar Devi', '9845170708', 'Rautahut', '', ''),
(247, 'Mr.', 'Rahul Kumar Mahato', 'B388', 'profile_photos/photoid@1577245558.jpg', '9826253213', '09/04/2009', '', 'Nepalese', 'Rautahut', 'Male', '29/04/2016', 'Two', 'Chautari Mahato', '9841186457', 'Hari Kishan Mahato Nuniya', '9826253213', 'Raj Kumari Devi', '9826253213', 'Rautahut', '', ''),
(248, 'Ms.', 'Tashi Lhamu Lama', 'B136', 'profile_photos/photoid@1577246468.jpg', '9843882658', '27/03/2006', '', 'Nepalese', 'Gorkha', 'Female', '18/04/2014', 'One \'A\'', 'Dhirjen Dorma Lama', '9803598073', 'Chhewang Germi Lama', '9843882658', ' Dhirjen Dorma Lama', '9843882658', 'Gorkha', '', ''),
(249, 'Mr.', 'Dawa Tsering Lama', 'B175', 'profile_photos/photoid@1577259255.jpg', '9741429363', '18/12/2010', '', 'Nepalese', 'Gorkha', 'Male', '10/04/2018O', 'One \'A\'', 'Phuntso Lama', '9813088830', 'Renzo Lama', '9741429363', 'Tsering Bhutti Lama', '9741429363', 'Gorkha', '', ''),
(250, 'Mr.', 'Tashi Tsering Lama', 'B183', 'profile_photos/photoid@1577259751.jpg', '9869762620', '02/11/2012', '', 'Nepalese', 'Gorkha', 'Male', '07/08/2015', 'One \'A\'', 'Nyima Sangmo', '9818152419', 'Mingyur Dorje Lama', '9869762620', 'Bhuti Lama', '9869762620', 'Gorkha', '', ''),
(251, 'Ms.', 'Pema Dolma Lama', 'B191', 'profile_photos/photoid@1577260441.jpg', '9813323383', '31/07/2010', '', 'Nepalese', 'Gorkha', 'Female', '15/04/2015', 'One \'A\'', 'Nyima Chamu', '9813323383', 'Dawa Dorje Lama', '9813323383', 'Pema Lama', '9813323383', 'Gorkha', '', ''),
(252, 'Mr.', 'Pema Namgyal Lama', 'B219', 'profile_photos/photoid@1577685408.jpg', '9868269806', '01/03/2010', '', 'Nepalese', 'Mugu', 'Male', '12/04/2016', 'One\'A\'', 'Angmo Lama', '9848388895', 'Sonam Dorje Lama', '9868269806', 'Sonam Choekyi Lama ', '9868269806', 'Mugu', '', ''),
(253, 'Mr.', 'Karma Sherab Gurung', 'B220', 'profile_photos/photoid@1577685770.jpg', '9810117045', '04/10/2009', '', 'Nepalese', 'Manang', 'Male', '12/04/2016', 'One\'A\'', 'Maya Gurung', '9810117045', 'Gyurmey Gurung', '9810117045', 'Maya Gurung', '9810117045', 'Manang', '', ''),
(254, 'Ms.', 'Dawa Choedon Lama', 'B221', 'profile_photos/photoid@1577686123.jpg', '9849041512', '12/02/2009', '', 'Nepalese', 'Gorkha', 'Female', '12/04/2016', 'One\'A\'', 'Tsering Dolma', '9849041512', 'Lobsang Phuntsok Lama', '9849041512', 'Amu Choedon', '9849041512', 'Gorkha', '', ''),
(255, 'Mr.', 'Dhan Bahadur Gurung', 'B224', 'profile_photos/photoid@1577686503.jpg', '9741143210', '11/05/2010', '', 'Nepalese', 'Gorkha', 'Male', '12/04/2016', 'One\'A\'', 'Dal Bahadur Gurung', '9741143210', 'Dal Bahadur Gurung', '9741143210', 'Laxmi Gurung', '9741143210', 'Gorkha', '', ''),
(256, 'Mr.', 'Sohan Tamang', 'B226', 'profile_photos/photoid@1577686882.jpg', '9616390137', '15/06/2009', '', 'Nepalese', 'Nuwakot', 'Male', '13/04/2016', 'One\'A\'', 'Nata Tamang', '9818255462', 'Santa Bahadur Tamang', '9616390137', 'Sapana Tamang', '9616390137', 'Nuwakot', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `username`, `password`) VALUES
(1, 'admin', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `marks`
--
ALTER TABLE `marks`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`empid`),
  ADD UNIQUE KEY `uname` (`add_num`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `marks`
--
ALTER TABLE `marks`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `student`
--
ALTER TABLE `student`
  MODIFY `empid` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=257;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
