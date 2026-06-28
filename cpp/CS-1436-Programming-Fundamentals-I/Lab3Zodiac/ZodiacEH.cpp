/*Write a C++ program where the user types in a birthday (month and day) the program responds with the appropriate
western zodiac sign for that birthday.The month is entered as a number from 1 to 12 and day as 1 to 31.
Use a function to determine the western zodiac sign associated with the date entered. Check for date validation
to all parts to your program. The program should also include a loop that lets the user repeat this calculation until the
user says he/she is done. Output should look similar to below.*/

/*Sign	Dates
Capricorn	12/22-1/19
Aquarius	1/20-2/18
Pisces		2/19-3/20
Aries		3/21-4/19
Taurus		4/20-5/20
Gemini		5/21-6/21
Cancer		6/22-7/22
Leo			7/23-8/22
Virgo		8/23-9/22
Libra		9/23-10/23
Scorpio		10/24-11/21
Sagittarius	11/22-12/21
*/

#include <iostream>

using namespace std;

int main()
{
	cout << "This Program will let you know what your Zodiac Sign is by using your" << endl;
	cout << "Month and Day of birth." << endl;
	cout << "\n*Note that these values must be imputed as numeric values.*" << endl;

	// The Giant do while loop for the program
	char Answer;
	int Month = 9, Day = 26;
	do
	{
		cout << "\nPlease enter the Month that you were born: ";
		cin >> Month;
		cout << endl;


		while (Month <= 0 || Month >= 13)
		{
			cout << "*The Value of the Month must be between 1 and 12*" << endl;
			cout << "Please enter the Month that you were born: ";
			cin >> Month;
			cout << endl;
		}


		cout << "Please enter the Day that you were born: ";
		cin >> Day;
		cout << endl;

			// Month of January
			if (Month == 1)
			{
				while (Day <= 0 || Day >= 32)
				{
					cout << "*The Value of the Day must be between 1 and 31*" << endl;
					cout << "Please enter the Day that you were born: ";
					cin >> Day;
					cout << endl;

				}

					if (Day <= 19)
					{
						cout << "The Zodiac sign for someone born on January " << Day << " is Capricorn" << endl;
					}
					else if (Day >= 20)
					{
						cout << "The Zodiac sign for someone born on January " << Day << " is Aquarius" << endl;
					}

					cout << "\nDo you wish to run again? \n\nPress Y to run again or N to end the program.\n" << endl;
					cin >> Answer;
					cout << endl;
			}

			// Month of February
			if (Month == 2)
			{
				while (Day <= 0 || Day >= 30)
				{
					cout << "*The Value of the Day must be between 1 and 29*" << endl;
					cout << "Please enter the Day that you were born: ";
					cin >> Day;
					cout << endl;

				}

					if (Day <= 18)
					{
						cout << "The Zodiac sign for someone born on February " << Day << " is Aquarius" << endl;
					}
					else if (Day >= 19)
					{
						cout << "The Zodiac sign for someone born on February " << Day << " is Pisces" << endl;
					}

					cout << "\nDo you wish to run again? \n\nPress Y to run again or N to end the program.\n" << endl;
					cin >> Answer;
					cout << endl;
			}

			// Month of March
			if (Month == 3)
			{
				while (Day <= 0 || Day >= 32)
				{
					cout << "*The Value of the Day must be between 1 and 31*" << endl;
					cout << "Please enter the Day that you were born: ";
					cin >> Day;
					cout << endl;

				}

					if (Day <= 20)
					{
						cout << "The Zodiac sign for someone born on March " << Day << " is Pisces" << endl;
					}
					else if (Day >= 21)
					{
						cout << "The Zodiac sign for someone born on March " << Day << " is Aries" << endl;
					}

					cout << "\nDo you wish to run again? \n\nPress Y to run again or N to end the program.\n" << endl;
					cin >> Answer;
					cout << endl;
			}

			// Month of April
			if (Month == 4)
			{
				while (Day <= 0 || Day >= 31)
				{
					cout << "*The Value of the Day must be between 1 and 30*" << endl;
					cout << "Please enter the Day that you were born: ";
					cin >> Day;
					cout << endl;

				}

					if (Day <= 19)
					{
						cout << "The Zodiac sign for someone born on April " << Day << " is Aries" << endl;
					}
					else if (Day >= 20)
					{
						cout << "The Zodiac sign for someone born on April " << Day << " is Taurus" << endl;
					}

					cout << "\nDo you wish to run again? \n\nPress Y to run again or N to end the program.\n" << endl;
					cin >> Answer;
					cout << endl;
			}

			// Month of May
			if (Month == 5)
			{
				while (Day <= 0 || Day >= 32)
				{
					cout << "*The Value of the Day must be between 1 and 31*" << endl;
					cout << "Please enter the Day that you were born: ";
					cin >> Day;
					cout << endl;

				}

					if (Day <= 20)
					{
						cout << "The Zodiac sign for someone born on May " << Day << " is Taurus" << endl;
					}
					else if (Day >= 21)
					{
						cout << "The Zodiac sign for someone born on May " << Day << " is Gemini" << endl;
					}

					cout << "\nDo you wish to run again? \n\nPress Y to run again or N to end the program.\n" << endl;
					cin >> Answer;
					cout << endl;
			}

			// Month of June
			if (Month == 6)
			{
				while (Day <= 0 || Day >= 31)
				{
					cout << "*The Value of the Day must be between 1 and 30*" << endl;
					cout << "Please enter the Day that you were born: ";
					cin >> Day;
					cout << endl;

				}

					if (Day <= 21)
					{
						cout << "The Zodiac sign for someone born on June " << Day << " is Gemini" << endl;
					}
					else if (Day >= 22)
					{
						cout << "The Zodiac sign for someone born on June " << Day << " is Cancer" << endl;
					}

					cout << "\nDo you wish to run again? \n\nPress Y to run again or N to end the program.\n" << endl;
					cin >> Answer;
					cout << endl;
			}

			// Month of July
			if (Month == 7)
			{
				while (Day <= 0 || Day >= 32)
				{
					cout << "*The Value of the Day must be between 1 and 31*" << endl;
					cout << "Please enter the Day that you were born: ";
					cin >> Day;
					cout << endl;

				}

					if (Day <= 23)
					{
						cout << "The Zodiac sign for someone born on July " << Day << " is Cancer" << endl;
					}
					else if (Day >= 23)
					{
						cout << "The Zodiac sign for someone born on July " << Day << " is Leo" << endl;
					}

					cout << "\nDo you wish to run again? \n\nPress Y to run again or N to end the program.\n" << endl;
					cin >> Answer;
					cout << endl;
			}

			// Month of August
			if (Month == 8)
			{
				while (Day <= 0 || Day >= 32)
				{
					cout << "*The Value of the Day must be between 1 and 31*" << endl;
					cout << "Please enter the Day that you were born: ";
					cin >> Day;
					cout << endl;

				}

					if (Day <= 22)
					{
						cout << "The Zodiac sign for someone born on August " << Day << " is Leo" << endl;
					}
					else if (Day >= 23)
					{
						cout << "The Zodiac sign for someone born on August " << Day << " is Virgo" << endl;
					}

					cout << "\nDo you wish to run again? \n\nPress Y to run again or N to end the program.\n" << endl;
					cin >> Answer;
					cout << endl;
			}

			// Month of September
			if (Month == 9)
			{
				while (Day <= 0 || Day >= 31)
				{
					cout << "*The Value of the Day must be between 1 and 30*" << endl;
					cout << "Please enter the Day that you were born: ";
					cin >> Day;
					cout << endl;

				}

					if (Day <= 22)
					{
						cout << "The Zodiac sign for someone born on September " << Day << " is Virgo" << endl;
					}
					else if (Day >= 23)
					{
						cout << "The Zodiac sign for someone born on September " << Day << " is Libra" << endl;
					}

					cout << "\nDo you wish to run again? \n\nPress Y to run again or N to end the program.\n" << endl;
					cin >> Answer;
					cout << endl;
			}

			// Month of October
			if (Month == 10)
			{
				while (Day <= 0 || Day >= 32)
				{
					cout << "*The Value of the Day must be between 1 and 31*" << endl;
					cout << "Please enter the Day that you were born: ";
					cin >> Day;
					cout << endl;

				}

					if (Day <= 23)
					{
						cout << "The Zodiac sign for someone born on October " << Day << " is Libra" << endl;
					}
					else if (Day >= 24)
					{
						cout << "The Zodiac sign for someone born on October " << Day << " is Scorpio" << endl;
					}

					cout << "\nDo you wish to run again? \n\nPress Y to run again or N to end the program.\n" << endl;
					cin >> Answer;
					cout << endl;
			}

			// Month of November
			if (Month == 11)
			{
				while (Day <= 0 || Day >= 31)
				{
					cout << "*The Value of the Day must be between 1 and 30*" << endl;
					cout << "Please enter the Day that you were born: ";
					cin >> Day;
					cout << endl;

				}

					if (Day <= 21)
					{
						cout << "The Zodiac sign for someone born on November " << Day << " is Scorpio" << endl;
					}
					else if (Day >= 22)
					{
						cout << "The Zodiac sign for someone born on November " << Day << " is Sagittarius" << endl;
					}

					cout << "\nDo you wish to run again? \n\nPress Y to run again or N to end the program.\n" << endl;
					cin >> Answer;
					cout << endl;
			}

			// Month of December
			if (Month == 12)
			{
				while (Day <= 0 || Day >= 32)
				{
					cout << "*The Value of the Day must be between 1 and 31*" << endl;
					cout << "Please enter the Day that you were born: ";
					cin >> Day;
					cout << endl;

				}

					if (Day <= 21)
					{
						cout << "The Zodiac sign for someone born on December " << Day << " is Sagittarius" << endl;
					}
					else if (Day >= 22)
					{
						cout << "The Zodiac sign for someone born on December " << Day << " is Capricorn" << endl;
					}

					cout << "\nDo you wish to run again? \n\nPress Y to run again or N to end the program.\n" << endl;
					cin >> Answer; 
					cout << endl;
			}
		
	} while (Answer == 'Y' || Answer == 'y');
		return 0;
}
