public class Solution {
    public int StrStr(string haystack, string needle) {
        return haystack.Length < 50 ? StrStrNaiveOptim(haystack, needle) : StrStrKMP(haystack, needle);
    }

    public int StrStrNaiveOptim(string haystack, string needle) {        
        int nl = needle.Length;
        int hl = haystack.Length;
        if (haystack.Length < needle.Length) return -1;
        if (haystack == needle) return 0;        
        for (int i = 0; i < hl; i++) {
            for (int j = 0; j < nl && j + i < hl; j++) {
                if (needle[j] != haystack[i + j])
                    break;
                if (j == nl - 1)
                    return i;
            }            
        }
        return -1;
    }

    public int StrStrKMP(string haystack, string needle) {
        if (string.IsNullOrEmpty(needle) || haystack == needle) return 0;
        if (haystack.Length < needle.Length) return -1;
        
        // build prefix table
        int[] prefixTable = ComputePrefixTable(needle);

        // apply KMP algorythm
        int haystackIndex = 0;
        int needleIndex = 0;
        while (haystackIndex < haystack.Length)
        {
            if (haystack[haystackIndex] == needle[needleIndex])
            {
                haystackIndex++;
                needleIndex++;
                if (needleIndex == needle.Length)
                    return haystackIndex - needle.Length; // Found match
            }
            else
            {
                if (needleIndex != 0)
                    needleIndex = prefixTable[needleIndex - 1];
                else
                    haystackIndex++;
            }
        }
        return -1;
    }

    public int[] ComputePrefixTable(string pattern)
    {
        int[] prefixTable = new int[pattern.Length];
        int len = 0;
        int i = 1;
        prefixTable[0] = 0;

        while (i < pattern.Length)
        {
            if (pattern[i] == pattern[len])
            {
                len++;
                prefixTable[i] = len;
                i++;
            }
            else
            {
                if (len != 0)
                    len = prefixTable[len - 1];
                else
                {
                    prefixTable[i] = 0;
                    i++;
                }
            }
        }
        return prefixTable;
    }

    public int StrStrIndexOf(string haystack, string needle) {
        return haystack.IndexOf(needle);
    }
}