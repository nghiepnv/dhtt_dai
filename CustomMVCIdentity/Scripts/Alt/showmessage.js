function showmessage(msg, timeDelay, div) {
    if ($("#" + div).hasClass("uk-hidden")) {
        $("#" + div).fadeIn("slow", function () {
            $(this).removeClass("uk-hidden").html(msg);
        });
        var delayMillis = parseInt(timeDelay);
        setTimeout(function () {
            $("#" + div).fadeOut("slow", function () {
                $(this).addClass("uk-hidden");
            });
        }, delayMillis);
    }
}