import React from 'react';
import "./profilesview.css";
import { useNavigate } from 'react-router-dom';
import { get, post } from '../../Service/Service';
import { faCirclePlus} from "@fortawesome/free-solid-svg-icons";
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'

export default function ProfilesView(props) {
    const navigate = useNavigate();

    function selectProfile(id){
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

    function sendNewProfile(){
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
                headers: {Authorization : `Bearer ${JWT}`}
            }).then(
                res => {
                    window.location.reload();
                }
            )
        }
    }

    return (
        <div className='container-fluid profiles align-items-center justify-content-center'>
            {props.account.profiles.map((profile, key) => (
                <div key={key} className='profile' onClick={e => selectProfile(profile.id)}>
                    <img src={profile.avatarLink} alt={profile.userName} />
                    <h2>{profile.userName}</h2>
                </div>
            ))}
            <div className='profile' onClick={e => sendNewProfile()}>
                <FontAwesomeIcon icon={faCirclePlus}/>
                <h2>Nouveau</h2>
            </div>
        </div>
    );
}