<?php

session_start();
$servername = "localhost"; // Имя сервера базы данных
$username = "root"; // Имя пользователя базы данных
$passwordbd = ""; // Пароль пользователя базы данных
$dbname = "kursovaya"; // Имя базы данных

// Получаем данные из POST-запроса
$login = $_POST['login'];
$password = $_POST['password'];

// Создаем соединение
$conn = new mysqli($servername, $username, $passwordbd, $dbname);

// Проверяем соединение
if ($conn->connect_error) {
    die("Ошибка соединения: " . $conn->connect_error);
}

// Подготавливаем запрос на выборку данных о регистрации пользователя
$stmt = $conn->prepare("SELECT * FROM registration_data WHERE login=? AND password=?");
$stmt->bind_param("ss", $login,  $password);
$stmt->execute();


$result = $stmt->get_result();
$row = $result->fetch_assoc();  
$_SESSION['id'] = $row['id'];
//echo $_SESSION['id'];


if ($result->num_rows > 0) {
    echo $row['id']; // Данные о регистрации найдены
} else {
    echo "failure"; // Данные о регистрации не найдены
}

// Закрываем соединение
$stmt->close();
$conn->close();
?>