using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityObject = UnityEngine.Object;
using System.Collections;

public class Transform_wrap
{
    public static UnityEngine.Transform get_obj(long L)
    {
        return FCGetObj.GetObj<UnityEngine.Transform>(L);
    }

    public static void Register(long VM)
    {
        int nClassName = FCLibHelper.fc_get_inport_class_id(VM, "Transform");
        FCLibHelper.fc_register_class_del(VM, nClassName,obj_del);
        FCLibHelper.fc_register_class_release_ref(VM, nClassName,obj_release);
        FCLibHelper.fc_register_class_hash(VM, nClassName,obj_hash);
        FCLibHelper.fc_register_class_equal(VM, nClassName,obj_equal);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"position",get_position_wrap,set_position_wrap);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"localPosition",get_localPosition_wrap,set_localPosition_wrap);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"eulerAngles",get_eulerAngles_wrap,set_eulerAngles_wrap);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"localEulerAngles",get_localEulerAngles_wrap,set_localEulerAngles_wrap);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"right",get_right_wrap,set_right_wrap);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"up",get_up_wrap,set_up_wrap);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"forward",get_forward_wrap,set_forward_wrap);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"rotation",get_rotation_wrap,set_rotation_wrap);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"localRotation",get_localRotation_wrap,set_localRotation_wrap);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"localScale",get_localScale_wrap,set_localScale_wrap);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"parent",get_parent_wrap,set_parent_wrap);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"worldToLocalMatrix",get_worldToLocalMatrix_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"localToWorldMatrix",get_localToWorldMatrix_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"root",get_root_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"childCount",get_childCount_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"lossyScale",get_lossyScale_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"hasChanged",get_hasChanged_wrap,set_hasChanged_wrap);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"hierarchyCapacity",get_hierarchyCapacity_wrap,set_hierarchyCapacity_wrap);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"hierarchyCount",get_hierarchyCount_wrap,null);
        FCLibHelper.fc_register_class_func(VM, nClassName,"SetParent_Transform",SetParent_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"SetParent_Transform_bool",SetParent1_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"SetPositionAndRotation",SetPositionAndRotation_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"Translate_Vector3",Translate_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"Translate_Vector3_Space",Translate1_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"Translate_float_float_float",Translate2_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"Translate_float_float_float_Space",Translate3_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"Translate_Vector3_Transform",Translate4_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"Translate_float_float_float_Transform",Translate5_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"Rotate_Vector3",Rotate_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"Rotate_Vector3_Space",Rotate1_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"Rotate_float_float_float",Rotate2_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"Rotate_float_float_float_Space",Rotate3_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"Rotate_Vector3_float",Rotate4_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"Rotate_Vector3_float_Space",Rotate5_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"RotateAround",RotateAround_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"LookAt_Transform",LookAt_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"LookAt_Transform_Vector3",LookAt1_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"LookAt_Vector3_Vector3",LookAt2_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"LookAt_Vector3",LookAt3_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"TransformDirection_Vector3",TransformDirection_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"TransformDirection_float_float_float",TransformDirection1_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"InverseTransformDirection_Vector3",InverseTransformDirection_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"InverseTransformDirection_float_float_float",InverseTransformDirection1_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"TransformVector_Vector3",TransformVector_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"TransformVector_float_float_float",TransformVector1_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"InverseTransformVector_Vector3",InverseTransformVector_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"InverseTransformVector_float_float_float",InverseTransformVector1_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"TransformPoint_Vector3",TransformPoint_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"TransformPoint_float_float_float",TransformPoint1_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"InverseTransformPoint_Vector3",InverseTransformPoint_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"InverseTransformPoint_float_float_float",InverseTransformPoint1_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"DetachChildren",DetachChildren_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"SetAsFirstSibling",SetAsFirstSibling_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"SetAsLastSibling",SetAsLastSibling_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"SetSiblingIndex",SetSiblingIndex_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"GetSiblingIndex",GetSiblingIndex_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"Find",Find_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"IsChildOf",IsChildOf_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"GetEnumerator",GetEnumerator_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"GetChild",GetChild_wrap);
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
        UnityEngine.Transform obj = FCGetObj.GetObj<UnityEngine.Transform>(nIntPtr);
        if(obj != null)
        {
            return obj.GetHashCode();
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_equal))]
    public static bool  obj_equal(long L, long R)
    {
        UnityEngine.Transform left  = FCGetObj.GetObj<UnityEngine.Transform>(L);
        UnityEngine.Transform right = FCGetObj.GetObj<UnityEngine.Transform>(R);
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
    public static int get_position_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            Vector3 temp_ret = ret.position;
            FCLibHelper.fc_set_value_vector3(ret_ptr, ref temp_ret);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_position_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform ret = get_obj(nThisPtr);
            Vector3 arg0 = new Vector3();
            FCLibHelper.fc_get_vector3(L,0,ref arg0);
            ret.position = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_localPosition_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            Vector3 temp_ret = ret.localPosition;
            FCLibHelper.fc_set_value_vector3(ret_ptr, ref temp_ret);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_localPosition_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform ret = get_obj(nThisPtr);
            Vector3 arg0 = new Vector3();
            FCLibHelper.fc_get_vector3(L,0,ref arg0);
            ret.localPosition = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_eulerAngles_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            Vector3 temp_ret = ret.eulerAngles;
            FCLibHelper.fc_set_value_vector3(ret_ptr, ref temp_ret);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_eulerAngles_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform ret = get_obj(nThisPtr);
            Vector3 arg0 = new Vector3();
            FCLibHelper.fc_get_vector3(L,0,ref arg0);
            ret.eulerAngles = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_localEulerAngles_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            Vector3 temp_ret = ret.localEulerAngles;
            FCLibHelper.fc_set_value_vector3(ret_ptr, ref temp_ret);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_localEulerAngles_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform ret = get_obj(nThisPtr);
            Vector3 arg0 = new Vector3();
            FCLibHelper.fc_get_vector3(L,0,ref arg0);
            ret.localEulerAngles = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_right_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            Vector3 temp_ret = ret.right;
            FCLibHelper.fc_set_value_vector3(ret_ptr, ref temp_ret);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_right_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform ret = get_obj(nThisPtr);
            Vector3 arg0 = new Vector3();
            FCLibHelper.fc_get_vector3(L,0,ref arg0);
            ret.right = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_up_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            Vector3 temp_ret = ret.up;
            FCLibHelper.fc_set_value_vector3(ret_ptr, ref temp_ret);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_up_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform ret = get_obj(nThisPtr);
            Vector3 arg0 = new Vector3();
            FCLibHelper.fc_get_vector3(L,0,ref arg0);
            ret.up = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_forward_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            Vector3 temp_ret = ret.forward;
            FCLibHelper.fc_set_value_vector3(ret_ptr, ref temp_ret);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_forward_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform ret = get_obj(nThisPtr);
            Vector3 arg0 = new Vector3();
            FCLibHelper.fc_get_vector3(L,0,ref arg0);
            ret.forward = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_rotation_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            Quaternion temp_ret = ret.rotation;
            FCLibHelper.fc_set_value_quaternion(ret_ptr, ref temp_ret);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_rotation_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform ret = get_obj(nThisPtr);
            Quaternion arg0 = new Quaternion();
            FCLibHelper.fc_get_quaternion(L,0,ref arg0);
            ret.rotation = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_localRotation_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            Quaternion temp_ret = ret.localRotation;
            FCLibHelper.fc_set_value_quaternion(ret_ptr, ref temp_ret);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_localRotation_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform ret = get_obj(nThisPtr);
            Quaternion arg0 = new Quaternion();
            FCLibHelper.fc_get_quaternion(L,0,ref arg0);
            ret.localRotation = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_localScale_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            Vector3 temp_ret = ret.localScale;
            FCLibHelper.fc_set_value_vector3(ret_ptr, ref temp_ret);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_localScale_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform ret = get_obj(nThisPtr);
            Vector3 arg0 = new Vector3();
            FCLibHelper.fc_get_vector3(L,0,ref arg0);
            ret.localScale = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_parent_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long v = FCGetObj.PushObj(ret.parent);
            FCLibHelper.fc_set_value_wrap_objptr(VM, ret_ptr, v);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_parent_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform ret = get_obj(nThisPtr);
            UnityEngine.Transform arg0 = FCGetObj.GetObj<UnityEngine.Transform>(FCLibHelper.fc_get_wrap_objptr(L,0));
            ret.parent = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_worldToLocalMatrix_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            Matrix4x4 temp_ret = ret.worldToLocalMatrix;
            FCLibHelper.fc_set_value_matrix(ret_ptr, ref temp_ret);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_localToWorldMatrix_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            Matrix4x4 temp_ret = ret.localToWorldMatrix;
            FCLibHelper.fc_set_value_matrix(ret_ptr, ref temp_ret);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_root_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long v = FCGetObj.PushObj(ret.root);
            FCLibHelper.fc_set_value_wrap_objptr(VM, ret_ptr, v);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_childCount_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_int(ret_ptr, ret.childCount);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_lossyScale_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            Vector3 temp_ret = ret.lossyScale;
            FCLibHelper.fc_set_value_vector3(ret_ptr, ref temp_ret);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_hasChanged_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_bool(ret_ptr, ret.hasChanged);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_hasChanged_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform ret = get_obj(nThisPtr);
            bool arg0 = FCLibHelper.fc_get_bool(L,0);
            ret.hasChanged = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_hierarchyCapacity_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_int(ret_ptr, ret.hierarchyCapacity);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_hierarchyCapacity_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform ret = get_obj(nThisPtr);
            int arg0 = FCLibHelper.fc_get_int(L,0);
            ret.hierarchyCapacity = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_hierarchyCount_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_int(ret_ptr, ret.hierarchyCount);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int SetParent_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            UnityEngine.Transform arg0 = FCGetObj.GetObj<UnityEngine.Transform>(FCLibHelper.fc_get_wrap_objptr(L,0));
            obj.SetParent(arg0);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int SetParent1_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            UnityEngine.Transform arg0 = FCGetObj.GetObj<UnityEngine.Transform>(FCLibHelper.fc_get_wrap_objptr(L,0));
            bool arg1 = FCLibHelper.fc_get_bool(L,1);
            obj.SetParent(arg0,arg1);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int SetPositionAndRotation_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            Vector3 arg0 = new Vector3();
            FCLibHelper.fc_get_vector3(L,0,ref arg0);
            Quaternion arg1 = new Quaternion();
            FCLibHelper.fc_get_quaternion(L,1,ref arg1);
            obj.SetPositionAndRotation(arg0,arg1);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int Translate_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            Vector3 arg0 = new Vector3();
            FCLibHelper.fc_get_vector3(L,0,ref arg0);
            obj.Translate(arg0);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int Translate1_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            Vector3 arg0 = new Vector3();
            FCLibHelper.fc_get_vector3(L,0,ref arg0);
            UnityEngine.Space arg1 = (UnityEngine.Space)(FCLibHelper.fc_get_int(L,1));
            obj.Translate(arg0,arg1);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int Translate2_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            float arg0 = FCLibHelper.fc_get_float(L,0);
            float arg1 = FCLibHelper.fc_get_float(L,1);
            float arg2 = FCLibHelper.fc_get_float(L,2);
            obj.Translate(arg0,arg1,arg2);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int Translate3_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            float arg0 = FCLibHelper.fc_get_float(L,0);
            float arg1 = FCLibHelper.fc_get_float(L,1);
            float arg2 = FCLibHelper.fc_get_float(L,2);
            UnityEngine.Space arg3 = (UnityEngine.Space)(FCLibHelper.fc_get_int(L,3));
            obj.Translate(arg0,arg1,arg2,arg3);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int Translate4_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            Vector3 arg0 = new Vector3();
            FCLibHelper.fc_get_vector3(L,0,ref arg0);
            UnityEngine.Transform arg1 = FCGetObj.GetObj<UnityEngine.Transform>(FCLibHelper.fc_get_wrap_objptr(L,1));
            obj.Translate(arg0,arg1);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int Translate5_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            float arg0 = FCLibHelper.fc_get_float(L,0);
            float arg1 = FCLibHelper.fc_get_float(L,1);
            float arg2 = FCLibHelper.fc_get_float(L,2);
            UnityEngine.Transform arg3 = FCGetObj.GetObj<UnityEngine.Transform>(FCLibHelper.fc_get_wrap_objptr(L,3));
            obj.Translate(arg0,arg1,arg2,arg3);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int Rotate_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            Vector3 arg0 = new Vector3();
            FCLibHelper.fc_get_vector3(L,0,ref arg0);
            obj.Rotate(arg0);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int Rotate1_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            Vector3 arg0 = new Vector3();
            FCLibHelper.fc_get_vector3(L,0,ref arg0);
            UnityEngine.Space arg1 = (UnityEngine.Space)(FCLibHelper.fc_get_int(L,1));
            obj.Rotate(arg0,arg1);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int Rotate2_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            float arg0 = FCLibHelper.fc_get_float(L,0);
            float arg1 = FCLibHelper.fc_get_float(L,1);
            float arg2 = FCLibHelper.fc_get_float(L,2);
            obj.Rotate(arg0,arg1,arg2);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int Rotate3_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            float arg0 = FCLibHelper.fc_get_float(L,0);
            float arg1 = FCLibHelper.fc_get_float(L,1);
            float arg2 = FCLibHelper.fc_get_float(L,2);
            UnityEngine.Space arg3 = (UnityEngine.Space)(FCLibHelper.fc_get_int(L,3));
            obj.Rotate(arg0,arg1,arg2,arg3);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int Rotate4_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            Vector3 arg0 = new Vector3();
            FCLibHelper.fc_get_vector3(L,0,ref arg0);
            float arg1 = FCLibHelper.fc_get_float(L,1);
            obj.Rotate(arg0,arg1);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int Rotate5_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            Vector3 arg0 = new Vector3();
            FCLibHelper.fc_get_vector3(L,0,ref arg0);
            float arg1 = FCLibHelper.fc_get_float(L,1);
            UnityEngine.Space arg2 = (UnityEngine.Space)(FCLibHelper.fc_get_int(L,2));
            obj.Rotate(arg0,arg1,arg2);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int RotateAround_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            Vector3 arg0 = new Vector3();
            FCLibHelper.fc_get_vector3(L,0,ref arg0);
            Vector3 arg1 = new Vector3();
            FCLibHelper.fc_get_vector3(L,1,ref arg1);
            float arg2 = FCLibHelper.fc_get_float(L,2);
            obj.RotateAround(arg0,arg1,arg2);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int LookAt_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            UnityEngine.Transform arg0 = FCGetObj.GetObj<UnityEngine.Transform>(FCLibHelper.fc_get_wrap_objptr(L,0));
            obj.LookAt(arg0);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int LookAt1_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            UnityEngine.Transform arg0 = FCGetObj.GetObj<UnityEngine.Transform>(FCLibHelper.fc_get_wrap_objptr(L,0));
            Vector3 arg1 = new Vector3();
            FCLibHelper.fc_get_vector3(L,1,ref arg1);
            obj.LookAt(arg0,arg1);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int LookAt2_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            Vector3 arg0 = new Vector3();
            FCLibHelper.fc_get_vector3(L,0,ref arg0);
            Vector3 arg1 = new Vector3();
            FCLibHelper.fc_get_vector3(L,1,ref arg1);
            obj.LookAt(arg0,arg1);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int LookAt3_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            Vector3 arg0 = new Vector3();
            FCLibHelper.fc_get_vector3(L,0,ref arg0);
            obj.LookAt(arg0);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int TransformDirection_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            Vector3 arg0 = new Vector3();
            FCLibHelper.fc_get_vector3(L,0,ref arg0);
            Vector3 ret = obj.TransformDirection(arg0);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            Vector3 temp_ret = ret;
            FCLibHelper.fc_set_value_vector3(ret_ptr, ref temp_ret);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int TransformDirection1_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            float arg0 = FCLibHelper.fc_get_float(L,0);
            float arg1 = FCLibHelper.fc_get_float(L,1);
            float arg2 = FCLibHelper.fc_get_float(L,2);
            Vector3 ret = obj.TransformDirection(arg0,arg1,arg2);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            Vector3 temp_ret = ret;
            FCLibHelper.fc_set_value_vector3(ret_ptr, ref temp_ret);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int InverseTransformDirection_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            Vector3 arg0 = new Vector3();
            FCLibHelper.fc_get_vector3(L,0,ref arg0);
            Vector3 ret = obj.InverseTransformDirection(arg0);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            Vector3 temp_ret = ret;
            FCLibHelper.fc_set_value_vector3(ret_ptr, ref temp_ret);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int InverseTransformDirection1_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            float arg0 = FCLibHelper.fc_get_float(L,0);
            float arg1 = FCLibHelper.fc_get_float(L,1);
            float arg2 = FCLibHelper.fc_get_float(L,2);
            Vector3 ret = obj.InverseTransformDirection(arg0,arg1,arg2);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            Vector3 temp_ret = ret;
            FCLibHelper.fc_set_value_vector3(ret_ptr, ref temp_ret);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int TransformVector_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            Vector3 arg0 = new Vector3();
            FCLibHelper.fc_get_vector3(L,0,ref arg0);
            Vector3 ret = obj.TransformVector(arg0);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            Vector3 temp_ret = ret;
            FCLibHelper.fc_set_value_vector3(ret_ptr, ref temp_ret);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int TransformVector1_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            float arg0 = FCLibHelper.fc_get_float(L,0);
            float arg1 = FCLibHelper.fc_get_float(L,1);
            float arg2 = FCLibHelper.fc_get_float(L,2);
            Vector3 ret = obj.TransformVector(arg0,arg1,arg2);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            Vector3 temp_ret = ret;
            FCLibHelper.fc_set_value_vector3(ret_ptr, ref temp_ret);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int InverseTransformVector_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            Vector3 arg0 = new Vector3();
            FCLibHelper.fc_get_vector3(L,0,ref arg0);
            Vector3 ret = obj.InverseTransformVector(arg0);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            Vector3 temp_ret = ret;
            FCLibHelper.fc_set_value_vector3(ret_ptr, ref temp_ret);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int InverseTransformVector1_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            float arg0 = FCLibHelper.fc_get_float(L,0);
            float arg1 = FCLibHelper.fc_get_float(L,1);
            float arg2 = FCLibHelper.fc_get_float(L,2);
            Vector3 ret = obj.InverseTransformVector(arg0,arg1,arg2);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            Vector3 temp_ret = ret;
            FCLibHelper.fc_set_value_vector3(ret_ptr, ref temp_ret);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int TransformPoint_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            Vector3 arg0 = new Vector3();
            FCLibHelper.fc_get_vector3(L,0,ref arg0);
            Vector3 ret = obj.TransformPoint(arg0);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            Vector3 temp_ret = ret;
            FCLibHelper.fc_set_value_vector3(ret_ptr, ref temp_ret);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int TransformPoint1_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            float arg0 = FCLibHelper.fc_get_float(L,0);
            float arg1 = FCLibHelper.fc_get_float(L,1);
            float arg2 = FCLibHelper.fc_get_float(L,2);
            Vector3 ret = obj.TransformPoint(arg0,arg1,arg2);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            Vector3 temp_ret = ret;
            FCLibHelper.fc_set_value_vector3(ret_ptr, ref temp_ret);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int InverseTransformPoint_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            Vector3 arg0 = new Vector3();
            FCLibHelper.fc_get_vector3(L,0,ref arg0);
            Vector3 ret = obj.InverseTransformPoint(arg0);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            Vector3 temp_ret = ret;
            FCLibHelper.fc_set_value_vector3(ret_ptr, ref temp_ret);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int InverseTransformPoint1_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            float arg0 = FCLibHelper.fc_get_float(L,0);
            float arg1 = FCLibHelper.fc_get_float(L,1);
            float arg2 = FCLibHelper.fc_get_float(L,2);
            Vector3 ret = obj.InverseTransformPoint(arg0,arg1,arg2);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            Vector3 temp_ret = ret;
            FCLibHelper.fc_set_value_vector3(ret_ptr, ref temp_ret);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int DetachChildren_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            obj.DetachChildren();
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int SetAsFirstSibling_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            obj.SetAsFirstSibling();
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int SetAsLastSibling_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            obj.SetAsLastSibling();
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int SetSiblingIndex_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            int arg0 = FCLibHelper.fc_get_int(L,0);
            obj.SetSiblingIndex(arg0);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int GetSiblingIndex_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            int ret = obj.GetSiblingIndex();
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            FCLibHelper.fc_set_value_int(ret_ptr, ret);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int Find_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            string arg0 = FCLibHelper.fc_get_string_a(L,0);
            UnityEngine.Transform ret = obj.Find(arg0);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long v = FCGetObj.PushObj(ret);
            FCLibHelper.fc_set_value_wrap_objptr(VM, ret_ptr, v);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int IsChildOf_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            UnityEngine.Transform arg0 = FCGetObj.GetObj<UnityEngine.Transform>(FCLibHelper.fc_get_wrap_objptr(L,0));
            bool ret = obj.IsChildOf(arg0);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            FCLibHelper.fc_set_value_bool(ret_ptr, ret);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int GetEnumerator_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            System.Collections.IEnumerator ret = obj.GetEnumerator();
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long v = FCGetObj.PushObj(ret);
            FCLibHelper.fc_set_value_wrap_objptr(VM, ret_ptr, v);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int GetChild_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Transform obj = get_obj(nThisPtr);
            int arg0 = FCLibHelper.fc_get_int(L,0);
            UnityEngine.Transform ret = obj.GetChild(arg0);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long v = FCGetObj.PushObj(ret);
            FCLibHelper.fc_set_value_wrap_objptr(VM, ret_ptr, v);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

}
