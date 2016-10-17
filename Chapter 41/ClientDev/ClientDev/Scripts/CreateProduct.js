(function () {

    $(document).ready(function () {
        var form = $("form");
        form.submit(function (e) {
            if (!form.valid()) {
                return;
            } else {
                e.preventDefault();

                var errorList = $("#errorSummary ul");
                var formData = {
                    Name: $("#Name").val(),
                    Category: $("#Category").val(),
                    Price: $("#Price").val()
                };
                $.ajax({
                    url: "/api/product",
                    type: "POST",
                    data: formData,
                    dataType: "json",
                    success: function (product) {
                        errorList.empty();
                        $("table tbody").append(
                                    "<tr><td>" + product.ProductID
                                    + "</td><td>" + product.Name
                                    + "</td><td>" + product.Category
                                    + "</td><td>" + product.Price + "</td></tr>");
                    },
                    error: function (jqXHR, status, error) {
                        var errData = JSON.parse(jqXHR.responseText);
                        for (var i = 0; i < errData.length; i++) {
                            errorList.append("<li>" + errData[i] + "</li>");
                        }
                    }
                });
            }
        });
    });

})();
