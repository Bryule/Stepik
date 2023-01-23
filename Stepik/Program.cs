using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepik
{
    class Program
    {
        static void AirportArray()
        {
            int[] sectors = { 6, 28, 15, 15, 18 };
            bool isOpen = true;
            while (isOpen)
            {
                Console.SetCursorPosition(0, 18);
                for (int i = 0; i < sectors.Length; i++)
                {
                    Console.WriteLine($"В секторе {i + 1} свободно {sectors[i]} мест");
                }
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Регистрация рейса.");
                Console.WriteLine("\n\n1 - забронировать места\n\n2 - выход из программbl\n\n");
                Console.WriteLine("Введите номер команды: ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int userSector;
                        int userPlaceAmount;
                        Console.WriteLine("В каком секторе вы хотите лететь?");
                        userSector = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (sectors.Length <= userSector || 0 > userSector)
                        {
                            Console.WriteLine("Такого сектора не существует");
                            break;
                        }
                        Console.Write("Сколько мест вы хотите забронировать?");
                        userPlaceAmount = Convert.ToInt32(Console.ReadLine());
                        if (sectors[userSector] < userPlaceAmount || userPlaceAmount < 0)
                        {
                            Console.WriteLine($"В секторе {userSector} недостаточно мест. " +
                                $"Остаток {sectors[userSector]}");
                            break;
                        }
                        sectors[userSector] -= userPlaceAmount;
                        break;
                    case 2:
                        isOpen = false;
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void arraytwo()
        {
            int[,] array = new int[4, 4];
            Random rand = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(2, 10);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void LibraryArray()
        {
            string[,] library =
            {
                { "Пушкин", "Есенин", "Достоевский" },
                { "Маяковский", "Гоголь", "Горький" },
                { "Лермонтов", "Грибоедов", "Толстой" }
            };
            bool isOpen = true;
            while (isOpen)
            {
                Console.SetCursorPosition(0, 20);
                Console.WriteLine("\nВесь список авторов:\n");
                for (int i = 0; i < library.GetLength(0); i++)
                {
                    for (int j = 0; j < library.GetLength(1); j++)
                    {
                        Console.Write(library[i, j] + "| ");

                    }
                    Console.WriteLine();
                }
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Библиотека\n");
                Console.WriteLine("\n1.Узнать имя автора по индексу книги" +
                    "\n\n2.Найти книгу по автору\n\n3. Выход\n");
                Console.Write("Выберите пункт меню: ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int line;
                        int column;
                        Console.Write("Введите номер полки: ");
                        line = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.Write("Введите номер cтолбика: ");
                        column = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine($"Это автор {library[line, column]} ");
                        break;
                    case 2:
                        string author;
                        bool authorIsFound = false;
                        Console.Write("Введите автора: ");
                        author = Console.ReadLine();
                        for (int i = 0; i < library.GetLength(0); i++)
                        {
                            for (int j = 0; j < library.GetLength(1); j++)
                            {
                                if (author.ToLower() == library[i, j].ToLower())
                                {
                                    Console.Write($"Автор {library[i, j]} находится на {i + 1} полке, " +
                                        $"в {j + 1} столбце\n");
                                    authorIsFound = true;
                                }

                            }
                        }
                        if (authorIsFound == false)
                            Console.WriteLine("Такого автора нет!");
                        break;
                    case 3:
                        isOpen = false;
                        break;
                    default:
                        Console.WriteLine("Введена неверная команда");
                        break;
                }
                if (isOpen)
                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                Console.ReadKey();
                Console.Clear();
            }
        }


        static void Game()
        {
            Console.CursorVisible = false;
            char[,] map =
            {
                {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'  },
                {'#', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X', '#'  },
                {'#', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'  },
                {'#', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'  },
                {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', '#', '#', '#', ' ', ' ', '#'  },
                {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', 'X', '#', ' ', ' ', '#'  },
                {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', '#', ' ', ' ', '#'  },
                {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', '#', ' ', ' ', '#'  },
                {'#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', '#', ' ', ' ', '#'  },
                {'#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', '#', ' ', ' ', '#'  },
                {'#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', '#', ' ', ' ', '#'  },
                {'#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'  },
                {'#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'  },
                {'#', 'X', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'  },
                {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'  },
            };
            int userX = 6;
            int userY = 6;
            char[] bag = new char[1];
            bool isStart = true;

            while (isStart)
            {
                Console.SetCursorPosition(0, 20);
                Console.Write("Сумка");
                for (int i = 0; i < bag.Length; i++)
                {
                    Console.Write(bag[i] + " ");
                }
                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        Console.Write(map[i, j]);

                    }
                    Console.WriteLine();
                }
                Console.SetCursorPosition(userY, userX);
                Console.Write('@');
                ConsoleKeyInfo charKey = Console.ReadKey();
                switch (charKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (map[userX - 1, userY] != '#')
                            userX--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (map[userX + 1, userY] != '#')
                            userX++;
                        break;
                    case ConsoleKey.LeftArrow:
                        if (map[userX, userY - 1] != '#')
                            userY--;
                        break;
                    case ConsoleKey.RightArrow:
                        if (map[userX, userY + 1] != '#')
                            userY++;
                        break;
                }
                if (map[userX, userY] == 'X')
                {

                    map[userX, userY] = 'o';
                    char[] tempBag = new char[bag.Length + 1];
                    for (int i = 0; i < bag.Length; i++)
                    {
                        tempBag[i] = bag[i];
                    }
                    tempBag[tempBag.Length - 1] = 'X';
                    bag = tempBag;
                }
                Console.Clear();
            }
        }

        static void stringPractice()
        {
            Console.WriteLine("Привет");
            WriteError();
            Console.WriteLine("Странно");
            WriteError();
        }
        static void WriteError()
        {
            ConsoleColor defeaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Нет соединения с интернетом");
            Console.ForegroundColor = defeaultColor;
        }

        static void Main(string[] args)
        {
            stringPractice();
        }

    }
}



