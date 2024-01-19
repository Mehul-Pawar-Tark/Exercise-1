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

            String archive = "101101";
            String[] dictionary = new string[] { "00", "10", "01", "11" };

            Console.WriteLine(huffmanDecoding.decode(archive, dictionary));
            #endregion

            #region Solution 2 : LexmaxReplace
            LexmaxReplace lexmaxReplace = new LexmaxReplace();

            String s = "abb";
            String t = "c";
            Console.WriteLine(lexmaxReplace.get(s, t));
            #endregion

            #region Solution 3 : SortingSubsets
            SortingSubsets sortingSubsets = new SortingSubsets();

            int[] a = new int[] { 11, 11, 49, 7, 11, 11, 7, 7, 11, 49, 11 };
            Console.WriteLine(sortingSubsets.getMinimalSize(a));
            #endregion

            #region Solution 4 : PalindromeDecoding
            PalindromeDecoding palindromeDecoding = new PalindromeDecoding();

            String str = "misip";
            int[] position = new int[]{2, 3, 1, 7};
            int[] lengths = new int[] { 1, 1, 2, 2 };

            Console.WriteLine(palindromeDecoding.decode(str,position,lengths));
            #endregion

            #region Solution 5 : MovingAvg
            MovingAvg movingAvg = new MovingAvg();
            
            int k=3;
            double[] data = new double[] { 6, 2.5, 3.5 };
            Console.WriteLine(movingAvg.difference(k, data));
            #endregion

            #region Solution 6 : WordCompositionGame
            WordCompositionGame wordCompositionGame = new WordCompositionGame();

            String[] listA = { "cat", "dog", "pig", "mouse" };
            String[] listB = { "cat", "pig" };
            String[] listC = { "dog", "cat" };
            Console.WriteLine(wordCompositionGame.score(listA, listB, listC));
            #endregion
           
            #region Solution 7 : LargestSubsequence
            LargestSubsequence largestSubsequence = new LargestSubsequence();          
            Console.WriteLine(largestSubsequence.getLargest("aquickbrownfoxjumpsoverthelazydog"));
            #endregion

            #region Solution 8 : MaximumBalances
            MaximumBalances maximumBalances = new MaximumBalances();   
            Console.WriteLine(maximumBalances.solve("(((("));
            #endregion

            #region Solution 9 : DukeOnChessBoard
            DukeOnChessBoard dukeOnChessBoard = new DukeOnChessBoard(); 
            Console.WriteLine(dukeOnChessBoard.dukePath(8, "a8"));
            #endregion

            #region Solution 10 : Islands
            Islands islands = new Islands();
            Console.WriteLine(islands.beachLength(new String[] { "#...#.....", "##..#...#." }));
            #endregion

            #region Solution 11 : Mailbox
            Mailbox mailbox = new Mailbox();
            String collection = "AAAAAAABBCCCCCDDDEEE123456789";
            String[] addresses = { "123C", "123A", "123 ADA" };
            Console.WriteLine(mailbox.impossible(collection, addresses));
            #endregion

            #region Solution 12 : MysticAndCandiesEasy
            MysticAndCandiesEasy mysticAndCandiesEasy = new MysticAndCandiesEasy();
            Console.WriteLine(mysticAndCandiesEasy.minBoxes(10,7,new int[] { 3, 3, 3, 3 }));
            #endregion

            #region Solution 13 : PrintScheduler
            PrintScheduler printScheduler = new PrintScheduler();
            String[] threads = { "ABCDE" };
            String[] slices = { "0 21", "0 22" };
            Console.WriteLine(printScheduler.getOutput(threads, slices));
            #endregion

            #region Solution 14 : TurningLightOn
            TurningLightOn turningLightOn = new TurningLightOn();
            Console.WriteLine(turningLightOn.minFlips(new string[] {"1111","1010","1111","1010"}));
            #endregion

        }

    }

    
}
