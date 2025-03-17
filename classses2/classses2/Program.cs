namespace classses2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many books do you want?: ");
            int count = int.Parse(Console.ReadLine());

            Book[] books = new Book[count];

            for (int i = 0; i < count; i++) 
            {
                Console.WriteLine(i + 1 + ") Insert information about the book: ");
                
                Console.WriteLine("No: ");
                int no = int.Parse(Console.ReadLine());

                Console.WriteLine("Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Price: ");
                float price = float.Parse(Console.ReadLine());

                Console.WriteLine("Genre: ");
                string genre = Console.ReadLine();

                books[i] = new Book(no, name, price, genre);                
            }
            Console.WriteLine("Given book(s): ");
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Name: " + books[i].Name );
                Console.WriteLine("Price: " + books[i].Price );
            }
        }
    }
}
