namespace AssignmentW4
{
    internal class Program
    {
        static void Main()
        {
            //1.Creating an instance of the Car class
            Car car1 = new Car("Honda", 2019, 30000.00f);
            Console.WriteLine($" Brand: {car1.Brand}");
            Console.WriteLine($" Year: {car1.Year}");
            Console.WriteLine($" Price: {car1.Price}");

            //2.Creating an instance of the BankAccount class
            BankAccount account = new BankAccount("12345");
            account.Deposit(1000);
            account.Withdraw(500);
            //Printing the final balance
            Console.WriteLine($"Final Balance : {account.Balance}");

            //3.Creating an instance of the Rectangle class
            Rectangle myRectangle = new Rectangle(4.5f, 3.2f);
            //Calling the calculateArea method
            float area = myRectangle.CalculateArea();
            Console.WriteLine($"Area of the rectangle is {area}");

            //4.Creating an instance of circle class
            Circle myCircle = new Circle(5);
            float areaCircle = myCircle.CalculateArea();
            Console.WriteLine($"Area of the circle is {areaCircle}");

            //5. Creating an instance of Student class
            Student john = new Student("JohnDoe", 20, "Computer Science");
            john.Introduce();

            Stack<int> myStack = new Stack<int>();

            // Pushing elements onto the stack and printing after each push
            myStack.Push(5);
            PrintStack(myStack);

            myStack.Push(10);
            PrintStack(myStack);

            myStack.Push(15);
            PrintStack(myStack);

            // Popping elements from the stack and printing after each pop
            int poppedItem = myStack.Pop();
            Console.WriteLine($"Popped item: {poppedItem}");
            PrintStack(myStack);

            Console.ReadLine(); // To prevent the console from closing immediately
        }

        static void PrintStack(Stack<int> stack)
        {
            Console.WriteLine("Stack items:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}