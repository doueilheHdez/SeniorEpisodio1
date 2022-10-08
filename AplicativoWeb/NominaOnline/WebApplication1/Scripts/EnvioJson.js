function EnvioInformacion(Param, URL, fn) {
    $.ajax({
        url: URL,
        data: JSON.stringify(Param),
        dataType: "json",
        type: "POST",
        async: true,
        cache: false,
        contentType: "application/json; charset=utf-8",
        dataFilter: function (data) { return data; },
        success: function (data) {
            fn(jQuery.parseJSON(data.d));
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert("Intente Nuevamente");
            return null;
        }
    });
}