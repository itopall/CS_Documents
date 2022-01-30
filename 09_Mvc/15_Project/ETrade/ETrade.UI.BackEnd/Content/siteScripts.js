
function AjaxRequest(url, data, callback) {
    $.ajax({
        type: 'post',
        url: url,
        data: data,
        beforeSend: function () {
            $("body").append('<div id="requestOverlay" class="request-overlay"></div>');
        },
        complete: function () {
            $("#requestOverlay").remove();
        },
        success: function (result) {
            if (result.status === true) {
                toastr.success(result.message);
            } else {
                toastr.error("Hata oluştu! Hata mesajı: " + result.message);
            }

            callback(result);
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            if (XMLHttpRequest.status == 500) {
                toastr.error("Hata oluştu! " + XMLHttpRequest.status + "<br><br>Hata Mesajı:<br>" + XMLHttpRequest.responseJSON.Message);

                //Hata aldığında normal sayfa yapısında olduğu gibi Error sayfasına yönlendirmek istersek aşağıdaki kısmı aktif edebiliriz.
                //window.location.replace("/Other/Error");
            }
            else {
                window.location.replace("/Account/Login");
            }
        }
    });
}