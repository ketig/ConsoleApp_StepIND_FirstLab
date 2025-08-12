using ConsoleApp_StepIND_FirstLab.Models.Pairs;

namespace ConsoleApp_StepIND_FirstLab.Models.Pairs
{
    public static class StringExtensions
    {
        public static int CountBracketPairs(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "Input cannot be null");
            }

            Stack<char> stack = new Stack<char>();
            int pairCount = 0;

            foreach (char c in input)
            {

                if (c == '(' || c == '[')
                {
                    stack.Push(c);
                }
                else if ((c == ')' || c == ']')
                    && stack.Count > 0 && stack.Peek() == '(' || stack.Count > 0 && stack.Peek() == '[')
                {
                    stack.Pop();
                    pairCount++;
                }
            }

            return pairCount;
        }

        public static IList<(int Start, int End)> FindBracketPairPositions(string input)
        {
            //ArgumentNullException.ThrowIfNull(input);

            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "Input cannot be null");
            }

            Stack<int> stack = new Stack<int>();
            List<(int Start, int End)> pairs = new List<(int Start, int End)>();

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (c == '(' || c == '[')
                {
                    stack.Push(i);
                }
                else if ((c == ')' || c == ']')
                    && (stack.Count > 0 && (c == ')' && input[stack.Peek()] == '(' || c == ']' && input[stack.Peek()] == '[')))
                {
                    int start = stack.Pop();
                    pairs.Add((start, i));
                }
            }
            return pairs;
        }

        /// <summary> 
        /// Examines the <see cref="text"/> and returns true if the pairs and the orders of brackets are balanced; otherwise returns false. 
        /// </summary> 
        /// <param name="text">The source text.</param> 
        /// <param name="bracketTypes">The bracket type option.</param> 
        /// <returns>True if the pairs and the orders of brackets are balanced; otherwise returns false.</returns> 
        /// <exception cref="ArgumentNullException"><see cref="text"/> is null.</exception> 
        public static bool ValidateBrackets(this string? text, BracketTypes bracketTypes)
        {
            // "(())()[]"
            return false;
        }
    }

}

//using Brackets;
//using PairBrackets;

//string testInput = "(())()[]";
//int pairs = StringExtensions.CountBracketPairs(testInput);
//Console.WriteLine($"Bracket pairs in \"{testInput}\": {pairs}");
//IList<(int Start, int End)> positions = StringExtensions.FindBracketPairPositions(testInput);
//Console.WriteLine("Positions of bracket pairs:");
//foreach (var position in positions)
//{
//    Console.WriteLine($"Start: {position.Start}, End: {position.End}");
//}

//bool validate = StringExtensions.ValidateBrackets(testInput, BracketTypes.RoundBrackets);
//Console.WriteLine(validate);
