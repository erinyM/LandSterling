
    jQuery(document).ready(function ($) {

        for (let i = 0; i < document.forms.length; ++i) {
            let form = document.forms[i];
            if ($(form).attr("method") != "get") { $(form).append('<input type="hidden" name="GxpQSc" value="vhfWZ12z@_" />'); }
            if ($(form).attr("method") != "get") { $(form).append('<input type="hidden" name="WEyRklMDxXKoHO" value="Odc15oURZxn0fXMp" />'); }
        }

        $(document).on('submit', 'form', function () {
            if ($(this).attr("method") != "get") { $(this).append('<input type="hidden" name="GxpQSc" value="vhfWZ12z@_" />'); }
            if ($(this).attr("method") != "get") { $(this).append('<input type="hidden" name="WEyRklMDxXKoHO" value="Odc15oURZxn0fXMp" />'); }
            return true;
        });

        jQuery.ajaxSetup({
            beforeSend: function (e, data) {

                if (data.type !== 'POST') return;

                if (typeof data.data === 'object' && data.data !== null) {
                    data.data.append("GxpQSc", "vhfWZ12z@_");
                    data.data.append("WEyRklMDxXKoHO", "Odc15oURZxn0fXMp");
                }
                else {
                    data.data = data.data + '&GxpQSc=vhfWZ12z@_&WEyRklMDxXKoHO=Odc15oURZxn0fXMp';
                }
            }
        });

    });