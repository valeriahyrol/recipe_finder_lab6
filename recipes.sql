-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Час створення: Трв 20 2024 р., 11:00
-- Версія сервера: 8.2.0
-- Версія PHP: 8.2.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База даних: `recipes`
--

-- --------------------------------------------------------

--
-- Структура таблиці `lab6`
--

DROP TABLE IF EXISTS `lab6`;
CREATE TABLE IF NOT EXISTS `lab6` (
  `id` int NOT NULL AUTO_INCREMENT,
  `title` varchar(255) NOT NULL,
  `text` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп даних таблиці `lab6`
--

INSERT INTO `lab6` (`id`, `title`, `text`) VALUES
(1, 'Pancakes', '2 cups flour, 2 eggs, 1 cup milk, 1 tbsp sugar, 1 tsp salt. Mix all ingredients and cook on a griddle.'),
(2, 'Spaghetti Bolognese', '200g spaghetti, 100g ground beef, 1 can tomato sauce, 1 onion, 2 cloves garlic, 1 tbsp olive oil. Cook spaghetti. In another pan, cook ground beef with chopped onion and garlic. Add tomato sauce and simmer for 20 minutes. Serve over spaghetti.'),
(3, 'Caesar Salad', '1 head romaine lettuce, 50g Parmesan cheese, 100g croutons, 1/2 cup Caesar dressing. Chop lettuce and mix with dressing. Add croutons and Parmesan cheese on top.'),
(4, 'Grilled Cheese Sandwich', '2 slices of bread, 2 slices of cheese, 1 tbsp butter. Butter the bread, place cheese between slices, and grill until golden brown.'),
(5, 'Chicken Curry', '200g chicken breast, 1 onion, 2 cloves garlic, 1 tbsp curry powder, 1 can coconut milk. Cook chopped onion and garlic in a pan. Add chicken and curry powder, cook until chicken is done. Add coconut milk and simmer for 15 minutes.'),
(6, 'Chocolate Cake', '2 cups flour, 1.5 cups sugar, 1 cup cocoa powder, 1.5 tsp baking powder, 1.5 tsp baking soda, 1 tsp salt, 2 eggs, 1 cup milk, 1/2 cup vegetable oil, 2 tsp vanilla extract. Mix dry ingredients. Add eggs, milk, oil, and vanilla, mix until smooth. Bake at 350°F for 30-35 minutes.'),
(7, 'Beef Tacos', '200g ground beef, 1 packet taco seasoning, taco shells, lettuce, tomato, cheese. Cook ground beef and add taco seasoning. Serve in taco shells with chopped lettuce, tomato, and cheese.'),
(8, 'Mushroom Soup', '200g mushrooms, 1 onion, 2 cloves garlic, 1 liter vegetable broth, 1 cup cream. Cook chopped onion and garlic. Add sliced mushrooms and cook until soft. Add vegetable broth and simmer for 20 minutes. Blend until smooth, then add cream.'),
(9, 'Apple Pie', '1 pie crust, 6 apples, 1 cup sugar, 1 tsp cinnamon, 1 tbsp flour, 1 tbsp lemon juice. Peel and slice apples. Mix with sugar, cinnamon, flour, and lemon juice. Place in pie crust and bake at 375°F for 50-60 minutes.'),
(10, 'French Toast', '4 slices of bread, 2 eggs, 1/2 cup milk, 1 tsp cinnamon, 1 tbsp butter. Mix eggs, milk, and cinnamon. Dip bread in mixture and cook in a buttered pan until golden brown.');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
