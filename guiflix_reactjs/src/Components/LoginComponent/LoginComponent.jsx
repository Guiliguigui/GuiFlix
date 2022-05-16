import React, { useState } from 'react';
import { Link, useNavigate } from 'react-router-dom';
import "./logincomponent.css";
import { post } from "../../Service/Service";
import { Modal, Button } from "react-bootstrap";

// token dans localstorage account dans le redux state

export default function LoginComponent() {
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
    const [showModal, setShowModal] = useState(false);
    const [modalErrorMessage, setModalErrorMessage] = useState('Input Empty');
    const navigate = useNavigate();


    const validate = () => {
        post('Authentication/User/Login', {
            email, password
        }).then(
            res => {
                if (res.data.isAuthSuccessful) {
                    localStorage.setItem("GuiFlix_JWT", res.data.token)
                    localStorage.setItem("GuiFlix_Account", res.data.account)
                    navigate("/profile")
                }
                else {
                    setShowModal(true)
                    setModalErrorMessage(res.data.errorMessage)
                }
            })
    }

    return (
        <>
            <div className="cardBord d-flex justify-content-center align-items-center"  >
                <div className="col-md-6 col-lg-15 d-flex align-items-center">
                    <div className="card-body p-8 p-lg-10 text-white">
                        <form>
                            <h5 className="fw-normal mb-3 pb-3" >Sign In</h5>

                            <div className="form-outline mb-4">
                                <input type="email" id="form2Example17" value={email} onChange={(e) => setEmail(e.target.value)} placeholder='Email-Address' className="form-control bg-dark form-control-lg" />
                            </div>

                            <div className="form-outline mb-4">
                                <input type="password" placeholder='Password' value={password} onChange={(e) => setPassword(e.target.value)} className="form-control form-control-lg bg-dark" />
                            </div>

                            <div className="pt-7 mb-4">
                                <button className="btn btn-danger btn-block btn-lg flex-fill" type="button" onClick={validate}>Sign In</button>
                            </div>
                            <div className='d-flex flex-column bd-highlight mb-3'>
                                <p className="mb-0 p-2 text-muted bd-highlight" >New on GuiFlix ? <Link className="link-light" to="/register">Register Here</Link></p>
                                <a className="small text-muted p-2 bd-highlight" href="#!">Forgot password?</a><br />
                                <a href="#!" className="small text-muted p-2 bd-highlight">Terms of use.</a>
                                <a href="#!" className="small text-muted p-2 bd-highlight">Privacy policy</a>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
            <Modal className="mymodal text-white" show={showModal}>
                <Modal.Header closeButton>
                    <Modal.Title>Registeration Error</Modal.Title>
                </Modal.Header>
                <Modal.Body >{modalErrorMessage}
                    <Button variant="danger" onClick={(e) => setShowModal(false)}>
                        Close
                    </Button>
                </Modal.Body>
            </Modal>
        </>
    );
}

