// Javascript program to Minimize the absolute
// difference of sum of two subsets
 
// function to print difference
function subsetDifference(n)
{
     
    // summation of n elements
    let s = n * (n + 1) / 2;
 
    // if divisible by 4
    if (n % 4 == 0)
    {
        document.write("First subset sum = " + Math.floor(s / 2));
        document.write("<br> Second subset sum = " + Math.floor(s / 2));
        document.write("<br> Difference = "  +  0);
    }
    else
    {
 
        // if remainder 1 or 2.
        // In case of remainder
        // 2, we divide elements
        // from 3 to n in groups
        // of size 4 and put 1 in
        // one group and 2 in
        // group. This also makes
        // difference 1.
        if (n % 4 == 1 || n % 4 == 2)
        {
 
            document.write("First subset sum = " + Math.floor(s / 2));
            document.write("<br> Second subset sum = " + Math.floor(s / 2 + 1));
            document.write("<br> Difference = " + 1);
        }
 
        // We put elements from 4
        // to n in groups of
        // size 4. Remaining
        // elements 1, 2 and 3 can
        // be divided as (1, 2)
        // and (3).
        else
        {
            document.write( "First subset sum = " + Math.floor(s / 2));
            document.write( "<br> Second subset sum = " + Math.floor(s / 2));
            document.write("<br> Difference = " + 0);
        }
    }
}
 
    // Driver code
    let n = 6;
    subsetDifference(n);