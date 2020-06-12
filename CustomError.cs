using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo {
    class Student {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
    }

    [Serializable]
    class InvalidStudentNameException : SystemException {
        public InvalidStudentNameException() {

        }

        public InvalidStudentNameException(string name)
            : base(String.Format("Invalid Student Name: {0}", name)) {

        }

    }
}
