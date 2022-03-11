using GuestBookLibrary.Models;

// guest book stores first name, last name, message to host, and bool isMember


List<GuestModel> guests = new List<GuestModel>();


string moreGuests = "";
string memberText = "";
bool validAnswer = true;

do

{
    GuestModel guest = new GuestModel();

    guest.FirstName = PrintMessageToConsole("What is your first name: ");
    guest.LastName = PrintMessageToConsole("What is your last name: ");
    guest.MessageToHost = PrintMessageToConsole("What is your message to the host: ");

    do
    {
        memberText = PrintMessageToConsole("Are you a member of this club (yes/no):");
        if (memberText.ToLower() == "yes")
        {
            guest.IsMember = true;
            validAnswer = true;
        }
        else if (memberText.ToLower() == "no")
        {
            guest.IsMember = false;
            validAnswer = true;
        }
        else
        {
            Console.WriteLine("That is not a valid answer. Try again.");
            validAnswer = false;
        }

    } while (!validAnswer);

    guests.Add(guest);

    moreGuests = PrintMessageToConsole("Are there more guests coming (yes/no): ");
    Console.Clear();

} while (moreGuests.ToLower() == "yes");

foreach (GuestModel g in guests)
{
    Console.WriteLine(g.DisplayGuestInfo);
}


static string PrintMessageToConsole(string message)
{
    Console.Write(message);

    string output = Console.ReadLine();

    return output;
    
}



