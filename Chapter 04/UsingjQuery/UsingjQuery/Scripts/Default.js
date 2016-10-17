/// <reference path="jquery-1.8.2.js" />
$(document).ready(function () {

    var jsonString = '[{"Name":"Everest","Height":8848},'
        + '{"Name":"Aconcagua","Height":6962},{"Name":"McKinley","Height":6194},'
        + '{"Name":"Kilimanjaro","Height":5895},{"Name":"K2","Height":8611}]';

    var dataObjects = $.parseJSON(jsonString);

    var targetElem = $('#tableBody');

    for (var i = 0; i < dataObjects.length; i++) {
        targetElem.append('<tr><td class="name">'
            + dataObjects[i].Name + '</td><td class="height">'
            + dataObjects[i].Height + '</td></tr>');
    }
        
    $('tr').prepend("<td></td>");
    $('<input name="delete" type="radio"/>').prependTo('tbody td:first-child')
        .first().attr("checked", true);

    $(':button').click(function (e) {
        $(':radio:checked').closest('tr').remove();
        $(':radio').first().attr("checked", true);
    });
});