-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Июн 05 2024 г., 18:11
-- Версия сервера: 10.4.28-MariaDB
-- Версия PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `kursovaya`
--

-- --------------------------------------------------------

--
-- Структура таблицы `day_info`
--

CREATE TABLE `day_info` (
  `id_user` int(11) NOT NULL,
  `day` date NOT NULL,
  `info` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `day_info`
--

INSERT INTO `day_info` (`id_user`, `day`, `info`) VALUES
(2, '2024-05-29', 'daddadad'),
(5, '2024-06-22', 'Информация не найденарррррррррр'),
(6, '2024-06-20', 'зубной 12-00'),
(5, '2024-06-20', 'Найденная информация: ооооооооо'),
(5, '2024-06-06', 'Найденная информация: aaaaa'),
(5, '2024-06-14', 'dadadda'),
(5, '2024-06-13', 'день как день'),
(5, '2024-06-04', 'шшшш'),
(8, '2024-06-12', 'зубной 15-00');

-- --------------------------------------------------------

--
-- Структура таблицы `registration_data`
--

CREATE TABLE `registration_data` (
  `id` int(11) NOT NULL,
  `login` text NOT NULL,
  `password` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `registration_data`
--

INSERT INTO `registration_data` (`id`, `login`, `password`) VALUES
(1, 'admin', '123'),
(2, 'aaa', '111'),
(3, 'aaa', '111'),
(4, 'ффф', '111'),
(5, '', ''),
(6, 'newuser', '123'),
(8, 'userx', '123');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `day_info`
--
ALTER TABLE `day_info`
  ADD KEY `id_user` (`id_user`) USING BTREE;

--
-- Индексы таблицы `registration_data`
--
ALTER TABLE `registration_data`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `registration_data`
--
ALTER TABLE `registration_data`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `day_info`
--
ALTER TABLE `day_info`
  ADD CONSTRAINT `day_info_ibfk_1` FOREIGN KEY (`id_user`) REFERENCES `registration_data` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
