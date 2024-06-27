ShapeCreator shapeCreator = new RectangleCreator();
Shape Rectangle = shapeCreator.CreateShape();
Rectangle.Draw();
ShapeCreator shapeCreator1 = new SmallRectangleCreator();
Shape smallRectangle = shapeCreator1.CreateShape();
smallRectangle.Draw();
