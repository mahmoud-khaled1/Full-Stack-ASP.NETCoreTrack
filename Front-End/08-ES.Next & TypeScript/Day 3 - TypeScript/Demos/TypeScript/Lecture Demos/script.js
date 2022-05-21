// function HelloTS(title: string): string {
//     return `Hello world, ${title}`;
// }
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
// let helloWorld: string = HelloTS("From ITI");
// console.log(helloWorld);
// let x1: number;
// let x2: number = 3;
// let x3 = 10;//number
// // x3="a";
// let y1: any;
// let y2;//any
// y2 = 22;
// y2 = "aa";
// y1 = true;
// let z1: string | null;
// z1 = null;
// z1 = "aa";
// // z1=true;
// let arr1: string[] | number[];
// let arr2: Array<string>;
// let arr3 = ["aa", "ss", "dd"];
// //arr3.push(1);
// arr1 = [1, 2, 3];
// arr1 = ["a", "b", "c"];
// //arr1=[1,2,"a"];
// let t1: any[]; //tuple
// let t2 = []; //tuple
// let t3: [];
// let t4: [number, string, number];
// t2 = [1, 2, "a", true]
// t4 = [1, "a", 2];
// //t3=[2,3]
// //////
// function helloWorld2(title: string | string[]): void {
//     if (typeof title == 'string')
//         console.log(`Hello, ${title}`);
//     else
//         console.log(...title);
// }
// helloWorld2("TS");
// helloWorld2(["JS", "TS"]);
// function addNumbers(n1: number, n2: number, n3: number = 0): number //Parameter with default value
// {
//     return n1 + n2 + n3;
// }
// addNumbers(2, 3);
// addNumbers(2, 3, 5);
// function addNumbers2(n1: number, n2: number, n3?: number): number //optional parameter
// {
//     let result = (n3 == undefined) ? n1 + n2 : n1 + n2 + n3;
//     return result;
//     // if (n3 == undefined)
//     //     return n1 + n2;
//     // else
//     //     return n1 + n2 + n3;
// }
// addNumbers2(1, 2);
// addNumbers2(1, 2, 3);
/////////////////////////////////////////////////////
var Person = /** @class */ (function () {
    function Person(name, phoneNo) {
        this.name = name;
        //this.age=age;
        this.phoneNo = phoneNo;
    }
    Person.prototype.show = function () {
        console.log("Person Name: ".concat(this.name, ", \n            and his phone mumber: ").concat(this.phoneNo));
    };
    Person.whoAmI = function () {
        console.log("I am a Person");
    };
    return Person;
}());
var Person2 = /** @class */ (function () {
    // protected age:number;
    // public name:string;
    // phoneNo:string; //public
    function Person2(name, age, phoneNo) {
        this.name = name;
        this.age = age;
        this.phoneNo = phoneNo;
        // this.name=name;
        // this.age=age;
        // this.phoneNo=phoneNo;
    }
    Person2.prototype.show = function () {
        console.log("Person Name: ".concat(this.name, ", \n            his age: ").concat(this.age, ",\n            and his phone mumber: ").concat(this.phoneNo));
    };
    Person2.whoAmI = function () {
        console.log("I am a Person");
    };
    return Person2;
}());
var Evaluation;
(function (Evaluation) {
    Evaluation[Evaluation["Excellent"] = 1] = "Excellent";
    Evaluation[Evaluation["Verygood"] = 2] = "Verygood";
    Evaluation[Evaluation["Good"] = 3] = "Good";
    Evaluation[Evaluation["Fair"] = 4] = "Fair"; //4
})(Evaluation || (Evaluation = {}));
var Employee = /** @class */ (function (_super) {
    __extends(Employee, _super);
    function Employee(name, phoneNo, jobTitle) {
        var _this = _super.call(this, name, phoneNo) || this;
        _this.salary = 1000;
        _this.jobTitle = jobTitle;
        return _this;
    }
    Employee.prototype.show = function () {
        {
            _super.prototype.show.call(this);
            console.log("Job title: ".concat(this.jobTitle));
        }
    };
    Employee.prototype.getPaid = function () {
        return this.salary;
    };
    return Employee;
}(Person));
// let e1= new Employee("AA", "111", "Developer");
// e1.show();
var Professor = /** @class */ (function (_super) {
    __extends(Professor, _super);
    function Professor(name, phoneNo, degree) {
        var _this = _super.call(this, name, phoneNo) || this;
        _this.salary = 5000;
        _this.bonus = 500;
        _this.degree = degree;
        return _this;
    }
    Professor.prototype.show = function () {
        {
            _super.prototype.show.call(this);
            console.log("degree: ".concat(this.degree));
            console.log("Evalutaion: ".concat(Evaluation[this.eval]));
        }
    };
    Professor.prototype.getPaid = function () {
        return this.salary + this.bonus;
    };
    return Professor;
}(Person));
var Student = /** @class */ (function (_super) {
    __extends(Student, _super);
    function Student(name, phoneNo, GPA) {
        var _this = _super.call(this, name, phoneNo) || this;
        _this.GPA = GPA;
        return _this;
    }
    Student.prototype.show = function () {
        {
            _super.prototype.show.call(this);
            console.log("GPA: ".concat(this.GPA));
        }
    };
    return Student;
}(Person));
var meat = {
    name: 'meat',
    calories: 100
    //, type: "Meat"
};
var prods;
prods = [{ name: 'Laptop', price: 100, quantity: 10 },
    { name: 'Mobile', price: 200, quantity: 20 },
    { name: 'Tablet', price: 300, quantity: 30 }];
