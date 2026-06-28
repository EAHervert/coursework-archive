#include <iostream>
#include <vector>

using namespace std;

int main()
{
	int value;
	cout << "How large is this vector?" << endl;
	cin >> value;

	vector<int> test(value);

	for (int m = 0; m < value; m++)
	{
		cout << m << ": ";
		cin >> test[m];
	}

	cout << endl;
	
	for (int n = 0; n < value; n++)
	{
		cout << n << ": ";
		cout << test[n] << endl;
	}

	cout << "The size of the vector is: " << test.size() << endl;

	return 0;
}