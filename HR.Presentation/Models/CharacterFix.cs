using System.Globalization;
using System.Text;

namespace HR.Presentation.Models;

public static class CharacterFix
{
    public static string Fix(string value)
    {
        string temp = value.Normalize(NormalizationForm.FormD);
        StringBuilder sb = new StringBuilder();

        foreach (char c in temp)
        {
            if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                sb.Append(c);
        }
        return sb.ToString().Normalize(NormalizationForm.FormC).ToLowerInvariant();
    }
}
