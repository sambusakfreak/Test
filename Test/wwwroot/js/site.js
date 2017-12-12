

$(document).ready(function () {

   /* var wrapper = $('#add-sets');
    var clone = $('#add-set');
    $("#selecta").chosen();

    $("#btn-add-set").click(function (e) {
        e.preventDefault();


        
    }); */

    var clone = $('div.content').clone(true);
    console.log(clone);
    $('div.content select').chosen();

    jQuery('#btn-add-set    ').click(function () {
        var parent = jQuery('div.content').last();
        clone.clone(true).insertAfter(parent);
        $('div.content:last select').chosen();
    }); 





    $('#btn-remove-set').click(function (e) {
        e.preventDefault();
        $(this).parents('#add-set').remove();

        removeButton();
    });

    function removeButton() {
        if (self>0) {
            if ($('#add-set').length == 1) {
                $('#add-set #btn-remove-set').hide();
                self --;
            }
        }
        
    }




});
 