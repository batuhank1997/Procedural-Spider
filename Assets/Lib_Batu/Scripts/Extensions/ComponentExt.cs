using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BKLib
{
    public static class ComponentExt
    {
        public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
        {
            if (gameObject.TryGetComponent(out T requestedComponent))
            {
                return requestedComponent;
            }
            return gameObject.AddComponent<T>();
        }
    }
}

