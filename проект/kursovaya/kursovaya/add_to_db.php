<?php
// Параметры подключения к базе данных
$servername = "localhost";
$username = "root";
$dbpassword = "";
$dbname = "kursovaya";

// Устанавливаем соединение с базой данных
$conn = new mysqli($servername, $username, $dbpassword, $dbname);

// Проверяем соединение
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

// Получаем данные из POST запроса
$login = $_POST['login'];
$password = $_POST['password'];
$stmt = $conn->prepare("SELECT * FROM registration_data WHERE login=? AND password=?");
$stmt->bind_param("ss", $login,  $password);
$stmt->execute();


$result = $stmt->get_result();
$row = $result->fetch_assoc();  
//echo $_SESSION['id'];


if ($result->num_rows > 0) 
    echo "Вы уже авторизованы!" ;// Данные о регистрации найдены


else {
    // SQL запрос для добавления пользователя в базу данных
$sql = "INSERT INTO registration_data (login, password) VALUES ('$login', '$password')";

if ($conn->query($sql) === TRUE) {
    echo "Пользователь успешно добавлен в базу данных";
} else {
    echo "Ошибка: " . $sql . "<br>" . $conn->error;
}
}
$stmt->close();
// Закрываем соединение с базой данных
$conn->close();
?>