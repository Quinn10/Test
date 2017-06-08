using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace TestThreading2
{
    public static class FastObjectAllocator<T> where T : new()
    {
        public static Func<T> mObjectCreator = null;

        public static T New()
        {
            if (mObjectCreator == null)
            {
                Type objectType = typeof(T);
                ConstructorInfo defaultConstrcutor = objectType.GetConstructor(new Type[] { });

                DynamicMethod dynMethod = new DynamicMethod(
                    name: string.Format("_{0:N}", Guid.NewGuid()),
                    returnType: objectType,
                    parameterTypes: null
                    );

                ILGenerator il = dynMethod.GetILGenerator();
                il.Emit(OpCodes.Newobj, defaultConstrcutor);
                il.Emit(OpCodes.Ret);


               mObjectCreator = dynMethod.CreateDelegate(typeof(Func<T>)) as Func<T>;
                      
            }

            return mObjectCreator();


        }
    }
}
