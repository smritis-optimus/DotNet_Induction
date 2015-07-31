//<summary>
//method for choosing answer1,2 or 4.when it is selected,answer 3 is set to false
//corresponding div background is changed
//</summary>
function CheckCommon(checkboxClicked,divClicked) {
    if (checkboxClicked.checked) {
        checkboxClicked.checked = false;
        divClicked.style.backgroundColor = "darkgrey";
       }
    else {
        checkboxClicked.checked = true;
        divClicked.style.backgroundColor = "orange";
        document.getElementById('cbOption3').checked = false;
        document.getElementById('dvOption3').style.backgroundColor = "darkgray";
    }
}
//<summary>
//method for choosing exclusive answer 3.When it is selected,all other checkbox is set to false
//corresponding div background is changed
//</summary>
function CheckExclusive(checkboxClicked,divClicked) {
    if (checkboxClicked.checked) {
        checkboxClicked.checked = false;
        divClicked.style.backgroundColor = "darkgrey";
    }
    else {
        checkboxClicked.checked = true;
        divClicked.style.backgroundColor = "orange";
        document.getElementById('cbOption1').checked = false;
        document.getElementById('cbOption2').checked = false;
        document.getElementById('cbOption4').checked = false;
        document.getElementById('dvOption1').style.backgroundColor = "darkgray";
        document.getElementById('dvOption2').style.backgroundColor = "darkgray";
        document.getElementById('dvOption4').style.backgroundColor = "darkgray";
    }
}
//<summary>
//method for checking if any answer is selected or not
//</summary>
function SelectAnswer() {
    if (document.getElementById('cbOption1').checked == false && document.getElementById('cbOption2').checked == false && document.getElementById('cbOption3').checked == false && document.getElementById('cbOption4').checked == false) {
        alert("Select an answer");
        return false;
    }
    else
        return true;
}