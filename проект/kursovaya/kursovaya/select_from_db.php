<?php
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "kursovaya";
// Устанавливаем соединение с базой данных
$conn = new mysqli($servername, $username, $password, $dbname);
// Проверка успешности соединения
if ($conn->connect_error) {
    die("Ошибка соединения: " . $conn->connect_error);
}
// Получаем данные из POST, предполагаем, что они были проверены и очищены
$id = $_POST['id'];
$date = $_POST['date'];
// Используем подготовленный запрос для безопасности
$stmt = $conn->prepare("SELECT info FROM day_info WHERE id_user = ? AND day = ?");
$stmt->bind_param("is", $id, $date); // 'i' для int, 's' для string
// Выполнение запроса
$stmt->execute();
$result = $stmt->get_result();
// Проверка наличия записей
if ($result->num_rows > 0) {
    // Получаем информацию из первой строки результата
    $row = $result->fetch_assoc();
    $info = $row['info'];
    // Выводим информацию
    echo "Найденная информация: " . $info; 
} else {
    // Информируем пользователя об отсутствии данных
    echo "Информация по заданным параметрам не найдена.";
}
// Очищаем и закрываем объекты запроса
$stmt->close();
$conn->close();
?>