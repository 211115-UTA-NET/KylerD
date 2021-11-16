#!user/bin/bash

cd /d/Revature/KylerD/

echo "Please enter the file name you would like to push:"
read fileName

git add $fileName

echo "Please add a commit message:"
read commitMessage

git commit -m "$commitMessage"

git push