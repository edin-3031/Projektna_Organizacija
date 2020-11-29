var prvi, drugi = false;

function provjera(id) {

    if (id === "sfr") {
        var sifra = document.getElementById(id).value;

        if (isNaN(sifra) || sifra === "") {
            document.getElementById("snimi").disabled = true;
            document.getElementById(id).classList.add('err');
            document.getElementById("sifra_span").innerHTML = "Unos moraju biti brojevi";
            document.getElementById("sifra_span").classList.add("err");
            prvi = false;
            document.getElementById("snimi").disabled = true;
        }

        else if ((!isNaN(sifra)) || sifra != "") {
            document.getElementById(id).classList.remove('err');
            document.getElementById("sifra_span").innerHTML = "";
            document.getElementById("sifra_span").classList.remove("err");
            prvi = true;
        }
    }

    if (id === "n") {
        var naziv = document.getElementById(id).value;

        if (naziv === "") {
            document.getElementById("snimi").disabled = true;
            document.getElementById(id).classList.add('err');
            document.getElementById("naziv_span").innerHTML = "Ovo polje je obavezno";
            document.getElementById("naziv_span").classList.add("err");
            document.getElementById("snimi").disabled = true;
            drugi = false;
        }

        else if (naziv != "") {
            document.getElementById(id).classList.remove('err');
            document.getElementById("naziv_span").innerHTML = "";
            document.getElementById("naziv_span").classList.remove("err");
            drugi = true;
        }
    }

    if (prvi === true && drugi === true) {
        document.getElementById("snimi").disabled = false;
    }
    else {
        document.getElementById("snimi").disabled = true;
    }
}