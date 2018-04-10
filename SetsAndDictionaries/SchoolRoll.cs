using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetsAndDictionaries
{
    public class SchoolRoll
    {
        private HashSet<Student> _students = new HashSet<Student>();

        public IEnumerable<Student> Students { get { return _students; } }  //make it virtually read only

        //public void AddStudents(List<Student> students)
        public void AddStudents(IEnumerable<Student> students)
        {
            _students.UnionWith(students);
        }
    }
}
