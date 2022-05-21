// /*
// When building large scale apps, the object oriented style of programming 
// is preferred by many developers, most notably in languages such as Java or C#. 
// TypeScript offers a class system that is very similar to the one in these 
// languages, including inheritance, abstract classes, interface implementations, setters/getters, and more.

// It's also fair to mention that since the most recent JavaScript update 
// (ECMAScript 2015), classes are native to vanilla JS and can be used 
// without TypeScript. The two implementation are very similar but have their 
// differences, TypeScript being a bit more strict.
// */
// //Declaring a class
// class Car { 
//   private ChasisNo:number;
//   protected MotorNo:number;
//   //public fields (By default public)
//   engine:string; 
//   public wheel:number;
//   //private fileds
  
//   //constructor 
//   constructor(engine:string) { 
//      this.engine = engine;
//   }  
//   //function 
//   disp():void { 
//      console.log("Engine is  :   "+this.engine) 
//   } 
// }

// //Creating Instance objects
// var obj = new Car("Engine 1")
// //var obj2=new Car();
// //access the field 
// console.log("Reading attribute value Engine as :  "+obj.engine)  
// //access the function
// obj.disp()

// //--------------------------------------------------------------------//
// //Inheritance
//   //TypeScript allow single inheritance, multi-level inheritance.
//   //BUT DON'T allow multiple inheritance.
// class Root { 
//   str:string; 
// } 
// class Child extends Root {
//   str2:string;
// } 
// class Leaf extends Child {
//   str3:string;
// } //indirectly inherits from Root by virtue of inheritance  
// var obj2 = new Leaf(); 
// obj2.str ="hello" 
// console.log(obj2.str) 

// //------------------------------------------------------------//
// class VanCar0
// {
// //  public model:string;
// //  private plateNo:string;

//   constructor(public model:string, private plateNo:string)
//   {
//   //  this.model=model;
//   //  this.plateNo=plateNo;
//   }

//   print()
//   {
//     console.log(`Car Model: ${this.model}, and Plate No.: ${this.plateNo}`)
//   }
// }

// let v1=new VanCar0("Renault", "123");
// console.log(v1.model); //Renault
// ////////////////////////
// class VanCar1 
// {
//  public model:string;
//  private plateNo:string;

//   constructor( model:string="",  plateNo:string="")
//   {
//    this.model=model;
//    this.plateNo=plateNo;
//   }
// }

// var car1=new VanCar1();
// ///////

// class VanCar 
// {
//   //public Model:string;
//   //private plateNo: string;

//   constructor(public Model?:string, private plateNo?:string)
//   {
//     //this.Model=Model;
//     //this.plateNo=plateNo;
//   }
// }

// var van1 =new VanCar();
// var van2 = new VanCar("Renault", "ABC - 2356");
// console.log(van2.Model);
// //----------------//

// //Complete example
// class Menu {
//   // Our properties:
//   // By default they are public, but can also be private or protected.
//   items: Array<string>;// string[]  // The items in the menu, an array of strings.
//   pages: number;         // How many pages will the menu be, a number.
//   // A  constructor. 
//   constructor(item_list: Array<string>, total_pages: number) {
//     // The this keyword is mandatory.
//     this.items = item_list;    
//     this.pages = total_pages;
//   }
//   // Methods
//   list(): void {
//     console.log("Our menu for today:");
//     for(var i=0; i<this.items.length; i++) {
//       console.log(this.items[i]);
//     }
//   }

// }

// console.log("Classes...");
// // Create a new instance of the Menu class.
// var sundayMenu = new Menu(["pancakes","waffles","orange juice"], 1);

// // Call the list method.
// sundayMenu.list();


// //Inheritance & Overloading
// class HappyMeal extends Menu {
//   // Properties are inherited
//   //we can add more properties
//   toy: string;  
//   // A new constructor has to be defined.
//   constructor(item_list: Array<string>, total_pages: number,toy:string) {
//     // In this case we want the exact same constructor as the parent class (Menu), 
//     // To automatically copy it we can call super() - a reference to the parent's constructor.
//     super(item_list, total_pages);
//     this.toy=toy;
//   }
//   // Just like the properties, methods are inherited from the parent.
//   // However, we want to override the list() function so we redefine it.
//   list(): void{
//     //console.log(this.pages);
//     console.log("special children menu:");
//     super.list();
//     console.log("A gift toy is provided: " + this.toy);
//   }
// }
// console.log("------------------------------");
// console.log("Inheritance...");
// // Create a new instance of the HappyMeal class.
// var menu_for_children = new HappyMeal(["candy","drink","kids Burger"], 1,"puzzle");

// // This time the log message will begin with the special introduction.
// menu_for_children.list();

// //-----------------------------------------------------//
// //static members
//   //A static variable retains its values till the program finishes execution. 
//   //Static members are referenced by the class name.
// class StaticMem {  
//   static num:number; 
//   static disp():void { 
//      console.log("The value of num is"+ StaticMem.num) 
//   } 
// } 

// StaticMem.num = 12     // initialize the static variable 
// StaticMem.disp()      // invoke the static method

// //-----------------------------------------------------//
// //Data Hiding
//   //A public data member has universal accessibility. Data members in a class are public by default.
//   //Private data members are accessible only within the class that defines these members.
//   //A protected data member is accessible by the members within the same class as that of the former and also by the members of the child classes.
// class Encapsulate { 
//   str:string = "hello" 
//   private str2:string = "world"
//   protected str3:string 
// }
// var obj3 = new Encapsulate() 
// console.log(obj3.str)     //accessible 
// //console.log(obj3.str2)   //compilation Error as str2 is private
// //console.log(obj3.str3)

// class EncapsulateChild extends Encapsulate{
//   display(){
//     console.log(this.str);
//     console.log(this.str3)
//     //console.log(this.str2)
//   }
// }
// //Classes can implement interfaces
// interface Food {
//   name: string;
//   calories: number;
// }
// class HealthyFood2 implements Food{
//   //will make error if we don't add the interface members
//   name:string;
//   calories:number;
// }
// ///////////////////////////////////////

// class Test
// {
//   a: number;
//   b: number;
//   constructor(a:number,b:number)
//   {
//     this.a=a;
//     this.b=b;
//   }
// }

// let t= new Test(10,20);
// alert(t.a);


// class Test2
// {
//   //a: number;
//   //b: number;
//   constructor(public a:number, public b:number)
//   {
//     //this.a=a;
//     //this.b=b;
//   }
// }
// let t2= new Test2(10,20);
// alert(t2.a);

// //For a more in-depth look at classes in TS you can read the documentation:
//   //http://www.typescriptlang.org/docs/handbook/classes.html
