using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RGR_2024_2d_course
{

    public class BinaryTree
    {
        private Node root; //задаем корень
        public void Add(float value) //задаем функцию добавления значения и проверки на корневое значения
        {
            if (root == null) //проверяем на наличие корня
            {
                root = new Node(value);
                Console.WriteLine("root-" + value);
            }// создаем корень обращаясь к классу узла
            else
                AddRecursive(root, value); //обращаемся к функции рекурсивного добавления значения в структуру дерева
        }
        private void AddRecursive(Node node, float value) //рекурсивное добавление значения в структуру дерева
        {
            if (value < node.Value) // находим куда отправлять полученное значения => вправо - большее, влево - меньшее
            {
                if (node.Left == null) // проверяю наличие значения в узле
                {
                    node.Left = new Node(value);
                    Console.WriteLine("l-" + value);
                }  // добавляю в структуру узла
                else
                    AddRecursive(node.Left, value); //рекурсивно прохожу по функции
            }
            else
            {
                if (node.Right == null) //проверяю наличие в узле
                { node.Right = new Node(value);
                    Console.WriteLine("r-" + value); } // добавляю
                else
                    AddRecursive(node.Right, value); //рекурсивно вызываю функцию
            }
        }

        public void PrintTree() //задаю процедуру вывода в консоль дерева
        {
            PrintTreeRecursively(root, 0); 
        }
        private void PrintTreeRecursively(Node node, float space)
        {
            if (node == null)
                return;
            space += 15;
            Console.Write("\n");
            for (int i = 10; i < space; i++)
                Console.Write(" ");
            Console.Write(node.Value + "\n");
            
            PrintTreeRecursively(node.Right, space);
            PrintTreeRecursively(node.Left, space-25);
        }
    }
}

