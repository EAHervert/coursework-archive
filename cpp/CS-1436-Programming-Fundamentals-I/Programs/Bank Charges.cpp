//++++++++++++++++++++++++++++++++++++
// Author: Esau Hervert
// Course: COSC 1436
// Bank Charges
//++++++++++++++++++++++++++++++++++++


//What do I know?

	/*A bank charges $10 per month plus the following check fees for a commercial checking
	account:
	$.10 each for fewer than 20 checks
	$.08 each for 20–39 checks
	$.06 each for 40–59 checks
	$.04 each for 60 or more checks
	The bank also charges an extra $15 if the balance of the account falls below $400 (before
	any check fees are applied). Write a program that asks for the beginning balance and the
	number of checks written. Compute and display the bank’s service fees for the month.
	Input Validation: Do not accept a negative value for the number of checks written. If a
	negative value is given for the beginning balance, display an urgent message indicating
	the account is overdrawn.*/

// What do I need?
	// Number of Checks
	// Starting balance

// Flowchart
/*
		[Title] >_
		[Get balances] >_
		<balance (<0)>	(T)-> Error >_
		(F) >_
		<Balance (<400)> (T)-> add 15 >_
		(F) >_
		[Number of Checks] >_
		[[Conditional testing for checks]] >>_
		[Add all fees] >_
		[Display] >_
*/

#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
	cout << "This program will calculate fees for your checking account.\n\n";

	double balance;
	cout << "Please enter your balance: $";
	cin >> balance;

	if (balance < 0)
	{
		cout << "\n\nUrgent: Account is overdrawn.\n\n";
		return 0;
	}

	const double ExtraCharge = 15.00;
		double TotalFees = 10; // Went ahead and added the flat fee of 10 dollars here

	if (balance < 400)
	{
		TotalFees += ExtraCharge;
	}

	int Checks;
	cout << "\nPlease enter how many checks you wrote this month? ";
	cin >> Checks;

	if (Checks < 0)
	{
		cout << "\nYou cannot have a negative amount for checks written." << endl;
		cout << "\n	Please enter a positive answer or enter a \"0\" if no checks were written\n\n";
		cin >> Checks;
	}

	double CheckFees;

	if ((Checks >= 0) && (Checks < 20))
	{
		CheckFees = .1;
	}
	else if ((Checks >= 20) && (Checks < 40))
	{
		CheckFees = .08;
	}
	else if ((Checks >= 40) && (Checks < 60))
	{
		CheckFees = .06;
	}
	else if (Checks >= 60)
	{
		CheckFees = .04;
	}
	
	double TotalCheckFees, GrandTotal;
	TotalCheckFees = CheckFees * Checks;
	GrandTotal = TotalFees + TotalCheckFees;

	cout << fixed << showpoint << setprecision(2);
		cout << "\nThe Total amount owed this month is $" << GrandTotal << endl;
		cout << endl;
		return 0;

}
