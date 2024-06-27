var bike = new Bike();

Component component = new Light(bike);
Component component2 = new Saddle(component);
Console.WriteLine(component2.OperationBike());
