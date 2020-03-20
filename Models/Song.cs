using System;

namespace Uweek.Models
{
    public class Song
    {
    
    public int Id {get;set;}
    public string Name {get;set;}
    public DateTime PublicDate {get;set;}
    public int AuthorId {get;set;}
    public int GenderId {get;set;}
    public Gender Gender {get;set;}

    }
}