// TestShape.ts 
// import shape = require("./IShape"); 
// import circle = require("./Circle"); 
// import triangle = require("./Triangle");  

import {IShape} from './IShape'
import {Circle} from './Circle'
import {Triangle} from './Triangle'

function drawAllShapes(shapeToDraw: IShape) {
   shapeToDraw.draw(); 
} 

drawAllShapes(new Circle()); 
drawAllShapes(new Triangle()); 