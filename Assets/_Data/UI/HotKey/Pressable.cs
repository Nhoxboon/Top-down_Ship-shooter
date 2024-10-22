using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pressable : NhoxMonoBehaviour
{
    public virtual void Press()
    {
        Debug.Log("Press " + transform.parent.parent.name);
    }
}
