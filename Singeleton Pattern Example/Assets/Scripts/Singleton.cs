using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    public static Singleton instance = null;
    private string text;

    public static Singleton Instance
    {
        get {
            if(instance == null)
            {
                instance = new GameObject("New Instance").AddComponent<Singleton>();

            }
            return instance;
        
        }


    }
    private void OnEnable()
    {
        instance = this;
        text = "Sa";
    }
    public string GetText()
    {
        return text;
    }



}
