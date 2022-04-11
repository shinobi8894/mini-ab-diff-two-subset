<?php
// PHP program to Minimize the absolute
// difference of sum of two subsets
 
// function to print difference
function subsetDifference($n)
{
     
    // summation of n elements
    $s = $n * ($n + 1) / 2;
 
    // if divisible by 4
    if ($n % 4 == 0)
    {
        echo "First subset sum = "
            ,floor($s / 2);
        echo "\nSecond subset sum = "
            ,floor($s / 2);
        echo "\nDifference = " , 0;
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
        if ($n % 4 == 1 || $n % 4 == 2)
        {
 
            echo"First subset sum = "
                , floor($s / 2);
            echo "\nSecond subset sum = "
                , floor($s / 2 + 1);
            echo"\nDifference = " ,1;
        }
 
        // We put elements from 4
        // to n in groups of
        // size 4. Remaining
        // elements 1, 2 and 3 can
        // be divided as (1, 2)
        // and (3).
        else
        {
            echo "First subset sum = "
                ,floor($s / 2);
            echo "\nSecond subset sum = "
                , floor($s / 2);
            echo"\nDifference = " , 0;
        }
    }
}
 
    // Driver code
    $n = 6;
    subsetDifference($n);
     
?>