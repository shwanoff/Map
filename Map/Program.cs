using System;

namespace Map
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем словарь с начальными данными.
            var map = new Map<int, string>();
            map.Add(1, "Hello");
            map.Add(2, "world");
            map.Add(new Item<int, string>(3, "Hey"));
            map.Add(new Item<int, string>(4, "Space"));
            ShowMap(map, "Created map");

            // Изменяем один из элементов словаря.
            map.Update(2, "Beautiful World");
            ShowMap(map, "Updated map");

            // Удаляем один элемент словаря.
            map.Remove(4);
            ShowMap(map, "Cleared map");

            Console.ReadLine();
        }

        /// <summary>
        /// Вывести словарь на экран.
        /// </summary>
        /// <param name="map"> Словарь. </param>
        /// <param name="title"> Заголовок перед выводом словаря. </param>
        private static void ShowMap(Map<int, string> map, string title)
        {
            Console.WriteLine($"{title}: ");
            foreach(var key in map.Keys)
            {
                // Получаем значение словаря по ключу.
                var value = map.Get(key);
                Console.WriteLine($"{key} - {value}");
            }
            Console.WriteLine();
        }
    }
}
