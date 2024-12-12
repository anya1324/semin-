namespace _2D_Boats
{
    class Program
    {
        static bool endGame = false;
        static int boatCount = 2;

        static int[,] playerField;
        static int[,] enemyField;

        static char empty = '*';
        static char boat = 'X';
        static char miss = '-';
        static char explode = '#';

        static void Main(string[] args)
        {
            playerField = FillArray();
            enemyField = FillArray();

            MakePlayerBoats();
            MakeEnemyBoats();

            while (!endGame)
            {
                Console.Clear();
                PrintPlayerField();
                Console.WriteLine();
                PrintEnemyField();
                Input();
                EnemyAttack();
                CheckForLoose();
                CheckForWin();
            }
        }
        static void Input()
        {
            Console.WriteLine("Napis souradnice lodicky X");
            int x = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine("Napis souradnice lodicky Y");
            int y = Convert.ToInt32(Console.ReadLine()) - 1;

            enemyField[y, x] += 10;
        }
        static void EnemyAttack()
        {
            Random rnd = new Random();
            playerField[rnd.Next(0, 10), rnd.Next(0, 10)] += 10;
        }
        static void PrintPlayerField()
        {
            for (int i = 0; i < playerField.GetLength(0); i++)
            {
                for (int j = 0; j < playerField.GetLength(1); j++)
                {
                    if (playerField[i,j] == 1)
                    {
                        Console.Write(boat);
                    }
                    else if (playerField[i, j] == 10)
                    {
                        Console.Write(miss);
                    }
                    else if (playerField[i, j] == 11)
                    {
                        Console.Write(explode);
                    }
                    else
                    {
                        Console.Write(empty);
                    }
                }
                Console.WriteLine();
            }
        }
        static void PrintEnemyField()
        {
            for (int i = 0; i < enemyField.GetLength(0); i++)
            {
                for (int j = 0; j < enemyField.GetLength(1); j++)
                {
                    if (enemyField[i, j] == 10)
                    {
                        Console.Write(miss);
                    }
                    else if (enemyField[i, j] == 11)
                    {
                        Console.Write(explode);
                    }
                    else
                    {
                        Console.Write(empty);
                    }
                }
                Console.WriteLine();
            }
        }
        static void MakePlayerBoats()
        {
            for (int i = 0; i < boatCount; i++)
            {
                Console.WriteLine($"Napis souradnice {i+1}. lodicky X");
                int x = Convert.ToInt32(Console.ReadLine()) - 1;

                Console.WriteLine($"Napis souradnice {i+1}. lodicky Y");
                int y = Convert.ToInt32(Console.ReadLine()) - 1;

                playerField[y, x] = 1;
            }
        }
        static void MakeEnemyBoats()
        {
            Random rnd = new Random();

            for (int i = 0; i < boatCount; i++)
            {
                enemyField[rnd.Next(0, 10), rnd.Next(0, 10)] = 1;
            }
        }
        static int[,] FillArray()
        {
            int[,] array = new int[10,10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    array[i, j] = 0;
                }
            }

            return array;
        }
        static void CheckForLoose()
        {
            int count = 0;

            for (int i = 0; i < playerField.GetLength(0); i++)
            {
                for (int j = 0; j < playerField.GetLength(1); j++)
                {
                    if (playerField[i, j] == 1)
                    {
                        count++;
                    }
                }
            }

            if (count == 0)
            {
                Console.WriteLine("prohral(a) jsi");
                endGame = true;
            }
        }
        static void CheckForWin()
        {
            int count = 0;

            for (int i = 0; i < playerField.GetLength(0); i++)
            {
                for (int j = 0; j < playerField.GetLength(1); j++)
                {
                    if (enemyField[i, j] == 1)
                    {
                        count++;
                    }
                }
            }

            if (count == 0)
            {
                Console.WriteLine("vyhral(a) jsi");
                endGame = true;
            }
        }
    }
}