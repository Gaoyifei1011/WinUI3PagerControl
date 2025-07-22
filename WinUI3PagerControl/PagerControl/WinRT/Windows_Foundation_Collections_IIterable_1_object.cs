using System;

namespace WinRT.GenericTypeInstantiations;

internal static class Windows_Foundation_Collections_IIterable_1_object
{
    private static bool Initialized { get; } = Init();

    public static bool EnsureInitialized() => Initialized;

    private static unsafe System.Collections.Generic.IEnumerator<object> First(IObjectReference _obj)
    {
        var ThisPtr = _obj.ThisPtr;

        IntPtr __retval = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR((*(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>**)ThisPtr)[6](ThisPtr, &__retval));
            GC.KeepAlive(_obj);
            _ = Windows_Foundation_Collections_IIterator_1_object.EnsureInitialized();
            return MarshalInterface<System.Collections.Generic.IEnumerator<object>>.FromAbi(__retval);
        }
        finally
        {
            MarshalInterface<System.Collections.Generic.IEnumerator<object>>.DisposeAbi(__retval);
        }
    }

    private static unsafe bool Init()
    {
        ABI.System.Collections.Generic.IEnumerableMethods<object, IntPtr>.InitRcwHelper(&First);
        return true;
    }
}