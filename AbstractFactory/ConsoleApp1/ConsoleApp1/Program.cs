IShapeCreator createSmall = new SmallShapeCreator();
Shape smallRectangle = createSmall.CreateRectangle();
IShapeCreator createBigShape = new CreateBigShape();
Shape bigRectangle = createBigShape.CreateRectangle();
smallRectangle.Draw();
bigRectangle.Draw();

