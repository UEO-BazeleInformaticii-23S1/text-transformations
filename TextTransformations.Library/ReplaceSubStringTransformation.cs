namespace TextTransformations.Library
{
    public class ReplaceSubStringTransformation : TextTransformation
    {
        public ReplaceSubStringTransformation(
            string lookupText, string replaceWithText)
        {
            LookupText = lookupText ?? throw new ArgumentNullException(nameof(lookupText));
            ReplaceWithText = replaceWithText ?? throw new ArgumentNullException(nameof(replaceWithText));
        }

        public string LookupText { get; }

        public string ReplaceWithText { get; }

        public override string Apply(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            string result = text.Replace(LookupText, ReplaceWithText);

            return result;

        }
    }
}
