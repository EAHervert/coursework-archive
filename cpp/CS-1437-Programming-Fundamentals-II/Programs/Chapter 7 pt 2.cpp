#include <iostream>

using namespace std;

void D2Function1(int array[][2], int rows)
{
	int m = 0, n = 0;
	cout << "The inputs are:" << endl;

	for (int n = 0; n <= 1; n++)
	{
		for (int m = 0; m < rows; m++)
		{
			cout << m << ", " << n << ": ";
			cin >> array[m][n];
		}

	}
	
}

void D2Function2(int array[][2], int rows)
{
	for (int n = 0; n <= 1; n++)
	{
		for (int m = 0; m < rows; m++)
		{
			cout << array[m][n];
			cout << "	";
		}
		cout << endl;
		
	}
}

int main()
{
	
	cout << "This program will create a matrix that is 2 by 2." << endl;
	// cout << "Please choose an m: ";

	int Matrix[2][2];

	D2Function1(Matrix, 2);
	D2Function2(Matrix, 2);

	return 0;
}