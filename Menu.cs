using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251
{
    class Menu
    {
        List<Shape> shapes = new List<Shape>();
        public void Execute()
        {

            SelectOptions();
        }

        private void SelectOptions()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Esxoge una opción");
                Console.WriteLine("1. Crear una figura");
                Console.WriteLine("2. Ver todas tus figuras");
                Console.WriteLine("3. Salir");
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        bool continueCase1 = true;
                        while (continueCase1)
                        {
                            Console.WriteLine("Escoge cual figura crear");
                            Console.WriteLine("1. Rectángulo");
                            Console.WriteLine("2. Cuadrado");
                            Console.WriteLine("3. Círculo");
                            Console.WriteLine("4. Triángulo");
                            Console.WriteLine("5. Volver");
                            string selectioCase1 = Console.ReadLine();
                            switch (selectioCase1)
                            {
                                case "1":
                                    CreateRectangle();
                                    break;
                                case "2":
                                    CreateSquare();
                                    break;
                                case "3":
                                    CreateCircle();
                                    break;
                                case "4":
                                    CreateTriangle();
                                    break;
                                case "5":
                                    continueCase1 = false;
                                    break;
                                default:
                                    Console.WriteLine("Esa no es una opción");
                                    break;
                            }
                        }
                        
                        break;
                    case "2":
                        foreach(var shape in shapes)
                        {
                            Console.WriteLine(shape.GetDetails());
                        }
                        Console.ReadLine();
                        break;
                    case "3":
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("Esa no es una opción");
                        break;
                }
            }
        }

        private void CreateRectangle()
        {
            Console.WriteLine("Introduzca el nombre");
            string name = Console.ReadLine();
            Console.WriteLine("Introduzca la base");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca la altura");
            float h = float.Parse(Console.ReadLine());
            shapes.Add(new Rectangle(name, b, h));
            Console.WriteLine($"Se creó la figura {name} de base {b} y altura {h}");
            Console.ReadLine();
        }
        private void CreateSquare()
        {
            Console.WriteLine("Introduzca el nombre");
            string name = Console.ReadLine();
            Console.WriteLine("Introduzca el lado");
            float l = float.Parse(Console.ReadLine());
            shapes.Add(new Square(name, l));
            Console.WriteLine($"Se creó la figura {name} de lado {l}");
            Console.ReadLine();
        }
        private void CreateCircle()
        {
            Console.WriteLine("Introduzca el nombre");
            string name = Console.ReadLine();
            Console.WriteLine("Introduzca el radio");
            float r = float.Parse(Console.ReadLine());
            shapes.Add(new Circle(name, r));
            Console.WriteLine($"Se creó la figura {name} de radio {r}");
            Console.ReadLine();
        }
        private void CreateTriangle()
        {
            Console.WriteLine("Introduzca el nombre");
            string name = Console.ReadLine();
            Console.WriteLine("Introduzca la base");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca la altura");
            float h = float.Parse(Console.ReadLine());
            shapes.Add(new Triangle(name, b, h));
            Console.WriteLine($"Se creó la figura {name} de base {b} y altura {h}");
            Console.ReadLine();
        }
    }
}
