using System.Text.RegularExpressions;

namespace KittyAdventure;

public static class SemanticTools
{
    //ask about string article/string word?
    public static string CreateArticle(string word)
    {
        string article = "a";
        bool startsWithVowel = Regex.IsMatch(word, @"^[aeiouAEIOU]");
        if (startsWithVowel)
            article = "an";
        return article;
    }
}