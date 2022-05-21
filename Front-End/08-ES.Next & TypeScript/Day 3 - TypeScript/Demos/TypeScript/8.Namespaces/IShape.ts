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

namespace Drawing { 
  export interface IShape { 
     draw(); 
  }
} 