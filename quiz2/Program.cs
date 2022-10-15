using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.დაწერეთ პროგრამა რომელიც კლავიატურიდან შემოიტანს n-ს და მასივს შეავსებს n-ცალი რიცხვით.დაითვალეთ:
            //კენტი რიცხვების ჯამი
            //ლუწი რიცხვების ნამრავლი
            //დაითვლის მასივში თითოეული ელემენტის რაოდენობას(3)


            //Console.WriteLine("Enter the number (size of array)");

            //int _length = Convert.ToInt32(Console.ReadLine());

            //int[] arr = new int[_length];

            //Random rnd = new Random();


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i]  = rnd.Next(10);

            //}

            //int oddSum = 0;
            //int evenMultiplication = 1;



            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 != 0)
            //    {
            //        Console.WriteLine($"odd numbers is {arr[i]}");
            //        oddSum += arr[i];


            //    }

            //    else if (arr[i] % 2 == 0) {
            //        evenMultiplication *= arr[i];
            //    }

            //}
            //Console.WriteLine($"Sum of odd numbers is {oddSum} and Multiplicatin of the even numbers is  {evenMultiplication} and element in array is {_length}");






            ///2. დაწერეთ პროგრამა რომელიც სტრინგისთვის დაბეჭდავს არის თუ არა მოცემული სტრინგი
            ///პალინდრომი (პალინდრომის მეთოდი გაიტანეთ ცალკე და გამოიძახეთ სხვადასხვა სტრინგისთვის)   (2)

            //string a = string.Empty;
            //Console.WriteLine("Enter your Word/s!");
            //a = Console.ReadLine();


            //  Help.CheakPalindrome(a);





            //3. დაწერეთ პროგრამა რომელიც მასივში დაბეჭდავს ერთმანეთის მეზობლად 
            //  მდგარი ტოლი ელემენტების მაქსიმალურ რაოდენობას და ამ ელემენტს. 
            //  Მაგ 1 1 2 2 2 3 4 2 2 - უნდა დაბეჭდოს 3  და 2.  (3)


            /* int[] array1 = new int[11] { 0, 1, 1, 5, 5, 5, 2, 2, 6, 3, 3 };
             int[] array2 = new int[11] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

             int max_count = 1;
             int tempCount = 1;
             int num = 0;

             for (int i = 0; i < array1.Length - 1; i++)
             {
                 if (array1[i] == array1[i + 1]) tempCount++;
                 else tempCount = 1;

                 if (tempCount > max_count)
                 {
                     max_count = tempCount;
                     num = array1[i];
                 }
             }

             for (int i = 0; i < max_count; i++) array2[i] = num;


             Console.WriteLine($"number:  { num} there is {max_count} times ");

             */








            // 4 (ბონუსი)დაწერეთ პროგრამა რომელიც მასივში იპოვნის ყველაზე ხშირად 
            //გამეორებული ელემენტის რაოენობას და დაბეჭდავს ამ ელემენტს. (2)

            int[] array = new int[15] { 0, 1, 1, 5, 5, 5, 2, 2, 6, 3, 3,3,3,3,3, };
            var query = (from item in array
                         group item by item into g
                         orderby g.Count() descending
                         select g.Key).First();

            Console.WriteLine(query);


        }










    }
    }
