using UnityEngine;
using System.Collections;

public static class RootObjectExtensionMethod
{
    public static Transform GetRootObject(this Transform trans)
    {
        Transform current = trans.parent;

        while (current != null)
        {
            if (current.GetComponent<RootObject>() != null)
            {
                return current;
            }
        }

        return null;
    }
}
