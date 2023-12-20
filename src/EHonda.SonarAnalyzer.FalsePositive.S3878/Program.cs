const int a = 1;
int[] bs = [2, 3];

// Reports S3878
F([a, ..bs]);

// The equivalent before C# 12 collection expressions, does not report S3878
F(bs.Prepend(a).ToArray());

void F(params int[] xs)
{
    Console.WriteLine(xs.Length);
}
