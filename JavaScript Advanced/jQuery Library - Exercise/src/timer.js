function timer() {
    $('button#start-timer').click(start);
    $('button#stop-timer').click(stop);

    let hours = $('span#hours');
    let minutes = $('span#minutes');
    let seconds = $('span#seconds');

    let jsTimer = null;

    function start() {
        if (jsTimer === null) {
            jsTimer = setInterval(tick, 1000);
        }
    }

    function stop() {
        if (jsTimer !== null) {
            clearInterval(jsTimer);
            jsTimer = null;
        }
    }

    function tick() {
        let currentSecond = Number(seconds.text()) + 1;
        if (currentSecond === 60) {
            currentSecond = 0;

            let currentMinute = Number(minutes.text()) + 1;
            if (currentMinute === 60) {
                currentMinute = 0;
                hours.text(('0' + Number(hours.text()) + 1).slice(-2));
            }

            minutes.text(('0' + currentMinute).slice(-2));
        } 

        seconds.text(('0' + currentSecond).slice(-2));
    }
}