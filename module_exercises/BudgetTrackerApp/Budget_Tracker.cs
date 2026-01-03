// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to our Budget Tracker!\n");

// set budget
double shopping_budget = 200; // double more appropriate as remainder wont always be round
double entertainment_budget = 250;

// print budgets to console
Console.WriteLine($"Shopping budget: £{shopping_budget}");
Console.WriteLine($"Fun budget: £{entertainment_budget}\n");

// track fixed expenses (rent, gas + electric, water) & print to console
double[] fixed_expenses = {1200.0, 150.0, 50.0};

//Console.WriteLine($"Fixed Expenses (£):\n Rent: {fixed_expenses[0]}\n Gas & Electric: {fixed_expenses[1]}\n Water: {fixed_expenses[2]}");

// track fixed expenses with a list instead of an array
List<double> fixed_expenses2 = new List<double> {1200.0, 150.0, 50.0};

Console.WriteLine($"Fixed Expenses (£):\n Rent: {fixed_expenses2[0]}\n Gas & Electric: {fixed_expenses2[1]}\n Water: {fixed_expenses2[2]}");

// add some new expenses
fixed_expenses2.Add(35); // internet
fixed_expenses2.Add(14.95); // spotify

Console.WriteLine($" Internet: {fixed_expenses2[3]}");
Console.WriteLine($" Spotify: {fixed_expenses2[4]}");

// budget spent so far
double shoppingspent = 350.0;
double entertainmentspent = 100.0;

// check if we are over or within budget for both shopping and entertainment
if (shoppingspent > shopping_budget)
{
    Console.WriteLine("\nYou are over budget on food shopping");
}
else {Console.WriteLine("\nYou are within budget for food shopping");}

if (entertainmentspent > entertainment_budget)
{
    Console.WriteLine("You are over budget on enterainment");
}
else {Console.WriteLine("You are within budget for entertainment");}

// calculate remaining budget
double remainingshoppingbudget = shopping_budget - shoppingspent;
double remainingentertainmentbudget = entertainment_budget - entertainmentspent;

Console.WriteLine($"\nRemaining budgets (£) \n Shopping: {remainingshoppingbudget} \n Entertainment: {remainingentertainmentbudget}\n");

// check if we are within budget using logic operators
if (shoppingspent <= shopping_budget && entertainmentspent <= entertainment_budget)
{
    Console.WriteLine("You are within budget for groceries and entertainment\n");
}
else if (shoppingspent <= shopping_budget || entertainmentspent <= entertainment_budget)
{
    Console.WriteLine("You are within budget for one of your spending limits\n");
}
else
{
    Console.WriteLine("You are over budget for both shopping and entertainment\n");
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}