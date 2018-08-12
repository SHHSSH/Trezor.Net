﻿using ProtoBuf;

namespace Trezor
{
    [ProtoContract]
    public class EthereumTxAck
    {
        [ProtoMember(1, Name = @"data_chunk")]
        public byte[] DataChunk { get; set; }

        public bool ShouldSerializeDataChunk() => DataChunk != null;
        public void ResetDataChunk() => DataChunk = null;
    }
}