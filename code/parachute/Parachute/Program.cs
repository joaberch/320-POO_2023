using Parachute;

Plane avion = new Plane();
//Para Alice = new Para("Alice");

//Préparer la variable pour récupérer la saisie
ConsoleKeyInfo keyPressed;

//Configurer la taille de l'écran
Console.SetWindowSize(Config.SCREEN_WIDTH, Config.SCREEN_HEIGHT);

//dessiner l'avion une première fois
avion.draw();

//Faire embarquer les passagers
avion.addParachutist(3);

List<Para> outside = new List<Para>();  //Création d'une collection pour les parachutistes en dehors de l'avion

while (true) //Game engine
{
    // Modifier le modèle (ce qui *est*)
    avion.update();


    // Modifier ce que l'on *voit*
    Console.Clear();
    avion.draw();

    foreach(Para para in outside)
    {
        
        para.Parashow();
        para.Update();
    }

    if (Console.KeyAvailable) // L'utilisateur a pressé une touche
    {

        keyPressed = Console.ReadKey(false);
        switch (keyPressed.Key)
        {
            case ConsoleKey.Spacebar:
                outside.Add(avion.insideplane.First()); //Ajouter un parachutist en dehors de l'avion
                avion.parajump();
                outside[0].x = avion.x;

                break;

            case ConsoleKey.Escape:
                Environment.Exit(0);
                break;
        }
    }

    // Temporiser
    Thread.Sleep(15);
}