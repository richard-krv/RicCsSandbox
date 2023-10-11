using System.Collections;

namespace RcUtils;

public static class Extensions
{
    public static string ToCSVString(this int[] arr)
    {
        return string.Join(",", arr);
    }

    public static string ToCSVString(this object[] arr)
    {
        return string.Join(",", arr);
    }

    public static string ToCSVString(this IStructuralEquatable arr)
    {
        return string.Join(",", arr as int[]);
    }
}
