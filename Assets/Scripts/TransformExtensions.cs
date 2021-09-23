using UnityEngine;

namespace AngryKoala.Extensions
{
    public static class TransformExtensions
    {
        /// <summary>
        /// Sets x value of transform's position
        /// </summary>
        /// <param name="x">x</param>
        public static Transform SetX(this Transform transform, float x)
        {
            transform.position = new Vector3(x, transform.position.y, transform.position.z);
            return transform;
        }

        /// <summary>
        /// Sets y value of transform's position
        /// </summary>
        /// <param name="y">y</param>
        public static Transform SetY(this Transform transform, float y)
        {
            transform.position = new Vector3(transform.position.x, y, transform.position.z);
            return transform;
        }

        /// <summary>
        /// Sets z value of transform's position
        /// </summary>
        /// <param name="z">z</param>
        public static Transform SetZ(this Transform transform, float z)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, z);
            return transform;
        }

        /// <summary>
        /// Sets x and y values of transform's position
        /// </summary>
        /// <param name="x">x</param>
        /// <param name="y">y</param>
        public static Transform SetXY(this Transform transform, float x, float y)
        {
            transform.position = new Vector3(x, y, transform.position.z);
            return transform;
        }

        /// <summary>
        /// Sets x and z values of transform's position
        /// </summary>
        /// <param name="x">x</param>
        /// <param name="z">z</param>
        public static Transform SetXZ(this Transform transform, float x, float z)
        {
            transform.position = new Vector3(x, transform.position.y, z);
            return transform;
        }

        /// <summary>
        /// Sets y and z values of transform's position
        /// </summary>
        /// <param name="y">y</param>
        /// <param name="z">z</param>
        public static Transform SetYZ(this Transform transform, float y, float z)
        {
            transform.position = new Vector3(transform.position.x, y, z);
            return transform;
        }

        /// <summary>
        /// Sets x, y and z values of transform's position
        /// </summary>
        /// <param name="x">x</param>
        /// <param name="y">y</param>
        /// <param name="z">z</param>
        public static Transform SetXYZ(this Transform transform, float x, float y, float z)
        {
            transform.position = new Vector3(x, y, z);
            return transform;
        }

        /// <summary>
        /// Sets x value of transform's localPosition
        /// </summary>
        /// <param name="x">x</param>
        public static Transform SetLocalX(this Transform transform, float x)
        {
            transform.localPosition = new Vector3(x, transform.localPosition.y, transform.localPosition.z);
            return transform;
        }

        /// <summary>
        /// Sets y value of transform's localPosition
        /// </summary>
        /// <param name="y">y</param>
        public static Transform SetLocalY(this Transform transform, float y)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, y, transform.localPosition.z);
            return transform;
        }

        /// <summary>
        /// Sets z value of transform's localPosition
        /// </summary>
        /// <param name="z">z</param>
        public static Transform SetLocalZ(this Transform transform, float z)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, z);
            return transform;
        }

        /// <summary>
        /// Sets x and y values of transform's localPosition
        /// </summary>
        /// <param name="x">x</param>
        /// <param name="y">y</param>
        public static Transform SetLocalXY(this Transform transform, float x, float y)
        {
            transform.localPosition = new Vector3(x, y, transform.localPosition.z);
            return transform;
        }

        /// <summary>
        /// Sets x and z values of transform's localPosition
        /// </summary>
        /// <param name="x">x</param>
        /// <param name="z">z</param>
        public static Transform SetLocalXZ(this Transform transform, float x, float z)
        {
            transform.localPosition = new Vector3(x, transform.localPosition.y, z);
            return transform;
        }

        /// <summary>
        /// Sets y and z values of transform's localPosition
        /// </summary>
        /// <param name="y">y</param>
        /// <param name="z">z</param>
        public static Transform SetLocalYZ(this Transform transform, float y, float z)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, y, z);
            return transform;
        }

        /// <summary>
        /// Sets x, y and z values of transform's localPosition
        /// </summary>
        /// <param name="x">x</param>
        /// <param name="y">y</param>
        /// <param name="z">z</param>
        public static Transform SetLocalXYZ(this Transform transform, float x, float y, float z)
        {
            transform.localPosition = new Vector3(x, y, z);
            return transform;
        }

        /// <summary>
        /// Performs a LookAt() with transform's x direction
        /// </summary>
        public static void LookAtWithX(this Transform transform, Transform target)
        {
            transform.LookAt(target);
            transform.Rotate(Vector3.down * 90, Space.Self);
        }

        /// <summary>
        /// Performs a LookAt() with transform's x direction
        /// </summary>
        public static void LookAtWithX(this Transform transform, Vector3 target)
        {
            transform.LookAt(target);
            transform.Rotate(Vector3.down * 90, Space.Self);
        }

        /// <summary>
        /// Performs a LookAt() with transform's y direction
        /// </summary>
        public static void LookAtWithY(this Transform transform, Transform target)
        {
            transform.LookAt(target);
            transform.Rotate(Vector3.right * 90, Space.Self);
        }

        /// <summary>
        /// Performs a LookAt() with transform's y direction
        /// </summary>
        public static void LookAtWithY(this Transform transform, Vector3 target)
        {
            transform.LookAt(target);
            transform.Rotate(Vector3.right * 90, Space.Self);
        }

        /// <summary>
        /// Performs a LookAt() with a given rotation speed
        /// </summary>
        public static void LookAtGradually(this Transform transform, Transform target, float maxRadiansDelta, bool stableUpVector = false)
        {
            Vector3 targetDirection = target.position - transform.position;
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, maxRadiansDelta, 0.0f);

            transform.rotation = Quaternion.LookRotation(newDirection);
            if(stableUpVector)
            {
                transform.rotation = Quaternion.Euler(0f, transform.rotation.eulerAngles.y, 0f);
            }
        }

        /// <summary>
        /// Performs a LookAt() with a given rotation speed
        /// </summary>
        public static void LookAtGradually(this Transform transform, Vector3 target, float maxRadiansDelta, bool stableUpVector = false)
        {
            Vector3 targetDirection = target - transform.position;
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, maxRadiansDelta, 0.0f);

            transform.rotation = Quaternion.LookRotation(newDirection);
            if(stableUpVector)
            {
                transform.rotation = Quaternion.Euler(0f, transform.rotation.eulerAngles.y, 0f);
            }
        }

        /// <summary>
        /// Performs a LookAt() with transform's x direction and a given rotation speed
        /// </summary>
        public static void LookAtWithXGradually(this Transform transform, Transform target, float maxRadiansDelta)
        {
            Vector3 targetDirection = target.position - transform.position;
            Vector3 newDirection = Vector3.RotateTowards(transform.right, targetDirection, maxRadiansDelta, 0.0f);

            transform.LookAtWithX(newDirection);
        }

        /// <summary>
        /// Performs a LookAt() with transform's x direction and a given rotation speed
        /// </summary>
        public static void LookAtWithXGradually(this Transform transform, Vector3 target, float maxRadiansDelta)
        {
            Vector3 targetDirection = target - transform.position;
            Vector3 newDirection = Vector3.RotateTowards(transform.right, targetDirection, maxRadiansDelta, 0.0f);

            transform.LookAtWithX(newDirection);
        }

        /// <summary>
        /// Performs a LookAt() with transform's y direction and a given rotation speed
        /// </summary>
        public static void LookAtWithYGradually(this Transform transform, Transform target, float maxRadiansDelta)
        {
            Vector3 targetDirection = target.position - transform.position;
            Vector3 newDirection = Vector3.RotateTowards(transform.up, targetDirection, maxRadiansDelta, 0.0f);

            transform.LookAtWithY(newDirection);
        }

        /// <summary>
        /// Performs a LookAt() with transform's y direction and a given rotation speed
        /// </summary>
        public static void LookAtWithYGradually(this Transform transform, Vector3 target, float maxRadiansDelta)
        {
            Vector3 targetDirection = target - transform.position;
            Vector3 newDirection = Vector3.RotateTowards(transform.up, targetDirection, maxRadiansDelta, 0.0f);

            transform.LookAtWithY(newDirection);
        }

        /// <summary>
        /// Performs a recursive search to find a child in transform's hierarchy
        /// </summary>
        /// <param name="transform"></param>
        /// <param name="name"></param>
        /// <param name="includeInactive"></param>
        /// <returns></returns>
        public static Transform FindRecursive(this Transform transform, string name, bool includeInactive = false)
        {
            foreach(Transform child in transform.GetComponentsInChildren<Transform>(includeInactive))
            {
                if(child.name.Equals(name))
                {
                    return child;
                }
            }
            return null;
        }
    }
}
