using System;

namespace WinRT.GenericTypeInstantiations;

internal static class Windows_Foundation_Collections_IIterator_1_object
{
    private static bool Initialized { get; } = Init();

    public static bool EnsureInitialized() => Initialized;

    private static unsafe uint GetMany(IObjectReference _obj, object[] items)
    {
        var ThisPtr = _obj.ThisPtr;

        MarshalInterfaceHelper<object>.MarshalerArray __items = default;
        int __items_length = default;
        IntPtr __items_data = default;
        uint __retval = default;
        try
        {
            __items = MarshalInspectable<object>.CreateMarshalerArray(items);
            (__items_length, __items_data) = MarshalInspectable<object>.GetAbiArray(__items);
            ExceptionHelpers.ThrowExceptionForHR((*(delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, uint*, int>**)ThisPtr)[9](ThisPtr, __items_length, __items_data, &__retval));
            GC.KeepAlive(_obj);
            MarshalInspectable<object>.CopyAbiArray(items, (__items_length, __items_data));
            return __retval;
        }
        finally
        {
            MarshalInspectable<object>.DisposeMarshalerArray(__items);
        }
    }

    private static unsafe object get_Current(IObjectReference _obj)
    {
        var ThisPtr = _obj.ThisPtr;

        IntPtr __retval = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR((*(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>**)ThisPtr)[6](ThisPtr, &__retval));
            GC.KeepAlive(_obj);
            return MarshalInspectable<object>.FromAbi(__retval);
        }
        finally
        {
            MarshalInspectable<object>.DisposeAbi(__retval);
        }
    }

    private static unsafe bool Init()
    {
        ABI.System.Collections.Generic.IEnumeratorMethods<object, IntPtr>.InitRcwHelper(&get_Current, &GetMany);
        return true;
    }
}