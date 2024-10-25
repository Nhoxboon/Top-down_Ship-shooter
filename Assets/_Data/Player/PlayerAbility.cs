using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbility : NhoxMonoBehaviour
{
    public virtual void Active(AbilitiesCode abilitiesCode)
    {
        Debug.Log("AbilitiesCode: " + abilitiesCode.ToString());
    }
}
