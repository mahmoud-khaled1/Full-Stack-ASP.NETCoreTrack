import { Circle, Triangle } from './ShapesModule.js';

function drawShapes(shapes) {
    for (var _i = 0, shapes_1 = shapes; _i < shapes_1.length; _i++) {
        var shape = shapes_1[_i];
        shape.draw();
    }
}
var myShapes = [new Circle(), new Triangle()];
drawShapes(myShapes);