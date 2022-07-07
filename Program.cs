//найти растояние между точками на плоскости и пространстве 
// если рассматривать расстояние на плоскости, то координаты z1=0 и z2=0
    double  distance;

    Console.Write("введите координату x1  ");
    int x1=int.Parse (Console.ReadLine());
    Console.Write("введите координату y1  ");
    int y1= int.Parse(Console.ReadLine());
    Console.Write("введите координату z1  ");
    int z1= int.Parse(Console.ReadLine());

    Console.Write("введите координату x2  ");
    int x2= int.Parse(Console.ReadLine());
    Console.Write("введите координату y2  ");
    int y2= int.Parse(Console.ReadLine());
    Console.Write("введите координату z2  ");
    int z2= int.Parse(Console.ReadLine());
    
distance=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
Console.WriteLine($"Расстояние между двумя точками  равно {distance}");
Console.ReadKey();



  