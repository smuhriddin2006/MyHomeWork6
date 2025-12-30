using MainApp5;

Post.CreatePost("Dubai","too good", 2);
Post.CreatePost("America","too great", 10);
Post.CreatePost("Russian","too bad", 20);
var filt = Post.GetPosts();
foreach(var res in filt)
{
    System.Console.WriteLine($"{res.Title} -- {res.Description} -- {res.CategoryId}");
}
