using Hemelo.Database.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemelo.Database.Core.Implementation
{
    public class BlockStorage : IBlockStorage
    {
        readonly Stream stream;
        readonly int blockSize; 
        readonly int blockHeaderSize;
        readonly int blockContentSize;
    }
}
