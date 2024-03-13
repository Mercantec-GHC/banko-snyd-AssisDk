using System.Data;
using System.Net.Http.Headers;
using System.Linq;
using System.Security.Cryptography;

namespace BankoCheater
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] assisRow1 = new int[] { 1, 31, 40, 74, 84 }; int[] assisRow2 = new int[] { 5, 18, 34, 54, 76 }; int[] assisRow3 = new int[] { 19, 22, 68, 79, 89 };
            int[] assis2Row1 = new int[] { 10, 23, 30, 44, 63 }; int[] assis2Row2 = new int[] { 6, 25, 46, 65, 73 }; int[] assis2Row3 = new int[] { 7, 27, 32, 55, 88 };
            
            int row1CountAssis = 0; int row2CountAssis = 0; int row3CountAssis = 0;

            int row1CountAssis2 = 0; int row2CountAssis2 = 0; int row3CountAssis2 = 0;

            int[][] assisRows = new int[3][];
            assisRows[0] = assisRow1;
            assisRows[1] = assisRow2;
            assisRows[2] = assisRow3;

            int[][] assis2Rows = new int[3][];
            assis2Rows[0] = assis2Row1;
            assis2Rows[1] = assis2Row2;
            assis2Rows[2] = assis2Row3;

            int[] rowCountsAssis = new int[3];
            rowCountsAssis[0] = row1CountAssis;
            rowCountsAssis[1] = row2CountAssis;
            rowCountsAssis[2] = row3CountAssis;

            int[] rowCountsAssis2 = new int[3];
            rowCountsAssis2[0] = row1CountAssis2;
            rowCountsAssis2[1] = row2CountAssis2;
            rowCountsAssis2[2] = row3CountAssis2;


            int trukketNo;
            
            List<int> numbers = new List<int>();
            //numbers.Clear();
            bool fullPlate = false; bool assisFullPlate = false; bool assis2FullPlate = false;

            
            do
            {
                Console.Write("Indtast det trukket nmmmer: ");
                string input = Console.ReadLine();
                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }

                if (!int.TryParse(input, out trukketNo) || trukketNo < 1 || trukketNo > 90 || numbers.Contains(trukketNo))
                {
                    Console.WriteLine("Det indtastet er ugyldig (eller du har allerede indtastet det før, venligst indtast kun tal mellem 1 og 90 ");
                    continue;
                }
                Console.Clear();
                numbers.Add(trukketNo); 
               
                ;
             








                foreach (var row in assisRows)
                {
                    // Tjekker om det nuværende række indholder det trukketNo
                    if (row.Contains(trukketNo))
                    {
                        // Forøger det tilhørende count baseret på rækker
                        if (row == assisRow1)
                        {
                            row1CountAssis++;
                        }
                        else if (row == assisRow2)
                        {
                            row2CountAssis++;
                        }
                        else if (row == assisRow3)
                        {
                            row3CountAssis++;
                        }
                    }
                }
                foreach (var row in assis2Rows)
                {
                    
                    if (row.Contains(trukketNo))
                    {
                        
                        if (row == assis2Row1)
                        {
                            row1CountAssis2++;
                        }
                        else if (row == assis2Row2)
                        {
                            row2CountAssis2++;
                        }
                        else if (row == assis2Row3)
                        {
                            row3CountAssis2++;
                        }
                    }
                }


                if (row1CountAssis == 5)
                    {
                        
                        Console.WriteLine("Du har Banko 5 rigtgt på din plade der hedder Assis på række 1 ");
                        Console.WriteLine(assisRow1[0] + " , " + assisRow1[1] + " , " + assisRow1[2] + " , " + assisRow1[3] + " , " + assisRow1[4]);
                    }
                    if (row2CountAssis == 5)
                    {

                        Console.WriteLine("Du har Banko 5 rigtgt på din plade der hedder Assis på række 2 ");
                        Console.WriteLine(assisRow2[0] + " , " + assisRow2[1] + " , " + assisRow2[2] + " , " + assisRow2[3] + " , " + assisRow2[4]);
                    }
                    if (row3CountAssis == 5)
                    {

                        Console.WriteLine("Du har Banko 5 rigtgt på din plade der hedder Assis på række 3 ");
                        Console.WriteLine(assisRow3[0] + " , " + assisRow3[1] + " , " + assisRow3[2] + " , " + assisRow3[3] + " , " + assisRow3[4]);
                    }

                    //Assis2 plade 2

                    if (row1CountAssis2 == 5)
                    {

                        Console.WriteLine("Du har Banko 5 rigtgt på din plade der hedder Assis2 på række 1 ");
                        Console.WriteLine(assis2Row1[0] + " , " + assis2Row1[1] + " , " + assis2Row1[2] + " , " + assis2Row1[3] + " , " + assis2Row1[4]);
                    }
                    if (row2CountAssis2 == 5)
                    {

                        Console.WriteLine("Du har Banko 5 rigtgt på din plade der hedder Assis2 på række 2 ");
                        Console.WriteLine(assis2Row2[0] + " , " + assis2Row2[1] + " , " + assisRow2[2] + " , " + assis2Row2[3] + " , " + assis2Row2[4]);
                    }
                    if (row3CountAssis == 5)
                    {

                        Console.WriteLine("Du har Banko 5 rigtgt på din plade der hedder Assis på række 3 ");
                        Console.WriteLine(assis2Row3[0] + " , " + assis2Row3[1] + " , " + assis2Row3[2] + " , " + assis2Row3[3] + " , " + assis2Row3[4]);
                    }

                   

                    if (row1CountAssis == 5 && row2CountAssis == 5 && row3CountAssis == 5 )
                    {
                        Console.WriteLine("Tillyke du har fuld plade på din plade som hedder Assis");
                        Console.WriteLine(assisRow1[0] + " ,\t " + assisRow1[1] + " ,\t " + assisRow1[2] + " ,\t " + assisRow1[3] + " ,\t " + assisRow1[4]);
                        Console.WriteLine(assisRow2[0] + " ,\t " + assisRow2[1] + " ,\t " + assisRow2[2] + " ,\t " + assisRow2[3] + " ,\t " + assisRow2[4]);
                        Console.WriteLine(assisRow3[0] + " ,\t " + assisRow3[1] + " ,\t " + assisRow3[2] + " ,\t " + assisRow3[3] + " ,\t " + assisRow3[4]);


                        assisFullPlate = true;
                    }

                    if (row1CountAssis2 == 5 && row2CountAssis2 == 5 && row3CountAssis2 == 5)
                    {
                        Console.WriteLine("Tillyke du har fuld plade på din plade som hedder Assis2");
                        Console.WriteLine(assis2Row1[0] + " ,\t " + assis2Row1[1] + " ,\t " + assis2Row1[2] + " ,\t " + assis2Row1[3] + " ,\t " + assis2Row1[4]);
                        Console.WriteLine(assis2Row2[0] + " ,\t " + assis2Row2[1] + " ,\t " + assis2Row2[2] + " ,\t " + assis2Row2[3] + " ,\t " + assis2Row2[4]);
                        Console.WriteLine(assis2Row3[0] + " ,\t " + assis2Row3[1] + " ,\t " + assis2Row3[2] + " ,\t " + assis2Row3[3] + " ,\t " + assis2Row3[4]);
                    
                      
                    {
                        assis2FullPlate = true;

                    }
                    if (assisFullPlate && assis2FullPlate) { fullPlate = true; }

                }
              


            } while (fullPlate == false);

            Console.WriteLine("Banko du har fuld hus på alle dine plader!");
        }

    }
}











