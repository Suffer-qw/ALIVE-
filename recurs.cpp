// recurs.cpp : Этт файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
using namespace std;

void viwe(int* array, int size) {
    int z = 1;
    for (int i = 0; i < size - 1; i++) {
        cout << array[i] << endl;
    }
}


int sumarray(int* array, int size) {
    int y = 0;
    size = size - 1;
    if (size > 0) {
        return  array[size] + sumarray(array, size);
        //cout << " who" << array[size]-1<< endl;
    }
    else
        return  array[size];
    //cout << " ohw" << array[size]-1 << endl;

}

int view(int* array, int size) {

    size = size - 1;
    if (size > 0) {
        view(array, size);
        cout << array[size] - 1 << endl;
    }
    else
        return  array[size];
    //cout << " ohw" << array[size]-1 << endl;

}

void weiv(int* array, int size) {
    size = size - 1;
    if (size > 0) {
        cout << array[size]-1 << endl;
        weiv(array, size);
    }
    

}



void sum(int gg) {
    //3a+5b=n
    int a = 1;
    int b = 1;

    while (true)
    {

        int y = 3 * a + 5 * b;
        if (y == gg) {
            cout << a << " " << b;
            break;
        }
        if (y < gg) {
            a++;
            b++;
        }
        if (y > gg) {
            a--;
        }
        if (a < 0) {
            a = a + 5;

            b = b - 3;
        }

    }

    cout << endl;

}


int main()
{
    int size = 5;

    size++;
    int* array = new int[size];

    for (int i = 0; i < size; i++) {
        array[i] = i + 1;
    }

    //viwe(array, size);

    int x = view(array, size);
    cout << endl;
    weiv(array, size);

    /*for (int i = 8; i < 100; i++) {
        cout << i << endl;
        sum(i);

    }
    */


}


// recurs.cpp : Этт файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
using namespace std;

void viwe(int* array, int size) {
    int z = 1;
    for (int i = 0; i < size - 1; i++) {
        cout << array[i] << endl;
    }
}


int sumarray(int* array, int size) {
    int y = 0;
    size = size - 1;
    if (size > 0) {
        return  array[size] + sumarray(array, size);
        //cout << " who" << array[size]-1<< endl;
    }
    else
        return  array[size];
    //cout << " ohw" << array[size]-1 << endl;

}

int view(int* array, int size) {

    size = size - 1;
    if (size > 0) {
        view(array, size);
        cout << array[size] - 1 << endl;
    }
    else
        return  array[size];
    //cout << " ohw" << array[size]-1 << endl;

}

void weiv(int* array, int size) {
    size = size - 1;
    if (size > 0) {
        cout << array[size]-1 << endl;
        weiv(array, size);
    }
    

}



void sum(int gg) {
    //3a+5b=n
    int a = 1;
    int b = 1;

    while (true)
    {

        int y = 3 * a + 5 * b;
        if (y == gg) {
            cout << a << " " << b;
            break;
        }
        if (y < gg) {
            a++;
            b++;
        }
        if (y > gg) {
            a--;
        }
        if (a < 0) {
            a = a + 5;

            b = b - 3;
        }

    }

    cout << endl;

}


int main()
{
    int size = 5;

    size++;
    int* array = new int[size];

    for (int i = 0; i < size; i++) {
        array[i] = i + 1;
    }

    //viwe(array, size);

    int x = view(array, size);
    cout << endl;
    weiv(array, size);

    /*for (int i = 8; i < 100; i++) {
        cout << i << endl;
        sum(i);

    }
    */


}


