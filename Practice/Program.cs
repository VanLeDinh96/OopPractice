using Practice.Polymorphism;

// polymorphism
Shape[] shapes = new Shape[]
{
    new Circle(),
    new Square()
};

foreach(var shape in shapes){
    shape.Draw();
}