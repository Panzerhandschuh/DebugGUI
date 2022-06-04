using System;

namespace WeaverDev
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class DebugGUIPrintAttribute : Attribute { }
}