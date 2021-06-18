using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDM_14
{
    class Program
    {
        public static bool Mar (ref char a, ref char b)
        {
            char[] alfav = new char[32] { 'а', 'б', 'в', 'г', 'д', 'е', 'є', 'ж', 'з', 'и', 'і', 'ї', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ь', 'ю', 'я' };

            int ia = 1, ib = 1, indx;

            for (int i = 0; i < alfav.Length; i++)
            {
                if (a == alfav[i]) ia = i;
                if (b == alfav[i]) ib = i;
            }

            indx = ib - ia;

            if (indx < 0)
            {
                Re(ref a, ref b);
                return true;
            }

            return false;
        }

        public static bool Mar2(ref char a, ref char b)
        {
            char[] alfav = new char[32] { 'а', 'б', 'в', 'г', 'д', 'е', 'є', 'ж', 'з', 'и', 'і', 'ї', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ь', 'ю', 'я' };

            int ia = 33, ib = 33, indx;

            for (int i = 0; i < alfav.Length; i++)
            {
                if (a == alfav[i]) ia = i;
                if (b == alfav[i]) ib = i;
            }

            indx = ia - ib;

            if (indx < 0)
            {
                Re(ref a, ref b);
                return true;
            }

            return false;
        }

        public static void Re (ref char a, ref char b)
        {
            char buff = a;
            a = b;
            b = buff;
        }

        public static string CTS (char[] arr)
        {
            string output = "";
            for (int i = 0; i < arr.Length; i++)
                output += arr[i];

            return output;

        }

        static void Main(string[] args)
        {
            string name = "стицун";
            string name2;
            string move = "";

            char[] nameone = name.ToCharArray();

            char[] sr = name.ToCharArray();
            Array.Sort(sr);

            while (true)
            {
                if (CTS(nameone) == CTS(sr)) break;
                for (int i = 1; i < nameone.Length; i++)
                {
                    if (CTS(nameone) == CTS(sr)) break;
                    if (Mar(ref nameone[i - 1], ref nameone[i])) move += CTS(nameone) + "\n";
                }
            } 
            name2 = CTS(nameone);

            Console.WriteLine($"{name} --> {name2}\n{move}");


            //2
            string name3;
            string move1 = "";

            char[] nameone1 = name.ToCharArray();
            Array.Reverse(sr);
           

            while (true)
            {
                if (CTS(nameone1) == CTS(sr)) break;
                for (int i = 1; i < nameone1.Length; i++)
                {
                    if (CTS(nameone1) == CTS(sr)) break;
                    if (Mar2(ref nameone1[i - 1], ref nameone1[i])) move1 += CTS(nameone1) + "\n";
                }
            }
            name3 = CTS(nameone1);

            Console.WriteLine($"{name} --> {name3}\n{move1}");

            Console.ReadKey();
        }
    }
}
