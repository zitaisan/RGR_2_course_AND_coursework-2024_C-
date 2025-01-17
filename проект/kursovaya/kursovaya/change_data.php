<?php
session_start();
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "kursovaya";

// Устанавливаем соединение с базой данных
$conn = new mysqli($servername, $username, $password, $dbname);

// Проверяем соединение
if ($conn->connect_error) {
    die("Ошибка соединения: " . $conn->connect_error);
}

// Переменные, полученные из POST (предполагается, что они были правильно переданы)
$id = $_POST['id'];
$info = $_POST['info'];
$date = $_POST['date'];

// SQL запрос для проверки существования записи
$sqlCheck = "SELECT * FROM day_info WHERE id_user = ? AND day = ?";
$stmtCheck = $conn->prepare($sqlCheck);
$stmtCheck->bind_param("is", $id, $date); // 'i' для int, 's' для string
$stmtCheck->execute();
$result = $stmtCheck->get_result();

if ($result->num_rows > 0) { // Если запись существует, обновляем
    $sqlUpdate = "UPDATE day_info SET info = ? WHERE id_user = ? AND day = ?";
    $stmtUpdate = $conn->prepare($sqlUpdate);
    $stmtUpdate->bind_param("sis", $info, $id, $date); // 's' для всех строковых значений
    if ($stmtUpdate->execute()) {
        echo "Запись успешно обновлена";
    } else {
        echo "Ошибка при обновлении записи: " . $conn->error;
    }
    $stmtUpdate->close();
} else { // Если записи нет, вставляем новую
    $sqlInsert = "INSERT INTO day_info (id_user, day, info) VALUES (?, ?, ?)";
    $stmtInsert = $conn->prepare($sqlInsert);
    $stmtInsert->bind_param("iss", $id, $date, $info);
    if ($stmtInsert->execute()) {
        echo "Новая запись успешно создана";
    } else {
        echo "Ошибка при вставке записи: " . $conn->error;
    }
    $stmtInsert->close();
}

$stmtCheck->close();
$conn->close();
?>
