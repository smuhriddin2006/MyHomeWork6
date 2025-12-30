namespace MainApp5;

public class Category : Post
{
    public int Id {get; set;}
    public string Name {get; set;}
    public DateTime CreatedAi {get; set;}

    static List<Category> categories = new();
    public static void CreatCategory(string name)
    {
        var create = new Category()
        {
            Name = name
        };
        categories.Add(create);
    }
    public static List<Category> GetCategories()
    {
        return categories;
    }
    public static Category GetCategoryById(int id)
    {
        var findI = categories.Find(f => f.Id == id)!;
        return findI;
    }

    public static List<Category> GetCategoryByName(string name)
    {
        var filtr = categories
        .Where(category => category.Name.ToLower().Contains(name.ToLower())).ToList();
        return filtr;
    }
    public static Category GetCategoriesByData(DateTime date)
    {
        var find = categories.Find(f => f.CreatedAi == date);
        return find!;
    }


    public static void DeleteCategory(int id)
    {
        var findI = categories.Find(f => f.Id == id);
        categories.Remove(findI!);
    }

}
