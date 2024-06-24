namespace Test.Helper;

public class StringHelper
{ 
    public static string ProcessAttribute(string attribute)
    {
        if (!string.IsNullOrEmpty(attribute))
        {
            int index = attribute.IndexOf('(');
            if (index >= 0)
            {
                attribute = attribute.Substring(0, index).Trim();
            }
        }
        return attribute;
    }
}