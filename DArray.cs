using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_A
{
    internal class DArray<T> //: IEnumerable<T>
    {
        T[] array;
        public int Length { get; set; }
        public DArray(int size)
        {
            array = new T[size];
            Length = size;
        }

        public T this[int idx] 
        {
            get { return array[idx]; }
            set {
                try 
                {
                    array[idx] = value;
                }catch (IndexOutOfRangeException) 
                {
                    var arraytmp = new T[++Length];
                    Array.Copy(array, arraytmp, array.Length);
                    arraytmp[idx] = value;
                    array = arraytmp;
                }
            }
        }

        //public IEnumerator<T> GetEnumerator()
        //{
        //    return GetEnumerator();
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
