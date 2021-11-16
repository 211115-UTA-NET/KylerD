#!user/bin/bash

echo "Lets create a folder! Enter your folder name:"
read folderName
mkdir $folderName
cd ./$folderName

echo "Now lets create a file in that folder! Enter the name of the file (include extensions):"
read fileName
touch $fileName

echo "Welcome to your new file!" > $fileName
for i in {0..20..2}
do
echo $i >> $fileName
done