public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        Dictionary<char, int> stringS = new Dictionary<char, int>();
        Dictionary<char, int> stringT = new Dictionary<char, int>();

        foreach (char c in s)
        {
            stringS[c] = stringS.GetValueOrDefault(c, 0) + 1;
        }

        foreach (char c in t)
        {
            stringT[c] = stringT.GetValueOrDefault(c, 0) + 1;
        }

        foreach (var (key, value) in stringS)
        {
            if (stringT.GetValueOrDefault(key, -1) != value) return false;
        }

        return true;
    }
}