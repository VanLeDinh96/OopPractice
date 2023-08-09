
// polymorphism 1:
// Shape[] shapes = new Shape[]
// {
//     new Circle(),
//     new Square()
// };

// foreach(var shape in shapes){
//     shape.Draw();
// }

// polymorphism 2:
using Practice.Polymorphim2;

Calculator calculator = new Calculator();
int result1 = calculator.Add(1, 2);
double result2 = calculator.Add(2.2,3.3);
string result3 = calculator.Add("hello ", "world!");

Console.WriteLine(result1);
Console.WriteLine(result2);
Console.WriteLine(result3);