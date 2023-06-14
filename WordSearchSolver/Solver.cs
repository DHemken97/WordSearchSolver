using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearchSolver
{
    public class Solver
    {
        public List<string> WordList;
        public char[][] Board;
        public bool AllowSingleLetterWords;
        public Solver()
        {
            WordList = File.ReadAllLines("words.txt").Select(x => x.ToUpper()).ToList();
        }

        public List<SearchResult> FindWords()
        {
            NormalizeBoard();
            var foundWords = new List<SearchResult>();
            var cx = 0;
            var cy = 0;

            for (int y = 0; y < Board.Length; y++)
            {
                var width = Board[y].Length;
                for (int x = 0; x < width; x++)
                {
                    var currentWord = Board[y][x].ToString();
                    var currentPositions = new List<Point> {new(x, y)};
                    cy = y;
                    cx = x;
                    var letterStartWords = WordList.Where(w => w.StartsWith(currentWord));

                    //Single Letter words
                    var possibleWords = letterStartWords.Where(w => w.StartsWith(currentWord));
                    if (AllowSingleLetterWords)
                    if (possibleWords.Any(x => x.ToUpper() == currentWord.ToUpper()))
                        foundWords.Add(new SearchResult
                        {
                            Word = currentWord,
                            Positions = currentPositions
                        });

                    //left

                    while (possibleWords.Any() && cx<width-1)
                    {
                        cx += 1;
                        currentWord += Board[cy][cx].ToString();
                        currentPositions.Add(new Point(cx, cy));
                        possibleWords = possibleWords.Where(w => w.StartsWith(currentWord)).ToList();
                        if (possibleWords.Any(x => x.ToUpper() == currentWord.ToUpper()))
                            foundWords.Add(new SearchResult
                            {
                                Word = currentWord,
                                Positions = currentPositions
                            });

                    }

                    //Reset for right search

                     currentWord = Board[y][x].ToString();
                     currentPositions = new List<Point> { new(x, y) };
                     cy = y;
                     cx = x;
                     possibleWords = letterStartWords.Where(w => w.StartsWith(currentWord));

                    //right (reversed)

                    while (possibleWords.Any() && cx > 0)
                    {
                        cx -= 1;
                        currentWord += Board[cy][cx].ToString();
                        currentPositions.Add(new Point(cx, cy));
                        possibleWords = possibleWords.Where(w => w.StartsWith(currentWord)).ToList();

                        if (possibleWords.Any(w => w == "dog"))
                        {
                            Console.WriteLine($"Possible dog: {x},{y} - {currentWord}");
                        }

                        if (possibleWords.Any(x => x.ToUpper() == currentWord.ToUpper()))
                            foundWords.Add(new SearchResult
                            {
                                Word = currentWord,
                                Positions = currentPositions
                            });

                    }


                    //Reset for Up search

                    currentWord = Board[y][x].ToString();
                    currentPositions = new List<Point> { new(x, y) };
                    cy = y;
                    cx = x;
                    possibleWords = letterStartWords.Where(w => w.StartsWith(currentWord));

                    //Up
                    while (possibleWords.Any() && cy > 0)
                    {
                        cy -= 1;
                        currentWord += Board[cy][cx].ToString();
                        currentPositions.Add(new Point(cx, cy));
                        possibleWords = possibleWords.Where(w => w.StartsWith(currentWord)).ToList();
                        if (possibleWords.Any(x => x.ToUpper() == currentWord.ToUpper()))
                            foundWords.Add(new SearchResult
                            {
                                Word = currentWord,
                                Positions = currentPositions
                            });

                    }


                    //Reset for down search

                    currentWord = Board[y][x].ToString();
                    currentPositions = new List<Point> { new(x, y) };
                    cy = y;
                    cx = x;
                    possibleWords = letterStartWords.Where(w => w.StartsWith(currentWord));

                    //down
                    while (possibleWords.Any() && cy < Board.Length-1)
                    {
                        cy += 1;
                        currentWord += Board[cy][cx].ToString();
                        currentPositions.Add(new Point(cx, cy));
                        possibleWords = possibleWords.Where(w => w.StartsWith(currentWord)).ToList();
                        if (possibleWords.Any(x => x.ToUpper() == currentWord.ToUpper()))
                            foundWords.Add(new SearchResult
                            {
                                Word = currentWord,
                                Positions = currentPositions
                            });

                    }


                    //Reset for Diag Search

                    currentWord = Board[y][x].ToString();
                    currentPositions = new List<Point> { new(x, y) };
                    cy = y;
                    cx = x;
                    possibleWords = letterStartWords.Where(w => w.StartsWith(currentWord));

                    //Down-Right Diag
                    while (possibleWords.Any() && cy < Board.Length - 1 && cx < width - 1)
                    {
                        cy += 1;
                        cx += 1;
                        currentWord += Board[cy][cx].ToString();
                        currentPositions.Add(new Point(cx, cy));
                        possibleWords = possibleWords.Where(w => w.StartsWith(currentWord)).ToList();
                        if (possibleWords.Any(x => x.ToUpper() == currentWord.ToUpper()))
                            foundWords.Add(new SearchResult
                            {
                                Word = currentWord,
                                Positions = currentPositions
                            });

                    }

                    //Reset for Diag Search

                    currentWord = Board[y][x].ToString();
                    currentPositions = new List<Point> { new(x, y) };
                    cy = y;
                    cx = x;
                    possibleWords = letterStartWords.Where(w => w.StartsWith(currentWord));

                    //Down-Left Diag
                    while (possibleWords.Any() && cy < Board.Length - 1 && cx > 0)
                    {
                        cy += 1;
                        cx -= 1;
                        currentWord += Board[cy][cx].ToString();
                        currentPositions.Add(new Point(cx, cy));
                        possibleWords = possibleWords.Where(w => w.StartsWith(currentWord)).ToList();
                        if (possibleWords.Any(x => x.ToUpper() == currentWord.ToUpper()))
                            foundWords.Add(new SearchResult
                            {
                                Word = currentWord,
                                Positions = currentPositions
                            });

                    }

                    //Reset for Diag Search

                    currentWord = Board[y][x].ToString();
                    currentPositions = new List<Point> { new(x, y) };
                    cy = y;
                    cx = x;
                    possibleWords = letterStartWords.Where(w => w.StartsWith(currentWord));

                    //Up-Right Diag
                    while (possibleWords.Any() && cy > 0 && cx < width - 1)
                    {
                        cy -= 1;
                        cx += 1;
                        currentWord += Board[cy][cx].ToString();
                        currentPositions.Add(new Point(cx, cy));
                        possibleWords = possibleWords.Where(w => w.StartsWith(currentWord)).ToList();
                        if (possibleWords.Any(x => x.ToUpper() == currentWord.ToUpper()))
                            foundWords.Add(new SearchResult
                            {
                                Word = currentWord,
                                Positions = currentPositions
                            });

                    }

                    //Reset for Diag Search

                    currentWord = Board[y][x].ToString();
                    currentPositions = new List<Point> { new(x, y) };
                    cy = y;
                    cx = x;
                    possibleWords = letterStartWords.Where(w => w.StartsWith(currentWord));

                    //Up-Left Diag
                    while (possibleWords.Any() && cy > 0 && cx > 0)
                    {
                        cy -= 1;
                        cx -= 1;
                        currentWord += Board[cy][cx].ToString();
                        currentPositions.Add(new Point(cx, cy));
                        possibleWords = possibleWords.Where(w => w.StartsWith(currentWord)).ToList();
                        if (possibleWords.Any(x => x.ToUpper() == currentWord.ToUpper()))
                            foundWords.Add(new SearchResult
                            {
                                Word = currentWord,
                                Positions = currentPositions
                            });

                    }


                }

            }

            foundWords.ForEach(word => word.Positions = word.Positions.Take(word.Word.Length).ToList()); //make sure we didnt get any extra letters at the end
            return foundWords;
        }

        private void NormalizeBoard()
        {

            for (int i = 0; i < Board.Length; i++)
            {
                for (int j = 0; j < Board[i].Length; j++)
                {
                    Board[i][j] = Board[i][j].ToString().ToUpper().ToCharArray()[0];
                }
            }
        }
    }

    public class SearchResult
    {
        public string Word;
        public List<Point> Positions;
        public override string ToString()
        {
            return Word;
        }
    }
}
