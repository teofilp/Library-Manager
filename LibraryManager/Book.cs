using System;

public class Book
{
    public string id { set; get; }
    public string title { set; get; }
    public string author { set; get; }
    public string category { set; get; }
    public string description { set; get; }
    public int copies { set; get; }
    public int available { set; get; }

    public byte[] cover { set; get; }

    public Book(string id, string title, string author, string category, string description, int copies,  int available, byte[] cover)
    {
        this.id = id;
        this.title = title;
        this.author = author;
        this.category = category;
        this.description = description;
        this.copies = copies;
        this.available = available;
        this.cover = cover;
    }
}
