string[] FirstNames = {
        "Willa",
        "Delora",
        "Adele",
        "Luis",
        "Laila",
        "Saul",
        "Gabe",
        "Kayleen",
        "Rick",
        "Natsuki",
        "Danny",
        "Laura"
};
string[] MiddleNames = {
        "Troels",
        "Alena",
        "Rueda",
        "Tamati",
        "Ashura",
        "Matheo",
        "Lysandros",
        "Sisel",
        "Ann",
        "Marie",
        "Tara",
        "Zane",
};
string[] LastNames = { 
        "Harmony",
        "Williams",
        "Jones",
        "Brown",
        "David",
        "Miller",
        "Wilson",
        "Anderson",
        "Thomas",
        "Jackson",
        "White",
        "Robinson"
};
string[] jobCareers = {
        "Game Designer",
        "Cashier",
        "Programmer",
        "Animator",
        "Butcher",
        "Car Salesperson",
};
decimal[] perHour = {7.25m, 8.00m, 8.50m, 9.00m, 9.50m, 10.00m, 10.50m, 11.00m, 11.50m, 12.00m, 12.50m, 13.00m, 15.00m, 17.50m, 18.00m, 20.00m, 25.00m, 30.00m, 35.00m, 40.00m, 50.00m};

string[] names = new string[1000];
decimal[] stipends=new decimal[1000];
decimal[] salaries = new decimal[1000];
string[] jobs = new string[1000];
List<string> oldName = new List<string>();
for(int i = 0; i<1000; i++) {
Console.Write($"{i+1}  ");

    Random random = new Random();

while(true){
int v  = random.Next(0, FirstNames.Length);
int y  = random.Next(0, MiddleNames.Length);
int z  = random.Next(0, LastNames.Length);
string uniqueName = $"{FirstNames[v]}{MiddleNames[y]}{LastNames[z]}";
foreach (string x in oldName){
    if (x == uniqueName){continue;}}
oldName.Add(uniqueName);
Console.Write($"Name: {uniqueName}");
break;
}
int payment = random.Next(0, perHour.Length);
decimal stipend = perHour[payment];
Console.Write($"Hourly Wage: {stipend}   ");
decimal salary = stipend *2000;
Console.WriteLine($"YearlySalary {salary}");
int career  = random.Next(0, jobCareers.Length);
string job = jobCareers[career];
Console.Write($"CoolJob: {job}   ");
}