using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtiquetaCertaCase.Core.Schema
{
    public class PaginatedResult<T> : Result<IEnumerable<T>>
    {
        public PaginatedResult() { }

        public PaginatedResult(List<T> data)
        {
            SetSuccess(data);
        }
    }
}
