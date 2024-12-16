string* returnTest(string& str) {
    string* stringPtr = new string; //Создание памяти под string по адресу 00000ABCX54                                             <- пример выполнения, адреса брать настоящие
    *stringPtr = str; //Берем по адресу 00000ABCX54 значение и устанавливаем его в "test" по адресу str            <- пример выполнения, адреса брать настоящие
    cout <<"STP " << stringPtr << endl;//ссылка
    return stringPtr;
   
}
// stringPtr == newStr
int main()
{
    string str = "test";
    string* newStr = returnTest(str);

    cout <<"newStr " << newStr << endl; //ссылка
    cout << "*newStr " << *newStr << endl;// значение
    cout << "&*newStr " << &*newStr << endl;// ссылка
    cout << "*&*newStr " << *&*newStr << endl;
    cout << "&*&*newStr " << &*&*newStr << endl;
    cout << "*&*&*newStr " << *&*&*newStr << endl;
}
