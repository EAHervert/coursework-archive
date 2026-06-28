/*You are going to implement a grading program for this course.See below for sample run.

Labs 35 % 6 labs  1 lowest grade dropped
Quiz 35 % 10 quizzes 1 lowest grade dropped
Exams 30 % 2 exams   no grades dropped


Acceptance criteria:
-	Create a console base program to calculate students overall grade.
-	Display a title to the user what this program will do.
-	Prompt the user to enter the grades for a particular section. Labs, quizzes and etc.
-	Provide data validation checks.   Do not let the user continue if invalid data is incorrect. If your want to make room for extra credit than add the range to allow for it. However, inform the user of the range.   If the user enters an invalid value do not accept the value and prompt again.   If the user keeps entering an invalid amount keep prompting the user until the data is valid.
-	When all values are entered.  Create a file called GradeReport.txt the user can open up and inspect the results. Make sure the report looks professional.  See example below. Do not just list all the grades straight down and spread multiple pages. The report must contain the following:
o	The report should consist of a title.
o	The report should also display all the grades the user entered based on what category; example lab, quiz and exam.
o	The report should display what grade was dropped in the lab and quiz category.
o	The report should display the average per each of the section with taken into the consideration of the lowest grade dropped.
o	The weighted percentage totals for each section.
o	The weighted grade for each section
o	The final average
o	The letter grade.
-	The program should prompt the user if he or she would like to run the program again.  Remember to check for data validation. If you prompt for a Y/N and the user enters in an ‘A’ or lower case y.

*/

/*
In order to do this, we will pull 3 arrays for the labs, quizzes, and Exams.
Make sure that it droppes the lowest grade when you average the grades.
Make sure to display the grade in the format that he wants.
*/

#include <iostream>
#include <iomanip>
#include <fstream>

using namespace std;

double LowestValueCalculator(double Values[], int Size)
{
	double LowestValue;
	LowestValue = Values[0];
	for (int Count = 0; Count < Size; Count++)
	{
		if (Values[Count] < LowestValue)
		{
			LowestValue = Values[Count];
		}
	}

	return LowestValue;
}

double AverageCalculator(double Values[], int Size)
{
	double Sum1 = 0, Sum2, Total, Average, LowestValue;

		for (int Counter = 0; Counter < Size; Counter++)
		{
			Sum1 += Values[Counter];
		}

			LowestValue = Values[0];
			for (int Count = 0; Count < Size; Count++)
			{
				if (Values[Count] < LowestValue)
				{
					LowestValue = Values[Count];
				}
			}
	Total = Size;
	Sum2 = Sum1 - LowestValue;
	Average = Sum2/ (Total - 1);
	
	return Average;

}

int main()
{
// Let the user know what the program will do.
	cout << "This Program will take your grades for the class and calculate your Total Grade." << endl;
	cout << "Note that the lowest grade one could get is a 0% and the highest is 110% when you get a 100% plus 10% Extra Credit." << endl << endl;


	// Gigantic Do while Loop with nested if statement to validate answe for run again.
	char AgainAnswer = 'Y';
	do
	{
		// Create the file to host all the data.
		ofstream GradeBookEH;
		GradeBookEH.open("GradeBookEH.txt");

		// Set precision throught the program
		GradeBookEH << fixed << showpoint << setprecision(2);

		// Create a Header.
		GradeBookEH << "					Grade Report for Spring 2015" << endl << endl;

		// Labs
		// List information on labs.
		GradeBookEH << "The Lab Grades are: ";
		
		// Getting Lab grades as an array from the user. Then writting it on the file. Doing data validation as well.
		double LabArray[6], LabAverage, LabLowestValue;
		for (int LabNumber = 0; LabNumber < 6; LabNumber++)
		{
			cout << "Please enter your grade for Lab " << LabNumber + 1 << " ";
			cin >> LabArray[LabNumber];
			if (LabArray[LabNumber] <= 110 && LabArray[LabNumber] > 0)
			{

				GradeBookEH << LabNumber + 1 << " - ";
				GradeBookEH << LabArray[LabNumber] << "% || ";
			}
			while (LabArray[LabNumber] > 110 || LabNumber < 0)
			{
				cout << "\n\nThe input is incorrect! Please enter a correct value." << endl;
				cout << "(The value must be between 0 and 110, considering Extra Credit.)" << endl << endl;
				cout << "Please enter your grade for Lab " << LabNumber + 1 << " ";
				cin >> LabArray[LabNumber];
				if (LabArray[LabNumber] <= 110 && LabArray[LabNumber] > 0)
				{
					GradeBookEH << LabNumber + 1 << " - ";
					GradeBookEH << LabArray[LabNumber] << "% || ";
				}
			}
		}

		// Displaying Dropped Grade and Average.
		LabLowestValue = LowestValueCalculator(LabArray, 6);
		GradeBookEH << "\nThe Lab Grade ommited was " << LabLowestValue << "%." << endl;
		LabAverage = AverageCalculator(LabArray, 6);
		GradeBookEH << "The Lab Average is " << LabAverage << "%.";
		cout << endl << endl;



		//Quizzes
		// List information on Quizzes.
		GradeBookEH << "\n\nThe Quiz Grades are: ";

		double QuizArray[10], QuizAverage, QuizLowestValue;
		for (int QuizNumber = 0; QuizNumber < 10; QuizNumber++)
		{
			cout << "Please enter your grade for Quiz " << QuizNumber + 1 << " ";
			cin >> QuizArray[QuizNumber];
			if (QuizArray[QuizNumber] <= 110 && QuizArray[QuizNumber] > 0)
			{

				GradeBookEH << QuizNumber + 1 << " - ";
				GradeBookEH << QuizArray[QuizNumber] << "% || ";
			}
			while (QuizArray[QuizNumber] > 110 || QuizArray[QuizNumber] < 0)
			{
				cout << "\nThe input is incorrect! Please enter a correct value." << endl;
				cout << "(The value must be between 0 and 110, considering Extra Credit.)" << endl << endl;
				cout << "Please enter your Grade for Quiz " << QuizNumber + 1 << " ";
				cin >> QuizArray[QuizNumber];
				if (QuizArray[QuizNumber] <= 110 && QuizArray[QuizNumber] > 0)
				{

					GradeBookEH << QuizNumber + 1 << " - ";
					GradeBookEH << QuizArray[QuizNumber] << "% || ";
				}
			}

		}
		// Displaying Dropped Grade and Average.
		QuizLowestValue = LowestValueCalculator(QuizArray, 10);
		GradeBookEH << "\nThe Quiz Grade ommited was " << QuizLowestValue << "%." << endl;
		QuizAverage = AverageCalculator(QuizArray, 10);
		GradeBookEH << "The Quiz Average is " << LabAverage << "%";
		cout << endl << endl;

		// Tests
		// List information on Quizzes.
		GradeBookEH << "\n\nThe Test Grades are: ";

		double TestArray[2];
		for (int TestNumber = 0; TestNumber < 2; TestNumber++)
		{
			cout << "Please enter your Grade for Test " << TestNumber + 1 << " ";
			cin >> TestArray[TestNumber];
			if (TestArray[TestNumber] <= 110 && TestArray[TestNumber] > 0)
			{

				GradeBookEH << TestNumber + 1 << " - ";
				GradeBookEH << TestArray[TestNumber] << "% || ";
			}
			while (TestArray[TestNumber] > 110 || TestNumber < 0)
			{
				cout << "\n\nThe input is incorrect, Please enter a correct value." << endl;
				cout << "(The value must be between 0 and 110, considering Extra Credit.)" << endl << endl;
				cout << "Please enter your Grade for Test " << TestNumber + 1 << " ";
				cin >> TestArray[TestNumber];
				if (TestArray[TestNumber] <= 110 && TestArray[TestNumber] > 0)
				{

					GradeBookEH << TestNumber + 1 << " - ";
					GradeBookEH << TestArray[TestNumber] << "% || ";
				}
			}

		}
		// Calculate the Test Average.
		double TestTotal = 0;
		double TestAverage;
		for (int TestNumber = 0; TestNumber < 2; TestNumber++)
		{
			TestTotal += TestArray[TestNumber];
		}
		TestAverage = TestTotal / 2;
		GradeBookEH << "\nThe Test Average is " << TestAverage << "%." << endl;
		GradeBookEH << "No Test Grades are dropped.";

		//Total Grades
		//Prompt the user on how the overall Grade calculation.
		GradeBookEH << "\n\nThe Total Grade is equal to 35% of your Lab Grade, 35% of your Quiz Grade, and 30% of your Test Grade.";

		double GrandTotal, WeightedLab, WeightedQuiz, WeightedTest;

		GradeBookEH << "\nThe Weighted Totals are: ";
		WeightedLab = LabAverage * .35;
		WeightedQuiz = QuizAverage * .35;
		WeightedTest = TestAverage * .30;
		GradeBookEH << "Lab - " << WeightedLab << "% || Quiz " << WeightedQuiz << "% || Test " << WeightedTest << "% ||";
		GrandTotal = (.35 * LabAverage) + (.35 * QuizAverage) + (.3 * TestAverage);
		GradeBookEH << "\n\nYour Total Grade for the class is " << GrandTotal << "%.";

		// Let you know what Letter Grade you got.
		if (GrandTotal > 0 && GrandTotal < 60)
		{
			GradeBookEH << "\nYou got a F!" << endl;
		}
		else if (GrandTotal >= 60 && GrandTotal < 70)
		{
			GradeBookEH << "\nYou got a D!" << endl;
		}
		else if (GrandTotal >= 70 && GrandTotal < 80)
		{
			GradeBookEH << "\nYou got a C! You Passed!" << endl;
		}
		else if (GrandTotal >= 80 && GrandTotal < 90)
		{
			GradeBookEH << "\nYou got a B! Congratulations!" << endl;
		}
		else if (GrandTotal >= 90 && GrandTotal <= 100)
		{
			GradeBookEH << "\nYou got a A! Congratulations!" << endl;
		}
		else if (GrandTotal > 100 && GrandTotal <= 110)
		{
			GradeBookEH << "\nYou got a A++! We got a smart one over here!" << endl;
		}
		else if (GrandTotal > 110)
		{
			GradeBookEH << "\nHOW!!!!!!!" << endl;
		}
		
	// Let the user know that you have completed the file.
		cout << "\nFile Created." << endl;
		
		cout << "\nWould you like to run again?" << endl << "\nPlease enter Y for Yes or N for No." << endl;
		cout << "\nAgain: ";
		cin >> AgainAnswer;
		cout << endl;

		GradeBookEH.close();
		
	// Loop to validate answer.
		int t_f = 0;
		do 
		{
			if (AgainAnswer != 'Y')
			{
				if (AgainAnswer != 'y')
				{
					if (AgainAnswer != 'N')
					{

						if (AgainAnswer == 'n')
						{
							t_f = 0;
						}
						else
						{
							cout << "\nInvalid input! Please enter Y for Yes or N for No." << endl;
							cin >> AgainAnswer;
							t_f = 1;
						}
					}
					else
						t_f = 0;
				}
				else
					t_f = 0;
			}
			else
				t_f = 0;
			
		} while (t_f == 1);

	}while (AgainAnswer == 'Y' || AgainAnswer == 'y');

}
