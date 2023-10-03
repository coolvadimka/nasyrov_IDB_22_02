using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject testobj;
    public void Deactive()
    {
        testobj.SetActive(false);
    }
}
