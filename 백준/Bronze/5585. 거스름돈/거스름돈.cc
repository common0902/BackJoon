#include<iostream>
using namespace std;

int main()
{
	int a, count =0;
	cin >> a;
	a = 1000 - a;
	while (true)
	{
		if (a == 0) break;
		if (a - 500 >= 0) a -= 500;
		else if (a - 100 >= 0) a -= 100;
		else if (a - 50 >= 0) a -= 50;
		else if (a - 10 >= 0) a -= 10;
		else if (a - 5 >= 0) a -= 5;
		else if (a - 1 >= 0) a -= 1; 
		count++;
	}
	cout << count;
}