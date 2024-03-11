using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Practica_and_Task
{
    public class DataList<T>
    {


        public T[] _datas;
            
        public DataList()
        {
            _datas = Array.Empty<T>();
        }

        public void Add( T data)
        {
            Array.Resize(ref _datas, _datas.Length + 1);
            _datas[_datas.Length - 1] = data;

        }
        public T[] GetAll()
        {
            return _datas;

        }

        internal void Delete( R)
        {

            Array.Resize(ref _datas, _datas.Length + 1);
            _datas[_datas.Length - 1] = word;

        }
    }
}
