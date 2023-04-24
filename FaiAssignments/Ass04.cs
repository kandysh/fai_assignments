            Type arrType = Type.GetType(Console.ReadLine()); // asks for the cts type and convert's it to type
            var len = int.Parse(Console.ReadLine());
            Array arr = Array.CreateInstance(arrType, len); // creates an instance of array with the type and length

            for (int i = 0; i < len; i++)
                arr.SetValue(Convert.ChangeType(Console.ReadLine(), arrType), i); // Setvalue sets the value for that index and convert converts the data types

            foreach (var a in arr) Console.WriteLine(a);
