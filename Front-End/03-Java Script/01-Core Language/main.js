/* Some JS concept */

// window.alert("Hello From Js File");

// document.write("<h3 style=color:red;>Hello from JS File !!</h3>");

// console.log("Hello From Js File to Console !");

// console.error("Error From Js file to Console !")

// console.table(["mahmoud","khaled","mohamed"]);

// console.log("Hello again from %cJs file to Console !","color:red;")

//------------------------------------------------------------------------------

/*  Data Types  */

// console.log( typeof"mahmoud Khaled"); //String
// console.log( typeof (100)); //Number
// console.log( typeof (100.5));//Number
// console.log( typeof [10,5,6,5]);//Array => object
// console.log( typeof {name:"mahmoud",age:23,country:"Egypt"}); //Object 
// console.log( typeof true);//boolean
// console.log( typeof null); //object
//------------------------------------------------------------------------------

/*  Variables  
    note : Java Script is Loosely typed language so we don't need to specifiy type of variable 
*/
/*
  Var
  - Redeclare (Yes)
  - Access Before Declare (Undefined)
  - Variable Scope Drama [Added To Window] ()
  - Block Or Scope Function

  Let
  - Redeclare (No => Error)
  - Access Before Declare (Error)
  - Variable Scope Drama ()
  - Block Or Scope Function

  Const
  - Redeclare (No => Error)
  - Access Before Declare (Error)
  - Variable Scope Drama ()
  - Block Or Scope Function
*/

// const pi = 3.14

// pi = 1 
// //cannot do this becuase with const you cannot change the value

// //___________________


// //Let --> is block level 

// for(let i = 0; i < 3; i++) {
// console.log(i) //--> it will console here
// }
// console.log(i)// ---> Not here


// //----------------------

// //Var is for variables available to the entire function 


// for(var j = 0; j < 3; j++) {
// console.log(j)// --> it will console here
// }
// console.log(j) //---> it will console here

//------------------------------------------------------------------------------

/*String Syntax And Character Escape Sequence*/

//console.log("mahmoud"); //valid 
//console.log('mahmoud'); //valid 
//console.log('mahmoud 'khaled''); //invalid 
// console.log("mahmoud 'khaled'"); //valid 
// console.log('mahmoud "khaled"'); //valid 
// console.log('mahmoud \'khaled\''); //valid
// console.log("mahmoud \
// khaeld \
// mohamed");
// console.log("What is your name \n mahmoud ?"); //(\n) new line 
// var namee="mahmoud";
// var lastName="khaled";
// console.log(namee+" "+lastName); //Concatenation
// console.log(`${namee} ${lastName}`); //Concatenation also 

// let markUp=`
// <div class="card">
//     <div class="child">
//         <h2>${namee}</h2>
//         <p>${lastName}</p>
//     </div>
// </div>    
// ;`
// document.write(markUp);

// let ti="ElAero",de="ElZero Web School",da="25/10";

// var markUp=`    
// <div>
//     <h3>${ti}</h3>
//     <p>${de}</p>
//     <span>${da}</span>
// </div>
// `
// document.write(markUp.repeat(4)); // repeat it 4 time

//------------------------------------------------------------------------------