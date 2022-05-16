import React from 'react';
import { useState } from 'react';
import "./registercomponent.css";
import { useNavigate } from 'react-router-dom';
import { post } from "../../Service/Service";
import { Modal, Button } from "react-bootstrap";

export default function RegisterComponent() {
    const validEmail = new RegExp('^[a-zA-Z0-9._:$!%-]+@[a-zA-Z0-9.-]+.[a-zA-Z]+$');
    const validPassword = new RegExp('^(?=.*?[A-Za-z])(?=.*?[0-9]).{6,}$');
    const validLastName = new RegExp('^[A-Z]{1}[a-zA-Z\\séèë\\-_]*$');
    const validFirstName = new RegExp('^[A-Z]{1}[a-zA-Z\\séèë\\-_]*$');
    const validPhone = new RegExp('^([0|\\+33|33]+)(\\.|\\-|\\s)?([1-9]{1})((\\.|\\-|\\s)?[0-9]{2}){4}$');
    const validHasNumber = new RegExp("[0-9]{2}");
    const validHasUpperChar = new RegExp("[A-Z]{2}");
    const validHasMiniMaxChars = new RegExp(".{8,15}");
    const validHasLowerChar = new RegExp("[a-z]{2}");
    const validHasSymbols = new RegExp("[!@#$%^&*()_+=\\[{\\]};:<>|./?,-]{2}");

    const [email, setEmail] = useState("");
    const [password, setPassword] = useState("");
    const [lastName, setLastName] = useState("");
    const [firstName, setFirstName] = useState("");
    const [phone, setPhone] = useState("");

    const [showModal, setShowModal] = useState(false);
    const [modalErrorMessage, setModalErrorMessage] = useState('');

    const [fragmentError, setFragmentError] = useState(<></>);

    const navigate = useNavigate();


    const validate = () => {
        let errorList = [];
        if (!validEmail.test(email)) {
            errorList.push(<p className="text-danger">Your Email is invalid</p>)
        }
        if (!validPassword.test(password)) {
            errorList.push(<p className="text-danger">Password should not be empty</p>)
        }
        else {
            if (!validHasNumber.test(password)) {
                errorList.push(<p className="text-danger">Password should contain At least two numeric values</p>)
            }
            if (!validHasUpperChar.test(password)) {
                errorList.push(<p className="text-danger">Password should contain At least two upper case letters</p>)
            }
            if (!validHasMiniMaxChars.test(password)) {
                errorList.push(<p className="text-danger">Password should not be less than 8 characters and greater than 15 characters</p>)
            }
            if (!validHasLowerChar.test(password)) {
                errorList.push(<p className="text-danger">Password should contain At least two lower case letters</p>)
            }
            if (!validHasSymbols.test(password)) {
                errorList.push(<p className="text-danger">Password should contain At least two special case characters</p>)
            }
        }
        if (!validLastName.test(lastName)) {
            errorList.push(<p className="text-danger">Your LastName is invalid</p>)
        }
        if (!validFirstName.test(firstName)) {
            errorList.push(<p className="text-danger">Your FirstName is invalid</p>)
        }
        if (!validPhone.test(phone)) {
            errorList.push(<p className="text-danger">Your Phone is invalid</p>)
        }
        setFragmentError(
            <>
                {errorList.map((e, index) => {
                    return (
                        <div key={index}>{e}</div>
                    )
                })}
            </>
        )
        if (errorList.length === 0) {
            post('Authentication/User/Register', {
                email, password, lastName, firstName, phone
            }).then(
                res => {
                    if (res.data.isRegisterationSuccessful) {
                        navigate("/login")
                    }
                    else {
                        setShowModal(true)
                        setModalErrorMessage(res.data.errorMessage)
                    }
                })
        }

    };
    return (
        <>
            <div className="cardBord d-flex justify-content-center align-items-center"  >
                <div className="col-md-6 col-lg-15 d-flex align-items-center">
                    <div className="card-body p-8 p-lg-10 text-white">
                        <form>
                            <h5 className="fw-normal mb-3 pb-3" >Sign Up</h5>
                            <div className="form-outline mb-4">
                                <input type="email" id="form2Example17" value={email} onChange={(e) => setEmail(e.target.value)} className="form-control form-control-lg" />
                                <label className="form-label" htmlFor="form2Example17" >Email address</label>
                            </div>
                            <div className="form-outline mb-4">
                                <input type="password" id="form2Example27" value={password} onChange={(e) => setPassword(e.target.value).SetHasNumber(e.target.value).setHasLowerChar(e.target.value).setHasMiniMaxChar(e.target.value).setHasSymbols(e.target.value).setHasUpperChar(e.target.value)} className="form-control form-control-lg" />
                                <label className="form-label" htmlFor="form2Example27" >Password</label>
                            </div>
                            <div className="form-outline mb-4">
                                <input type="text" id="form2Example27" value={lastName} onChange={(e) => setLastName(e.target.value)} className="form-control form-control-lg" />
                                <label className="form-label" htmlFor="form2Example27" >Last Name</label>
                            </div>
                            <div className="form-outline mb-4">
                                <input type="text" id="form2Example27" value={firstName} onChange={(e) => setFirstName(e.target.value)} className="form-control form-control-lg" />
                                <label className="form-label" htmlFor="form2Example27" >First Name</label>
                            </div>
                            <div className="form-outline mb-4">
                                <input type="text" id="form2Example27" value={phone} onChange={(e) => setPhone(e.target.value)} className="form-control form-control-lg" />
                                <label className="form-label" htmlFor="form2Example27" >Phone</label>
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