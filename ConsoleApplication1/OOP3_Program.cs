using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class OOP3_Program
    {
        int i, j, k;
        string str1;
        Box b;
        static void Main(string[] args)
        {   
            Box smallBox = new Box(100);
            smallBox.breath = 10;
            smallBox.length = 10;
            smallBox.width = 10;
            smallBox.isOpaque = true;
            //smallBox.color = "White";
            smallBox.setColor("white");
            Console.WriteLine(smallBox.volume());
            smallBox.changeColor("Red");
            Console.WriteLine(smallBox.color);
            smallBox.PrintBoxColor();
            //smallBox.color = "Black";
            smallBox.setColor("White");
            smallBox.PrintBoxColor();
            smallBox.dismantleBox();

            Box biggerBox = new Box();
            //biggerBox.color = "Yellow";
            biggerBox.setColor("Yellow");
            biggerBox.PrintBoxColor();

            biggerBox.init(10, 20, 30);

            Console.Read();
        }

        void test()
        {
            
        }


    }

    class Box
    {
        public int length;
        public  int width;
        public int breath;
        public bool isOpaque;
        public string color { get;private set; }

        public Box()
        {
            length = breath=width=10;
            isOpaque = true;
            color = "Blue";
            Console.WriteLine("I am in constructor");
        }

        public Box(int i)
        {
            length = breath = width = i;
            isOpaque = true;
            color = "Blue";
            Console.WriteLine("I am in constructor");
        }
        public void init(int i, int j, int k)
        {
            length = i;
            width = j;
            breath = k;
            isOpaque = true;
            color = "Blue";
            Console.WriteLine("I am in init method");
        }
        public void init(int i, float j, int k)
        {
            length = i;
            //width = j;
            breath = k;
            isOpaque = true;
            color = "Blue";
            Console.WriteLine("I am in init method");
        }
        public void init(int i, int j, string k)
        {
            length = i;
            width = j;
            //breath = k;
            isOpaque = true;
            color = "Blue";
            Console.WriteLine("I am in init method");
        }

        public void init(int i, int j)
        {
            length = i;
            width = j;
            breath =10;
            isOpaque = true;
            color = "Blue";
            Console.WriteLine("I am in init method");
        }

        public int volume()
        {
            return length * width * breath;
        }

        public void changeColor(string color)
        {

            this.color = color;

            Console.WriteLine("Color of the box is changed to "+this.color);
        }

        public void setColor(string color)
        {
            this.color = color;
            Console.WriteLine("Color of the box is set to " + this.color);
        }

        public void PrintBoxColor()
        {
            Console.WriteLine("Color of the box is " + this.color);
        }

        public void dismantleBox()
        {
            Console.WriteLine("Box is dismantled!");
        }

        public void checkOpaqueness()
        {
            if (isOpaque)
            {
                Console.WriteLine("Box is Opaque!");
            }
            else
                Console.WriteLine("Box is NOT Opaque!");
        } 


    }
}


//class  --- template
//object    --- completely defined

