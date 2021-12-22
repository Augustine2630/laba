public class MenuSetup
{

    public static void Main(string[] args)
    {

        Tabs T = new Tabs();
        Requests rq = new Requests();
        Menu();
        void Menu()
        {
            Console.Clear();
            MenuSetup MS = new MenuSetup();
            Console.WriteLine(" 1. Продукты\n 2. Типы программных продуктов\n 3. Выход");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Menu2();
                    break;
                case 2:
                    T.tabs2();
                    Menu();
                    break;
                case 3:
                    break;
                default:
                    Menu();
                    break;
            }
        }

        void Menu2()
        {

            Console.Clear();
            Console.WriteLine(" 1. Готовые продукты\n 2. Зарегистрировать продукт\n 3. Заявки на регистрацию\n 4. Удалить заявку\n 5. Изменить заявку\n 6. Запись заявок в текстовый файл\n 7. Прочитать из файла\n 8. Назад");

            int input2 = Convert.ToInt32(Console.ReadLine());

            switch (input2)
            {
                case 1:
                    T.tabs1();
                    Menu();
                    break;
                case 2:
                    rq.addToDict();
                    Menu();
                    break;
                case 3:
                    rq.claim();
                    Menu();
                    break;
                case 4:
                    rq.deleting();
                    Menu();
                    break;
                case 5:
                    rq.re();
                    Menu();
                    break;
                case 8:
                    Menu();
                    break;
                case 6:
                    rq.addToTXT();
                    Menu();
                    break;
                case 7:
                    rq.readFromTXT();
                    Menu();
                    break;
                default:
                    break;
            }

        }

    }

}


public class Requests
{
    int data;
    int EmptyCount = 0;

    
    
    public Dictionary<int, string> request = new Dictionary<int, string>();
    
    
    string path = @"D:\\c#\\req.txt";

    public string Value;

    public void addToDict()
    {


        Console.Clear();
        Console.WriteLine("Введите дату заявки: ");
        try
        {
            data = Convert.ToInt32(Console.ReadLine());
            if(data > 32)
            {
                Console.WriteLine("Неверная дата");
                Console.ReadLine();
                return;
                

               
            } 
        }
        catch
        {
            Console.WriteLine("неверный формать даты. Попробуйте снова: ");
            data = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Введите название продукта: ");
        string info = Convert.ToString(Console.ReadLine());

        try { request.Add(data, info); } catch { }
        //request.Add(data, info);

        foreach (KeyValuePair<int, string> keyValue in request)
        {

        }
        Console.ReadLine();

    }

    public void claim()
    {
        if (EmptyCount.Equals(data))
        {
            Console.Clear();
            Console.WriteLine("Список продуктов пуст.");
            Console.ReadLine();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("список заявок: ");


            foreach (KeyValuePair<int, string> keyValue in request)
            {
                Console.WriteLine("Дата регистрации: " + keyValue.Key + " Название продукта: " + keyValue.Value);
            }

            Console.ReadLine();

        }
    }

    public void deleting()
    {
        if (EmptyCount.Equals(data))
        {
            Console.Clear();
            Console.WriteLine("Список продуктов пуст.");
            Console.ReadLine();
        }
        else
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
        }
    }

    public void re()
    {
        if (EmptyCount.Equals(data))
        {
            Console.Clear();
            Console.WriteLine("Список продуктов пуст.");
            Console.ReadLine();
        }
        else
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

            try { request.Add(data, info); } catch { }



            Console.WriteLine("Новый список заявок: ");
            foreach (KeyValuePair<int, string> keyValue in request)
            {
                Console.WriteLine("Дата регистрации: " + keyValue.Key + " Название продукта: " + keyValue.Value);
            }
        }
    }
    public void addToTXT()
    {
        int i = 1;
        if (EmptyCount.Equals(data))
        {
            Console.WriteLine("Список заявок пуст");
            Console.ReadLine();
            return;
        } else { 
            
            Console.WriteLine("Заявки записаны"); 
            StreamWriter sw = new StreamWriter(path);
            int[] keys = new int[request.Count];
            request.Keys.CopyTo(keys, 0);
            
            string[] valuesDict = new string[request.Count];
            request.Values.CopyTo(valuesDict, 0);
            foreach (KeyValuePair<int, string> keyValue in request)
            {
                
                /*for (int i = 1; i.Equals(request.Count); i++)
                {
                    sw.Write(i + ". ");
                }*/
                sw.WriteLine((i++) + ". " +" Дата: " + keyValue.Key + " Название: " + keyValue.Value);
            }
            //keys.ToList().ForEach(i => sw.WriteLine(i));
            //valuesDict.ToList().ForEach(i => sw.WriteLine(i));

            
            sw.Close();
           
            Console.ReadLine();
        }
       
        
    }

    public void readFromTXT()
    {
        Console.Clear();
        Console.WriteLine("Заявки в .txt");
        using (StreamReader sr = new StreamReader(path))
        {
            string line;
            
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
        Console.ReadLine(); 
    }
}
public class Tabs
{
    public void tabs1()
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
    public void tabs2()
    {
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

