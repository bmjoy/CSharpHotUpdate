using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityObject = UnityEngine.Object;
using UnityEngine.UI;

public class Component_wrap
{
    public static UnityEngine.Component get_obj(long L)
    {
        return FCGetObj.GetObj<UnityEngine.Component>(L);
    }

    public static void Register(long VM)
    {
        int nClassName = FCLibHelper.fc_get_inport_class_id(VM, "Component");
        FCLibHelper.fc_register_class_new(VM, nClassName, obj_new);
        FCLibHelper.fc_register_class_del(VM, nClassName,obj_del);
        FCLibHelper.fc_register_class_release_ref(VM, nClassName,obj_release);
        FCLibHelper.fc_register_class_hash(VM, nClassName,obj_hash);
        FCLibHelper.fc_register_class_equal(VM, nClassName,obj_equal);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"transform",get_transform_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"gameObject",get_gameObject_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"tag",get_tag_wrap,set_tag_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"GetComponent_Type",GetComponent_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"GetComponent_T",GetComponent1_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"GetComponent_StringA",GetComponent2_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"GetComponentInChildren_Type_bool",GetComponentInChildren_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"GetComponentInChildren_Type",GetComponentInChildren1_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"GetComponentsInChildren_Type",GetComponentsInChildren_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"GetComponentsInChildren_Type_bool",GetComponentsInChildren1_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"GetComponentInParent_Type",GetComponentInParent_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"GetComponentsInParent_Type",GetComponentsInParent_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"GetComponentsInParent_Type_bool",GetComponentsInParent1_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"GetComponents_Type",GetComponents_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"GetComponents_Type_List<Component>",GetComponents1_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"CompareTag",CompareTag_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"SendMessageUpwards_StringA_Object_SendMessageOptions",SendMessageUpwards_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"SendMessageUpwards_StringA_Object",SendMessageUpwards1_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"SendMessageUpwards_StringA",SendMessageUpwards2_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"SendMessageUpwards_StringA_SendMessageOptions",SendMessageUpwards3_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"SendMessage_StringA_Object_SendMessageOptions",SendMessage_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"SendMessage_StringA_Object",SendMessage1_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"SendMessage_StringA",SendMessage2_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"SendMessage_StringA_SendMessageOptions",SendMessage3_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"BroadcastMessage_StringA_Object_SendMessageOptions",BroadcastMessage_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"BroadcastMessage_StringA_Object",BroadcastMessage1_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"BroadcastMessage_StringA",BroadcastMessage2_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"BroadcastMessage_StringA_SendMessageOptions",BroadcastMessage3_wrap);
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int  obj_new(long L)
    {
        long nPtr = FCGetObj.NewObj<UnityEngine.Component>();
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
        UnityEngine.Component obj = FCGetObj.GetObj<UnityEngine.Component>(nIntPtr);
        if(obj != null)
        {
            return obj.GetHashCode();
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_equal))]
    public static bool  obj_equal(long L, long R)
    {
        UnityEngine.Component left  = FCGetObj.GetObj<UnityEngine.Component>(L);
        UnityEngine.Component right = FCGetObj.GetObj<UnityEngine.Component>(R);
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
    public static int get_transform_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Component ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long v = FCGetObj.PushObj(ret.transform);
            FCLibHelper.fc_set_value_wrap_objptr(VM, ret_ptr, v);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_gameObject_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Component ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long v = FCGetObj.PushObj(ret.gameObject);
            FCLibHelper.fc_set_value_wrap_objptr(VM, ret_ptr, v);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_tag_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Component ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_string_a(ret_ptr, ret.tag);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_tag_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Component ret = get_obj(nThisPtr);
            string arg0 = FCLibHelper.fc_get_string_a(L,0);
            ret.tag = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int GetComponent_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Component obj = get_obj(nThisPtr);
            System.Type arg0 = FCGetObj.GetObj<System.Type>(FCLibHelper.fc_get_wrap_objptr(L,0));
            UnityEngine.Component ret = obj.GetComponent(arg0);
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
    public static int GetComponent1_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Component obj = get_obj(nThisPtr);
            string arg0 = FCLibHelper.fc_get_string_a(L, 0);
            long nRetPtr = 0;
            switch(arg0)
            {
                case "SkinnedMeshRenderer":
                {
                    SkinnedMeshRenderer ret_obj = obj.GetComponent<SkinnedMeshRenderer>();
                    nRetPtr = FCGetObj.PushObj<SkinnedMeshRenderer>(ret_obj);
                }
                break;
                case "Renderer":
                {
                    Renderer ret_obj = obj.GetComponent<Renderer>();
                    nRetPtr = FCGetObj.PushObj<Renderer>(ret_obj);
                }
                break;
                case "MeshRenderer":
                {
                    MeshRenderer ret_obj = obj.GetComponent<MeshRenderer>();
                    nRetPtr = FCGetObj.PushObj<MeshRenderer>(ret_obj);
                }
                break;
                case "Animation":
                {
                    Animation ret_obj = obj.GetComponent<Animation>();
                    nRetPtr = FCGetObj.PushObj<Animation>(ret_obj);
                }
                break;
                case "Collider":
                {
                    Collider ret_obj = obj.GetComponent<Collider>();
                    nRetPtr = FCGetObj.PushObj<Collider>(ret_obj);
                }
                break;
                case "BoxCollider":
                {
                    BoxCollider ret_obj = obj.GetComponent<BoxCollider>();
                    nRetPtr = FCGetObj.PushObj<BoxCollider>(ret_obj);
                }
                break;
                case "BoxCollider2D":
                {
                    BoxCollider2D ret_obj = obj.GetComponent<BoxCollider2D>();
                    nRetPtr = FCGetObj.PushObj<BoxCollider2D>(ret_obj);
                }
                break;
                case "MeshCollider":
                {
                    MeshCollider ret_obj = obj.GetComponent<MeshCollider>();
                    nRetPtr = FCGetObj.PushObj<MeshCollider>(ret_obj);
                }
                break;
                case "SphereCollider":
                {
                    SphereCollider ret_obj = obj.GetComponent<SphereCollider>();
                    nRetPtr = FCGetObj.PushObj<SphereCollider>(ret_obj);
                }
                break;
                case "Rigidbody":
                {
                    Rigidbody ret_obj = obj.GetComponent<Rigidbody>();
                    nRetPtr = FCGetObj.PushObj<Rigidbody>(ret_obj);
                }
                break;
                case "Camera":
                {
                    Camera ret_obj = obj.GetComponent<Camera>();
                    nRetPtr = FCGetObj.PushObj<Camera>(ret_obj);
                }
                break;
                case "AudioSource":
                {
                    AudioSource ret_obj = obj.GetComponent<AudioSource>();
                    nRetPtr = FCGetObj.PushObj<AudioSource>(ret_obj);
                }
                break;
                case "Transform":
                {
                    Transform ret_obj = obj.GetComponent<Transform>();
                    nRetPtr = FCGetObj.PushObj<Transform>(ret_obj);
                }
                break;
                case "Component":
                {
                    Component ret_obj = obj.GetComponent<Component>();
                    nRetPtr = FCGetObj.PushObj<Component>(ret_obj);
                }
                break;
                case "ParticleSystem":
                {
                    ParticleSystem ret_obj = obj.GetComponent<ParticleSystem>();
                    nRetPtr = FCGetObj.PushObj<ParticleSystem>(ret_obj);
                }
                break;
                case "Light":
                {
                    Light ret_obj = obj.GetComponent<Light>();
                    nRetPtr = FCGetObj.PushObj<Light>(ret_obj);
                }
                break;
                case "Button":
                {
                    Button ret_obj = obj.GetComponent<Button>();
                    nRetPtr = FCGetObj.PushObj<Button>(ret_obj);
                }
                break;
                case "Text":
                {
                    Text ret_obj = obj.GetComponent<Text>();
                    nRetPtr = FCGetObj.PushObj<Text>(ret_obj);
                }
                break;
                default:
                break;
            }
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            FCLibHelper.fc_set_value_wrap_objptr(VM, ret_ptr, nRetPtr);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int GetComponent2_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Component obj = get_obj(nThisPtr);
            string arg0 = FCLibHelper.fc_get_string_a(L,0);
            UnityEngine.Component ret = obj.GetComponent(arg0);
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
    public static int GetComponentInChildren_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Component obj = get_obj(nThisPtr);
            System.Type arg0 = FCGetObj.GetObj<System.Type>(FCLibHelper.fc_get_wrap_objptr(L,0));
            bool arg1 = FCLibHelper.fc_get_bool(L,1);
            UnityEngine.Component ret = obj.GetComponentInChildren(arg0,arg1);
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
    public static int GetComponentInChildren1_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Component obj = get_obj(nThisPtr);
            System.Type arg0 = FCGetObj.GetObj<System.Type>(FCLibHelper.fc_get_wrap_objptr(L,0));
            UnityEngine.Component ret = obj.GetComponentInChildren(arg0);
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
    public static int GetComponentsInChildren_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Component obj = get_obj(nThisPtr);
            System.Type arg0 = FCGetObj.GetObj<System.Type>(FCLibHelper.fc_get_wrap_objptr(L,0));
            UnityEngine.Component[] ret = obj.GetComponentsInChildren(arg0);
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
    public static int GetComponentsInChildren1_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Component obj = get_obj(nThisPtr);
            System.Type arg0 = FCGetObj.GetObj<System.Type>(FCLibHelper.fc_get_wrap_objptr(L,0));
            bool arg1 = FCLibHelper.fc_get_bool(L,1);
            UnityEngine.Component[] ret = obj.GetComponentsInChildren(arg0,arg1);
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
    public static int GetComponentInParent_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Component obj = get_obj(nThisPtr);
            System.Type arg0 = FCGetObj.GetObj<System.Type>(FCLibHelper.fc_get_wrap_objptr(L,0));
            UnityEngine.Component ret = obj.GetComponentInParent(arg0);
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
    public static int GetComponentsInParent_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Component obj = get_obj(nThisPtr);
            System.Type arg0 = FCGetObj.GetObj<System.Type>(FCLibHelper.fc_get_wrap_objptr(L,0));
            UnityEngine.Component[] ret = obj.GetComponentsInParent(arg0);
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
    public static int GetComponentsInParent1_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Component obj = get_obj(nThisPtr);
            System.Type arg0 = FCGetObj.GetObj<System.Type>(FCLibHelper.fc_get_wrap_objptr(L,0));
            bool arg1 = FCLibHelper.fc_get_bool(L,1);
            UnityEngine.Component[] ret = obj.GetComponentsInParent(arg0,arg1);
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
    public static int GetComponents_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Component obj = get_obj(nThisPtr);
            System.Type arg0 = FCGetObj.GetObj<System.Type>(FCLibHelper.fc_get_wrap_objptr(L,0));
            UnityEngine.Component[] ret = obj.GetComponents(arg0);
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
    public static int GetComponents1_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Component obj = get_obj(nThisPtr);
            System.Type arg0 = FCGetObj.GetObj<System.Type>(FCLibHelper.fc_get_wrap_objptr(L,0));
            List<UnityEngine.Component> arg1 = null;
            arg1 = FCCustomParam.GetList(ref arg1,L,1);
            obj.GetComponents(arg0,arg1);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int CompareTag_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Component obj = get_obj(nThisPtr);
            string arg0 = FCLibHelper.fc_get_string_a(L,0);
            bool ret = obj.CompareTag(arg0);
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
    public static int SendMessageUpwards_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Component obj = get_obj(nThisPtr);
            string arg0 = FCLibHelper.fc_get_string_a(L,0);
            System.Object arg1 = FCGetObj.GetSystemObj(VM, FCLibHelper.fc_get_param_ptr(L,1));
            UnityEngine.SendMessageOptions arg2 = (UnityEngine.SendMessageOptions)(FCLibHelper.fc_get_int(L,2));
            obj.SendMessageUpwards(arg0,arg1,arg2);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int SendMessageUpwards1_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Component obj = get_obj(nThisPtr);
            string arg0 = FCLibHelper.fc_get_string_a(L,0);
            System.Object arg1 = FCGetObj.GetSystemObj(VM, FCLibHelper.fc_get_param_ptr(L,1));
            obj.SendMessageUpwards(arg0,arg1);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int SendMessageUpwards2_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Component obj = get_obj(nThisPtr);
            string arg0 = FCLibHelper.fc_get_string_a(L,0);
            obj.SendMessageUpwards(arg0);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int SendMessageUpwards3_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Component obj = get_obj(nThisPtr);
            string arg0 = FCLibHelper.fc_get_string_a(L,0);
            UnityEngine.SendMessageOptions arg1 = (UnityEngine.SendMessageOptions)(FCLibHelper.fc_get_int(L,1));
            obj.SendMessageUpwards(arg0,arg1);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int SendMessage_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Component obj = get_obj(nThisPtr);
            string arg0 = FCLibHelper.fc_get_string_a(L,0);
            System.Object arg1 = FCGetObj.GetSystemObj(VM, FCLibHelper.fc_get_param_ptr(L,1));
            UnityEngine.SendMessageOptions arg2 = (UnityEngine.SendMessageOptions)(FCLibHelper.fc_get_int(L,2));
            obj.SendMessage(arg0,arg1,arg2);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int SendMessage1_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Component obj = get_obj(nThisPtr);
            string arg0 = FCLibHelper.fc_get_string_a(L,0);
            System.Object arg1 = FCGetObj.GetSystemObj(VM, FCLibHelper.fc_get_param_ptr(L,1));
            obj.SendMessage(arg0,arg1);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int SendMessage2_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Component obj = get_obj(nThisPtr);
            string arg0 = FCLibHelper.fc_get_string_a(L,0);
            obj.SendMessage(arg0);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int SendMessage3_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Component obj = get_obj(nThisPtr);
            string arg0 = FCLibHelper.fc_get_string_a(L,0);
            UnityEngine.SendMessageOptions arg1 = (UnityEngine.SendMessageOptions)(FCLibHelper.fc_get_int(L,1));
            obj.SendMessage(arg0,arg1);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int BroadcastMessage_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Component obj = get_obj(nThisPtr);
            string arg0 = FCLibHelper.fc_get_string_a(L,0);
            System.Object arg1 = FCGetObj.GetSystemObj(VM, FCLibHelper.fc_get_param_ptr(L,1));
            UnityEngine.SendMessageOptions arg2 = (UnityEngine.SendMessageOptions)(FCLibHelper.fc_get_int(L,2));
            obj.BroadcastMessage(arg0,arg1,arg2);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int BroadcastMessage1_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Component obj = get_obj(nThisPtr);
            string arg0 = FCLibHelper.fc_get_string_a(L,0);
            System.Object arg1 = FCGetObj.GetSystemObj(VM, FCLibHelper.fc_get_param_ptr(L,1));
            obj.BroadcastMessage(arg0,arg1);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int BroadcastMessage2_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Component obj = get_obj(nThisPtr);
            string arg0 = FCLibHelper.fc_get_string_a(L,0);
            obj.BroadcastMessage(arg0);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int BroadcastMessage3_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.Component obj = get_obj(nThisPtr);
            string arg0 = FCLibHelper.fc_get_string_a(L,0);
            UnityEngine.SendMessageOptions arg1 = (UnityEngine.SendMessageOptions)(FCLibHelper.fc_get_int(L,1));
            obj.BroadcastMessage(arg0,arg1);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

}
