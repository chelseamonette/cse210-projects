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
public List<Comment> _commentList;

public Video(string title, string author, int length)
{
    _title = title;
    _author = author;
    _length = length;
    _commentList = new List<Comment>();
}
public string VideoInfo()
{
    return $"Title: {_title}, Author: {_author} Length: {_length} seconds";
}
public void StoreComments(Comment comment)
{
    _commentList.Add(comment);
}
public string DisplayComments(Comment comment)
{
    return $"Name: {comment._name}, Comment: {comment._text}";
}
public int NumberOfComments()
{
    return _commentList.Count;
}
}