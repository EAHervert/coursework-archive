/*
	Rainfall Statistics

	Write a program that lets the user enter the total rainfall for each of 12 months into
	an array of double s. The program should calculate and display the total rainfall for
	the year, the average monthly rainfall, and the months with the highest and lowest
	amounts.
	
	Input Validation: Do not accept negative numbers for monthly rainfall figures.
*/

#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
	cout << "Rainfall Statistics" << endl;
	cout << "\nThis program will calculate the total rainfall for the year." << endl;
	
	// Create constant to hold values
	const int Months = 12;

	// Array holding rainfall
	double itrainedalot[Months];

	// Ask for the values
	 for (int MonthNumber = 0; MonthNumber < Months; MonthNumber++)
		{
			cout << "\nPlease enter the rain amount for Month " << MonthNumber + 1 << "	";
			cin >> itrainedalot[MonthNumber];
			cout << endl;
		}
	 for (int MonthNumber = 1; MonthNumber < Months; MonthNumber++)
	 {
		 cout << itrainedalot[MonthNumber] << " ";
	 }
}
