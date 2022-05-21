import {IShape, Circle, Triangle} from './ShapesModule'

function drawShapes (shapes: IShape[]):void{
    for (let shape of shapes)
    {
        shape.draw();
    }
}

let myShapes: IShape[]=[new Circle(),new Triangle()];
drawShapes(myShapes);