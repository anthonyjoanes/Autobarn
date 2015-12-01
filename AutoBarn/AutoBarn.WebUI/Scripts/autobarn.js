(function ($) {
    $(function () {

        $('.button-collapse').sideNav();
        $('.parallax').parallax();
        $('.slider').slider({ full_width: true });

        $('.datepicker').pickadate({
            selectMonths: true, // Creates a dropdown to control month
            selectYears: 15 // Creates a dropdown of 15 years to control year
        });

    }); // end of document ready


    $(document).ready(function () {
        

        $.ajax({
            url: "/Booking/Makes",
            type: 'GET',
            success: function(data) {

               

                var selectedMakeId = $('#selectedMakeId').val();

                var $select = $('#vehicleMakes');
                $select.empty();

                $('<option disabled selected>', {
                    value: ''
                }).html('Choose Make').appendTo($select);

                for (var i = 0; i < data.length; i++) {

                    var id = data[i].Id;
                    var make = data[i].Name;

                   // if (selectedMakeId == id) {
                    //    $('<option selected>', {
                    //        value: id
                    //    }).html(make).appendTo($select);
                   // } else {
                        $('<option>', {
                            value: id
                        }).html(make).appendTo($select);
                    //}

                    
                }


                $('select').material_select();
            },
            error: function() {
                console.info("There was an error downloading the makes data");
            }
        });
        
    });

    $('#vehicleMakes').on('change', function() {

        alert(this.value);

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


                var $services = $('#services');

                $services.empty();

                $('<option disabled selected>', {
                    value: ''
                }).html('Choose Model').appendTo($services);



                $('select').material_select();
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

                $('select').material_select();
            },
            error: function () {
                console.info("There was an error downloading the makes data");
            }
        });
    });

    


})(jQuery); // end of jQuery name space