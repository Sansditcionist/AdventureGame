// print backstory to user
Console.WriteLine("Welcome to the garden");
Console.WriteLine("You are a man that has schizophrenia and also you are homeless that lived under a rock. The garden Is yours.");
Console.WriteLine("The garden Is very old that there Is mouldy bread and also has a sign from Jesus. You walk on the grass");
Console.WriteLine("Do you want to enter greenhouse that Is on the left? Or the shed that Is on the right?");

// Prompt the user for a choice
Console.Write("> ");
string optionChoice = Console.ReadLine();

// Ask player where they want to go
if(optionChoice == "greenhouse" )
{
    Console.WriteLine("you chose to go to the greenhouse.");
    Console.WriteLine("When you walk In, you see a body with no head and a old Nokia phone.");
    Console.WriteLine("Do you want to take the old Nokia phone?");

    // Prompt user for a choice
    Console.Write("> ");
    string nokiaChoice = Console.ReadLine();

    if(nokiaChoice == "yes")
    {
        Console.WriteLine("Your dumb brain attemps to steal the old Nokia phone, but the man with no head wakes up and kills you with a gun that has sharp metal instead of bullets");
        Console.WriteLine("You have died.");
    }
    else if(nokiaChoice == "no")
    { 
        Console.WriteLine("Your smart brain decides not to steal the old Nokia phone.");
        Console.WriteLine("You turn back and exit the greenhouse.");
    }
    else
    {
        Console.WriteLine("are you dumb? you have to answer yes or no.");
    }
}
else if(optionChoice == "shed")
{
    Console.WriteLine("you chose to go to the shed");
    Console.WriteLine("as you walk In, you see a green button");
    Console.WriteLine("Do you want to press the the green button?");

    // ugh again? Prompt user for a goddamn choice
    Console.Write("> ");
    string butonChoice = Console.ReadLine();

    if(butonChoice == "yes")
    {
        Console.WriteLine("You press the button and you here a noise.");
    }
    else if(butonChoice == "no")
    {
        Console.WriteLine("You don't press the button.");
        Console.WriteLine("You turn back to exit the shed but then you hear a sound from the greenhouse.");
        Console.WriteLine("A man with no head hits you with a baseball bat and you get knocked out.");
        Console.WriteLine("You wake up Inside the greenhouse. It was quiet for a moment but then... The man with no head shoots your ugly ass and then you die. 5 days later you had a funeral.");
    }
    else
    {
        Console.WriteLine("are you dumb? you have to answer yes or no.");
    }
}
else
{
    Console.WriteLine("There Is no option for that.");
}
