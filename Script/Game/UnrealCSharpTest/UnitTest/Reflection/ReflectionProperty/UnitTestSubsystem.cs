using Script.CoreUObject;
using Script.Engine;

namespace Script.UnrealCSharpTest
{
    public partial class UUnitTestSubsystem
    {
        private void TestReflectionProperty()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            var PropertyActor = GetWorld().SpawnActor<ATestReflectionPropertyActor>(new FTransform());

            // Bool
            TestCoreSubsystem.TestEqual("ReflectionGetBoolProperty", PropertyActor.BoolValue, true);

            PropertyActor.BoolValue = false;

            TestCoreSubsystem.TestEqual("ReflectionSetBoolProperty", PropertyActor.BoolValue, false);

            // Int8
            TestCoreSubsystem.TestEqual("ReflectionGetInt8Property", PropertyActor.Int8Value, (sbyte)12);

            PropertyActor.Int8Value = 21;

            TestCoreSubsystem.TestEqual("ReflectionSetInt8Property", PropertyActor.Int8Value, (sbyte)21);

            // Int16
            TestCoreSubsystem.TestEqual("ReflectionGetInt16Property", PropertyActor.Int16Value, (short)12);

            PropertyActor.Int16Value = 21;

            TestCoreSubsystem.TestEqual("ReflectionSetInt16Property", PropertyActor.Int16Value, (short)21);

            // Int32
            TestCoreSubsystem.TestEqual("ReflectionGetInt32Property", PropertyActor.Int32Value, (int)12);

            PropertyActor.Int32Value = 21;

            TestCoreSubsystem.TestEqual("ReflectionSetInt32Property", PropertyActor.Int32Value, (int)21);

            // Int64
            TestCoreSubsystem.TestEqual("ReflectionGetInt64Property", PropertyActor.Int64Value, (long)12);

            PropertyActor.Int64Value = 21;

            TestCoreSubsystem.TestEqual("ReflectionSetInt64Property", PropertyActor.Int64Value, (long)21);

            // UInt8
            TestCoreSubsystem.TestEqual("ReflectionGetUInt8Property", PropertyActor.UInt8Value, (byte)12);

            PropertyActor.UInt8Value = 21;

            TestCoreSubsystem.TestEqual("ReflectionSetUInt8Property", PropertyActor.UInt8Value, (byte)21);

            // UInt16
            TestCoreSubsystem.TestEqual("ReflectionGetUInt16Property", PropertyActor.UInt16Value, (ushort)12);

            PropertyActor.UInt16Value = 21;

            TestCoreSubsystem.TestEqual("ReflectionSetUInt16Property", PropertyActor.UInt16Value, (ushort)21);

            // UInt32
            TestCoreSubsystem.TestEqual("ReflectionGetUInt32Property", PropertyActor.UInt32Value, (uint)12);

            PropertyActor.UInt32Value = 21;

            TestCoreSubsystem.TestEqual("ReflectionSetUInt32Property", PropertyActor.UInt32Value, (uint)21);

            // UInt64
            TestCoreSubsystem.TestEqual("ReflectionGetUInt64Property", PropertyActor.UInt64Value, (ulong)12);

            PropertyActor.UInt64Value = 21;

            TestCoreSubsystem.TestEqual("ReflectionSetUInt64Property", PropertyActor.UInt64Value, (ulong)21);

            // Float
            TestCoreSubsystem.TestEqual("ReflectionGetFloatProperty", PropertyActor.FloatValue, 12.3f);

            PropertyActor.FloatValue = 3.21f;

            TestCoreSubsystem.TestEqual("ReflectionSetFloatProperty", PropertyActor.FloatValue, 3.21f);

            // Double
            TestCoreSubsystem.TestEqual("ReflectionGetDoubleProperty", PropertyActor.DoubleValue, 12.3);

            PropertyActor.DoubleValue = 3.21;

            TestCoreSubsystem.TestEqual("ReflectionSetDoubleProperty", PropertyActor.DoubleValue, 3.21);

            // FName
            TestCoreSubsystem.TestEqual("ReflectionGetNameProperty", PropertyActor.NameValue, "Name12");

            PropertyActor.NameValue = "21emaN";

            TestCoreSubsystem.TestEqual("ReflectionSetNameProperty", PropertyActor.NameValue, "21emaN");

            // FText
            TestCoreSubsystem.TestEqual("ReflectionGetTextProperty", PropertyActor.TextValue, "Text12");

            PropertyActor.TextValue = "21txeT";

            TestCoreSubsystem.TestEqual("ReflectionSetTextProperty", PropertyActor.TextValue, "21txeT");

            // FString
            TestCoreSubsystem.TestEqual("ReflectionGetStringProperty", PropertyActor.StringValue, "String12");

            PropertyActor.StringValue = "21gnirtS";

            TestCoreSubsystem.TestEqual("ReflectionSetStringProperty", PropertyActor.StringValue, "21gnirtS");

            // Enum
            TestCoreSubsystem.TestEqual("ReflectionGetEnumProperty", PropertyActor.EnumValue, ETestEnum.TestEnumOne);

            PropertyActor.EnumValue = ETestEnum.TestEnumTwo;

            TestCoreSubsystem.TestEqual("ReflectionSetEnumProperty", PropertyActor.EnumValue, ETestEnum.TestEnumTwo);

            // EnumClass
            TestCoreSubsystem.TestEqual("ReflectionGetEnumClassProperty", PropertyActor.EnumClassValue,
                ETestEnumClass.TestEnumClassOne);

            PropertyActor.EnumClassValue = ETestEnumClass.TestEnumClassTwo;

            TestCoreSubsystem.TestEqual("ReflectionSetEnumClassProperty", PropertyActor.EnumClassValue,
                ETestEnumClass.TestEnumClassTwo);

            // UStruct
            TestCoreSubsystem.TestEqual("ReflectionGetStructProperty", PropertyActor.StructValue,
                new FTestStruct { Value = 1 });

            PropertyActor.StructValue = new FTestStruct { Value = 2 };

            TestCoreSubsystem.TestEqual("ReflectionSetStructProperty", PropertyActor.StructValue,
                new FTestStruct { Value = 2 });

            // UObject
            TestCoreSubsystem.TestEqual("ReflectionGetObjectProperty", PropertyActor.ObjectValue, PropertyActor);

            PropertyActor.ObjectValue = this;

            TestCoreSubsystem.TestEqual("ReflectionSetObjectProperty", PropertyActor.ObjectValue, this);

            // UClass
            TestCoreSubsystem.TestEqual("ReflectionGetClassProperty", PropertyActor.ClassValue,
                PropertyActor.GetClass());

            PropertyActor.ClassValue = GetClass();

            TestCoreSubsystem.TestEqual("ReflectionSetClassProperty", PropertyActor.ClassValue, GetClass());

            // UInterface
            TestCoreSubsystem.TestEqual("ReflectionGetInterfaceProperty", PropertyActor.InterfaceValue,
                PropertyActor.InterfaceValue);

            PropertyActor.InterfaceValue = PropertyActor.InterfaceValue;

            TestCoreSubsystem.TestEqual("ReflectionSetInterfaceProperty", PropertyActor.InterfaceValue,
                PropertyActor.InterfaceValue);

            // TSubclassOf
            TestCoreSubsystem.TestEqual("ReflectionGetSubclassOfProperty", PropertyActor.SubclassOfValue,
                PropertyActor.GetClass());

            PropertyActor.SubclassOfValue = GetClass();

            TestCoreSubsystem.TestEqual("ReflectionSetSubclassOfProperty", PropertyActor.SubclassOfValue,
                GetClass());

            // TWeakObjectPtr
            TestCoreSubsystem.TestEqual("ReflectionGetWeakObjectPtrProperty", PropertyActor.WeakObjectPtrValue,
                PropertyActor);

            PropertyActor.WeakObjectPtrValue = this;

            TestCoreSubsystem.TestEqual("ReflectionSetWeakObjectPtrProperty", PropertyActor.WeakObjectPtrValue, this);

            // TLazyObjectPtr
            TestCoreSubsystem.TestEqual("ReflectionGetLazyObjectPtrProperty", PropertyActor.LazyObjectPtrValue,
                PropertyActor);

            PropertyActor.LazyObjectPtrValue = this;

            TestCoreSubsystem.TestEqual("ReflectionSetLazyObjectPtrProperty", PropertyActor.LazyObjectPtrValue, this);

            // TSoftObjectPtr
            TestCoreSubsystem.TestEqual("ReflectionGetSoftObjectPtrProperty", PropertyActor.SoftObjectPtrValue,
                PropertyActor);

            PropertyActor.SoftObjectPtrValue = this;

            TestCoreSubsystem.TestEqual("ReflectionSetSoftObjectPtrProperty", PropertyActor.SoftObjectPtrValue, this);

            // TSoftClassPtr
            TestCoreSubsystem.TestEqual("ReflectionGetSoftClassPtrProperty", PropertyActor.SoftClassPtrValue,
                PropertyActor.GetClass());

            PropertyActor.SoftClassPtrValue = GetClass();

            TestCoreSubsystem.TestEqual("ReflectionSetSoftClassPtrProperty", PropertyActor.SoftClassPtrValue,
                GetClass());

            // TArray
            TestCoreSubsystem.TestEqual("ReflectionGetArrayProperty", PropertyActor.ArrayValue,
                new TArray<int> { 1, 2 });

            PropertyActor.ArrayValue = new TArray<int> { 3, 4 };

            TestCoreSubsystem.TestEqual("ReflectionSetArrayProperty", PropertyActor.ArrayValue,
                new TArray<int> { 3, 4 });

            // TSet
            TestCoreSubsystem.TestEqual("ReflectionGetSetProperty", PropertyActor.SetValue,
                new TSet<int> { 1, 2 });

            PropertyActor.SetValue = new TSet<int> { 3, 4 };

            TestCoreSubsystem.TestEqual("ReflectionSetSetProperty", PropertyActor.SetValue,
                new TSet<int> { 3, 4 });

            // TMap
            TestCoreSubsystem.TestEqual("ReflectionGetMapProperty", PropertyActor.MapValue,
                new TMap<int, int> { { 1, 1 }, { 2, 2 } });

            PropertyActor.MapValue = new TMap<int, int> { { 3, 3 }, { 4, 4 } };

            TestCoreSubsystem.TestEqual("ReflectionSetMapProperty", PropertyActor.MapValue,
                new TMap<int, int> { { 3, 3 }, { 4, 4 } });
        }
    }
}