using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Update her frame çaðrýlýr
    void Update()
    {
        Debug.Log(Singleton.Instance.GetText());
    }
}
