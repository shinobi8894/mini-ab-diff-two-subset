// CPP program to Minimize the absolute
// difference of sum of two subsets
#include <bits/stdc++.h>
using namespace std;
 
// function to print difference
void subsetDifference(int n)
{
    // summation of n elements
    int s = n * (n + 1) / 2;
 
    // if divisible by 4
    if (n % 4 == 0) {
        cout << "First subset sum = "
             << s / 2;
        cout << "\nSecond subset sum = "
             << s / 2;
        cout << "\nDifference = " << 0;
    }
    else {
 
        // if remainder 1 or 2. In case of remainder
        // 2, we divide elements from 3 to n in groups
        // of size 4 and put 1 in one group and 2 in
        // group. This also makes difference 1.
        if (n % 4 == 1 || n % 4 == 2) {
 
            cout << "First subset sum = "
                 << s / 2;
            cout << "\nSecond subset sum = "
                 << s / 2 + 1;
            cout << "\nDifference = " << 1;
        }
 
        // We put elements from 4 to n in groups of
        // size 4. Remaining elements 1, 2 and 3 can
        // be divided as (1, 2) and (3).
        else
        {
            cout << "First subset sum = "
                 << s / 2;
            cout << "\nSecond subset sum = "
                 << s / 2;
            cout << "\nDifference = " << 0;
        }
    }
}
 
// driver program to test the above function
int main()
{
    int n = 6;
    subsetDifference(n);
    return 0;
}