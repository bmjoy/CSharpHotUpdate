﻿using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 所有委托对象的基类
class FCDelegateBase
{
    public long m_VMPtr;    // 虚拟机的地址
    public long m_nThisPtr; // this指针
    public int m_nClassName;
    public int m_nFuncName;
    public string m_szFuncName; // 脚本函数名
}

// 委托管理器，管理运行时的委托对象
class FCDelegateMng
{
    struct FCDelegateKey
    {
        public long nVMPtr;
        public long nThisPtr;
        public int nClassName;
        public int nFuncName;
    }
    Dictionary<FCDelegateKey, FCDelegateBase> m_Delegates = new Dictionary<FCDelegateKey, FCDelegateBase>();
    Dictionary<System.Object, FCDelegateBase> m_Record = new Dictionary<object, FCDelegateBase>();

    static FCDelegateMng s_pIns;
    public static FCDelegateMng  Instance
    {
        get
        {
            if(s_pIns == null)
            {
                s_pIns = new FCDelegateMng();
            }
            return s_pIns;
        }
    }
    public void OnReloadScript()
    {
        m_Delegates.Clear();
        m_Record.Clear();
    }

    // 功能：根据脚本所传的参数，动态获取或创建一个关联的委托对象
    public T  GetDelegate<T>(long L, int nIndex = 0) where T : FCDelegateBase, new()
    {
        long pDelegatePtr = FCLibHelper.fc_get_param_ptr(L, nIndex); // 得到脚本委托参数（临时的，不可保留)
        long VM = FCLibHelper.fc_get_vm_ptr(L);
        long nObjPtr = FCLibHelper.fc_inport_delegate_get_obj_ptr(VM, pDelegatePtr); // 得到脚本对象地址
        int nClassNameID = FCLibHelper.fc_inport_delegate_get_class_name_id(VM, pDelegatePtr);  // 类名
        int nFuncNameID = FCLibHelper.fc_inport_delegate_get_func_name_id(VM, pDelegatePtr); // 函数名
        if (0 == nObjPtr && 0 == nClassNameID && 0 == nFuncNameID)
            return default(T); // 返回空指针

        FCDelegateKey key = new FCDelegateKey();
        key.nVMPtr = VM;
        key.nThisPtr = nObjPtr;
        key.nClassName = nClassNameID;
        key.nFuncName = nFuncNameID;

        // -- 这个地方有必要加锁，如果不加锁的话，多线程执行脚本，并在脚本中使用委托，就会导致这里线程冲突
        if(VM != FCDll.GetMainVMPtr())
        {
            Debug.LogError("请注意多线程冲突的问题, 不可以在多线程中使用委托");
        }

        FCDelegateBase obj = null;
        if(m_Delegates.TryGetValue(key, out obj))
        {
            if(key.nVMPtr != VM)
            {
                Debug.LogError("多线程冲突, 记录有误，请检查对应的委托用法");
            }
            return (T)obj;
        }
        T pObj = new T();
        pObj.m_VMPtr = VM;
        pObj.m_nThisPtr = nObjPtr;
        pObj.m_szFuncName = GetDelegateFuncName(VM, pDelegatePtr);
        pObj.m_nClassName = nClassNameID;
        pObj.m_nFuncName = nFuncNameID;
        m_Delegates[key] = pObj;
        return pObj;
    }

    // 功能：记录一个委托对象，自动删除前面关联的那个
    public void  RecordDelegate(System.Object pDelegateFunc, FCDelegateBase pObj)
    {
        if (pDelegateFunc == null)
            return;
        if(pObj == null)
        {
            FCDelegateBase pOld = null;
            if (m_Record.TryGetValue(pDelegateFunc, out pOld))
            {
                FCDelegateKey key = new FCDelegateKey();
                key.nVMPtr = pOld.m_VMPtr;
                key.nThisPtr = pOld.m_nThisPtr;
                key.nClassName = pOld.m_nClassName;
                key.nFuncName = pOld.m_nFuncName;
                m_Delegates.Remove(key);
            }
            m_Record.Remove(pDelegateFunc);
        }
        else
        {
            m_Record[pDelegateFunc] = pObj;
        }
    }
    
    static string  GetDelegateFuncName(long VM, long pDelegatePtr)
    {
        int nNamelen = FCLibHelper.fc_inport_delegate_get_func_name_len(VM, pDelegatePtr);
        if (nNamelen <= 0)
            return string.Empty;
        byte[] buffer = new byte[nNamelen];
        FCLibHelper.fc_inport_delegate_get_func_name(VM, pDelegatePtr, buffer, nNamelen);
        string szParam = System.Text.Encoding.UTF8.GetString(buffer, 0, nNamelen);
        return szParam;
    }
}
