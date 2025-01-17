using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_2024_2d_course
{
    public class Node
    {
        public float Value; //создаю структуру узла
        public Node Left;
        public Node Right;
        public Node(float value) //назначаю конструктор класса узла
        {
            Value = value;
            Left = Right = null;
        }
    }
}
