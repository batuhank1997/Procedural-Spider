using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace BKLib
{
	public static class GameObjectExt
	{

        public static T GetOrAddComponent<T>(this GameObject go) where T : MonoBehaviour
        {
            var component = go.GetComponent<T>();
            if (component == null) go.AddComponent<T>();
            return component;
        }

        public static bool HasComponent<T>(this GameObject gameObject) where T : MonoBehaviour
        {
            return gameObject.GetComponent<T>() != null;
        }

        public static void Trigger(this GameObject go, UnityEvent evt)
        {
            if (evt != null)
            {
                evt.Invoke();
            }
            else
            {
                Debug.LogWarning("Tried to invoke a null UnityEvent");
            }
        }

        /// <summary>
        /// Safely invoke a UnityEvent
        /// </summary>
        /// <typeparam name="T">The type of the UnityEvent</typeparam>
        /// <param name="go"></param>
        /// <param name="evt">The event</param>
        /// <param name="data">The payload for the event</param>
        public static void Trigger<T>(this GameObject go, UnityEvent<T> evt, T data)
        {
            if (evt != null)
            {
                evt.Invoke(data);
            }
            else
            {
                Debug.LogWarning("Tried to invoke a null UnityEvent on " + go.name + " with type '" + typeof(T).ToString() + "' with the follwing payload: " + data.ToString());
            }
        }

        /// <summary>
        /// Get a component, log an error if it's not there
        /// </summary>
        /// <typeparam name="T">The type of component to get</typeparam>
        /// <param name="go"></param>
        /// <returns>The component, if found</returns>
        public static T GetComponentRequired<T>(this GameObject go) where T : Component
        {
            T component = go.GetComponent<T>();

            if (component == null) Debug.LogError("Could not find " + typeof(T) + " on " + go.name);

            return component;
        }


        /// <summary>
        /// Take an action only if a component exists, error if it's not there
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="go"></param>
        /// <param name="callback"></param>
        /// <returns>The component, if found</returns>
        public static T GetComponentRequired<T>(this GameObject go, System.Action<T> callback) where T : Component
        {
            var component = go.GetComponentRequired<T>();

            if (component != null)
            {
                callback.Invoke(component);
            }

            return component;
        }

    }
}

