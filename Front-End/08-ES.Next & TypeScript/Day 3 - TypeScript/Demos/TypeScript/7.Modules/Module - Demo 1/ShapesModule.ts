//https://www.typescriptlang.org/docs/handbook/modules.html
export interface IShape{
    draw: ()=>void
}

export class Circle implements IShape
{
    draw()
    {
        console.log("Circle Drawn...");
    }
}

export class Triangle implements IShape
{
    draw()
    {
        console.log("Triangle Drawn...");
    }
}