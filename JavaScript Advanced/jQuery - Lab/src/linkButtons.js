function attachEvents() {
    let buttons = $('a.button');
    $(buttons).click(clicked);    

    function clicked() {
        buttons.removeClass('selected');
        $(this).addClass('selected');
    }
}