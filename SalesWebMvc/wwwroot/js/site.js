// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

/*formatar CPF ou CNPJ ao digitar*/
function FormataCPForCNPJ(campo, teclapres) {
    var tecla = teclapres.keyCode;
    var vr = new String(campo.value);
    vr = vr.replace(".", "");
    vr = vr.replace("/", "");
    vr = vr.replace("-", "");
    tam = vr.length + 1;

    if (tecla != 11) {
        if (tam < 14) {
            if (tam == 4)
                campo.value = vr.substr(0, 3) + '.';
            if (tam == 7)
                campo.value = vr.substr(0, 3) + '.' + vr.substr(3, 6) + '.';
            if (tam == 11)
                campo.value = vr.substr(0, 3) + '.' + vr.substr(3, 3) + '.' + vr.substr(7, 3) + '-';
        }

        if (tam == 14) {
            campo.value = (campo.value).replace(".", "");
            campo.value = (campo.value).replace(".", "");
            campo.value = (campo.value).replace(".", "");
            campo.value = (campo.value).replace("-", "");

            campo.value = campo.value.substr(0, 2) + '.' + campo.value.substr(2, 3) + '.' + campo.value.substr(5, 3) + '/' + campo.value.substr(8, 4) + '-';

        }
    }
}

/* Validar CPF ou CNPJ */
function ValidarCPForCNPJ(Obj) {

    var len = (Obj.value).length;
    if (len == 14) {
        var cpf = Obj.value;
        exp = /\.|\-/g
        cpf = cpf.toString().replace(exp, "");
        var digitoDigitado = eval(cpf.charAt(9) + cpf.charAt(10));
        var soma1 = 0, soma2 = 0;
        var vlr = 11;

        for (i = 0; i < 9; i++) {
            soma1 += eval(cpf.charAt(i) * (vlr - 1));
            soma2 += eval(cpf.charAt(i) * vlr);
            vlr--;
        }
        soma1 = (((soma1 * 10) % 11) == 10 ? 0 : ((soma1 * 10) % 11));
        soma2 = (((soma2 + (2 * soma1)) * 10) % 11);

        var digitoGerado = (soma1 * 10) + soma2;
        if (digitoGerado != digitoDigitado)
            alert('CPF Invalido!');
    }

    if (len == 18) {
        var cnpj = Obj.value;
        var valida = new Array(6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2);
        var dig1 = new Number;
        var dig2 = new Number;

        exp = /\.|\-|\//g
        cnpj = cnpj.toString().replace(exp, "");
        var digito = new Number(eval(cnpj.charAt(12) + cnpj.charAt(13)));

        for (i = 0; i < valida.length; i++) {
            dig1 += (i > 0 ? (cnpj.charAt(i - 1) * valida[i]) : 0);
            dig2 += cnpj.charAt(i) * valida[i];
        }
        dig1 = (((dig1 % 11) < 2) ? 0 : (11 - (dig1 % 11)));
        dig2 = (((dig2 % 11) < 2) ? 0 : (11 - (dig2 % 11)));

        if (((dig1 * 10) + dig2) != digito)
            alert('CNPJ Invalido!');
    }
}

/* somente Números */
function SomenteNumero(e) {
    var tecla = (window.event) ? event.keyCode : e.which;
    if ((tecla > 47 && tecla < 58)) return true;
    else {
        if (tecla == 8 || tecla == 0) return true;
        else return false;
    }
}