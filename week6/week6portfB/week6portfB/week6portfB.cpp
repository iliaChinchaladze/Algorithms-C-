// week6portfB.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;


void recombination(string s1, string s2, string s3)
{
    int position1 = s1.find(s3);
    int position2 = s2.find(s3);

    for (size_t i = 0; i < position1; i++)
    {
        cout << s1[i];    //S1 Left part
    }

    cout << s3;           //S3

    for (size_t i = position2 + 2; i <= s2.length(); i++)
    {
        cout << s2[i];    //S2right
    }

    cout << endl;         //newline

    for (size_t i = 0; i < position2; i++)
    {
        cout << s2[i];    //S2 Left part
    }
    cout << s3;           //S3
    for (size_t i = position1 + 2; i <= s1.length(); i++)
    {
        cout << s1[i];    //S1right
    }
    cout << endl;
    cout << endl;
    cout << endl;
}

void substring(string z1, string z2, string s3)
{
    int z1Len = z1.length(); //A GC GA GC A
    int z2Len = z2.length();//TA GC TT GC GAT
    int s3Len = s3.length(); //GC
    



    // first z1 then z2
    
    int found = 0;
    for (int i = 0; i <= z1Len - s3Len; i++)
    {

        int occur = 0;
        while (occur < s3Len && z1[i + occur] == s3[occur])
        {
            occur++;
            found ++;
        }

        if (occur == s3Len && found ==2 )
        {

            //If first occurance found in z1 found occurances in z2
            for (int ii = 0; ii <= z2Len - s3Len; ii++)
            {
                int occurs2 = 0;

                while (occurs2 < s3Len && z2[ii + occurs2] == s3[occurs2])
                {
                    occurs2++;
                }


                if (occurs2 == s3Len)
                {
                    //type out I occurances of s1 
                    for (int z = 0; z < i + 2; z++)
                    {
                        cout << z1[z];
                    }
                    
                    //type first ocurance, type socond ocurance in s2
                    for (int pp = ii + 2; pp < z2Len; pp++)
                    {
                        cout << z2[pp];
                    }
                    cout << endl;

                }

            }
        }

        /// Second occurance of s3 in z1
        
        else if (occur == s3Len && found > 2)
        {        
            
            for (int ii = 0; ii <= z2Len - s3Len; ii++)
            {
                int occurs2 = 0;

                while (occurs2 < s3Len && z2[ii + occurs2] == s3[occurs2])
                {
                    occurs2++;
                }

                // if GC = GC , occurance found
                if (occurs2 == s3Len)
                {
                    //type out II occurance in s1
                    for (int z = 0; z < i + 2; z++)
                    {
                        cout << z1[z];
                    }

                    //type first ocurance, type socond ocurance in s2
                    for (int pp = ii + 2; pp < z2Len; pp++)
                    {
                        cout << z2[pp];
                    }
                    cout << endl;
                }
            }
        }
    }    
    

    // first z2 then z1//////////////////////////////////////////////////////////////

    int found2 = 0;
    for (int i = 0; i < z2Len - s3Len; i++)
    {

        int occur = 0;
        while (occur < s3Len && z1[i + occur] == s3[occur])
        {
            occur++;
            found2++;
        }

        if (occur == s3Len && found2 == 2)
        {

            //If first occurance found in z2 found occurances in z1
            for (int ii = 0; ii <= z1Len - s3Len; ii++)
            {
                int occurs2 = 0;

                while (occurs2 < s3Len && z1[ii + occurs2] == s3[occurs2])
                {
                    occurs2++;
                }


                if (occurs2 == s3Len)
                {
                    //type out I occurances of s1 
                    for (int z = 0; z < i + 3; z++)
                    {
                        cout << z2[z];
                    }

                    //type first ocurance, type socond ocurance in s2
                    for (int pp = ii + 2; pp < z1Len; pp++)
                    {
                        cout << z1[pp];
                    }
                    cout << endl;

                }

            }
        }

        /// Second occurance of s3 in z2

        else if (occur == s3Len && found2 > 2)
        {

            for (int ii = 0; ii <= z1Len - s3Len; ii++)
            {
                int occurs2 = 0;

                while (occurs2 < s3Len && z1[ii + occurs2] == s3[occurs2])
                {
                    occurs2++;
                }

                // if GC = GC , occurance found
                if (occurs2 == s3Len)
                {
                    //type out II occurance in z2
                    for (int z = 0; z < i + 3; z++)
                    {
                        cout << z2[z];
                    }

                    //type first ocurance, type socond ocurance in z1
                    for (int pp = ii + 2; pp < z1Len; pp++)
                    {
                        cout << z1[pp];
                    }
                    cout << endl;
                }
            }
        }
    }



}
        

int main()
{
    //EXAMPLE1
    string  s1, s2, s3;
    string* myptr;
    myptr = &s1;
    *myptr = "AGCGADA";
    myptr = &s2;
    *myptr = "ATTGCG";
    myptr = &s3;
    *myptr = "GC";
    recombination(s1, s2, s3);
    //EXAMPLE2
    string z1, z2;
    myptr = &z1;
    *myptr = "AGCGAGCA";
    myptr = &z2;
    *myptr = "TAGCTTGCGAT";
    substring(z1, z2, s3);

    
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
