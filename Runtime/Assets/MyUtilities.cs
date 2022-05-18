using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace DLLTest {

    public class MyUtilities {
        #if UNITY_IOS
        [DllImport ("__Internal")]
        private static extern void NativeiOSCode_runNativeCode();
        #endif

       public void runNativeCode(){
        #if UNITY_IOS
        NativeiOSCode_runNativeCode();
        Debug.Log("iOS Device");

        #else
        Debug.Log("No iOS Device.");
        #endif
       }
    }
}