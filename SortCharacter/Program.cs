using System;
					
public class Program
{
	public static string procVowel(string param){
		//your code here
		List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
        param = param.ToLower();
        string bag = "";
        string output = "";

        for (int i = 0; i < param.Length; i++)
        {
            if (param[i] == ' ')
            {
                continue;
            }
            if(vowels.Contains(param[i])){
                bag += param[i];
            }
        }
        char[] arr = new char[bag.Length];
        for(int i = 0; i < bag.Length; i++ ){
            arr[i] = bag[i];
        } 
        for (int i = 0; i < bag.Length; i++)
        {
            if(arr[i] != '.'){
                output += bag[i];
            }
            for (int j = i+1; j < bag.Length; j++)
            {
                if(arr[j] == '.'){
                    break;
                }
                if (arr[i] == arr[j])
                {
                    output += arr[j];
                    arr[j] = '.';
                }
            }
            
        }
        return output;
	}
	
	public static string procConsonant(string param){
		//your code here

        List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
        List<char> consonants = new List<char>();

        // Menambahkan karakter 'a' sampai 'z' ke dalam list consonants
        for (char c = 'a'; c <= 'z'; c++)
        {
            if (!vowels.Contains(c))
            {
                consonants.Add(c);
            }
        }
        param = param.ToLower();
        string bag = "";
        string output = "";

        for (int i = 0; i < param.Length; i++)
        {
            if (param[i] == ' ')
            {
                continue;
            }
            if(consonants.Contains(param[i])){
                bag += param[i];
            }
        }
        char[] arr = new char[bag.Length];
        for(int i = 0; i < bag.Length; i++ ){
            arr[i] = bag[i];
        } 
        for (int i = 0; i < bag.Length; i++)
        {
            if(arr[i] != '.'){
                output += bag[i];
            }
            for (int j = i+1; j < bag.Length; j++)
            {
                if(arr[j] == '.'){
                    break;
                }
                if (arr[i] == arr[j])
                {
                    output += arr[j];
                    arr[j] = '.';
                }
            }
            
        }
        return output;
	}
	
	public static void Main()
	{

		Console.Write("Input one line of words (S) : ");
		string input = Console.ReadLine();
		
		string charVowel = procVowel(input);
		string charConsonant = procConsonant(input);
			
		Console.WriteLine("Vowel Characters : ");
		Console.WriteLine(charVowel);
		Console.WriteLine("Consonant Characters : ");
		Console.WriteLine(charConsonant);
	}

}