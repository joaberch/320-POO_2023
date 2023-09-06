using Parachute;

Plane Plane = new Plane();
//Para Bob = new Para();

ConsoleKeyInfo keyPressed;

Console.SetWindowSize(Config.SCREEN_WIDTH, Config.SCREEN_HEIGHT);

Plane.draw();
while (true) //Game engine
{
    // Modifier le modèle (ce qui *est*)
    Plane.update();


    // Modifier ce que l'on *voit*
    Console.Clear();
    Plane.draw();

    if (Console.KeyAvailable) // L'utilisateur a pressé une touche
    {
        
        keyPressed = Console.ReadKey(false);
        switch (keyPressed.Key)
        {
            case ConsoleKey.Escape:
                Environment.Exit(0);
                break;
        }
    }

    // Temporiser
    Thread.Sleep(15);
}