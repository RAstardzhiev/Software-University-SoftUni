let printEmailValidationResult = email => /^[A-Za-z0-9]+@[a-z]+\.[a-z]+$/.test(email)
    ? console.log('Valid')
    : console.log('Invalid');



printEmailValidationResult('valid@email.bg');
printEmailValidationResult('invalid@emai1.bg');