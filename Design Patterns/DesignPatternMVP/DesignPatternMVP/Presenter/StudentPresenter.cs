using System.Collections.Generic;
using DesignPatternMVP.View;
using DesignPatternMVP.Model;
namespace DesignPatternMVP.Presenter
{
    /// <summary>
    ///  Creating a Presenter class for collecting user inputs from View 
    ///  and pass view details to the Model
    /// </summary>
    public class StudentPresenter:IStudentPresenter
    {
      List<StudentModel> students=new List<StudentModel>();
        IStudentView newStudent;
        /// <summary>
        /// collecting inputs from view
        /// </summary>
        /// <param name="student"></param>
        public StudentPresenter(IStudentView student)
        {
            newStudent=student;
        }
        /// <summary>
        /// passing detils in model
        /// </summary>
        public void LoadStudentUI()
        {
            StudentModel model = new StudentModel();
            LoadData(model, newStudent);
            students.Add(model);
        }
        /// <summary>
        /// Returning list of students to view
        /// </summary>
        /// <returns></returns>
        public List<StudentModel> GetStudents()
        {
            return students;
        }

        /// <summary>
        /// loading values in model
        /// </summary>
        /// <param name="studentModel">model</param>
        /// <param name="studentPresenter">presenter</param>
        public void LoadData(StudentModel studentModel, IStudentView studentPresenter)
        {
            studentModel.Name = studentPresenter.Name;
            studentModel.Age = studentPresenter.Age;
            studentModel.Rollno = studentPresenter.Rollno;
            studentModel.Branch = studentPresenter.Branch;
        }
    }
}