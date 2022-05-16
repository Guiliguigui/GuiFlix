import React from "react";
import LoginComponent from "../../Components/LoginComponent/LoginComponent";
import Logo from "../../Assets/LogoGuiFlix.png";
import { Link } from "react-router-dom";


const LoginView = () => {
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
                            <LoginComponent />
                        </div>
                    </div>
                </div>
            </section>
        </div>
    );
}

export default LoginView;