using System;

internal class NumberNineteen
    {
        static void Main(string[] args)
        {
	 SeiveOfErastothenes();
	}
	private static void SeiveOfErastothenes()
        {
            int n = 10000000;
            bool[] prime = new bool[n+1];
            for (int i = 1; i < n; i++)
            {
                prime[i] = true;
            }

            for (int p = 2; p*p < n; p++)
            {
                if (prime[p])
                {
                    for (int i = p*p; i <= n; i+=p)
                    {
                        prime[i] = false;
                    }
                }

            }
            for (int i = 2; i <n; i++)
            {
                if(prime[i] == true)
                {
                    Console.Write(i + " ");
                }
            }

        }
}