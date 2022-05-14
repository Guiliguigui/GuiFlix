import React, { useState } from 'react';
import { Link } from 'react-router-dom';
import "./logincomponent.css";
import Logo from "../../Assets/LogoGuiFlix.png";
import { post } from "../../Service/Service";


export default function LoginComponent() {

    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');

    const validate = () => {
        post('Authentication/User/Login', {
            email,password
        })

    };


    return (
        <div className="loginview">
            <section className="vh-100">
                <div className="col-md-6 col-lg-5 d-flex d-md-block">
                    <Link to="/">
                        <img src={Logo}
                            alt="GuiFlix_Logo" className="logo" />
                    </Link>
                </div>
                <div className="container py-5 h-100">
                    <div className="row d-flex justify-content-center align-items-center h-100">
                        <div className="col-6 col-lg-10 ">
                            <div className="cardBord d-flex justify-content-center align-items-center"  >
                                <div className="col-md-6 col-lg-15 d-flex align-items-center">
                                    <div className="card-body p-8 p-lg-10 text-white">
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
                                                <button className="btn btn-danger btn-lg btn-block" type="button" onClick={validate}>Login</button>
                                            </div>
                                            <a className="small text-muted" href="#!">Forgot password?</a>
                                            <p className="mb-5 pb-lg-2" >New on GuiFlix ? <Link className="small text-muted" to="/register">Register Here</Link></p>
                                            <a href="#!" className="small text-muted">Terms of use.</a>
                                            <a href="#!" className="small text-muted">Privacy policy</a>
                                        </form>
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

