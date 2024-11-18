#include <iostream>
using namespace std;


int main(){
  //srand(time(0));
    int rows = 100;
    // rows - количество массивов
    int n = 5;
    //  n - количество значений
    
    float** arr = new float*[rows] ;
    // arr - 
    for (int i = 0; i < rows;i++) {
        arr[i] = new float[n];
    }
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < n; j++) {
            float x = rand()%100;
            arr[i][j] = x /100;
            //arr[номер массва] [номер значения массва]
        }
    }
    
for(int x = 0; x <rows + n; x++ ){
    for (int i = 0; i < rows; i++) {
      int x = 0;
        for (int j = 0; j < n-1; j++) {
          x = x + (arr[i][j] + arr[i][j+1]);
          if(x > 5){
            float x = rand()%100;
            arr[i][j] = x/100 ;
          }
        }
      }
  }
   
   float* good = new float [rows] ;
   for (int i = 0; i < rows; i++) {
        for (int j = 0; j < n; j++) {
          good[i]= good[i]+arr[i][j];
            //arr[номер массва] [номер значения массва]
        }
    }
    
    string* ball = new string[rows];
    
    for (int i = 0; i < rows; i++){
    
    float kryta = good[i];
    if(kryta >1.2){
       ball[i] = "2";
      if(kryta >1.8){
         ball[i] = "3";
        if(kryta >2.8){
           ball[i] = "4";
          if(kryta >3.5){
            ball[i] = "5";
          if(kryta >5){
            ball[i]="brak";
            continue;
          }
            
          }
        }
      }
    }
    else{
       ball[i] = "1";
    }
  }
    
    
    for (int i = 0; i < rows; i++) {
        if(ball[i] == "brak"){
            continue;
        }

        for (int j = 0; j < n; j++) {
            cout << arr[i][j]<< " ";
            //arr[номер массва] [номер значения массва]
        }
        cout <<"== "<< ball[i] << "{"<<i<<"}";
        cout << endl;

    }
  
  
}
