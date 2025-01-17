using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovaya
{
  public partial class Form3 : Form
    {
        private string selectedDate;

        private bool islog;
        private int id;
        public Form3(string selectedDate, bool islog, int id)
        {
            
            this.selectedDate = selectedDate;
            this.id = id;
            this.islog = islog;
            InitializeComponent();
            label2.Text = selectedDate;
            if (islog == true)
            {
                button1.Visible = true;
                button4.Visible = false;
                button3.Visible = true;
            }
            else
            {
                button1.Visible = false;
                button3.Visible = false;
                button4.Visible = true;
            }
            
            DateTime dateValue;

            if (DateTime.TryParse(selectedDate, out dateValue))
            {
                // Форматирование даты в формат, который ожидается в БД
                string formattedDate = dateValue.ToString("yyyy-MM-dd");

                string url = "http://localhost/test/kursovaya/select_from_db.php"; // Укажите URL вашего PHP скрипта
                string postData = $"date={formattedDate}&id={id}"; // Используйте отформатированную дату

                try
                {
                    // Отправляем POST-запрос на сервер PHP
                    WebRequest request = WebRequest.Create(url);
                    request.Method = "POST";
                    request.ContentType = "application/x-www-form-urlencoded";

                    using (StreamWriter writer = new StreamWriter(request.GetRequestStream()))
                    {
                        writer.Write(postData);
                    }

                    // Получаем ответ от сервера PHP
                    WebResponse response = request.GetResponse();
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        string result = reader.ReadToEnd();
                        richTextBox1.Text = result;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Неверный формат даты");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateValue;

            if (DateTime.TryParse(selectedDate, out dateValue))
            {
                // Форматирование даты в формат, который ожидается в БД
                string formattedDate = dateValue.ToString("yyyy-MM-dd");
                string info = richTextBox1.Text;
                string url = "http://localhost/test/kursovaya/change_data.php"; // Укажите URL вашего PHP скрипта
                MessageBox.Show(info);
                string postData = $"date={formattedDate}&id={id}&info={info}"; // Используйте отформатированную дату

                try
                {
                    // Отправляем POST-запрос на сервер PHP
                    WebRequest request = WebRequest.Create(url);
                    request.Method = "POST";
                    request.ContentType = "application/x-www-form-urlencoded";

                    using (StreamWriter writer = new StreamWriter(request.GetRequestStream()))
                    {
                        writer.Write(postData);
                    }

                    // Получаем ответ от сервера PHP
                    WebResponse response = request.GetResponse();
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        string result = reader.ReadToEnd();
                        richTextBox1.Text = result;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Вы не зарегистрированы");
                }
            }
            else
            {
                MessageBox.Show("Вы не зарегистрированы");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(islog, id);

            this.Dispose();
            form1.Visible = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            DateTime dateValue;

            if (DateTime.TryParse(selectedDate, out dateValue))
            {
                // Форматирование даты в формат, который ожидается в БД
                string formattedDate = dateValue.ToString("yyyy-MM-dd");

                string url = "http://localhost/test/kursovaya/select_from_db.php"; // Укажите URL вашего PHP скрипта
                string postData = $"date={formattedDate}&id={id}"; // Используйте отформатированную дату

                try
                {
                    // Отправляем POST-запрос на сервер PHP
                    WebRequest request = WebRequest.Create(url);
                    request.Method = "POST";
                    request.ContentType = "application/x-www-form-urlencoded";

                    using (StreamWriter writer = new StreamWriter(request.GetRequestStream()))
                    {
                        writer.Write(postData);
                    }

                    // Получаем ответ от сервера PHP
                    WebResponse response = request.GetResponse();
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        string result = reader.ReadToEnd();
                        richTextBox1.Text = result;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Неверный формат даты");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(selectedDate);
            this.Visible = false;
            newForm.Show();
        }
    }
}
