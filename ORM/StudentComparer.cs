using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    internal class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student? x, Student? y)
        {
            return x?.Id == y?.Id && x?.FName == y?.FName;
        }

        public int GetHashCode([DisallowNull] Student obj)
        {
            return HashCode.Combine(obj.Id, obj.FName);
        }
    }
}
