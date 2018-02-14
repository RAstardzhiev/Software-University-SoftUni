function notify(message) {
    let notificationBox = document.getElementById('notification');
    notificationBox.textContent = message;
    notificationBox.style.display = 'block';
    setTimeout(hideNotificationBox, 2000);

    function hideNotificationBox() {
        notificationBox.style.display = 'none';
    }
}