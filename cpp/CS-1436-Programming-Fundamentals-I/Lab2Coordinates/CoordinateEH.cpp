//++++++++++++++++++++++++++++++++++++
// Author: Esau Hervert
// Course: COSC 1436
// Program: Lab 2 - Coordinate
//++++++++++++++++++++++++++++++++++++

/*
Write a C++ program that prompts the user to input the x-y coordinates of a point on a Cartesian
plane. The program should then output a message indicating whether the point is the origin, is located on the x or y axis, or appears in a particular quadrant. For example:

(0, 0) is the origin
(4, 0) is on the x-axis
(0, -3) is on the y-axis
(-2, 3) is in quadrant two

Output should look similar to below.
Sample Run:
Enter the x coordinate: 4
Enter the y coordinate: 5

The point (4, 5) is in quadrant I

*/

/*
Notes:
	Do not check for invalid inputs.  Name your program:  CoordinateXX.cpp, where XX are your initials.
	Set numbers as doubles.
*/
#include <iostream>

using namespace std;

int main()
{
	cout << "This program will give you information about your imputed coordinate" << endl;
	cout << "\nPlease enter the X coordinate: ";

	double XValue, YValue;
	cin >> XValue;

	cout << "Please enter the Y coordinate: ";
	cin >> YValue;
	cout << endl;

	cout << "The point" << " (" << XValue << ", " << YValue << ")";
	if (XValue == 0)
	{
		if (YValue == 0)
		{
			cout << " is at the origin." << endl;
		}
		else
		{
			cout << " is on the Y-Axis." << endl;
		}

	}
	 else if (YValue == 0)
	{
		if (XValue == 0)
		{
			cout << " is at the origin." << endl;
		}
		else
		{
			cout << " is on the X-Axis." << endl;
		}

	}
	 else if (XValue >= 0)
	 {
		 if (YValue >= 0)
		 {
			 cout << " is in Quadrant I." << endl;
		 }
		 else
		 {
			 cout << " is in Quadrant IV." << endl;
		 }

	 }
	 else if (XValue <= 0)
	 {
		 if (YValue >= 0)
		 {
			 cout << " is in Quadrant II." << endl;
		 }
		 else
		 {
			 cout << " is in Quadrant III." << endl;
		 }

	 }
	return 0;
}
