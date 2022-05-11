import React, { useState } from 'react';
import { Link } from 'react-router-dom';


export default function LoginComponent() {
    const validEmail = new RegExp(
        '^[a-zA-Z0-9._:$!%-]+@[a-zA-Z0-9.-]+.[a-zA-Z]$'
    );
    const validPassword = new RegExp('^(?=.*?[A-Za-z])(?=.*?[0-9]).{6,}$');
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
    const [emailErr, setEmailErr] = useState(false);
    const [pwdError, setPwdError] = useState(false);
    const validate = () => {
        if (!validEmail.test(email)) {
            setEmailErr(true);
        }
        if (!validPassword.test(password)) {
            setPwdError(true);
        }
    };
    const onValid=()=>{}

    return (
        <div className="loginview">
            {/* <section className="vh-100 card"> */}
                <div className="container py-5 h-100">
                    <div className="row d-flex justify-content-center align-items-center h-100">
                        <div className="col col-xl-10">
                            <div className="cardBord">
                                <div className="row g-0">
                                    <div className="col-md-6 col-lg-5 d-none d-md-block">
                                        <img src="../../Assets/LogoGuiFlix.png"
                                            alt="GuiFlix_Logo" />
                                    </div>
                                    <div className="col-md-6 col-lg-7 d-flex align-items-center">
                                        <div className="card-body p-4 p-lg-5 text-black">

                                            <form>
                                                <h5 className="fw-normal mb-3 pb-3" >Sign In</h5>

                                                <div className="form-outline mb-4">
                                                    <input type="email" id="form2Example17" className="form-control form-control-lg" />
                                                    <label className="form-label" htmlFor="form2Example17" value={email} onChange={(e) => setEmail(e.target.value)}>Email address</label>
                                                </div>

                                                <div className="form-outline mb-4">
                                                    <input type="password" id="form2Example27" className="form-control form-control-lg" />
                                                    <label className="form-label" htmlFor="form2Example27" value={password} onChange={(e) => setPassword(e.target.value)}>Password</label>
                                                </div>

                                                <div className="pt-1 mb-4">
                                                    <button className="btn btn-danger btn-lg btn-block" type="button" onClick={validate} onChange={onValid}>Login</button>
                                                </div>
                                                <a className="small text-muted" href="#!">Forgot password?</a>
                                                <p className="mb-5 pb-lg-2" >New on GuiFlix ? <Link className="small text-muted" to="/register">Register Here</Link></p>
                                                <a href="#!" className="small text-muted">Terms of use.</a>
                                                <a href="#!" className="small text-muted">Privacy policy</a>
                                            </form>
                                            {emailErr && <p>Your email is invalid</p>}
                                            {pwdError && <p>Your password is invalid</p>}
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            {/* </section> */}
        </div>
    );
}

