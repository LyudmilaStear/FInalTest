string[] EnterNewArray(int size) //, int minValue, int maxValue)
            {
                
                string[] array = new string[size]; 
                for (int i = 0; i < size; i++) 
                {
                    Console.WriteLine($"Введите элемент массива под индексом {i}");
                    array[i] = Console.ReadLine();     
                }                           
                return array;
            }

            void WriteArray(string[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"'{array[i]}', ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Введите размер массива: ");
            int size1 = Convert.ToInt32(Console.ReadLine());
            string[] array = EnterNewArray(size1);
            Console.WriteLine("Ваш массив: ");
            WriteArray(array);
