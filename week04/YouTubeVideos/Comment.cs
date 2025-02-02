/* A comment should be defined by the Comment class
which has the responsibility for tracking both the
name of the person who made the comment and the text
of the comment. */
using System;

public class Comment{

private string _name;
private string _text;

public Comment(string name, string text){
    _name = name;
    _text = text;
}

}