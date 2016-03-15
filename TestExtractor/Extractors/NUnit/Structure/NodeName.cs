using System;
using NUnit.Core;

namespace TestExtractor.Extractors.NUnit.Structure
{
    /// <summary>
    ///     Concrete implementation of the Node Name Interface
    ///     Inherits Class : <see cref="TestExtractor.Structure.NodeName" />
    /// </summary>
    [Serializable]
    public sealed class NodeName : TestExtractor.Structure.NodeName
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="NodeName" /> class.
        /// </summary>
        public NodeName ()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="NodeName" /> class.
        /// </summary>
        public NodeName (ITest tNode)
        {
            FullName = ReplaceQuotes(tNode.TestName.FullName);
            Name = ReplaceQuotes(tNode.TestName.Name);
            UniqueName = ReplaceQuotes(tNode.TestName.UniqueName);
        }

        private static string ReplaceQuotes (string input)
        {
            // this is necessary for test cases which contains a string as a parameter
            return input.Replace("\"", "\\\"");
        }
    }
}