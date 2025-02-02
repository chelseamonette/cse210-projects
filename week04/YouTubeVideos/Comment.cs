/* A comment should be defined by the Comment class
which has the responsibility for tracking both the
name of the person who made the comment and the text
of the comment. */
using System;

public class Comment(){

public string _name;
public string _text;

public string VideoComment(string name, string text){
    _name = name;
    _text = text;
    

}

}