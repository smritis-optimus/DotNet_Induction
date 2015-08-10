using DesignPatternMVP.Presenter;

namespace DesignPatternMVP.View
{
    /// <summary>
    /// creating an interface for view
    /// </summary>
   public interface IStudentView
    {
        string Name { get; set; }
        int Age { get; set; }
        int Rollno { get; set; }
        string Branch { get; set; }
        /// <summary>  
        /// Load Data into model 
        /// </summary>  
        void LoadView();
    }
}
