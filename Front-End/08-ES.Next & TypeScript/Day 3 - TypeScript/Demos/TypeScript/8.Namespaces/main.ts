
/// <reference path = "IShape.ts" />   
/// <reference path = "Circle.ts" /> 
/// <reference path = "Triangle.ts" />  

namespace Drawing{
    function drawAllShape(shape:IShape) { 
        shape.draw(); 
    } 
    drawAllShape(new Circle());
    drawAllShape(new Triangle());
}
namespace Test
{
    function drawAllShape(shape:Drawing.IShape) { 
        shape.draw(); 
    } 
    drawAllShape(new Drawing.Circle());
    drawAllShape(new Drawing.Triangle());
}





    