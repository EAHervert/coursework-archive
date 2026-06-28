#include <iostream>

using namespace std;

int main()
{
	int Array[2][2][2];

	for (int m = 0; m < 2; m++)
	{
		for (int n = 0; n < 2; n++)
		{
			for (int l = 0; l < 2; l++)
			{
				cout << m << " ," << n << ", " << l << ": ";
				cin >> Array[m][n][l];
				
			}
		}
	}

	cout << endl;

	for (int m = 0; m < 2; m++)
	{
		for (int n = 0; n < 2; n++)
		{
			for (int l = 0; l < 2; l++)
			{
				cout << m << " ," << n << ", " << l << ": ";
				cout << Array[m][n][l] << endl;
			}
		}
	}

	return 0;

}

