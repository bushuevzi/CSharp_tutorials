using System;

namespace CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] myShapes = { new Hexagon(), new Circle(), new Triangle("Joe"), new Circle("JoJo") };
            for(int i=0; i < myShapes.Length; i++)
            {
                myShapes[i].Draw();

                //Who's pointy?
                if (myShapes[i] is IPointy ip)  //если объект реализует IPointy то в ip будет помещен IPointy, если нет в ip будет false
                    // если в ip будет false это будет пропущено
                    Console.WriteLine($"-> Ppoints: {ip.Points}");
                else
                    Console.WriteLine($"-> {myShapes[i].PetName}\'s not pointy!");
                Console.WriteLine();

                //Can Idraw you in 3D?
                if (myShapes[i] is IDraw3D)
                    DrawIn3D((IDraw3D)myShapes[i]);
            }
        }

        //I'll draw anyone supporting IDraw3D
        static void DrawIn3D(IDraw3D itf3d)
        {
            Console.WriteLine("=> Drawing IDraw3D compatimble type");
            itf3d.Draw3D();
        }
    }
}
