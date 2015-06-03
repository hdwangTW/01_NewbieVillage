using System.Text;

namespace LanguageBasics.Common
{
    internal abstract class InheritanceConstructorCallDemoClassBase
    {
        // ReSharper disable once InconsistentNaming
        protected readonly StringBuilder m_messageBuffer = new StringBuilder();

        public string ConstructorCallMessage
        {
            get { return m_messageBuffer.ToString(); }
        }

        protected InheritanceConstructorCallDemoClassBase()
        {
            m_messageBuffer.AppendLine("InheritanceConstructorCallDemoClassBase::Ctor()");
        }

        // ReSharper disable once UnusedParameter.Local
        protected InheritanceConstructorCallDemoClassBase(int arg)
        {
            m_messageBuffer.AppendLine("InheritanceConstructorCallDemoClassBase::Ctor(int)");
        }
    }

    internal class InheritanceConstructorCallDemoClass
        : InheritanceConstructorCallDemoClassBase
    {
        public InheritanceConstructorCallDemoClass()
        {
            m_messageBuffer.AppendLine("InheritanceConstructorCallDemoClass::Ctor()");      
        }

        // ReSharper disable once UnusedParameter.Local
        public InheritanceConstructorCallDemoClass(int arg)
        {
            m_messageBuffer.AppendLine("InheritanceConstructorCallDemoClass::Ctor(int)");
        }

        public InheritanceConstructorCallDemoClass(string arg)
            : base(int.Parse(arg))
        {
            m_messageBuffer.AppendLine("InheritanceConstructorCallDemoClass::Ctor(string)");
        }

        // ReSharper disable once UnusedParameter.Local
        public InheritanceConstructorCallDemoClass(int intArg, string strArg)
            : this(intArg)
        {
            m_messageBuffer.AppendLine("InheritanceConstructorCallDemoClass::Ctor(int, string)");
        }
    }
}