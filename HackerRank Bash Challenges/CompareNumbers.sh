#!user/bin/bash

echo "Please enter a number for X:"
read x
echo "Please enter a number for Y:"
read y
if [ $x -gt $y ]; then
    echo "X is greater than Y"
elif [ $x -eq $y ]; then
    echo "X is equal to Y"
elif [ $x -lt $y ]; then
    echo "X is less than Y"
else
    echo "Failed."
fi