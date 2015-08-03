function GetStudentById() {
    var id = document.getElementById('txtId').value;
    Assignment31.StudentRecord.GetStudentByID(id, GetStudentByIdSuccessCallBack, GetStudentByIdFailedCallBack);
}
function GetStudentByIdSuccessCallBack(result) {
    document.getElementById('txtName').value = result["Name"];
    document.getElementById('txtGender').value = result["Gender"];
    document.getElementById('txtAge').value = result["Age"];
    document.getElementById('txtStream').value = result["Stream"];
}
function GetStudentByIdFailedCallBack(error) {
    alert(error.get_message());
}