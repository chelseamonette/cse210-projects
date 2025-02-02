/* Write a program to keep track of YouTube videos
and comments left on them. As mentioned this could
be part of a larger project to analyze them, but
for this assignment, you will only need to worry
about storing the information about a video and
the comments.*/

using System;

class Program
{
    static void Main(string[] args)
    {
        /*Once you have the classes in place, write a program that 
        creates 3-4 videos, sets the appropriate values, and for each 
        one add a list of 3-4 comments (with the commenter's name and 
        text). Put each of these videos in a list.*/
        Video video1 = new Video("Easy Updo for Short to Medium Hair", "Another Braid", 71);
        Comment comment1 = new Comment("@launijohnson2683", "I'm terrible with hair and I was actually able to do this! Mine wasn't so perfect but good enough to wear as a wedding guest. Thank you!!");
        Comment comment2 = new Comment("@pinokoyokoyama8131", "fake hair is easy to do, real hair is not this easy to control especially for smooth silky hair.");
        Comment comment3 = new Comment("@kc7816", "I found your video. My hair sits exactly at the top of the shoulder. Perfect length for this hairstyle. I did this hairstyle for my wedding myself and absolutely love it and it's so easy and pretty to do!");
        List<Comment> commentsVideo1 = new();
        video1.StoreComments(comment1)
        commentsVideo1.Add(comment1);
        commentsVideo1.Add(comment2);
        commentsVideo1.Add(comment3);

        Video video2 = new Video("Easy 10 Minute Everyday Full Face Massage", "TheMoments", 794);
        Comment comment4 = new Comment("@SuzanneG-k9h", "I am over 65 and this is still helping a lot, thanks for making it so easy");
        Comment comment5 = new Comment("@ethanteige", "As a guy, I see many people seeing face massages as something overly feminine, but this is wonderful and so necessary for anyone in modern day. I greatly appreciate this, thanks for making great and healing content 🙏💙"); 
        Comment comment6 = new Comment("@harshitaojha4857", "I think this is the best massage video I've seen on YouTube. I can't believe you're demonstrating this for free.");
        List<Comment> commentsVideo2 = new();
        commentsVideo2.Add(comment4);
        commentsVideo2.Add(comment5);
        commentsVideo2.Add(comment6);

        Video video3 = new Video("How Jesus Christ Restores What Is Broken", "The Church of Jesus Christ of Latter-day Saints", 212);
        Comment comment7 = new Comment("@Videostowatch24", "Jeffery. R Holland is one of the most compassionate people  on this earth. He knows what darkness feels like, so he reminds us that the light comes back.");
        Comment comment8 = new Comment("@julienconnault1612", "My mother passed away today. This message comes at the exact right time for me. Thanks Brother Holland for your compassion.");
        Comment comment9 = new Comment("@stanlane1694", "Me being a broken vessel know in my heart one day I will be healed both mentally and physically....thank you Br. Holland, i love you.");
        List<Comment> commentsVideo3 = new();
        commentsVideo3.Add(comment7);
        commentsVideo3.Add(comment8);
        commentsVideo3.Add(comment9);

        List<Video> videos = new();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3); 

        /*Then, have your program iterate through the list of videos 
        and for each one, display the title, author, length, number 
        of comments(from the method) and then list out all of the 
        comments for that video. Repeat this display for each video 
        in the list.*/
        foreach(Video video in videos)
        {
            Console.WriteLine(video.VideoInfo());
            
        }
        
        
    }
}