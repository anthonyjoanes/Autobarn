$('.button-collapse').sideNav();
$('.parallax').parallax();
$('.slider').slider({ full_width: true });

$('.datepicker').pickadate({
    selectMonths: true, // Creates a dropdown to control month
    selectYears: 15 // Creates a dropdown of 15 years to control year
});
$('select').material_select();

$('#vehicleMakes').on('change', function () {

    $('#makesummary').html($('#vehicleMakes :selected').text());
    $('#modelsummary').html('');
    $('#pricesummary').html('');
    $('#dealersummary').html('');
    $('#savingsummary').html('');


    $.ajax({
        url: "/Booking/Models/" + this.value,
        type: 'GET',
        success: function (data) {


            var $select = $('#vehicleModels');
            $select.empty();

            $('<option disabled selected>', {
                value: ''
            }).html('Choose Model').appendTo($select);

            for (var i = 0; i < data.length; i++) {
                console.info(data[i].Name);

                var option = $('<option>', {
                    value: data[i].Id
                }).html(data[i].Name).appendTo($select);
            }


            var $services = $('#services');

            $services.empty();

            $('<option disabled selected>', {
                value: ''
            }).html('Choose Service').appendTo($services);


            $('select').material_select();
        },
        error: function () {
            console.info("There was an error downloading the makes data");
        }
    });
});

$('#vehicleModels').on('change', function () {

    $('#modelsummary').html($('#vehicleModels :selected').text());

    $('#pricesummary').html('');
    $('#dealersummary').html('');
    $('#savingsummary').html('');

    $.ajax({
        url: "/Booking/Services/" + this.value,
        type: 'GET',
        success: function (data) {

            $('#serviceobjects').val(data);

            var $select = $('#services');
            $select.empty();

            $('<option disabled selected>', {
                value: ''
            }).html('Choose Service').appendTo($select);

            for (var i = 0; i < data.length; i++) {
                console.info(data[i].Name);

                var option = $('<option>', {
                    value: data[i].Id
                }).html(data[i].Name).appendTo($select);
            }

            $('select').material_select();
        },
        error: function () {
            console.info("There was an error downloading the makes data");
        }
    });
});

$('#services').on('change', function () {

    var serviceId = this.value;

    $.ajax({
        url: "/Booking/Service/" + this.value,
        type: 'GET',
        success: function (data) {

            $('#pricesummary').html(data.Price);
            $('#dealersummary').html(data.DealerPrice);
            $('#savingsummary').html(data.DealerPrice - data.Price);

        },
        error: function () {

        }
    });

});