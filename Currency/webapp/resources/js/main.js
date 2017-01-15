/**
 * Created by drovdo on 21/05/16.
 */
$(function () {
    var sendUrl = "http://localhost:52068/CurrencyService.svc";
    var source = "";
    var target = "";
    var startDate = null;
    var endDate = null;
    var currencies;

    $('#startDate').datepicker({
    }).on('hide', function (e) {
        startDate = e.date;
        startDate = startDate.getTime() - startDate.getTimezoneOffset() * 60000;
    });

    $('#endDate').datepicker({
    }).on('hide', function (e) {
        endDate = e.date;
        endDate = endDate.getTime() - endDate.getTimezoneOffset() * 60000;
    });

    $.notify.addStyle('superError', {
        html: "<div><span data-notify-text/></div>",
        classes: {
            base: {
                "white-space": "nowrap",
                "padding": "15px",
                "color": "#a94442",
                "background-color": "#f2dede",
                "margin-bottom": "20px",
                "border": "1px solid transparent",
                "border-radius": "4px",
                "font-weight": "bold"
            }
        }
    });

    $(document).ready(function () {
        var date = new Date();
        endDate = new Date(date.getFullYear(), date.getMonth(), date.getDate(), 0, 0, 0, 0);
        startDate = new Date(endDate.getTime());
        startDate.setTime(startDate.getTime() - 86400000);//day before
        $('#startDate').val(formatDate(startDate));
        $('#endDate').val(formatDate(endDate));
        startDate = startDate.getTime() - startDate.getTimezoneOffset() * 60000;
        endDate = endDate.getTime() - endDate.getTimezoneOffset() * 60000;
        $.ajax({
            type: 'get',
            url: sendUrl + '/currencies',
        }).done(function (result) {
            currencies = result['GetCurrenciesResult'];
            var sourceDropdown = $('#source').find('.dropdown-menu');
            fillCurrencies(sourceDropdown, currencies);
            var targetDropdown = $('#target').find('.dropdown-menu');
            fillCurrencies(targetDropdown, currencies);

            $('.dropdown-menu li a').click(function () {
                var selText = $(this).text();
                var dropdown = $(this).parents('.dropdown');
                if (dropdown.attr('id') === 'source') {
                    source = selText;
                } else if (dropdown.attr('id') === 'target') {
                    target = selText;
                }
                dropdown.find('.dropdown-toggle').html(selText + ' <span class="caret"></span>');
            });
        });
        getDayRates();
    });

    var fillCurrencies = function (dropdown, currencies) {
        for (var i = 0; i < currencies.length; i++) {
            dropdown.append(
                 $('<li>').append(
                     $('<a>').append(currencies[i])));
        }
    }

    var searchResultsDataTable = $('#searchResult').DataTable({
        ordering: false,
        searching: false,
        columns: [
            { data: 'SourceName' },
            { data: 'TargetName' },
            { data: 'Rate' },
            {
                data: 'Date',
                type: 'date',
                render :function (value) {
                    if (value === null) return "";

                    var dt = new Date(value);

                    return formatDate(dt);}
            }
        ]
    });

    $('#swapBtn').click(function () {
        if (source === "" && target === "") {
            $.notify('Please, select source and target currency.', { style: 'superError' });
        } else if (source === "") {
            $.notify('Please, select source currency.', { style: 'superError' });
        } else if (target === "") {
            $.notify('Please, select target currency.', { style: 'superError' });
        } else {
            $('#source').find('.dropdown-toggle').html(target + ' <span class="caret"></span>');
            $('#target').find('.dropdown-toggle').html(source + ' <span class="caret"></span>');
            var temp = source;
            source = target;
            target = temp;
        }
    });

    $('#searchBtn').click(function () {
        if (startDate > endDate) {
            $.notify('Start date should be after end date.', { style: 'superError' });
        } else if (source === "" && target === "") {
            $.notify('Please, select source and target currency.', { style: 'superError' });
        } else if (source === "") {
            $.notify('Please, select source currency.', { style: 'superError' });
        } else if (target === "") {
            $.notify('Please, select target currency.', { style: 'superError' });
        } else if (target == source) {
            $.notify('Source and target currencies are the same.', { style: 'superError' });
        } else {
            $(this).button('loading');
            $.ajax({
                type: 'get',
                url: sendUrl + '/rates',
                dataType: 'json',
                data: {
                    source: source, target: target, startDate: startDate, endDate: endDate
                }
            }).done(function (result) {
                $('#searchBtn').button('reset');
                var searchResult = result['GetRatesByCurrenciesBetweenDatesResult'];
                showSearchResults(searchResult, false);
            });
        }
    });

    var showSearchResults = function (result, dayResult) {
        var searchResult = result['ResponseData'];
        if (searchResult.length == 0) {
            $('#searchResultsHeader').text('There\'s nothing to show :(');
            var resultInfo = $('#dayRates');
            resultInfo.text('Whould you better enjoy today\'s rates?');
            $('#searchResults').hide();
        } else {
            $('#searchResultsHeader').text('Here you are!');
            var resultInfo = $('#dayRates');
            resultInfo.text('Do you want to see today\'s rates?');
            fillDataTable(searchResultsDataTable, searchResult);
            $('#searchResults').show();
        }
        if (!dayResult) {
            resultInfo.show();
        } else {
            resultInfo.hide();
        }
    };

    function fillDataTable(table, tokens) {
        table.clear().rows.add(tokens).draw();
    }

    var getDayRates = function () {
        $.ajax({
            type: 'get',
            url: sendUrl + '/dayrates',
        }).done(function (result) {
            var resultRate = result['GetDayRatesResult'];
            showSearchResults(resultRate, true);
        });
    };

    $('#dayRates').click(function () {
        $('#searchResults').hide();
        getDayRates();
    });


    function formatDate(date) {
        return ("0" + (date.getMonth() + 1)).slice(-2) + "/" + ("0" + date.getDate()).slice(-2) + "/" + date.getFullYear();
    }
});