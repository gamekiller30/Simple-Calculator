            Console.Write("Enter value A:");
            int vala = int.Parse(Console.ReadLine());


            Console.Write("Enter value B:");
            int valb = int.Parse(Console.ReadLine());

            Console.Write("Enter Calculation Type:");
            string calc = (Console.ReadLine());


            double result;


            switch (calc)
            {

                case "*":
                    result = vala * valb;
                    Console.WriteLine("The result is {0}.", result);
                    break;

                case "/":
                    result = vala / valb;
                    Console.WriteLine("The result is {0}.", result);
                    break;

                case "+":
                    result = vala + valb;
                    Console.WriteLine("The result is {0}.", result);
                    break;


                case "-":
                    result = vala - valb;
                    Console.WriteLine("The result is {0}.", result);
                    break;

                case "sqrt":
                    result = Math.Sqrt(vala + valb);
                    Console.WriteLine(result);
                    break;

                case "Pow":
                    result = Math.Pow(vala, valb);
                    Console.WriteLine(result);
                    break;

                case "Reamainder":
                    result = vala % valb;
                    Console.WriteLine(result);
                    break;

                case "exit":
                    Console.WriteLine("Cya soon!");
                    break;

                default:
                    Console.WriteLine("Wrong Value!");
                    break;

            }

            Console.ReadKey();
