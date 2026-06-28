#include <iostream>
#include <string>

using namespace std;

struct MovieData
{
	string Title;
	string Director;
	int Year;
	int Runtime;

};

void PrintMovie(MovieData);

int main()
{
	MovieData Movie1 = { "Dukes of Hazard", "John Doe", 1990, 120 };
	MovieData Movie2 = { "Spiderman", "The Producer", 2007, 560 };
	PrintMovie(Movie1);
	MovieData *Movieptr = &Movie2;
	PrintMovie(*Movieptr);
	
	system("pause");
	return 0;
}

void PrintMovie(MovieData data)
{
	cout << "\n\tTitle: " << data.Title;
	cout << "\n\tDirector: " << data.Director;
	cout << "\n\tYear: " << data.Year;
	cout << "\n\tRuntime: " << data.Runtime << endl;

}
