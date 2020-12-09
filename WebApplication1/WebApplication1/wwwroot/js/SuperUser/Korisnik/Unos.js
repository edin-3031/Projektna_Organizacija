$(document).ready(function () {
    document.getElementById("snimi_korisnik_unos").disabled = true;
});
        var prvi, drugi, treci, cetvrti, peti, sesti, sedmi, osmi = false;
        function provjera(id) {
    if (id === "sifra_input") {
        var sifra = document.getElementById(id).value;

        if (isNaN(sifra)) {
    document.getElementById(id).classList.add('err');
            document.getElementById("sifra_span").innerHTML = "Unos moraju biti brojevi";
            document.getElementById("sifra_span").classList.add("err");
        }

        else if (sifra === "") {
    document.getElementById(id).classList.add('err');
            document.getElementById("sifra_span").innerHTML = "Polje nesmije biti prazno";
            document.getElementById("sifra_span").classList.add("err");
        }

        else if ((!isNaN(sifra)) || sifra != "") {
    document.getElementById(id).classList.remove('err');
            document.getElementById("sifra_span").innerHTML = "";
            document.getElementById("sifra_span").classList.remove("err");
            prvi = true;
        }
    }

    else if (id === "ime_input") {
        var ime = document.getElementById(id).value;

        if (ime === "") {
    document.getElementById(id).classList.add('err');
            document.getElementById("ime_span").innerHTML = "Polje nesmije biti prazno";
            document.getElementById("ime_span").classList.add("err");
        }
        else if (ime != "") {
    document.getElementById(id).classList.remove('err');
            document.getElementById("ime_span").innerHTML = "";
            document.getElementById("ime_span").classList.remove("err");
            drugi = true;
        }
    }

    else if (id === "prezime_input") {
        var ime = document.getElementById(id).value;

        if (ime === "") {
    document.getElementById(id).classList.add('err');
            document.getElementById("prezime_span").innerHTML = "Polje nesmije biti prazno";
            document.getElementById("prezime_span").classList.add("err");
        }
        else if (ime != "") {
    document.getElementById(id).classList.remove('err');
            document.getElementById("prezime_span").innerHTML = "";
            document.getElementById("prezime_span").classList.remove("err");
            treci = true;
        }
    }

    else if (id === "telefon_input") {
        var telefon = document.getElementById(id).value;

        if (isNaN(telefon)) {
    document.getElementById(id).classList.add('err');
            document.getElementById("telefon_span").innerHTML = "Unos moraju biti brojevi";
            document.getElementById("telefon_span").classList.add("err");
        }

        else if (telefon === "") {
    document.getElementById(id).classList.add('err');
            document.getElementById("telefon_span").innerHTML = "Polje nesmije biti prazno";
            document.getElementById("telefon_span").classList.add("err");
        }

        else if ((!isNaN(telefon)) || telefon != "") {
    document.getElementById(id).classList.remove('err');
            document.getElementById("telefon_span").innerHTML = "";
            document.getElementById("telefon_span").classList.remove("err");
            cetvrti = true;
        }
    }

    else if (id === "mail_input") {
        var mail = document.getElementById(id).value;

        if (mail === "") {
    document.getElementById(id).classList.add('err');
            document.getElementById("mail_span").innerHTML = "Polje nesmije biti prazno";
            document.getElementById("mail_span").classList.add("err");
        }
        else if (mail != "") {
    document.getElementById(id).classList.remove('err');
            document.getElementById("mail_span").innerHTML = "";
            document.getElementById("mail_span").classList.remove("err");
            peti = true;
        }
    }

    else if (id === "username_input") {
        var korisnickoIme = document.getElementById(id).value;
        @brojac = 0;
        @kor_ime=korisnickoIme;

        @foreach(var lista in lista_users)
        {
            if(lista.Korisnicko_Ime.ToString() == kor_ime.ToString())
            {
                @(brojac++);
                break;
            }
        }

        if (@brojac >0) {
    document.getElementById(id).classList.add('err');
            document.getElementById("username_span").innerHTML = "Unesena vrijednost je već zauzeta";
            document.getElementById("username_span").classList.add("err");
        }

        if (korisnickoIme === "") {
    document.getElementById(id).classList.add('err');
            document.getElementById("username_span").innerHTML = "Polje nesmije biti prazno";
            document.getElementById("username_span").classList.add("err");
        }

        else if (@brojac == 0 && korisnickoIme != "") {
    document.getElementById(id).classList.remove('err');
            document.getElementById("username_span").innerHTML = "";
            document.getElementById("username_span").classList.remove("err");
            sesti = true;
        }
    }

    else if (id === "pass_input") {
        var pass = document.getElementById(id).value;

        if (pass === "") {
    document.getElementById(id).classList.add('err');
            document.getElementById("pass_span").innerHTML = "Polje nesmije biti prazno";
            document.getElementById("pass_span").classList.add("err");
        }
        else if (pass.length < 8) {
    document.getElementById(id).classList.add('err');
            document.getElementById("pass_span").innerHTML = "Lozinka mora imati najmanje 8 karaktera";
            document.getElementById("pass_span").classList.add("err");
        }
        else if (pass != "" && pass.length >= 8) {
    document.getElementById(id).classList.remove('err');
            document.getElementById("pass_span").innerHTML = "";
            document.getElementById("pass_span").classList.remove("err");
            sedmi = true;
        }
    }

    else if (id === "uloga_select") {
        var selected = document.getElementById(id).value;

        if (selected === 0) {
    document.getElementById(id).classList.add('err');
            document.getElementById("select_span").innerHTML = "Morate odabrati jedno polje";
            document.getElementById("select_span").classList.add("err");
        }
        else if (selected > 0) {
    document.getElementById(id).classList.remove('err');
            document.getElementById("select_span").innerHTML = "";
            document.getElementById("select_span").classList.remove("err");
            osmi = true;
        }
    }

    if (prvi === true && drugi === true && treci === true && cetvrti === true && peti === true && sesti === true && sedmi === true && osmi === true) {
    document.getElementById("snimi_korisnik_unos").disabled = false;
    }
    else {
    document.getElementById("snimi_korisnik_unos").disabled = true;
    }
}