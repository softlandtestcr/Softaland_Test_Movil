extern alias System_Runtime_Extensions;
namespace System.Runtime.CompilerServices {
    internal class __BlockReflectionAttribute : Attribute { }
}

namespace Microsoft.Xml.Serialization.GeneratedAssembly {


    [System.Runtime.CompilerServices.__BlockReflection]
    public class XmlSerializationWriter1 : System.Xml.Serialization.XmlSerializationWriter {

        public void Write3_anyType(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"anyType", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace1 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write1_Object(@"anyType", namespace1, ((global::System.Object)o), true, false, namespace1, @"");
        }

        public void Write4_Tarea(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"Tarea", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace2 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write2_Tarea(@"Tarea", namespace2, ((global::SoftlandApiTest.ModelTask.Tarea)o), true, false, namespace2, @"");
        }

        public void Write5_anyType(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"anyType", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace3 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write1_Object(@"anyType", namespace3, ((global::System.Object)o), true, false, namespace3, @"");
        }

        void Write1_Object(string n, string ns, global::System.Object o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Object)) {
                }
                else {
                    if (t == typeof(global::SoftlandApiTest.ModelTask.Tarea)) {
                        Write2_Tarea(n, ns,(global::SoftlandApiTest.ModelTask.Tarea)o, isNullable, true);
                        return;
                    }
                    WriteTypedPrimitive(n, ns, o, true);
                    return;
                }
            }
            WriteStartElement(n, ns, o, false, null);
            WriteEndElement(o);
        }

        void Write2_Tarea(string n, string ns, global::SoftlandApiTest.ModelTask.Tarea o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::SoftlandApiTest.ModelTask.Tarea)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Tarea", defaultNamespace);
            string namespace4 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"id", namespace4, ((global::System.String)o.@id));
            string namespace5 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"name", namespace5, ((global::System.String)o.@name));
            string namespace6 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"notes", namespace6, ((global::System.String)o.@notes));
            string namespace7 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"done", namespace7, System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@done)));
            WriteEndElement(o);
        }

        protected override void InitCallbacks() {
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public class XmlSerializationReader1 : System.Xml.Serialization.XmlSerializationReader {

        public object Read3_anyType(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id1_anyType && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read1_Object(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":anyType");
            }
            return (object)o;
        }

        public object Read4_Tarea(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id3_Tarea && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read2_Tarea(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":Tarea");
            }
            return (object)o;
        }

        public object Read5_anyType(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id1_anyType && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read1_Object(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":anyType");
            }
            return (object)o;
        }

        global::System.Object Read1_Object(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
                if (isNull) {
                    if (xsiType != null) return (global::System.Object)ReadTypedNull(xsiType);
                    else return null;
                }
                if (xsiType == null) {
                    return ReadTypedPrimitive(new System.Xml.XmlQualifiedName("anyType", "http://www.w3.org/2001/XMLSchema"));
                }
                else {
                    if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id3_Tarea && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                        return Read2_Tarea(isNullable, false, defaultNamespace);
                    return ReadTypedPrimitive((System.Xml.XmlQualifiedName)xsiType);
                }
            }
            if (isNull) return null;
            global::System.Object o;
            o = new global::System.Object();
            bool[] paramsRead = new bool[0];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations0 = 0;
            int readerCount0 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations0, ref readerCount0);
            }
            ReadEndElement();
            return o;
        }

        global::SoftlandApiTest.ModelTask.Tarea Read2_Tarea(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id3_Tarea && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::SoftlandApiTest.ModelTask.Tarea o;
            o = new global::SoftlandApiTest.ModelTask.Tarea();
            bool[] paramsRead = new bool[4];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations1 = 0;
            int readerCount1 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id4_id && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@id = Reader.ReadElementContentAsString();
                        }
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id5_name && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@name = Reader.ReadElementContentAsString();
                        }
                        paramsRead[1] = true;
                    }
                    else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id6_notes && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@notes = Reader.ReadElementContentAsString();
                        }
                        paramsRead[2] = true;
                    }
                    else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id7_done && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@done = System.Xml.XmlConvert.ToBoolean(Reader.ReadElementContentAsString());
                        }
                        paramsRead[3] = true;
                    }
                    else {
                        UnknownNode((object)o, @":id, :name, :notes, :done");
                    }
                }
                else {
                    UnknownNode((object)o, @":id, :name, :notes, :done");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations1, ref readerCount1);
            }
            ReadEndElement();
            return o;
        }

        protected override void InitCallbacks() {
        }

        string id7_done;
        string id4_id;
        string id3_Tarea;
        string id6_notes;
        string id2_Item;
        string id5_name;
        string id1_anyType;

        protected override void InitIDs() {
            id7_done = Reader.NameTable.Add(@"done");
            id4_id = Reader.NameTable.Add(@"id");
            id3_Tarea = Reader.NameTable.Add(@"Tarea");
            id6_notes = Reader.NameTable.Add(@"notes");
            id2_Item = Reader.NameTable.Add(@"");
            id5_name = Reader.NameTable.Add(@"name");
            id1_anyType = Reader.NameTable.Add(@"anyType");
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public abstract class XmlSerializer1 : System.Xml.Serialization.XmlSerializer {
        protected override System.Xml.Serialization.XmlSerializationReader CreateReader() {
            return new XmlSerializationReader1();
        }
        protected override System.Xml.Serialization.XmlSerializationWriter CreateWriter() {
            return new XmlSerializationWriter1();
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public sealed class ObjectSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"anyType", this.DefaultNamespace ?? @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write3_anyType(objectToSerialize, this.DefaultNamespace, @"");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read3_anyType(this.DefaultNamespace);
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public sealed class TareaSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"Tarea", this.DefaultNamespace ?? @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write4_Tarea(objectToSerialize, this.DefaultNamespace, @"");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read4_Tarea(this.DefaultNamespace);
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public class XmlSerializerContract : global::System.Xml.Serialization.XmlSerializerImplementation {
        public override global::System.Xml.Serialization.XmlSerializationReader Reader { get { return new XmlSerializationReader1(); } }
        public override global::System.Xml.Serialization.XmlSerializationWriter Writer { get { return new XmlSerializationWriter1(); } }
        System_Runtime_Extensions::System.Collections.Hashtable readMethods = null;
        public override System_Runtime_Extensions::System.Collections.Hashtable ReadMethods {
            get {
                if (readMethods == null) {
                    System_Runtime_Extensions::System.Collections.Hashtable _tmp = new System_Runtime_Extensions::System.Collections.Hashtable();
                    _tmp[@"System.Object::"] = @"Read3_anyType";
                    _tmp[@"SoftlandApiTest.ModelTask.Tarea::"] = @"Read4_Tarea";
                    _tmp[@"System.Object::"] = @"Read5_anyType";
                    if (readMethods == null) readMethods = _tmp;
                }
                return readMethods;
            }
        }
        System_Runtime_Extensions::System.Collections.Hashtable writeMethods = null;
        public override System_Runtime_Extensions::System.Collections.Hashtable WriteMethods {
            get {
                if (writeMethods == null) {
                    System_Runtime_Extensions::System.Collections.Hashtable _tmp = new System_Runtime_Extensions::System.Collections.Hashtable();
                    _tmp[@"System.Object::"] = @"Write3_anyType";
                    _tmp[@"SoftlandApiTest.ModelTask.Tarea::"] = @"Write4_Tarea";
                    _tmp[@"System.Object::"] = @"Write5_anyType";
                    if (writeMethods == null) writeMethods = _tmp;
                }
                return writeMethods;
            }
        }
        System_Runtime_Extensions::System.Collections.Hashtable typedSerializers = null;
        public override System_Runtime_Extensions::System.Collections.Hashtable TypedSerializers {
            get {
                if (typedSerializers == null) {
                    System_Runtime_Extensions::System.Collections.Hashtable _tmp = new System_Runtime_Extensions::System.Collections.Hashtable();
                    _tmp.Add(@"System.Object::", new ObjectSerializer());
                    _tmp.Add(@"SoftlandApiTest.ModelTask.Tarea::", new TareaSerializer());
                    if (typedSerializers == null) typedSerializers = _tmp;
                }
                return typedSerializers;
            }
        }
        public override System.Boolean CanSerialize(System.Type type) {
            if (type == typeof(global::System.Object)) return true;
            if (type == typeof(global::SoftlandApiTest.ModelTask.Tarea)) return true;
            if (type == typeof(global::System.Reflection.TypeInfo)) return true;
            return false;
        }
        public override System.Xml.Serialization.XmlSerializer GetSerializer(System.Type type) {
            if (type == typeof(global::System.Object)) return new ObjectSerializer();
            if (type == typeof(global::SoftlandApiTest.ModelTask.Tarea)) return new TareaSerializer();
            if (type == typeof(global::System.Object)) return new ObjectSerializer();
            return null;
        }
        public static global::System.Xml.Serialization.XmlSerializerImplementation GetXmlSerializerContract() { return new XmlSerializerContract(); }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public static class ActivatorHelper {
        public static object CreateInstance(System.Type type) {
            System.Reflection.TypeInfo ti = System.Reflection.IntrospectionExtensions.GetTypeInfo(type);
            foreach (System.Reflection.ConstructorInfo ci in ti.DeclaredConstructors) {
                if (!ci.IsStatic && ci.GetParameters().Length == 0) {
                    return ci.Invoke(null);
                }
            }
            return System.Activator.CreateInstance(type);
        }
    }
}
