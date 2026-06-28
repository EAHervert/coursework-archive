/*
The program should create an array of three structures.  The elements should be initialized with the following data:

Drink Name
Drink Cost
Number of Drink in Machine

The machine has $10 worth of change if needed.

Each time the program runs, it should enter a loop that performs the following steps:
-	It should display a menu of drinks the vending machine contains. [X]
-	The program should wait until the user enters a drink or press the quit command.  [X]
	The quit command (choose the command you want) should not be visible to the end user. [X]
	Also after one transaction it should display the menu again and wait for the next transaction. [X]
-	If the user selects a drink.  The user should be prompted to input the amount of the drink. [X]
-	Data validation.  If the user entered a max amount the machine cannot handle inform the user. [X]
	For example if the machine cannot accept $20 or greater then give an error message to the user. [X]  
	If the user puts in amount less than amount prompt them what value they need to input.  [X]
	If the user gets change back display the change amount.  [X]
	In addition to decrement inventory.	[]
-	If the user selects a drink that has sold out, a message should be displayed.  The loop then repeats. [X]
-	When the user chooses to quit the program it should display the total amount of money the machine earned in a report.  [X]
	Name the report SalesReport.txt.	[X]

The manner in which you display the output is of your choosing along with the appropriate error messages. With that being said make sure that the output is clean and clear 
to the user. You do not want the user to guess what he or she has to do.   Make sure all parts of your program check for correct data entry. Name the file

*/

/*	What are the Drinks going to be?
		Black Velvet - 1.25 - 11
		Panama - 1.50 - 10
		Alexander - 1.50 - 9
		Hurricane - 1.75 - 12
		Matador - 2.00 - 13
*/
#include <iostream>
#include <string>
#include <iomanip>
#include <cctype>
#include <fstream>

using namespace std;

struct DrinkName
{
	string Name;
	double Price;
	int Amount;
};


int Continue(int Key1)
{
	// ask them if they would like to make another transation.
	int t_f;
	cout << "\nWould you like to make another transaction?" << endl;
	cout << "1 - Yes.\n2 - No." << endl;
	cin >> Key1;
	cout << endl;

	do
	{
		if (Key1 != 1)
		{
			if (Key1 != 2)
			{

				if (Key1 == -11)
				{
					t_f = 0;
				}
				else
				{
					cout << "\nInvalid input! Please enter 1 for Yes or 2 for No." << endl;
					cin >> Key1;
					t_f = 1;
				}
			}
			else
				t_f = 0;
		}
		else
			t_f = 0;
	}while (t_f == 1);

	return Key1;
}

int main()
{
	// Initialization of values.
	int Key1 = 0, Key2 = 0, t_f = 1;
	double TotalAmountInMachine = 10.00, MoneyOwedByHuman = 0, MoneyGivenByHuman = 0, Change = 0;
	int DrinkOfChoice = 0, DrinkMultiples = 0;
	cout << fixed << showpoint << setprecision(2);

	// Create the file to host all the data.
	ofstream SalesReport;
	SalesReport.open("SalesReport.txt");

	// Create a constant that has the amount of different drinks I will use. Remember that for a number n, the total amount in a array will be n+1 because
	// 0 is where the Array starts.
	const int DrinkTypes = 5;
	DrinkName DrinkNumber[DrinkTypes];

	// *********** Input the details of the drinks. ***********

	// Black Velvet
	const int BlackVelvet = 0;
	DrinkNumber[BlackVelvet].Name = "Black Velvet";
	DrinkNumber[BlackVelvet].Price = 1.25;
	DrinkNumber[BlackVelvet].Amount = 11;

	
	// Panama
	const int Panama = 1;
	DrinkNumber[Panama].Name = "Panama";
	DrinkNumber[Panama].Price = 1.50;
	DrinkNumber[Panama].Amount = 10;

	// Alexander
	const int Alexander = 2;
	DrinkNumber[Alexander].Name = "Alexander";
	DrinkNumber[Alexander].Price = 1.50;
	DrinkNumber[Alexander].Amount = 9;

	// Hurricane
	const int Hurricane = 3;
	DrinkNumber[Hurricane].Name = "Hurricane";
	DrinkNumber[Hurricane].Price = 1.75;
	DrinkNumber[Hurricane].Amount = 12;

	// Matador
	const int Matador = 4;
	DrinkNumber[Matador].Name = "Matador";
	DrinkNumber[Matador].Price = 2.00;
	DrinkNumber[Matador].Amount = 13;
	
	// make an introduction and show they user what drinks are available.
	cout << "Welcome!\nThis machine has a variety of products to choose from for your enjoyment." << endl << endl;
	
	// Giant do while loop.
	do
	{
		// Display the menu options
		cout << "\nPlease select something from the menu below." << endl << endl;
		for (int counter = 0; counter < DrinkTypes; counter++)
		{
			cout << counter + 1 << ". " << DrinkNumber[counter].Name << "\t -> $" << DrinkNumber[counter].Price << endl;
		}
		
		// Prompt the user of what drink they would want. The options go from 1 to 5 so the algorithm must take that into consideration. 
		cout << "\nWhat drink would you like?" << endl;
		cin >> DrinkOfChoice;

		while ((DrinkOfChoice != 1) & (DrinkOfChoice != 2) & (DrinkOfChoice != 3) & (DrinkOfChoice != 4) & (DrinkOfChoice != 5))
		{
			cout << "\nThe input " << DrinkOfChoice << " Is not Valid" << endl;
			cout << "Please input a valid choice (1, 2, 3, 4, or 5)." << endl;
			cin >> DrinkOfChoice;
		}
		
		// Extra line
		cout << endl;

		// Prompt the user of how many of these drinks they would like.
		cout << "How many " << DrinkNumber[(DrinkOfChoice - 1)].Name << "s would you like?" << endl;
		cout << "(Note: If Drink choice was on accident, just input 0.)" << endl;
		cin >> DrinkMultiples;
		
		if (DrinkMultiples == 0)
		{
			Key2 = Continue(Key1);

		}
		else if (isdigit(DrinkMultiples))
		{
			cout << "The input " << DrinkMultiples << " Is not Valid" << endl;
		}
		else if (!isdigit(DrinkMultiples))
		{
			if (DrinkNumber[(DrinkOfChoice - 1)].Amount == 0)
			{
				cout << "We are sold out of " << DrinkNumber[(DrinkOfChoice - 1)].Name << "s." << endl;
				Key2 = Continue(Key1);
				continue;
			}
			else if (DrinkMultiples > DrinkNumber[(DrinkOfChoice - 1)].Amount)
			{
				cout << "\nThere are only " << DrinkNumber[(DrinkOfChoice - 1)].Amount << " " << DrinkNumber[(DrinkOfChoice - 1)].Name << "s in inventory." << endl;
				cout << "\nPlease enter a new amount for drink quantity." << endl;
				cout << "(Note: if you wish to exit, please enter 0.)" << endl << endl;
				cout << "How many " << DrinkNumber[(DrinkOfChoice - 1)].Name << "s would you like?" << endl;
				cin >> DrinkMultiples;
				if (DrinkMultiples == 0)
				{
					Key2 = Continue(Key1);
						continue;
				}
			}
			else
			{
				// Ask for the money, prompt them if they are short on cash, and return change if needed.
				MoneyOwedByHuman = DrinkNumber[(DrinkOfChoice - 1)].Price * DrinkMultiples;
				cout << "\nPlease enter " << MoneyOwedByHuman;
				cout << endl;
				cin >> MoneyGivenByHuman;
				if (MoneyGivenByHuman >= 20.00)
				{
					cout << "\nThis Machine cannot take bills larger than 10.00" << endl << endl;
					Key2 = Continue(Key1);
					continue;
				}

				cout << endl;

				if (MoneyGivenByHuman > MoneyOwedByHuman)
				{
					Change = MoneyGivenByHuman - MoneyOwedByHuman;
					cout << "Your change is $" << Change << "." << endl;
					TotalAmountInMachine += MoneyGivenByHuman - Change;

					// Subtract the item amounts from the total inventory.
					DrinkNumber[(DrinkOfChoice - 1)].Amount -= DrinkMultiples;

				}
				else if (MoneyGivenByHuman == MoneyOwedByHuman)
				{
					TotalAmountInMachine += MoneyOwedByHuman;

					// Subtract the item amounts from the total inventory.
					DrinkNumber[(DrinkOfChoice - 1)].Amount -= DrinkMultiples;
			
					Key2 = Continue(Key1);
					continue;

				}
				else if (MoneyGivenByHuman < MoneyOwedByHuman)
				{
					cout << "\nYou do not have enough to complete the purchase." << endl;
					cout << "You are short by $" << MoneyOwedByHuman - MoneyGivenByHuman << endl << endl;
					cout << "Please take back your money below." << endl;
					cout << "Money returned -> $" << MoneyGivenByHuman << endl << endl;
					Key2 = Continue(Key1);
					continue;
				}
			}
		}
	
	} while (Key2 == 1); 

	cout << "Thank you for shopping!" << endl << endl;

	// Key and Data created and formatted.
	
	SalesReport << fixed << showpoint << setprecision(2);

	if (Key2 == -11)
	{
		SalesReport << "\t\t   SALES REPORT FOR VENDING MACHINE" << endl ;
		SalesReport << "\n\nName of Drink\t\tPrice of Drink\t\tAmount in Inventory" << endl;

		for (int Value = 0; Value < DrinkTypes; Value++)
		{
			SalesReport << endl;
			SalesReport << DrinkNumber[Value].Name << "\t\t\t";
			if (Value == 1 || Value == 4)
			{
				SalesReport << "\t";
			}
			SalesReport << DrinkNumber[Value].Price << "\t\t\t";
			SalesReport << DrinkNumber[Value].Amount << "\t\t\t" << endl;
		}

		SalesReport << "\nTOTAL AMOUNT: " << TotalAmountInMachine << endl;
		SalesReport << "\nNET GAIN: " << TotalAmountInMachine - 10 << endl;

	}
	
	return 0;
}
