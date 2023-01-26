using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Stepik
{
    class Before_OOP
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
        //Array Library
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

        //Game Mini Pacman
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
        //DrawBar
        static void MainDrawBar()
        {
            int health = 5;
            int maxHealth = 10;
            int mana = 7;
            int maxMana = 10;
            while (true)
            {
                DrawBar(health, maxHealth, ConsoleColor.Green, 0, '|');
                DrawBar(mana, maxMana, ConsoleColor.Blue, 1);

                Console.SetCursorPosition(0, 5);
                Console.Write("Введите число на которое изменится health ");
                health = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите число на которое изменится mana ");
                mana = Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void DrawBar(int value, int maxValue, ConsoleColor color, int position, char symbol = '_')
        {
            ConsoleColor defaulColor = Console.BackgroundColor;

            string bar = "";
            for (int i = 0; i < value; i++)
            {
                bar += symbol;
            }

            Console.SetCursorPosition(0, position);
            Console.Write('{');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaulColor;

            bar = "";

            for (int i = value; i < maxValue; i++)
            {
                bar += symbol;
            }
            Console.Write(bar + '}');
        }


        //Pacman
        //#region Pacman
        //static void Pacman()
        //{
        //    char[,] map = ReadMap("map.txt");
        //    ConsoleKeyInfo pressedKey = new ConsoleKeyInfo('w', ConsoleKey.W, false, false, false);
        //    Console.CursorVisible = false;

        //    Task.Run(() =>
        //    {
        //        while (true)
        //        {
        //            pressedKey = Console.ReadKey();

        //        }
        //    });

        //    int pacmanX = 1;
        //    int pacmanY = 1;
        //    int score = 0;

        //    while (true)
        //    {
        //        Console.Clear();
        //        HandleInput(pressedKey, ref pacmanX, ref pacmanY, ref score, map);

        //        Console.ForegroundColor = ConsoleColor.Blue;
        //        DrawMap(map);

        //        Console.ForegroundColor = ConsoleColor.Yellow;
        //        Console.SetCursorPosition(pacmanX, pacmanY);
        //        Console.Write('@');

        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.SetCursorPosition(21, 0);
        //        Console.Write($"Score: {score}");
        //        Thread.Sleep(1000);


        //    }
        //}

        //private static char[,] ReadMap(string path)
        //{
        //    string[] file = File.ReadAllLines("map.txt");
        //    char[,] map = new char[GetMaxLenghtOfLine(file), file.Length];

        //    for (int x = 0; x < map.GetLength(0); x++)
        //    {
        //        for (int y = 0; y < map.GetLength(1); y++)
        //        {
        //            map[x, y] = file[y][x];
        //        }
        //    }
        //    return map;
        //}

        //private static int GetMaxLenghtOfLine(string[] lines)
        //{
        //    int maxLength = lines[0].Length;
        //    foreach (var line in lines)
        //        if (line.Length > maxLength)
        //            maxLength = line.Length;

        //    return maxLength;
        //}

        //private static void DrawMap(char[,] map)
        //{
        //    for (int y = 0; y < map.GetLength(1); y++)
        //    {

        //        for (int x = 0; x < map.GetLength(0); x++)
        //        {
        //            Console.Write(map[x, y]);
        //        }
        //        Console.Write("\n");
        //    }


        //}

        //private static void HandleInput(ConsoleKeyInfo pressedKey, ref int pacmanX, ref int pacmanY, ref int score, char[,] map)
        //{
        //    int[] direction = GetDirection(pressedKey);
        //    int nextPacmanPositionX = pacmanX + direction[0];
        //    int nextPacmanPositionY = pacmanY + direction[1];

        //    char nextCell = map[nextPacmanPositionX, nextPacmanPositionY];

        //    if (nextCell == ' ' || nextCell == '.')
        //    {
        //        pacmanX = nextPacmanPositionX;
        //        pacmanY = nextPacmanPositionY;
        //        if (nextCell == '.')
        //        {
        //            score++;
        //            map[nextPacmanPositionX, nextPacmanPositionY] = ' ';
        //        }

        //    }

        //}

        //private static int[] GetDirection(ConsoleKeyInfo pressedKey)
        //{
        //    int[] direction = { 0, 0 };
        //    if (pressedKey.Key == ConsoleKey.UpArrow)
        //    {
        //        direction[1] = -1;
        //    }
        //    else if (pressedKey.Key == ConsoleKey.DownArrow)
        //    {
        //        direction[1] = 1;
        //    }
        //    if (pressedKey.Key == ConsoleKey.LeftArrow)
        //    {
        //        direction[0] = -1;
        //    }
        //    if (pressedKey.Key == ConsoleKey.RightArrow)
        //    {
        //        direction[0] = 1;
        //    }
        //    return direction;

        //}

        //#endregion

        static void ListPractice()
        {
            List<int> number = new List<int>();
            number.Add(12);
            number.Add(5);
            number.Add(8);
            number.Add(3);

            number.AddRange(new int[] { 4, 1, 7, 9 });

            number.RemoveAt(2);
            number.Remove(3);
            number.Clear();
            for (int i = 0; i < number.Count; i++)
            {
                Console.WriteLine(number[i]);
            }
        }

        static void DictionaryPractice()
        {
            Dictionary<string, string> countriesCapitals = new Dictionary<string, string>();

            countriesCapitals.Add("Австралия", "Канберра");
            countriesCapitals.Add("Турция", "Анкара");
            countriesCapitals.Add("Германия", "Берлин");

            foreach (var item in countriesCapitals)
            {
                Console.WriteLine($"Страна: - {item.Key} столица - {item.Value}");
            }



        }
    }
}
