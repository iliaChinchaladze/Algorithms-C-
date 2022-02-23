// week6porfA.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std; //using this will stop you needing to put std before every command
void substitute(char*,char,char);


int main()
{
    char c1, c2;
    char* s;   

    s = &c1;
    *s = 'a';
    s = &c2;
    *s = '!';

    substitute(s, c1, c2);
    
}


void substitute(char* s, char c1, char c2)
{
    string myString = "la!belabella!bel";
    s = &myString[0];
    int len = sizeof(myString) / sizeof(myString[0]);//length of the elements in the array

    char x = 'x';
   
    for (int i=0; i<len-i; i++) 
    {
        
        if (*(s + i) == c1 && *(s + i + 1) == c2)
        {
            
            cout << "Found it here " << i<<endl;
            
            *(s + i) = x;
        }
       
    }
    for (int i = 0; i < len - i; i++)
    {
        cout << *(s + i) ;
    }
    

}



// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
