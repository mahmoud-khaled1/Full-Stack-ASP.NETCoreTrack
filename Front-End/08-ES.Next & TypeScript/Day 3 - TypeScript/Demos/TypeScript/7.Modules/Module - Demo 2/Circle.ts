
//import shape = require("./IShape"); 
import {IShape} from './IShape'

export class Circle implements IShape { 
   public draw() { 
      console.log("Cirlce is drawn (external module)"); 
   } 
} 