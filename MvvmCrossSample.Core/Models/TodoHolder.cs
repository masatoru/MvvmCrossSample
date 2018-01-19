using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmCrossSample.Core.Models
{
    public class TodoHolder
    {
        public static TodoHolder Current { get; } = new TodoHolder();
        public List<Todo> TodoList { get; }=new List<Todo>();
    }
}
