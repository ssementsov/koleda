using System;

namespace Task_37
{
    class Program  //Task_37
    {
        static void Main(string[] args)
        {
            string[] book = { "B1", "B2", "B3", "B4" };
            int i;
            string[,,] books = new string[2, 2, 2];
            bool find = false;

            books[0, 0, 0] = book[0];
            books[0, 1, 1] = book[1];
            books[1, 0, 1] = book[2];
            books[0, 1, 0] = book[3];

            Console.WriteLine("Введите название книги");
            string name = Console.ReadLine();

            for (i = 0; i < book.Length; i++)
            {
                if (name == book[i])
                {                    
                    find = true;
                    for (int cabinet = 0; cabinet < books.GetLength(0); cabinet++)
                    {
                        for (int shelf = 0; shelf < books.GetLength(1); shelf++)
                        {
                            for (int place = 0; place < books.GetLength(2); place++)
                            {
                                if (books[cabinet, shelf, place] == book[i])
                                {
                                    Console.WriteLine($"{name} находится в {cabinet}" +
                                        $" стелаже, на {shelf} полке, на {place} месте");
                                }
                            }
                        }
                    }
                }
            }
            if (find == false)
            {
                Console.WriteLine("Такая книга не найдена");
            }
        }
    }   
}

