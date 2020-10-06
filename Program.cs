using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Palindromes
{
    class Program
    {
            static void Main(string[] args)
            {
                string sourcePath = "../../../sourceFiles";
                string outputPath = "../../../results.txt";
                Console.WriteLine("Verifying Source Files....");

                string[] sourceFiles = Directory.GetFiles(sourcePath);
                if (sourceFiles.Length > 0)
                {
                    foreach (var file in sourceFiles)
                    {
                        if (Path.GetExtension(file) != ".txt")
                        {
                            throw new Exception("Source file must be in .txt format");
                        }
                    }
                }
                else throw new Exception("Source directory is empty");

                FileStream fs = File.Create(outputPath);
                fs.Dispose();

                var timer = new Stopwatch();
                timer.Start();
                Console.WriteLine("Processing files....");

                foreach(var workingFile in sourceFiles) 
                {

                    var palindromes = new List<string>();
                    var charBuffer = new List<char>();
                    var stringBuffer = new List<string>();

                    var sourceFileText = File.ReadAllText(workingFile, Encoding.UTF8);
                    var cleanedDocument = Regex.Replace(sourceFileText, @"\t|\n|\r", " ");

                    var documentWords = cleanedDocument.Split(" ");

                    foreach (var word in documentWords)
                    {

                        if (word != "")
                        {
                            char[] characters = word.ToCharArray();

                            foreach (var element in characters)
                            {
                                if (!char.IsWhiteSpace(element) && !char.IsPunctuation(element))
                                {
                                    charBuffer.Add(element);
                                }
                            }
                            string workingWord = string.Join("", charBuffer).ToLower();
                            string reversed = new string(workingWord.ToCharArray().Reverse().ToArray());

                            if (workingWord.Length > 2 && workingWord == reversed)
                            {
                                palindromes.Add(workingWord);
                            }

                            charBuffer.Clear();
                        }
                    }

                    File.WriteAllLinesAsync(outputPath, palindromes);

                }

                timer.Stop();
                TimeSpan totalTime = timer.Elapsed;

                Console.WriteLine($"Parsed {sourceFiles.Length} in {totalTime.ToString()} ");
                Console.WriteLine("Press any key to quit.....");
                Console.ReadLine();

            }
        }
}
