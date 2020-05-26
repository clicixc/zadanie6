using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;
using System.Collections;

namespace ConsoleApp7
{
    
    class student
    {
        
        public ArrayList a = new ArrayList();

        public void add(int[] id,int x)
        {
            WriteLine("Введите id студента");
            a.Add(ReadLine());
            int c = 0;
            for (int i = 0; i < x; i++)
            {
                if (ToInt32(a[0])==ToInt32(id[i]))
                {
                    c++;
                }
                
            }
            
            if (c == 0)
            {


                WriteLine("Введите ФИО студента(без пробелов)");
                a.Add(ReadLine());
                WriteLine("введите группу студента");
                a.Add(ReadLine());
                WriteLine("введите дату рождения в виде( дд.мм.гггг");
                a.Add(ReadLine());
            }
            else
            {
                WriteLine("данный id занят");
            }
        }
        public void cor(int[] id, int x)
        {
            a.Clear();
            WriteLine("Введите новое id студента");
            a.Add(ReadLine());
            int c = 0;
            for (int i = 0; i < x; i++)
            {
                if (ToInt32(a[0]) == ToInt32(id[i]))
                {
                    c++;
                }
            }
            if (c == 0)
            {


                WriteLine("Введите новое ФИО студента(без пробелов)");
                a.Add(ReadLine());
                WriteLine("введите новую группу студента");
                a.Add(ReadLine());
                WriteLine("введите новую дату рождения в виде( дд.мм.гггг");
                a.Add(ReadLine());
            }
        }
        public void del()
        {
            a.Clear();
        }
        public void all()
        {
            for (int i = 0; i < a.Count; i++)
            {
                Write(a[i]+" ");
            }
            WriteLine();
        }
        public void seach(int q)
        {
            if (q==ToInt32(a[0]))
            {
                for (int i = 0; i < a.Count; i++)
                {
                    Write(a[i]+"  ");
                }
            }
        }
        public void year(int q)
        {
            string s = a[3] + "";
            string[] s1 = s.Split('.');
            if (q==ToInt32(a[0]))
            {
                
                WriteLine(2020-ToInt32(s1[2]));
            }
        }
    }
    class Program
    {
        static public int x = 0;
        static void Main(string[] args)
        {
            int y = 0;
            int[] id = new int[20];
            bool b = true;
            student[] s = new student[20];
            for (int i = 0; i < 20; i++)
            {
                s[i] = new student();
            }
            while (b)
            {
                WriteLine("введите номер операции \n 1- добавление студента \n 2 - редактирование студента \n 3 - удаление студента \n 4 -  вывод всех студентов \n 5 - вывод всей информации по студенту по его id \n 6 - вывод возраста студента студента по его id \n 7 - закрыть програму");
                int i = ToInt32(ReadLine());
                int q;
                switch (i)
                {
                    case 1: s[x].add(id,x);id[x] =ToInt32(s[x].a[0]) ;WriteLine(id[0]); x++; break;
                    case 2:
                        WriteLine("введите номер по счёту студента которого хотите изменить");
                        if (x!=0&&x>=y)
                        {
                            y = ToInt32(ReadLine()); s[y].cor(id, x); 
                        }
                        else
                        {
                            WriteLine("список студентов пуст");
                        }
                        break;
                    case 3: WriteLine("введите номер по счёту студента которого хотите удалить");
                        if (x != 0 && x >= y)
                        {
                            y = ToInt32(ReadLine())-1; s[y].del();
                        }
                        else
                        {
                            WriteLine("список студентов пуст");
                        }
                        break;
                    case 4:
                        for (int j = 0; j < x; j++)
                        {
                            s[j].all();
                        }
                        break;
                    case 5:
                        q=ToInt32(ReadLine());
                        for (int j = 0; j < x; j++)
                        {

                            s[j].seach(q);
                        }
                        break;
                    case 6:
                        q=ToInt32(ReadLine());
                        for (int j = 0; j < x; j++)
                        {

                            s[j].year(q);
                        }
                        break;
                    case 7: b=false;break;
                }
                
            }
        }
    }
}
