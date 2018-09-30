using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Reloaded.Process.Memory;

namespace Reloaded_Mod_Template
{
    public static class EndianConverter
    {
        /// <summary>
        /// Reads a value from the CLFile array and retrieves it in the desired format.
        /// </summary>
        /// <returns></returns>
        public static T ReverseEndian<T>(this T type) where T : unmanaged
        {
            // Declare an array for storing the data.
            byte[] data = MemoryReadWrite.ConvertStructureToByteArrayUnsafe(ref type);
            data        = FastArrayReverse(data);

            // Use this base object for the storage of the value we are retrieving.
            return MemoryReadWrite.ArrayToStructureUnsafe<T>(ref data);
        }

        /// <summary>
        /// GetManagedSize returns the size of a structure whose type
        /// is 'type', as stored in managed memory. For any reference type
        /// this will simply return the size of a pointer (4 or 8).
        /// </summary>
        public static int GetManagedSize(Type type)
        {
            var method = new DynamicMethod("GetManagedSizeImpl", typeof(uint), new Type[0], typeof(EndianConverter), false);

            ILGenerator gen = method.GetILGenerator();
            gen.Emit(OpCodes.Sizeof, type);
            gen.Emit(OpCodes.Ret);

            var func = (Func<uint>)method.CreateDelegate(typeof(Func<uint>));
            return checked((int)func());
        }

        /// <summary>
        /// Provides a non-LINQ implementation of array reversing.
        /// </summary>
        private static T[] FastArrayReverse<T>(T[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                T arrayStartSwapElement = array[i];
                int arrayEndSwapIndex = (array.Length - 1) - i;

                array[i] = array[arrayEndSwapIndex];
                array[arrayEndSwapIndex] = arrayStartSwapElement;
            }

            return array;
        }
    }
}
