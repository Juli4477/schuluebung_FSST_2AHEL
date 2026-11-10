namespace Schulübung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Point =66;
            string Grade = "";
           
            if (Point >= 85)
            {
                Grade = "Excellent";
            }
            else if (Point >= 75)
            {
                Grade = "Good";
            }
            else if (Point >= 65)
            {
                Grade = "OK";
            }
            else if (Point >= 50)
            {
                Grade = "Pass";
            }
            else
            { Grade = "Fail";
            }
        }
}
