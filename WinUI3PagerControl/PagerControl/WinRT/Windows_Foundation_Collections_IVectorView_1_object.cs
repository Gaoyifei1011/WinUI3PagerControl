using System;

namespace WinRT.GenericTypeInstantiations;

internal static class Windows_Foundation_Collections_IVectorView_1_object
{
    private static bool Initialized { get; } = Init();

    public static bool EnsureInitialized() => Initialized;

    private static unsafe object GetAt(IObjectReference _obj, uint index)
    {
        var ThisPtr = _obj.ThisPtr;

        IntPtr __retval = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR((*(delegate* unmanaged[Stdcall]<IntPtr, uint, IntPtr*, int>**)ThisPtr)[6](ThisPtr, index, &__retval));
            GC.KeepAlive(_obj);
            return MarshalInspectable<object>.FromAbi(__retval);
        }
        finally
        {
            MarshalInspectable<object>.DisposeAbi(__retval);
        }
    }

    private static unsafe bool IndexOf(IObjectReference _obj, object value, out uint index)
    {
        var ThisPtr = _obj.ThisPtr;

        ObjectReferenceValue __value = default;
        uint __index = default;
        byte __retval = default;
        try
        {
            __value = MarshalInspectable<object>.CreateMarshaler2(value);
            ExceptionHelpers.ThrowExceptionForHR((*(delegate* unmanaged[Stdcall]<IntPtr, IntPtr, uint*, byte*, int>**)ThisPtr)[8](ThisPtr, MarshalInspectable<object>.GetAbi(__value), &__index, &__retval));
            GC.KeepAlive(_obj);
            index = __index;
            return __retval != 0;
        }
        finally
        {
            MarshalInspectable<object>.DisposeMarshaler(__value);
        }
    }

    private static unsafe uint GetMany(IObjectReference _obj, uint startIndex, object[] items)
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
            ExceptionHelpers.ThrowExceptionForHR((*(delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>**)ThisPtr)[9](ThisPtr, startIndex, __items_length, __items_data, &__retval));
            GC.KeepAlive(_obj);
            MarshalInspectable<object>.CopyAbiArray(items, (__items_length, __items_data));
            return __retval;
        }
        finally
        {
            MarshalInspectable<object>.DisposeMarshalerArray(__items);
        }
    }

    private static unsafe bool Init()
    {
        global::ABI.System.Collections.Generic.IReadOnlyListMethods<object, IntPtr>.InitRcwHelper(&GetAt,
        &IndexOf,
        &GetMany);
        _ = Windows_Foundation_Collections_IIterable_1_object.EnsureInitialized();
        return true;
    }
}