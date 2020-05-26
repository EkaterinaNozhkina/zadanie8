using System;
 

namespace zadanie8
{
     
        static void Main(string[] args)
    {
        Student a = new Student();

        a.fio = "Васильев Николай Сергеевич";
        a.dat = "17.10.2000";
        a.grp = 12;
        a.fio = "Николае Иван Андреевич";
        a.dat = "12.12.2001";
        a.grp = 12;
        a.fio = "Сергеев Сергей Викторович";
        a.dat = "09.11.1989";
        a.grp = 8;
        a.fio = "Кузнецов Андрей Сергеевич";
        a.dat = "02.10.2002";
        a.grp = 6;
        a.fio = "Пустовских Кирилл Алексеевич";
        a.dat = "05.12.2001";
        a.grp = 808;
        int n = 0;
        while (n != 6)
        {
            Console.WriteLine("\n__\n\n\t\tМеню\n_");
            Console.WriteLine("\t1.Показать Информацию о студентах");
            Console.WriteLine("\nДля выполнения действий нажмите следующую цифру:\n");
           
            Console.WriteLine("\t2.Добавить студента\n\t3.Удалить сдутента\n\t4.Изменить студента\n\t5.Поиск студентов\n\t6.Выход\n");

            n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0 || n >=  7) { Console.WriteLine("Нажмите нужную цифру"); }
            switch (n)
            {
                case 1:
                    {
                        int no;
                        do
                        {
                            Console.WriteLine("\n__\n\n\t\tПодменю\n");
                            Console.WriteLine("\nЧто именно вы хотите?\n\n\t1.Найти студента по id\n\t2.Найти студента по фамилии\n\t3.Переход в главное меню\n");
                            do
                            {
                                no = Convert.ToInt32(Console.ReadLine());
                                if (no < 1 || no > 3) { Console.WriteLine("Нажмите нужную цифру"); }
                            } while (no < 1 / no > 3);
                            switch (no)
                            {
                                case 1: { a.Sid(); break; }
                                case 2: { a.ser(); break; }
                            }
                        } while (no != 3);
                        break;
                    }
                    {
                        int no;
                        do
                        {
                            Console.WriteLine("\n_\n\n\t\tПодменю\n");
                            Console.WriteLine("\nЧто именно вы хотите?\n\n\t1.Вся информация о студентах\n\t2.Список студентов с инициалами\n\t" +
                                "3.Список студентов старше 18\n\t4.Список студентов младше 18\n\t5.Переход в главное меню\n");
                            do
                            {
                                no = Convert.ToInt32(Console.ReadLine());
                                if (no < 1 || no  > 5) { Console.WriteLine("Нажмите цифру"); }
                            } while (no < 1 /   no > 5);
                            switch (no)
                            {
                                case 1: { a.Info(); break; }
                                case 2: { a.Inic(); break; }
                                case 3: { a.sor('s'); break; }
                                case 4: { a.sor('a'); break; }
                            }
                        } while (no != 5);
                        break;
                    }
                case 2: { a.add(); break; }
                case 3: { a.Dell(); break; }
                case 4: { a.redakt(); break; }
                case 5:
                    {
                        int no;
                        do
                        {
                            Console.WriteLine("\n_\n\n\t\tПодменю\n");
                            Console.WriteLine("\nЧто именно вы хотите?\n\n\t1.Вся информация о студентах\n\t2.Список студентов с инициалами\n\t" +
                                "3.Список студентов старше 18\n\t4.Список студентов младше 18\n\t5.Переход в главное меню\n");
                            do
                            {
                                no = Convert.ToInt32(Console.ReadLine());
                                if (no < 1 || no > 5) { Console.WriteLine("Нажмите цифру"); }
                            } while (no < 1 / no > 5);
                            switch (no)
                            {
                                case 1: { a.Info(); break; }
                                case 2: { a.Inic(); break; }
                                case 3: { a.sor('s'); break; }
                                case 4: { a.sor('a'); break; }
                            }
                        } while (no != 5);
                        break;
                    }
            }
        }
    }
}
 