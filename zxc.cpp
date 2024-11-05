#include <string>
#include <iostream>
#include <math.h>
using namespace std;

void romb(float& y, float& x)
{
	int z=0;
	if ((y >= -0.5*x - 1 && y <= 0.5*x + 1 && x <= 1) or (1 >= pow(y,2) + pow(x, 2) && x>= 0 )) {
		z = z + 1;
	}
	cout << " ";
	if (y <= 1) {
		z = z + 1;
	}
	if (z == 2) {
		cout << "verno,";
	}
	else {
		cout << "not verno,";
	}
}
/*void romb(float& y, float& x)
{
	if ((y >= 2 * x - 1) && (y <= 2 * x + 1)&& (y >= -2 * x - 1) && (y <= -2 * x + 1)) {
		cout << "verno";
	}
	else {
		cout << "not verno";
	}
}
int main()
{
string zxc;
	zxc = "01022037";
	int xxc = stoi(zxc);
	int age = stoi(zxc.substr(4, 4));
	if (xxc > 01012000) {
		for (int i = 2000; i <= age; i += 4) {
			cout << " " << i;
		}

	}
}

int main()
{
	int zxc;
	cin >> zxc;
	zxc = zxc - 978285661;
	zxc /= 60*60*24;
	while (zxc > 100) {
		zxc = zxc - 365;
	}
	cout << zxc;
}

int main()
{
	srand(time(0));
	int f = 0;
	int b = 0;
	int zxc[30];
	for(int i = 0; i < 30; i++) {
		zxc[i] = rand() % 60 - 30;
	}
	for (int i = 0; i < 30; i++) {
		cout << zxc[i] << " ";
	}
	for (int i = 0; i < 30; i++) {
		if (zxc[i] > 0 ) {
			b++;
		}
	}

	for (int i = 0; i < 30; i++) {
		f = f + zxc[i];
	}
	cout << f / 30 << " ";
	cout << b;
}
*/

int main()
{
	long int mat[10][10];

	for (int i = 0; i < 10; i+=1) {
		for (int j = 0; j < 10; j++) {
			mat[i][j] = j+10*i;
		}
	}
	for (int i = 0; i < 10; i++) {
		
		for (int j = 0; j < 10; j++) {
			if (j == 5) {
				cout << "*"<< " ";
				j++;
			}
			if (i == 5) {
				for (int x = 0; x < 10; x++) {
					cout << "*" << " ";
				}
				break;
			}
			cout << mat[i][j]<< " ";
		}
		cout << endl;
	}
	
}
