/*
5. Membership Fees Increase
A country club, which currently charges $2,500 per year for membership, has
announced it will increase its membership fee by 4% each year for the next six years.
Write a program that uses a loop to display the projected rates for the next six years.
*/

#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
	cout << "This program will calculate membership fees for the next 6 years\n";

	double Mem_Year = 2500;
	double Increase = 0.04;

	cout << setprecision(2) << showpoint << fixed;
	for (int num = 1; num <= 6; num++)
	{
		Mem_Year = Mem_Year + (Mem_Year * Increase);
		cout << "The amount for year " << num << " is " << Mem_Year << endl;
	}
}
