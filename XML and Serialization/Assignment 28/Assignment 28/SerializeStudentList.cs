using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization;
using System.Collections.Generic;
namespace Assignment28
{
    static class SerilalizeStudentList
    {
        public static void Main()
        {
            //creating list of students and adding objects to it
            List<Student> students = new List<Student>();
            Student studentOne = new Student();
            studentOne.RollNo = 1;
            studentOne.Name = "Preeti";
            studentOne.TotalMarks = 65;
            students.Add(studentOne);
            Student studentTwo = new Student();
            studentTwo.RollNo = 2;
            studentTwo.Name = "Kabir";
            studentTwo.TotalMarks = 80;
            students.Add(studentTwo);
            //initialising file for each of binary,xml ans soap files
            string fileBinary = Path.GetFullPath(@"..\..\SerializationData\iCalibrator.dat");
            string fileXml = Path.GetFullPath(@"..\..\SerializationData\iCalibrator.xml");
            string fileSoap = Path.GetFullPath(@"..\..\SerializationData\iCalibrator.soap");
            int ch;
            try
            {
                do
                {
                    Console.WriteLine("...........\n");
                    Console.WriteLine("1.Serialize using Binary");
                    Console.WriteLine("2.Deserialize using Binary");
                    Console.WriteLine("3.Serialize using Xml");
                    Console.WriteLine("4.Deserialize using Xml");
                    Console.WriteLine("5.Serialize using Soap");
                    Console.WriteLine("6.Deserialize using Soap");
                    Console.WriteLine("7.Exit");
                    Console.WriteLine("Enter your choice");
                    ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1: SerializeBinary(students, fileBinary);
                            break;
                        case 2: DeSerializeBinary(fileBinary);
                            break;
                        case 3: SerializeXml(students, fileXml);
                            break;
                        case 4: DeSerializeXml(fileXml);
                            break;
                        case 5: SerializeSoap(students, fileSoap);
                            break;
                        case 6: DeSerializeSoap(fileSoap);
                            break;
                        case 7: Console.WriteLine("...Task Completed...");
                            break;
                        default: Console.WriteLine("Wrong choice please enter again");
                            break;
                    }
                } while (ch != 7);
            }
            catch (FormatException e)
            {
                Console.WriteLine(" Number Format Exception: " + e.Message);
            }
            Console.Read();
        }
        //<summary>
        //method for binary serialization
        //</summary>

        private static void SerializeBinary(List<Student> students, string filename)
        {
            try
            {
                //Format the object as Binary
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                //Create the stream to add object into it.
                using (Stream addStudentContent = File.OpenWrite(filename))
                {
                    //It serialize the student object
                    binaryFormatter.Serialize(addStudentContent, students);
                    addStudentContent.Flush();
                }
                Console.WriteLine("After Serialization-->\n");
                foreach (Student student in students)
                {
                    Console.WriteLine("Rollno : {0}\nName : {1}\nTotalMarks : {2}\nGrade : {3} \n", student.RollNo, student.Name, student.TotalMarks, student.Grade);
                }
            }
            catch (SerializationException ex)
            {
                Console.WriteLine("Serialization Error: " + ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        //<summary>
        //method for binary deserialization
        //</summary>

        private static void DeSerializeBinary(string filename)
        {
            try
            {
                //Format the object as Binary
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                //Reading the file from the server
                using (FileStream readStudentContent = File.Open(filename, FileMode.Open))
                {
                    object obj = binaryFormatter.Deserialize(readStudentContent);
                    List<Student> students = (List<Student>)obj;
                    readStudentContent.Flush();
                    Console.WriteLine("After DeSerialization-->\n");
                    foreach (Student student in students)
                    {
                        Console.WriteLine("Rollno : {0}\nName : {1}\nTotalMarks : {2}\nGrade : {3} \n", student.RollNo, student.Name, student.TotalMarks, student.Grade);
                    }
                }
            }
            catch (SerializationException ex)
            {
                Console.WriteLine("Serialization Error: " + ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        //<summary>
        //method for xml serialization
        //</summary>

        private static void SerializeXml(List<Student> students, string fileName)
        {
            try
            {
                //Format the object as Xml
                XmlSerializer xmlFormatter = new XmlSerializer(typeof(List<Student>));
                //Creating textwriter to add object into it
                using (TextWriter writeStudentContent = new StreamWriter(fileName))
                {
                    //serialize student object
                    xmlFormatter.Serialize(writeStudentContent, students);
                    writeStudentContent.Flush();
                }
                Console.WriteLine("After Serialization-->\n");
                  foreach (Student student in students)
                {
                    Console.WriteLine("Rollno : {0}\nName : {1}\nTotalMarks : {2}\nGrade : {3} \n", student.RollNo, student.Name, student.TotalMarks, student.Grade);
                }
            }
            catch (SerializationException ex)
            {
                Console.WriteLine("Serialization Error: " + ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        //<summary>
        //method for xml deserialization
        //</summary>

        private static void DeSerializeXml(string filename)
        {
            try
            {
                //Format the object as Xml
                XmlSerializer xmlFormatter = new XmlSerializer(typeof(List<Student>));
                //Reading the files from Server
                using (TextReader readStudentContent = new StreamReader(filename))
                {
                    object obj = xmlFormatter.Deserialize(readStudentContent);
                    List<Student> students = (List<Student>)obj;
                    Console.WriteLine("After DeSerialization-->\n");
                    foreach (Student student in students)
                    {
                        Console.WriteLine("Rollno : {0}\nName : {1}\nTotalMarks : {2}\nGrade : {3} \n", student.RollNo, student.Name, student.TotalMarks, student.Grade);
                    }
                }
            }
            catch (SerializationException ex)
            {
                Console.WriteLine("Serialization Error: " + ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        //<summary>
        //method for soap serialization
        //</summary>

        private static void SerializeSoap(List<Student> students, string filename)
        {
            Student[] studentArray = students.ToArray();
            try
            {
                SoapFormatter soapFormatter = new SoapFormatter();
                //Create the stream to add object into it.
                using (FileStream writeStudentContent = File.OpenWrite(filename))
                {
                    //It serialize the student object
                    soapFormatter.Serialize(writeStudentContent, studentArray);
                    writeStudentContent.Flush();
                }
                Console.WriteLine("After Serialization-->\n");
                for (int i = 0; i < studentArray.Length; i++)
                {
                    Console.WriteLine("Rollno : {0}\nName : {1}\nTotalMarks : {2}\nGrade : {3} \n", studentArray[i].RollNo, studentArray[i].Name, studentArray[i].TotalMarks, studentArray[i].Grade);
                }
            }
            catch (SerializationException ex)
            {
                Console.WriteLine("Serialization Error: " + ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        //</summary>
        //method for soap deserialization
        //</sumaary>

        private static void DeSerializeSoap(string filename)
        {
            try
            {
                //Format the object as Binary
                SoapFormatter soapFormatter = new SoapFormatter();
                //Reading the file from the server
                using (FileStream readStudentContent = File.Open(filename, FileMode.Open))
                {
                    Student[] studentArray = (Student[])soapFormatter.Deserialize(readStudentContent);
                    readStudentContent.Flush();
                    Console.WriteLine("After DeSerialization-->\n");
                    for (int i = 0; i < studentArray.Length; i++)
                    {
                        Console.WriteLine("Rollno : {0}\nName : {1}\nTotalMarks : {2}\nGrade : {3} \n", studentArray[i].RollNo, studentArray[i].Name, studentArray[i].TotalMarks, studentArray[i].Grade);
                    }
                }
            }
            catch (SerializationException ex)
            {
                Console.WriteLine("Serialization Error: " + ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
