using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterTwelfth.Code
{
    /// <summary>
    /// 泛型类型 和继承
    /// </summary>
    public class GenericExtends
    {
    }

    /// <summary>
    /// Node基类
    /// </summary>
    public class Node
    {
        protected Node m_next;
        public Node(Node next)
        {
            m_next = next;
        }
    }

    /// <summary>
    /// 泛型类型继承基类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class NodeType<T> : Node
    {
        public T m_data;
        public NodeType(T data, Node next) : base(next)
        {
            m_data = data;
        }
        public NodeType(T data) : this(data, null)
        { }

        public override string ToString()
        {
            return m_data.ToString() + ((m_next != null) ? m_next.ToString() : null);
        }
    }


}
