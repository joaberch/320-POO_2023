using Parachute;
Plane Plane = new Plane();

Console.SetWindowSize(Config.SCREEN_WIDTH, Config.SCREEN_HEIGHT);

Plane.draw();

while (true)
{
    // Modifier le modèle (ce qui *est*)
    Plane.update();
    
    // Temporiser
    Thread.Sleep(100);
}