/*
When building large scale apps, the object oriented style of programming
is preferred by many developers, most notably in languages such as Java or C#.
TypeScript offers a class system that is very similar to the one in these
languages, including inheritance, abstract classes, interface implementations, setters/getters, and more.

It's also fair to mention that since the most recent JavaScript update
(ECMAScript 2015), classes are native to vanilla JS and can be used
without TypeScript. The two implementation are very similar but have their
differences, TypeScript being a bit more strict.
*/
var __extends = (this && this.__extends) || (function () {
    var extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Menu = /** @class */ (function () {
    // A straightforward constructor. 
    function Menu(item_list, total_pages) {
        // The this keyword is mandatory.
        this.items = item_list;
        this.pages = total_pages;
    }
    // Methods
    Menu.prototype.list = function () {
        console.log("Our menu for today:");
        for (var i = 0; i < this.items.length; i++) {
            console.log(this.items[i]);
        }
    };
    return Menu;
}());
// Create a new instance of the Menu class.
var sundayMenu = new Menu(["pancakes", "waffles", "orange juice"], 1);
// Call the list method.
sundayMenu.list();
//--------------------------------------------------------------------//
//Inheritance
var HappyMeal = /** @class */ (function (_super) {
    __extends(HappyMeal, _super);
    // A new constructor has to be defined.
    function HappyMeal(item_list, total_pages, toy) {
        var _this = 
        // In this case we want the exact same constructor as the parent class (Menu), 
        // To automatically copy it we can call super() - a reference to the parent's constructor.
        _super.call(this, item_list, total_pages) || this;
        _this.toy = toy;
        return _this;
    }
    // Just like the properties, methods are inherited from the parent.
    // However, we want to override the list() function so we redefine it.
    HappyMeal.prototype.list = function () {
        console.log("Our special menu for children:");
        for (var i = 0; i < this.items.length; i++) {
            console.log(this.items[i]);
        }
        console.log("A gift toy is provided: " + this.toy);
    };
    return HappyMeal;
}(Menu));
// Create a new instance of the HappyMeal class.
var menu_for_children = new HappyMeal(["candy", "drink", "kids Burger"], 1, "puzzle");
// This time the log message will begin with the special introduction.
menu_for_children.list();
//For a more in-depth look at classes in TS you can read the documentation:
//http://www.typescriptlang.org/docs/handbook/classes.html
