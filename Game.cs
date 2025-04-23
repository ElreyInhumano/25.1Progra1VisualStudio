using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251
{
    class Game
    {
        List<City> cities = new List<City>();
        List<IObtainTaxes> obtainTaxes = new List<IObtainTaxes>();

        LimaCity lima = new LimaCity("Lima", 1000, 2000, 1500, 0, false, false, false, false, false, false);
        TrujilloCity trujillo = new TrujilloCity("Trujillo", 850, 1800, 1300, 0, false, false, false, false, false, false);
        ChiclayoCity chiclayo = new ChiclayoCity("Chiclayo", 750, 1600, 1100, 0, false, false, false, false, false, false);

        bool playing = true;
        float money;
        float day = 0;
        public void Execute()
        {
            AddTolist();
            StartGame();
        }

        void StartGame()
        {
            Console.WriteLine("Estás en el país de Perú y eres su presidente, te tocará gestionar sus ciudades.");
            Console.ReadLine();
            Console.WriteLine("Actualmente tienes 3 ciudades:");
            Console.WriteLine($"{lima.GetDetails()}");
            Console.WriteLine($"{trujillo.GetDetails()}");
            Console.WriteLine($"{chiclayo.GetDetails()}");
            Console.ReadLine();
            Console.WriteLine("Al comienzo de cada día obtendrás la suma de los impuestos que genera cada ciudad.");
            Console.WriteLine("Además, cada día podrás comprar edificios y/o parques para cada ciudad, para que generen más impuestos.");
            Console.ReadLine();
            StartDay();
        }

        void StartDay()
        {
            playing = true;
            money = lima.ObtainTaxes() + trujillo.ObtainTaxes() + chiclayo.ObtainTaxes() + money;
            Console.WriteLine($"Tienes de dinero {money} soles");
            Console.WriteLine("Presiona Enter para empezar el día");
            Console.ReadLine();
            day += 1;
            Day();
        }

        void Day()
        {
            while (playing)
            {
                if (day % 7 != 0)
                {
                    bool buyingLima = true;
                    bool buyingTrujillo = true;
                    bool buyingChiclayo = true;
                    Console.WriteLine($"Estás en el día {day}");
                    Console.WriteLine("¿Qué quieres hacer?");
                    Console.WriteLine("Escribe 1 para seleccionar Lima");
                    Console.WriteLine("Escribe 2 para seleccionar Trujillo");
                    Console.WriteLine("Escribe 3 para seleccionar Chiclayo");
                    Console.WriteLine("Escribe 4 para ver tus estadísticas");
                    Console.WriteLine("Escribe 5 para pasar de día");
                    string selection = Console.ReadLine();
                    switch (selection)
                    {
                        case "1":
                            while (buyingLima)
                            {
                                Console.WriteLine("Escribe 1 para comprar edificio ");
                                Console.WriteLine("Escribe 2 para comprar parque");
                                Console.WriteLine("Escribe 3 para volver");
                                string selectionCase1 = Console.ReadLine();
                                switch (selectionCase1)
                                {
                                    case "1":
                                        if (!lima.building3)
                                        {
                                            if (money >= lima.priceBuild)
                                            {
                                                if (!lima.building1)
                                                {
                                                    lima.building1 = true;
                                                    lima.buildsCount += 1;
                                                    money -= lima.priceBuild;
                                                }
                                                else if (!lima.building2)
                                                {
                                                    lima.building2 = true;
                                                    lima.buildsCount += 1;
                                                    money -= lima.priceBuild;
                                                }
                                                else
                                                {
                                                    lima.building3 = true;
                                                    lima.buildsCount += 1;
                                                    money -= lima.priceBuild;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine($"Te faltan {lima.priceBuild -= money} soles");
                                                Console.ReadLine();
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ya tienes todos los edificios de esta ciudad no puedes comprar más");
                                            Console.ReadLine();
                                        }

                                        break;
                                    case "2":
                                        if (!lima.park3)
                                        {
                                            if (money >= lima.pricePark)
                                            {
                                                if (!lima.park1)
                                                {
                                                    lima.park1 = true;
                                                    lima.buildsCount += 1;
                                                    money -= lima.pricePark;
                                                }
                                                else if (!lima.park2)
                                                {
                                                    lima.park2 = true;
                                                    lima.buildsCount += 1;
                                                    money -= lima.pricePark;
                                                }
                                                else
                                                {
                                                    lima.park3 = true;
                                                    lima.buildsCount += 1;
                                                    money -= lima.pricePark;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine($"Te faltan {lima.pricePark -= money} soles");
                                                Console.ReadLine();
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ya tienes todos los parques de esta ciudad no puedes comprar más");
                                            Console.ReadLine();
                                        }
                                        break;
                                    case "3":
                                        Day();
                                        break;
                                    default:
                                        Console.WriteLine("Esa no es una opción");
                                        Day();
                                        break;
                                }
                            
                                    
                            }
                            break;
                        case "2":
                            while (buyingTrujillo)
                            {
                                Console.WriteLine("Escribe 1 para comprar edificio ");
                                Console.WriteLine("Escribe 2 para comprar parque");
                                Console.WriteLine("Escribe 3 para volver");
                                string selectionCase2 = Console.ReadLine();
                                switch (selectionCase2)
                                {
                                    case "1":
                                        if (!trujillo.building3)
                                        {
                                            if (money >= trujillo.priceBuild)
                                            {
                                                if (!trujillo.building1)
                                                {
                                                    trujillo.building1 = true;
                                                    trujillo.buildsCount += 1;
                                                    money -= trujillo.priceBuild;
                                                }
                                                else if (!trujillo.building2)
                                                {
                                                    trujillo.building2 = true;
                                                    trujillo.buildsCount += 1;
                                                    money -= trujillo.priceBuild;
                                                }
                                                else
                                                {
                                                    trujillo.building3 = true;
                                                    trujillo.buildsCount += 1;
                                                    money -= trujillo.priceBuild;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine($"Te faltan {trujillo.priceBuild -= money} soles");
                                                Console.ReadLine();
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ya tienes todos los edificios de esta ciudad no puedes comprar más");
                                            Console.ReadLine();
                                        }
                                        break;
                                    case "2":
                                        if (!trujillo.park3)
                                        {
                                            if (money >= trujillo.pricePark)
                                            {
                                                if (!trujillo.park1)
                                                {
                                                    trujillo.park1 = true;
                                                    trujillo.buildsCount += 1;
                                                    money -= trujillo.pricePark;
                                                }
                                                else if (!trujillo.park2)
                                                {
                                                    trujillo.park2 = true;
                                                    trujillo.buildsCount += 1;
                                                    money -= trujillo.pricePark;
                                                }
                                                else
                                                {
                                                    trujillo.park3 = true;
                                                    trujillo.buildsCount += 1;
                                                    money -= trujillo.pricePark;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine($"Te faltan {trujillo.pricePark -= money} soles");
                                                Console.ReadLine();
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ya tienes todos los parques de esta ciudad no puedes comprar más");
                                            Console.ReadLine();
                                        }
                                        break;
                                    case "3":
                                        Day();
                                        break;
                                    default:
                                        Console.WriteLine("Esa no es una opción");
                                        break;
                                }
                            }                            
                            break;
                        case "3":
                            while (buyingChiclayo)
                            {
                                Console.WriteLine("Escribe 1 para comprar edificio ");
                                Console.WriteLine("Escribe 2 para comprar parque");
                                Console.WriteLine("Escribe 3 para volver");
                                string selectionCase3 = Console.ReadLine();
                                switch (selectionCase3)
                                {
                                    case "1":
                                        if (!chiclayo.building3)
                                        {
                                            if (money >= chiclayo.priceBuild)
                                            {
                                                if (!chiclayo.building1)
                                                {
                                                    chiclayo.building1 = true;
                                                    chiclayo.buildsCount += 1;
                                                    money -= chiclayo.priceBuild;
                                                }
                                                else if (!chiclayo.building2)
                                                {
                                                    chiclayo.building2 = true;
                                                    chiclayo.buildsCount += 1;
                                                    money -= chiclayo.priceBuild;
                                                }
                                                else
                                                {
                                                    chiclayo.building3 = true;
                                                    chiclayo.buildsCount += 1;
                                                    money -= chiclayo.priceBuild;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine($"Te faltan {chiclayo.priceBuild -= money} soles");
                                                Console.ReadLine();
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ya tienes todos los edificios de esta ciudad no puedes comprar más");
                                            Console.ReadLine();
                                        }
                                        break;
                                    case "2":
                                        if (!chiclayo.park3)
                                        {
                                            if (money >= chiclayo.pricePark)
                                            {
                                                if (!chiclayo.park1)
                                                {
                                                    chiclayo.park1 = true;
                                                    chiclayo.buildsCount += 1;
                                                    money -= chiclayo.pricePark;
                                                }
                                                else if (!chiclayo.park2)
                                                {
                                                    chiclayo.park2 = true;
                                                    chiclayo.buildsCount += 1;
                                                    money -= chiclayo.pricePark;
                                                }
                                                else
                                                {
                                                    chiclayo.park3 = true;
                                                    chiclayo.buildsCount += 1;
                                                    money -= chiclayo.pricePark;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine($"Te faltan {chiclayo.pricePark -= money} soles");
                                                Console.ReadLine();
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ya tienes todos los parques de esta ciudad no puedes comprar más");
                                            Console.ReadLine();
                                        }
                                        break;
                                    case "3":
                                        Day();
                                        break;
                                    default:
                                        Console.WriteLine("Esa no es una opción");
                                        Day();
                                        break;
                                }
                            }                            
                            break;
                        case "4":
                            Console.WriteLine($"Tienes de dinero {money} soles");
                            Console.WriteLine($"{lima.GetDetails()}");
                            Console.WriteLine($"{trujillo.GetDetails()}");
                            Console.WriteLine($"{chiclayo.GetDetails()}");
                            Console.ReadLine();
                            break;
                        case "5":
                            StartDay();
                            playing = false;
                            break;
                        default:
                            Console.WriteLine("Esa no es una opción");
                            Day();
                            break;
                    }
                }
                else
                {
                    bool buyingLima = true;
                    bool buyingTrujillo = true;
                    bool buyingChiclayo = true;
                    Console.WriteLine($"Estás en el día {day}");
                    Console.WriteLine("¿Qué quieres hacer?");
                    Console.WriteLine("Escribe 1 para seleccionar Lima");
                    Console.WriteLine("Escribe 2 para seleccionar Trujillo");
                    Console.WriteLine("Escribe 3 para seleccionar Chiclayo");
                    Console.WriteLine("Escribe 4 para ver tus estadísticas");
                    Console.WriteLine("Escribe 5 para pasar de día y seguir intentando salvar a tu país");
                    Console.WriteLine("Escribe 6 para pasar escapar a Dinamarca con el dinero que has conseguido, dejando tu país a su suerte.");
                    string selection = Console.ReadLine();
                    switch (selection)
                    {
                        case "1":
                            while (buyingLima)
                            {
                                Console.WriteLine("Escribe 1 para comprar edificio ");
                                Console.WriteLine("Escribe 2 para comprar parque");
                                Console.WriteLine("Escribe 3 para volver");
                                string selectionCase1 = Console.ReadLine();
                                switch (selectionCase1)
                                {
                                    case "1":
                                        if (!lima.building3)
                                        {
                                            if (money >= lima.priceBuild)
                                            {
                                                if (!lima.building1)
                                                {
                                                    lima.building1 = true;
                                                    lima.buildsCount += 1;
                                                    money -= lima.priceBuild;
                                                }
                                                else if (!lima.building2)
                                                {
                                                    lima.building2 = true;
                                                    lima.buildsCount += 1;
                                                    money -= lima.priceBuild;
                                                }
                                                else
                                                {
                                                    lima.building3 = true;
                                                    lima.buildsCount += 1;
                                                    money -= lima.priceBuild;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine($"Te faltan {lima.priceBuild -= money} soles");
                                                Console.ReadLine();
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ya tienes todos los edificios de esta ciudad no puedes comprar más");
                                            Console.ReadLine();
                                        }

                                        break;
                                    case "2":
                                        if (!lima.park3)
                                        {
                                            if (money >= lima.pricePark)
                                            {
                                                if (!lima.park1)
                                                {
                                                    lima.park1 = true;
                                                    lima.buildsCount += 1;
                                                    money -= lima.pricePark;
                                                }
                                                else if (!lima.park2)
                                                {
                                                    lima.park2 = true;
                                                    lima.buildsCount += 1;
                                                    money -= lima.pricePark;
                                                }
                                                else
                                                {
                                                    lima.park3 = true;
                                                    lima.buildsCount += 1;
                                                    money -= lima.pricePark;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine($"Te faltan {lima.pricePark -= money} soles");
                                                Console.ReadLine();
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ya tienes todos los parques de esta ciudad no puedes comprar más");
                                            Console.ReadLine();
                                        }
                                        break;
                                    case "3":
                                        Day();
                                        break;
                                    default:
                                        Console.WriteLine("Esa no es una opción");
                                        Day();
                                        break;
                                }
                            }                            
                            break;
                        case "2":
                            while (buyingTrujillo)
                            {
                                Console.WriteLine("Escribe 1 para comprar edificio ");
                                Console.WriteLine("Escribe 2 para comprar parque");
                                Console.WriteLine("Escribe 3 para volver");
                                string selectionCase2 = Console.ReadLine();
                                switch (selectionCase2)
                                {
                                    case "1":
                                        if (!trujillo.building3)
                                        {
                                            if (money >= trujillo.priceBuild)
                                            {
                                                if (!trujillo.building1)
                                                {
                                                    trujillo.building1 = true;
                                                    trujillo.buildsCount += 1;
                                                    money -= trujillo.priceBuild;
                                                }
                                                else if (!trujillo.building2)
                                                {
                                                    trujillo.building2 = true;
                                                    trujillo.buildsCount += 1;
                                                    money -= trujillo.priceBuild;
                                                }
                                                else
                                                {
                                                    trujillo.building3 = true;
                                                    trujillo.buildsCount += 1;
                                                    money -= trujillo.priceBuild;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine($"Te faltan {trujillo.priceBuild -= money} soles");
                                                Console.ReadLine();
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ya tienes todos los edificios de esta ciudad no puedes comprar más");
                                            Console.ReadLine();
                                        }
                                        break;
                                    case "2":
                                        if (!trujillo.park3)
                                        {
                                            if (money >= trujillo.pricePark)
                                            {
                                                if (!trujillo.park1)
                                                {
                                                    trujillo.park1 = true;
                                                    trujillo.buildsCount += 1;
                                                    money -= trujillo.pricePark;
                                                }
                                                else if (!trujillo.park2)
                                                {
                                                    trujillo.park2 = true;
                                                    trujillo.buildsCount += 1;
                                                    money -= trujillo.pricePark;
                                                }
                                                else
                                                {
                                                    trujillo.park3 = true;
                                                    trujillo.buildsCount += 1;
                                                    money -= trujillo.pricePark;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine($"Te faltan {trujillo.pricePark -= money} soles");
                                                Console.ReadLine();
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ya tienes todos los parques de esta ciudad no puedes comprar más");
                                            Console.ReadLine();
                                        }
                                        break;
                                    case "3":
                                        Day();
                                        break;
                                    default:
                                        Console.WriteLine("Esa no es una opción");
                                        Day();
                                        break;
                                }
                            }                            
                            break;
                        case "3":
                            while (buyingChiclayo)
                            {
                                Console.WriteLine("Escribe 1 para comprar edificio ");
                                Console.WriteLine("Escribe 2 para comprar parque");
                                Console.WriteLine("Escribe 3 para volver");
                                string selectionCase3 = Console.ReadLine();
                                switch (selectionCase3)
                                {
                                    case "1":
                                        if (!chiclayo.building3)
                                        {
                                            if (money >= chiclayo.priceBuild)
                                            {
                                                if (!chiclayo.building1)
                                                {
                                                    chiclayo.building1 = true;
                                                    chiclayo.buildsCount += 1;
                                                    money -= chiclayo.priceBuild;
                                                }
                                                else if (!chiclayo.building2)
                                                {
                                                    chiclayo.building2 = true;
                                                    chiclayo.buildsCount += 1;
                                                    money -= chiclayo.priceBuild;
                                                }
                                                else
                                                {
                                                    chiclayo.building3 = true;
                                                    chiclayo.buildsCount += 1;
                                                    money -= chiclayo.priceBuild;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine($"Te faltan {chiclayo.priceBuild -= money} soles");
                                                Console.ReadLine();
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ya tienes todos los edificios de esta ciudad no puedes comprar más");
                                            Console.ReadLine();
                                        }
                                        break;
                                    case "2":
                                        if (!chiclayo.park3)
                                        {
                                            if (money >= chiclayo.pricePark)
                                            {
                                                if (!chiclayo.park1)
                                                {
                                                    chiclayo.park1 = true;
                                                    chiclayo.buildsCount += 1;
                                                    money -= chiclayo.pricePark;
                                                }
                                                else if (!chiclayo.park2)
                                                {
                                                    chiclayo.park2 = true;
                                                    chiclayo.buildsCount += 1;
                                                    money -= chiclayo.pricePark;
                                                }
                                                else
                                                {
                                                    chiclayo.park3 = true;
                                                    chiclayo.buildsCount += 1;
                                                    money -= chiclayo.pricePark;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine($"Te faltan {chiclayo.pricePark -= money} soles");
                                                Console.ReadLine();
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ya tienes todos los parques de esta ciudad no puedes comprar más");
                                            Console.ReadLine();
                                        }
                                        break;
                                    case "3":
                                        Day();
                                        break;
                                    default:
                                        Console.WriteLine("Esa no es una opción");
                                        Day();
                                        break;
                                }
                            }                            
                            break;
                        case "4":
                            Console.WriteLine($"Tienes de dinero {money} soles");
                            Console.WriteLine($"{lima.GetDetails()}");
                            Console.WriteLine($"{trujillo.GetDetails()}");
                            Console.WriteLine($"{chiclayo.GetDetails()}");
                            Console.ReadLine();
                            Day();
                            break;
                        case "5":
                            StartDay();
                            playing = false;
                            break;
                        case "6":
                            Console.WriteLine($"Felicidades lograste escapar de Perú con {money} soles, ahora puedes vivir una vida de lujo a costa de tu país");
                            Console.ReadLine();
                            playing = false;
                            break;
                        default:
                            Console.WriteLine("Esa no es una opción");
                            Day();
                            break;
                    }
                }


            }

        }

        void AddTolist()
        {
            cities.Add(lima);
            cities.Add(trujillo);
            cities.Add(chiclayo);

            obtainTaxes.Add(lima);
            obtainTaxes.Add(trujillo);
            obtainTaxes.Add(chiclayo);
        }
    }
}
