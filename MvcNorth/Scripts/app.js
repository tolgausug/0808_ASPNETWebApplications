/// reference path="jquery-3.1.1.js"/>

$("#txtara").keyup(function () {
    var key = this.value;

    $.ajax({
        url: "../Urun/Bul?key" + key,
        method: "GET"
    }).done(function (response) {
        console.log(response);
    })
})