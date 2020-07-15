$libraryFiles = @("Maria.Core.dll", "Maria.Platform.dll") #"Maria.Editor.dll",

$myPath = (Get-Item -Path ".\").FullName;
$myPath = $myPath.Replace("\", "/")

$libraryBasePath = -join ($myPath, "/lib/")
$builderPath = -join ($myPath, "/Libraries/UnityPackager/UnityPackager.exe")
$packageOutPath = -join ($myPath, "/Maria.unitypackage")

# Args for library generation
$libraryBuildArgs = -join ("null", " ", $packageOutPath, " ")

# Add library files to library package
For ($i=0; $i -lt $libraryFiles.Count; $i++)  
{
    $libraryBuildArgs += -join ($libraryBasePath, $libraryFiles.Get($i), " ", "Assets/Plugins/Maria/", $libraryFiles.Get($i), " ")
}

Write-Host $builderPath
Write-Host $libraryBuildArgs

Start-Process -FilePath $builderPath -ArgumentList $libraryBuildArgs