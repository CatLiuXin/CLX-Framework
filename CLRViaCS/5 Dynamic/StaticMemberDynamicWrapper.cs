using System;
using System.Collections.Generic;
using System.Text;
using System.Dynamic;
using System.Reflection;
using System.Linq;

namespace CLRViaCS._5_Dynamic
{
    /// <summary>
    /// 使用 dynamic 调用类的静态成员
    /// 主要示范了 dynamic 的内部机制
    /// 如果在动态表达式使用的一个对象未实现IDynamicMetaObjectProvider接口
    /// 那么将会使用反射在对象上执行操作
    /// 如果继承了，那么就会执行它的GetMetaObject方法
    /// </summary>
    internal sealed class StaticMemberDynamicWrapper:DynamicObject
    {
        private readonly TypeInfo m_type;
        public StaticMemberDynamicWrapper(Type type) { m_type = type.GetTypeInfo(); }
        public override IEnumerable<string> GetDynamicMemberNames()
        {
            return m_type.DeclaredMembers.Select(mi => mi.Name);
        }
        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            result = null;
            var filed = FindField(binder.Name);
            if(filed!=null) { result = filed.GetValue(null);return true; }
            var prop = FindProperty(binder.Name, true);
            if (prop != null) { result = prop.GetValue(null, null);return true; }
            return false;
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            var filed = FindField(binder.Name);
            if (filed != null) { filed.SetValue(null,value); return true; }
            var prop = FindProperty(binder.Name, true);
            if (prop != null) {prop.SetValue(null,value, null); return true; }
            return false;
        }

        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            Console.WriteLine("Finding!");
            MethodInfo method = FindMethod(binder.Name, args.Select(c => c.GetType()).ToArray());
            if(method==null) { result = null;return false; }
            result = method.Invoke(null, args);
            return true;
        }

        private MethodInfo FindMethod(string name,Type[] paramTypes)
        {
            return m_type.DeclaredMethods.FirstOrDefault(mi => mi.IsPublic && mi.IsStatic
            && mi.Name == name
            && ParametersMatch(mi.GetParameters(), paramTypes));
        }

        private bool ParametersMatch(ParameterInfo[] parameters,Type[] paramTypes)
        {
            if (parameters.Length != paramTypes.Length) return false;
            for(int i = 0; i < paramTypes.Length; i++)
            {
                if (paramTypes[i] != parameters[i].ParameterType) return false;
            }
            return true;
        }

        private FieldInfo FindField(string name)
        {
            return m_type.DeclaredFields.FirstOrDefault(fi => fi.IsPublic && fi.IsStatic && fi.Name == name);
        }

        private PropertyInfo FindProperty(string name,bool get)
        {
            if (get)
            {
                return m_type.DeclaredProperties.FirstOrDefault(
                    pi => pi.Name == name && pi.GetMethod != null &&
                    pi.GetMethod.IsPublic && pi.GetMethod.IsStatic);
            }
            else
            {
                return m_type.DeclaredProperties.FirstOrDefault(
                    pi => pi.Name == name && pi.SetMethod != null &&
                    pi.SetMethod.IsPublic && pi.SetMethod.IsStatic);
            }
        }
    }
}
