

// Open-Closed

// Yazılım varlıkları ( sınıflar - metotlar vb ) genişletilmeye açık ancak değiştirilmeye kapalı olmalı.

using OpenClosed;

Square newSq = new Square();

newSq.SideLength = 5;

double area = newSq.CalculateArea();