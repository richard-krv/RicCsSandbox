using RcUtils;

namespace RcCollections;

using System.Collections;
using static OutputConsole;

internal class RcArray
{
    public static void EqualityCheck()
    {
        var arr1 = new[] { 1, 2, 3, 4, 5 };
        var arr2 = new[] { 1, 2, 3, 4, 5 };

        WriteLine($"Comparing arrays {arr1.ToCSVString()} and {arr2.ToCSVString()} = {(arr1.Equals(arr2)? "equal" : "not equal")}");

        IStructuralEquatable iseArr1 = new[] { 1, 2, 3, 4, 5 };
        IStructuralEquatable iseArr2 = new[] { 1, 2, 3, 4, 5 };

        WriteLine($"Comparing ISE arrays {iseArr1.ToCSVString()} and {iseArr2.ToCSVString()} = {(iseArr1.Equals(iseArr2, EqualityComparer<object>.Default) ? "equal" : "not equal")}");

        IStructuralEquatable iseTpl1 = ( 1, 2, 3, 4, 5 );
        IStructuralEquatable iseTpl2 = ( 1, 2, 3, 4, 5 );

        WriteLine($"Comparing ISE tuples {iseTpl1} and {iseTpl2} = {(iseTpl1.Equals(iseTpl2, EqualityComparer<object>.Default) ? "equal" : "not equal")}");

        IStructuralEquatable iseArr3 = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 8 };
        IStructuralEquatable iseArr4 = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

        WriteLine($"Comparing ISE arrays {iseArr3.ToCSVString()} and {iseArr4.ToCSVString()} = {(iseArr3.Equals(iseArr4, EqualityComparer<object>.Default) ? "equal" : "not equal")}");

    }
}