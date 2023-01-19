namespace CSharp_I_should_know.EP2MakeCSharpVariables
{
    public class Variables
    {
        int myNum = 5;
        double myDoubleNum = 5.99D;
        char myLetter = 'D';
        bool myBool = true;
        string myText = "Hello";

        void TypeCasting()
        {
            int myInt = 9;
            double myDouble = myInt;

            double myNewDouble = 9.78;
            int myNewInt = (int)myNewDouble;
            Console.WriteLine(myNum);
            Console.WriteLine(myDouble);
            Console.WriteLine(myNewDouble);
            Console.WriteLine(myNewInt);
        }

        void TypeConversion()
        {
            Console.WriteLine(Convert.ToString(myNum));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myNum));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDoubleNum));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
        }

        public void GoToEP2()
        {
            TypeCasting();
            TypeConversion();
        }
    }
}
