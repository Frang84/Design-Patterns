List<Multimedia> myMultimedia = new List<Multimedia>();
Info info1 = new Info(120, "Manchester by the sea", "Drama");
Info info2 = new Info(5, "wish you were here", "progressive rock");
Info info3 = new Info(0, "bliss", "Landscape photography");
myMultimedia.Add(new Movie(info1, 2016, "Kenneth Lonergan"));
myMultimedia.Add(new Music(info2, 1975, "Pink Floyd"));
myMultimedia.Add(new Picture(info3, 1996, "Charles O'Rear"));

List<Multimedia> copyList = new List<Multimedia>();
foreach (var item in myMultimedia)
{
    copyList.Add(item.Clone());
}
info1.SetLength(130);
foreach (var item in copyList)
{
    Console.WriteLine(item.toString());
    Console.WriteLine("----------------");
}



