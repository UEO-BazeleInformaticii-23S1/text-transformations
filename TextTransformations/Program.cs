using TextTransformations.Library;

namespace TextTransformations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = string.Empty;

            string result = TransformationEngine.ApplyAll(
                text,
                new InsertSubStringTransformation(0, "This is the original text"),
                new RemoveSubStringTransformation("This "),
                new ReplaceSubStringTransformation("original", "modified"));

            Console.WriteLine("Result=" + result);
        }
    }
}