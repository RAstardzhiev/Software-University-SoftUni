function validate() {
    let inputBox = document.getElementById('email');
    inputBox.addEventListener('change', performValidation);
    let pattern = /^[a-z]+@[a-z]+\.[a-z]+$/;

    function performValidation() {
        let email = this.value;
        if (pattern.test(email)) {
            this.classList.remove('error');
        } else {
            this.classList.add('error');
        }
    }
}