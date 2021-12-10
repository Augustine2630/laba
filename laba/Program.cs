using System;
using System.Collections.Generic;


    public class Program
    {
        public static void Main(string[] args)
        {
            Menus mn = new Menus(); 
            mn.Men();
        }
    }
    public class RequestOperations
    {

        int data;
        int EmptyCount = 0;

        Dictionary<int, string> request = new Dictionary<int, string>();

        Menus ms = new Menus();

        public void info2()            //добавление заявки
        {
            Console.Clear();
            Console.Write("Введите наименование продукта:  ");
            string info = Convert.ToString(Console.ReadLine());

            Console.Write("Дата регистрации?  ");
            try
            {
                data = Convert.ToInt32(Console.ReadLine());
                if (data > 31)
                {
                    Console.Write("Неверный формат даты.");
                    Console.ReadLine();
                    Console.Write("Дата регистрации?  ");
                    data = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch
            {
                Console.Write("Неверный формат даты.");
                Console.ReadLine();
                Console.Write("Дата регистрации?  ");
                data = Convert.ToInt32(Console.ReadLine());
            }


            request.Add(data, info);
            foreach (KeyValuePair<int, string> keyValue in request)
            {
                Console.WriteLine(keyValue.Key + keyValue.Value);
            }

            //if (request.Keys.Count > 0) Console.Write("Услуга записана.Перейдите в список услуг");
            // else Console.WriteLine("Вы не выбрали услугу");
            //Console.ReadKey();



        }

        public void info1()                    
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------------Заявки---------------------");                 //список добавленных заявок
            Console.ResetColor();



            foreach (KeyValuePair<int, string> keyValue in request)
            {
                Console.WriteLine("Дата регистрации: " + keyValue.Key + " Название продукта: " + keyValue.Value);
            }

            //int[] vs = new int[request.Count()];
            //request.Keys.CopyTo(vs, 0);

            //Console.WriteLine(vs);

            Console.WriteLine("Для выхода в меню нажмите любую клавишу");
            Console.ReadKey();
            ms.Men();

        }

        public void re()
        {
            Console.Clear();
            foreach (KeyValuePair<int, string> keyValue in request)
            {
                Console.WriteLine("Дата регистрации: " + keyValue.Key + " Название продукта: " + keyValue.Value);
            }

            if (EmptyCount == request.Count())
            {
                Console.WriteLine("Список заявок пуст. ");
                Console.ReadLine();
                ms.Men();
            }

            Console.WriteLine("Введите дату продукта для изменения: ");

            try
            {
                data = Convert.ToInt32(Console.ReadLine());
                if (data > 31)
                {
                    Console.Write("Неверный формат даты.");
                    Console.ReadLine();
                    Console.Write("Дата регистрации?  ");
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
                request.Remove(data);

            }
            catch
            {
                Console.WriteLine("Такой даты не существует. ");
            }

            Console.WriteLine("Введите новое название продукта: ");
            string info = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите новую дату: ");
            data = Convert.ToInt32(Console.ReadLine());

            request.Add(data, info);

            Console.WriteLine("Новый список заявок: ");
            foreach (KeyValuePair<int, string> keyValue in request)
            {
                Console.WriteLine("Дата регистрации: " + keyValue.Key + " Название продукта: " + keyValue.Value);
            }

            ms.Men();
    }

        public void deleting()
        {



            Console.Clear();

            foreach (KeyValuePair<int, string> keyValue in request)
            {
                Console.WriteLine("Дата регистрации: " + keyValue.Key + " Название продукта: " + keyValue.Value);
            }
            if (EmptyCount == request.Count())
            {
                Console.WriteLine("Список заявок пуст. ");
                Console.ReadLine();
            ms.Men();
        }




            Console.WriteLine("Введите дату удалемого продукта: ");

            try
            {
                data = Convert.ToInt32(Console.ReadLine());
                if (data > 31)
                {
                    Console.Write("Неверный формат даты.");
                    Console.ReadLine();
                    Console.Write("Дата регистрации?  ");
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
                request.Remove(data);
            }
            catch
            {
                Console.WriteLine("Такой даты не существует.");
            }
        ms.Men();



    }
    }


    public class Programs
    {
        public void Prgrm() {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Типы программных продуктов:");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n1. Видеоигры;" +
                "\n2. Офисные решения;" +
                "\n3. Бизнес решения;" +
                "\n4. Развлекательные;" +
                "\n5. Разработка ПО;" +
                "\n6. Сетевое ПО.");
            Console.ResetColor();
            Console.WriteLine("Для выхода в меню нажмите любую клавишу");
            Console.ReadKey();
        }
    }

    public class ProgTab
    {

        public void Tab()                                
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n  --------------------------Программные продукты-------------------------------------" +
            "\n№|         Название           |             Дата регистрации                              |" +
            "\n  ----------------------------------------------------------------------------------------" +
            "\n1| 1С                         |28.11.21                                                   |" +
            "\n2| MS Windows 11              |11.11.21                                                   |" +
            "\n3| Battlefield 2042           |19.11.21                                                   |" +
            "\n4| Forza Horizon 5            |9.11.21                                                    |" +
            "\n  ----------------------------------------------------------------------------------------\n");
            Console.ResetColor();
            Console.ReadKey();

        }
    }


public class Menus
{

    int input = 0;
    int input2 = 0;
    int input3 = 0;
    int input4 = 0;
    int input5 = 0;

    public void Men()
    {
        Console.Clear();
        Console.WriteLine(" 1. Продукты\n 2. Типы программных продуктов\n 3. Выход");
        input = Convert.ToInt32(Console.ReadLine());
        switch (input)
        {
            case 1:
               
                Menu2();
                Men();
                break;
            case 2:
                Programs prg = new Programs();
                prg.Prgrm();
                Men();
                break;
            case 3:
                break;
            default:
                break;
                
          


        }
    }

    public void Menu2()
    {
        Console.Clear();
        Console.WriteLine(" 1. Готовые продукты\n 2. Зарегистрировать продукт\n 3. Заявки на регистрацию\n 4. Удалить заявку\n 5. Изменить заявку\n 6. Назад");
        input2 = Convert.ToInt32(Console.ReadLine());
        RequestOperations rQ = new RequestOperations();
        switch (input2)
        {
            case 1:
                
                ProgTab PT = new ProgTab();
                PT.Tab();
                Men();
                break;
            case 2:
                rQ.info2();
                Men();
                break;
            case 3:
                rQ.info1();
                Men();
                break;
            case 4:
                rQ.deleting();
                Men();
                break;
            case 5:
                rQ.re();
                Men();
                break;
            case 6:
                Men();
                break;
        }
    }

    /*public void Menu()
    {

        Console.Clear();
        string[] m = { "Продукты", "Типы программных продуктов", "Выход" };     //Основное меню
        for (int i = 0; i < m.Length; i++)
        Console.WriteLine("\n{0}. {1}", i, m[i]);
        Console.WriteLine("Выберите пункт:");
        Menu2(Convert.ToInt32(Console.ReadLine()));
    }

    public void Menu2(int input)
    {
        input = Convert.ToInt32(Console.ReadLine());
        switch (input)
        {
            case 0:
                string[] s = { "Готовые продукты", "Зарегистрировать продукт", "Заявки на регистрацию", "Удалить заявку", "Изменить заявку", "Назад" };    //request 
                for (int i = 0; i < s.Length; i++)
                Console.WriteLine("{0}. {1}", i, s[i]);
                Menu_request();
                break;
            case 1:
                string[] z = { "Список типов программных продуктов", "Назад" };                               //animal
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

    public void Menu_request()
    {
            input2 = Convert.ToInt32(Console.ReadLine());
            switch (input2)
            {
                case 0:
                    requestTab zTab = new requestTab();
                    zTab.request();
                    Console.WriteLine("Для выхода в меню нажмите любую клавишу");
                    Console.ReadKey();
                    Menu();
                    break;
                case 1:
                    requestOperations.request_info2();
                    Menu();
                    break;
                case 2:
                    requestOperations.request_info1();
                    Menu();
                    break;
                case 5:
                    Menu();
                    break;
                case 3:
                    requestOperations.deleting();
                    Menu();
                    break;
                case 4:
                    requestOperations.re();
                    Menu();
                    break;
                default:
                    Console.WriteLine("Ошибка ввода");
                    break;
            }

    }         //ввод второго уровня с клавиатуры

    public void Menu_animal()
    {
        input3 = Convert.ToInt32(Console.ReadLine());                                  //ввод второго уровня с клавиатуры
        switch (input3)
        {
            case 0:
                Animal am = new Animal();
                am.Anml();
                Menu();
                break;
            case 1:
                Menu();
                break;
            default:
                Console.WriteLine("Ошибка ввода");
                break;
        }
    }*/
}
