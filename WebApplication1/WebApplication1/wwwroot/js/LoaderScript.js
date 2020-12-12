$(document).ready(function () {
    $("#tekst_i_animacija").hide();
});

document.getElementById("go").click(function () {
    $("#tekst_i_animacija").show();
    document.getElementById("podloga").style.filter = "blur(10px)";
    document.getElementById("zaglavlje").style.filter = "blur(10px)";
});