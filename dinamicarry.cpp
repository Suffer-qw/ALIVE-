#include <iostream>
using namespace std;




int* CAR(int size_A) {
    int* newArr = new int[size_A];
    for (int i = 0; i < size_A; i++) {
        newArr[i] = rand()%10;
    }
    return newArr;
    
}

void arryvive(int* arry, int size_A) {
    for (int i = 0; i < size_A; i++) {
        cout <<" \033[32m" << arry[i] << "";
    }
}

int* sortArr(int* digitals, int size_A) {
    for (int i = 0; i < size_A; i++) {
        for (int j = 0; j < size_A-1; j++) {
            if (digitals[j] > digitals[j + 1]) {
                int b = digitals[j]; // создали дополнительную переменную
                digitals[j] = digitals[j + 1]; // меняем местами
                digitals[j + 1] = b; // значения элементов
            }
        }
    }
    return digitals;
}


int main() {
  
    int size_A;
    cin >> size_A;
    CAR(size_A);
    int* arry = CAR(size_A);
    arryvive(arry,size_A);
    sortArr( arry, size_A);
    cout << "|";
    system("CLS");
    arryvive(arry, size_A);





    
}
