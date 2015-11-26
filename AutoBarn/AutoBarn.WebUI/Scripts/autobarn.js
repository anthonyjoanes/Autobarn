﻿(function ($) {
    $(function () {

        $('.button-collapse').sideNav();
        $('.parallax').parallax();

    }); // end of document ready


    $(document).ready(function () {
        $('select').material_select();

        $.ajax({
            url: "/Booking/Makes",
            type: 'GET',
            success: function(data) {

                var $select = $('#vehicleMakes');

                for (var i = 0; i < data.length; i++) {
                    console.info(data[i].Name);

                    var option = $('<option>', {
                        value: data[i].Id
                    }).html(data[i].Name).appendTo($select);
                }


            },
            error: function() {
                console.info("There was an error downloading the makes data");
            }
        });

    });

    $('#vehicleMakes').on('change', function() {

        $.ajax({
            url: "/Booking/Models/"+this.value,
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


            },
            error: function () {
                console.info("There was an error downloading the makes data");
            }
        });
    });

    $('#vehicleModels').on('change', function () {

        $.ajax({
            url: "/Booking/Services/" + this.value,
            type: 'GET',
            success: function (data) {

                var $select = $('#services');
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


            },
            error: function () {
                console.info("There was an error downloading the makes data");
            }
        });
    });

    


})(jQuery); // end of jQuery name space