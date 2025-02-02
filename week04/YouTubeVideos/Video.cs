/*Your program should have a class for a Video that
has the responsibility to track the title, author, 
and length (in seconds) of the video. Each video 
also has responsibility to store a list of comments,
and should have a method to return the number of 
comments.*/
using System;
using System.ComponentModel;
using System.Transactions;


public class Video{

private string _title;
private string _author;
private int _length;


public Video(string title, string author, int length)
{
    _title = title;
    _author = author;
    _length = length;
    
}
public string VideoInfo()
{
    return $"{_title}, {_author} {_length}seconds";
}
public List<Comment> StoreComments(Comment comment, Video video)
{
    List<Comment> commentList = new();
    
}
public void DisplayComments(Comment comment)
{
    Console.Write(comment);
}
public int NumberOfComments()
{
    int commentCounter = 0;
    foreach(Comment comment in _commentList){
        commentCounter = commentCounter + 1;
    }
    return commentCounter;
}
}