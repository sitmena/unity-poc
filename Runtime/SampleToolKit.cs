using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;


namespace Tamatem.Tools{
    public class SampleToolKit : MonoBehaviour {
        #if UNITY_IOS
                [DllImport ("__Internal")]
                private static extern void NativeiOSCode_runNativeCode();

                [DllImport ("__Internal")]
                private static extern bool NativeiOSCode_isTriangleWithThreeCorners();
        #endif

        public void runNativeCode()
        {
        #if UNITY_IOS
            NativeiOSCode_runNativeCode();
            Debug.Log("iOS Device");
        #else
            Debug.Log("NOT iOS Device");
        #endif

        }
       public void OnButtonPress(){
        runNativeCode();
        Debug.Log("Hiiiiiiiiii");
       }

}
}
