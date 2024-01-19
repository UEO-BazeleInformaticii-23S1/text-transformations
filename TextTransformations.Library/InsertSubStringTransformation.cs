namespace TextTransformations.Library
{
    public class InsertSubStringTransformation : TextTransformation
    {
        public InsertSubStringTransformation(
            int index, string subString)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("index");
            }

            Index = index;
            SubString = subString ?? throw new ArgumentNullException(nameof(subString));
        }


        public int Index { get; }

        public string SubString { get; }

        public override string Apply(string text)
        {
            // text = text ?? string.Empty;
            // or alternatively:
            if (text is null)
            {
                text = string.Empty;
            }

            //if (Index < text.Length || (Index == 0 && text.Length == 0))
            // or simpler:
            if (Index < text.Length || Index == 0)
            {
                string result = text.Insert(Index, SubString);

                return result;
            }
            else
            {
                throw new IndexOutOfRangeException(
                    $"Index '{Index}' must be greater than (or equal to) 0 and less than '{text.Length}'");
            }
        }
    }
}
