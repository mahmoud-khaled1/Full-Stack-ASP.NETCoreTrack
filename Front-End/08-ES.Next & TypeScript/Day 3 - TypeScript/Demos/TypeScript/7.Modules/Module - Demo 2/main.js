// TestShape.ts 
// import shape = require("./IShape"); 
// import circle = require("./Circle"); 
// import triangle = require("./Triangle");  
define(["require", "exports", "./Circle", "./Triangle"], function (require, exports, Circle_1, Triangle_1) {
    "use strict";
    exports.__esModule = true;
    function drawAllShapes(shapeToDraw) {
        shapeToDraw.draw();
    }
    drawAllShapes(new Circle_1.Circle());
    drawAllShapes(new Triangle_1.Triangle());
});
