#include<iostream>
using namespace std;

int main()
{
	int max = INT32_MIN, a, b, c;

	for (int i = 1; i < 10; ++i)
	{
		for (int j = 1; j < 10; ++j)
		{
			cin >> a;
			if (max < a)
			{
				max = a;
				b = i;
				c = j;
			}
		}
	}
	cout << max << endl;
	cout << b << " " << c;
}