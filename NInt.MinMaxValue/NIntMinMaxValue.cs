using System;

namespace NInt.MinMaxValue;

#if NETSTANDARD 

public static class NIntMinMaxValue
{
    public static nint MinValue = IntPtr.Size == 4 ? int.MinValue : unchecked((nint)long.MinValue);
    public static nint MaxValue = IntPtr.Size == 4 ? int.MaxValue : unchecked((nint)long.MaxValue);
}
public static class NUIntMinMaxValue
{
    public static nuint MinValue = 0;
    public static nuint MaxValue = UIntPtr.Size == 4 ? uint.MaxValue : unchecked((nuint)ulong.MaxValue);
}

#else

public static class NIntMinMaxValue
{
    public static nint MinValue = nint.MinValue;
    public static nint MaxValue = nint.MaxValue;
}
public static class NUIntMinMaxValue
{
    public static nuint MinValue = nuint.MinValue;
    public static nuint MaxValue = nuint.MaxValue;
}

#endif
