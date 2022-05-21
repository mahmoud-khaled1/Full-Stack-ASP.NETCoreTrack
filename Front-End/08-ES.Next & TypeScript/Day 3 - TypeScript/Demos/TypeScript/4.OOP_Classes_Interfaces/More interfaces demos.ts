// /*
// Interfaces are used to type-check whether an object fits a certain structure. 
// By defining an interface we can name a specific combination of variables, 
// making sure that they will always go together. 
// When compiled to JavaScript, interfaces disappear - their only purpose is to help in the development stage.
// */
// // Here we define our  interface, its properties, and their types.
// interface IPerson { 
//   firstName:string, 
//   lastName:string, 
//   age?:number, //optional
//   sayHi: ()=>string 
// };

// interface IPayable
// {
//   salary:number;
// }

// class Person
// {
//   protected uID;
// }

// class Emp extends Person implements IPerson,IPayable
// {
//   firstName: string;
//   lastName: string;
//   jobTitle:string;
//   salary:number;
//   sayHi():string
//   {
//     return "Hi"
//   }

//   showID()
//   { 
//     return this.uID
//   }
// }

// let e111=new Emp();
// e111.firstName="sdfsd";

// var p:IPerson={
//   firstName:"aa",
//   lastName:"bb",
//   //jobTitle:"sfds",
//   //age:19,
//   sayHi:()=>"Hi"
// }

// class Employee implements IPerson
// {
//   firstName: string;
//   lastName: string;
//   jobTitle:string;

//   sayHi: () => "Hi";
// }

// class Trainee implements IPerson
// {
//   firstName: string;
//   lastName: string;
//   grade:number;
//   sayHi: () => "Hi";

// }
// /////////
// interface ICreature
// {
//   Age: number;
// }

// class LeaderStudent
// {
//   GroupLeaded: string;
// }

// class Student extends LeaderStudent 
//               implements IPerson,ICreature 
// {
//   constructor(){
//     super();
//     this.Faculty="FCI";
//   }

//   firstName="";  
//   lastName="";
//   Age=18;
//   Faculty: string;
//   sayHi(): string
//   {
//     return `Hi, I am Student, 
//       and my Name: ${this.firstName}`
//   }
// }

// let s1=new Student();
// s1.firstName="ALi";
// s1.GroupLeaded="G1";

// //------------------------------------------//
// var customer:IPerson = { 
//   firstName:"Tom",
//   lastName:"Hanks", 
//   //age: 12,// will not work
//   sayHi: ():string =>{return "Hi there"} 
// } 

// let client:IPerson;
// client={
//   firstName:"aa",
//   lastName:"bb",
//   //jobTitle:"Developer",
//   sayHi: ()=> "Hi"
// }

// /*var customer:IPerson = { 
//   firstName:"Tom",
//   lastName:"Hanks", 
// } */ //error not implemented function.
// console.log("Customer Object ") 
// console.log(customer.firstName) 
// console.log(customer.lastName) 
// console.log(customer.sayHi())  

// var employee:IPerson = { 
//    firstName:"Jim",
//    lastName:"Blakes", 
//    sayHi: ():string =>{return "Hello!!!"} 
// } 
// console.log("Employee  Object ") 
// console.log(employee.firstName) 
// console.log(employee.lastName)

// //Another interface
// interface Food {
//     name: string;
//     calories: number;
// }

// //Making object from interface
// var seafood2:Food;//={name:"fish",calories:20};

// seafood2.name="";
// seafood2.calories=20;


// //or you can cast the object as interface type
// var seaFood= {} as Food;
// // var seeFood:Food;
// seaFood.name="fish";
// seaFood.calories=10;

// // We tell our function to expect an object that fulfills the Food interface. 
// // This way we know that the properties we need will always be available.
// function speak(food: Food): void{
//   console.log("Our " + food.name + " has " + food.calories + " calories.");
// }

// // We define an object that has all of the properties the Food interface expects.
// // Notice that types will be inferred automatically.
// var ice_cream = {
//   name: "ice cream", 
//   calories: 200
//   //,uu:200
// }

// speak(ice_cream);

// //The order of the properties does NOT matter. 
// //We just need the required properties to be present and to be the right type. 
// //If something is missing, has the wrong type, or is named differently, the compiler will warn us.
// var cake = {
//     name: "ice cream",
//     //calories: 200
//   }
// //speak(cake);//Error: Argument of type '{ name: string; }' is not assignable to parameter of type 'Food'.Property 'calories' is missing in type '{ name: string; }'.

// //Classes can implement interfaces
// class HealthyFood implements Food{
//   //will make error if we don't add the interface members
//   name:string;
//   calories:number;
//   category:string;
// }

// //Interfaces and Inheritance
//   //An interface can be extended by other interfaces. 
//   //In other words, an interface can inherit from other interface. 
//   //Typescript allows an interface to inherit from multiple interfaces
// interface Person { 
//   age:number 
// } 
// interface Musician extends Person { 
//   instrument:string,
// } 
// var drummer: Musician; 
// drummer.age = 27 
// drummer.instrument = "Drums" 
// console.log("Age:  "+drummer.age) 
// console.log("Instrument:  "+drummer.instrument)

// //Multiple Interface Inheritance
// interface IParent1 { 
//   v1:number 
// } 
// interface IParent2 { 
//   v2:number 
// } 
// interface Child extends IParent1, IParent2 { v3:number} 
// //var Iobj:Child = { v1:12, v2:23} 
// console.log("value 1: "+this.v1+" value 2: "+this.v2)