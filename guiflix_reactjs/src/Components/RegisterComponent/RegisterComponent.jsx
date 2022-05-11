import React from 'react';
import { useState } from 'react';

export default function RegisterComponent() {
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
            <section className="vh-100 cardName">
                <div className="container py-5 h-100">
                    <div className="row d-flex justify-content-center align-items-center h-100">
                        <div className="col col-xl-10">
                            <div className="cardBord"  >
                                <div className="row g-0">
                                    <div className="col-md-6 col-lg-5 d-none d-md-block">
                                        <img src=""
                                            alt="login form" className="img-fluid imgStyle" />
                                    </div>
                                    <div className="col-md-6 col-lg-7 d-flex align-items-center">
                                        <div className="card-body p-4 p-lg-5 text-black">

                                            <form>
                                                <h5 className="fw-normal mb-3 pb-3" >Sign Up</h5>

                                                <div className="form-outline mb-4">
                                                    <input type="email" id="form2Example17" className="form-control form-control-lg" />
                                                    <label className="form-label" htmlFor="form2Example17" value={email} onChange={(e) => setEmail(e.target.value)}>Email address</label>
                                                </div>

                                                <div className="form-outline mb-4">
                                                    <input type="password" id="form2Example27" className="form-control form-control-lg" />
                                                    <label className="form-label" htmlFor="form2Example27" value={password} onChange={(e) => setPassword(e.target.value)}>Password</label>
                                                </div>
                                                <div className="form-outline mb-4">
                                                    <input type="password" id="form2Example27" className="form-control form-control-lg" />
                                                    <label className="form-label" htmlFor="form2Example27" value={lastName} onChange={(e) => setLastName(e.target.value)}>Last Name</label>
                                                </div>
                                                <div className="form-outline mb-4">
                                                    <input type="password" id="form2Example27" className="form-control form-control-lg" />
                                                    <label className="form-label" htmlFor="form2Example27" value={firstName} onChange={(e) => setFirstName(e.target.value)}>First Name</label>
                                                </div>
                                                <div className="form-outline mb-4">
                                                    <input type="password" id="form2Example27" className="form-control form-control-lg" />
                                                    <label className="form-label" htmlFor="form2Example27" value={phone} onChange={(e) => setPhone(e.target.value)}>Phone</label>
                                                </div>

                                                <div className="pt-1 mb-4">
                                                    <button className="btn btn-danger btn-lg btn-block" type="button" onClick={validate}>Sign In</button>
                                                </div>
                                                <a href="#!" className="small text-muted">Terms of use.</a>
                                                <a href="#!" className="small text-muted">Privacy policy</a>
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

