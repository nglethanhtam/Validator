using System;

namespace BinaryValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a binary string");
            string input = Console.ReadLine();
            bool isValid = IsValidBinaryString(input);
            Console.WriteLine(isValid ? "Valid" : "Invalid");
        }

        private static bool IsValidBinaryString(string input)
        {
            if (input.Trim().Length == 0) return false;

            int countZero = 0, countOne = 0;
            char[] arrInput = input.ToCharArray();

            if (arrInput[0].Equals('0')) countZero++;
            else if (arrInput[0].Equals('1')) countOne++;
            else return false;

            for (int i = 1; i < arrInput.Length; i++)
            {
                if (arrInput[i].Equals('0')) countZero++;
                else if (arrInput[i].Equals('1')) countOne++;
                else return false;

                if (countOne < countZero) return false;
            }

            if (countZero != countOne) return false;

            return true;
        }
    }
}
