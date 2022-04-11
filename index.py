# Python3 code to Minimize the absolute
# difference of sum of two subsets
 
# function to print difference
def subsetDifference( n ):
 
    # summation of n elements
    s = int(n * (n + 1) / 2)
     
    # if divisible by 4
    if n % 4 == 0:
        print("First subset sum = ", int(s / 2))
        print("Second subset sum = ",int(s / 2))
        print("Difference = " , 0)
 
    else:
 
        # if remainder 1 or 2. In case of remainder
        # 2, we divide elements from 3 to n in groups
        # of size 4 and put 1 in one group and 2 in
        # group. This also makes difference 1.
        if n % 4 == 1 or n % 4 == 2:
            print("First subset sum = ",int(s/2))
            print("Second subset sum = ",int(s/2)+1)
            print("Difference = ", 1)
             
        # We put elements from 4 to n in groups of
        # size 4. Remaining elements 1, 2 and 3 can
        # be divided as (1, 2) and (3).
        else:
            print("First subset sum = ", int(s / 2))
            print("Second subset sum = ",int(s / 2))
            print("Difference = " , 0)
             
# driver code to test the above function
n = 6
subsetDifference(n)