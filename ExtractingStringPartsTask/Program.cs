namespace ExtractingStringPartsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = "United States of America";
            string state = "California";
            string city = "San Fransicso";
            string landmark = "Alcatraz Island";
            // output the length of state
            Console.WriteLine($"State Length = {state.Length}");
            // Concatenate the contents of city and landmark * don't forget to add a space
            Console.WriteLine("City and Landmark = " + city + landmark);
            // output the first character of county
            Console.WriteLine("First character of country " + country[0] );
            // output a concatenation of the first and last characters of city
            Console.WriteLine("First and last letters of city = " + city[0] + " and " + city[city.Length - 1]);
            // output the substring of landmark starting at c and outputting to the end
            int indexOfC = -1;
            for (int i = 0; i < landmark.Length; i++)
            {
                if (landmark[i] == 'c')
                {
                    indexOfC = i;
                    break; 
                }
            }

            if (indexOfC != -1)
            {
                Console.WriteLine($"Substring of landmark from 'c': {landmark.Substring(indexOfC)}");
            }
            // output the substring of country starting at the first S and ending at the first A
            int S = -1;
            int A = -1;
            for (int i = 0; i < country.Length; i++)
            {
                if (S == -1 && country[i] == 'S')
                {
                    S = i;
                }
                if (A == -1 && country[i] == 'A')
                {
                    A = i;
                    break;
                }
            }
            if (S != -1 && A != -1 && S < A)
            {
                Console.WriteLine($"Substring of country from first 'S' to first 'A': {country.Substring(S, A - S + 1)}");
            }
            // output the position of f in California
            int IndexOfF = -1;
            for (int i = 0; i < state.Length; i++)
            {
                if (state[i] == 'f')
                {
                    IndexOfF = i;
                    break;
                }
            }
            if (IndexOfF != -1)
            {
                Console.WriteLine("The index of 'f' in state = " + IndexOfF);
            }
            //************CHALLENGE****************//
            // Output how many vowels are in each of the strings in the format
            // California has n vowels
            char[] vowels = {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int countryVowelCount = 0;
            foreach (char c in country)
            {
                if (vowels.Contains(c))
                {
                    countryVowelCount++;
                }
            }
            Console.WriteLine($"{country} has {countryVowelCount} vowels");
            int stateVowelCount = 0;
            foreach (char d in state)
            {
                if (vowels.Contains(d))
                {
                    stateVowelCount++;
                }
            }
            Console.WriteLine($"{state} has {stateVowelCount} vowels");
            int cityVowelCount = 0;
            foreach (char e in city)
            {
                if (vowels.Contains(e))
                {
                    cityVowelCount++;
                }
            }
            Console.WriteLine($"{city} has {cityVowelCount} vowels");
            int landmarkVowelCount = 0;
            foreach (char f in landmark)
            {
                if (vowels.Contains(f))
                {
                    landmarkVowelCount++;
                }
            }
            Console.WriteLine($"{landmark} has {landmarkVowelCount} vowels");
        }// Show your evidence of the program running in the Readme file
    }
}
