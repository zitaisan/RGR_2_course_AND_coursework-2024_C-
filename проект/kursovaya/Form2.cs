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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;

namespace kursovaya
{
    //форма проверяет регистрацию с сайта. если нет, то выводит регистрацию, если есть то перекидывает на форму с отображением дня
    public partial class Form2 : Form
    {
        private bool islog;
        private string selectedDate;
        public Form2(string selectedDate)
        {
            
            this.selectedDate = selectedDate;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            // Создаем запрос на проверку данных о регистрации
            string url = "http://localhost/test/kursovaya/check_registration.php";

            string postData = $"login={login}&password={password}";
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

                if (result == "failure")
                {
                    MessageBox.Show("Вы не зарегистрированы");

                }
                else
                {
                    islog = true;
                    int id = int.Parse(result);
                    MessageBox.Show("Вы прошли авторизацию!");
                    Form3 newForm = new Form3(selectedDate, islog, id);
                    this.Dispose();
                    newForm.Show();
                }
            }
        }
           catch (Exception ex)
           {
               MessageBox.Show("Вы не зарегистрированы");
           }
        }    
        private void button2_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;

            using (WebClient client = new WebClient())
            {
                var data = new NameValueCollection();
                data["login"] = login;
                data["password"] = password;

                byte[] response = client.UploadValues("http://localhost/test/kursovaya/add_to_db.php", "POST", data);

                string result = System.Text.Encoding.UTF8.GetString(response);
                MessageBox.Show(result);
            }

        }
    }
}


