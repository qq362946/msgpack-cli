﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:2.0.50727.8745
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.9.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWritePropertySerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IList<string>> _serializer0;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty>> _packOperationTable;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty, bool>> _nullCheckersTable;
        
        private System.Action<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty, System.Collections.Generic.IList<string>> this_SetUnpackedValueOfListStaticItemDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWritePropertySerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context, (MsgPack.Serialization.SerializerCapabilities.PackTo | MsgPack.Serialization.SerializerCapabilities.UnpackFrom)) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<System.Collections.Generic.IList<string>>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty>(this.PackValueOfListStaticItem);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty>>(1);
            packOperationTable["ListStaticItem"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty>(this.PackValueOfListStaticItem);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty, bool>> nullCheckerTable = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty, bool>>);
            nullCheckerTable = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty, bool>>(1);
            nullCheckerTable["ListStaticItem"] = new System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty, bool>(this.IsListStaticItemNull);
            this._nullCheckersTable = nullCheckerTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty, int, int>(this.UnpackValueOfListStaticItem);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty, int, int>>(1);
            unpackOperationTable["ListStaticItem"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty, int, int>(this.UnpackValueOfListStaticItem);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "ListStaticItem"};
            this.this_SetUnpackedValueOfListStaticItemDelegate = new System.Action<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty, System.Collections.Generic.IList<string>>(this.SetUnpackedValueOfListStaticItem);
        }
        
        private void PackValueOfListStaticItem(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty objectTree) {
            this._serializer0.PackTo(packer, objectTree.ListStaticItem);
        }
        
        private bool IsListStaticItemNull(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty objectTree) {
            return (objectTree.ListStaticItem == null);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty objectTree) {
            MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty> packHelperParameters = default(MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationList;
            MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty> packHelperParameters0 = default(MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty>);
            packHelperParameters0.Packer = packer;
            packHelperParameters0.Target = objectTree;
            packHelperParameters0.Operations = this._packOperationTable;
            packHelperParameters0.SerializationContext = this.OwnerContext;
            packHelperParameters0.NullCheckers = this._nullCheckersTable;
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(ref packHelperParameters);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(ref packHelperParameters0);
            }
        }
        
        private void SetUnpackedValueOfListStaticItem(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty unpackingContext, System.Collections.Generic.IList<string> unpackedValue) {
            unpackingContext.ListStaticItem = unpackedValue;
        }
        
        private void UnpackValueOfListStaticItem(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty, System.Collections.Generic.IList<string>> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty, System.Collections.Generic.IList<string>>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(System.Collections.Generic.IList<string>);
            unpackHelperParameters.MemberName = "ListStaticItem";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = null;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfListStaticItemDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty result = default(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty);
            result = new MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListStaticItemReadWriteProperty>(), this._unpackOperationTable);
            }
        }
    }
}
