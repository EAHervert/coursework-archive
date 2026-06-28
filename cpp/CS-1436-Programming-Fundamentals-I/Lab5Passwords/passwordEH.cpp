
//++++++++++++++++++++++++++++++++++++
// Author: Esau Hervert
// Course: COSC 1436
// Program 5
//++++++++++++++++++++++++++++++++++++

/*
Implement the all the following as C++ programs for full credit.  Submit only .cpp files only.
Imagine you are developing a software package that required users to enter their own passwords.   You software requires that users’ passwords meet the follow criteria.
	The password should be at least 10 characters long.
	The password should contain at least one uppercase and at least one lowercase letter.
	The password should have at least one digit.
Write a program that asks for a password and then verifies that it meets the states criteria.  If it doesn’t, the program should display a message telling the user why it 
failed.  For example, “mypasswords” fails to meet at least one upper case and does not contain a digit.  If it fails to meet more than one criteria it should display all 
the reasons why it failed.  Name the file passwordXX.cpp

What needs to be done?
	Have a program that detects if there are 10 characters in a password. Check if there is at least one uppercase, one lower case, and one number.

How will it be done?
	Create a array that can be as long as the person having to imput the password wants it to be.
	Have it be at least 10 characters long, have an uppercase and a lowercase letter and have a digit.
*/

#include <iostream>
#include <cstring>
#include <string>

using namespace std;

int main()
{
	// Title
	cout << "\tThis program will test your Password to see if it is valid." << endl << endl;
	cout << "To be valid, it must contain 10 characters and it must contain at least: \none uppercase, one lowercase, and one numeric character." << endl << endl;
	// Initialize all the information to be used.
		int PasswordSize;
		string Password;
		int ValueUpper = 0, ValueLower = 0, ValueNumber = 0;
	// Get the password from the user.
		cout << "Enter any Password: ";
		cin >> Password;
		cout << "\nThe Password you entered is: " << Password << endl;
		PasswordSize = Password.length();
	// Check each character and make sure to count the uppercase, lowercase, and numeric characters.
	// Make sure to keep a count for all the characters for later in the program.
		for (int character = 0; character < PasswordSize; character++)
		{
			if (isupper(Password[character]))
			{
				ValueUpper += 1;
			}
			else if (islower(Password[character]))
			{
				ValueLower += 1;
			}
			else if (isdigit(Password[character]))
			{
				ValueNumber += 1;
			}
			else
			{
				cout << "\n\nThis Password is invalid!" << endl;
				if (PasswordSize < 10)
				{
					cout << "\nPasswords must be at least 10 characters long.";
				}
				cout << "\nIt must only include uppercase, lowercase, \nand numeric characters (0 to 9)." << endl << endl;
				return 0;
			}
		}
	// Test to see if there is the required characters and if there aren't, tell the user why.
		if (ValueUpper > 0 & ValueLower > 0 & ValueNumber > 0)
		{
			cout << "\n\nCongratulations!\n\nThis is a valid Password!" << endl << endl;
		}
		else
		{
			cout << "\n\nThis Password is invalid!";
			if (PasswordSize < 10)
			{
				cout << "\nPasswords must be at least 10 characters long.";
			}
			if (ValueUpper == 0)
			{
				cout << "\nYou need at least one uppercase character.";
			}
			if (ValueLower == 0)
			{
				cout << "\nYou need at least one lowercase character.";
			}
			if (ValueNumber == 0)
			{
				cout << "\nYou need at least one numeric character (0 to 9).";
			}
		}
		cout << endl << endl;
		return 0;
}
