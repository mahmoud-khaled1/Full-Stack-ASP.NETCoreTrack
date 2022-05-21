//Types With functions
function greeter(person) {
    return "Hello, " + person;
}
//Correct call:
document.body.innerHTML = greeter("ITI");
//sending different data type:
//let user = [0, 1, 2];//error TS2345: Argument of type 'number[]' is not assignable to parameter of type 'string'.
//document.body.innerHTML = greeter(user);
//trying to call the function without argument:
//document.body.innerHTML = greeter();//Error: [ts] Expected 1 arguments, but got 0.
//Union Type and function parameter
function disp2(name) {
    if (typeof name == "string") {
        console.log(name);
    }
    else {
        var i;
        for (i = 0; i < name.length; i++) {
            console.log(name[i]);
        }
    }
}
disp2("mark");
console.log("Printing names array....");
disp2(["Mark", "Tom", "Mary", "John"]);
//disp2(10);//error
//Function return type:
function greeter2(person) {
    //return 10; //will not accept return different data type
    return "Hello, " + person;
}
//Optional parameters
//you can mark the parameter as optional by using  ? after it
function foo(bar, bas) {
    console.log(bar, bas);
}
foo(123);
foo(123, 'hello');
//foo();//error
//Alternatively you can even provide a default value (using = someValue after the parameter declaration) which will get injected for you if the caller doesn't provide that argument:
function foo2(bar, bas) {
    if (bas === void 0) { bas = 'hello'; }
    console.log(bar, bas);
}
foo(123); // 123, hello
foo(123, 'world'); // 123, world
//Rest parameters
//Rest parameters are similar to variable arguments in Java. 
//Rest parameters don’t restrict the number of values that you can pass to 
//a function. However, the values passed must all be of the same type. 
//In other words, rest parameters act as placeholders for multiple arguments of the same type.
function addNumbers() {
    var nums = [];
    for (var _i = 0; _i < arguments.length; _i++) {
        nums[_i] = arguments[_i];
    }
    var i;
    var sum = 0;
    for (i = 0; i < nums.length; i++) {
        sum = sum + nums[i];
    }
    console.log("sum of the numbers", sum);
}
addNumbers(1, 2, 3);
addNumbers(10, 10, 10, 10, 10);
//Anonymous Function
//Functions that are not bound to an identifier (function name) are called 
//as anonymous functions. 
//These functions are dynamically declared at runtime. 
//Anonymous functions can accept inputs and return outputs, just as standard functions do. 
//An anonymous function is usually not accessible after its initial creation.
var msg = function () {
    return "hello world";
};
console.log(msg());
//Anonymous function with parameters
var res = function (a, b) {
    return a * b;
};
console.log(res(12, 2));
//Lambda Expression
//Lambda refers to anonymous functions in programming. 
//Lambda functions are a concise mechanism to represent anonymous functions. 
//These functions are also called as Arrow functions.
var foo3 = function (x) { return 10 + x; };
console.log(foo(100)); //outputs 110 
//Empty parentheses for no parameter
var disp = function () {
    console.log("Function invoked");
};
disp();
//Optional parentheses for a single parameter
var display = function (x) {
    console.log("The function got " + x);
};
display(12);
//step2: function definition
function testFun(x, y, z) {
    console.log(x);
    console.log(y);
}
//Step3: calling function
testFun("abc");
testFun(10);
//testFun();//Not allowed overload
testFun(1, "xyz");
