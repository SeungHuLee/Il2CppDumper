using System;
using System.Runtime.InteropServices;

namespace Il2CppDumper
{
    [StructLayout(LayoutKind.Explicit)]
    public class Il2CppCodeRegistration
    {
        [FieldOffset(0)] public uint reversePInvokeWrapperCount;
        [FieldOffset(4)] public uint padding0;
        [FieldOffset(8)] public ulong reversePInvokeWrappers;           // Il2CppMethodPointer* -> ulong

        [FieldOffset(16)] public uint genericMethodPointersCount;
        [FieldOffset(20)] public uint padding1;
        [FieldOffset(24)] public ulong genericMethodPointers;            // Il2CppMethodPointer* -> ulong
        [FieldOffset(32)] public ulong genericAdjustorThunks;            // Il2CppMethodPointer* -> ulong

        [FieldOffset(40)] public uint invokerPointersCount;
        [FieldOffset(44)] public uint padding2;
        [FieldOffset(48)] public ulong invokerPointers;                  // InvokerMethod* -> ulong

        [FieldOffset(56)] public uint unresolvedVirtualCallCount;
        [FieldOffset(60)] public uint padding3;
        [FieldOffset(64)] public ulong unresolvedVirtualCallPointers;    // Il2CppMethodPointer* -> ulong

        [FieldOffset(72)] public uint interopDataCount;
        [FieldOffset(76)] public uint padding4;
        [FieldOffset(84)] public ulong interopData;                      // Il2CppInteropData* -> ulong

        [FieldOffset(92)] public uint windowsRuntimeFactoryCount;
        [FieldOffset(96)] public uint padding5;
        [FieldOffset(100)] public ulong windowsRuntimeFactoryTable;       // Il2CppWindowsRuntimeFactoryTableEntry* -> ulong

        [FieldOffset(108)] public uint codeGenModulesCount;
        [FieldOffset(112)] public uint padding6;
        [FieldOffset(116)] public ulong codeGenModules;                   // Il2CppCodeGenModule** -> ulong
    }

    [StructLayout(LayoutKind.Explicit)]
    public class Il2CppCodeGenModule
    {
        [FieldOffset(0)] public ulong moduleName;                          // const char* -> ulong
        [FieldOffset(8)] public uint methodPointerCount;
        [FieldOffset(12)] public uint padding0;
        [FieldOffset(16)] public ulong methodPointers;                      // const Il2CppMethodPointer* -> ulong
        [FieldOffset(24)] public uint adjustorThunkCount;
        [FieldOffset(28)] public uint padding1;
        [FieldOffset(32)] public ulong adjustorThunks;                      // const Il2CppTokenAdjustorThunkPair* -> ulong
        [FieldOffset(40)] public ulong invokerIndices;                      // const int32_t* -> ulong
        [FieldOffset(48)] public uint reversePInvokeWrapperCount;
        [FieldOffset(52)] public uint padding2;
        [FieldOffset(56)] public ulong reversePInvokeWrapperIndices;        // const Il2CppTokenIndexMethodTuple* -> ulong
        [FieldOffset(64)] public uint rgctxRangesCount;
        [FieldOffset(68)] public uint padding3;
        [FieldOffset(72)] public ulong rgctxRanges;                         // const Il2CppTokenRangePair* -> ulong
        [FieldOffset(80)] public uint rgctxsCount;
        [FieldOffset(84)] public uint padding4;
        [FieldOffset(88)] public ulong rgctxs;                              // const Il2CppRGCTXDefinition* -> ulong
        [FieldOffset(96)] public ulong debuggerMetadata;                    // const Il2CppDebuggerMetadataRegistration* -> ulong
        [FieldOffset(114)] public ulong moduleInitializer;                   // const Il2CppMethodPointer -> ulong
        [FieldOffset(122)] public ulong staticConstructorTypeIndices;        // TypeDefinitionIndex* -> ulong
        [FieldOffset(130)] public ulong metadataRegistration;                // const Il2CppMetadataRegistration* -> ulong
        [FieldOffset(138)] public ulong codeRegistaration;                   // const Il2CppCodeRegistration* -> ulong
    }

    [StructLayout(LayoutKind.Explicit)]
    public class Il2CppMetadataRegistration
    {
        [FieldOffset(0)] public int genericClassesCount;
        [FieldOffset(4)] public int padding0;
        [FieldOffset(8)] public ulong genericClasses;              // Il2CppGenericClass** -> ulong

        [FieldOffset(16)] public int genericInstsCount;
        [FieldOffset(20)] public int padding1;
        [FieldOffset(24)] public ulong genericInsts;                // Il2CppGenericInst** -> ulong

        [FieldOffset(32)] public int genericMethodTableCount;
        [FieldOffset(36)] public int padding2;
        [FieldOffset(40)] public ulong genericMethodTable;          // Il2CppGenericMethodFunctionsDefinitions* -> ulong

        [FieldOffset(48)] public int typesCount;
        [FieldOffset(52)] public int padding3;
        [FieldOffset(56)] public ulong types;                       // Il2CppType** -> ulong

        [FieldOffset(64)] public int methodSpecsCount;
        [FieldOffset(68)] public int padding4;
        [FieldOffset(72)] public ulong methodSpecs;                 // Il2CppMethodSpec* -> ulong

        [FieldOffset(80)] public int fieldOffsetsCount;
        [FieldOffset(84)] public int padding5;
        [FieldOffset(88)] public ulong fieldOffsets;                // int32_t** -> ulong

        [FieldOffset(96)] public int typeDefinitionsSizesCount;
        [FieldOffset(100)] public int padding6;
        [FieldOffset(104)] public ulong typeDefinitionsSizes;        // Il2CppTypeDefinitionSizes** -> ulong

        [FieldOffset(112)] public ulong metadataUsagesCount;         // size_t -> ulong (safe for both 32/64 bit)
        [FieldOffset(120)] public ulong metadataUsages;              // void*** -> ulong
    }

    public enum Il2CppTypeEnum
    {
        IL2CPP_TYPE_END = 0x00,       /* End of List */
        IL2CPP_TYPE_VOID = 0x01,
        IL2CPP_TYPE_BOOLEAN = 0x02,
        IL2CPP_TYPE_CHAR = 0x03,
        IL2CPP_TYPE_I1 = 0x04,
        IL2CPP_TYPE_U1 = 0x05,
        IL2CPP_TYPE_I2 = 0x06,
        IL2CPP_TYPE_U2 = 0x07,
        IL2CPP_TYPE_I4 = 0x08,
        IL2CPP_TYPE_U4 = 0x09,
        IL2CPP_TYPE_I8 = 0x0a,
        IL2CPP_TYPE_U8 = 0x0b,
        IL2CPP_TYPE_R4 = 0x0c,
        IL2CPP_TYPE_R8 = 0x0d,
        IL2CPP_TYPE_STRING = 0x0e,
        IL2CPP_TYPE_PTR = 0x0f,       /* arg: <type> token */
        IL2CPP_TYPE_BYREF = 0x10,       /* arg: <type> token */
        IL2CPP_TYPE_VALUETYPE = 0x11,       /* arg: <type> token */
        IL2CPP_TYPE_CLASS = 0x12,       /* arg: <type> token */
        IL2CPP_TYPE_VAR = 0x13,       /* Generic parameter in a generic type definition, represented as number (compressed unsigned integer) number */
        IL2CPP_TYPE_ARRAY = 0x14,       /* type, rank, boundsCount, bound1, loCount, lo1 */
        IL2CPP_TYPE_GENERICINST = 0x15,     /* <type> <type-arg-count> <type-1> \x{2026} <type-n> */
        IL2CPP_TYPE_TYPEDBYREF = 0x16,
        IL2CPP_TYPE_I = 0x18,
        IL2CPP_TYPE_U = 0x19,
        IL2CPP_TYPE_FNPTR = 0x1b,        /* arg: full method signature */
        IL2CPP_TYPE_OBJECT = 0x1c,
        IL2CPP_TYPE_SZARRAY = 0x1d,       /* 0-based one-dim-array */
        IL2CPP_TYPE_MVAR = 0x1e,       /* Generic parameter in a generic method definition, represented as number (compressed unsigned integer)  */
        IL2CPP_TYPE_CMOD_REQD = 0x1f,       /* arg: typedef or typeref token */
        IL2CPP_TYPE_CMOD_OPT = 0x20,       /* optional arg: typedef or typref token */
        IL2CPP_TYPE_INTERNAL = 0x21,       /* CLR internal type */

        IL2CPP_TYPE_MODIFIER = 0x40,       /* Or with the following types */
        IL2CPP_TYPE_SENTINEL = 0x41,       /* Sentinel for varargs method signature */
        IL2CPP_TYPE_PINNED = 0x45,       /* Local var that points to pinned object */

        IL2CPP_TYPE_ENUM = 0x55,        /* an enumeration */
        IL2CPP_TYPE_IL2CPP_TYPE_INDEX = 0xff        /* an index into IL2CPP type metadata table */
    }

    public class Il2CppType
    {
        public ulong datapoint;
        public uint bits;
        public Union data { get; set; }
        public uint attrs { get; set; }
        public Il2CppTypeEnum type { get; set; }
        public uint num_mods { get; set; }
        public uint byref { get; set; }
        public uint pinned { get; set; }
        public uint valuetype { get; set; }

        public void Init(double version)
        {
            attrs = bits & 0xffff;
            type = (Il2CppTypeEnum)((bits >> 16) & 0xff);
            if (version >= 27.2)
            {
                num_mods = (bits >> 24) & 0x1f;
                byref = (bits >> 29) & 1;
                pinned = (bits >> 30) & 1;
                valuetype = bits >> 31;
            }
            else
            {
                num_mods = (bits >> 24) & 0x3f;
                byref = (bits >> 30) & 1;
                pinned = bits >> 31;
            }
            data = new Union { dummy = datapoint };
        }

        public class Union
        {
            public ulong dummy;
            /// <summary>
            /// for VALUETYPE and CLASS
            /// </summary>
            public long klassIndex => (long)dummy;
            /// <summary>
            /// for VALUETYPE and CLASS at runtime
            /// </summary>
            public ulong typeHandle => dummy;
            /// <summary>
            /// for PTR and SZARRAY
            /// </summary>
            public ulong type => dummy;
            /// <summary>
            /// for ARRAY
            /// </summary>
            public ulong array => dummy;
            /// <summary>
            /// for VAR and MVAR
            /// </summary>
            public long genericParameterIndex => (long)dummy;
            /// <summary>
            /// for VAR and MVAR at runtime
            /// </summary>
            public ulong genericParameterHandle => dummy;
            /// <summary>
            /// for GENERICINST
            /// </summary>
            public ulong generic_class => dummy;
        }
    }

    public class Il2CppGenericClass
    {
        [Version(Max = 24.5)]
        public long typeDefinitionIndex;    /* the generic type definition */
        [Version(Min = 27)]
        public ulong type;        /* the generic type definition */
        public Il2CppGenericContext context;   /* a context that contains the type instantiation doesn't contain any method instantiation */
        public ulong cached_class; /* if present, the Il2CppClass corresponding to the instantiation.  */
    }

    public class Il2CppGenericContext
    {
        /* The instantiation corresponding to the class generic parameters */
        public ulong class_inst;
        /* The instantiation corresponding to the method generic parameters */
        public ulong method_inst;
    }

    public class Il2CppGenericInst
    {
        public long type_argc;
        public ulong type_argv;
    }

    public class Il2CppArrayType
    {
        public ulong etype;
        public byte rank;
        public byte numsizes;
        public byte numlobounds;
        public ulong sizes;
        public ulong lobounds;
    }

    public class Il2CppGenericMethodFunctionsDefinitions
    {
        public int genericMethodIndex;
        public Il2CppGenericMethodIndices indices;
    }

    public class Il2CppGenericMethodIndices
    {
        public int methodIndex;
        public int invokerIndex;
        [Version(Min = 24.5, Max = 24.5)]
        [Version(Min = 27.1)]
        public int adjustorThunk;
    };

    public class Il2CppMethodSpec
    {
        public int methodDefinitionIndex;
        public int classIndexIndex;
        public int methodIndexIndex;
    };

    public class Il2CppRange
    {
        public int start;
        public int length;
    }

    public class Il2CppTokenRangePair
    {
        public uint token;
        public Il2CppRange range;
    }
}
