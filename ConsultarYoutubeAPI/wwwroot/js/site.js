function Canal() {
    $.ajax({
        type: "GET",
        url: "/Canal/Index",
        success: function (response) {
            console.log('Sucesso');
            var url = "/Canal/Index";
            window.location.assign(url);
        },
        faulure: function (response) {
            alert(response.responseText);
        },
        error: function (response) {
            alert(response.responseText);
        },
    });
}

function Video() {
    $.ajax({
        type: "GET",
        url: "/Video/Index",
        success: function (response) {
            console.log('Sucesso');
            var url = "/Video/Index";
            window.location.assign(url);
        },
        faulure: function (response) {
            alert(response.responseText);
        },
        error: function (response) {
            alert(response.responseText);
        },
    });
}