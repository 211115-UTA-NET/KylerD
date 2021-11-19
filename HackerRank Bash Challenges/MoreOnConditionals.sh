#!user/bin/bash

echo "Enter side A:"
read sideA

echo "Enter side B:"
read sideB

echo "Enter side C:"
read sideC

if [[ $sideA == $sideB && $sideB == $sideC ]]; then
    echo "EQUILATERAL"
elif [[ $sideA == $sideB || $sideA == $sideC || $sideB == $sideC ]]; then
    echo "ISOSCELES"
else
    echo "SCALENE"
fi