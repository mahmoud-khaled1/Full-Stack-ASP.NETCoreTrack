// Decorators provide a way to add both annotations and a meta-programming syntax for class declarations and members.
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
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
// https://www.typescriptlang.org/docs/handbook/decorators.html#method-decorators
// https://fireship.io/lessons/ts-decorators-by-example/
// https://coryrylan.com/blog/introduction-to-typescript-property-decorators
// // ----------
// //Real World Use Case: When a class is decorated you have to be careful with inheritence because its decendents will not inherit the decorators. 
// //Let’s freeze the class to prevent inheritence completely.
// function Frozen(constructor: Function) {
//   Object.seal(constructor);
//   Object.seal(constructor.prototype);
//   // The Object.freeze() method freezes an object. 
//   // A frozen object can no longer be changed; freezing an object prevents new properties from being added to it, existing properties from being removed, prevents changing the enumerability, configurability, or writability of existing properties, and prevents the values of existing properties from being changed. In addition, freezing an object also prevents its prototype from being changed. freeze() returns the same object that was passed in.
// }
// @Frozen
// class Parent {
//   parentX:number=10;
// }
// console.log(Object.isFrozen(Parent)); // true
// class Child extends Parent {// cannot be extended
//   childY:number=20;
// } 
// let c=new Child();
// console.log(c.parentX);
////////////////////////////////////////
// Requires enabling of `experimentalDecorators`
// http://www.typescriptlang.org/docs/handbook/decorators.html
function DefaultName(constructorFunction) {
    console.log('----invoking decorator function here----');
    constructorFunction.prototype.name = "Changed by decorator";
}
var Employee = /** @class */ (function () {
    function Employee(name) {
        console.log('----Inovking constructor here----');
        if (name)
            this.name = name;
    }
    Employee = __decorate([
        DefaultName
    ], Employee);
    return Employee;
}());
console.log('----Instance creation here----');
var employee = new Employee();
console.log("".concat(employee.name));
console.log('----another Instance creation ----');
var employee2 = new Employee("ITI");
console.log("".concat(employee2.name));
