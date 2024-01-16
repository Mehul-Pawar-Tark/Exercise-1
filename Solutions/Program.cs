using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Solutions
{
    class Program
    {

        static void Main(string[] args)
        {
            
            #region Solution 1 : HuffmanDecoding
            HuffmanDecoding huffmanDecoding = new HuffmanDecoding();
            huffmanDecoding.setinput();
             Console.WriteLine(huffmanDecoding.decode(huffmanDecoding.Archive, huffmanDecoding.Dictionary));
            #endregion

            #region Solution 2 : LexmaxReplace
            LexmaxReplace lexmaxReplace = new LexmaxReplace();
            lexmaxReplace.setInput();
            Console.WriteLine(lexmaxReplace.get(lexmaxReplace.s,lexmaxReplace.t));
            #endregion
            

            #region Solution 3 : SortingSubsets
            SortingSubsets sortingSubsets = new SortingSubsets();
            sortingSubsets.setInput();
            Console.WriteLine(sortingSubsets.getMinimalSize(sortingSubsets.nums));
            #endregion

            #region Solution 4 : PalindromeDecoding
            PalindromeDecoding palindromeDecoding = new PalindromeDecoding();
            palindromeDecoding.setInput();
            Console.WriteLine(palindromeDecoding.decode(palindromeDecoding.str,palindromeDecoding.position,palindromeDecoding.lengths));
            #endregion

            #region Solution 5 : MovingAvg
            MovingAvg movingAvg = new MovingAvg();
            movingAvg.setInput();
            Console.WriteLine(movingAvg.difference(movingAvg.n, movingAvg.numbers));
            #endregion

            #region Solution 6 : WordCompositionGame
            WordCompositionGame wordCompositionGame = new WordCompositionGame();
            Console.WriteLine(wordCompositionGame.score(wordCompositionGame.list1, wordCompositionGame.list2, wordCompositionGame.list3));
            #endregion

           
            #region Solution 7 : LargestSubsequence
            LargestSubsequence largestSubsequence = new LargestSubsequence();
            largestSubsequence.setInput();
            Console.WriteLine(largestSubsequence.getLargest(largestSubsequence.str));
            #endregion


            #region Solution 8 : MaximumBalances
            MaximumBalances maximumBalances = new MaximumBalances();
            maximumBalances.setInput();
            Console.WriteLine(maximumBalances.solve(maximumBalances.str));
            #endregion

            #region Solution 9 : DukeOnChessBoard
            DukeOnChessBoard dukeOnChessBoard = new DukeOnChessBoard();
            dukeOnChessBoard.setInput();
            Console.WriteLine(dukeOnChessBoard.dukePath(dukeOnChessBoard.n, dukeOnChessBoard.initposition));
            #endregion

            #region Solution 10 : Islands
            Islands islands = new Islands();
            Console.WriteLine(islands.beachLength(islands.kingdom));
            #endregion

            #region Solution 11 : Mailbox
            Mailbox mailbox = new Mailbox();
            Console.WriteLine(mailbox.impossible(mailbox.Collection, mailbox.addresses));
            #endregion

            #region Solution 12 : MysticAndCandiesEasy
            MysticAndCandiesEasy mysticAndCandiesEasy = new MysticAndCandiesEasy();
            Console.WriteLine(mysticAndCandiesEasy.minBoxes(mysticAndCandiesEasy.C, mysticAndCandiesEasy.X, mysticAndCandiesEasy.high));
            #endregion

            #region Solution 13 : PrintScheduler
            PrintScheduler printScheduler = new PrintScheduler();
            Console.WriteLine(printScheduler.getOutput(printScheduler.threads, printScheduler.time_slices));
            #endregion

            
            #region Solution 14 : TurningLightOn
            TurningLightOn turningLightOn = new TurningLightOn();
            Console.WriteLine(turningLightOn.minFlips(new String[]{ "0101", "1010", "0101", "1010"}));
            #endregion



        }

    }

    
}
