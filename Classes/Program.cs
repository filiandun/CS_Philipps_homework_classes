namespace Classes
{
    internal class Program
    {
        /*
        * Задание 1
        Напишите метод, который отображает квадрат из некоторого символа. 
        Метод принимает в качестве параметра: длину стороны квадрата, символ.
        */
        static void Function1()
        {
            char symbol;
            int length;


            Console.Write("Введите длину стороны квадрата: ");
            length = int.Parse(Console.ReadLine());

            Console.Write("Введите символ из которого будет состоять квадрат: ");
            symbol = Convert.ToChar(Console.ReadLine());


            Console.WriteLine("\nВаш квадрат: ");
            for (int j = 0; j < length; ++j) // вывод первой строки
            {
                Console.Write(symbol + " ");
            }

            Console.WriteLine();
            for (int i = 0; i < length - 2; ++i) // вывод внутренних строк
            { 
                Console.Write(symbol);
                for (int l = 0; l < (length * 2) - 3; ++l) // тут, в условии цкила for, поиграться пришлось, чтобы квадарат +- ровным выводился
                {
                    Console.Write(" ");
                }
                Console.WriteLine(symbol);
            }

            for (int j = 0; j < length; ++j) // вывод последней строки
            {
                Console.Write(symbol + " ");
            }
        }


        /*
        * Задание 2
        Напишите метод, который проверяет является ли переданное число «палиндромом». 
        Число передаётся в качестве параметра. Если число палиндром нужно вернуть из метода true, иначе false.
        Палиндром — число, которое читается одинаково как справа налево, так и слева направо. Например:
        1221 — палиндром;
        3443 — палиндром;
        7854 — не палиндром.
         */
        static bool Function2()
        {
            string number;

            Console.Write("Введите число: ");
            number = Console.ReadLine();

            for (int i = 0; i < number.Length; ++i)
            {
                if (number[i] != number[number.Length - i - 1])
                {
                    // Console.WriteLine($"{number[i]} != {number[number.Length - i - 1]}");
                    return false;
                }
                // Console.WriteLine($"{number[i]} == {number[number.Length - i - 1]}");
            }
            return true;
        }


        /*
        * Задание 3
        Напишите метод, фильтрующий массив на основании переданных параметров. 
        Метод принимает параметры: оригинальный_массив, массив_с_данными_для_фильтрации.
        Метод возвращает оригинальный массив без элементов, которые есть в массиве для фильтрации. Например:
        1 2 6 -1 88 7 6 — оригинальный массив;
        6 88 7 — массив для фильтрации;
        1 2 -1 — результат работы метода.
         */
        static void Function3(int[] array, int[] array_filter)
        {
            int[] new_array = new int[array.Length];

            Console.Write("Исходный массив: ");
            for (int i = 0; i < array.Length; ++i)
            {
                Console.Write(array[i] + " ");
            }

            Console.Write("\nМассив с фильтрами: ");
            for (int i = 0; i < array.Length; ++i)
            {
                Console.Write(array[i] + " ");
            }

            for (int i = 0; i < array.Length; ++i)
            {
                for (int j = 0; j < array_filter.Length; ++j)
                {

                    if (array[i] == array_filter[j])
                    {
                        break;
                    }

                    if (j == array.Length - 4)
                    {
                        Array.Fill(new_array, array[i]);
                    }
                }

            }

            Console.Write("\nИзменённый массив: ");
            for (int i = 0; i < new_array.Length; ++i)
            {
                Console.Write(new_array[i] + " ");
            }
        }


        /*
        * Задание 4
        Создайте класс «Веб-сайт». Необходимо хранить в 
        полях класса: название сайта, путь к сайту, описание 
        сайта, ip адрес сайта. Реализуйте методы класса для ввода 
        данных, вывода данных, реализуйте доступ к отдельным 
        полям через методы класса. 
        */
        class WebSite
        {
            private string name;
            private string url;
            private string description;
            private string ip;

            public WebSite() : this("new website", "https://new.website.com/", "just new website", "00.00.00.00") { }
            public WebSite(string name, string url, string description, string ip)
            {
                this.name = name;
                this.url = url;
                this.description = description;
                this.ip = ip;
            }



            public void SetAll(string name, string url, string description, string ip)
            {
                    this.name = name;
                    this.url = url;
                    this.description = description;
                    this.ip = ip;
            }

            public void SetName(string name)
            {
                this.name = name;
            }

            public void SetUrl(string url)
            {
                this.url = url;
            }

            public void SetDescription(string description)
            {
                this.description = description;
            }

            public void SetIp(string ip)
            {
                this.ip = ip;
            }



            public void GetAll()
            {
                Console.WriteLine($"Имя: {this.name}");
                Console.WriteLine($"URL: {this.url}");
                Console.WriteLine($"Описание: {this.description}");
                Console.WriteLine($"IP: {this.ip}");
                Console.WriteLine();
            }

            public string GetName()
            {
                return this.name;
            }

            public string GetUrl()
            {
                return this.url;
            }

            public string GetDescription()
            {
                return this.description;
            }

            public string GetIp()
            {
                return this.ip;
            }
        }



        /*
        * Задание 5
        Создайте класс «Журнал». 
        Необходимо хранить в полях класса: название журнала, год основания, описание журнала, контактный телефон, контактный e-mail. 
        Реализуйте методы класса для ввода данных, вывода данных, реализуйте доступ к отдельным полям через методы класса.
        */

        class Journal
        {
            private string name;
            private int yearFoundation;
            private string description;
            private int telephone;
            private string email;


            public Journal() : this("new journal", 1111, "just new journal", 111000, "newjournal@email.com") { }
            public Journal(string name, int yearFoundation, string description, int telephone, string email)
            {
                this.name = name;
                this.yearFoundation = yearFoundation;
                this.description = description;
                this.telephone = telephone;
                this.email = email;
            }




            public void SetAll(string name, int yearFoundation, string description, int telephone, string email)
            {
                this.name = name;
                this.yearFoundation = yearFoundation;
                this.description = description;
                this.telephone = telephone;
                this.email = email;
            }

            public string SetName
            {
                set
                {
                    this.name = value;
                }
            }

            public int SetYearFoundation
            {
                set
                { 
                    this.yearFoundation = value;
                }
            }

            public string SetDescription
            {
                set
                {
                    this.description = value;
                }
            }

            public int SetTelephone
            {
                set
                {
                    this.telephone = value;
                }
            }

            public string SetEmail
            {
                set
                {
                    this.email = value;
                }
            }




            public void GetAll()
            {
                Console.WriteLine($"Название: {this.name}");
                Console.WriteLine($"Год основания: {this.yearFoundation}");
                Console.WriteLine($"Описание: {this.description}");
                Console.WriteLine($"Номер телефона: {this.telephone}");
                Console.WriteLine($"Электронная почта: {this.email}");
                Console.WriteLine();
            }

            public string GetName
            {
                get
                {
                    return this.name;
                }
            }

            public int GetYearFoundation
            {
                get
                {
                    return this.yearFoundation;
                }
            }

            public string GetDescription
            {
                get
                {
                    return this.description;
                }
            }

            public int GetTelephone
            {
                get
                {
                    return this.telephone;
                }
            }

            public string GetEmail
            {
                get
                {
                    return this.email;
                }
            }
        }



        /*
         * Задание 6
        Создайте класс «Магазин». 
        Необходимо хранить в полях класса: название магазина, адрес, описание профиля магазина, контактный телефон, контактный e-mail. 
        Реализуйте методы класса для ввода данных, вывода данных, реализуйте доступ к отдельным полям через методы класса.
        */
        class Shop
        {
            public string name { get; set; }
            public string address { get; set; }
            public string description { get; set; }
            public int telephone { get; set; }
            public string email { get; set; }


            public Shop() : this("new shop", "city, st. street, 00", "just new shop", 111000, "newshop@email.com") { }
            public Shop(string name, string address, string description, int telephone, string email)
            {
                this.name = name;
                this.address = address;
                this.description = description;
                this.telephone = telephone;
                this.email = email;
            }



            public void SetAll(string name, string address, string description, int telephone, string email)
            {
                this.name = name;
                this.address = address;
                this.description = description;
                this.telephone = telephone;
                this.email = email;
            }

            public void GetAll()
            {
                Console.WriteLine($"Название: {this.name}");
                Console.WriteLine($"Адрес: {this.address}");
                Console.WriteLine($"Описание: {this.description}");
                Console.WriteLine($"Номер телефона: {this.telephone}");
                Console.WriteLine($"Электронная почта: {this.email}");
                Console.WriteLine();
            }
        }




        static void Main()
        {
        // ЗАДАНИЕ 1
            //Function1();


        // ЗАДАНИЕ 2
            //if (Function2() == true) { Console.WriteLine("Введённое число является палиндромом"); } else { Console.WriteLine("Введённое число не является палиндромом"); };


        // ЗАДАНИЕ 3
            //int[] array = { 1, 2, 3, 4, 5 }; int[] array_filter = { 2, 4 }; Function3(array, array_filter);


        // ЗАДАНИЕ 4                              
            Console.WriteLine("\n///////////////////////////////////"); Console.WriteLine("//            ЗАДАНИЕ 4          //"); Console.WriteLine("///////////////////////////////////\n");

            //
            Console.WriteLine($"ДЕФОЛТНЫЙ КОНСТРУКТОР: ");

            WebSite website = new WebSite();
            website.GetAll();

            //
            Console.WriteLine($"МЕТОД SETALL: ");

            website.SetAll("SetAll", "https://setall/", "testing SetAll", "01.01.01.01");
            website.GetAll();

            //
            Console.WriteLine($"ОТДЕЛЬНЫЕ МЕТОДЫ SET: ");

            website.SetName("SetName");
            website.SetUrl("SetURL");
            website.SetDescription("SetDescription");
            website.SetIp("02.02.02.02");
            website.GetAll();

            //
            Console.WriteLine("ОТДЕЛЬНЫЕ МЕТОДЫ GET: ");

            website.SetAll("Get", "https://get/", "testing Get", "03.03.03.03");

            Console.WriteLine($"Имя: {website.GetName()}");
            Console.WriteLine($"URL: {website.GetUrl()}");
            Console.WriteLine($"Описание: {website.GetDescription()}");
            Console.WriteLine($"IP: {website.GetIp()}");
            Console.WriteLine();


        // ЗАДАНИЕ 5
            Console.WriteLine("\n///////////////////////////////////"); Console.WriteLine("//            ЗАДАНИЕ 5          //"); Console.WriteLine("///////////////////////////////////\n");

            //
            Console.WriteLine("ДЕФОЛТНЫЙ КОНСТРУКТОР: ");

            Journal journal = new Journal();
            journal.GetAll();

            //
            Console.WriteLine($"МЕТОД SETALL: ");

            journal.SetAll("SetAll", 2222, "testing SetAll", 222000, "setall@set.all");
            journal.GetAll();

            //
            Console.WriteLine($"ОТДЕЛЬНЫЕ МЕТОДЫ SET: ");

            journal.SetName = "SetName";
            journal.SetYearFoundation = 3333;
            journal.SetDescription = "SetDescription";
            journal.SetTelephone = 333000;
            journal.SetEmail = "setemail@set.email";
            journal.GetAll();

            //
            Console.WriteLine("ОТДЕЛЬНЫЕ МЕТОДЫ GET: ");

            journal.SetAll("Get", 4444, "testing Get", 444000, "get@get.get");

            Console.WriteLine($"Название: {journal.GetName}");
            Console.WriteLine($"Год основания: {journal.GetYearFoundation}");
            Console.WriteLine($"Описание: {journal.GetDescription}");
            Console.WriteLine($"Номер телефона: {journal.GetTelephone}");
            Console.WriteLine($"Электронная почта: {journal.GetEmail}");
            Console.WriteLine();


        // ЗАДАНИЕ 6
            Console.WriteLine("\n///////////////////////////////////"); Console.WriteLine("//            ЗАДАНИЕ 6          //"); Console.WriteLine("///////////////////////////////////\n");

            //
            Console.WriteLine($"ДЕФОЛТНЫЙ КОНСТРУКТОР: ");

            Shop shop = new Shop();
            shop.GetAll();

            //
            Console.WriteLine($"МЕТОД SETALL: ");

            shop.SetAll("SetAll", "SetAll, st. SetAll, 02", "testing SetAll", 222000, "setall@set.all");
            shop.GetAll();

            //
            Console.WriteLine($"ОТДЕЛЬНЫЕ МЕТОДЫ SET: ");

            shop.name = "SetName";
            shop.address = "SetAdress, st. SetAdress, 03";
            shop.description = "SetDescription";
            shop.telephone = 333000;
            shop.email = "setemail@set.email";
            shop.GetAll();

            //
            Console.WriteLine("ОТДЕЛЬНЫЕ МЕТОДЫ GET: ");

            shop.SetAll("Get", "Get, st. Get, 04", "testing Get", 444000, "get@get.get");

            Console.WriteLine($"Название: {shop.name}");
            Console.WriteLine($"Адрес: {shop.address}");
            Console.WriteLine($"Описание: {shop.description}");
            Console.WriteLine($"Номер телефона: {shop.telephone}");
            Console.WriteLine($"Электронная почта: {shop.email}");
            Console.WriteLine();
        }
    }
}