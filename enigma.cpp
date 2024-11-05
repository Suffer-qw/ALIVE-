
#include <iostream>
#include <string>
#include <map>
using namespace std;


int main()
{
	string gg = " ";
	string zxc;
	cin >> zxc;
	map <string, string> mp;
	mp["h"] = "1";
	mp["e"] = "2";
	mp["l"] = "3";
	mp["o"] = "4";
	mp["i"] = "5";
	map <string, string> pm;
	pm["1"] = "h";
	pm["2"] = "e";
	pm["3"] = "l";
	pm["4"] = "o";
	pm["5"] = "i";
	for (int i = 0; i < 5; i++) {
		string good = zxc.substr(0+i, 1);
		cout << mp[good];
		gg = gg + mp[good];
	}
	for (int i = 0; i < 6; i++) {
		string good = gg.substr(0 + i, 1);
		cout << pm[good];
		gg = gg + pm[good];
	}
	
}
