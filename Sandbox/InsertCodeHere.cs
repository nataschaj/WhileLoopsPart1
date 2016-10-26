using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            // Case 1
            Console.WriteLine("Start of Case 1"); //kører så længe c1 er under 20. 
            int c1 = 1;
            while (c1 < 20)
            {
                c1 = c1 + 2; //1+2= 3, 3+2=5, 5+2=7 osv.. indtil den når så tæt på 20 som muligt
                Console.WriteLine(c1); // Uncomment to see result
            }
            Console.WriteLine("End of Case 1");


            // Case 2
            Console.WriteLine("Start of Case 2");
            int c2 = 1;
            while (c2 < 20)
            {
                Console.WriteLine(c2);
                c2 = c2 * 2;
            }
            Console.WriteLine("End of Case 2");


            // Case 3
            Console.WriteLine("Start of Case 3"); //tilføjer 1 til 15 så længe at c3 er mindre end 20 og større en 10.
            int c3 = 15;
            while ((c3 < 20) && (c3 > 10))
            {
                Console.WriteLine(c3);
                c3++;
            }
            Console.WriteLine("End of Case 3");


            // Case 4
            Console.WriteLine("Start of Case 4"); //c4 er 10 og loop'et trækker 1 fra c4 så længe c4 er størrer eller lig med 0
            int c4 = 10;
            while (c4 >= 0)
            {
                Console.WriteLine(c4);
                c4--;
            }
            Console.WriteLine("End of Case 4");


            // Insert code for the below four cases

            // Case 5
            // Print out the numbers 3,5,7,9
            Console.WriteLine("Start of case 5");
            int c5 = 3;

            while ((c5 > 2) && (c5 < 10))
            {
                Console.WriteLine(c5);
                c5 = c5 + 2;
            }
            Console.WriteLine("End of Case 5");


            // Case 6
            // Print out the numbers 0,1,3,7,15,31
            Console.WriteLine("Start of case 6");


            Console.WriteLine("End of Case 6");


            // Case 7
            // Print out the numbers 100,50,25,12,6,3,1
            Console.WriteLine("Start of case 7");


            Console.WriteLine("End of Case 7");

            // Case 8 (DIFFICULT)
            // Print out the numbers 10,9,12,7,14,5,16,3,18,1
            Console.WriteLine("Start of case 8");


            Console.WriteLine("End of Case 8");


            // The LAST line of code should be ABOVE this line
        }
    }
}
