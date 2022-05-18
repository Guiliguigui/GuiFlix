import React, { useState } from 'react';
import "./profilesview.css";
import { useNavigate } from 'react-router-dom';
import { get, post, supprime } from '../../Service/Service';
import { faCirclePlus, faEraser } from "@fortawesome/free-solid-svg-icons";
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { Modal, Button } from "react-bootstrap";


export default function ProfilesView(props) {
    const [isSure, setIsSure] = useState(true);
    const [showModal, setShowModal] = useState(false);
    const navigate = useNavigate();

    function selectProfile(id) {
        const JWT = localStorage.getItem("GuiFlix_JWT");
        get("Profile/" + id,
            {
                headers: { Authorization: `Bearer ${JWT}` }
            }
        ).then(
            res => {
                props.setProfileSelected(res.data)
                navigate("/navigation")
            }
        ).catch(
            err => {
                console.error(err);
            }
        );
    }

    function sendNewProfile() {
        const profileName = prompt("Please enter the name of the profile");
        if (profileName !== null) {
            const JWT = localStorage.getItem("GuiFlix_JWT");
            post("Profile",
                {
                    userName: profileName,
                    avatarLink: "https://upload.wikimedia.org/wikipedia/commons/0/0b/Netflix-avatar.png",
                    accountId: props.account.id
                },
                {
                    headers: { Authorization: `Bearer ${JWT}` }
                }).then(
                    res => {
                        window.location.reload();
                    }
                )
        }
    }

    async function deleteProfile(id) {
        const JWT = localStorage.getItem("GuiFlix_JWT");
        supprime("Profile/" + id,
            {
                headers: { Authorization: `Bearer ${JWT}` }
            }
        ).then(res => {
            // setShowModal(true)
            if (!isSure) {


                window.location.reload();
            }
            else {
                props.setProfileSelected(res.headers);
                window.location.reload();
            }
        })
            .catch(err => {
                err.setErrorMessage(err.message);
                console.error('There was an error!', err);
            });
    }
    return (
        <div className='container-fluid profiles align-items-center justify-content-center'>
            {props.account.profiles.map((profile, key) => (
                <div key={key}>
                    <div className='profile' onClick={e => selectProfile(profile.id)}>
                        <img src={profile.avatarLink} alt={profile.userName} />
                        <h2>{profile.userName}</h2>
                    </div>
                    <div key={key} onClick={e => deleteProfile(profile.id)} className="text-danger mt-50 fa-2xl"><FontAwesomeIcon icon={faEraser} /></div>
                </div>
            ))}
            <div className='profile' onClick={e => sendNewProfile()}>
                <FontAwesomeIcon icon={faCirclePlus} />
                <h2>Nouveau</h2>
            </div>
            <Modal className="mymodal text-white" show={showModal}>
                <Modal.Header closeButton>
                    <Modal.Title>Delete Profile ?</Modal.Title>
                </Modal.Header>
                <Modal.Body >
                    <h4>Are You Sure to delete this profile</h4>
                </Modal.Body>
                <Modal.Footer>
                    <Button variant="danger" onClick={(e) => {
                        setShowModal(false)
                        setIsSure(true)
                    }}>
                        Yes
                    </Button>
                    <Button variant="danger" onClick={(e) => {
                        setShowModal(false)

                    }}>
                        No
                    </Button>
                </Modal.Footer>
            </Modal>
        </div>

    );
}