class Person
{
    private id:number;
    protected age:number;
    public name:string;
    phoneNo:string; //public

    constructor(name:string,  phoneNo: string)
    {
        this.name=name;
        //this.age=age;
        this.phoneNo=phoneNo;
    }

    show()
    {
        console.log(`Person Name: ${this.name}, 
            and his phone mumber: ${this.phoneNo}`);
    }

    static whoAmI()
    {
        console.log("I am a Person");
    }
}

class Person2
{
    private id:number;
    // protected age:number;
    // public name:string;
    // phoneNo:string; //public

    constructor(public name:string, protected age:number, public phoneNo: string)
    {
        // this.name=name;
        // this.age=age;
        // this.phoneNo=phoneNo;
    }

    show()
    {
        console.log(`Person Name: ${this.name}, 
            his age: ${this.age},
            and his phone mumber: ${this.phoneNo}`);
    }

    static whoAmI()
    {
        console.log("I am a Person");
    }
}

//Inheritance
  //TypeScript allow single inheritance, multi-level inheritance.
  //BUT DON'T allow multiple inheritance.
  class Root { 
    str:string; 
  } 
  class Child extends Root {
    str2:string;
  } 
  class Leaf extends Child {
    str3:string;
  } //indirectly inherits from Root by virtue of inheritance  
  var obj2 = new Leaf(); 
  obj2.str ="hello" 
  console.log(obj2.str) 

  
interface IPayable
{
    salary:number;
    bonus?:number;
    getPaid: ()=>number;
}

enum Evaluation
{
    Excellent=1, //1
    Verygood, //2
    Good, //3
    Fair //4
}

interface IEvaluated
{
    eval:Evaluation;
    comment?:string;
}

class Employee extends Person implements IPayable
{
    jobTitle:string;
    salary:number=1000;
    constructor(name:string, phoneNo:string, jobTitle:string)
    {
        super(name,phoneNo);
        this.jobTitle=jobTitle;
    }

    show(): void {
        {
            super.show();
            console.log(`Job title: ${this.jobTitle}`);
        }
    }

    getPaid():number
    {
        return this.salary;
    }
}

// let e1= new Employee("AA", "111", "Developer");
// e1.show();

class Professor extends Person implements IPayable, IEvaluated
{
    degree:string;
    salary: number=5000;
    bonus:number=500;
    eval: Evaluation;
    constructor(name:string, phoneNo:string, degree:string)
    {
        super(name,phoneNo);
        this.degree=degree;
    }

    show(): void {
        {
            super.show();
            console.log(`degree: ${this.degree}`);
            console.log(`Evalutaion: ${Evaluation[this.eval]}`);
        }
    }

    getPaid():number
    {
        return this.salary + this.bonus;
    }
}

class Student extends Person
{
    GPA:number;
    constructor(name:string, phoneNo:string, GPA:number)
    {
        super(name,phoneNo);
        this.GPA=GPA;
    }

    show(): void {
        {
            super.show();
            console.log(`GPA: ${this.GPA}`);
        }
    }
}

let payablePersons: IPayable[];
payablePersons=[new Employee("EE", "11", "Developer"), 
                new Professor("PP", "222", "Msc.")
                //,new Student("SS", "333",5)
            ];

for (let person of payablePersons)
{
    console.log(person.getPaid());
}

let p =new Professor("PP", "111", "Porf.");
p.salary=10000;
p.eval=Evaluation.Verygood;
p.show();

/////////////////////////////

interface IProduct
{
    name: string;
    price: number;
    quantity: number;
    img?:string;
}

let prods: IProduct[];

prods=[{name: 'Laptop', price:100, quantity:10}
        , {name: 'Mobile', price:200, quantity:20}
        , {name: 'Tablet', price:300, quantity:30}];



