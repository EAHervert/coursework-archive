//++++++++++++++++++++++++++++++++++++
// Author: Esau Hervert
// Course: COSC 1436
// Lab 1
//++++++++++++++++++++++++++++++++++++

/* This lab is meant to calculate the amount of dimples on new golf balls. We are to get the surface area and the area for one golf ball dimple.
we are also given that the surface area of a sphere is SA == 4 * PI * r^2. We are to prompt the user to give us the diameter of the golf ball in inches.
we are to display to them: the ball's diameter, surface area, and total amount of dimples.*/

/* Notes:
	The imput is in diameters but the equation deals with radius so a conversion must take place.
	The dimple count must be an interger and the other values must be at a 2 decimal precision.
	*/

#include <iostream>
#include <cmath>
#include <iomanip>

using namespace std;

int main()
{
				// First I will define all the variables that I will be using.
	const double PI = 3.141592653589793;
	double SurfaceArea, Diameter, Radius, AreaForOneGolfBallDimple;
	int DimpleAmounts;

				// Now I ask them the Diameter.

	cout << "This program will calculate the amount of dimples a particular golf ball has.\n";
	
	cout << "\nPlease enter the diameter of the golf ball in inches:		";

	cin >> Diameter;

				// Now I convert the Diameter to the Radius.

	Radius = Diameter / 2;

				// I now ask for the square-inch-per-dimple factor.

	cout << "\nPlease enter the area for one golf ball dimple in inches:	";

	cin >> AreaForOneGolfBallDimple;

				// Now I perform the calculations.

	SurfaceArea = 4 * PI * pow(Radius, 2);

	DimpleAmounts = SurfaceArea / AreaForOneGolfBallDimple;

				// I now format the precision of our answers.

	cout << fixed << showpoint << setprecision(2);

				// Now I can display all that needs to be displayed.
	
	cout << "\n\nThe Diameter of the golf ball is " << Diameter << " inches."<< endl;

	cout << "\nThe Surface Area of the golf ball is " << SurfaceArea << " inches squared." << endl;

	cout << "\nThe Dimple Amount on the golf ball is " << DimpleAmounts << " Dimples.\n" << endl;

	return 0;
}
