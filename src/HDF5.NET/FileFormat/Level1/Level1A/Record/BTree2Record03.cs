﻿using System.IO;

namespace HDF5.NET
{
    public class BTree2Record03 : BTree2Record
    {
        #region Constructors

        public BTree2Record03(BinaryReader reader, Superblock superblock) : base(reader)
        {
            this.HugeObjectAddress = superblock.ReadOffset();
            this.HugeObjectLength = superblock.ReadLength();
        }

        #endregion

        #region Properties

        public ulong HugeObjectAddress { get; set; }
        public ulong HugeObjectLength { get; set; }

        #endregion
    }
}