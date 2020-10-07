using System;

namespace FormulaOneConsole
{
    class Program
    {
        public const string WORKINGPATH = @"C:\data\formulaone\";
        private const string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + WORKINGPATH + @"formula-one.mdf;Integrated Security=True";
        static void Main(string[] args)
        {
            Console.WriteLine("*** FORMULA ONE - BATCH OPERATION ***");

            char scelta = ' ';
            do
            {
                Console.WriteLine("\n*** FORMULA ONE - BATCH SCRIPTS ***\n");
                Console.WriteLine("1 - Create Countries");
                Console.WriteLine("2 - Create Teams");
                Console.WriteLine("3 - Create Drivers");
                Console.WriteLine("------------------");
                Console.WriteLine("R - Reset");
                Console.WriteLine("------------------");
                Console.WriteLine("X - EXIT\n");
                scelta = Console.ReadKey(true).KeyChar;
                switch (scelta)
                {
                    case '1':
                        callExecuteSqlScript("Countries");
                        break;
                    case '2':
                        callExecuteSqlScript("Teams");
                        break;
                    case '3':
                        callExecuteSqlScript("Drivers");
                        break;
                    default:
                        if (scelta != 'X' && scelta != 'x') Console.WriteLine("\nUncorrect Choice - Try Again\n");
                        break;
                }
            } while (scelta != 'X' && scelta != 'x');

            static bool callExecuteSqlScript(string scriptName)
            {
                SqlConnection sql = new SqlConnection();
                try
                {
                    
                    Console.WriteLine("\nCreate " + scriptName + " - SUCCESS\n");
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nCreate " + scriptName + " - ERROR: " + ex.Message + "\n");
                    return false;
                }
            }
        }
    }
}
