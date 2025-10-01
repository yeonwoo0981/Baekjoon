#include <iostream>
using namespace std;

int plusWays[11] = { 1, 2, 4 };

int main() { 
	int t, n;

	for (int i = 3; i < 11; i++) {
		plusWays[i] = plusWays[i - 1] + plusWays[i - 2] + plusWays[i - 3];
	}

	cin >> t;

	while (t--) {
		cin >> n;
		cout << plusWays[n - 1] << endl;
	}

	return 0;
}