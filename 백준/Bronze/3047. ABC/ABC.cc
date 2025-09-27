#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int main() {
	vector<int> nums(3);
	for (int i = 0; i < 3; i++)
		cin >> nums[i];

	string order;
	cin >> order;

	sort(nums.begin(), nums.end());
	
	for (char c : order) {
		if (c == 'A')
			cout << nums[0] << " ";
		else if (c == 'B')
			cout << nums[1] << " ";
		else if (c == 'C')
			cout << nums[2] << " ";
	}
	cout << '\n';
	return 0;
}