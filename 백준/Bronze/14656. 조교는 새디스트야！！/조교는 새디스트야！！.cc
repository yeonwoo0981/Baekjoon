#include <iostream>
using namespace std;

int main() {
	int n;
	cin >> n;
	
	int wrong = 0; // 올바른 자리에 있지 않은 학생의 수를 저장하기 위한 변수 선언
	for (int i = 1; i <= n; i++) {
		int num; // 현재 위치에 있는 학생의 번호
		cin >> num;

		if (num != i) // 현재 위치가 올바른 자리가 아니면
			wrong++; // 추가
	}

	cout << wrong << endl; // 출력
	return 0;
}