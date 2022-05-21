// // function HelloTS(title: string): string {
// //     return `Hello world, ${title}`;
// // }

// // let helloWorld: string = HelloTS("From ITI");
// // console.log(helloWorld);

// // let x1: number;
// // let x2: number = 3;
// // let x3 = 10;//number
// // // x3="a";

// // let y1: any;
// // let y2;//any

// // y2 = 22;
// // y2 = "aa";
// // y1 = true;

// // let z1: string | null;
// // z1 = null;
// // z1 = "aa";
// // // z1=true;

// // let arr1: string[] | number[];
// // let arr2: Array<string>;
// // let arr3 = ["aa", "ss", "dd"];

// // //arr3.push(1);
// // arr1 = [1, 2, 3];
// // arr1 = ["a", "b", "c"];
// // //arr1=[1,2,"a"];

// // let t1: any[]; //tuple
// // let t2 = []; //tuple
// // let t3: [];
// // let t4: [number, string, number];

// // t2 = [1, 2, "a", true]
// // t4 = [1, "a", 2];
// // //t3=[2,3]
// // //////
// // function helloWorld2(title: string | string[]): void {
// //     if (typeof title == 'string')
// //         console.log(`Hello, ${title}`);
// //     else
// //         console.log(...title);
// // }

// // helloWorld2("TS");
// // helloWorld2(["JS", "TS"]);

// // function addNumbers(n1: number, n2: number, n3: number = 0): number //Parameter with default value
// // {
// //     return n1 + n2 + n3;
// // }

// // addNumbers(2, 3);
// // addNumbers(2, 3, 5);

// // function addNumbers2(n1: number, n2: number, n3?: number): number //optional parameter
// // {
// //     let result = (n3 == undefined) ? n1 + n2 : n1 + n2 + n3;
// //     return result;
// //     // if (n3 == undefined)
// //     //     return n1 + n2;
// //     // else
// //     //     return n1 + n2 + n3;
// // }

// // addNumbers2(1, 2);
// // addNumbers2(1, 2, 3);
// /////////////////////////////////////////////////////

// class Person
// {
//     private id:number;
//     protected age:number;
//     public name:string;
//     phoneNo:string; //public

//     constructor(name:string,  phoneNo: string)
//     {
//         this.name=name;
//         //this.age=age;
//         this.phoneNo=phoneNo;
//     }

//     show()
//     {
//         console.log(`Person Name: ${this.name}, 
//             and his phone mumber: ${this.phoneNo}`);
//     }

//     static whoAmI()
//     {
//         console.log("I am a Person");
//     }
// }

// class Person2
// {
//     private id:number;
//     // protected age:number;
//     // public name:string;
//     // phoneNo:string; //public

//     constructor(public name:string, protected age:number, public phoneNo: string)
//     {
//         // this.name=name;
//         // this.age=age;
//         // this.phoneNo=phoneNo;
//     }

//     show()
//     {
//         console.log(`Person Name: ${this.name}, 
//             his age: ${this.age},
//             and his phone mumber: ${this.phoneNo}`);
//     }

//     static whoAmI()
//     {
//         console.log("I am a Person");
//     }
// }

// interface IPayable
// {
//     salary:number;
//     bonus?:number;
//     getPaid: ()=>number;
// }

// enum Evaluation
// {
//     Excellent=1, //1
//     Verygood, //2
//     Good, //3
//     Fair //4
// }

// interface IEvaluated
// {
//     eval:Evaluation;
//     comment?:string;
// }

// class Employee extends Person implements IPayable
// {
//     jobTitle:string;
//     salary:number=1000;
//     constructor(name:string, phoneNo:string, jobTitle:string)
//     {
//         super(name,phoneNo);
//         this.jobTitle=jobTitle;
//     }

//     show(): void {
//         {
//             super.show();
//             console.log(`Job title: ${this.jobTitle}`);
//         }
//     }

//     getPaid():number
//     {
//         return this.salary;
//     }
// }

// // let e1= new Employee("AA", "111", "Developer");
// // e1.show();

// class Professor extends Person implements IPayable, IEvaluated
// {
//     degree:string;
//     salary: number=5000;
//     bonus:number=500;
//     eval: Evaluation;
//     constructor(name:string, phoneNo:string, degree:string)
//     {
//         super(name,phoneNo);
//         this.degree=degree;
//     }

//     show(): void {
//         {
//             super.show();
//             console.log(`degree: ${this.degree}`);
//             console.log(`Evalutaion: ${Evaluation[this.eval]}`);
//         }
//     }

//     getPaid():number
//     {
//         return this.salary + this.bonus;
//     }
// }

// class Student extends Person
// {
//     GPA:number;
//     constructor(name:string, phoneNo:string, GPA:number)
//     {
//         super(name,phoneNo);
//         this.GPA=GPA;
//     }

//     show(): void {
//         {
//             super.show();
//             console.log(`GPA: ${this.GPA}`);
//         }
//     }
// }

// // let payablePersons: IPayable[];
// // payablePersons=[new Employee("EE", "11", "Developer"), 
// //                 new Professor("PP", "222", "Msc.")
// //                 //,new Student("SS", "333",5)
// //             ];

// // for (let person of payablePersons)
// // {
// //     console.log(person.getPaid());
// // }

// // let p =new Professor("PP", "111", "Porf.");
// // p.salary=10000;
// // p.eval=Evaluation.Verygood;
// // p.show();

// interface Food
// {
//     name:string;
//     calories:number;
// }

// let meat: Food= {
//     name:'meat',
//     calories:100
//     //, type: "Meat"
// }

// interface IProduct
// {
//     name: string;
//     price: number;
//     quantity: number;
//     img?:string;
// }

// let prods: IProduct[];

// prods=[{name: 'Laptop', price:100, quantity:10}
//         , {name: 'Mobile', price:200, quantity:20}
//         , {name: 'Tablet', price:300, quantity:30}];



