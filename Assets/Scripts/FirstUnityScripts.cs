using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstUnityScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        short s = 0;
        int i = 0;
        long l = 0;
        float f = 0;
        double d = 0;

        object o = d;
        double d2 = (double)o;

        i = (int)l;
        l = i;

        ushort a = 15050; //0011101011001010
        byte v = (byte)a; //11001010

        TestFunc(ref i);

        var aTest = 0;

        if (o!= null)
        {
            int i2 = (int)o;
        }

        int[] array = new int[10000];

        List<int> list = new List<int>(80);
    }
    
    public void Exp()
    {
        int i = 0;
        object o = i;
        int j = (int)o;
    }
    
    public void TestFunc (ref int i)
    {
        i = 10;
        Debug.Log(i);
    }

}
