namespace Latih9_ProsedurFungsi
{
     class Program
    {
        static void TampilkanWaktu()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine("Sekarang  :"+date );

        }
           static void main()
           {
               TampilkanWaktu();
           }
       

        static int Kali(int a, int b)
        {
            return a * b;
        }

        static void Main()
        {
            int hasil = Kali(5, 4);
            Console.WriteLine("Hasil Perkalian : " + hasil);
        }

        static bool ApakahGenap(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

    }
    }

