using System;
using System.Collections.Generic;

public class LibraryManager
{

    private readonly List<LibraryItem> _catalog;
    
 
    private readonly List<Member> _members;

   
    public LibraryManager()
    {
        _catalog = new List<LibraryItem>();
        _members = new List<Member>();
    }


    public void AddItem(LibraryItem item)
    {
        if (item == null)
            throw new ArgumentNullException(nameof(item), "Cannot add a null item to catalog");
            
        _catalog.Add(item);
    }

  
    public void RegisterMember(Member member)
    {
        if (member == null)
            throw new ArgumentNullException(nameof(member), "Cannot register a null member");
            
        _members.Add(member);
    }

 
    public void ShowCatalog()
    {
        Console.WriteLine("\n=== Library Catalog ===");
        
        if (_catalog.Count == 0)
        {
            Console.WriteLine("No items in catalog.");
        }
        else
        {
            foreach (var item in _catalog)
            {
                Console.WriteLine($"- {item.GetDetails()} (ID: {item.Id})");
            }
        }
        
        Console.WriteLine("======================\n");
    }

    public LibraryItem? FindItemById(int id) => 
        _catalog.Find(item => item.Id == id);

  
    public Member? FindMemberByName(string name) => 
        _members.Find(member => member.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
}
