/*
An enum is a way to organize a collection of related values.
Many other programming languages (C/C#/Java) have an enum data type but
JavaScript does not. However TypeScript does.
*/
var Color;


(function (Color) {
    Color[Color["Red"] = 0] = "Red";
    Color[Color["Green"] = 1] = "Green";
    Color[Color["Blue"] = 2] = "Blue";
})(Color || (Color = {}));
var col = Color.Red;
col = 0; // Effectively same as Color.Red
//you can change the number associated with an Enum:
var Color2;
(function (Color2) {
    Color2[Color2["DarkRed"] = 3] = "DarkRed";
    Color2[Color2["DarkGreen"] = 4] = "DarkGreen";
    Color2[Color2["DarkBlue"] = 5] = "DarkBlue"; // 5
})(Color2 || (Color2 = {}));
function setColor(c) {
    console.log(c);
    console.log(Color[c]);
    document.body.style.backgroundColor = Color[c];
}
//calling function:
setColor(Color.Blue); //will work.
//setColor("red");//will not work
