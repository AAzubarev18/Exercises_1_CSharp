namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* (1) Напишите программу, которая просит пользователя ввести числа с клавиатуры и сохраняет их в массив. 
             * Затем программа должна вывести сумму всех чисел в массиве.
            (доп.) Расширить программу, чтобы она могла работать с массивами любой длины, которую вводит пользователь.
            */
            Console.WriteLine("Введите длину массива:");
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];


            Console.WriteLine("Введите числа через пробел:");
            string[] input = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                arr1[i] = int.Parse(input[i]);
            }

            int sum1 = 0;
            for (int i = 0; i < n; i++)
            {
                sum1 += arr1[i];
            }

            Console.WriteLine("Сумма всех чисел в массиве: " + sum1);
            Console.ReadLine();


            /* (2)  Напишите программу, которая создает массив из 10 целых чисел, заполняет его случайными значениями от 1 до 100, и выводит массив на экран.
            (доп.) Расширить программу, чтобы она находила максимальное и минимальное значение в массиве и выводила их на экран.
            */
            int[] arr2 = new int[10];

            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                arr2[i] = rnd.Next(1, 101);
            }

            Console.WriteLine("Массив:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(arr2[i] + " ");
            }

            int max = arr2[0], min = arr2[0];
            for (int i = 1; i < 10; i++)
            {
                if (arr2[i] > max) max = arr2[i];
                if (arr2[i] < min) min = arr2[i];
            }

            Console.WriteLine("\nМаксимальное значение: " + max);
            Console.WriteLine("Минимальное значение: " + min);

            Console.ReadLine();

            /* (3) Напишите программу, которая запрашивает у пользователя строку и выводит на экран каждый символ строки в отдельной строке.      !!!!!!!! ARRAY MUST USED
            (доп.) Расширить программу, чтобы она могла работать с несколькими массивами, введенными пользователем, и выводила их сумму.
             */
            string inputStr;
            int inputCount, sum3 = 0;

            Console.WriteLine("Введите количество строк:");
            inputCount = int.Parse(Console.ReadLine());

            for (int j = 0; j < inputCount; j++)
            {
                Console.WriteLine("Введите {0} строку: ", j + 1);
                inputStr = Console.ReadLine();

                Console.WriteLine("Символы строки:");

                for (int i = 0; i < inputStr.Length; i++)
                {
                    Console.WriteLine(inputStr[i]);
                }

                sum3 += inputStr.Length;
            }

            Console.WriteLine("Сумма символов всех строк: " + sum3);

            Console.ReadLine();

            /* (4) Напишите программу, которая запрашивает у пользователя 5 чисел, сохраняет их в массив, и затем выводит на экран только четные числа из массива.
            (доп.) Расширить программу, чтобы она запрашивала у пользователя не только строки, но и другие типы данных, такие как числа и булевы значения, и сохраняла их в массив.
            */
            object[] inputArray = new object[5];
            int value;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите данные:");
                inputArray[i] = Console.ReadLine();
            }

            Console.WriteLine("Введенные данные:");

            for (int i = 0; i < 5; i++)
            {

                if ((int.TryParse((string?)inputArray[i], out value)))
                {
                    int amount4 = (int)Convert.ChangeType(inputArray[i], typeof(int));

                    if (amount4 % 2 == 0)
                    {
                        Console.Write(inputArray[i] + " ");
                    }
                    else if (amount4 % 2 != 0)
                    {
                        Console.Write("Нечетное число! ");
                    }

                }
                else
                    Console.Write(inputArray[i] + " ");
            }

            Console.ReadLine();


            /* (5) Напишите программу, которая запрашивает у пользователя строку и проверяет, является ли эта строка палиндромом (то есть, можно ли прочитать ее задом наперед так же, как и в прямом порядке).
            (доп.) Расширить программу, чтобы она работала с несколькими строками, введенными пользователем, и проверяла, являются ли они палиндромами.
            */
            Console.WriteLine("Введите строку (или несколько строк):");

            string input5 = Console.ReadLine();

            string[] lines = input5.Split(' ');

            foreach (string line in lines)
            {
                string trimmed5 = line.Trim();

                bool isPalindrome = IsPalindrome(trimmed5);

                Console.WriteLine("Строка \"" + trimmed5 + "\" " + (isPalindrome ? "является" : "не является") + " палиндромом.");
            }

            static bool IsPalindrome(string str)
            {
                int length = str.Length;

                for (int i = 0; i < length / 2; i++)
                {
                    if (str[i] != str[length - i - 1])
                    {
                        return false;
                    }
                }

                return true;
            }

            Console.ReadLine();


            /* (6) Напишите программу, которая находит среднее значение из трех чисел, введенных пользователем с клавиатуры. */
            Console.WriteLine("Введите три числа:");

            Console.Write("Первое число: ");
            double a6 = double.Parse(Console.ReadLine());

            Console.Write("Второе число: ");
            double b6 = double.Parse(Console.ReadLine());

            Console.Write("Третье число: ");
            double c6 = double.Parse(Console.ReadLine());

            double average6 = (a6 + b6 + c6) / 3.0;

            Console.WriteLine("Среднее значение 3-х чисел: " + Math.Round(average6, 2));

            Console.ReadLine();

            /* (7) Напишите программу, которая запрашивает у пользователя его имя и возраст, а затем 
             * выводит на экран сообщение с приветствием и информацией о том, сколько ему лет. */
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Привет, " + name + ". Твой возраст составляет " + age + " лет.");

            Console.ReadLine();

            /* (8) Напишите программу, которая запрашивает у пользователя строку и выводит на экран количество слов в этой строке. */
            Console.Write("Введите строку: ");
            string inputString = Console.ReadLine();

            string[] words = inputString.Split(' ');

            Console.WriteLine("Количество слов в строке: " + words.Length);

            Console.ReadLine();

            /* (9) Напишите программу, которая находит наибольшую общую подпоследовательность двух строк. 
             * Например, для строк "abcdef" и "acbcf" наибольшая общая подпоследовательность будет "abcf". */
            static string LongestCommonSubstring(string a, string b)
            {
                var n = a.Length;
                var m = b.Length;
                var array = new int[n, m];
                var maxValue = 0;
                var maxI = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (a[i] == b[j])
                        {
                            array[i, j] = (i == 0 || j == 0)
                                ? 1
                                : array[i - 1, j - 1] + 1;
                            if (array[i, j] > maxValue)
                            {
                                maxValue = array[i, j];
                                maxI = i;
                            }
                        }
                    }
                }

                return a.Substring(maxI + 1 - maxValue, maxValue);
            }


            Console.Write("Первое слово: ");
            var s1 = Console.ReadLine();
            Console.Write("Второе слово: ");
            var s2 = Console.ReadLine();

            Console.WriteLine("Наибольшая общая подстрока: {0}", LongestCommonSubstring(s1, s2));
            Console.ReadLine();

            /* (10) Напишите программу, которая запрашивает у пользователя число и определяет, является ли оно простым (т.е. имеет только два делителя - 1 и само число). */
            //Примеры составных чисел: 4 6 8 9 14 15
            //Примеры простых чисел: 2 3 5 7 13 17
            Console.Write("Введите целое число: ");
            int number10 = int.Parse(Console.ReadLine());

            bool isPrime = true;

            if (number10 < 2)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number10); i++)
                {
                    if (number10 % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
            {
                Console.WriteLine(number10 + " - простое число.");
            }
            else
            {
                Console.WriteLine(number10 + " - составное число.");
            }

            Console.ReadLine();

            /* (11)  Напишите программу, которая сортирует массив чисел в порядке возрастания или убывания. 
             * Массив и порядок сортировки должны вводиться пользователем с клавиатуры. */
            Console.Write("Введите число элементов массива: ");
            int length11 = int.Parse(Console.ReadLine());

            int[] numbers11 = new int[length11];

            Console.WriteLine("Введите элементы массива:");

            for (int i = 0; i < length11; i++)
            {
                numbers11[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Выберите порядок сортировки (возрастание - (1), убывание - (2) ): ");
            int order = int.Parse(Console.ReadLine());

            if (order == 1)
            {
                // Сортировка массива по возрастанию
                Array.Sort(numbers11);
            }
            else if (order == 2)
            {
                // Сортировка массива по убыванию
                Array.Sort(numbers11);
                Array.Reverse(numbers11);
            }
            else
            {
                Console.WriteLine("Неверный выбор порядка сортировки.");
                return;
            }

            Console.WriteLine("Отсортированный массив:");
            foreach (int _number11 in numbers11)
            {
                Console.Write(_number11 + " ");
            }

            Console.ReadLine();

            /* (12) Напишите программу, которая определяет, является ли год високосным (т.е. делится на 4, но не делится на 100, или делится на 400). */
            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine(year + " год - високосный");
            }
            else
            {
                Console.WriteLine(year + " год - не високосный");
            }

            Console.ReadKey();

            /* (13)  Напишите программу, которая генерирует случайное число от 1 до 100 и дает пользователю три попытки угадать это число. Если пользователь угадывает число, программа выводит сообщение с поздравлением, иначе программа сообщает правильный ответ. */
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 101);
            int maxAttempts = 3;
            int attempts = 0;
            int userInput = 0;

            Console.WriteLine("Угадайте число от 1 до 100 за " + maxAttempts + " попыток");

            while (userInput != randomNumber && attempts < maxAttempts)
            {
                // запрашиваем ввод пользователем и проверяем его
                Console.Write("Попытка " + (attempts + 1) + ": Введите число от 1 до 100: ");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out userInput))
                {
                    Console.WriteLine("Ошибка ввода. Попробуйте снова.");
                    continue;
                }
                if (userInput < 1 || userInput > 100)
                {
                    Console.WriteLine("Число должно быть от 1 до 100. Попробуйте снова.");
                    continue;
                }

                attempts++; // увеличиваем количество попыток
            }

            if (userInput == randomNumber)
            {
                Console.WriteLine("Поздравляем! Загаданное число действительно было" + randomNumber);
            }
            else
            {
                Console.WriteLine("К сожалению, вы проиграли. Загаданное число было " + randomNumber);
            }
            Console.ReadKey();

            /* (14)  Напишите программу, которая считывает файл с данными о пользователях (имя, возраст, пол и т.д.), а затем выводит на экран информацию о самом старшем и самом младшем пользователе. */
            //John, 12, M,
            //Anna, 69, F,
            //Elly, 5, F,
            List<User> userList = new List<User>();

            string filePath2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"ForParse\users.txt");

            using (StreamReader reader = new StreamReader(filePath2))
            {
                while (!reader.EndOfStream)
                {
                    string[] data = reader.ReadLine().Replace("\t", string.Empty).Split(',');

                    User user = new User()
                    {
                        Name = data[0],
                        Age = int.Parse(data[1]),
                        Gender = data[2]
                    };

                    userList.Add(user);
                    userList.OrderBy(p => p.Age);
                }

                var _max = userList.Max(x => x.Age);
                var _min = userList.Min(x => x.Age);

                var _maxAge = userList.Select(p => new { Name = p, Age = p.Age });
                foreach (var user in userList)
                    Console.WriteLine("Пользователю {0} {1} лет", user.Name, user.Age);


                Console.WriteLine("Самый старший участник {0} : {1}, а самый младший {2} : {3} ", userList.ElementAt(0).Name, _max, userList.Last().Name, _min);

                Console.ReadKey();
            }

            /* (15)  Напишите программу, которая определяет, является ли введенная пользователем строка палиндромом, игнорируя все символы, кроме букв и цифр. 
             * Например, строка "A man, a plan, a canal: Panama" является палиндромом. */

            Console.Write("Введите строку: "); 
            string input = Console.ReadLine();

            string cleanString = "";

            foreach (char c in input)
            {
                if (char.IsLetterOrDigit(c))
                {
                    cleanString += c;
                }
            }

            char[] charArray = cleanString.ToCharArray();
            Array.Reverse(charArray);
            string reverseString = new string(charArray);

            if (cleanString.Equals(reverseString, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Строка является палиндромом");
            }
            else
            {
                Console.WriteLine("Строка не является палиндромом");
            }

            Console.ReadLine();

        }

        public class User { 
            public string Name { get; set; } 
            public int Age { get; set; } 
            public string Gender { get; set; }

        }

    }
}