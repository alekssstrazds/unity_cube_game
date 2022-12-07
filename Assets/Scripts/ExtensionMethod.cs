using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtensionMethod
{
    public static List<Transform> GetChildren(this GameObject gameobject, bool resursive) {
        List<Transform> children = new List<Transform>();

        foreach(Transform child in gameobject.transform) {
            children.Add(child);
            if(resursive) {
                children.AddRange(GetChildren(child.gameObject, true));
            }
        }
        return children;
    }
    public static Dictionary<Transform, dynamic> GetChildrenHierarchy(this GameObject gameobject) {
        Dictionary<Transform, dynamic> children = new Dictionary<Transform, dynamic>();

        foreach(Transform child in gameobject.transform) {
            children.Add(child, GetChildrenHierarchy(child.gameObject));
        }
        return children;
    }
}
