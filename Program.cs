using System;

namespace Prg_12Mar21
{
    class Program
    {
        static void Main(string[] args)
        {
            //может это не нужно, но у меня на анг. винде без этого не работают русские буквы
            //вывод русских символов
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //вывод русских символов
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            var enc1251 = System.Text.Encoding.GetEncoding(1251);
            System.Console.InputEncoding = enc1251;



            // я мог бы это всё сделать используя 2 переменный, но на всякий случай сделал больше
            string name;
            int age;
            int sex; //это пол
            int nrav;
            int ck_uvlecheniya;


            Console.WriteLine("ку))0)))!\n");
            //имя
            Console.WriteLine("Как тебя зовут?");
            Console.Write("Имя:"); 
            name = Console.ReadLine();
            Console.WriteLine($"Приятно познакомиться, {name}");

            //возраст
            Console.WriteLine("\nСколько тебе лет?");
            Console.Write("Возраст:"); Console.ReadLine();
            Console.WriteLine("Фига здоровый, как кабан!");

            //пол
            Console.WriteLine("\nТы мальчик или девочка? (введите число)");
            Console.Write("{1. мальчик\\2. девочка}:");sex = Convert.ToInt32(Console.ReadLine());

            //цвета
            if (sex == 1)
            {
                Console.WriteLine("\nТебе нравится синий цвет?");
                Console.Write("{1. да\\2. нет}:"); Console.ReadLine(); // тут делаем вид, что нам не всё равно что выберет пользователь
            }
            else if (sex == 2)
            {
                Console.WriteLine("\nТебе нравится розовый цвет?");
                Console.Write("{1. да\\2. нет}:"); Console.ReadLine(); // тут делаем вид, что нам не всё равно что выберет пользователь
            }
            else //это на тот случай, если найдётся дофига шутник и выберет несуществующий пол
            {
                Console.WriteLine("\nТебе нравится зелёный цвет?"); 
                Console.Write("{1. да\\2. нет}:"); Console.ReadLine(); // тут делаем вид, что нам не всё равно что выберет пользователь
            }

            //увлечения
            //1
            Console.WriteLine("\nТебе нравится играть в футбол?");
            Console.Write("{1. да\\2. нет}:"); ck_uvlecheniya = (Convert.ToInt32(Console.ReadLine()));
            if (ck_uvlecheniya == 1) Console.WriteLine("Отлично!");
            //2
            Console.WriteLine("\nТебе нравится программировать?");
            Console.Write("{1. да\\2. нет}:"); ck_uvlecheniya = (Convert.ToInt32(Console.ReadLine()));
            if (ck_uvlecheniya == 1) Console.WriteLine("Классно!");
            //3
            Console.WriteLine("\nТебе нравится играть читать?");
            Console.Write("{1. да\\2. нет}:"); ck_uvlecheniya = (Convert.ToInt32(Console.ReadLine()));
            if (ck_uvlecheniya == 1) Console.WriteLine("Невероятно!");
            //4
            Console.WriteLine("\nТебе нравится петь?");
            Console.Write("{1. да\\2. нет}:"); ck_uvlecheniya = (Convert.ToInt32(Console.ReadLine()));
            if (ck_uvlecheniya == 1) Console.WriteLine("Чудесно!");
            //5
            Console.WriteLine("\nТебе нравится танцевать?");
            Console.Write("{1. да\\2. нет}:"); ck_uvlecheniya = (Convert.ToInt32(Console.ReadLine()));
            if (ck_uvlecheniya == 1) Console.WriteLine("Молодец!");
            //6
            Console.WriteLine("\nТебе нравится бегать?");
            Console.Write("{1. да\\2. нет}:"); ck_uvlecheniya = (Convert.ToInt32(Console.ReadLine()));
            if (ck_uvlecheniya == 1) Console.WriteLine("Ого!");
            //7
            Console.WriteLine("\nТебе нравится пить пиво?");
            Console.Write("{1. да\\2. да}:"); ck_uvlecheniya = 1;
            if (ck_uvlecheniya == 1) Console.WriteLine("ха!");

            Console.WriteLine("\nТебе нравится твой код?");
            Console.Write("{1. да\\2. нет}:"); ck_uvlecheniya = (Convert.ToInt32(Console.ReadLine()));
            if (ck_uvlecheniya == 1) Console.WriteLine("Ты молодец!");
            else Console.WriteLine("Ты не ту цифру нажал, но я знаю, что тебе нравится. Ты молодец!");

            Console.WriteLine("\nНажмите любую клавишу для выхода.");//чтобы приложение сразу не закрывалось
            Console.ReadKey();
        }
    }
}
