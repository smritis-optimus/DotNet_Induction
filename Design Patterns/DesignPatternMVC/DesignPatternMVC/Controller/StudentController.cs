namespace DesignPatternMVC.Controller
{
    /// <summary>
    /// controller of student
    /// </summary>
    public class StudentController
    {
        private Model.StudentModel Model;
        private View.StudentView View;
        /// <summary>
        /// constructor intializes the components model and view
        /// </summary>
        /// <param name="paramModel">Student Model</param>
        /// <param name="paramView">Student View</param>
        public StudentController(Model.StudentModel paramModel, View.StudentView paramView)
        {
            Model = paramModel;
            View = paramView;
        }
        public void InitializedComponent(bool ispostback)
        {
            if (!ispostback)
                View.InitializedView(Model);
        }
        public StudentController()
        {
        }
        /// <summary>
        /// send the request to update the model
        /// </summary>
        /// <param name="view"></param>
        public void RequestUpdate(View.StudentView view)
        {
            if (Model != null)
            {
                Model.UpdateModel(view.Name, view.Rollno, view.Age, view.Branch);
            }
        }
    }

}