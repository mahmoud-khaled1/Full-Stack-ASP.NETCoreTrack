/*Type annotations in TypeScript are lightweight ways to record the intended 
contract of the function or variable.
This means that you can declare the types of variables, and the compiler will 
make sure that they aren't assigned the wrong types of values.

Here are some of the most commonly used data types:
    - Number - All numeric values are represented by the number type, there aren't separate definitions for integers, floats or others.
    - String - The text type, just like in vanilla JS strings can be surrounded by 'single quotes' or "double quotes".
    - Boolean - true or false, using 0 and 1 will cause a compilation error.
    - Any - A variable with this type can have it's value set to a string, number, or anything else.
    - Arrays - Has two possible syntaxes: my_arr: number[]; or my_arr: Array<number>.
    - Void - Used on function that don't return anything.
    - Bigint
    - Symbol

list of all of the available types:
    http://www.typescriptlang.org/docs/handbook/basic-types.html

Types are removed when compiled to JS, it's only for help in development phase.
*/
//Decalring variables:
var a;//will be of type any.
a="asd";//type will be string
a=10;//allowed, variable by default is Any
a=true;

var d:any;
d=10;
d="asd";
d=true;

var aa="test";//type will be detected from assigned value.

//var aa:string="test";
//aa=10;//not allowed changing the variable type

var b:string;
//b=123;//will not work

var bb:string="test";
//var bb:string=123;//will not work

var x;// of Type any
var xx:any;// of type any


let c:Number=0;
let c2=0;
//c="sss"; //Will not work
// c=false;

//Not allowed using variable without declaration.
//e=10;


//Union
//combine one or two types
//written as a sequence of types separated by vertical bars.
var val:string|number;
val = 12;
val="rr";
//val=true;
console.log("numeric value of val "+val); 
val = "This is a string"; 
console.log("string value of val "+val);
//val=true;// Will not work
//////////////////////////////
var res:string | string[];
res="test";
res=['aa', 'bb', 'cc'];
//res=10; Will not work
//res=[1,2,3]; will not work

//Union Type and Arrays
var arr:number[]|string[]; 
arr = [1,2,4]; 
arr = ["Cairo","Assiut","Minia"];
//arr = [1,"j",4]; //Not Alowed
//arr=2; //Not allowed
//arr=[true, false,true]; //Not Allowed
//---------------------------------------------------------//

//Arrays
//var array_name[:datatype];        //declaration 
//array_name = [val1,val2,valn..]   //initialization
var alphas:string[]; //Array of string
alphas = ["1","2","3","4"] 
//alphas=[1,2,3]; not allowed
//alphas[4]=1;//not allowed

var myArr: any[];// Tuple
var myArr2=[];//array of any // Tuple

myArr=[1,2,3];
myArr=['a','b', 'c'];
myArr=[1, 'a', true];
//myArr="test"; // Will not work

var alphas2=["1","2","3","4"]; //Array of string with initialization.
//alphas2[4]=1;//not allowed
console.log(alphas[0]); 
console.log(alphas[1]);

var result: string | string[];
result="str";
result=["a","b","c"];

//--------------------------------------------------------//
//Tuples
//It represents a heterogeneous collection of values. 
//In other words, tuples enable storing multiple fields of different types. 
//Tuples can also be passed as parameters to functions.
//You can also declare an empty tuple and initialize it later
var mytuple2:any[];
var mytuple2 = []; 
var mytuple = [10,"Hello"]; //create a  tuple 

mytuple2[0] = 120 
mytuple2[1] = "asd"
console.log(mytuple[0]) 
console.log(mytuple[1])

let arr66: [number, string, string, boolean];
let arr77:[];
arr66=[1,"a","b", true];
//arr66=[1,"a"];


/////////////////////////////////////////////////////////////
//Objects
    //An object is an instance which contains set of key value pairs. 
    //The values can be scalar values or functions or even array of other objects. 
    
    //Object Literal Notation
    var person = { 
        firstName:"Tom", 
        lastName:"Hanks" 
     }; 
    //access the object values 
    console.log(person.firstName); 
    console.log(person.lastName);

     //In case you want to add some value to an object, JavaScript allows you to make the necessary modification.
    //If you use the same code in Typescript the compiler gives an error.   
    //person.sayHello = function(){ return "hello";}//Compilation error
    
    //You can define as a type template:
    var person2 = {
        firstName:"Tom", 
        lastName:"Hanks", 
        sayHello:function() {  }  //Type template 
     } 
     person2.sayHello = function() {  
        console.log("hello "+person.firstName)
     }  
     
     person2.sayHello()




