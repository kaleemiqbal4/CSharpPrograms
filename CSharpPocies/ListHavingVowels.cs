namespace CSharpPocies;

public class ListHavingVowels
{
    public List<string> FilterListHavingTwoVowels(List<string> lists)
    {
        HashSet<Char> vowelChars = new HashSet<Char>()
        {
            'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u'
        };
        var filteredName = lists.Where(x => x.Count(c => vowelChars.Contains(c)) > 1).ToList();
        return filteredName;
    }
}
