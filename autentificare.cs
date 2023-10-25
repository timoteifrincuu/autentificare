const string UtilizatorCorect = "utilizator";
const string ParolaCorecta = "parola123";

bool autentificareReusita = false;

while (!autentificareReusita)
{
    Console.Write("Introduceți numele de utilizator: ");
    string utilizator = Console.ReadLine();

    Console.Write("Introduceți parola: ");
    string parola = Console.ReadLine();

    if (utilizator == UtilizatorCorect && parola == ParolaCorecta)
    {
        autentificareReusita = true;
        Console.WriteLine("Bine ai venit, " + utilizator + "!");
    }
    else
    {
        Console.WriteLine("Autentificare eșuată. Vă rugăm să încercați din nou.");
    }
}

Console.WriteLine("Acum sunteți autentificat în aplicație.");
