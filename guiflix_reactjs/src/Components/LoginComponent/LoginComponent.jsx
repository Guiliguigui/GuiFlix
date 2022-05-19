import React, { useState } from 'react';
import { Link, useNavigate } from 'react-router-dom';
import "./logincomponent.css";
import { post } from "../../Service/Service";
import { Modal, Button } from "react-bootstrap";
// import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
// import { faEye } from "@fortawesome/free-solid-svg-icons";
// import { faEyeSlash } from "@fortawesome/free-solid-svg-icons";


export default function LoginComponent() {
    const [email, setEmail] = useState('');
    const [passwordType, setPasswordType] = useState("password");
    const [password, setPassword] = useState("");
    const [showModal, setShowModal] = useState(false);
    const [modalErrorMessage, setModalErrorMessage] = useState('Input Empty');
    const navigate = useNavigate();

    

    const validate = () => {
        console.log("nimmememe")
        post('Authentication/User/Login', {
            email, password
        })
            .then(
                res => {
                    if (res.data.isAuthSuccessful) {
                        localStorage.setItem("GuiFlix_JWT", res.data.token)
                        navigate("/profile")
                    }
                    else {
                        setShowModal(true)
                        setModalErrorMessage(res.data.errorMessage)
                    }
                })
            .catch(err => {
                setShowModal(true)
            })
    }
    return (
        <>
            <div className="cardBord d-flex justify-content-center align-items-center rounded"  >
                <div className="col-md-6 col-lg-15 d-flex align-items-center">
                    <div className="card-body rounded zp-8 p-lg-10 text-white mt-0">
                        <form onSubmit={(e)=>{validate(); e.preventDefault()}}>
                            <h3 className="fw-normal mb-5 text-start" >Sign In</h3>
                            <div className="form-outline mb-4">
                                <input type="email" id="form2Example17" value={email} onChange={(e) => setEmail(e.target.value)} placeholder='Email-Address' className="form-control text-light bg-dark form-control-lg" />
                            </div>
                            <div className="form-outline mb-4 d-flex flex-row bd-highlight mb-3">
                                <input type={passwordType} placeholder='Password' value={password} onChange={(e) => setPassword(e.target.value)} className="form-control form-control-lg text-light bg-dark" />
                                {/* <button className="btn btn-outline-primary" onClick={togglePassword}>
                                        {passwordType === "password" ? <FontAwesomeIcon icon={faEye} className="color-red"></FontAwesomeIcon> : <FontAwesomeIcon icon={faEyeSlash} className="color-red"></FontAwesomeIcon>}
                                    </button> */}
                            </div>
                            <div className="pt-7 mb-4">
                                <button className="btn w-100 btn-danger btn-block btn-lg flex-fill" type="submit" >Sign In</button>
                            </div>
                            <div className='p-2 text-start'>
                                <p className="mb-0 push text-muted text-start" >New on GuiFlix ? <Link className="link-light" to="/register">Register Here</Link></p>
                                <a className="small text-muted">Forgot password?</a><br />
                                <a className="small text-muted">Terms of use.</a>
                                <a className="small text-muted">Privacy policy</a>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
            <Modal className="mymodal text-white" show={showModal}>
                <Modal.Header closeButton>
                    <Modal.Title>Login Error</Modal.Title>
                </Modal.Header>
                <Modal.Body >
                    {modalErrorMessage}

                </Modal.Body>
                <Modal.Footer>
                    <Button variant="danger" onClick={(e) => setShowModal(false)}>
                        Close
                    </Button>
                </Modal.Footer>
            </Modal>
        </>
    );
}

