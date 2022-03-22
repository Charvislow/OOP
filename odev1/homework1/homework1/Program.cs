using System;

namespace homework1
{
    class Crypt
    {
        private int number;
        static void Main(string[] args)
        {
           int number=0;
            inputNumber(ref number);

            Crypt numb = new Crypt(number);

            encryptNumber(ref number);
            printEncryptedNumber(number);

            decryptNumber(ref number);
            printDecryptedNumber(number);
        }
        public Crypt()
        { }
        public Crypt(int _number)
        {
            number = _number;
        }
        static void inputNumber(ref int numb)
        {
                      bool condition;
                      do
                      {
                          Console.Write("Enter a four-digit number: ");
                          numb = Convert.ToInt32(Console.ReadLine());

                          if (numb > 999 && numb < 10000)
                              break;
                          else
                              Console.Write("Not a four-digit number! ");
                      } while (condition = true);
        }
        static void encryptNumber(ref int encNumber)
        {
            int first = ((encNumber / 1000) + 7) % 10;
            int second = ((encNumber / 100) + 7) % 10;
            int third = ((encNumber / 10) + 7) % 10;
            int fourth = ((encNumber + 7) % 10);
            encNumber = (third * 1000) + (fourth * 100) + (first * 10) + second;     
        }
        static void decryptNumber(ref int decNumber)
        {
            int first = ((decNumber / 1000) + 3) % 10;
            int second = ((decNumber / 100) + 3) % 10;
            int third = ((decNumber / 10) + 3) % 10;
            int fourth = ((decNumber + 3) % 10);
            decNumber = (third * 1000) + (fourth * 100) + (first * 10) + second;
        }
        static void printEncryptedNumber(int encNumber)
        {
            Console.WriteLine("Encrypted Message: " + encNumber);
        }
        static void printDecryptedNumber(int decNumber)
        {
            Console.WriteLine("Decrypted Message: " + decNumber);
        }
    }
}
