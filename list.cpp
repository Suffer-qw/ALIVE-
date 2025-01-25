
#include <iostream>
using namespace std;

struct item
{
    int d = 0;
    item* p = nullptr;//прошлый 
    item* n = nullptr;//следующий   
};

struct mlist
{
    item* s = nullptr;//первый
    item* e = nullptr;//последний
    item* c = nullptr;// текущий
};

void ToStart(mlist& list)
{
    list.c = list.s;
}

void ToEnd(mlist& list)
{
    list.c = list.e;
}

bool ToNext(mlist& list)
{
    if (list.c && list.c->n)//если есть текущий и у текущего есть следующий то 
        list.c = list.c->n;//текущий становиться следующим (перемещение на шаг вперёд)
    // если нет возвращаем фолс

    return (list.c && list.c->n) ? list.c = list.c->n : false;
}
bool ToPrev(mlist& list)
{
    if (list.c && list.c->p)//если есть текущий и у текущего есть предыдущий то 
        list.c = list.c->p;//текущий становиться предыдущим (перемещение на шаг назад)
    // если нет возвращаем фолс

    return (list.c && list.c->p) ? list.c = list.c->p : false;
}

void InsretAfter(mlist& list, int d)
{
    item* n = new item;
    n->d = d;
    if (!list.c)// если текущего нет то текущим  становиться начало
        ToStart(list);
    if (!list.c)// если текущего нет то текущим  становиться концом
        ToEnd(list);
    if (!list.c)// если текущего нет то списка нету и надо его создать
        list.s = list.e = list.c = n;
    else
    {
        if (list.c->n)// если есть с->n то у текущего следующего текущим предыдущим становиться n
            list.c->n->p = n;
        n->n = list.c->n; // у нового следующего  новым следующим становиться текущий следующий
        list.c->n = n;
        n->p = list.c;//иновым предыдущим становиться текущий
        if(!n->n)
            list.e = n;
    }
}

void Delete(mlist& list)
{
   
    item* t = list.c;
    if (t)
    {
        if (t->n)
        {
            list.c = t->n;
            t->n->p = t->p;
            if (t->p)
                t->p->n = t->n;
            if (!list.c->p)
                list.s = list.c;
        }
        else if (t->p)
        {
            list.c = t->p;
            t->p->n = nullptr;
            list.e = list.c;
        }
        else
            list.s = list.e = list.c = nullptr;

        delete t;
    }
}

/*void DeleteAfter(mlist& list)
{

    item* t = list.c->n;
    delete list.c->n;
    if (list.c->n->n)
        list.c->p = t->n;
}
*/
void ShowList(mlist& list)
{
    system("CLS");
    cout << "List:\n";

    item* t = list.s;
    cout << "null->";
    while (t) 
    {
        if (t == list.c)
            cout << "[" << t->d << "]";
        else
            cout << t->d;
        cout << " -> ";
        t = t->n;
    }
    cout << "null\n";
}

int main()
{
    mlist list;
    int s = 0;
    do
    {
        ShowList(list);
        cout << "\n1. Start ";
        cout << "\n2. End ";
        cout << "\n3. Next  ";
        cout << "\n4. Prev ";
        cout << "\n5. InsertAfter ";
        cout << "\n6. deleteAfter ";
        cout << "\nyour vibor ";
        cin >> s;
        switch (s)
        {
        case 0: break;
        case 1:
            ToStart(list);
            break;
        case 2:
            ToEnd(list);
            break;
        case 3:
            ToNext(list);
            break;
        case 4:
            ToPrev(list);
            break;
        case 5:
            cout << "\ninput ";
            cin >> s;
            InsretAfter(list, s);
            s = 1;
            break;
        case 6:
            Delete(list);
            break;
        default:
            break;
        }
    } while (s);

    std::cout << "Hello World!\n";
}

