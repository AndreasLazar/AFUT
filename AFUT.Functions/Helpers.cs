namespace AFUT.Functions
{
    public static class Helpers
    {
        public static string GetResponseMessage(string name)
            => string.IsNullOrEmpty(name) ? "Please provide a name" : $"Hello {name}";
    }
}