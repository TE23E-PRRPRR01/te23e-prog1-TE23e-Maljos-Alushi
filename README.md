# C# i Visual Studio Code
VS Code är ett snabbt och lättanvänt IDE som du kan skapa ditt C#-projekt med.

## Förberedelser

### Installera git och Dotnet 7
Gå till följande webbsidor och ladda ner och installera följande program:

1. Installera [git](https://git-scm.com/downloads)
2. Installera [Dotnet 7](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-7.0.400-windows-x64-installer)

Eller kör följande kommandon i Windows Terminal:

```Powershell
winget install git.git
winget install Microsoft.DotNet.SDK.7
```

### Installera följande tillägg i VS Code
Följande tillägg kommer att installeras automatiskt:

* [C#](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) – Ger VS Code stöd för C#
* [C# Toolbox of Productivity](https://marketplace.visualstudio.com/items?itemName=RichardZampieriprog.csharp-snippet-productivity) – Lägger till en del extra användbara genvägar och funktioner, tex för att skapa nya projekt och klasser
* [Open Folder Context Menu](https://marketplace.visualstudio.com/items?itemName=chrisdias.vscode-opennewinstance) - För att enkelt öppna en mapp
* [gitignore](https://marketplace.visualstudio.com/items?itemName=codezombiech.gitignore) – Underlättar arbetet med git och VS Code. Om du söker efter den, se till att ta den av CodeZombie!
* [VSCode Great Icons](https://marketplace.visualstudio.com/items?itemName=emmanuelbeziat.vscode-great-icons) – Gör det lättare att känna igen filtyper
* [XML Complete](https://marketplace.visualstudio.com/items?itemName=rogalmic.vscode-xml-complete) – För att jobba med WPF och Xaml
* [RedHat XML](https://marketplace.visualstudio.com/items?itemName=redhat.vscode-xml) - För att jobba med WPF och Xaml
* [GitHub Classroom](https://marketplace.visualstudio.com/items?itemName=GitHub.classroom) - För att arbeta med labbar och prov på Github Classroom
* [C# XML Documentation Comments](https://marketplace.visualstudio.com/items?itemName=k--kato.docomment) - För att kommentera metoder och klasser

### Ställ in VS Code inställningar från profil
För att få en bra och fungerande utvecklingsmiljö i VS Code, behöver VS Code inställningar ställas in. Detta görs genom att importera en profil.
Gå in i inställningar och välj **Profile** -> **Import profile** och välj filen *.vscode/Skola.code-profile*.

### Korta ned prompt i Powershell

I terminalen i *VS Code* är prompten väldigt lång.  
Gör följande för att korta ned prompten i Terminalen/Konsolen i *VS Code*.

* Öppna terminalen och skriv/kör dessa rader för skapa en **profil**-fil:

```powershell
test-path $profile
new-item -path $profile -itemtype file -force
code $profile
```

* Skriv in följande i **profil**-filen och spara:

```powershell
function prompt {
   $p = Split-Path -leaf -path (Get-Location)
   "$p> "
}
```

* Avslutningsvis, i terminalen skriv/kör:

```powershell
Set-ExecutionPolicy RemoteSigned -Scope CurrentUser
```

* Starta om *VS Code*

Referens: [How to display ony the current folder name](https://superuser.com/questions/446827/configure-windows-powershell-to-display-only-the-current-folder-name-in-the-shel).

## Skapa C#-projekt

1. Skapa en ny mapp
2. Öppna den tomma mappen i VS Code med **File** -> **Open In Terminal**
3. Skapa grundkoden med:

```bash
dotnet new console
```
4. Koda och testa med:

```bash
dotnet run
```

## Ladda upp till GitHub

1. Tryck på ikonen för Source Control
2. Fyll i en commit meddelande som beskriver vad du har gjort
3. Tryck på **Commit & Sync**