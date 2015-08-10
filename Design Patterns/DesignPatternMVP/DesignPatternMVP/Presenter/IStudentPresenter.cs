using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternMVP.Model;
using DesignPatternMVP.View;
namespace DesignPatternMVP.Presenter
{
    interface IStudentPresenter
    {
        /// <summary>  
        /// Load Data into presenter  
        /// </summary>  
        void LoadData(StudentModel studentModel, IStudentView studentPresenter);  
    }
}
