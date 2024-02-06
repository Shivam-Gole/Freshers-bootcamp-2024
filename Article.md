<a name="br1"></a> 

**Title : *Understanding the Open-Closed Principle: Wriꢀng Clean, Maintainable,***

***and Scalable Code***

**Introducꢀon:**

In the world of soꢀware engineering, adhering to solid design principles is crucial for

building maintainable, extensible, and robust soꢀware systems. One such principle is the

Open-Closed Principle (OCP), which emphasizes the importance of designing soꢀware

components that are open for extension but closed for modiﬁcaꢁon. In this arꢁcle, we'll

delve into the concept of the Open-Closed Principle and explore how it can be applied

eﬀecꢁvely with the help of an illustraꢁve example.

**What is the Open-Closed Principle (OCP)?**

The Open-Closed Principle, one of the ﬁve SOLID principles of object-oriented design, was

introduced by Bertrand Meyer in his 1988 book "Object-Oriented Soꢀware Construcꢁon."

The principle states:

"Soꢀware enꢁꢁes (classes, modules, funcꢁons, etc.) should be open for extension, but

closed for modiﬁcaꢁon."

In simpler terms, this means that the behaviour of a soꢀware component should be

extendable without requiring changes to its source code. New funcꢁonality should be added

by extending exisꢁng code rather than modifying it. This approach promotes code reuse,

maintainability, and stability.

**Lets understand with the help of an example where OCP is being violated :**

using System;

using System.Collections.Generic;

// Base class representing a shape

abstract class Shape

{

public abstract void Draw();

}

// Concrete class representing a rectangle

class Rectangle : Shape

{

public override void Draw()

{

Console.WriteLine("Drawing a rectangle");

// Code to draw a rectangle on the canvas

}

}



<a name="br2"></a> 

// Concrete class representing a circle

class Circle : Shape

{

public override void Draw()

{

Console.WriteLine("Drawing a circle");

// Code to draw a circle on the canvas

}

}

// Function to draw all shapes on the canvas (violating OCP)

class Drawing

{

public static void DrawAllShapes(List<Shape> shapes)

{

foreach (var shape in shapes)

{

if (shape is Rectangle)

{

Console.WriteLine("Drawing a rectangle");

// Code to draw a rectangle on the canvas

}

else if (shape is Circle)

{

Console.WriteLine("Drawing a circle");

// Code to draw a circle on the canvas

}

// Add more conditions for new shapes here

}

}

}

class Program

{

static void Main(string[] args)

{

// Create instances of different shapes

Rectangle rectangle = new Rectangle();

Circle circle = new Circle();

// Draw individual shapes

rectangle.Draw();

circle.Draw();

// Draw all shapes on the canvas (violating OCP)

List<Shape> shapes = new List<Shape> { rectangle, circle };

Drawing.DrawAllShapes(shapes);



<a name="br3"></a> 

Console.ReadLine();

}

}

In the above code the **drawAllShapes()** funcꢁon explicitly checks the type of each shape

using dynamic\_cast and then draws the shape accordingly. If a new shape is added, the

**drawAllShapes()** funcꢁon must be modiﬁed to include a case for that shape, violaꢁng the

Open-Closed Principle.

**Problems of Not Following the Open-Closed Principle in C#:**

So, if you are not following the Open-Closed Principle during the applicaꢁon development process,

then you may end up with your applicaꢁon development with the following problems

1\. If you allow a class or funcꢁon to add new logic, then as a developer, you need to test the

enꢁre funcꢁonaliꢁes, including the old and new funcꢁonaliꢁes of the applicaꢁon.

2\. As a developer, it is also your responsibility to tell the QA (Quality Assurance) team about the

changes in advance so that they can prepare themselves for regression tesꢁng along with the

new feature tesꢁng.

3\. If you are not following the Open-Closed Principle, it also breaks the Single Responsibility

Principle, as the class or module will perform mulꢁple responsibiliꢁes.

4\. If you are implemenꢁng all the funcꢁonaliꢁes in a single class, then the maintenance of the

class becomes very diﬃcult.

We should go for **EXTENSION** instead of **MODIFICATION** as per the Open-Closed principle. As a

result, the current funcꢁonaliꢁes that are already implemented are going to be unchanged. The

advantage is that we only need to test and check the new classes.

To adhere to the **Open-Closed Principle (OCP)**, we need to modify the code to ensure that adding

new shapes does not require modifying exisꢁng code. We can achieve this by maintaining

polymorphic behavior and using dynamic dispatch to call the draw() method on each shape.

using System;

using System.Collections.Generic;

// Base class representing a shape

abstract class Shape

{

public abstract void Draw();

}

// Concrete class representing a rectangle

class Rectangle : Shape

{

public override void Draw()

{

Console.WriteLine("Drawing a rectangle");

// Code to draw a rectangle on the canvas



<a name="br4"></a> 

}

}

// Concrete class representing a circle

class Circle : Shape

{

public override void Draw()

{

Console.WriteLine("Drawing a circle");

// Code to draw a circle on the canvas

}

}

// New concrete class representing a triangle

class Triangle : Shape

{

public override void Draw()

{

Console.WriteLine("Drawing a triangle");

// Code to draw a triangle on the canvas

}

}

// Function to draw all shapes on the canvas (adhering to OCP)

class Drawing

{

public static void DrawAllShapes(List<Shape> shapes)

{

foreach (var shape in shapes)

{

shape.Draw(); // Polymorphic behavior

}

}

}

class Program

{

static void Main(string[] args)

{

// Create instances of different shapes

Rectangle rectangle = new Rectangle();

Circle circle = new Circle();

Triangle triangle = new Triangle(); // New shape added without

modifying existing code

// Draw individual shapes

rectangle.Draw();

circle.Draw();



<a name="br5"></a> 

triangle.Draw(); // New shape drawn without modifying existing code

// Draw all shapes on the canvas (adhering to OCP)

List<Shape> shapes = new List<Shape> { rectangle, circle, triangle };

// Updated to include triangle

Drawing.DrawAllShapes(shapes);

Console.ReadLine();

}

}

This C# code mirrors the funcꢁonality of the given C++ code, including the addiꢁon of a new shape

(triangle) without modifying the exisꢁng code .

**Conclusion** :

The Open-Closed Principle encourages developers to design soꢀware components that are resilient

to change and easily extensible. By adhering to this principle, we can build soꢀware systems that are

more modular, maintainable, and adaptable to evolving requirements. By employing abstracꢁon,

inheritance, and polymorphism, we can achieve designs that allow for easy extension while

minimizing the need for modiﬁcaꢁon, thus promoꢁng code reuse and reducing the risk of

introducing bugs.

In summary, understanding and applying the Open-Closed Principle is essenꢁal for wriꢁng clean,

ﬂexible, and scalable code in modern soꢀware development pracꢁces. By embracing this principle,

developers can build robust and future-proof soꢀware systems that stand the test of ꢁme.

