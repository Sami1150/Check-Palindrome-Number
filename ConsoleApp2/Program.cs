public class Solution
{
    public bool IsPalindrome(int x)
    {
        string temp = "";
        string val = x.ToString();
        for (int i = val.Length - 1; i >= 0; i--)
        {
            temp = temp + val[i];
        }

        if (temp == val)
        {
            return true;
        }
        else
            return false;

    }
}