
//Types With functions
function greeter(person: string) {
    return "Hello, " + person;
}

function greeter2(person: string):string {
   return "Hello, " + person;
}

function greeter02(person: string):void {
   console.log("Hello, " + person);
   //return 33;
}
//Correct call:
greeter("test");
//greeter(1);
//document.body.innerHTML = greeter("ITI");
//sending different data type:
//let user = [0, 1, 2];//error TS2345: Argument of type 'number[]' is not assignable to parameter of type 'string'.
//document.body.innerHTML = greeter(user);

//trying to call the function without argument:
//document.body.innerHTML = greeter();//Error: [ts] Expected 1 arguments, but got 0.


//Union Type and function parameter
function disp2(name:string|string[]):void { 
    if(typeof name == "string") { 
       console.log(name) 
    } else {       
       for(let i = 0;i<name.length;i++) { 
          console.log(name[i])
       } 
    } 
 } 

 disp2("mark");
 console.log("Printing names array....");
 disp2(["Mark","Tom","Mary","John"]);
 //disp2(10);//error


//Function return type:
function greeter3(person: string) : string {
    //return 10; //will not accept return different data type
    return "Hello, " + person;
}

function greeter4(person: string) : void {
   console.log("Hello, " + person);
   //return "Hello, " + person;// will not allow void function to return value
}
//Default parameters
function sum(n1:number, n2:number, n3:number=0):number
{
   return n1+n2+n3;
}

sum(4,5);
sum(3,4,5);
//Default parameters
function sum3Num(n1:number, n2:number, n3:number=0)
{
   return n1+n2+n3;
}
sum3Num(1,2,3);
sum3Num(1,2);

//Optional parameters
//you can mark the parameter as optional by using  ? after it
function sum2(n1:number, n2:number, n3?:number):number
{
   if(n3==undefined)
      return n1+n2;
   else
      return n1+n2+n3;
}

sum2(2,3);
sum(2,3,4);

// function foo(bar: number, bas?: string): void {
//    if(bas!="undefined") 
//       console.log(bar, bas);
//    else
//       console.log(bar);
// }
// foo(123);
// foo(123, 'hello');
//foo();//error

// //Alternatively you can even provide a default value (using = someValue after the parameter declaration) which will get injected for you if the caller doesn't provide that argument:
// function foo2(bar: number, bas: string = 'hello') {
//     console.log(bar, bas);
// }
// foo(123);           // 123, hello
// foo(123, 'world');  // 123, world

//Rest parameters
//Rest parameters are similar to variable arguments in Java. 
//Rest parameters don’t restrict the number of values that you can pass to 
//a function. However, the values passed must all be of the same type. 
//In other words, rest parameters act as placeholders for multiple arguments of the same type.

function addNumber0(arr:number[])
{
   var sum:number = 0; 
    
   for(let i = 0;i<arr.length;i++) { 
      sum = sum + arr[i]; 
   } 
   console.log("sum of the numbers",sum) 
}
addNumber0([1,2,3,5]);
///////
function addNumbers(...nums:number[]):void {     
    var sum:number = 0; 
    
    for(let i = 0;i<nums.length;i++) { 
       sum = sum + nums[i]; 
    } 
    console.log("sum of the numbers",sum) 
 } 
 addNumbers(1,2,3);
 addNumbers(10,10,10,10,10);
 addNumbers(3,4,4,4,44,4);

 //Anonymous Function
 //Functions that are not bound to an identifier (function name) are called 
 //as anonymous functions. 
 //These functions are dynamically declared at runtime. 
 //Anonymous functions can accept inputs and return outputs, just as standard functions do. 
 //An anonymous function is usually not accessible after its initial creation.
 var msg = function() { 
    return "hello world";  
 } 
 console.log(msg())

 //Anonymous function with parameters
 var res2 = function(a:number,b:number) { 
    return a*b;  
 }; 
 console.log(res2(12,2)) 


 //Lambda Expression
 //Lambda refers to anonymous functions in programming. 
 //Lambda functions are a concise mechanism to represent anonymous functions. 
 //These functions are also called as Arrow functions.
 var foo3 = (x:number)=>10 + x;
console.log(foo3(100));      //outputs 110 

//Empty parentheses for no parameter
var disp =()=> { 
    console.log("Function invoked"); 
 } 
 disp();

//Optional parentheses for a single parameter
var display = x=> { 
    console.log("The function got "+x); 
 } 
 display(12);
 
//////////////////////
 //Function Overloads
 //To overload a function in TypeScript, you need to follow the steps given below
    //Step 1 − Declare multiple functions with the same name but different function signature. 
        //Function signature includes the following:
            //The data type of the parameter
            //The number of parameters
            //The sequence of parameters
    //Step 2 − The declaration must be followed by the function definition. 
        //The parameter types should be set to any if the parameter types differ during overload. 
        //Additionally,  you may consider marking one or more parameters as optional during the function definition.
    //Step 3 − Finally, you must invoke the function

  // Step1: Declare function overloads
  function testFun(s1:string):void; 
  function testFun(n1:number):void; 
  function testFun(n1:number,s1:string):void;
  function testFun(n1:number,s2:number,n3:number ):void;
  
    //step2: function definition
    function testFun(x:string|number,y?:string|number,z?:number):void { 
       console.log(x);
       if (y!= undefined )
         console.log(y); 
      if (z!= undefined )
         console.log(y); 
    } 

    //Step3: calling function
    testFun("asd");
    testFun(10);
    testFun(1,"xyz");
    testFun(10,20,30);
    
   
    //testFun(1,2);
    //testFun();//Not allowed overload
    
    

    

    




