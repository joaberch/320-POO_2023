using Parachute;

Plane avion = new Plane();

//Préparer la variable pour récupérer la saisie
ConsoleKeyInfo keyPressed;

//Configurer la taille de l'écran
Console.SetWindowSize(Config.SCREEN_WIDTH, Config.SCREEN_HEIGHT);

//dessiner l'avion une première fois
avion.draw();

//Choisir le nombre de parachutiste
const int NBRPARA = 3;

//Faire embarquer les passagers
avion.addParachutist(NBRPARA);

//créer un compteur pour le nombre de parachutiste ayant sauter
int compteursauter = 0;

//Création d'une collection pour les parachutistes en dehors de l'avion
List<Para> outside = new List<Para>();  

while (true) //Game engine
{
    // Modifier le modèle (ce qui *est*)
    avion.update();


    // Modifier ce que l'on *voit*
    Console.Clear();
    avion.draw();

    foreach(Para para in outside)   //Modifie les parachutiste en dehors de l'avion
    {
        para.draw();
        para.Update();
    }

    if (Console.KeyAvailable) // L'utilisateur a pressé une touche
    {

        keyPressed = Console.ReadKey(false);
        switch (keyPressed.Key)
        {
            case ConsoleKey.Spacebar:                       //Si l'utilisateur a appuyé sur espace
                if (compteursauter != NBRPARA)                  //Si plus de parachutiste dans l'avion
                {
                    outside.Add(avion.insideplane.First());         //Ajouter un parachutist en dehors de l'avion
                    avion.parajump();                               //Enlever un parachutiste dans l'avion
                    outside[compteursauter].x = avion.x;            //Définir la valeur x du parachutiste
                    ++compteursauter;                               //Augmenter le nombre de parachutiste ayant sauté
                }

                break;

            case ConsoleKey.Escape:                         //Si l'utilisateur a appuyé sur exit
                Environment.Exit(0);                            //Quitter le programme
                break;
        }
    }

    // Temporiser
    Thread.Sleep(15);
}