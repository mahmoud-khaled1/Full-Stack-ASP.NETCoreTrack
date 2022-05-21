// Decorators provide a way to add both annotations and a meta-programming syntax for class declarations and members.

// A Decorator is a special kind of declaration that can be attached to 
// a class declaration, method, property, or parameter. 
// Decorators use the form @expression, where expression must evaluate to a 
// function that will be called at runtime with information about the decorated declaration.

// A Class Decorator is declared just before a class declaration. 
// The class decorator is applied to the constructor of the class and can be used to observe, modify, or replace a class definition.

// A Method Decorator is declared just before a method declaration. 
// The decorator is applied to the Property Descriptor for the method, and can be used to observe, modify, or replace a method definition. 

// The expression for the method decorator will be called as a function at runtime, with the following three arguments:

//     - Either the constructor function of the class for a static member, or the prototype of the class for an instance member.
//     - The name of the member.
//     - The Property Descriptor for the member.
// we can define a descriptor. The descriptor allows us to define a new getter and setter for the Decorator. With our custom getter and setter, we can apply our custom logic for our Decorator.
// ----------------------------------------------------------------
// https://www.typescriptlang.org/docs/handbook/decorators.html
// https://fireship.io/lessons/ts-decorators-by-example/

// https://coryrylan.com/blog/introduction-to-typescript-property-decorators


// Requires enabling of `experimentalDecorators`

function DefaultName(constructorFunction: Function) {
  console.log('----invoking decorator function here----');
  constructorFunction.prototype.name = "Changed by decorator";
}

@DefaultName
class Employee {
  name: string;
  constructor(name?: string) {
    console.log('----Inovking constructor here----');
    if(name)
      this.name=name;
  }
}
console.log('----Instance creation here----');
let employee: Employee = new Employee();
console.log(`${employee.name}`);

console.log('----another Instance creation ----');
let employee2: Employee = new Employee("ITI");
console.log(`${employee2.name}`);

