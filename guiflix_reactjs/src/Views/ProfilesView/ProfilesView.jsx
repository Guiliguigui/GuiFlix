import React from 'react';
import "./profilesview.css";
import { useNavigate } from 'react-router-dom';
import { get } from '../../Service/Service';

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

    return (
        <div className='profiles align-items-center justify-content-center'>
            {props.account.profiles.map((profile, key) => (
                <div key={key} className='profile' onClick={e => selectProfile(profile.id)}>
                    <img src={profile.avatarLink} alt={profile.userName} />
                    <h2>{profile.userName}</h2>
                </div>
            ))}
            {/* ajout d'un nouveau profil */}
        </div>
    );
}