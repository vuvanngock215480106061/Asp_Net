$(document).ready(function () {
    function sendData() {
        var a = $('#txtA').val();
        var b = $('#txtB').val();

        if (isNaN(a) || isNaN(b)) {
            alert('Vui lòng nhập giá trị hợp lệ cho cạnh huyền , chiều cao.');
            return;
        }

        var dataToSend = {
            soa: a,
            sob: b,
        };

        $.ajax({
            url: "WebForm1.aspx",
            type: "POST",
            data: JSON.stringify(dataToSend),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                $("#ketqua").text('Diện tích tam giác vuông là: ' + response);
            },
            error: function (xhr, status, error) {
                $("#ketqua").text('Có lỗi xảy ra: ' + xhr.responseText);
            }
        });
    }

    $("#btnCalculate").click(function () {
        sendData();
    });
});
