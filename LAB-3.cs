
int sum = 0;
            int res = 0;
            int[] M = new int[9];
            for (int i = 0; i < M.Length; i++)
            {
                Console.WriteLine($"Введите число {i+1}:");
                M[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < M.Length; i++)
            {
                if(M[i] % 5 == 0 && M[i] % 7 != 0)
                {
                    sum += M[i];
                    res += 1;
                }
            }
            Console.WriteLine($"Сумма элементов: {sum}. Количество: {res}");
            Console.ReadKey();
