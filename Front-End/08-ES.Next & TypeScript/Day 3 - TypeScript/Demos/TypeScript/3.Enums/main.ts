/*
An enum is a way to organize a collection of related values. 
Many other programming languages (C/C#/Java) have an enum data type but 
JavaScript does not. However TypeScript does. 
*/

enum Color { 
    Red,//0
    Green,//1
    Blue//2
}

var col:Color=Color.Blue;
col = 2; // Effectively same as Color.Blue

//you can change the number associated with an Enum:
enum Color2 {
  DarkRed = 3,  // 3
  DarkGreen,    // 4
  DarkBlue      // 5
}

function setColor(c:Color):void
{
  console.log(c);//2
  console.log(Color[c]);//Blue
  document.body.style.backgroundColor=Color[c];
}

//calling function:
setColor(Color.Red);//will work.

//setColor("red");//will not work


