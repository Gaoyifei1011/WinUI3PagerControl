using ABI.System.Collections.Generic;
using System;
using System.Collections.Generic;

namespace WinRT.GenericTypeInstantiations;

internal static class Windows_Foundation_Collections_IVector_1_object
{
    private static bool Initialized { get; } = Init();

    public static bool EnsureInitialized()
    {
        return Initialized;
    }

    private static unsafe object GetAt(IObjectReference _obj, uint index)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        IntPtr ptr = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, uint, IntPtr*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 6 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, uint, IntPtr*, int>))))(thisPtr, index, &ptr));
            return MarshalInspectable<object>.FromAbi(ptr);
        }
        finally
        {
            MarshalInspectable<object>.DisposeAbi(ptr);
        }
    }

    private static unsafe IReadOnlyList<object> GetView(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        IntPtr intPtr = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(*(IntPtr*)((*(IntPtr*)(void*)thisPtr) + 8 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>))))(thisPtr, &intPtr));
            Windows_Foundation_Collections_IVectorView_1_object.EnsureInitialized();
            return MarshalInterface<IReadOnlyList<object>>.FromAbi(intPtr);
        }
        finally
        {
            MarshalInterface<IReadOnlyList<object>>.DisposeAbi(intPtr);
        }
    }

    private static unsafe bool IndexOf(IObjectReference _obj, object value, out uint index)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        ObjectReferenceValue value2 = default;
        uint num = 0u;
        byte b = 0;
        try
        {
            value2 = MarshalInspectable<object>.CreateMarshaler2(value);
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr, uint*, byte*, int>)(*(IntPtr*)((*(IntPtr*)(void*)thisPtr) + 9 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr, uint*, byte*, int>))))(thisPtr, MarshalInspectable<object>.GetAbi(value2), &num, &b));
            index = num;
            return b != 0;
        }
        finally
        {
            MarshalInspectable<object>.DisposeMarshaler(value2);
        }
    }

    private static unsafe void SetAt(IObjectReference _obj, uint index, object value)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        ObjectReferenceValue value2 = default;
        try
        {
            value2 = MarshalInspectable<object>.CreateMarshaler2(value);
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, uint, IntPtr, int>)(*(IntPtr*)((*(IntPtr*)(void*)thisPtr) + 10 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, uint, IntPtr, int>))))(thisPtr, index, MarshalInspectable<object>.GetAbi(value2)));
        }
        finally
        {
            MarshalInspectable<object>.DisposeMarshaler(value2);
        }
    }

    private static unsafe void InsertAt(IObjectReference _obj, uint index, object value)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        ObjectReferenceValue value2 = default;
        try
        {
            value2 = MarshalInspectable<object>.CreateMarshaler2(value);
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, uint, IntPtr, int>)(*(IntPtr*)((*(IntPtr*)(void*)thisPtr) + 11 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, uint, IntPtr, int>))))(thisPtr, index, MarshalInspectable<object>.GetAbi(value2)));
        }
        finally
        {
            MarshalInspectable<object>.DisposeMarshaler(value2);
        }
    }

    private static unsafe void Append(IObjectReference _obj, object value)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        ObjectReferenceValue value2 = default;
        try
        {
            value2 = MarshalInspectable<object>.CreateMarshaler2(value);
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr, int>)(*(IntPtr*)((*(IntPtr*)(void*)thisPtr) + 13 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr, int>))))(thisPtr, MarshalInspectable<object>.GetAbi(value2)));
        }
        finally
        {
            MarshalInspectable<object>.DisposeMarshaler(value2);
        }
    }

    private static unsafe uint GetMany(IObjectReference _obj, uint startIndex, object[] items)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        MarshalInterfaceHelper<object>.MarshalerArray marshalerArray = default;
        int num = 0;
        IntPtr intPtr = default;
        uint result = 0u;
        try
        {
            marshalerArray = MarshalInspectable<object>.CreateMarshalerArray(items);
            (num, intPtr) = MarshalInspectable<object>.GetAbiArray(marshalerArray);
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)(*(IntPtr*)((*(IntPtr*)(void*)thisPtr) + 16 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>))))(thisPtr, startIndex, num, intPtr, &result));
            MarshalInspectable<object>.CopyAbiArray(items, (num, intPtr));
            return result;
        }
        finally
        {
            MarshalInspectable<object>.DisposeMarshalerArray(marshalerArray);
        }
    }

    private static unsafe void ReplaceAll(IObjectReference _obj, object[] items)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        MarshalInterfaceHelper<object>.MarshalerArray marshalerArray = default;
        int num = 0;
        IntPtr intPtr = default;
        try
        {
            marshalerArray = MarshalInspectable<object>.CreateMarshalerArray(items);
            (num, intPtr) = MarshalInspectable<object>.GetAbiArray(marshalerArray);
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, int>)(*(IntPtr*)((*(IntPtr*)(void*)thisPtr) + 17 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, int>))))(thisPtr, num, intPtr));
        }
        finally
        {
            MarshalInspectable<object>.DisposeMarshalerArray(marshalerArray);
        }
    }

    private static unsafe bool Init()
    {
        IListMethods<object, IntPtr>.InitRcwHelper((delegate*<IObjectReference, uint, object>)(&GetAt), (delegate*<IObjectReference, IReadOnlyList<object>>)(&GetView), (delegate*<IObjectReference, object, out uint, bool>)(&IndexOf), (delegate*<IObjectReference, uint, object, void>)(&SetAt), (delegate*<IObjectReference, uint, object, void>)(&InsertAt), (delegate*<IObjectReference, object, void>)(&Append), (delegate*<IObjectReference, uint, object[], uint>)(&GetMany), (delegate*<IObjectReference, object[], void>)(&ReplaceAll));
        Windows_Foundation_Collections_IIterable_1_object.EnsureInitialized();
        return true;
    }
}