namespace delegates
{
    public delegate double delegate1(int x, float y, double z);
    public delegate void delegate2(int x, float y, double z);
    public delegate bool delegate3(string str);
    class demo
    {
        public static double addnum1(int x, float y, double z)
        {
            return x + y + z;
        }
        public static void addnum2(int x, float y, double z)
        {
            Console.WriteLine(x + y + z);
        }

        public static bool checklength(string str)
        {
            if (str.Length > 5)
                return true;
            return false;
        }
        static void Main()
        {
            delegate1 obj1 = addnum1;
            double result = obj1.Invoke(100, 22.2f, 11.11);
            Console.WriteLine("result");

            delegate2 obj2 = addnum2;
            obj2.Invoke(100, 34.5f, 193.465);

            delegate3 obj3 = checklength;
            bool status = obj3.Invoke("hel");
            Console.WriteLine(status);

            Console.ReadLine();


        }

    }
}
    
