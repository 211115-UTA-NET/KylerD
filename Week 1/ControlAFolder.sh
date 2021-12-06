#!usr/bin/bash

#Create a folder and open it
echo "Lets create a folder! Enter your folder name:"
read folderName
mkdir $folderName
cd ./$folderName

#Create a file in new folder
echo "Now lets create a file in that folder! Enter the name of the file (include extensions):"
read fileName
touch $fileName

#Print off odd numbers below 20 on different lines
echo "Welcome to your new file!" > $fileName
for i in {1..20..2}
do
     echo $i >> $fileName
done

#Print off even numbers below 20 on the same line
for ((i=2; i<=20; i+=2));
do
     if [ $i -lt 20 ]; then
          echo -n "$i, " >> $fileName
     else
          echo -n $i >> $fileName
     fi
done