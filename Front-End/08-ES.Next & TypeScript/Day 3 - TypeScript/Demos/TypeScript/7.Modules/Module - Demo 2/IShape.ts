/*
A module is designed with the idea to organize code written in TypeScript. 
Modules are broadly divided into:
    Internal Modules
    External Modules

External modules in TypeScript exists to specify and load dependencies between 
multiple external js files. If there is only one js file used, 
then external modules are not relevant.

To support loading external JavaScript files, we need a module loader. 
This will be another js library. 
For browser the most common library used is RequieJS. 
This is an implementation of AMD (Asynchronous Module Definition) specification. 
Instead of loading files one after the other, AMD can load them all separately, 
even when they are dependent on each other.
https://www.tutorialsteacher.com/typescript/typescript-module
*/
//export let testVar: string="test";

export interface IShape { 
  draw(); 
}