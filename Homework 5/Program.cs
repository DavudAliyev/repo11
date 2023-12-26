using System;
using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Globalization;
using System.Threading;

namespace Homework_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //Verilmiş yazıdan içində boşluqlar olmayan yeni bir yazı düzəltmək 
            //Console.WriteLine("Yazini daxil edin: ");
            //string text = Console.ReadLine();
            //string newtext = "";

            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] != ' ')
            //        newtext += text[i];
            //}

            //Console.WriteLine(newtext);


            #endregion

            #region task2
            //Verilmiş ədədlər siyahısındaki verilmiş n ədədinin yerləşdiyi indexi tapan proqram
            //Console.WriteLine("Ededlerin sayini daxil edin: ");
            //string numStr=Console.ReadLine();
            //int num=Convert.ToInt32(numStr);
            //string[] strArr = new string[num];

            //for (int i = 0;i < strArr.Length;i++)
            //{
            //    Console.WriteLine($"{i+1}-ci ededi daxil edin");
            //    strArr[i] = Console.ReadLine();
            //}

            //Console.WriteLine("Axtarilan ededi daxil edin: ");
            //string num1Str=Console.ReadLine();
            //char num1=Convert.ToChar(num1Str);

            //int wantedindex = -1;

            //for (int i = 0; i < numStr.Length;i++)
            //{
            //    if (numStr[i] == num1)
            //    {
            //        wantedindex = i;
            //        break;
            //    }
            //}
            //Console.WriteLine(wantedindex);



            #endregion

            #region task3
            //Verilmiş yazılar siyahısında verilmiş hərfdən neçə ədəd olduğunu tapan proqram
            //Console.WriteLine("Yazilarin sayini daxil edin: ");
            //string numStr=Console.ReadLine();
            //int num=Convert.ToInt32(numStr);
            //string[] strArr= new string[num];

            //for(int i=0; i<strArr.Length; i++)
            //{
            //    Console.WriteLine($"{i+1}-ci yazini daxil edin: ");
            //    strArr[i] = Console.ReadLine();
            //}

            //Console.WriteLine("Axtarilan herfi daxil edin: ");
            //string letterStr=Console.ReadLine();
            //char letter=Convert.ToChar(letterStr);

            //int count = 0;

            //for(int i=0;i<strArr.Length;i++)
            //{
            //    string str = strArr[i];
            //    for(int j=0 ;j<str.Length;j++)
            //    {
            //        if (str[j] == letter)
            //        {
            //            count++;                       
            //        }
            //    }
            //}

            //Console.WriteLine(count);

            #endregion

            #region task4
            //Verilmiş yazının əvvəlindəki boşluqlar silinmiş bir string düzəldən proqram
            //Console.WriteLine("Yazini daxil edin: ");
            //string text= Console.ReadLine();

            //string newStr = "";

            //int index = 0;

            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] != ' ')
            //    {
            //        index = i;
            //        break;
            //    }
            //}

            //for (int i = index;i < text.Length;i++)
            //{
            //    newStr += text[i];
            //}

            //Console.WriteLine(newStr);

            #endregion

            #region task5
            //Verilmiş 2 ədəd üzərində verilmiş simvola uyğun əməliyyat edən proqram.
            //Simvol +,-,* və ya / olmalıdır, əks halda simvolu yenidən daxil edilməsi istənilməlidir.

            //Console.WriteLine("num1 ededini daxil edin: ");
            //string num1Str = Console.ReadLine();
            //int num1 = Convert.ToInt32(num1Str);

            //Console.WriteLine("num2 ededini daxil edin: ");
            //string num2Str = Console.ReadLine();
            //int num2 = Convert.ToInt32(num2Str);


            //bool check = true;
            //int result = 0;
            //do
            //{
            //    Console.WriteLine("Operatoru daxil edin: ");
            //    string mathopStr = Console.ReadLine();
            //    char mathop = Convert.ToChar(mathopStr);
            //    check = true;

            //    switch (mathop)
            //    {
            //        case '+':
            //            result = num1 + num2;
            //            break;
            //        case '-':
            //            result = num1 - num2;
            //            break;
            //        case '*':
            //            result = num1 * num2;
            //            break;
            //        case '/':
            //            if (num2 == 0)
            //            {
            //                Console.WriteLine("bolen 0 ola bilmez!");
            //                break;
            //            }
            //            result = num1 / num2;
            //            break;
            //        default:
            //            Console.WriteLine("Simvol yanlisdir!");
            //            check = false;
            //            break;
            //    }
            //} while (false);

            //Console.WriteLine(result);


            #endregion

            #region task6
            //Verilmiş 3 ədəddən hansının ən böyük olduğunu tapan proqram
            //Console.WriteLine("1-ci ededi daxil edin: ");
            //string num1Str=Console.ReadLine();
            //int num1=Convert.ToInt32(num1Str);

            //Console.WriteLine("2-ci ededi daxil edin: ");
            //string num2Str=Console.ReadLine();
            //int num2=Convert.ToInt32(num2Str);

            //Console.WriteLine("3-cu ededi daxil edin: ");
            //string num3Str=Console.ReadLine();
            //int num3=Convert.ToInt32(num3Str);

            //int biggest;

            //if (num1 > num2)
            //{
            //    if (num1 > num3)
            //        biggest = num1;
            //    else biggest = num3;
            //}
            //else if (num2 > num3)
            //{
            //    biggest = num2;
            //}
            //else biggest = num3;

            //Console.WriteLine($"En boyuk eded-{biggest}");

            #endregion

            #region task7
            //Verilmiş yazının içində A hərfinin olub olmadığını tapan proqram
            //Console.WriteLine("Yazini daxil edin: ");
            //string text=Console.ReadLine();

            //char letterStr= 'A';
            //char letter=Convert.ToChar(letterStr);

            //bool check = false;

            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == letterStr)
            //    {
            //        check = true;
            //        break;
            //    }
            //}

            //if (check==true) Console.WriteLine("A herfi var");
            //else Console.WriteLine("A herfi yoxdur ");

            #endregion

            #region task8
            //Verilmiş yazıda neçə A hərfinin olduğunu tapan proqram
            //Console.WriteLine("Yazini daxil edin: ");
            //string text=Console.ReadLine();

            //char latterStr = 'A';
            //char letter=Convert.ToChar(latterStr);

            //int count = 0;

            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == letter)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine($"Yazida {count} A herfi var");

            #endregion

            #region task9
            //Verilmiş müsbət cüt ədədi kradtarına yüksəldən proqram.
            //Daxil edilən ədə musbət və cüt olmadıqca yenidən daxil edilməlidir

            //int num;
            //do
            //{
            //    Console.WriteLine("Ededi daxil edin: ");
            //    string numStr = Console.ReadLine();
            //    num = Convert.ToInt32(numStr);
            //}
            //while (num <= 0 || num % 2 != 0);

            //int result = num * num;
            //Console.WriteLine(result);

            #endregion

            #region task10
            //Verilmiş 5 uzunluqlu ədədlər siyahısındaki ədədlərin cəmini tapan proqram

            //int[] count = new int[5];

            //for (int i = 0; i < count.Length; i++)
            //{
            //    Console.WriteLine($"{i+1}-ci ededi daxil edin");
            //    string numStr=Console.ReadLine();
            //    int num=Convert.ToInt32(numStr);
            //    count[i] = num;
            //}

            //int sum = 0;

            //for (int i = 0;i < count.Length;i++)
            //{
            //    sum += count[i];
            //}

            //Console.WriteLine(sum);

            #endregion

            #region task11
            //Verilmiş təhsil növü dəyərinə əsasən o təhsilin saatını göstərən proqram.
            //Əgər verilmiş dəyər "programming"dirsə console-da 400 saat, "design"dırsa 250 saat,
            //"system"dirsə 200 saat, heç biri deyilsə "təhsil novu yanlisdir" yazılmalıdır console-da.
            //bool checkInput;
            //do
            //{
            //    Console.WriteLine("Tehsil novunu qeyd edin: ");
            //    string type = Console.ReadLine();
            //    checkInput = true;

            //    switch(type)
            //    {
            //        case "programming":
            //            Console.WriteLine("400 saat");
            //            break;
            //        case "design":
            //            Console.WriteLine("250 saat");
            //            break;
            //        case "system":
            //            Console.WriteLine("200 saat");
            //            break;
            //        default:
            //            Console.WriteLine("Tehsil novu yanlisdir");
            //            break;

            //    }
            //}while (!checkInput);



            #endregion


        }
    }
}
