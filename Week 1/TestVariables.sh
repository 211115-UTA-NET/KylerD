#!/usr/bin/bash

#Declaring variables in bash

#----------Example 1:

declare -i a=2
declare -i b=3
declare -i c=0

c=$(( a + b ))
echo "$a + $b = $c"

#----------Example 2:

declare -i d=z
declare -i e=ThisIsALongString
echo "$d"
echo "$e"

#----------Example 3:

declare -l name=KylerGDennis
echo "$name"
declare -u name2=KylerGDennis
echo "$name2"

declare -l name3=Kyler12345
echo "$name3"
declare -u name4=Kyler12345
echo "$name4"

#----------Example 4:

read=5
read2=15
declare -r finalRead=ReadOnly

finalRead=$(( read + read2 ))
echo "$read + $read2 = $finalRead"