using System;
using System.Collections.Generic;

namespace zoo.console_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int input = 0;
            int input2 = 0;
            int input3 = 0;
            int input4 = 0;
            int input5 = 0;
            string info = "";
            int data = 0;
            int EmptyCount = 0;

            /*List<string[]> zoo = new List<string[]>();  */             //простейший список однотипных объектов
            Dictionary<int, string> zoo = new Dictionary<int, string>();


            Menu();
            input = Convert.ToInt32(Console.ReadLine());


            void Menu()
            {
                Console.Clear();
                string[] m = { "Зоопарк", "Животные", "Выход" };     //Основное меню
                for (int i = 0; i < m.Length; i++)
                    Console.WriteLine("\n{0}. {1}", i, m[i]);
                Console.WriteLine("Выберите пункт:");
                Menu2(Convert.ToInt32(Console.ReadLine()));
            }

            void Menu2(int input)
            {
                switch (input)
                {
                    case 0:
                        string[] s = { "Зоопарки города", "Подать заявку", "Заявки", "Удалить заявку", "Изменить заявку", "Назад" };    //zoo 
                        for (int i = 0; i < s.Length; i++)
                            Console.WriteLine("{0}. {1}", i, s[i]);
                        Menu_Zoo();
                        break;
                    case 1:
                        string[] z = { "Список отрядов животных Московского зоопарка", "Назад" };                               //animal
                        for (int i = 0; i < z.Length; i++)
                            Console.WriteLine("{0}. {1}", i, z[i]);
                        Menu_animal();
                        break;
                    case 2:
                        Exit();
                        void Exit() => Console.WriteLine("Для выхода нажмите любую клавишу");        //выход                                                
                        break;
                    default:
                        Console.WriteLine("Ошибка ввода");
                        break;
                }
            }

            void Menu_Zoo()
            {

                {
                    input2 = Convert.ToInt32(Console.ReadLine());
                    switch (input2)
                    {
                        case 0:
                            Zoo();
                            Console.WriteLine("Для выхода в меню нажмите любую клавишу");
                            Console.ReadKey();
                            Menu();
                            break;
                        case 1:
                            Zoo_info2();
                            break;
                        case 2:

                            Zoo_info1();
                            break;
                        case 5:
                            Menu();
                            break;
                        case 3:
                            deleting();
                            break;
                        case 4:
                            re();
                            break;
                        default:
                            Console.WriteLine("Ошибка ввода");
                            break;
                    }
                }
            }         //ввод второго уровня с клавиатуры

            void Menu_animal()
            {
                input3 = Convert.ToInt32(Console.ReadLine());                                  //ввод второго уровня с клавиатуры
                switch (input3)
                {
                    case 0:
                        Animal();
                        break;
                    case 1:
                        Menu();
                        break;
                    default:
                        Console.WriteLine("Ошибка ввода");
                        break;
                }
            }



            void Zoo_info2()            //добавление заявки
            {
                Console.Clear();
                Console.Write("Введите наименование услуги:  ");
                string info = Convert.ToString(Console.ReadLine());

                Console.Write("На какую дату текущего месяца?  ");
                try
                {
                    data = Convert.ToInt32(Console.ReadLine());
                    if (data > 31) {
                        Console.Write("Неверный формат даты.");
                        Console.ReadLine();
                        Console.Write("На какую дату текущего месяца?  ");
                        data = Convert.ToInt32(Console.ReadLine());
                    }
                } catch
                {
                    Console.Write("Неверный формат даты.");
                    Console.ReadLine();
                    Console.Write("На какую дату текущего месяца?  ");
                    data = Convert.ToInt32(Console.ReadLine());
                }
                

                zoo.Add(data, info);
                foreach (KeyValuePair<int, string> keyValue in zoo)
                {
                    Console.WriteLine(keyValue.Key + keyValue.Value);
                }

                //if (zoo.Keys.Count > 0) Console.Write("Услуга записана.Перейдите в список услуг");
                // else Console.WriteLine("Вы не выбрали услугу");
                //Console.ReadKey();
                Menu();

            }

            void Zoo_info1()                    //запись заявки 
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("------------------Заявки---------------------");                 //список добавленных заявок
                Console.ResetColor();



                foreach (KeyValuePair<int, string> keyValue in zoo)
                {
                    Console.WriteLine("Дата услуги: " + keyValue.Key + " Название услуги: " + keyValue.Value);
                }

                Console.WriteLine("Для выхода в меню нажмите любую клавишу");
                Console.ReadKey();
                Menu();

            }

            void re()
            {
                Console.Clear();
                foreach (KeyValuePair<int, string> keyValue in zoo)
                {
                    Console.WriteLine("Дата услуги: " + keyValue.Key + " Название услуги: " + keyValue.Value);
                }

                if (EmptyCount == zoo.Count())
                {
                    Console.WriteLine("Список заявок пуст. ");
                    Console.ReadLine();
                    Menu();
                }

                Console.WriteLine("Введите дату желаемой услуги для изменения данных: ");

                try
                {
                    data = Convert.ToInt32(Console.ReadLine());
                    if (data > 31)
                    {
                        Console.Write("Неверный формат даты.");
                        Console.ReadLine();
                        Console.Write("На какую дату текущего месяца?  ");
                        data = Convert.ToInt32(Console.ReadLine());
                    }
                }
                catch
                {
                    Console.Write("Неверный формат даты.");
                    Console.ReadLine();
                    Console.Write("Введите корректный формат даты.  ");
                    data = Convert.ToInt32(Console.ReadLine());
                }

                try
                {
                    zoo.Remove(data);

                }
                catch
                {
                    Console.WriteLine("Такой даты не существует. ");
                }

                Console.WriteLine("Введите новое название услуги: ");
                string info = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите новую дату: ");
                data = Convert.ToInt32(Console.ReadLine());

                zoo.Add(data, info);

                Console.WriteLine("Новый список заявок: ");
                foreach (KeyValuePair<int, string> keyValue in zoo)
                {
                    Console.WriteLine("Дата услуги: " + keyValue.Key + " Название услуги: " + keyValue.Value);
                }

                Menu();
            }

            void deleting()
            {
                Console.Clear();

                foreach (KeyValuePair<int, string> keyValue in zoo)
                {
                    Console.WriteLine("Дата услуги: " + keyValue.Key + " Название услуги: " + keyValue.Value);
                }
                if(EmptyCount == zoo.Count()) {
                    Console.WriteLine("Список заявок пуст. ");
                    Console.ReadLine();
                    Menu();
                }
                
                Console.WriteLine("Введите дату удалемой услуги: ");
                
                try
                {
                    data = Convert.ToInt32(Console.ReadLine());
                    if (data > 31)
                    {
                        Console.Write("Неверный формат даты.");
                        Console.ReadLine();
                        Console.Write("На какую дату текущего месяца?  ");
                        data = Convert.ToInt32(Console.ReadLine());
                    }
                }
                catch
                {
                    Console.Write("Неверный формат даты.");
                    Console.ReadLine();
                    Console.Write("Введите корректный формат даты.  ");
                    data = Convert.ToInt32(Console.ReadLine());
                }

                try
                {
                    zoo.Remove(data);   
                }
                catch
                {
                    Console.WriteLine("Такой даты не существует.");
                }
                Menu();
            }



            void Zoo()                                //Список зоопарков Москвы
            {
               
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n  ---------------------Зоопарки Москвы и московской обл.----------------------------------" +
                "\n№|         Название           |             Адрес                                         |" +
                "\n  ----------------------------------------------------------------------------------------" +
                "\n1| Московский зоопарк         |ул. Большая Грузинская, 1                                  |" +
                "\n2| Зооферма Шихово            |Московская обл., Дмитровский район, деревня Шихово, д. 100.|" +
                "\n3| Кино-зоостудия «Ковчег»    |Московская обл., г. Кашира                                 |" +
                "\n4| Контактный зоопарк «Горки» |Московская обл., Коломенский р-н, пос. Горки               |" +
"\n  ----------------------------------------------------------------------------------------\n");
                Console.ResetColor();

            }


            void Animal() //Таблица с информацией о животных
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Отряды животных:");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n1. Млекопитающие;" +
                    "\n2. Птицы;" +
                    "\n3. Рептилии;" +
                    "\n4. Амфибии;" +
                    "\n5. Рыбы;" +
                    "\n6. Беспозвоночные.");
                Console.ResetColor();
                Console.WriteLine("Для выхода в меню нажмите любую клавишу");
                Console.ReadKey();
                Menu();
            }
        }

    }
}
