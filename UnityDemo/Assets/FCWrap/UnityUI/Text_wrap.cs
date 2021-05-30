using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityObject = UnityEngine.Object;
using UnityEngine.UI;

public class Text_wrap
{
    public static UnityEngine.UI.Text get_obj(long L)
    {
        return FCGetObj.GetObj<UnityEngine.UI.Text>(L);
    }

    public static void Register(long VM)
    {
        int nClassName = FCLibHelper.fc_get_inport_class_id(VM, "Text");
        FCLibHelper.fc_register_class_del(VM, nClassName,obj_del);
        FCLibHelper.fc_register_class_release_ref(VM, nClassName,obj_release);
        FCLibHelper.fc_register_class_hash(VM, nClassName,obj_hash);
        FCLibHelper.fc_register_class_equal(VM, nClassName,obj_equal);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"cachedTextGenerator",get_cachedTextGenerator_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"cachedTextGeneratorForLayout",get_cachedTextGeneratorForLayout_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"mainTexture",get_mainTexture_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"font",get_font_wrap,set_font_wrap);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"text",get_text_wrap,set_text_wrap);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"supportRichText",get_supportRichText_wrap,set_supportRichText_wrap);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"resizeTextForBestFit",get_resizeTextForBestFit_wrap,set_resizeTextForBestFit_wrap);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"resizeTextMinSize",get_resizeTextMinSize_wrap,set_resizeTextMinSize_wrap);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"resizeTextMaxSize",get_resizeTextMaxSize_wrap,set_resizeTextMaxSize_wrap);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"alignment",get_alignment_wrap,set_alignment_wrap);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"alignByGeometry",get_alignByGeometry_wrap,set_alignByGeometry_wrap);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"fontSize",get_fontSize_wrap,set_fontSize_wrap);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"horizontalOverflow",get_horizontalOverflow_wrap,set_horizontalOverflow_wrap);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"verticalOverflow",get_verticalOverflow_wrap,set_verticalOverflow_wrap);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"lineSpacing",get_lineSpacing_wrap,set_lineSpacing_wrap);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"fontStyle",get_fontStyle_wrap,set_fontStyle_wrap);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"pixelsPerUnit",get_pixelsPerUnit_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"minWidth",get_minWidth_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"preferredWidth",get_preferredWidth_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"flexibleWidth",get_flexibleWidth_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"minHeight",get_minHeight_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"preferredHeight",get_preferredHeight_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"flexibleHeight",get_flexibleHeight_wrap,null);
        FCLibHelper.fc_register_class_attrib(VM, nClassName,"layoutPriority",get_layoutPriority_wrap,null);
        FCLibHelper.fc_register_class_func(VM, nClassName,"FontTextureChanged",FontTextureChanged_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"GetGenerationSettings",GetGenerationSettings_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"GetTextAnchorPivot",GetTextAnchorPivot_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"CalculateLayoutInputHorizontal",CalculateLayoutInputHorizontal_wrap);
        FCLibHelper.fc_register_class_func(VM, nClassName,"CalculateLayoutInputVertical",CalculateLayoutInputVertical_wrap);
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
        UnityEngine.UI.Text obj = FCGetObj.GetObj<UnityEngine.UI.Text>(nIntPtr);
        if(obj != null)
        {
            return obj.GetHashCode();
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_equal))]
    public static bool  obj_equal(long L, long R)
    {
        UnityEngine.UI.Text left  = FCGetObj.GetObj<UnityEngine.UI.Text>(L);
        UnityEngine.UI.Text right = FCGetObj.GetObj<UnityEngine.UI.Text>(R);
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
    public static int get_cachedTextGenerator_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long v = FCGetObj.PushObj(ret.cachedTextGenerator);
            FCLibHelper.fc_set_value_wrap_objptr(VM, ret_ptr, v);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_cachedTextGeneratorForLayout_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long v = FCGetObj.PushObj(ret.cachedTextGeneratorForLayout);
            FCLibHelper.fc_set_value_wrap_objptr(VM, ret_ptr, v);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_mainTexture_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long v = FCGetObj.PushObj(ret.mainTexture);
            FCLibHelper.fc_set_value_wrap_objptr(VM, ret_ptr, v);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_font_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long v = FCGetObj.PushObj(ret.font);
            FCLibHelper.fc_set_value_wrap_objptr(VM, ret_ptr, v);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_font_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            UnityEngine.Font arg0 = FCGetObj.GetObj<UnityEngine.Font>(FCLibHelper.fc_get_wrap_objptr(L,0));
            ret.font = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_text_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_string_a(ret_ptr, ret.text);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_text_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            string arg0 = FCLibHelper.fc_get_string_a(L,0);
            ret.text = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_supportRichText_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_bool(ret_ptr, ret.supportRichText);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_supportRichText_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            bool arg0 = FCLibHelper.fc_get_bool(L,0);
            ret.supportRichText = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_resizeTextForBestFit_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_bool(ret_ptr, ret.resizeTextForBestFit);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_resizeTextForBestFit_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            bool arg0 = FCLibHelper.fc_get_bool(L,0);
            ret.resizeTextForBestFit = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_resizeTextMinSize_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_int(ret_ptr, ret.resizeTextMinSize);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_resizeTextMinSize_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            int arg0 = FCLibHelper.fc_get_int(L,0);
            ret.resizeTextMinSize = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_resizeTextMaxSize_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_int(ret_ptr, ret.resizeTextMaxSize);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_resizeTextMaxSize_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            int arg0 = FCLibHelper.fc_get_int(L,0);
            ret.resizeTextMaxSize = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_alignment_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_int(ret_ptr, (int)ret.alignment);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_alignment_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            UnityEngine.TextAnchor arg0 = (UnityEngine.TextAnchor)(FCLibHelper.fc_get_int(L,0));
            ret.alignment = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_alignByGeometry_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_bool(ret_ptr, ret.alignByGeometry);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_alignByGeometry_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            bool arg0 = FCLibHelper.fc_get_bool(L,0);
            ret.alignByGeometry = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_fontSize_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_int(ret_ptr, ret.fontSize);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_fontSize_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            int arg0 = FCLibHelper.fc_get_int(L,0);
            ret.fontSize = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_horizontalOverflow_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_int(ret_ptr, (int)ret.horizontalOverflow);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_horizontalOverflow_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            UnityEngine.HorizontalWrapMode arg0 = (UnityEngine.HorizontalWrapMode)(FCLibHelper.fc_get_int(L,0));
            ret.horizontalOverflow = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_verticalOverflow_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_int(ret_ptr, (int)ret.verticalOverflow);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_verticalOverflow_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            UnityEngine.VerticalWrapMode arg0 = (UnityEngine.VerticalWrapMode)(FCLibHelper.fc_get_int(L,0));
            ret.verticalOverflow = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_lineSpacing_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_float(ret_ptr, ret.lineSpacing);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_lineSpacing_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            float arg0 = FCLibHelper.fc_get_float(L,0);
            ret.lineSpacing = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_fontStyle_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_int(ret_ptr, (int)ret.fontStyle);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }
    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int set_fontStyle_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            UnityEngine.FontStyle arg0 = (UnityEngine.FontStyle)(FCLibHelper.fc_get_int(L,0));
            ret.fontStyle = arg0;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_pixelsPerUnit_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_float(ret_ptr, ret.pixelsPerUnit);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_minWidth_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_float(ret_ptr, ret.minWidth);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_preferredWidth_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_float(ret_ptr, ret.preferredWidth);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_flexibleWidth_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_float(ret_ptr, ret.flexibleWidth);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_minHeight_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_float(ret_ptr, ret.minHeight);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_preferredHeight_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_float(ret_ptr, ret.preferredHeight);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_flexibleHeight_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_float(ret_ptr, ret.flexibleHeight);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int get_layoutPriority_wrap(long L)
    {
        try
        {
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text ret = get_obj(nThisPtr);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            FCLibHelper.fc_set_value_int(ret_ptr, ret.layoutPriority);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int FontTextureChanged_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text obj = get_obj(nThisPtr);
            obj.FontTextureChanged();
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int GetGenerationSettings_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text obj = get_obj(nThisPtr);
            Vector2 arg0 = new Vector2();
            FCLibHelper.fc_get_vector2(L,0,ref arg0);
            UnityEngine.TextGenerationSettings ret = obj.GetGenerationSettings(arg0);
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
    public static int GetTextAnchorPivot_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            UnityEngine.TextAnchor arg0 = (UnityEngine.TextAnchor)(FCLibHelper.fc_get_int(L,0));
            Vector2 ret = UnityEngine.UI.Text.GetTextAnchorPivot(arg0);
            long ret_ptr = FCLibHelper.fc_get_return_ptr(L);
            Vector2 temp_ret = ret;
            FCLibHelper.fc_set_value_vector2(ret_ptr, ref temp_ret);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int CalculateLayoutInputHorizontal_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text obj = get_obj(nThisPtr);
            obj.CalculateLayoutInputHorizontal();
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

    [MonoPInvokeCallbackAttribute(typeof(FCLibHelper.fc_call_back_inport_class_func))]
    public static int CalculateLayoutInputVertical_wrap(long L)
    {
        try
        {
            long VM = FCLibHelper.fc_get_vm_ptr(L);
            long nThisPtr = FCLibHelper.fc_get_inport_obj_ptr(L);
            UnityEngine.UI.Text obj = get_obj(nThisPtr);
            obj.CalculateLayoutInputVertical();
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        return 0;
    }

}
