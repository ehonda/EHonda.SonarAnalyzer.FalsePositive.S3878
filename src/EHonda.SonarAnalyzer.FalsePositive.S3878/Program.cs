const int a = 1;
int[] cs = [2, 3];

// Reports S3878
F([a, ..cs]);

// The equivalent before C# 12 collection expressions, does not report S3878
F(cs.Prepend(a).ToArray());

void F(params int[] xs)
{
    Console.WriteLine(xs.Length);
}
