/*Your program should have a class for a Video that
has the responsibility to track the title, author, 
and length (in seconds) of the video. Each video 
also has responsibility to store a list of comments,
and should have a method to return the number of 
comments.*/
using System;


public class Video{

public string _title;
public string _author;
public string _length;
public List<string> _commentList;

public List<string> CommentList(string title, string author, string length){
    _title = title;
    _author = author;
    _length = length;
    List<string> _commentList = new();
    _commentList.Add(_title);
    _commentList.Add(_author);
    _commentList.Add(_length);
    return _commentList;
}

public int NumberOfComments(){
    int commentCounter = _commentList.Count();
    return commentCounter;
}
}