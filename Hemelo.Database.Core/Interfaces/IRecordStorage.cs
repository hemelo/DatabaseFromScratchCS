using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemelo.Database.Core.Interfaces
{
    /// <summary>
    /// High-Level layer for managing variable-size records of data.
    /// A record can span multiple blocks, and the system handles the complexity of linking these blocks together.
    /// </summary>
    public interface IRecordStorage
    {
        uint CreateRecord();

        uint CreateRecord(byte[] data);


    }
}
