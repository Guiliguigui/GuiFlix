import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import React, { useEffect,useState } from 'react';
import {get, post } from "../../Service/Service";

export default function LikeComponent(props) {
    const [type,setType]=useState('');
    const [profileId,setProfileId]=useState('');
    const [mediaId,setMediaId]=useState('');
    const JWT = localStorage.getItem("GuiFlix_JWT");

    post("Like",
        {
            type,
            profileId,
            mediaId
        },
        {
            headers: { Authorization: `Bearer ${JWT}` }
        }
    )
        .then(res => {
            if (props.mediaId !== res.data.mediaId) {
                localStorage.setItem(LikeComponent);
            }
        })
        .catch((err) => {

        })

    useEffect(() => {
        get("Like").then((res) => {
            // setLike(res.data);
        })
    }, [])

    return (
        <>
            <button>
                <FontAwesomeIcon icon='fa-regular fa-thumbs-downs' />
            </button>
            <button>
                <FontAwesomeIcon icon='fa-regular fa-thumbs-up' />
            </button>
        </>
    );
}


