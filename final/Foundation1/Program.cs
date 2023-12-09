using System;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("New Dog! Goodbye old one", "JonnyTeez", 500);
        Comment v1c1 = new Comment("Chugga", "Awe, hate to see ol fido go :(");
        Comment v1c2 = new Comment("Gottem44", "You're new dog is so cute!!!");
        Comment v1c3 = new Comment("wssd333a", "Is that a right thing to do for a dog?");
        Comment v1c4 = new Comment("thisIsSALLYFOSTER", "NO00oooOOoo0, Not fido!!!!");
        v1.AddComment(v1c1);
        v1.AddComment(v1c2);
        v1.AddComment(v1c3);
        v1.AddComment(v1c4);

        Video v2 = new Video("How to win Monopoly every time", "The Monopoly Man", 2000);
        Comment v2c1 = new Comment("win star", "Monopoly is really the worst game");
        Comment v2c2 = new Comment("jacbojacob", "THIS IS AMAZING!!! I AM GOING TO WIN EVERYTIME NOW!!!");
        Comment v2c3 = new Comment("Whoaskedyou", "Why did I click on this....Why did I watch all 33min...");
        v2.AddComment(v2c1);
        v2.AddComment(v2c2);
        v2.AddComment(v2c3);

        Video v3 = new Video("You'll never guess what I just saw!!!", "Tallun", 20);
        Comment v3c1 = new Comment("heresjonny", "Wait, what is it?! what did you see??");
        Comment v3c2 = new Comment("hunkman", "Clickbait");
        Comment v3c3 = new Comment("yeahThatsME", "wow, that just is so......sad");
        Comment v3c4 = new Comment("little tim", "First Comment");
        Comment v3c5 = new Comment("big tom", "First Comment!!!");
        v3.AddComment(v3c1);
        v3.AddComment(v3c2);
        v3.AddComment(v3c3);
        v3.AddComment(v3c4);
        v3.AddComment(v3c5);

        List<Video> allVideos = new List<Video>()
        {
            v1,v2,v3
        };

        foreach (Video v in allVideos)
        {
            v.DisplayVideoInfo();
            int count = v.CountComments();
            Console.WriteLine($"This video has {count} comments \nThe comments are: \n");
            v.ListComments();

            Console.WriteLine("=================================================");
        }


    }
}