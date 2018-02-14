function attachGradientEvents() {
    let resultBox = document.getElementById('result');
    let gradientBox = document.getElementById('gradient');

    gradientBox.addEventListener('mousemove', attachPosition);
    gradientBox.addEventListener('mouseout', clearPercentage);
    
    function attachPosition(event) {
        let currentMouseX = event.offsetX;
        let percentage = Math.floor(currentMouseX / this.clientWidth * 100);
        resultBox.textContent = percentage + '%';
    }

    function clearPercentage() {
        resultBox.textContent = '';
    }
}