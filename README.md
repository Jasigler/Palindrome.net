
  <h3 align="center">Palindromes.Net</h3>

  <p align="center">
    A simple (and probably useless).Net Core application to count palindromes in text files.
    <br />
    ·
    <a href="https://github.com/Jasigler/Palindrome.net/issues">Report Bug</a>
    ·
  </p>
</p>



<!-- TABLE OF CONTENTS -->
## Table of Contents

* [About the Project](#about-the-project)
  * [Built With](#built-with)
* [Getting Started](#getting-started)
  * [Prerequisites](#prerequisites)
  * [Installation](#installation)
* [Usage](#usage)
* [Contact](#contact)



<!-- ABOUT THE PROJECT -->
## About The Project

  This is a simple (and probably useless) cli application that will parse n number of provided text files and output a .txt file with all found palindromes. This has no real-world value except to me, as it was a proper introduction to 
  C# System.IO operations, file streams, and buffers. 

  The inspiration for this project was an ongoing joke at work about palindromes, so I thought it might be amusing to download a number of plain-text files of large literary works from the [Gutenberg Project](http://www.gutenberg.org) and retrieve a list of palindromes for each one.

  I naively began this assuming that I could utilize the `Parallel.ForEach()` operator on each text file, but I quickly realized that this operation is heavily IO-bound and would require extensive IO scheduling (which is far beyond the scope of this application).


### Built With

* [.Net Core 3]("https://dotnet.microsoft.com")



<!-- GETTING STARTED -->
## Getting Started

A starter dictionary file is located in the `SourceFiles` folder in the root of the project, but any additional files should be added there. They must be in .txt format (I may add support for PDF files eventually).


### Prerequisites

If you wish to simply run this application, you will need the .NET Core 3.1 Runtime from [here]("https://dotnet.microsoft.com/download/dotnet-core/3.1") for your operating system.

If you plan to make any changes, you'll need to select the SDK from the link above.

### Installation

1. Clone the repo
```
git clone git@github.com:Jasigler/Palindrome.net.git
```
2. Build the solution
```
cd Palindromes

dotnet build
```
3. Execute the application (Windows)
```
bin\debug\netcoreapp3.1\Palindromes.Exe
```
4. Execute the application (OSX, Linux)
```
./bin/debug/netcoreapp3.1/Palindromes
```
<!-- USAGE EXAMPLES -->
## Usage

When the application has finished parsing the files you've placed in the `SourceFiles` directory, it will generate a file called `results.txt` that contains all found palindromes. 

A few things to consider:

This application will only look at individual words, not phrases or any larger combination. Additionally, if you're using .txt source files from a repository like the Gutenberg Project, artifacts from translation/conversion can cause false positives. I've made some effort to reduce this, but you'll have to modify the logic to suit your personal use case. 



## Contact

Jason Sigler - [@that_sigler](https://twitter.com/that_sigler) - jason.sigler@outlook.com


[issues-shield]: https://img.shields.io/github/issues/github_username/repo.svg?style=flat-square
[issues-url]: https://github.com/Jasigler/Palindrome.net/issues
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=flat-square&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/Jasigler
