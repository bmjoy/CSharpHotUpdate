using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityObject = UnityEngine.Object;

public class Time_wrap
{
    public static UnityEngine.Time get_obj(long L)
    {
        return FCGetObj.GetObj<UnityEngine.Time>(L);
    }

    public static void Register(long VM)
    {
        int nClassName = FCLibHelper.fc_get_inport_class_id(VM, "Time");
        FCLibHelper.fc_register_class_new(VM, nClassName, obj_new);
        FCLibHelper.fc_register_class_del(VM, nClassName,obj_del);
        FCLibHelper.fc_register_class_release_ref(VM, nClassName,obj_release);
        FCLibHelper.fc_register_class_hash(VM, nClassName,obj_hash);
        FCLibHelper.fc_register_class_equal(VM, nClassName,obj_equal);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"time",get_time_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"timeSinceLevelLoad",get_timeSinceLevelLoad_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"deltaTime",get_deltaTime_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"fixedTime",get_fixedTime_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"unscaledTime",get_unscaledTime_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"fixedUnscaledTime",get_fixedUnscaledTime_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"unscaledDeltaTime",get_unscaledDeltaTime_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"fixedUnscaledDeltaTime",get_fixedUnscaledDeltaTime_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"fixedDeltaTime",get_fixedDeltaTime_wrap,set_fixedDeltaTime_wrap);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"maximumDeltaTime",get_maximumDeltaTime_wrap,set_maximumDeltaTime_wrap);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"smoothDeltaTime",get_smoothDeltaTime_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"maximumParticleDeltaTime",get_maximumParticleDeltaTime_wrap,set_maximumParticleDeltaTime_wrap);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"timeScale",get_timeScale_wrap,set_timeScale_wrap);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"frameCount",get_frameCount_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"renderedFrameCount",get_renderedFrameCount_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"realtimeSinceStartup",get_realtimeSinceStartup_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"captureFramerate",get_captureFramerate_wrap,set_captureFramerate_wrap);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"inFixedTimeStep",get_inFixedTimeStep_wrap,null);
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int  obj_new(long L)
    {
        long nPtr = FCGetObj.NewObj<UnityEngine.Time>();
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
        UnityEngine.Time obj = FCGetObj.GetObj<UnityEngine.Time>(nIntPtr);
        if(obj != null)
        {
            return obj.GetHashCode();
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_equal))]
    public static bool  obj_equal(long L, long R)
    {
        UnityEngine.Time left  = FCGetObj.GetObj<UnityEngine.Time>(L);
        UnityEngine.Time right = FCGetObj.GetObj<UnityEngine.Time>(R);
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
    public static int get_time_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_float(ret_ptr, UnityEngine.Time.time);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_timeSinceLevelLoad_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_float(ret_ptr, UnityEngine.Time.timeSinceLevelLoad);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_deltaTime_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_float(ret_ptr, UnityEngine.Time.deltaTime);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_fixedTime_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_float(ret_ptr, UnityEngine.Time.fixedTime);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_unscaledTime_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_float(ret_ptr, UnityEngine.Time.unscaledTime);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_fixedUnscaledTime_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_float(ret_ptr, UnityEngine.Time.fixedUnscaledTime);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_unscaledDeltaTime_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_float(ret_ptr, UnityEngine.Time.unscaledDeltaTime);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_fixedUnscaledDeltaTime_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_float(ret_ptr, UnityEngine.Time.fixedUnscaledDeltaTime);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_fixedDeltaTime_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_float(ret_ptr, UnityEngine.Time.fixedDeltaTime);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_fixedDeltaTime_wrap(long L)
    {
        try
        {
            float arg0 = FCLibHelper.fc_get_float(L,0);
            UnityEngine.Time.fixedDeltaTime = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_maximumDeltaTime_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_float(ret_ptr, UnityEngine.Time.maximumDeltaTime);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_maximumDeltaTime_wrap(long L)
    {
        try
        {
            float arg0 = FCLibHelper.fc_get_float(L,0);
            UnityEngine.Time.maximumDeltaTime = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_smoothDeltaTime_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_float(ret_ptr, UnityEngine.Time.smoothDeltaTime);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_maximumParticleDeltaTime_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_float(ret_ptr, UnityEngine.Time.maximumParticleDeltaTime);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_maximumParticleDeltaTime_wrap(long L)
    {
        try
        {
            float arg0 = FCLibHelper.fc_get_float(L,0);
            UnityEngine.Time.maximumParticleDeltaTime = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_timeScale_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_float(ret_ptr, UnityEngine.Time.timeScale);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_timeScale_wrap(long L)
    {
        try
        {
            float arg0 = FCLibHelper.fc_get_float(L,0);
            UnityEngine.Time.timeScale = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_frameCount_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_int(ret_ptr, UnityEngine.Time.frameCount);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_renderedFrameCount_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_int(ret_ptr, UnityEngine.Time.renderedFrameCount);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_realtimeSinceStartup_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_float(ret_ptr, UnityEngine.Time.realtimeSinceStartup);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_captureFramerate_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_int(ret_ptr, UnityEngine.Time.captureFramerate);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_captureFramerate_wrap(long L)
    {
        try
        {
            int arg0 = FCLibHelper.fc_get_int(L,0);
            UnityEngine.Time.captureFramerate = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_inFixedTimeStep_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_bool(ret_ptr, UnityEngine.Time.inFixedTimeStep);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

}
