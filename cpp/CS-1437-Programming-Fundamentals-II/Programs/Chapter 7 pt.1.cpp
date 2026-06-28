#include <iostream>

using namespace std;

void function(int array[], int)
{
	cout << "\nThe first value was: " << array[0] << endl;
}

int main()
{
	int Test[10], counter = 0, sum = 0, max = 0;
	double average = 0;

	cout << "Please enter the values." << endl;
	for (int &vals : Test)
	{
		cout << counter << ": ";
		cin >> vals;
		counter = counter + 1;
	}

	counter = 0;

	cout << "\nHere are your values:" << endl;

	for (int vals : Test)
	{
		cout << counter << ": " << vals << "	";
		counter = counter + 1;
	}

	for (int vals : Test)
	{
		sum = sum + vals;
	}

	average = sum / 10;

	cout << "\nThe average of these values is " << average << endl;

	for (int vals : Test)
	{
		if (vals > max)
		{
			max = vals;
		}
	}

	int min;
	min = Test[0];

	for (int vals : Test)
	{
		if (vals < min)
		{
			min = vals;
		}
	}


	cout << "\nThe highest value is " << max << endl;
	cout << "\nThe lowest value is " << min << endl;

	function(Test,10);

	return 0;
}