using System.Reflection;

namespace DynamicInvokeMethod
{
    public static class TypeUtilityEntensions
    {
        /// <summary>
        ///     执行一个对象中的方法
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <param name="methodName">Name of the method.</param>
        /// <param name="args">The arguments.</param>
        /// <returns>System.Object.</returns>
        public static object Invoke(this object obj, string methodName, params object[] args)
        {
            //BindingFlags.NonPublic | BindingFlags.Instance
            var calledType = obj.GetType().GetMethod(methodName, BindingFlags.Public | BindingFlags.Instance);
            return calledType?.Invoke(obj, args);
        }
    }
}