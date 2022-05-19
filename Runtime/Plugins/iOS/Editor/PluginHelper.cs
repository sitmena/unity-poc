using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class PluginHelper : MonoBehaviour
{
    [SerializeField] private Text textResult;

    [DllImport("__Internal")]
    private static extern int _addTwoNumberInIOS(int a, int b);
    DllImport("__Internal")
    private static extern string authenticate(string scheme, string redirectURI);

    public void authenticate()
    {
        string token = authenticate("game1","game1://oauth-callback");
        textResult.text = token;
    }
    public void AddTwoNumber()
    {
        int result = _addTwoNumberInIOS(10, 5);
        textResult.text = "10 + 5  is : " + result;
    }
}
