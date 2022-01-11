namespace ReverseString
{
    class Program
    {
        public static void Main(String [] args)
        {
            Console.WriteLine("Enter string to be reversed:");
            string input = Console.ReadLine();

            string reversedString = "";

            for(int i = 0 ; i<input.Length ; i++)
            {
                string charAti = Char.ToString(input[i]);
                reversedString = charAti + reversedString;
            }

             Console.WriteLine(reversedString);

             char[] inputarray = input.ToCharArray();

             for(int i=0,j=input.Length-1 ; i<j ;i++,j--)
             {
                 char temp = inputarray[i];
                 inputarray[i] = inputarray[j];
                 inputarray[j] = temp;
             }    
             
             reversedString = new String(inputarray);
             Console.WriteLine(reversedString);    
        }    

    }
}