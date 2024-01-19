namespace TextTransformations.Library
{
    public class RemoveSubStringTransformation : TextTransformation
    {
        public RemoveSubStringTransformation(string lookupText) 
        {
            LookupText = lookupText ?? throw new ArgumentNullException(nameof(lookupText));
        }

        public string LookupText { get; }

        public override string Apply(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            string result = text.Replace(LookupText, string.Empty);

            return result;
        }
    }
}
