using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AbilitiesCode
{
    NoAbility = 0,

    Missle = 1,
    Laze = 2,
}

public class AbilitiesParser
{
    public static AbilitiesCode FromString(string ability)
    {
        try
        {
            return (AbilitiesCode)System.Enum.Parse(typeof(AbilitiesCode), ability);
        }
        catch (ArgumentException e)
        {
            Debug.LogError(e.ToString());
            return AbilitiesCode.NoAbility;
        }
    }
}