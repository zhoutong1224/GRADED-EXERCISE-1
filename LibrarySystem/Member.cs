using System;
using System.Collections.Generic;

public class Member
{
  
    private readonly string _name;
    
   
    private readonly List<LibraryItem> _borrowedItems;

    
    public string Name => _name;

    
    public Member(string name)
    {
        _name = name;
        _borrowedItems = new List<LibraryItem>();
    }

 
    public string BorrowItem(LibraryItem item)
    {
      
        if (_borrowedItems.Count >= 3)
        {
            return "You cannot borrow more than 3 items.";
        }
        
     
        _borrowedItems.Add(item);
        return $"Item '{item.Title}' has been added to your borrowed list.";
    }

    
    public string ReturnItem(LibraryItem item)
    {
       
        if (_borrowedItems.Contains(item))
        {
            _borrowedItems.Remove(item);
            return $"Item '{item.Title}' has been successfully returned.";
        }
        else
        {
            return $"Item '{item.Title}' was not in your borrowed list.";
        }
    }

    public List<LibraryItem> GetBorrowedItems()
    {

        return new List<LibraryItem>(_borrowedItems);
    }
}
    