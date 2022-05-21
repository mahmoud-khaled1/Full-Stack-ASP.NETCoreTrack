/*
A namespace is a way to logically group related code.
This is inbuilt into TypeScript unlike in JavaScript where variables
declarations go into a global scope and if multiple JavaScript files are
used within same project there will be possibility of overwriting or
misconstruing the same variables,
which will lead to the “global namespace pollution problem” in JavaScript.

A namespace definition begins with the keyword namespace followed by
the namespace name.

The classes or interfaces which should be accessed outside the namespace
should be marked with keyword export.
https://www.tutorialsteacher.com/typescript/typescript-namespace
*/
/// <reference path = "IShape.ts" /> 
var Drawing;
(function (Drawing) {
    var Circle = /** @class */ (function () {
        function Circle() {
        }
        Circle.prototype.draw = function () {
            console.log("Circle is drawn");
        };
        return Circle;
    }());
    Drawing.Circle = Circle;
})(Drawing || (Drawing = {}));
/// <reference path = "IShape.ts" /> 
var Drawing;
(function (Drawing) {
    var Triangle = /** @class */ (function () {
        function Triangle() {
        }
        Triangle.prototype.draw = function () {
            console.log("Triangle is drawn");
        };
        return Triangle;
    }());
    Drawing.Triangle = Triangle;
})(Drawing || (Drawing = {}));
/// <reference path = "IShape.ts" />   
/// <reference path = "Circle.ts" /> 
/// <reference path = "Triangle.ts" />  
var Drawing;
(function (Drawing) {
    function drawAllShape(shape) {
        shape.draw();
    }
    drawAllShape(new Drawing.Circle());
    drawAllShape(new Drawing.Triangle());
})(Drawing || (Drawing = {}));
var Test;
(function (Test) {
    function drawAllShape(shape) {
        shape.draw();
    }
    drawAllShape(new Drawing.Circle());
    drawAllShape(new Drawing.Triangle());
})(Test || (Test = {}));
