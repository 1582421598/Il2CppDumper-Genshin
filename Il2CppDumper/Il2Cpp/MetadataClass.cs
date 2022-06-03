using System;

namespace Il2CppDumper
{
    public class Il2CppGlobalMetadataHeader
    {
        public uint sanity;
        public int version;
        public uint padding1;
        public uint padding2;
        public uint padding3;
        public uint padding4;
        public uint stringLiteralDataOffset;
        public uint stringLiteralDataSize;
        public uint stringLiteralOffset; // string data for managed code
        public int stringLiteralSize;
        public uint genericContainersOffset; // Il2CppGenericContainer
        public int genericContainersSize;
        public uint nestedTypesOffset; // TypeDefinitionIndex
        public int nestedTypesSize;
        public uint interfacesOffset; // TypeIndex
        public int interfacesSize;
        public uint vtableMethodsOffset; // EncodedMethodIndex
        public int vtableMethodsSize;
        public int interfaceOffsetsOffset; // Il2CppInterfaceOffsetPair
        public int interfaceOffsetsSize;
        public uint typeDefinitionsOffset; // Il2CppTypeDefinition
        public int typeDefinitionsSize;
        public uint rgctxEntriesOffset; // Il2CppRGCTXDefinition
        public int rgctxEntriesCount;
        public int padding5;
        public int padding6;
        public int padding7;
        public int padding8;
        public uint imagesOffset; // Il2CppImageDefinition
        public int imagesSize;
        public uint assembliesOffset; // Il2CppAssemblyDefinition
        public int assembliesSize;
        public uint fieldsOffset; // Il2CppFieldDefinition
        public int fieldsSize;
        public uint genericParametersOffset; // Il2CppGenericParameter
        public int genericParametersSize;
        public uint fieldAndParameterDefaultValueDataOffset; // uint8_t
        public int fieldAndParameterDefaultValueDataSize;
        public int fieldMarshaledSizesOffset; // Il2CppFieldMarshaledSize
        public int fieldMarshaledSizesSize;
        public int referencedAssembliesOffset; // int32_t
        public int referencedAssembliesSize;
        public uint attributesInfoOffset; // Il2CppCustomAttributeTypeRange
        public int attributesInfoCount;
        public uint attributeTypesOffset; // TypeIndex
        public int attributeTypesCount;
        [Version(Min = 29)]
        public uint attributeDataOffset;
        [Version(Min = 29)]
        public int attributeDataSize;
        [Version(Min = 29)]
        public uint attributeDataRangeOffset;
        [Version(Min = 29)]
        public int attributeDataRangeSize;
        public int unresolvedVirtualCallParameterTypesOffset; // TypeIndex
        public int unresolvedVirtualCallParameterTypesSize;
        public int unresolvedVirtualCallParameterRangesOffset; // Il2CppRange
        public int unresolvedVirtualCallParameterRangesSize;
        public int windowsRuntimeTypeNamesOffset; // Il2CppWindowsRuntimeTypeNamePair
        public int windowsRuntimeTypeNamesSize;
        public int exportedTypeDefinitionsOffset; // TypeDefinitionIndex
        public int exportedTypeDefinitionsSize;
        public uint stringOffset; // string data for metadata
        public int stringCount;
        public uint parametersOffset; // Il2CppParameterDefinition
        public int parametersSize;
        public uint genericParameterConstraintsOffset; // TypeIndex
        public int genericParameterConstraintsSize;
        public uint windowsRuntimeStringsOffset; // const char*
        public int windowsRuntimeStringsSize;
        public uint metadataUsagePairsOffset; // Il2CppMetadataUsagePair
        public int metadataUsagePairsCount;
        public int padding9;
        public int padding10;
        public int padding11;
        public int padding12;
        public uint fieldRefsOffset; // Il2CppFieldRef
        public int fieldRefsSize;
        public uint eventsOffset; // Il2CppEventDefinition
        public int eventsSize;
        public uint propertiesOffset; // Il2CppPropertyDefinition
        public int propertiesSize;
        public uint methodsOffset; // Il2CppMethodDefinition
        public int methodsSize;
        public uint parameterDefaultValuesOffset; // Il2CppParameterDefaultValue
        public int parameterDefaultValuesSize;
        public uint fieldDefaultValuesOffset; // Il2CppFieldDefaultValue
        public int fieldDefaultValuesSize;
        public int padding13;
        public int padding14;
        public int padding15;
        public int padding16;
        public uint metadataUsageListsOffset; // Il2CppMetadataUsageList
        public int metadataUsageListsCount;
    }

    public class Il2CppAssemblyDefinition
    {
        public int imageIndex;
        [Version(Min = 24.1)]
        public uint token;
        [Version(Max = 24)]
        public int customAttributeIndex;
        [Version(Min = 20)]
        public int referencedAssemblyStart;
        [Version(Min = 20)]
        public int referencedAssemblyCount;
        public Il2CppAssemblyNameDefinition aname;
    }

    public class Il2CppAssemblyNameDefinition
    {
        public uint nameIndex;
        public uint cultureIndex;
        [Version(Max = 24.3)]
        public int hashValueIndex;
        public uint publicKeyIndex;
        public uint hash_alg;
        public int hash_len;
        public uint flags;
        public int major;
        public int minor;
        public int build;
        public int revision;
        [ArrayLength(Length = 8)]
        public byte[] public_key_token;
    }

    public class Il2CppImageDefinition
    {
        public uint nameIndex;
        public int assemblyIndex;

        public int typeStart;
        public uint typeCount;

        [Version(Min = 24)]
        public int exportedTypeStart;
        [Version(Min = 24)]
        public uint exportedTypeCount;

        public int entryPointIndex;
        [Version(Min = 19)]
        public uint token;

        [Version(Min = 24.1)]
        public int customAttributeStart;
        [Version(Min = 24.1)]
        public uint customAttributeCount;
    }

    public class Il2CppTypeDefinition
    {
        public uint nameIndex;
        public uint namespaceIndex;
        [Version(Max = 24)]
        public int customAttributeIndex;
        public int byvalTypeIndex;
        public int byrefTypeIndex;

        public int declaringTypeIndex;
        public int parentIndex;
        public int elementTypeIndex; // we can probably remove this one. Only used for enums

        [Version(Max = 24.1)]
        public int rgctxStartIndex;
        [Version(Max = 24.1)]
        public int rgctxCount;

        public int genericContainerIndex;

        public uint flags;

        public int fieldStart;
        public int propertyStart;
        public int methodStart;
        public int eventStart;
        public int nestedTypesStart;
        public int interfacesStart;
        public int interfaceOffsetsStart;
        public int vtableStart;

        public ushort event_count;
        public ushort method_count;
        public ushort property_count;
        public ushort field_count;
        public ushort vtable_count;
        public ushort interfaces_count;
        public ushort interface_offsets_count;
        public ushort nested_type_count;

        // bitfield to portably encode boolean values as single bits
        // 01 - valuetype;
        // 02 - enumtype;
        // 03 - has_finalize;
        // 04 - has_cctor;
        // 05 - is_blittable;
        // 06 - is_import_or_windows_runtime;
        // 07-10 - One of nine possible PackingSize values (0, 1, 2, 4, 8, 16, 32, 64, or 128)
        // 11 - PackingSize is default
        // 12 - ClassSize is default
        // 13-16 - One of nine possible PackingSize values (0, 1, 2, 4, 8, 16, 32, 64, or 128) - the specified packing size (even for explicit layouts)
        public uint bitfield;
        public uint token;

        public bool IsValueType => (bitfield & 0x1) == 1;
        public bool IsEnum => ((bitfield >> 1) & 0x1) == 1;
    }

    public class Il2CppMethodDefinition
    {
        public int returnType;
        public int declaringType;
        [Version(Max = 24)]
        public int customAttributeIndex;
        [Version(Max = 24.1f)]
        public int methodIndex;
        public uint Padding1;
        public uint nameIndex;
        public int parameterStart;
        public int genericContainerIndex;
        public uint Padding2;
        [Version(Max = 24.1)]
        public int rgctxStartIndex;
        [Version(Max = 24.1)]
        public int rgctxCount;
        public ushort parameterCount;
        public ushort flags;
        public ushort slot;
        public ushort iflags;
        public uint token;
    }

    public class Il2CppParameterDefinition
    {
        public uint nameIndex;
        public uint token;
        [Version(Max = 24)]
        public int customAttributeIndex;
        public int typeIndex;
    }

    public class Il2CppFieldDefinition
    {
        public int typeIndex;
        public uint nameIndex;
        [Version(Max = 24)]
        public int customAttributeIndex;
        public uint token;
    }

    public class Il2CppFieldDefaultValue
    {
        public int fieldIndex;
        public int typeIndex;
        public int dataIndex;
    }

    public class Il2CppPropertyDefinition
    {
        public uint nameIndex;
        public uint Padding1;
        public uint token;
        public uint attrs;
        [Version(Max = 24)]
        public int customAttributeIndex;
        public uint Padding2;
        public int set;
        public int get;
    }

    public class Il2CppCustomAttributeTypeRange
    {
        [Version(Min = 24.1)]
        public uint token;
        public int start;
        public int count;
    }

    public class Il2CppMetadataUsageList
    {
        public uint start;
        public uint count;
    }

    public class Il2CppMetadataUsagePair
    {
        public uint destinationIndex;
        public uint encodedSourceIndex;
    }

    public class Il2CppStringLiteral
    {
        public int dataIndex;
        public uint length;
    }

    public class Il2CppParameterDefaultValue
    {
        public int parameterIndex;
        public int typeIndex;
        public int dataIndex;
    }

    public class Il2CppEventDefinition
    {
        public uint nameIndex;
        public int typeIndex;
        public int add;
        public int remove;
        public int raise;
        [Version(Max = 24)]
        public int customAttributeIndex;
        [Version(Min = 19)]
        public uint token;
    }

    public class Il2CppGenericContainer
    {
        /* index of the generic type definition or the generic method definition corresponding to this container */
        public int ownerIndex; // either index into Il2CppClass metadata array or Il2CppMethodDefinition array
        public int type_argc;
        /* If true, we're a generic method, otherwise a generic type definition. */
        public int is_method;
        /* Our type parameters. */
        public int genericParameterStart;
    }

    public class Il2CppFieldRef
    {
        public int typeIndex;
        public int fieldIndex; // local offset into type fields
    }

    public class Il2CppGenericParameter
    {
        public int ownerIndex;  /* Type or method this parameter was defined in. */
        public uint nameIndex;
        public short constraintsStart;
        public short constraintsCount;
        public ushort num;
        public ushort flags;
    }

    public enum Il2CppRGCTXDataType
    {
        IL2CPP_RGCTX_DATA_INVALID,
        IL2CPP_RGCTX_DATA_TYPE,
        IL2CPP_RGCTX_DATA_CLASS,
        IL2CPP_RGCTX_DATA_METHOD,
        IL2CPP_RGCTX_DATA_ARRAY,
        IL2CPP_RGCTX_DATA_CONSTRAINED,
    }

    public class Il2CppRGCTXDefinitionData
    {
        public int rgctxDataDummy;
        public int methodIndex => rgctxDataDummy;
        public int typeIndex => rgctxDataDummy;
    }

    public class Il2CppRGCTXDefinition
    {
        public Il2CppRGCTXDataType type => type_post29 == 0 ? (Il2CppRGCTXDataType)type_pre29 : (Il2CppRGCTXDataType)type_post29;
        [Version(Max = 27.1)]
        public int type_pre29;
        [Version(Min = 29)]
        public ulong type_post29;
        [Version(Max = 27.1)]
        public Il2CppRGCTXDefinitionData data;
        [Version(Min = 27.2)]
        public ulong _data;
    }

    public enum Il2CppMetadataUsage
    {
        kIl2CppMetadataUsageInvalid,
        kIl2CppMetadataUsageTypeInfo,
        kIl2CppMetadataUsageIl2CppType,
        kIl2CppMetadataUsageMethodDef,
        kIl2CppMetadataUsageFieldInfo,
        kIl2CppMetadataUsageStringLiteral,
        kIl2CppMetadataUsageMethodRef,
    };

    public class Il2CppCustomAttributeDataRange
    {
        public uint token;
        public uint startOffset;
    }
}
