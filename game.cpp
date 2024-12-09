#include <iostream> 
#include "windows.h" 

using namespace std;


int SIZE_MAP_X = 10;
int SIZE_MAP_Y = 10;
int Player_X = 9;
int Player_Y = 2;
char** map = new char* [SIZE_MAP_X];
/*
x
0 1 2 3 4 5 6 7 8 9 10 
1 * * * * * * * * * *  
2 *                 *
3 *  * * *  * * * * *
4 *  *
5 *  *  *  *        *
6 *     *  *        *
7 *    * * * * *    *
8 *                 *
9 *            *    *
1 * * * * * * * * * * 
          y


*/


void InitMap(int character_x, int character_y) {
    for (int i = 0; i < SIZE_MAP_X; i++) {
        map[i] = new char[SIZE_MAP_Y];
        for (int j = 0; j < SIZE_MAP_Y; j++) {
            if (i == 0 || i == SIZE_MAP_Y - 1 || j == 0 || j == SIZE_MAP_Y - 1) {
                map[i][j] = '*';
            }
            else {
                if (i == character_x && j == character_y)
                    map[i][j] = '@';                
                else
                    map[i][j] = ' ';
            }
        }
    }

    map[2][5] = '*';


    map[3][2] = '*';
    map[3][3] = '*';
    map[3][4] = '*';
    map[3][5] = '*';

    map[3][7] = '*';
    map[3][8] = '*';

    map[4][2] = '*';
    map[5][2] = '*';

    map[6][4] = '*';
    map[5][4] = '*';

    map[6][6] = '*';
    map[5][6] = '*';

    map[7][3] = '*';
    map[7][4] = '*';
    map[7][5] = '*';
    map[7][6] = '*';
    map[7][7] = '*';

    map[4][9] = ' ';
}
void PrintPlace(int x , int y) {
    for (int i = 0; i < SIZE_MAP_X; i++) {
        for (int j = 0; j < SIZE_MAP_Y; j++) {
            if (i == x-1 && j == y-1)
            {
                cout << '>';
                continue;
            }
            cout << map[i][j] << " ";
        }        cout << endl;
    }
    
}
void PrintPlace() {
    for (int i = 0; i < SIZE_MAP_X; i++) {
        for (int j = 0; j < SIZE_MAP_Y; j++) {
            cout << map[i][j] << " ";
        }        cout << endl;
    }

}

void RedrawPlace() {
    system("cls");
    PrintPlace();
}
bool MovePlayer(int destination_x, int destination_y) {
    if (map[destination_x][destination_y] != '*') {
        Player_X = destination_x;
        Player_Y = destination_y;
        for (int i = 0; i < SIZE_MAP_X; i++) {
            for (int j = 0; j < SIZE_MAP_Y; j++) {
                if (map[i][j] == '@')                    
                    map[i][j] = ' ';
            }
        }
        map[destination_x][destination_y] = '@';
        return true;
    }
    else        
        return false;
}

bool Winner(int x, int y) {
    if (Player_X == x && Player_Y == y) {
        cout << endl << "WINNER!" << endl;
        return false;
    }
    else
        return true;
    
}


bool MovePlayerX(int destination_x, int destination_y) {
    if (map[destination_x][destination_y] != '*') {
        Player_X = destination_x;
        Player_Y = destination_y;
        for (int i = 0; i < SIZE_MAP_X;i++) {
            for (int j = 0; j < SIZE_MAP_Y; j++) {
                if (map[i][j + 1] == '*')
                {
                    map[i][j] = '@';
                    map[i][j] = ' ';
                    break;
                }
            }
        }
        map[destination_x][destination_y] = '@';
        return true;
    }
    else        
        return false;
}


int main()
{
    //srand(time(0));
    InitMap(1, 1);
    int gg = 0;
    bool over = true;
    while (over) {
        for (int i = 0; i < 1; i++) {
            MovePlayerX(Player_X, Player_Y);
        }

        Sleep(10);
        RedrawPlace();
        over = Winner(4, 9);
        gg++;
    }


    /*
    while (over) {
        switch (rand() % 4) {
        case 0:                
            MovePlayer(Player_X + 1, Player_Y);
            break;           
        case 1:
            MovePlayer(Player_X - 1, Player_Y);                
            break;
        case 2:                
            MovePlayer(Player_X, Player_Y + 1);
            break;            
        case 3:
            MovePlayer(Player_X, Player_Y - 1);               
            break;
        }        
        Sleep(10);
        RedrawPlace();
        over = Winner(4, 9);
        gg++;
    }*/
    cout << gg;
    //364
}
