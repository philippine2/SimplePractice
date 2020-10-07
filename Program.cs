using System;
using System.Collections;

namespace HomeworkPhilippine
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList listA = new ArrayList { 1, 2, 5, 20, 13 };
            ArrayList listB = new ArrayList { 1, 4, 5, 6, 14, 15 };

            ArrayList f;
            /*foreach(object d in f)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine();
            
            Console.ReadLine();
            */


            //test1 :
            try
            {
                ArrayList NewArraylist;

                listA = null;
                NewArraylist = Union(listA, listB);

                foreach (int value in NewArraylist)
                {
                    Console.WriteLine(value);
                }
                Console.WriteLine();
                Console.ReadLine();
            }
            catch (Exception e)
            {

                Console.WriteLine($"Test failed : {e.Message}");
                Console.ReadLine();
            }
            // Test 2 : Changing the elements of ArrayList A by puting strings instead of int

            try

            {

                listB = new ArrayList() { 'a', 'b' };
                f = Union(listA, listB);

                foreach (object value in f)
                {
                    Console.WriteLine(value);
                }
                Console.WriteLine();
                Console.ReadLine();

            }
            catch (Exception e)
            {

                Console.WriteLine($"Test failed : {e.Message}");
                Console.ReadLine();
            }

            //test3 :

            try

            {

                listA = new ArrayList() { 'a', 'b' };
                f = Union(listA, listB);

                foreach (int value in f)
                {
                    Console.WriteLine(value);
                }
                //Console.WriteLine();
                Console.WriteLine();
                Console.ReadLine();

            }
            catch (Exception e)
            {

                Console.WriteLine($"Test failed : {e.Message}");
                Console.ReadLine();
            }


        }
        public static ArrayList Union(ArrayList a, ArrayList b)
        {


            ArrayList ListC = new ArrayList();
            ListC.AddRange(a);

            foreach (var item in b)
            {

                if (!ListC.Contains(item))
                {
                    ListC.Add(item);
                }

            }
            return ListC;
        }




    }

}

