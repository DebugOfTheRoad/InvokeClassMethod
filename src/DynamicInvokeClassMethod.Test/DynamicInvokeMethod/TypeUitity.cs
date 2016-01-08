using System;
using System.Reflection;

namespace DynamicInvokeMethod
{
    public class TypeUitity
    {
        ///// <summary>
        /////     执行一个 返回string，无参数的方法
        ///// </summary>
        ///// <param name="typeName">方法所在的类名</param>
        ///// <param name="methodName">方法名</param>
        ///// <returns>System.String.</returns>

        //public static string InvokeMethod(string typeName, string methodName)
        //{
        //    Type calledType = Type.GetType(typeName);
        //    if (calledType != null)
        //    {
        //        string s = (string)calledType.InvokeMember(
        //            methodName,
        //            BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Static,
        //            null,
        //            null,
        //            null);
        //        return s;
        //    }
        //    return string.Empty;
        //}

        ///// <summary>
        /////     执行一个带参数，并返回string的方法
        ///// </summary>
        ///// <param name="typeName">方法所在的类名</param>
        ///// <param name="methodName">方法名</param>
        ///// <param name="parameter">参数</param>
        ///// <returns>System.String.</returns>
        //public static string InvokeMethod(string typeName, string methodName, string parameter)
        //{
        //    Type calledType = Type.GetType(typeName);
        //    if (calledType != null)
        //    {
        //        return (string)calledType.InvokeMember(
        //            methodName,
        //            BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Static,
        //            null,
        //            null,
        //            new object[] { parameter });
        //    }
        //    return string.Empty;
        //}

        /// <summary>
        ///     Invokes the string method.
        /// </summary>
        /// <param name="assemblyName">程序集名称，全称</param>
        /// <param name="namespaceName">类所在的命名空间</param>
        /// <param name="typeName">方法所在的类名</param>
        /// <param name="methodName">方法名称</param>
        /// <returns>System.String.</returns>
        public static string InvokeMethod(string assemblyName, string namespaceName, string typeName, string methodName)

        {
            Type calledType = Type.GetType(namespaceName + "." + typeName + "," + assemblyName);
            //var obj = Activator.CreateInstance(calledType, "para");
            //BindingFlags.InvokeMethod | BindingFlags.Public /*| BindingFlags.Static*/|

            if (calledType != null)
            {
                //object obj = calledType.InvokeMember(methodName,
                //    BindingFlags.Public |
                //    BindingFlags.Instance | BindingFlags.CreateInstance, null, null, new object[] { "参数" });

                var result = (string)calledType.InvokeMember(methodName,
                    BindingFlags.InvokeMethod |
                    BindingFlags.Public | BindingFlags.NonPublic |
                    BindingFlags.Static, null, null, new object[] { "传递参数" });
                return result;
                //object instance = Activator.CreateInstance(calledType);
                //MethodInfo invoke = calledType.GetMethod("Apply");
                //var result = invoke.Invoke(instance, new object[] { "参数" });
                //return (string)result;
            }
            return string.Empty;
        }

        /// <summary>
        ///     Invokes the string method.
        /// </summary>
        /// <param name="assemblyName">程序集名称，全称</param>
        /// <param name="namespaceName">类所在的命名空间</param>
        /// <param name="typeName">方法所在的类名</param>
        /// <param name="methodName">方法名称</param>
        /// <param name="parameter">方法的参数</param>
        /// <returns>返回值类型</returns>
        public static string InvokeMethod(string assemblyName, string namespaceName, string typeName, string methodName, object parameter)
        {
            Type calledType = Type.GetType(namespaceName + "." + typeName + "," + assemblyName);
            if (calledType != null)
            {
                string result = (string)calledType.InvokeMember(methodName,
                    BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Static,
                    null,
                    null,
                    new[] { parameter });
                return result;
            }
            return string.Empty;
        }
    }
}