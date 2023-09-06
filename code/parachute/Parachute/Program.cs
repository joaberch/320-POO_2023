using Parachute;
Plane Plane = new Plane();

Console.SetWindowSize(Config.SCREEN_WIDTH, Config.SCREEN_HEIGHT);

Plane.draw();

while (true)
{
    // Modifier le modèle (ce qui *est*)
    Plane.update();
    

     // Modifier ce que l'on *voit*
     Console.Clear();
    Plane.draw();

    // Temporiser
    Thread.Sleep(100);
}