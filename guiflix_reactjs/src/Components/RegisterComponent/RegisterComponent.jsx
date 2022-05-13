import React from 'react';
import { useState } from 'react';
import "./registercomponent.css";
import Logo from "../../Assets/LogoGuiFlix.png";
import { Link } from 'react-router-dom';

export default function RegisterComponent() {
    const validEmail = new RegExp(
        '^[a-zA-Z0-9._:$!%-]+@[a-zA-Z0-9.-]+.[a-zA-Z]+$'
    );
    const validPassword = new RegExp('^(?=.*?[A-Za-z])(?=.*?[0-9]).{6,}$');
    const validLastName = new RegExp('^[A-Z]{1}[a-zA-Z\\séèë\\-_]*$');
    const validFirstName = new RegExp('^[A-Z]{1}[a-zA-Z\\séèë\\-_]*$');
    const validPhone = new RegExp('^([0|\\+33|33]+)(\\.|\\-|\\s)?([1-9]{1})((\\.|\\-|\\s)?[0-9]{2}){4}$');
    const validHasNumber = new RegExp("[0-9]{2}");
    const validHasUpperChar = new RegExp("[A-Z]{2}");
    const validHasMiniMaxChars = new RegExp(".{8,15}");
    const validHasLowerChar = new RegExp("[a-z]{2}");
    const validHasSymbols = new RegExp("[!@#$%^&*()_+=\\[{\\]};:<>|./?,-]{2}");
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
    const [lastName, setLastName] = useState('');
    const [firstName, setFirstName] = useState('');
    const [phone, setPhone] = useState('');


    const [fragmentError, setFragmentError] = useState(<></>);


    const validate = () => {
        let errrorlist = [];
        if (!validEmail.test(email)) {
            errrorlist.push(<p className="text-danger">Your Email is invalid</p>)
        }
        if (!validPassword.test(password)) {
            errrorlist.push(<p className="text-danger">Password should not be empty</p>)
        }
        if (!validHasNumber.test(password)) {
            errrorlist.push(<p className="text-danger">Password should contain At least two numeric values</p>)
        }
        if (!validHasUpperChar.test(password)) {
            errrorlist.push(<p className="text-danger">Password should contain At least two upper case letters</p>)
        }
        if (!validHasMiniMaxChars.test(password)) {
            errrorlist.push(<p className="text-danger">Password should not be less than 8 characters and greater than 15 characters</p>)
        }
        if (!validHasLowerChar.test(password)) {
            errrorlist.push(<p className="text-danger">Password should contain At least two lower case letters</p>)
        }
        if (!validHasSymbols.test(password)) {
            errrorlist.push(<p className="text-danger">Password should contain At least two special case characters</p>)
        }
        if (!validLastName.test(lastName)) {
            errrorlist.push(<p className="text-danger">Your LastName is invalid</p>)
        }
        if (!validFirstName.test(firstName)) {
            errrorlist.push(<p className="text-danger">Your FirstName is invalid</p>)
        }
        if (!validPhone.test(phone)) {
            errrorlist.push(<p className="text-danger">Your Phone is invalid</p>)
        }
        setFragmentError(
            <>
                {errrorlist.map((e) => {
                    return (
                        e
                    )
                })}
            </>
        )
    };
    return (
        <div className="registerview">
            <section className="vh-100">
                <div className="col-md-6 col-lg-5 d-none d-md-block">
                    <Link to="/">
                        <img src={Logo}
                            alt="GuiFlix_Logo" className="logo" />
                    </Link>
                </div>
                <div className="container py-5 h-100">
                    <div className="row d-flex justify-content-center align-items-center h-100">
                        <div className="col col-xl-10">
                            <div className="cardBord"  >
                                <div className="row g-0">
                                    <div className="col-md-6 col-lg-7 d-flex align-items-center">
                                        <div className="card-body p-8 p-lg-7 text-white">
                                            <form>
                                                <h5 className="fw-normal mb-3 pb-3" >Sign Up</h5>
                                                <div className="form-outline mb-4">
                                                    <input type="email" id="form2Example17" className="form-control form-control-lg" />
                                                    <label className="form-label" htmlFor="form2Example17" value={email} onChange={(e) => setEmail(e.target.value)}>Email address</label>
                                                </div>
                                                <div className="form-outline mb-4">
                                                    <input type="password" id="form2Example27" className="form-control form-control-lg" />
                                                    <label className="form-label" htmlFor="form2Example27" value={password} onChange={(e) => setPassword(e.target.value).SetHasNumber(e.target.value).setHasLowerChar(e.target.value).setHasMiniMaxChar(e.target.value).setHasSymbols(e.target.value).setHasUpperChar(e.target.value)}>Password</label>
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
                                                    <button className="btn btn-danger btn-lg btn-block" type="button" onClick={validate}>Sign Up</button>
                                                </div>
                                                <a href="#!" className="small text-muted">Terms of use.</a>
                                                <a href="#!" className="small text-muted">Privacy policy</a>
                                            </form>
                                            {fragmentError}
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