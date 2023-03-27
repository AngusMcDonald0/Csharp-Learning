namespace BlogPost
{
    class Program
    {
        static void Main(String[] args) 
        {
            var allAboutClasses = new Post("lesson on classes", "i like this lesson on classes it seems very useful");
            allAboutClasses.Upvote();
            allAboutClasses.Upvote();
            allAboutClasses.Downvote();
            Console.WriteLine($"Votes for this post: {allAboutClasses.GetVotes()}");
        } 
    }
}