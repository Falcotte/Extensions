using UnityEngine;

namespace AngryKoala.Extensions
{
    public static class GameObjectExtensions
    {
        public static T AddComponent<T>(this GameObject go, T toAdd) where T : Component
        {
            return go.AddComponent<T>().GetCopyOf(toAdd) as T;
        }
    }
}