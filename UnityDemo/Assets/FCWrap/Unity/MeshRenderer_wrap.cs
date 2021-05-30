using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityObject = UnityEngine.Object;

public class MeshRenderer_wrap
{
    public static UnityEngine.MeshRenderer get_obj(long L)
    {
        return FCGetObj.GetObj<UnityEngine.MeshRenderer>(L);
    }

    public static void Register(long VM)
    {
        int nClassName = FCLibHelper.fc_get_inport_class_id(VM, "MeshRenderer");
        FCLibHelper.fc_register_class_new(VM, nClassName, obj_new);
        FCLibHelper.fc_register_class_del(VM, nClassName,obj_del);
        FCLibHelper.fc_register_class_release_ref(VM, nClassName,obj_release);
        FCLibHelper.fc_register_class_hash(VM, nClassName,obj_hash);
        FCLibHelper.fc_register_class_equal(VM, nClassName,obj_equal);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"additionalVertexStreams",get_additionalVertexStreams_wrap,set_additionalVertexStreams_wrap);
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int  obj_new(long L)
    {
        long nPtr = FCGetObj.NewObj<UnityEngine.MeshRenderer>();
        long ret = FCLibHelper.fc_get_return_ptr(L);
        long VM = FCLibHelper.fc_get_vm_ptr(L);
        FCLibHelper.fc_set_value_wrap_objptr(VM, ret, nPtr);
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int  obj_del(long L)
    {
        FCGetObj.DelObj(L);
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int  obj_release(long L)
    {
        FCGetObj.ReleaseRef(L);
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int  obj_hash(long nIntPtr)
    {
        UnityEngine.MeshRenderer obj = FCGetObj.GetObj<UnityEngine.MeshRenderer>(nIntPtr);
        if(obj != null)
        {
            return obj.GetHashCode();
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_equal))]
    public static bool  obj_equal(long L, long R)
    {
        UnityEngine.MeshRenderer left  = FCGetObj.GetObj<UnityEngine.MeshRenderer>(L);
        UnityEngine.MeshRenderer right = FCGetObj.GetObj<UnityEngine.MeshRenderer>(R);
        if(left != null)
        {
            return left.Equals(right);
        }
        if(right != null)
        {
            return right.Equals(left);
        }
        return true;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_additionalVertexStreams_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.MeshRenderer ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long v = FCGetObj.PushObj(ret.additionalVertexStreams);
            FCLibHelper.fc_set_value_wrap_objptr(VM, ret_ptr, v);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_additionalVertexStreams_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.MeshRenderer ret = get_obj(nThisPtr);
            UnityEngine.Mesh arg0 = FCGetObj.GetObj<UnityEngine.Mesh>(FCLibHelper.fc_get_wrap_objptr(L,0));
            ret.additionalVertexStreams = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

}
