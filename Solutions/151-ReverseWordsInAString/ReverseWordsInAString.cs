public class Solution {
    public string ReverseWords(string s) {
        
        // solution 1
        // split string into array by space
        // reverse the array and concat to string with one space between each word

        var trimmedInput= s.Trim();

        // Split by spaces, remove empty entries caused by multiple spaces
        var splittedInput= trimmedInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        //All inbuilt methods in C# are starts from capital letter such as : string.Trim(), Array.Reverse(), string.Split(), string.Join()
        Array.Reverse(splittedInput);

        // By using string.Join method, I can join component from string array. I could also iterate over Array and concat into result
        return string.Join(' ', splittedInput);
    }
}