(function () {

    String.prototype.format = function (dataObject) {
        return this.replace(/{(.+)}/g, function (match, propertyName) {
            return dataObject[propertyName];
        });
    };

    function getData() {
        $.getJSON("/api/product", null, displayData);
    };

    function displayData(data) {
        var target = $("#dataTable tbody");
        target.empty();
        var template = $("#rowTemplate");
        data.forEach(function (dataObject) {
            target.append(template.html().format(dataObject));
        });
        $(target).find("button").click(function (e) {
            $("*.errorMsg").remove();
            $("*.error").removeClass("error");
            var index = $(e.target).attr("data-id");
            if ($(e.target).attr("data-action") == "delete") {
                deleteData(index);
            } else {
                var productData = { productID: index };
                $(e.target).closest('tr').find('input')
                    .each(function (index, inputElem) {
                        productData[inputElem.name] = inputElem.value;
                    });
                updateData(index, productData);
            }
            e.preventDefault();
        });
    }

    function deleteData(index) {
        $.ajax({
            url: "/api/product/" + index,
            type: 'DELETE',
            success: getData
        });
    }

    function updateData(index, productData) {
        $.ajax({
            url: "/api/product/" + index,
            type: 'PUT',
            data: productData,
            success: getData,
            error: function (jqXHR, status, error) {
                var errorRow = $("button[data-id=" + index + "]").closest("tr");
                errorRow.find("*").addClass("error");
                var errData = JSON.parse(jqXHR.responseText);
                for (var i = 0; i < errData.length; i++) {
                    errorRow.after("<tr class='errMsg error'><td/><td colspan=3>"
                        + errData[i] + "</td></tr>");
                }
            }
        });
    }

    $(document).ready(function () {
        getData();
    });

})();
