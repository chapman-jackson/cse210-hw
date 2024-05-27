using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Video list.
        List<Video> _youtubeVideos = new List<Video>();

        // Video one and its comments.
        Video videoOne = new Video("How to bake a cake.","Natasha's Kitchen","23:45");
        _youtubeVideos.Add(videoOne);

        Comment commentOne = new Comment("Jane L.","Thanks for the recipe!");
        videoOne.AddComments(commentOne);

        Comment commentTwo = new Comment("Bill T.","I used this tutorial to bake a cake for my wife. It was soooo good!");
        videoOne.AddComments(commentTwo);

        Comment commentThree = new Comment("Sarah P.","My daughter and I had a great time baking this cake together.");
        videoOne.AddComments(commentThree);

        //Video two and its comments.
        Video videoTwo = new Video("How to change oil in a car.","Bob the Mechanic","12:27");
        _youtubeVideos.Add(videoTwo);

        Comment commentFour = new Comment("Susan C.","Thanks for the help! ");
        videoTwo.AddComments(commentFour);

        Comment commentFive = new Comment("John H.","This was a good refresher. Thank you.");
        videoTwo.AddComments(commentFive);

        Comment commentSix = new Comment("Dane R.","I didn't know where to start. This helped a lot.");
        videoTwo.AddComments(commentSix); 

        // Video three and its comments.
        Video videoThree = new Video("Twelve tricks to draw amazing flowers.","Art with Dani","30:13");
        _youtubeVideos.Add(videoThree);

        Comment commentSeven = new Comment("Joseph H.","This helped me improve my drawings.");
        videoThree.AddComments(commentSeven);

        Comment commentEight = new Comment("Leah L.","You explained it in a way my beginner mind could understand. Thank you!");
        videoThree.AddComments(commentEight);

        Comment commentNine = new Comment("Amy C.","Your drawing techniques are always amazing.");
        videoThree.AddComments(commentNine);

        // Video four and its comments.
        Video videoFour = new Video("Meditation for Ten minutes a day","Meditation Guru","10:00");
        _youtubeVideos.Add(videoFour);

        Comment commentTen = new Comment("Sonya V.","This helped me wind down after a stressful day at work.");
        videoFour.AddComments(commentTen);

        Comment commentEleven = new Comment("Henry T.","An excellent way to begin my day.");
        videoFour.AddComments(commentEleven);

        Comment commentTwelve = new Comment("Lisa H.","I'm sharing this with my family and friends. It is so good!");
        videoFour.AddComments(commentTwelve);

        // Displaying the videos and the comments.
        foreach (var videos in _youtubeVideos)
        {
            Console.WriteLine(videos.returnVideoContent());
            foreach (var comments in videos.returnComments())
            {
                Console.WriteLine($"{comments.returnComments()}");
            }
            Console.WriteLine();
        }
    }
}