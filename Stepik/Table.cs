using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepik
{
    class Table
    {
        public int Number;
        public int MaxPlaces;
        public int FreePlaces;

        public Table(int number, int maxPlaces)
        {
            Number = number;
            MaxPlaces = maxPlaces;
            FreePlaces = maxPlaces;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Стол: {Number}, свободно мест {FreePlaces}, максимальная вместимость {MaxPlaces}");
        }

        public bool Reserve(int places)
        {
            if (FreePlaces >= places)
            {
                FreePlaces -= places;
                return true;
            }
            else
                return false;
        }

        // main 

        //        Console.CursorVisible = false;
        //            bool isOpen = true;

        //        Table[] tables = { new Table(1, 4), new Table(2, 8), new Table(3, 10) };

        //            while (isOpen)
        //            {
        //                Console.WriteLine("Администрирование кафе.\n");

        //                for (int i = 0; i<tables.Length; i++)
        //                {
        //                    tables[i].ShowInfo();
        //    }
        //    Console.WriteLine("\nВведите номер стола:");
        //                int wishTable = Convert.ToInt32(Console.ReadLine()) - 1;
        //    Console.Write("\nВведите количество мест для брони\n");
        //                int desiredPlaces = Convert.ToInt32(Console.ReadLine());

        //    bool isReservationCompeted = tables[wishTable].Reserve(desiredPlaces);

        //                if (isReservationCompeted)
        //                {
        //                    Console.WriteLine("Бронь успешна");
        //                }
        //                else
        //{
        //    Console.WriteLine("Недостаточно мест");
        //}

        //Console.ReadKey();
        //Console.Clear();
    }
}
