//initializing arrays of student information
string[] Student = { "Justin Jones", "Ethan Thomas", "Belle Baxley", "Allison Jones", "John Glandon", "Michael Blackburn", "Christopher Washington", "Earle Fox", "Joshua Carolin", "Mourad Alfadil", "Tee Sotomi", "Wilfredo Pacheco", "Jun Kim", "Jason Garrison", "Cam Dixon", "Josh Strathres" };
//List<string> Studentlist = new List<string>(Student);
string[] Hometown = { "Columbus", "Urbana", "Haleiwa", "Grand Rapids", "Detroit", "Warren", "Detroit", "Saline", "Westland", "Detroit", "Chicago", "Canton", "Lubbock", "Chelsea", "South Lyon", "Oxford" };
//List<string> Hometownlist = new List<string>(Hometown);
string[] FavFood= { "Baja Blast", "Hot Wings", "french fries", "Pad Ke Mao", "Stir fry", "Anpan", "Egg roll", "Pizza", "Naleśniki", "Fried Rice", "Pasta", "Quesadilla", "noodles", "Chewing Tobacco", "Coney Dogs", "Pizza" };
//List<string> Foodlist = new List<string>(FavFood);


bool goagain = false;
bool valid = true;
do
{
    //for loop to display a list of students and their associated numbers

    //prompting the user to input a number to pick from the list of students
    Console.WriteLine("Please enter in the number from the list below of which student you wish to view");

        for (int i = 0; i < Student.Length; i++)
        {
            Console.WriteLine((i + 1) + ": \t" + Student[i]);
        }
        int studentpick = int.Parse(Console.ReadLine());


    //replying to the user with their picked student and prompting them to choose which catagory to look into
    Console.WriteLine("You picked " + Student[studentpick - 1] + ". What would you like to know? Enter \"hometown\" or \"favorite food\"");
string answer = Console.ReadLine();
//lowercasing the answer so less work 
answer = answer.ToLower();
if (answer == "hometown" || answer == "home town")
{
    Console.WriteLine("The hometown of " + Student[studentpick-1] + " is " + Hometown[studentpick-1] + ".");
}
else if (answer == "favorite food" || answer == "food" || answer == "favorite")
{
    Console.WriteLine("The Favorite food of " + Student[studentpick-1] + " is " + FavFood[studentpick-1] + ".");
}

    //prompting the user if they wish to try again
    Console.WriteLine("Would you like to try again? (y/n)");
    string response = Console.ReadLine();
    if (response == "y")
    {
        goagain= true;
    }
    else if (response == "n")
    {
        goagain = false;
    }
}while (goagain == true);