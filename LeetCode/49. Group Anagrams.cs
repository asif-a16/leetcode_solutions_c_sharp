public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var anagrams = new Dictionary<string, List<string>>();
        foreach (string word in strs)
        {
            char[] arr = new char[26];
            foreach(char ch in word)
            {
                arr[ch-'a']++;
            }
            string key = new string(arr);

            if (!anagrams.ContainsKey(key))
            {
                anagrams[key] = new List<string>();
            }
            anagrams[key].Add(word);
        }

        return anagrams.Values.ToList<IList<string>>();
    }
}