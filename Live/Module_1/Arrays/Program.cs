namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
        int[] nummers;
        nummers =  [ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ];
        
        for (int i = 0; i < nummers.Length; i++)
        {
            System.Console.WriteLine(nummers[i]);
        }
        // nummers[0] = 5;
        // nummers[1] = 3;
        // nummers[2] = 8;
        // nummers[3] = 1;
        // nummers[4] = 4;
        Console.WriteLine(nummers[^1]);

        int[] nummers2 = [.. nummers, 12, 14, 16];

        for (int i = 0; i < nummers2.Length; i++)
        {
            System.Console.WriteLine(nummers2[i]);
        }

        int[] nummers3 = new int[100];
        Array.Copy(nummers, nummers3, nummers.Length);

        int[] nummers4 = new int[100];
        nummers4 = [.. nummers];

        for (int i = 0; i < nummers3.Length; i++)
        {
            // System.Console.WriteLine(nummers3[i]);
        }

        int[,] matrix = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
        System.Console.WriteLine(matrix[1, 2]);

        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[] { 1, 2, 3 };
        jaggedArray[1] = new int[] { 4, 5 };
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };

        int[,,] cube = new int[3, 3, 3]
        {
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            },
            {
                {10,11,12 },
                {13,14,15 },
                {16,17,18 }
            },
            {
                {19,20,21 },
                {22,23,24 },
                {25,26,27 }
            }
        };

        System.Console.WriteLine(cube.Rank);

        for (int i = 0; i < nummers.Length; i++)
        {
            int tmp = nummers[i];
            System.Console.WriteLine(tmp);
        }

        foreach (int tmp in nummers)
        {
            System.Console.WriteLine(tmp);
        }

        var x = 6.7;
        var list = new List<Func<Action<string>, int>>();

    }
}
