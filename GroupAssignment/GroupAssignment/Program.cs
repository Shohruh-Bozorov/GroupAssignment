using System;
/*
 
 Niklas, Fredrik, Shohruh

Objective
You are going to code a simple wine cellar where you keep track of your favorite wines.
You want to be able to add wines to the cellar, keep track of the number of wines and print
out the content of cellar.

When you add wines to your cellar, a confirmation should be written to the console.
If you try to add more wine bottles than your cellar can handle an error message should
instead be written.

Mandatory:
- Work in your assigned group
- Clone the repository https://github.com/smarlen/GroupAssignments.git

- Complete the code in the methods StringToPrint, InsertWine, PrintWines, NrOfBottles in repository

 */
namespace GroupAssignment1
{
    public enum GrapeVariants
    {
        CabernetSauvignon, PinotNoir, Corvina, Shiraz, Merlot, Chablis,
        Riesling, Tempranillo
    }
    public enum GrapeRegions
    {
        Bordeaux, Burgundy, Veneto, Piedmonte, RiberaDelDuero,
        NapaValley, Puglia, Pfalz
    }
    public struct Wine
    {
        public int? Year;                   // null = undefined
        public string Name;
        public GrapeVariants Grape;
        public GrapeRegions Region;

        /// <summary>
        /// Creates a string representing the content of the Wine struct
        /// </summary>
        /// <returns>string that can be printed out using Console.WriteLine</returns>
        public string StringToPrint()
        {
            //Your code
            //tror att denna delen är klar

            string contentOfWine = $"Wine: {Name} Year: {Year} GrapeVariant: {Grape} GrapeRegion: {Region}";
            return contentOfWine;


        }

        public void Print() 
        {
            StringToPrint();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            const int maxNrBottles = 4;
            Wine[] myCellar = new Wine[maxNrBottles];

            Console.WriteLine($"My cellar can have maximum {maxNrBottles} bottles");

            Wine wine1 = new Wine { Year = 2000, Name = "Château Lafite Rothschild", Grape = GrapeVariants.CabernetSauvignon, Region = GrapeRegions.Bordeaux };
            bool bOK = InsertWine(myCellar, wine1);

            Wine wine2 = new Wine { Year = 2010, Name = "Domaine de la Romanée-Conti", Grape = GrapeVariants.PinotNoir, Region = GrapeRegions.Burgundy };
            bOK = InsertWine(myCellar, wine2);

            Wine wine3 = new Wine { Year = 2005, Name = "Giuseppe Quintarelli Amarone", Grape = GrapeVariants.Corvina, Region = GrapeRegions.Veneto };
            bOK = InsertWine(myCellar, wine3);

            Wine wine4 = new Wine { Year = 2008, Name = "Sierra Cantabria", Grape = GrapeVariants.Tempranillo, Region = GrapeRegions.RiberaDelDuero };
            bOK = InsertWine(myCellar, wine3);

            Wine wine5 = new Wine { Year = 1992, Name = "Screaming Eagle", Grape = GrapeVariants.CabernetSauvignon, Region = GrapeRegions.RiberaDelDuero };
            bOK = InsertWine(myCellar, wine3);

            PrintWines(myCellar);
        }

        /// <summary>
        /// Inserts a wine into myCellar at first available position
        /// </summary>
        /// <param name="myCellar"></param>
        /// <param name="wine"></param>
        /// <returns>true - if insertion was possible, otherwise false</returns>
        private static bool InsertWine(Wine[] myCellar, Wine wine)
        {   //Your code
           


        }

        /// <summary>
        /// Print out all the wines in myCellar
        /// </summary>
        /// <param name="myCellar"></param>
        private static void PrintWines(Wine[] myCellar)
        {
            //Your code
            for (int bottle = 0; bottle < myCellar.Length; bottle++)
            {
                myCellar[bottle].Print();
            }
        }

        /// <summary>
        /// Counts the number of bottles in myCellar. That is all items
        /// where Year is not null 
        /// </summary>
        /// <param name="myCellar"></param>
        /// <returns>Number of bottles in myCellar</returns>
        private static int NrOfBottles(Wine[] myCellar)
        {
            //Your code
            
            int numberOfBottles = 0;         

            for (int bottle = 0; bottle< myCellar.Length; bottle++)
            {
                if (myCellar[bottle].Year != null)
                    numberOfBottles += bottle;               

            }
            return numberOfBottles;
        }
    }
}



/*
 
             bool result = default; 
            
            for (int i = 0; i < myCellar.Length; i++)
            {
                int k = 1;
                if (myCellar[i] )
                {
                    myCellar[i] = wine+k;
                    result = true;
                } else result = false;

                k++;
                
                

            }
                

            return result;

 */
