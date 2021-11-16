#!user/bin/bash

echo "Please enter Y or N:"
read STDIN
if [[ $STDIN == "Y" || $STDIN == "y" ]]; then
    echo "YES"
elif [[ $STDIN == "N" || $STDIN == "n" ]]; then
    echo "NO"
else
    echo "Fail"
fi
