#Get the check-in dates from the file
cd E:\gitProjects\AutomationGithubDesign
$dates = Get-Content 'githubdesign\githubdesign\bin\Debug\hire me.txt'
$today = Get-Date -format M/dd/yyyy
Write $dates
Write $today

# If today's date is in the file
if ( $dates -like $today)
{
#Cd to the github checkin directory. Yep, a project has to be created. You will push changes to this project.
cd 'githubcheckinproject\example'
$text = " text"

#Depending on the color of contribution you require on gitub, choose the loop iteration number
for ($i=1; $i -le 8; $i++)
{
$text | Add-Content 'sample.txt'
git add -A
git status
git commit -m $today
git push origin master
}
}
else
{
"date absent!"
}

$User = Read-Host -Prompt 'Press Any key to Close'