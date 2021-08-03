using System;



namespace SecretAgent
{
   
    class Program
    {


        static void Main()
        {
            
            Console.WriteLine("Hello Secret agent please give us your code name");
            string codeName = Console.ReadLine();
            Console.WriteLine("welcome " + codeName);
            Console.WriteLine("We are sending you to infiltrate the enemy base take this hacking device and good luck");
            Console.ReadKey();
            Console.Clear();
            for (int i = 1; i < 3; i++)
            {
             Mission(i);
            }

            EndGame();
          
        }
        // the mission logic
        static void Mission(int door)
        {
            Random rnd = new Random();
            int A = rnd.Next(1, 10);
            int B = rnd.Next(2, 10);
            int C = rnd.Next(2, 10);
            Console.WriteLine("you are infront of the " + door + "e door");
            Console.WriteLine("your device tells you its a 3 number code:");
            Console.WriteLine("added up the total is " + (A + B + C));
            Console.WriteLine("multiplied the total is " + (A * B * C));
            //Console.WriteLine(A.ToString() + " " + B.ToString() + " " + C.ToString());

            string Awnser = Console.ReadLine();
            if (Awnser == (A.ToString() + " " + B.ToString() + " " + C.ToString()))
            {
                Console.WriteLine("You break the code and proceed");
                Console.ReadKey();
                Console.Clear();
            } 
            else
            {
                Console.WriteLine("Worng!! as they drag you to the brig you see the correct code");
                Console.WriteLine(A.ToString() + " " + B.ToString() + " " + C.ToString());

                Console.ReadKey();
                Console.Clear();
                Main();
               
            }
            

        }
        // the final code logic 
        static void EndGame()
        {
            Console.Clear();
            Console.WriteLine("You are at the DOOMSDAY device, the fate of the free world is on your shoulders");
            Random rnd = new Random();
            int A = rnd.Next(1, 6);
            int B = rnd.Next(2, 6);
            int C = rnd.Next(2, 6);
            int D = rnd.Next(2, 6);

            Console.WriteLine("your device tells you its a 4 number code luckely the numpad only has 5 key's ");
            Console.WriteLine("added up the total is " + (A + B + C + D));
            Console.WriteLine("multiplied the total is " + (A * B * C * D));
            //Console.WriteLine(A.ToString() + " " + B.ToString() + " " + C.ToString() + " " + D.ToString());

            string Awnser = Console.ReadLine();
            if (Awnser == (A.ToString() + " " + B.ToString() + " " + C.ToString() + " " + D.ToString()))
            {
                Console.WriteLine("You deactivate the device take the core and sneak away");
                Console.WriteLine("You already have a beautiful girl in your arms when the airstrike hits");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Thank you for completing my silly game");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Worng!! You are held down while the evil genius keys in the deactivation code to take his time with you");
                Console.WriteLine(A.ToString() + " " + B.ToString() + " " + C.ToString() + " " + D.ToString());

                Console.ReadKey();
                Console.Clear();
                Main();

            }


        }

    }





}
