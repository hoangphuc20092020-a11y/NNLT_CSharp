internal static class TestPaths
{
    internal static readonly string Root = Environment.GetEnvironmentVariable("LAB05_CHECK_OUTPUT")
        ?? Path.Combine(Path.GetTempPath(), "NNLT_CSharp-Lab05-check");
    internal static string Images => Path.Combine(Root, "renders");
    internal static string Results => Path.Combine(Root, "check-results.json");
}
