#include <iostream>
#include <iomanip>
using namespace std;

int main() { 
	int t;
	cin >> t;
	cout << fixed << setprecision(1);

	while (t--) {
		int n;
		cin >> n;

		int credit = 0;
		float gpa = 0;

		while (n--) {
			int c;
			float g;
			cin >> c >> g;
			credit += c;
			gpa += c * g;
		}

		cout << credit << " " << gpa / credit << "\n";
	}
	return 0;
}