// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: messages-tron.proto

namespace Trezor.Net.Contracts.Tron
{

#pragma warning disable CS1591, CS0612, CS3021, IDE1006
    [global::ProtoBuf.ProtoContract()]
    public partial class TronGetAddress : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"show_display")]
        public bool ShowDisplay
        {
            get { return __pbn__ShowDisplay.GetValueOrDefault(); }
            set { __pbn__ShowDisplay = value; }
        }
        public bool ShouldSerializeShowDisplay() => __pbn__ShowDisplay != null;
        public void ResetShowDisplay() => __pbn__ShowDisplay = null;
        private bool? __pbn__ShowDisplay;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TronAddress : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Address
        {
            get { return __pbn__Address ?? ""; }
            set { __pbn__Address = value; }
        }
        public bool ShouldSerializeAddress() => __pbn__Address != null;
        public void ResetAddress() => __pbn__Address = null;
        private string __pbn__Address;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TronSignTx : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"ref_block_bytes")]
        public byte[] RefBlockBytes
        {
            get { return __pbn__RefBlockBytes; }
            set { __pbn__RefBlockBytes = value; }
        }
        public bool ShouldSerializeRefBlockBytes() => __pbn__RefBlockBytes != null;
        public void ResetRefBlockBytes() => __pbn__RefBlockBytes = null;
        private byte[] __pbn__RefBlockBytes;

        [global::ProtoBuf.ProtoMember(3, Name = @"ref_block_hash")]
        public byte[] RefBlockHash
        {
            get { return __pbn__RefBlockHash; }
            set { __pbn__RefBlockHash = value; }
        }
        public bool ShouldSerializeRefBlockHash() => __pbn__RefBlockHash != null;
        public void ResetRefBlockHash() => __pbn__RefBlockHash = null;
        private byte[] __pbn__RefBlockHash;

        [global::ProtoBuf.ProtoMember(4, Name = @"expiration")]
        public ulong Expiration
        {
            get { return __pbn__Expiration.GetValueOrDefault(); }
            set { __pbn__Expiration = value; }
        }
        public bool ShouldSerializeExpiration() => __pbn__Expiration != null;
        public void ResetExpiration() => __pbn__Expiration = null;
        private ulong? __pbn__Expiration;

        [global::ProtoBuf.ProtoMember(5, Name = @"data")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Data
        {
            get { return __pbn__Data ?? ""; }
            set { __pbn__Data = value; }
        }
        public bool ShouldSerializeData() => __pbn__Data != null;
        public void ResetData() => __pbn__Data = null;
        private string __pbn__Data;

        [global::ProtoBuf.ProtoMember(6, Name = @"contract")]
        public TronContract Contract { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"timestamp")]
        public ulong Timestamp
        {
            get { return __pbn__Timestamp.GetValueOrDefault(); }
            set { __pbn__Timestamp = value; }
        }
        public bool ShouldSerializeTimestamp() => __pbn__Timestamp != null;
        public void ResetTimestamp() => __pbn__Timestamp = null;
        private ulong? __pbn__Timestamp;

        [global::ProtoBuf.ProtoContract()]
        public partial class TronContract : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"transfer_contract")]
            public TronTransferContract TransferContract { get; set; }

            [global::ProtoBuf.ProtoMember(2, Name = @"transfer_asset_contract")]
            public TronTransferAssetContract TransferAssetContract { get; set; }

            [global::ProtoBuf.ProtoMember(4, Name = @"vote_witness_contract")]
            public TronVoteWitnessContract VoteWitnessContract { get; set; }

            [global::ProtoBuf.ProtoMember(5, Name = @"witness_create_contract")]
            public TronWitnessCreateContract WitnessCreateContract { get; set; }

            [global::ProtoBuf.ProtoMember(6, Name = @"asset_issue_contract")]
            public TronAssetIssueContract AssetIssueContract { get; set; }

            [global::ProtoBuf.ProtoMember(8, Name = @"witness_update_contract")]
            public TronWitnessUpdateContract WitnessUpdateContract { get; set; }

            [global::ProtoBuf.ProtoMember(9, Name = @"participate_asset_issue_contract")]
            public TronParticipateAssetIssueContract ParticipateAssetIssueContract { get; set; }

            [global::ProtoBuf.ProtoMember(10, Name = @"account_update_contract")]
            public TronAccountUpdateContract AccountUpdateContract { get; set; }

            [global::ProtoBuf.ProtoMember(11, Name = @"freeze_balance_contract")]
            public TronFreezeBalanceContract FreezeBalanceContract { get; set; }

            [global::ProtoBuf.ProtoMember(12, Name = @"unfreeze_balance_contract")]
            public TronUnfreezeBalanceContract UnfreezeBalanceContract { get; set; }

            [global::ProtoBuf.ProtoMember(13, Name = @"withdraw_balance_contract")]
            public TronWithdrawBalanceContract WithdrawBalanceContract { get; set; }

            [global::ProtoBuf.ProtoMember(14, Name = @"unfreeze_asset_contract")]
            public TronUnfreezeAssetContract UnfreezeAssetContract { get; set; }

            [global::ProtoBuf.ProtoMember(15, Name = @"update_asset_contract")]
            public TronUpdateAssetContract UpdateAssetContract { get; set; }

            [global::ProtoBuf.ProtoMember(16, Name = @"proposal_create_contract")]
            public TronProposalCreateContract ProposalCreateContract { get; set; }

            [global::ProtoBuf.ProtoMember(17, Name = @"proposal_approve_contract")]
            public TronProposalApproveContract ProposalApproveContract { get; set; }

            [global::ProtoBuf.ProtoMember(18, Name = @"proposal_delete_contract")]
            public TronProposalDeleteContract ProposalDeleteContract { get; set; }

            [global::ProtoBuf.ProtoContract()]
            public partial class TronAccountUpdateContract : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension __pbn__extensionData;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [global::ProtoBuf.ProtoMember(1, Name = @"account_name")]
                [global::System.ComponentModel.DefaultValue("")]
                public string AccountName
                {
                    get { return __pbn__AccountName ?? ""; }
                    set { __pbn__AccountName = value; }
                }
                public bool ShouldSerializeAccountName() => __pbn__AccountName != null;
                public void ResetAccountName() => __pbn__AccountName = null;
                private string __pbn__AccountName;

            }

            [global::ProtoBuf.ProtoContract()]
            public partial class TronTransferContract : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension __pbn__extensionData;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [global::ProtoBuf.ProtoMember(1, Name = @"to_address")]
                public byte[] ToAddress
                {
                    get { return __pbn__ToAddress; }
                    set { __pbn__ToAddress = value; }
                }
                public bool ShouldSerializeToAddress() => __pbn__ToAddress != null;
                public void ResetToAddress() => __pbn__ToAddress = null;
                private byte[] __pbn__ToAddress;

                [global::ProtoBuf.ProtoMember(2, Name = @"amount")]
                public ulong Amount
                {
                    get { return __pbn__Amount.GetValueOrDefault(); }
                    set { __pbn__Amount = value; }
                }
                public bool ShouldSerializeAmount() => __pbn__Amount != null;
                public void ResetAmount() => __pbn__Amount = null;
                private ulong? __pbn__Amount;

            }

            [global::ProtoBuf.ProtoContract()]
            public partial class TronTransferAssetContract : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension __pbn__extensionData;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [global::ProtoBuf.ProtoMember(1, Name = @"asset_name")]
                [global::System.ComponentModel.DefaultValue("")]
                public string AssetName
                {
                    get { return __pbn__AssetName ?? ""; }
                    set { __pbn__AssetName = value; }
                }
                public bool ShouldSerializeAssetName() => __pbn__AssetName != null;
                public void ResetAssetName() => __pbn__AssetName = null;
                private string __pbn__AssetName;

                [global::ProtoBuf.ProtoMember(2, Name = @"to_address")]
                public byte[] ToAddress
                {
                    get { return __pbn__ToAddress; }
                    set { __pbn__ToAddress = value; }
                }
                public bool ShouldSerializeToAddress() => __pbn__ToAddress != null;
                public void ResetToAddress() => __pbn__ToAddress = null;
                private byte[] __pbn__ToAddress;

                [global::ProtoBuf.ProtoMember(3, Name = @"amount")]
                public ulong Amount
                {
                    get { return __pbn__Amount.GetValueOrDefault(); }
                    set { __pbn__Amount = value; }
                }
                public bool ShouldSerializeAmount() => __pbn__Amount != null;
                public void ResetAmount() => __pbn__Amount = null;
                private ulong? __pbn__Amount;

            }

            [global::ProtoBuf.ProtoContract()]
            public partial class TronVoteWitnessContract : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension __pbn__extensionData;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [global::ProtoBuf.ProtoMember(1, Name = @"votes")]
                public global::System.Collections.Generic.List<TronVote> Votes { get; } = new global::System.Collections.Generic.List<TronVote>();

                [global::ProtoBuf.ProtoContract()]
                public partial class TronVote : global::ProtoBuf.IExtensible
                {
                    private global::ProtoBuf.IExtension __pbn__extensionData;
                    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                    [global::ProtoBuf.ProtoMember(1, Name = @"vote_address")]
                    public byte[] VoteAddress
                    {
                        get { return __pbn__VoteAddress; }
                        set { __pbn__VoteAddress = value; }
                    }
                    public bool ShouldSerializeVoteAddress() => __pbn__VoteAddress != null;
                    public void ResetVoteAddress() => __pbn__VoteAddress = null;
                    private byte[] __pbn__VoteAddress;

                    [global::ProtoBuf.ProtoMember(2, Name = @"vote_count")]
                    public ulong VoteCount
                    {
                        get { return __pbn__VoteCount.GetValueOrDefault(); }
                        set { __pbn__VoteCount = value; }
                    }
                    public bool ShouldSerializeVoteCount() => __pbn__VoteCount != null;
                    public void ResetVoteCount() => __pbn__VoteCount = null;
                    private ulong? __pbn__VoteCount;

                }

            }

            [global::ProtoBuf.ProtoContract()]
            public partial class TronWitnessCreateContract : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension __pbn__extensionData;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [global::ProtoBuf.ProtoMember(1, Name = @"url")]
                [global::System.ComponentModel.DefaultValue("")]
                public string Url
                {
                    get { return __pbn__Url ?? ""; }
                    set { __pbn__Url = value; }
                }
                public bool ShouldSerializeUrl() => __pbn__Url != null;
                public void ResetUrl() => __pbn__Url = null;
                private string __pbn__Url;

            }

            [global::ProtoBuf.ProtoContract()]
            public partial class TronWitnessUpdateContract : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension __pbn__extensionData;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [global::ProtoBuf.ProtoMember(2, Name = @"update_url")]
                [global::System.ComponentModel.DefaultValue("")]
                public string UpdateUrl
                {
                    get { return __pbn__UpdateUrl ?? ""; }
                    set { __pbn__UpdateUrl = value; }
                }
                public bool ShouldSerializeUpdateUrl() => __pbn__UpdateUrl != null;
                public void ResetUpdateUrl() => __pbn__UpdateUrl = null;
                private string __pbn__UpdateUrl;

            }

            [global::ProtoBuf.ProtoContract()]
            public partial class TronAssetIssueContract : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension __pbn__extensionData;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [global::ProtoBuf.ProtoMember(2, Name = @"name")]
                [global::System.ComponentModel.DefaultValue("")]
                public string Name
                {
                    get { return __pbn__Name ?? ""; }
                    set { __pbn__Name = value; }
                }
                public bool ShouldSerializeName() => __pbn__Name != null;
                public void ResetName() => __pbn__Name = null;
                private string __pbn__Name;

                [global::ProtoBuf.ProtoMember(3, Name = @"abbr")]
                [global::System.ComponentModel.DefaultValue("")]
                public string Abbr
                {
                    get { return __pbn__Abbr ?? ""; }
                    set { __pbn__Abbr = value; }
                }
                public bool ShouldSerializeAbbr() => __pbn__Abbr != null;
                public void ResetAbbr() => __pbn__Abbr = null;
                private string __pbn__Abbr;

                [global::ProtoBuf.ProtoMember(4, Name = @"total_supply")]
                public ulong TotalSupply
                {
                    get { return __pbn__TotalSupply.GetValueOrDefault(); }
                    set { __pbn__TotalSupply = value; }
                }
                public bool ShouldSerializeTotalSupply() => __pbn__TotalSupply != null;
                public void ResetTotalSupply() => __pbn__TotalSupply = null;
                private ulong? __pbn__TotalSupply;

                [global::ProtoBuf.ProtoMember(5, Name = @"frozen_supply")]
                public global::System.Collections.Generic.List<TronFrozenSupply> FrozenSupplies { get; } = new global::System.Collections.Generic.List<TronFrozenSupply>();

                [global::ProtoBuf.ProtoMember(6, Name = @"trx_num")]
                public uint TrxNum
                {
                    get { return __pbn__TrxNum.GetValueOrDefault(); }
                    set { __pbn__TrxNum = value; }
                }
                public bool ShouldSerializeTrxNum() => __pbn__TrxNum != null;
                public void ResetTrxNum() => __pbn__TrxNum = null;
                private uint? __pbn__TrxNum;

                [global::ProtoBuf.ProtoMember(7, Name = @"num")]
                public uint Num
                {
                    get { return __pbn__Num.GetValueOrDefault(); }
                    set { __pbn__Num = value; }
                }
                public bool ShouldSerializeNum() => __pbn__Num != null;
                public void ResetNum() => __pbn__Num = null;
                private uint? __pbn__Num;

                [global::ProtoBuf.ProtoMember(8, Name = @"start_time")]
                public ulong StartTime
                {
                    get { return __pbn__StartTime.GetValueOrDefault(); }
                    set { __pbn__StartTime = value; }
                }
                public bool ShouldSerializeStartTime() => __pbn__StartTime != null;
                public void ResetStartTime() => __pbn__StartTime = null;
                private ulong? __pbn__StartTime;

                [global::ProtoBuf.ProtoMember(9, Name = @"end_time")]
                public ulong EndTime
                {
                    get { return __pbn__EndTime.GetValueOrDefault(); }
                    set { __pbn__EndTime = value; }
                }
                public bool ShouldSerializeEndTime() => __pbn__EndTime != null;
                public void ResetEndTime() => __pbn__EndTime = null;
                private ulong? __pbn__EndTime;

                [global::ProtoBuf.ProtoMember(10, Name = @"description")]
                [global::System.ComponentModel.DefaultValue("")]
                public string Description
                {
                    get { return __pbn__Description ?? ""; }
                    set { __pbn__Description = value; }
                }
                public bool ShouldSerializeDescription() => __pbn__Description != null;
                public void ResetDescription() => __pbn__Description = null;
                private string __pbn__Description;

                [global::ProtoBuf.ProtoMember(11, Name = @"url")]
                [global::System.ComponentModel.DefaultValue("")]
                public string Url
                {
                    get { return __pbn__Url ?? ""; }
                    set { __pbn__Url = value; }
                }
                public bool ShouldSerializeUrl() => __pbn__Url != null;
                public void ResetUrl() => __pbn__Url = null;
                private string __pbn__Url;

                [global::ProtoBuf.ProtoContract()]
                public partial class TronFrozenSupply : global::ProtoBuf.IExtensible
                {
                    private global::ProtoBuf.IExtension __pbn__extensionData;
                    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                    [global::ProtoBuf.ProtoMember(1, Name = @"frozen_amount")]
                    public ulong FrozenAmount
                    {
                        get { return __pbn__FrozenAmount.GetValueOrDefault(); }
                        set { __pbn__FrozenAmount = value; }
                    }
                    public bool ShouldSerializeFrozenAmount() => __pbn__FrozenAmount != null;
                    public void ResetFrozenAmount() => __pbn__FrozenAmount = null;
                    private ulong? __pbn__FrozenAmount;

                    [global::ProtoBuf.ProtoMember(2, Name = @"frozen_days")]
                    public ulong FrozenDays
                    {
                        get { return __pbn__FrozenDays.GetValueOrDefault(); }
                        set { __pbn__FrozenDays = value; }
                    }
                    public bool ShouldSerializeFrozenDays() => __pbn__FrozenDays != null;
                    public void ResetFrozenDays() => __pbn__FrozenDays = null;
                    private ulong? __pbn__FrozenDays;

                }

            }

            [global::ProtoBuf.ProtoContract()]
            public partial class TronParticipateAssetIssueContract : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension __pbn__extensionData;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [global::ProtoBuf.ProtoMember(1, Name = @"to_address")]
                public byte[] ToAddress
                {
                    get { return __pbn__ToAddress; }
                    set { __pbn__ToAddress = value; }
                }
                public bool ShouldSerializeToAddress() => __pbn__ToAddress != null;
                public void ResetToAddress() => __pbn__ToAddress = null;
                private byte[] __pbn__ToAddress;

                [global::ProtoBuf.ProtoMember(2, Name = @"asset_name")]
                [global::System.ComponentModel.DefaultValue("")]
                public string AssetName
                {
                    get { return __pbn__AssetName ?? ""; }
                    set { __pbn__AssetName = value; }
                }
                public bool ShouldSerializeAssetName() => __pbn__AssetName != null;
                public void ResetAssetName() => __pbn__AssetName = null;
                private string __pbn__AssetName;

                [global::ProtoBuf.ProtoMember(3, Name = @"amount")]
                public ulong Amount
                {
                    get { return __pbn__Amount.GetValueOrDefault(); }
                    set { __pbn__Amount = value; }
                }
                public bool ShouldSerializeAmount() => __pbn__Amount != null;
                public void ResetAmount() => __pbn__Amount = null;
                private ulong? __pbn__Amount;

            }

            [global::ProtoBuf.ProtoContract()]
            public partial class TronFreezeBalanceContract : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension __pbn__extensionData;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [global::ProtoBuf.ProtoMember(1, Name = @"frozen_balance")]
                public ulong FrozenBalance
                {
                    get { return __pbn__FrozenBalance.GetValueOrDefault(); }
                    set { __pbn__FrozenBalance = value; }
                }
                public bool ShouldSerializeFrozenBalance() => __pbn__FrozenBalance != null;
                public void ResetFrozenBalance() => __pbn__FrozenBalance = null;
                private ulong? __pbn__FrozenBalance;

                [global::ProtoBuf.ProtoMember(2, Name = @"frozen_duration")]
                public ulong FrozenDuration
                {
                    get { return __pbn__FrozenDuration.GetValueOrDefault(); }
                    set { __pbn__FrozenDuration = value; }
                }
                public bool ShouldSerializeFrozenDuration() => __pbn__FrozenDuration != null;
                public void ResetFrozenDuration() => __pbn__FrozenDuration = null;
                private ulong? __pbn__FrozenDuration;

            }

            [global::ProtoBuf.ProtoContract()]
            public partial class TronUnfreezeBalanceContract : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension __pbn__extensionData;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            }

            [global::ProtoBuf.ProtoContract()]
            public partial class TronUnfreezeAssetContract : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension __pbn__extensionData;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            }

            [global::ProtoBuf.ProtoContract()]
            public partial class TronWithdrawBalanceContract : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension __pbn__extensionData;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            }

            [global::ProtoBuf.ProtoContract()]
            public partial class TronUpdateAssetContract : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension __pbn__extensionData;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [global::ProtoBuf.ProtoMember(1, Name = @"description")]
                [global::System.ComponentModel.DefaultValue("")]
                public string Description
                {
                    get { return __pbn__Description ?? ""; }
                    set { __pbn__Description = value; }
                }
                public bool ShouldSerializeDescription() => __pbn__Description != null;
                public void ResetDescription() => __pbn__Description = null;
                private string __pbn__Description;

                [global::ProtoBuf.ProtoMember(2, Name = @"url")]
                [global::System.ComponentModel.DefaultValue("")]
                public string Url
                {
                    get { return __pbn__Url ?? ""; }
                    set { __pbn__Url = value; }
                }
                public bool ShouldSerializeUrl() => __pbn__Url != null;
                public void ResetUrl() => __pbn__Url = null;
                private string __pbn__Url;

            }

            [global::ProtoBuf.ProtoContract()]
            public partial class TronProposalCreateContract : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension __pbn__extensionData;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [global::ProtoBuf.ProtoMember(1, Name = @"parameters")]
                public global::System.Collections.Generic.List<TronProposalParameters> Parameters { get; } = new global::System.Collections.Generic.List<TronProposalParameters>();

                [global::ProtoBuf.ProtoContract()]
                public partial class TronProposalParameters : global::ProtoBuf.IExtensible
                {
                    private global::ProtoBuf.IExtension __pbn__extensionData;
                    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                    [global::ProtoBuf.ProtoMember(1, Name = @"key")]
                    public ulong Key
                    {
                        get { return __pbn__Key.GetValueOrDefault(); }
                        set { __pbn__Key = value; }
                    }
                    public bool ShouldSerializeKey() => __pbn__Key != null;
                    public void ResetKey() => __pbn__Key = null;
                    private ulong? __pbn__Key;

                    [global::ProtoBuf.ProtoMember(2, Name = @"value")]
                    public ulong Value
                    {
                        get { return __pbn__Value.GetValueOrDefault(); }
                        set { __pbn__Value = value; }
                    }
                    public bool ShouldSerializeValue() => __pbn__Value != null;
                    public void ResetValue() => __pbn__Value = null;
                    private ulong? __pbn__Value;

                }

            }

            [global::ProtoBuf.ProtoContract()]
            public partial class TronProposalApproveContract : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension __pbn__extensionData;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [global::ProtoBuf.ProtoMember(1, Name = @"proposal_id")]
                public ulong ProposalId
                {
                    get { return __pbn__ProposalId.GetValueOrDefault(); }
                    set { __pbn__ProposalId = value; }
                }
                public bool ShouldSerializeProposalId() => __pbn__ProposalId != null;
                public void ResetProposalId() => __pbn__ProposalId = null;
                private ulong? __pbn__ProposalId;

                [global::ProtoBuf.ProtoMember(2, Name = @"is_add_approval")]
                public bool IsAddApproval
                {
                    get { return __pbn__IsAddApproval.GetValueOrDefault(); }
                    set { __pbn__IsAddApproval = value; }
                }
                public bool ShouldSerializeIsAddApproval() => __pbn__IsAddApproval != null;
                public void ResetIsAddApproval() => __pbn__IsAddApproval = null;
                private bool? __pbn__IsAddApproval;

            }

            [global::ProtoBuf.ProtoContract()]
            public partial class TronProposalDeleteContract : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension __pbn__extensionData;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [global::ProtoBuf.ProtoMember(1, Name = @"proposal_id")]
                public ulong ProposalId
                {
                    get { return __pbn__ProposalId.GetValueOrDefault(); }
                    set { __pbn__ProposalId = value; }
                }
                public bool ShouldSerializeProposalId() => __pbn__ProposalId != null;
                public void ResetProposalId() => __pbn__ProposalId = null;
                private ulong? __pbn__ProposalId;

            }

        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TronSignedTx : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"signature")]
        public byte[] Signature
        {
            get { return __pbn__Signature; }
            set { __pbn__Signature = value; }
        }
        public bool ShouldSerializeSignature() => __pbn__Signature != null;
        public void ResetSignature() => __pbn__Signature = null;
        private byte[] __pbn__Signature;

        [global::ProtoBuf.ProtoMember(2, Name = @"serialized_tx")]
        public byte[] SerializedTx
        {
            get { return __pbn__SerializedTx; }
            set { __pbn__SerializedTx = value; }
        }
        public bool ShouldSerializeSerializedTx() => __pbn__SerializedTx != null;
        public void ResetSerializedTx() => __pbn__SerializedTx = null;
        private byte[] __pbn__SerializedTx;

    }

#pragma warning restore CS1591, CS0612, CS3021, IDE1006

}
