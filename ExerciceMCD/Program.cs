// See https://aka.ms/new-console-template for more information

using Exercise_DB.Classes;

#region Initialisation des variables
List<Client> ClientList = new List<Client>();
List<Technician> TechnicianList = new List<Technician>();
List<Photocopier> PhotocopierList = new List<Photocopier>();

bool exit = false;
#endregion

while (!exit)
{
    ShowMenu();
    int choice = ReadNumericInput(1, 7);

    switch (choice)
    {
        case 1:
            CreateClient();
            break;
        case 2:
            CreateTechnician();
            break;
        case 3:
            CreatePhotocopier();
            break;
        case 4:
            DisplayListClient();
            break;
        case 5:
            DisplayListTech();
            break;
        case 6:
            DisplayListPhoto();
            break;
        case 7:
            exit = true;
            Console.WriteLine("Exit...");
            break;
        default:
            Console.WriteLine("Option non valide. Veuillez réessayer.");
            break;
    }

    if (!exit)
    {
        Console.WriteLine("\nPressez une touche pour continuer...");
        Console.ReadKey();
        Console.Clear();
    }
}

#region Menu des choix
static void ShowMenu()
{
    Console.WriteLine("-----------------------------");
    Console.WriteLine("========= Main Menu =========");
    Console.WriteLine("-----------------------------");
    Console.WriteLine("1 ---- ajouter un client ----");
    Console.WriteLine("-----------------------------");
    Console.WriteLine("2 -- ajouter un technician --");
    Console.WriteLine("-----------------------------");
    Console.WriteLine("3 -  ajouter un photocopier -");
    Console.WriteLine("-----------------------------");
    Console.WriteLine("4 ---  Lister les clients ---");
    Console.WriteLine("-----------------------------");
    Console.WriteLine("5 -  Lister les techniciens -");
    Console.WriteLine("-----------------------------");
    Console.WriteLine("6 - Lister les photocopieur -");
    Console.WriteLine("-----------------------------");
    Console.WriteLine("7 ----------- Exit ----------");
    Console.WriteLine("-----------------------------");

}
#endregion

#region Lecture de la valeur numérique
static int ReadNumericInput(int min, int max)
{
    int result = 0;
    string input;
    bool isValid;

    do
    {
        Console.Write($"Your choice ({min}-{max}) : ");
        input = Console.ReadLine();

        // Verify if the input is empty or only space
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("The input cannot be empty");
            isValid = false;
            continue;
        }

        // Try to convert to int
        if (!int.TryParse(input, out result))
        {
            Console.WriteLine("Input a valid number");
            isValid = false;
            continue;
        }

        // Verify if number is in the valid range
        if (result < min || result > max)
        {
            Console.WriteLine($"The input must be between {min} and {max}.");
            isValid = false;
            continue;
        }

        isValid = true;

    } while (!isValid);

    return result;
}
#endregion

#region Creer Client
void CreateClient()
{
    Console.Write("Nom :");
    String name = Console.ReadLine();
    Console.Write("Prenom :");
    String surname = Console.ReadLine();
    Console.Write("Email :");
    String email = Console.ReadLine();
    Console.Write("Tel :");
    int tel = int.Parse(Console.ReadLine());
    Console.Write("Adresse :");
    String address = Console.ReadLine();

    Client entry = new Client(name, surname, email, tel, address);

    AddListClient(entry);
}
#endregion

#region Ajouter à liste client
void AddListClient(Client newClient)
{
    ClientList.Add(newClient);
    Console.WriteLine("\n");
    Console.WriteLine("Client ajouté :");
    Console.WriteLine("client n° " + newClient.Id_client + " nom : " + newClient.Name + " " + newClient.Surname + " | addresse : " +
    newClient.Address + " | mail : " + newClient.Email + " | téléphone : " + newClient.Telephone);
}
#endregion

#region Afficher liste client
void DisplayListClient()
{
    Console.WriteLine("Liste des Clients");
    foreach (var client in ClientList)
        {
         Console.WriteLine("client n° " + client.Id_client + " nom : " + client.Name + " " + client.Surname + " addresse : " +
        client.Address + " mail : " + client.Email + " téléphone : " + client.Telephone);
        }
}
#endregion

#region Creer Technicien
void CreateTechnician()
{
    Console.Write("Nom :");
    String name = Console.ReadLine();
    Console.Write("Prenom :");
    String surname = Console.ReadLine();
    Console.Write("Tel :");
    int tel = int.Parse(Console.ReadLine());

    Technician entry = new Technician(name, surname, tel);

    AddListTechnician(entry);
}
#endregion

#region Ajouter à liste technicien
void AddListTechnician(Technician newTechnician)
{
    TechnicianList.Add(newTechnician);
    Console.WriteLine("\n");
    Console.WriteLine("Technicien ajouté:");
    Console.WriteLine("technicien n° " + newTechnician.Id_technician + " nom : " + newTechnician.Name + " " + newTechnician.Surname + " téléphone :" + newTechnician.Telephone);
}
#endregion

#region Afficher liste Techniciens
void DisplayListTech()
{
    Console.WriteLine("Liste des Techniciens");
    foreach (var technician in TechnicianList)
    {
        Console.WriteLine("technicien n° " + technician.Id_technician + " nom : " + technician.Name + " " + technician.Surname + " téléphone : " + technician.Telephone);
    }
}
#endregion

#region Creer Photocopieur
void CreatePhotocopier()
{
    Console.Write("Modèle :");
    String model = Console.ReadLine();
    Console.Write("Est defaillant (o/n) :");
    bool isFailing;
    String isFailingInput = Console.ReadLine();
    if (isFailingInput == "o")
    {
        isFailing = true;
    }
    else
    {
        isFailing = false;
    }

    Photocopier entry = new Photocopier(model, isFailing);

    AddListPhotocopier(entry);
}
#endregion

#region Ajouter à la liste Photocopieur
void AddListPhotocopier(Photocopier newPhotocopier)
{
    PhotocopierList.Add(newPhotocopier);
    Console.WriteLine("\n");
    Console.WriteLine("Photocopieur ajouté :");
    Console.WriteLine("photocopieur n° " + newPhotocopier.Id_photocopier + " modèle : " + newPhotocopier.Model + " est defaillant : " + newPhotocopier.Is_failing);
}
#endregion

#region Afficher la liste des Photocopieurs
void DisplayListPhoto()
{
    Console.WriteLine("Liste des Photocopieurs");
    foreach (var photocopier in PhotocopierList)
    {
        Console.WriteLine("photocopieur n° " + photocopier.Id_photocopier + " modèle : " + photocopier.Model + " est defaillant : " + photocopier.Is_failing);
    }
}
#endregion