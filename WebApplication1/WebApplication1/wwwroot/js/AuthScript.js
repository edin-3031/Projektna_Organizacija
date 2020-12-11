$("#go").mousedown(function () {

    this.style.borderLeft = "5px solid black";
    this.style.borderRight = "5px solid black";
    this.style.borderTop = "5px solid black";
});

$("#go").keydown(function () {

    this.style.borderLeft = "5px solid black";
    this.style.borderRight = "5px solid black";
    this.style.borderTop = "5px solid black";
});

$("#go").mouseup(function () {

    this.style.borderLeft = "3px solid black";
    this.style.borderRight = "3px solid black";
    this.style.borderTop = "3px solid black";

});

$("#go").mouseleave(function () {

    this.style.borderLeft = "3px solid black";
    this.style.borderRight = "3px solid black";
    this.style.borderTop = "3px solid black";

});


$("#go").keyup(function () {

    this.style.borderLeft = "5px solid black";
    this.style.borderRight = "5px solid black";
    this.style.borderTop = "5px solid black";
});

$("#msg").hide().slideDown(1000).delay(2000).slideUp(1000);

$(document).ready(function () {
    $("#tekst_i_animacija").hide();
});

$("#go").click(function () {
    $("#tekst_i_animacija").show();
    document.getElementById("podloga").style.filter = "blur(10px)";
});