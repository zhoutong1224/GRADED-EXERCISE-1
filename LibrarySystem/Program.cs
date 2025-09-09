using System;

class Program
{
    static void Main(string[] args)
    {
        
        LibraryManager library = new LibraryManager();
        
        
        library.AddItem(new Novel(1, "The Great Gatsby", "F. Scott Fitzgerald"));
        library.AddItem(new Novel(2, "1984", "George Orwell"));
        
        
        library.AddItem(new Magazine(3, "National Geographic", 256));
        
        
        library.AddItem(new TextBook(4, "Introduction to C#", "O'Reilly Media"));
        
       
        Member alice = new Member("Alice");
        
        
        Member bob = new Member("Bob");
        
       
        library.RegisterMember(alice);
        library.RegisterMember(bob);
        
       
        Console.WriteLine("Displaying library catalog:");
        library.ShowCatalog();
        
        
        LibraryItem? item = library.FindItemById(1);
        if (item != null)
        {
            string result = alice.BorrowItem(item);
            Console.WriteLine(result);
        }
        
       
        item = library.FindItemById(2);
        if (item != null)
        {
            string result = alice.BorrowItem(item);
            Console.WriteLine(result);
        }
        
       
        item = library.FindItemById(3);
        if (item != null)
        {
            string result = alice.BorrowItem(item);
            Console.WriteLine(result);
        }
        
        
        Novel newNovel = new Novel(5, "To Kill a Mockingbird", "Harper Lee");
        library.AddItem(newNovel); 
        item = newNovel;
        
        // 尝试借阅第4本
        string borrowResult = alice.BorrowItem(item);
        Console.WriteLine(borrowResult); 
    }
}
