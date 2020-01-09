﻿using System.IO;

namespace HDF5.NET
{
    public class BitFieldPropertyDescription : DatatypePropertyDescription
    {
        #region Constructors

        public BitFieldPropertyDescription(BinaryReader reader) : base(reader)
        {
            this.BitOffset = reader.ReadUInt16();
            this.BitPrecision = reader.ReadUInt16();
        }

        #endregion

        #region Properties

        public ushort BitOffset { get; set; }
        public ushort BitPrecision { get; set; }

        #endregion
    }
}