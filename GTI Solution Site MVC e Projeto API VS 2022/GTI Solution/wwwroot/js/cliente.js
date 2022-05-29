
$(document).ready(function () {
    setMasks();
    tableSearch();
})

$(function () {
    $(".datepicker").on('change', function () {
        var date = Date.parse($(this).val());
        if (date > Date.now()) {
            alert('Selecione uma data inferior ou igual à data de Atual!');
            $(this).val('');
        }
    });
});

function tableSearch() {
    var input, filter, table, tr, td, i, txtValue;
    input = document.getElementById("myInput");
    filter = input.value.toUpperCase();
    table = document.getElementById("myTable");
    tr = table.getElementsByTagName("tr");
    for (i = 0; i < tr.length; i++) {
        td = tr[i].getElementsByTagName("td")[0];
        if (td) {
            txtValue = td.textContent || td.innerText;
            if (txtValue.toUpperCase().indexOf(filter) > -1) {
                tr[i].style.display = "";
            } else {
                tr[i].style.display = "none";
            }
        }
    }
}

function setMasks() {
    $("#cep").mask("99.999-999", { reverse: true });
    $("#cpf").mask("999.999.999-99", { reverse: true })
    $("#rg_pr").mask("99.999.999");
}


$('#cep').blur(function () {
    var cep = $(this).val().replace(/\D/g, '');
    debugger
    if (cep != "") {
        var validacep = /^[0-9]{8}$/;
        if (validacep.test(cep)) {
            $("#rua").val("...");
            $("#bairro").val("...");
            $("#cidade").val("...");
            $("#uf_adress").val("...");
            $.getJSON("https://viacep.com.br/ws/" + cep + "/json/?callback=?", function (dados) {
                if (!("erro" in dados)) {
                    $("#rua").val(dados.logradouro);
                    $("#rua").attr('readonly', true);
                    $("#bairro").val(dados.bairro);
                    $('#bairro').attr('readonly', true);
                    $("#cidade").val(dados.localidade);
                    $("#cidade").attr('readonly', true);
                    $("#uf_adress").val(dados.uf);
                    $("#cep").val(dados.cep);
                    debugger
                    $("#uf_adress").attr('readonly', true);
                    $("#numero").focus();
                } else {
                    $("#cep").val('');
                    alert("CEP não encontrado.");
                };
            });
        } else {
            alert("Formato de CEP inválido.");
        };
    }
});


function validarCPF(el) {
    if (!checkValue(el.value)) {
        alert("CPF inválido! " + el.value);
        el.value = "";
    }
}


function checkValue(cpf) {
    cpf = cpf.replace(/[^\d]+/g, '');
    checkLength(cpf)
    add = 0;

    for (i = 0; i < 9; i++)
        add += parseInt(cpf.charAt(i)) * (10 - i);
    rev = 11 - (add % 11);

    if (rev == 10 || rev == 11)
        rev = 0;
    if (rev != parseInt(cpf.charAt(9)))
        return false;
    add = 0;

    for (i = 0; i < 10; i++)
        add += parseInt(cpf.charAt(i)) * (11 - i);
    rev = 11 - (add % 11);

    if (rev == 10 || rev == 11)
        rev = 0;
    if (rev != parseInt(cpf.charAt(10)))
        return false;
    return true;
}

function checkLength(cpf) {
    if (cpf == '') return false;
    if (cpf.length != 11 ||
        cpf == "00000000000" ||
        cpf == "11111111111" ||
        cpf == "22222222222" ||
        cpf == "33333333333" ||
        cpf == "44444444444" ||
        cpf == "55555555555" ||
        cpf == "66666666666" ||
        cpf == "77777777777" ||
        cpf == "88888888888" ||
        cpf == "99999999999")
        return false;
}