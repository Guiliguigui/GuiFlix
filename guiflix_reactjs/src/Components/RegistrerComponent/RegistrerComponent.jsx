import React from 'react';
import { useState } from 'react';

const RegistrerComponent = () => {
    const validEmail = new RegExp(
        '^[a-zA-Z0-9._:$!%-]+@[a-zA-Z0-9.-]+.[a-zA-Z]$'
    );
    const validPassword = new RegExp('^(?=.*?[A-Za-z])(?=.*?[0-9]).{6,}$');
    const validLastName = new RegExp('^(?=.*?[A-Za-z])(?=.*?[0-9]).{6,}$');
    const validFirstName = new RegExp('^[A-Z]{1}[a-zA-Z\\séèë\\-_]*$');
    const validPhone = new RegExp('^([0|\\+33|33]+)(\\.|\\-|\\s)?([1-9]{1})((\\.|\\-|\\s)?[0-9]{2}){4}$');
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
    const [lastName, setLastName] = useState('');
    const [firstName, setFirstName] = useState('');
    const [phone, setPhone] = useState('');
    const [emailErr, setEmailErr] = useState(false);
    const [pwdError, setPwdError] = useState(false);
    const [lastNameError, setLastNameError] = useState(false);
    const [firstNameError, setFirstNameError] = useState(false);
    const [phoneError, setPhoneError] = useState(false);
    const validate = () => {
        if (!validEmail.test(email)) {
            setEmailErr(true);
        }
        if (!validPassword.test(password)) {
            setPwdError(true);
        }
        if (!validLastName.test(lastName)) {
            setLastNameError(true);
        }
        if (!validFirstName.test(firstName)) {
            setFirstNameError(true);
        }
        if (!validPhone.test(phone)) {
            setPhoneError(true);
        }
    };
    return (
        <div>
            <section class="vh-100 cardName">
                <div class="container py-5 h-100">
                    <div class="row d-flex justify-content-center align-items-center h-100">
                        <div class="col col-xl-10">
                            <div class="cardBord"  >
                                <div class="row g-0">
                                    <div class="col-md-6 col-lg-5 d-none d-md-block">
                                        <img src=""
                                            alt="login form" class="img-fluid imgStyle" />
                                    </div>
                                    <div class="col-md-6 col-lg-7 d-flex align-items-center">
                                        <div class="card-body p-4 p-lg-5 text-black">

                                            <form>
                                                <h5 class="fw-normal mb-3 pb-3" >Sign Up</h5>

                                                <div class="form-outline mb-4">
                                                    <input type="email" id="form2Example17" class="form-control form-control-lg" />
                                                    <label class="form-label" for="form2Example17" value={email} onChange={(e) => setEmail(e.target.value)}>Email address</label>
                                                </div>

                                                <div class="form-outline mb-4">
                                                    <input type="password" id="form2Example27" class="form-control form-control-lg" />
                                                    <label class="form-label" for="form2Example27" value={password} onChange={(e) => setPassword(e.target.value)}>Password</label>
                                                </div>
                                                <div class="form-outline mb-4">
                                                    <input type="password" id="form2Example27" class="form-control form-control-lg" />
                                                    <label class="form-label" for="form2Example27" value={lastName} onChange={(e) => setLastName(e.target.value)}>Last Name</label>
                                                </div>
                                                <div class="form-outline mb-4">
                                                    <input type="password" id="form2Example27" class="form-control form-control-lg" />
                                                    <label class="form-label" for="form2Example27" value={firstName} onChange={(e) => setFirstName(e.target.value)}>First Name</label>
                                                </div>
                                                <div class="form-outline mb-4">
                                                    <input type="password" id="form2Example27" class="form-control form-control-lg" />
                                                    <label class="form-label" for="form2Example27" value={phone} onChange={(e) => setPhone(e.target.value)}>Phone</label>
                                                </div>

                                                <div class="pt-1 mb-4">
                                                    <button class="btn btn-danger btn-lg btn-block" type="button" onClick={validate()}>Login</button>
                                                </div>
                                                <a href="#!" class="small text-muted">Terms of use.</a>
                                                <a href="#!" class="small text-muted">Privacy policy</a>
                                            </form>
                                            {emailErr && <p>Your email is invalid</p>}
                                            {pwdError && <p>Your password is invalid</p>}
                                            {lastNameError && <p>Your LastName is invalid</p>}
                                            {firstNameError && <p>Your FirstName is invalid</p>}
                                            {phoneError && <p>Your Phone is invalid</p>}
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>

        </div>
    );
}

export default RegistrerComponent;