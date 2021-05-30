using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityObject = UnityEngine.Object;

public class Input_wrap
{
    public static UnityEngine.Input get_obj(long L)
    {
        return FCGetObj.GetObj<UnityEngine.Input>(L);
    }

    public static void Register(long VM)
    {
        int nClassName = FCLibHelper.fc_get_inport_class_id(VM, "Input");
        FCLibHelper.fc_register_class_new(VM, nClassName, obj_new);
        FCLibHelper.fc_register_class_del(VM, nClassName,obj_del);
        FCLibHelper.fc_register_class_release_ref(VM, nClassName,obj_release);
        FCLibHelper.fc_register_class_hash(VM, nClassName,obj_hash);
        FCLibHelper.fc_register_class_equal(VM, nClassName,obj_equal);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"compensateSensors",get_compensateSensors_wrap,set_compensateSensors_wrap);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"gyro",get_gyro_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"mousePosition",get_mousePosition_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"mouseScrollDelta",get_mouseScrollDelta_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"mousePresent",get_mousePresent_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"simulateMouseWithTouches",get_simulateMouseWithTouches_wrap,set_simulateMouseWithTouches_wrap);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"anyKey",get_anyKey_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"anyKeyDown",get_anyKeyDown_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"inputString",get_inputString_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"acceleration",get_acceleration_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"accelerationEvents",get_accelerationEvents_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"accelerationEventCount",get_accelerationEventCount_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"touches",get_touches_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"touchCount",get_touchCount_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"touchPressureSupported",get_touchPressureSupported_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"stylusTouchSupported",get_stylusTouchSupported_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"touchSupported",get_touchSupported_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"multiTouchEnabled",get_multiTouchEnabled_wrap,set_multiTouchEnabled_wrap);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"location",get_location_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"compass",get_compass_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"deviceOrientation",get_deviceOrientation_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"imeCompositionMode",get_imeCompositionMode_wrap,set_imeCompositionMode_wrap);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"compositionString",get_compositionString_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"imeIsSelected",get_imeIsSelected_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"compositionCursorPos",get_compositionCursorPos_wrap,set_compositionCursorPos_wrap);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"backButtonLeavesApp",get_backButtonLeavesApp_wrap,set_backButtonLeavesApp_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"GetAxis",GetAxis_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"GetAxisRaw",GetAxisRaw_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"GetButton",GetButton_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"GetButtonDown",GetButtonDown_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"GetButtonUp",GetButtonUp_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"GetKey_StringA",GetKey_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"GetKey_KeyCode",GetKey1_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"GetKeyDown_StringA",GetKeyDown_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"GetKeyDown_KeyCode",GetKeyDown1_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"GetKeyUp_StringA",GetKeyUp_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"GetKeyUp_KeyCode",GetKeyUp1_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"GetJoystickNames",GetJoystickNames_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"GetMouseButton",GetMouseButton_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"GetMouseButtonDown",GetMouseButtonDown_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"GetMouseButtonUp",GetMouseButtonUp_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"ResetInputAxes",ResetInputAxes_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"GetAccelerationEvent",GetAccelerationEvent_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"GetTouch",GetTouch_wrap);
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int  obj_new(long L)
    {
        long nPtr = FCGetObj.NewObj<UnityEngine.Input>();
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
        UnityEngine.Input obj = FCGetObj.GetObj<UnityEngine.Input>(nIntPtr);
        if(obj != null)
        {
            return obj.GetHashCode();
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_equal))]
    public static bool  obj_equal(long L, long R)
    {
        UnityEngine.Input left  = FCGetObj.GetObj<UnityEngine.Input>(L);
        UnityEngine.Input right = FCGetObj.GetObj<UnityEngine.Input>(R);
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
    public static int get_compensateSensors_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_bool(ret_ptr, UnityEngine.Input.compensateSensors);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_compensateSensors_wrap(long L)
    {
        try
        {
            bool arg0 = FCLibHelper.fc_get_bool(L,0);
            UnityEngine.Input.compensateSensors = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_gyro_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long v = FCGetObj.PushObj(UnityEngine.Input.gyro);
            FCLibHelper.fc_set_value_wrap_objptr(VM, ret_ptr, v);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_mousePosition_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            Vector3 temp_ret = UnityEngine.Input.mousePosition;
            FCLibHelper.fc_set_value_vector3(ret_ptr, ref temp_ret);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_mouseScrollDelta_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            Vector2 temp_ret = UnityEngine.Input.mouseScrollDelta;
            FCLibHelper.fc_set_value_vector2(ret_ptr, ref temp_ret);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_mousePresent_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_bool(ret_ptr, UnityEngine.Input.mousePresent);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_simulateMouseWithTouches_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_bool(ret_ptr, UnityEngine.Input.simulateMouseWithTouches);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_simulateMouseWithTouches_wrap(long L)
    {
        try
        {
            bool arg0 = FCLibHelper.fc_get_bool(L,0);
            UnityEngine.Input.simulateMouseWithTouches = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_anyKey_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_bool(ret_ptr, UnityEngine.Input.anyKey);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_anyKeyDown_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_bool(ret_ptr, UnityEngine.Input.anyKeyDown);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_inputString_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_string_a(ret_ptr, UnityEngine.Input.inputString);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_acceleration_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            Vector3 temp_ret = UnityEngine.Input.acceleration;
            FCLibHelper.fc_set_value_vector3(ret_ptr, ref temp_ret);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_accelerationEvents_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCCustomParam.ReturnArray(VM, UnityEngine.Input.accelerationEvents,ret_ptr);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_accelerationEventCount_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_int(ret_ptr, UnityEngine.Input.accelerationEventCount);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_touches_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCCustomParam.ReturnArray(VM, UnityEngine.Input.touches,ret_ptr);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_touchCount_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_int(ret_ptr, UnityEngine.Input.touchCount);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_touchPressureSupported_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_bool(ret_ptr, UnityEngine.Input.touchPressureSupported);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_stylusTouchSupported_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_bool(ret_ptr, UnityEngine.Input.stylusTouchSupported);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_touchSupported_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_bool(ret_ptr, UnityEngine.Input.touchSupported);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_multiTouchEnabled_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_bool(ret_ptr, UnityEngine.Input.multiTouchEnabled);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_multiTouchEnabled_wrap(long L)
    {
        try
        {
            bool arg0 = FCLibHelper.fc_get_bool(L,0);
            UnityEngine.Input.multiTouchEnabled = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_location_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long v = FCGetObj.PushObj(UnityEngine.Input.location);
            FCLibHelper.fc_set_value_wrap_objptr(VM, ret_ptr, v);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_compass_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long v = FCGetObj.PushObj(UnityEngine.Input.compass);
            FCLibHelper.fc_set_value_wrap_objptr(VM, ret_ptr, v);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_deviceOrientation_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_int(ret_ptr, (int)UnityEngine.Input.deviceOrientation);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_imeCompositionMode_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_int(ret_ptr, (int)UnityEngine.Input.imeCompositionMode);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_imeCompositionMode_wrap(long L)
    {
        try
        {
            UnityEngine.IMECompositionMode arg0 = (UnityEngine.IMECompositionMode)(FCLibHelper.fc_get_int(L,0));
            UnityEngine.Input.imeCompositionMode = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_compositionString_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_string_a(ret_ptr, UnityEngine.Input.compositionString);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_imeIsSelected_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_bool(ret_ptr, UnityEngine.Input.imeIsSelected);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_compositionCursorPos_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            Vector2 temp_ret = UnityEngine.Input.compositionCursorPos;
            FCLibHelper.fc_set_value_vector2(ret_ptr, ref temp_ret);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_compositionCursorPos_wrap(long L)
    {
        try
        {
            Vector2 arg0 = new Vector2();
            FCLibHelper.fc_get_vector2(L,0,ref arg0);
            UnityEngine.Input.compositionCursorPos = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_backButtonLeavesApp_wrap(long L)
    {
        try
        {
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_bool(ret_ptr, UnityEngine.Input.backButtonLeavesApp);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_backButtonLeavesApp_wrap(long L)
    {
        try
        {
            bool arg0 = FCLibHelper.fc_get_bool(L,0);
            UnityEngine.Input.backButtonLeavesApp = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int GetAxis_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            string arg0 = FCLibHelper.fc_get_string_a(L,0);
            float ret = UnityEngine.Input.GetAxis(arg0);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            FCLibHelper.fc_set_value_float(ret_ptr, ret);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int GetAxisRaw_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            string arg0 = FCLibHelper.fc_get_string_a(L,0);
            float ret = UnityEngine.Input.GetAxisRaw(arg0);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            FCLibHelper.fc_set_value_float(ret_ptr, ret);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int GetButton_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            string arg0 = FCLibHelper.fc_get_string_a(L,0);
            bool ret = UnityEngine.Input.GetButton(arg0);
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
    public static int GetButtonDown_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            string arg0 = FCLibHelper.fc_get_string_a(L,0);
            bool ret = UnityEngine.Input.GetButtonDown(arg0);
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
    public static int GetButtonUp_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            string arg0 = FCLibHelper.fc_get_string_a(L,0);
            bool ret = UnityEngine.Input.GetButtonUp(arg0);
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
    public static int GetKey_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            string arg0 = FCLibHelper.fc_get_string_a(L,0);
            bool ret = UnityEngine.Input.GetKey(arg0);
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
    public static int GetKey1_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            UnityEngine.KeyCode arg0 = (UnityEngine.KeyCode)(FCLibHelper.fc_get_int(L,0));
            bool ret = UnityEngine.Input.GetKey(arg0);
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
    public static int GetKeyDown_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            string arg0 = FCLibHelper.fc_get_string_a(L,0);
            bool ret = UnityEngine.Input.GetKeyDown(arg0);
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
    public static int GetKeyDown1_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            UnityEngine.KeyCode arg0 = (UnityEngine.KeyCode)(FCLibHelper.fc_get_int(L,0));
            bool ret = UnityEngine.Input.GetKeyDown(arg0);
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
    public static int GetKeyUp_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            string arg0 = FCLibHelper.fc_get_string_a(L,0);
            bool ret = UnityEngine.Input.GetKeyUp(arg0);
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
    public static int GetKeyUp1_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            UnityEngine.KeyCode arg0 = (UnityEngine.KeyCode)(FCLibHelper.fc_get_int(L,0));
            bool ret = UnityEngine.Input.GetKeyUp(arg0);
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
    public static int GetJoystickNames_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            string[] ret = UnityEngine.Input.GetJoystickNames();
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            FCCustomParam.ReturnArray(VM, ret,ret_ptr);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int GetMouseButton_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            int arg0 = FCLibHelper.fc_get_int(L,0);
            bool ret = UnityEngine.Input.GetMouseButton(arg0);
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
    public static int GetMouseButtonDown_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            int arg0 = FCLibHelper.fc_get_int(L,0);
            bool ret = UnityEngine.Input.GetMouseButtonDown(arg0);
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
    public static int GetMouseButtonUp_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            int arg0 = FCLibHelper.fc_get_int(L,0);
            bool ret = UnityEngine.Input.GetMouseButtonUp(arg0);
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
    public static int ResetInputAxes_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            UnityEngine.Input.ResetInputAxes();
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int GetAccelerationEvent_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            int arg0 = FCLibHelper.fc_get_int(L,0);
            UnityEngine.AccelerationEvent ret = UnityEngine.Input.GetAccelerationEvent(arg0);
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
    public static int GetTouch_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            int arg0 = FCLibHelper.fc_get_int(L,0);
            UnityEngine.Touch ret = UnityEngine.Input.GetTouch(arg0);
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
