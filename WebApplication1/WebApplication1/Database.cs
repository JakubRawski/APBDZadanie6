using WebApplication1.Models;

namespace WebApplication1;

public class Database
{
    public static List<Animal> Animals = new List<Animal>()
    {
        new Animal() { id = 1, name = "krowa" },
        new Animal() { id = 2, name = "owca" },
        new Animal() { id = 3, name = "kura" }
    };


}