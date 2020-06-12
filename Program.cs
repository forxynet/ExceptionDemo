using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo {
    class Program {
        static void Main(string[] args) {
            Student newStudent = null;

            try {
                newStudent = new Student();
                newStudent.StudentName = "James007";

                ValidateStudent(newStudent);
            }
            catch (Exception ex) {

                switch (ex.GetType().Name) {
                    case "NotImplementedException":
                        Console.WriteLine("NotImplementedException");
                        break;
                    case "System.PrinterException":
                        Console.WriteLine("System.ArgumentNullException");
                        break;
                    default:
                        Console.WriteLine("Exception");
                        break;
                }
            }
        }

        private static void ValidateStudent(Student newStudent) {
            throw new NotImplementedException();
        }

       
    }
}
