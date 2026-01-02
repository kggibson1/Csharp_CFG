// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to our Budget Tracker!");

// set budget
double shopping_budget = 200; // double more appropriate as remainder wont always be round
double entertainment_budget = 250;

// print budgets to console
Console.WriteLine($"Shopping budget: £{shopping_budget}");
Console.WriteLine($"Fun budget: £{entertainment_budget}");

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